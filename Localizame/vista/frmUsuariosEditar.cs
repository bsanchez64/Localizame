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
    public partial class frmUsuariosEditar : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public int xClic, yClic;
        public frmUsuariosEditar(int UId)
        {
            InitializeComponent();
            string[] datos = funciones_generales.buscarEditarUsuario(UId);
            foreach (var dato in datos)
            {
                var partes = dato.Split(',');

                if (partes.Length == 3)
                {
                    string username = partes[0].Trim();
                    string nombre = partes[1].Trim();
                    string nivel = partes[2].Trim();

                    lblUsuario.Text = "Editar usuario: " + username;
                    txtId.Text = Convert.ToString(UId);
                    txtUsername.Text = username;
                    txtNombre.Text = nombre;
                    cbxNivel.Text = nivel;
                }
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string nombre = txtNombre.Text;
            string nivel = cbxNivel.Text;

            cmd = new SqlCommand("UPDATE Users SET username = @username, nombre = @nombre, nivel = @nivel WHERE Id = @id", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("La actualización se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmUsuariosEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmUsuariosEditar_MouseClick(object sender, MouseEventArgs e)
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
