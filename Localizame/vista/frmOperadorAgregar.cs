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

namespace Localizame.vista
{
    public partial class frmOperadorAgregar : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmOperadorAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;

            string cadena = "SELECT COUNT(*) FROM Operadores WHERE cedula = @valor";

            if(funciones_generales.validarExistencia(cadena, cedula) > 0)
            {
                MessageBox.Show("Ya existe un vehículo con esta placa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO Operadores (cedula, nombre) VALUES (@cedula, @nombre)", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@nombre", nombre);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}