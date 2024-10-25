using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Localizame.controlador;
using Localizame.modelo;
using Microsoft.Data.SqlClient;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;
using FontStyle = System.Drawing.FontStyle;

namespace Localizame.modelo
{
    public class Geocerca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Punto> Puntos { get; set; } = new List<Punto>();

        public class Punto
        {
            public double Latitud { get; set; }
            public double Longitud { get; set; }

            public override string ToString()
            {
                return $"({Latitud}, {Longitud})";
            }
        }

        private static readonly SqlConnection conexion = new connection().AbrirConexion();

        public static List<Geocerca> CargarGeocercas()
        {
            var geocercas = new Dictionary<string, Geocerca>();

            const string query = @"SELECT id, nombrePoligono, latitud, longitud 
                             FROM Geocercas 
                             ORDER BY nombrePoligono";

            using (var cmd = new SqlCommand(query, conexion))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nombre = reader["nombrePoligono"].ToString();

                    var latitud = Convert.ToDouble(reader["latitud"].ToString().Replace(',', '.'),
                        System.Globalization.CultureInfo.InvariantCulture);
                    var longitud = Convert.ToDouble(reader["longitud"].ToString().Replace(',', '.'),
                        System.Globalization.CultureInfo.InvariantCulture);

                    if (!geocercas.TryGetValue(nombre, out var geocerca))
                    {
                        geocerca = new Geocerca
                        {
                            Nombre = nombre
                        };
                        geocercas[nombre] = geocerca;
                    }

                    geocerca.Puntos.Add(new Punto
                    {
                        Latitud = latitud,
                        Longitud = longitud
                    });
                }
            }

            return geocercas.Values.ToList();
        }

        private static bool PuntoEnPoligono(double lat, double lon, List<Punto> vertices)
        {
            if (vertices == null || vertices.Count < 3)
                return false;

            int i, j;
            bool resultado = false;
            for (i = 0, j = vertices.Count - 1; i < vertices.Count; j = i++)
            {
                if ((vertices[i].Latitud > lat) != (vertices[j].Latitud > lat) &&
                    (lon < (vertices[j].Longitud - vertices[i].Longitud) * (lat - vertices[i].Latitud) /
                    (vertices[j].Latitud - vertices[i].Latitud) + vertices[i].Longitud))
                {
                    resultado = !resultado;
                }
            }

            return resultado;
        }

        public static void CargarRutasConGeocercas(DataGridView grd, string placa, DateTime fechaInicio, DateTime fechaFin)
        {
            var geocercas = CargarGeocercas();

            const string query = @"SELECT p.placa, p.latitud, p.longitud, p.fechaHora, p.operador,
                                    p.propietario, p.ruta
                             FROM pasoVehiculos p
                             WHERE p.placa = @placa
                             AND p.fechaHora BETWEEN @fechaInicio AND @fechaFin
                             ORDER BY p.fechaHora";

            var dt = new DataTable();
            dt.Columns.Add("Placa");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Geocerca");
            dt.Columns.Add("Conductor");
            dt.Columns.Add("Ruta");
            dt.Columns.Add("EstaEnGeocerca", typeof(bool));

            using (var cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var latitudStr = reader["latitud"].ToString().Replace(',', '.');
                        var longitudStr = reader["longitud"].ToString().Replace(',', '.');

                        var latitud = Convert.ToDouble(latitudStr,
                            System.Globalization.CultureInfo.InvariantCulture);
                        var longitud = Convert.ToDouble(longitudStr,
                            System.Globalization.CultureInfo.InvariantCulture);

                        var fechaHora = Convert.ToDateTime(reader["fechaHora"]);

                        string geocercaNombre = "Fuera de Geocerca";
                        bool estaEnGeocerca = false;

                        foreach (var geocerca in geocercas)
                        {
                            if (PuntoEnPoligono(latitud, longitud, geocerca.Puntos))
                            {
                                geocercaNombre = geocerca.Nombre;
                                estaEnGeocerca = true;
                                break;
                            }
                        }

                        dt.Rows.Add(
                            reader["placa"],
                            fechaHora.ToString("dd/MM/yyyy"),
                            fechaHora.ToString("HH:mm:ss"),
                            geocercaNombre,
                            reader["operador"],
                            reader["ruta"],
                            estaEnGeocerca
                        );
                    }
                }
            }

            grd.DataSource = dt;

            grd.Columns["EstaEnGeocerca"].Visible = false;

            ConfigurarFormatoGrid(grd);

            grd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private static void ConfigurarFormatoGrid(DataGridView grd)
        {
            // Establecer colores y estilos base
            grd.EnableHeadersVisualStyles = false;
            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font(grd.Font, FontStyle.Bold);
            grd.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            grd.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var grid = sender as DataGridView;
                    var row = grid.Rows[e.RowIndex];
                    bool estaEnGeocerca = Convert.ToBoolean(row.Cells["EstaEnGeocerca"].Value);

                    if (estaEnGeocerca)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        // Restaurar el color normal
                        row.DefaultCellStyle.BackColor = e.RowIndex % 2 == 0 ? Color.White : Color.WhiteSmoke;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            };

            foreach (DataGridViewColumn col in grd.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (grd.Columns.Contains("Fecha"))
                grd.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (grd.Columns.Contains("Hora"))
                grd.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}