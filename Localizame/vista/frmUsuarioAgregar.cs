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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Localizame.vista
{
    public partial class frmUsuarioAgregar : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmUsuarioAgregar()
        {
            InitializeComponent();
            cbxNivel.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string nombre = txtNombre.Text;
            string nivel = cbxNivel.Text;
            string encryptedPassword = funciones_generales.GetMD5(password);

            cmd = new SqlCommand("INSERT INTO Users (username, password, nombre, nivel) VALUES (@username, @password, @nombre, @nivel)", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", encryptedPassword);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se ingresaron los datos satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarioAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
