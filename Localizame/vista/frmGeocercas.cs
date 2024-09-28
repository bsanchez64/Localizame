using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Localizame.modelo;
using Localizame.controlador;

namespace Localizame.vista
{
    public partial class frmGeocercas : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 6.1711964;
        double LngInicial = -75.6514894;
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
            dt.Rows.Add("Pilsen", LatInicial, LngInicial);
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
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            // agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);

            // agregamos el mapa y el marcador al map control
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
            
            // se obtiene los datos de lat y long del mapa donde usuario presiono
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            // se posicionan en el txt de la latitud y longitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            //creamos el marcador para moverlo al lugar indicado
            marker.Position = new PointLatLng(lat, lng);
            // tambien agregamos el mensaje al marcador(tooltip)
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);// agregar a la tabla
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
            //variables para almacenar
            double lng, lat;
            //agarramos los datos del grid
            for (int filas=0; filas< dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }
            GMapPolygon geocercaPuntos = new GMapPolygon(puntos, "Geocerca");
            Geocerca.Polygons.Add(geocercaPuntos);
            gMapControl1.Overlays.Add(Geocerca);
            //Actualizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }
    }
}
