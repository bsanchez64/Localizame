<<<<<<< HEAD
﻿using GMap.NET;
using GMap.NET.MapProviders;
=======
﻿using Microsoft.Data.SqlClient;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
>>>>>>> 96a7f37dad60f2232110fcd9362f7f50004c7ee1
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Localizame.modelo;
<<<<<<< HEAD
using System.Data;
=======
using Localizame.controlador;
using Microsoft.VisualBasic.ApplicationServices;
>>>>>>> 96a7f37dad60f2232110fcd9362f7f50004c7ee1

namespace Localizame.vista
{
    public partial class frmGeocercas : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
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
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public frmGeocercas()
        {
            InitializeComponent();
        }


        private void frmGeocercas_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            // insertar datos al dt para mostrar en la lista
            dt.Rows.Add("Ubicacion Inicial", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            // desactivar columnas de lat y long
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

            // marcador
            markerOverlay = new GMapOverlay("Marcador");//Agregamos el overlay al mapa

            // Inicializamos el marcador antes de usarlo
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);

            // agregamos el tooltip de texto al marcador
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);

            // Agregamos el marcador al overlay y luego al mapa
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
            filaSeleccionada = e.RowIndex;//Fila seleccionada
            //Recuperamos los datos del grid y los asignamos a los textbox
            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();
            // se asignan los valores del grid al marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            // se posiciona el foco del mapa en la posicion del marcador
            gMapControl1.Position = marker.Position;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Se obtienen los datos de lat y long del mapa donde el usuario presionó
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            // Se posicionan en el txt de la latitud y longitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            // Comprobamos si el marcador está inicializado, de lo contrario lo creamos
            if (marker == null)
            {
                marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);
                markerOverlay.Markers.Add(marker); // Agregamos el marcador al overlay si es nuevo
                gMapControl1.Overlays.Add(markerOverlay); // Aseguramos que el overlay está en el mapa
            }

            // Si el marcador ya existe, lo movemos al nuevo lugar
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
                dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);// agregar a la tabla
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada);// remover de la tabla
            //procedimiento para eliminar la base de datos
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
            GMapOverlay Geocerca = new GMapOverlay("Geocerca");
            List<PointLatLng> puntos = new List<PointLatLng>();

            double lng, lat;

            // agarramos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }


            // Validar si hay al menos 4 puntos
            if (puntos.Count < 4)
            {
                MessageBox.Show("Debes agregar al menos 4 puntos para crear un polígono.");
                return; // Salir si no hay suficientes puntos
            }

            // Si hay suficientes puntos, proceder a crear el polígono
            GMapPolygon geocercaPuntos = new GMapPolygon(puntos, "Geocerca");
            Geocerca.Polygons.Add(geocercaPuntos);
            gMapControl1.Overlays.Add(Geocerca);

            // Actualizar el mapa para que se vea el cambio
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

<<<<<<< HEAD

=======
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
                txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

                cmd = new SqlCommand("INSERT INTO Geocercas (nombrePoligono, latitud, longitud) VALUES (@nombrePoligono, @latitud, @longitud)", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@nombrePoligono", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@latitud", txtLatitud.Text);
                cmd.Parameters.AddWithValue("@longitud", txtLongitud.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hecho");
            }
        }
>>>>>>> 96a7f37dad60f2232110fcd9362f7f50004c7ee1
    }
}
