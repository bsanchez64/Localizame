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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Localizame.vista
{
    public partial class frmGeocercasEliminar : Form
    {
        GMapMarker marker;
        GMapOverlay markerOverlay;
        private GMapOverlay markersOverlay = new GMapOverlay("marcadores");
        private GMapOverlay Geocerca = new GMapOverlay("Geocerca");
        private List<GMarkerGoogle> markers = new List<GMarkerGoogle>();
        connection cn = new connection();
        SqlDataAdapter da;
        SqlCommand cmd;
        string nombreGeocerca;

        double LatInicial = 6.207945;
        double LngInicial = -75.5928211;
        public int xClic, yClic;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public frmGeocercasEliminar()
        {
            InitializeComponent();
            CargarGeocercas();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;
            cbxGeocercas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGeocercas()
        {
            cbxGeocercas.Items.Clear();
            var geocercas = funciones_generales.llenarGeocercasEditar();

            foreach (var geocerca in geocercas)
            {
                cbxGeocercas.Items.Add(geocerca);
            }
        }

        private void dibujarGeocerca()
        {
            {
                Geocerca.Polygons.Clear();
                List<PointLatLng> puntos = new List<PointLatLng>();
                string query = "SELECT latitud, longitud FROM Geocercas";

                try
                {
                    connection cn = new connection();
                    using (SqlConnection connection = cn.AbrirConexion())
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            double lat = Convert.ToDouble(reader["latitud"]);
                            double lng = Convert.ToDouble(reader["longitud"]);
                            puntos.Add(new PointLatLng(lat, lng));
                        }

                        reader.Close();
                    }

                    // Cerrar el polígono
                    if (puntos.Count > 0)
                    {
                        puntos.Add(puntos[0]); // Añadir el primer punto al final
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
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al dibujar la geocerca: " + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGeocercasEliminar_MouseMove(object sender, MouseEventArgs e)
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

        private void cbxGeocercas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxGeocercas.SelectedItem != null)
            {
                string valorCbx = cbxGeocercas.SelectedItem.ToString();
                string[] marcadores = funciones_generales.cargarMarcadoresGeocercas(valorCbx);
                markersOverlay.Markers.Clear();

                if (marcadores.Length > 0)
                {
                    GMapOverlay overlay = new GMapOverlay(valorCbx);

                    List<(double latitud, double longitud)> posiciones = funciones_generales.cargarPoligonos(valorCbx);
                    List<PointLatLng> puntosPoligono = new List<PointLatLng>();

                    foreach (var (latitud, longitud) in posiciones)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.blue_dot);
                        overlay.Markers.Add(marker);

                        puntosPoligono.Add(new PointLatLng(latitud, longitud));
                        gMapControl1.Position = new PointLatLng(latitud, longitud);
                    }

                    GMapPolygon poligono = new GMapPolygon(puntosPoligono, valorCbx);

                    poligono.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));
                    poligono.Stroke = new Pen(Color.Blue, 2);

                    overlay.Polygons.Add(poligono);

                    gMapControl1.Overlays.Add(overlay);

                    gMapControl1.Zoom = -12;
                    gMapControl1.Refresh();
                    gMapControl1.Zoom = 12;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbxGeocercas.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una geocerca antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de borrar esta geocerca?", "Borrar Geocerca", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialogResult == DialogResult.Yes)
            {
                nombreGeocerca = cbxGeocercas.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("DELETE FROM Geocercas WHERE nombrePoligono = @nombrePoligono", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@nombrePoligono", nombreGeocerca);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se eliminó la geocerca con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Remover el ítem del ComboBox
                    cbxGeocercas.Items.Remove(nombreGeocerca);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna geocerca con este nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.CerrarConexion();
            }
        }

        private void frmGeocercasEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}

