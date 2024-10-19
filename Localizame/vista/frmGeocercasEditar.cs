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

namespace Localizame.vista
{
    public partial class frmGeocercasEditar : Form
    {
        //marcadores de google
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        private GMapOverlay markersOverlay = new GMapOverlay("marcadores");
        private GMapOverlay Geocerca = new GMapOverlay("Geocerca");

        //datetable
        DataTable dt;

        double LatInicial = 6.207945;
        double LngInicial = -75.5928211;
        public int xClic, yClic;

        int filaSeleccionada = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
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

                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
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
                dataTable.Rows[rowIndex].Delete();
                dataTable.AcceptChanges();
                gridGeocercas.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar..");
            }


    }
}
