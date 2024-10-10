using GMap.NET;
using GMap.NET.MapProviders;
﻿using Microsoft.Data.SqlClient;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Localizame.modelo;
using System.Data;
using Localizame.controlador;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Localizame.vista
{
    public partial class frmGeocercas : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        private GMapOverlay Geocerca = new GMapOverlay("Geocerca");
        connection cn = new connection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        int filaSeleccionada = 0;
        double LatInicial = 6.1711964;
        double LngInicial = -75.6514894;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public frmGeocercas()
        {
            InitializeComponent();
        }

        private void dibujarGeocerca()
        {
            Geocerca.Polygons.Clear();
            List<PointLatLng> puntos = new List<PointLatLng>();

            double lng, lat;

            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
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


        private void frmGeocercas_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            dt.Rows.Add("Ubicación Inicial", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");

            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);

            markerOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gMapControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            gMapControl1.Position = marker.Position;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            if (marker == null)
            {
                marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);
                markerOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markerOverlay);
            }

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Introduce nombre de la ubicación");
            }
            else
            {

                if (string.IsNullOrEmpty(txtLatitud.Text) || string.IsNullOrEmpty(txtLongitud.Text))
                {
                    MessageBox.Show("Debes seleccionar una ubicación en el mapa");
                }
                else
                {
                    dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);// agregar a la tabla

                    dibujarGeocerca();

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               dataGridView1.Rows.RemoveAt(filaSeleccionada);
               dibujarGeocerca();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }


        }

        bool vai = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {

                this.Location = Cursor.Position;

            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGeocerca_Click(object sender, EventArgs e)
        {
            Geocerca.Polygons.Clear();
            List<PointLatLng> puntos = new List<PointLatLng>();

            double lng, lat;

            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            if (puntos.Count < 4)
            {
                MessageBox.Show("Debes agregar al menos 4 puntos para crear un polígono.");
                return;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if ((dataGridView1.Rows.Count <=3 ))
            {
                return;
            }

            int filasAfectadas = 0;
            string query = "INSERT INTO Geocercas (nombrePoligono, latitud, longitud, idUsuario) VALUES (@nombrePoligono, @latitud, @longitud, @idUsuario)";
            SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cmd.Parameters.Clear();

                string latitudInt = Convert.ToString(row.Cells["Lat"].Value);
                string longitudInt = Convert.ToString(row.Cells["Long"].Value);

                cmd.Parameters.AddWithValue("@nombrePoligono", Convert.ToString(row.Cells["Descripción"].Value));
                cmd.Parameters.AddWithValue("@latitud", latitudInt);
                cmd.Parameters.AddWithValue("@longitud", longitudInt);
                cmd.Parameters.AddWithValue("@idUsuario", 1);

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

      
    }
}
