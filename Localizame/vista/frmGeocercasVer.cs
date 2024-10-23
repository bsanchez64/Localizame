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
    public partial class frmGeocercasVer : Form
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
        private object marcadores;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public frmGeocercasVer()
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGeocercasVer_Click(object sender, EventArgs e)
        {

        }

        private void frmGeocercasVer_MouseClick(object sender, MouseEventArgs e)
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
            markersOverlay.Markers.Clear();
            string valorCbx = cbxGeocercas.SelectedItem.ToString();
            List<(double latitud, double longitud)> posiciones;

            if (funciones_generales.getNivel() == "administrador")
            {
                posiciones = funciones_generales.cargarPoligonos(valorCbx);
            }
            else
            {
                posiciones = funciones_generales.cargarPoligonosporId(valorCbx);
            }

            List<PointLatLng> puntosPoligono = new List<PointLatLng>();

            foreach (var (latitud, longitud) in posiciones)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.blue_dot);
                markersOverlay.Markers.Add(marker);
                puntosPoligono.Add(new PointLatLng(latitud, longitud));
                gMapControl1.Position = new PointLatLng(latitud, longitud);
            }

            if (puntosPoligono.Count > 0)
            {
                GMapPolygon poligono = new GMapPolygon(puntosPoligono, valorCbx)
                {
                    Fill = new SolidBrush(Color.FromArgb(50, Color.Blue)),
                    Stroke = new Pen(Color.Blue, 2)
                };
                markersOverlay.Polygons.Add(poligono);
            }

            if (!gMapControl1.Overlays.Contains(markersOverlay))
            {
                gMapControl1.Overlays.Add(markersOverlay);
            }

            gMapControl1.Zoom = -11;
            gMapControl1.Refresh();
            gMapControl1.Zoom = 11;

        }

        private void frmGeocercasVer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
