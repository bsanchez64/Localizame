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

namespace Localizame.vista
{
    public partial class frmInformes1 : Form
    {

        public string vh;
        public DateTime fechaInicial, fechaFinal;
        public frmInformes1()
        {
            InitializeComponent();
            //cmbVehiculo.DataSource = funciones_generales.llenardatosCmBox();
            gridOperadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            funciones_generales.informeOperadoresPlaca(gridOperadores, vh, fechaInicial, fechaFinal);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
