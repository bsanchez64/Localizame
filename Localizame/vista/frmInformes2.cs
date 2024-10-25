using Localizame.modelo;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localizame.vista
{
    public partial class frmInformes2 : Form
    {
        public string vh;
        public DateTime fechaInicial, fechaFinal;
        public int xClic, yClic;
        public frmInformes2()
        {
            InitializeComponent();
            cmbVehiculo.DataSource = funciones_generales.llenardatosCmBox();
            gridGeocercas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaInicial.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaInicial.ShowUpDown = true;
            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaFinal.ShowUpDown = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            vh = cmbVehiculo.Text;
            fechaInicial = dtpFechaInicial.Value;
            fechaFinal = dtpFechaFinal.Value;

            if (vh.IsNullOrEmpty())
            {
                MessageBox.Show("Debe seleccionar un vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Geocerca.CargarRutasConGeocercas(gridGeocercas, vh, fechaInicial, fechaFinal);
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
    }
}
