using Localizame.controlador;
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
using Localizame.modelo;
using System.Diagnostics;

namespace Localizame.vista
{
    public partial class frmVehiculoAgregar : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmVehiculoAgregar()
        {
            InitializeComponent();
            cbxPropietario.DataSource = funciones_generales.llenarPropietariosCmBox();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string placa = txtPlaca.Text;
            string propietario = cbxPropietario.Text;

            string cadena = "SELECT COUNT(*) FROM Vehiculos WHERE placa = @valor";

            if (funciones_generales.validarExistencia(cadena, placa) > 0)
            {
                MessageBox.Show("Ya existe un operador con esta cédula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO Vehiculos (placa, propietario) VALUES (@placa, @propietario)", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.Parameters.AddWithValue("@propietario", propietario);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("La actualización se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún vehículo con la placa proporcionada o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVehiculoAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
