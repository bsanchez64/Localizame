using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Localizame.controlador;
using Localizame.modelo;
using Microsoft.Data.SqlClient;

namespace Localizame.vista
{
    public partial class frmOperadorEditar : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmOperadorEditar()
        {
            InitializeComponent();
        }

        public frmOperadorEditar(int oId)
        {
            InitializeComponent();

            string[] datos = funciones_generales.buscarEditarOperador(oId);

            foreach (var dato in datos)
            {
                var partes = dato.Split(',');
                string nombre = partes[0].Trim();
                lblEditar.Text = "Editar operador: " + nombre;
                txtCedula.Text = Convert.ToString(oId);
                txtNombre.Text = nombre;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;

            cmd = new SqlCommand("UPDATE Operadores SET nombre =@nombre WHERE cedula = @cedula", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("La actualización se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún operador con la cedula proporcionada o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
