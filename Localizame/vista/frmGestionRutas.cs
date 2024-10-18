using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Localizame.modelo;

namespace Localizame.vista
{

    public partial class frmGestionRutas : Form
    {
        //marcadores de google
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        private GMapOverlay markersOverlay = new GMapOverlay("marcadores");

        int filaSeleccionada = 0;
        double LatInicial = 6.207945;
        double LngInicial = -75.5928211;
        public string vh;
        public DateTime fechaInicial, fechaFinal;

        public int xClic, yClic;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            item.ToolTipMode = MarkerTooltipMode.Always;
            Task.Delay(3000).ContinueWith(t =>
            {
                this.Invoke(new Action(() => item.ToolTipMode = MarkerTooltipMode.Never));
            });
        }

        public frmGestionRutas()
        {
            InitializeComponent();
            cmbVehiculo.DataSource = funciones_generales.llenardatosCmBox();
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaInicial.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaInicial.ShowUpDown = true;
            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaFinal.ShowUpDown = true;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGestionRutas_Load(object sender, EventArgs e)
        {
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            vh = cmbVehiculo.Text;
            fechaInicial = dtpFechaInicial.Value;
            fechaFinal = dtpFechaFinal.Value;
            markersOverlay.Markers.Clear();
            gMapControl1.Refresh();


            if (vh == "Selecciona una opcion")
            {
                MessageBox.Show("Debes seleccionar un vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string[] marcadores = funciones_generales.cargarMarcadores(vh, fechaInicial, fechaFinal);

                if (marcadores.Length > 0)
                {
                    foreach (var marcador in marcadores)
                    {
                        var parts = marcador.Replace("new PointLatLng(", "").Replace("),", "").Split(',');

                        double latitudInt = Convert.ToDouble(parts[0]);
                        double longitudInt = Convert.ToDouble(parts[1]);
                        string fechaHora = Convert.ToString(parts[2]);

                        double latitud = funciones_generales.ConvertirCoordenada1dg(latitudInt);
                        double longitud = funciones_generales.ConvertirCoordenada2dg(longitudInt);

                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.red_dot);

                        marker.ToolTipMode = MarkerTooltipMode.Never;
                        marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1} \n Fecha y hora: {2}", latitud, longitud, fechaHora);
                        markersOverlay.Markers.Add(marker);
                    }
                }

                gMapControl1.OnMarkerClick += new MarkerClick(gmap_OnMarkerClick);

                if (!gMapControl1.Overlays.Contains(markersOverlay))
                {
                    gMapControl1.Overlays.Add(markersOverlay);
                }

                gMapControl1.Zoom = -12;
                gMapControl1.Refresh();
                gMapControl1.Zoom = 12;

            }
        }

        private void btnUbicacionUltima_Click(object sender, EventArgs e)
        {
            vh = cmbVehiculo.Text;
            markersOverlay.Markers.Clear();
            gMapControl1.Refresh();


            if (vh == "Selecciona una opción")
            {
                MessageBox.Show("Debes seleccionar un vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] marcadores = funciones_generales.cargarUltimaPosicion(vh);

                if (marcadores.Length > 0)
                {
                    foreach (var marcador in marcadores)
                    {
                        var parts = marcador.Replace("new PointLatLng(", "").Replace("),", "").Split(',');

                        double latitudInt = Convert.ToDouble(parts[0]);
                        double longitudInt = Convert.ToDouble(parts[1]);
                        string fechaHora = Convert.ToString(parts[2]);

                        double latitud = funciones_generales.ConvertirCoordenada1dg(latitudInt);
                        double longitud = funciones_generales.ConvertirCoordenada2dg(longitudInt);
                        gMapControl1.Position = new PointLatLng(latitud, longitud);

                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.red_dot);

                        marker.ToolTipMode = MarkerTooltipMode.Always;
                        marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1} \n Fecha y hora: {2}", latitud, longitud, fechaHora);

                        markersOverlay.Markers.Add(marker);
                    }
                }

                if (!gMapControl1.Overlays.Contains(markersOverlay))
                {
                    gMapControl1.Overlays.Add(markersOverlay);
                }

                gMapControl1.Zoom = -16;
                gMapControl1.Refresh();
                gMapControl1.Zoom = 16;

            }
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
                trackZoom.Value = Convert.ToInt32(gMapControl1.Zoom);
            
        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }
    }
}
