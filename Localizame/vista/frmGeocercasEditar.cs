using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using Localizame.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using System.Diagnostics;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Xml;
using Localizame.controlador;
using Microsoft.Data.SqlClient;

namespace Localizame.vista
{
    public partial class frmGeocercasEditar : Form
    {
        GMapMarker marker;
        GMapOverlay markerOverlay;
        private GMapOverlay markersOverlay = new GMapOverlay("marcadores");
        private GMapOverlay Geocerca = new GMapOverlay("Geocerca");
        private List<GMarkerGoogle> markers = new List<GMarkerGoogle>();
        connection cn = new connection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        double LatInicial = 6.207945;
        double LngInicial = -75.5928211;
        public int xClic, yClic;

        public double Latv1, Lognv1;

        int filaSeleccionada = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void dibujarGeocerca()
        {
            Geocerca.Polygons.Clear();
            List<PointLatLng> puntos = new List<PointLatLng>();

            double lng, lat;

            for (int filas = 0; filas < gridGeocercas.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(gridGeocercas.Rows[filas].Cells[2].Value);
                lng = Convert.ToDouble(gridGeocercas.Rows[filas].Cells[3].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            GMapPolygon geocercaPuntos = new GMapPolygon(puntos, "Geocerca");

            if (!gMapControl1.Overlays.Contains(Geocerca))
            {
                gMapControl1.Overlays.Add(Geocerca);
            }

            Geocerca.Polygons.Add(geocercaPuntos);

            gMapControl1.Refresh();

            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        public frmGeocercasEditar()
        {
            InitializeComponent();
            cbxGeocercas.DataSource = funciones_generales.llenarGeocercasEditar();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;


        }



        private void frmGestionRutas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClic = e.X; yClic = e.Y;

            }
            else
            {
                this.Left = this.Left + (e.X);
                this.Top = this.Top + (e.Y);

            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxGeocercas_SelectedValueChanged(object sender, EventArgs e)
        {
            string valorCbx = cbxGeocercas.SelectedItem.ToString();
            string[] marcadores = funciones_generales.cargarMarcadoresGeocercas(valorCbx);

            txtDescripcion.Text = valorCbx;

            funciones_generales.llenarDataViewGeocercas(gridGeocercas, valorCbx);
            gridGeocercas.Columns[0].HeaderText = "ID";
            gridGeocercas.Columns[1].HeaderText = "Nombre Polígono";
            gridGeocercas.Columns[2].Visible = false;
            gridGeocercas.Columns[3].Visible = false;

            markersOverlay.Markers.Clear();

            if (marcadores.Length > 0)
            {
                foreach (var marcador in marcadores)
                {
                    var parts = marcador.Replace("new PointLatLng(", "").Replace("),", "").Split('/');

                    double lng, lat;

                    lat = Convert.ToDouble(parts[0]);
                    lng = Convert.ToDouble(parts[1]);

                    marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
                    gMapControl1.Position = new PointLatLng(lat, lng);
                    markersOverlay.Markers.Add(marker);
                }
            }

            dibujarGeocerca();

            if (!gMapControl1.Overlays.Contains(markersOverlay))
            {
                gMapControl1.Overlays.Add(markersOverlay);
            }

            gMapControl1.Zoom = 18;
            gMapControl1.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridGeocercas.SelectedRows.Count > 0)
            {
                DataTable dataTable = (DataTable)gridGeocercas.DataSource;

                int rowIndex = gridGeocercas.SelectedRows[0].Index;

                double latitud = Convert.ToDouble(dataTable.Rows[rowIndex]["latitud"]);
                double longitud = Convert.ToDouble(dataTable.Rows[rowIndex]["longitud"]);

                dataTable.Rows[rowIndex].Delete();
                dataTable.AcceptChanges();
                gridGeocercas.DataSource = dataTable;

                var marcadorAEliminar = markersOverlay.Markers.FirstOrDefault(marker =>
                    Math.Abs(marker.Position.Lat - latitud) < 0.0001 && Math.Abs(marker.Position.Lng - longitud) < 0.0001);

                if (marcadorAEliminar != null)
                {
                    markersOverlay.Markers.Remove(marcadorAEliminar);
                    gMapControl1.Refresh();
                    dibujarGeocerca();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }


        private void gridGeocercas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                double latitud = Convert.ToDouble(gridGeocercas.Rows[e.RowIndex].Cells["latitud"].Value);
                double longitud = Convert.ToDouble(gridGeocercas.Rows[e.RowIndex].Cells["longitud"].Value);

                foreach (var markers in markersOverlay.Markers)
                {
                    if (markers.Position.Lat == latitud && markers.Position.Lng == longitud)
                    {
                        gMapControl1.Position = new PointLatLng(latitud, longitud);
                        break;
                    }
                }

                gMapControl1.Refresh();
            }
        }

        private void gMapControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            Latv1 = lat;
            Lognv1 = lng;

            GMarkerGoogle newMarker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green_dot);
            newMarker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);

            markers.Add(newMarker);
            markersOverlay.Markers.Add(newMarker);

            if (!gMapControl1.Overlays.Contains(markersOverlay))
            {
                gMapControl1.Overlays.Add(markersOverlay);
            }
            gMapControl1.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Introduce nombre de la ubicación");
            }
            else
            {
                DataTable dt = gridGeocercas.DataSource as DataTable;
                int nuevoId = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Compute("MAX(id)", "")) + 1 : 1;
                dt.Rows.Add(nuevoId, txtDescripcion.Text, Latv1, Lognv1);
                dibujarGeocerca();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((gridGeocercas.Rows.Count <= 3))
            {
                return;
            }

            string valorCbx = cbxGeocercas.SelectedItem.ToString();

            string query2 = "DELETE FROM Geocercas WHERE nombrePoligono=@nombrePoligono";
            SqlCommand cmd2 = new SqlCommand(query2, cn.AbrirConexion());
            cmd2.Parameters.AddWithValue("@nombrePoligono", valorCbx);
            cmd2.ExecuteNonQuery();

            int filasAfectadas = 0;
            string query = "INSERT INTO Geocercas (nombrePoligono, latitud, longitud, idUsuario) VALUES (@nombrePoligono, @latitud, @longitud, @idUsuario)";
            SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());

            foreach (DataGridViewRow row in gridGeocercas.Rows)
            {
                cmd.Parameters.Clear();

                string latitudInt = Convert.ToString(row.Cells["latitud"].Value);
                string longitudInt = Convert.ToString(row.Cells["longitud"].Value);

                cmd.Parameters.AddWithValue("@nombrePoligono", Convert.ToString(row.Cells[1].Value));
                cmd.Parameters.AddWithValue("@latitud", latitudInt);
                cmd.Parameters.AddWithValue("@longitud", longitudInt);
                cmd.Parameters.AddWithValue("@idUsuario", funciones_generales.getIdUsuario());

                filasAfectadas = cmd.ExecuteNonQuery();
            }

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se ingresaron los datos satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            cn.CerrarConexion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }
    }
}
