using Localizame.controlador;
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
using Microsoft.Data.SqlClient;

namespace Localizame.vista
{
    public partial class frmVehiculoEditar : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmVehiculoEditar()
        {
            InitializeComponent();
        }

        public frmVehiculoEditar(int vId)
        {
            InitializeComponent();
            cbxPropietario.DataSource = funciones_generales.llenarPropietariosCmBox();
            string[] datos = funciones_generales.buscarEditarVehiculo(vId);

            foreach (var dato in datos)
            {
                var partes = dato.Split(',');

                if (partes.Length == 2)
                {
                    string placa = partes[0].Trim();
                    string propietario = partes[1].Trim();

                    txtId.Text = Convert.ToString(vId);
                    txtPlaca.Text = placa;
                    cbxPropietario.Text = propietario;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string propietario = cbxPropietario.Text;

            cmd = new SqlCommand("UPDATE Vehiculos SET propietario =@propietario WHERE placa = @placa", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@propietario", propietario);
            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("La actualización se realizó con éxito.","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún vehículo con la placa proporcionada o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
