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
            funciones_generales.getNivel();
            funciones_generales.getIdUsuario(); 
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;
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
            if (funciones_generales.getNivel() == "administrador")
            {
                markersOverlay.Markers.Clear();
                string valorCbx = cbxGeocercas.SelectedItem.ToString();
                string[] marcadores = funciones_generales.cargarMarcadoresGeocercas(valorCbx);

                if (marcadores.Length > 0)
                {
                    List<(double latitud, double longitud)> posiciones = funciones_generales.cargarPoligonos(valorCbx);
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
                    gMapControl1.Overlays.Add(markersOverlay);

                    gMapControl1.Zoom += 0.1;
                    gMapControl1.Zoom -= 0.1;
                }
            }

            else
                {
                    markersOverlay.Markers.Clear();
                    string valorCbx1 = cbxGeocercas.SelectedItem.ToString();
                    string[] marcadores1 = funciones_generales.cargarMarcadoresPorID(valorCbx1);

                    if (marcadores1.Length > 0)
                    {
                        GMapOverlay overlay = new GMapOverlay(valorCbx1);

                        List<(double latitud, double longitud)> posiciones = funciones_generales.cargarPoligonosporId(valorCbx1);
                        List<PointLatLng> puntosPoligono = new List<PointLatLng>();

                        foreach (var (latitud, longitud) in posiciones)
                        {
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.blue_dot);
                            overlay.Markers.Add(marker);

                            puntosPoligono.Add(new PointLatLng(latitud, longitud));
                            gMapControl1.Position = new PointLatLng(latitud, longitud);
                        }

                        GMapPolygon poligono = new GMapPolygon(puntosPoligono, valorCbx1);

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
        }
    }
