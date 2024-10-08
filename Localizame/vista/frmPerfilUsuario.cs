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
using Localizame.controlador;
using System.Numerics;

namespace Localizame.vista
{
    public partial class frmPerfilUsuario : Form
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmPerfilUsuario()
        {
            InitializeComponent();
            string[] datos = funciones_generales.buscarEditarUsuario();
            foreach (var dato in datos)
            {
                var partes = dato.Split(',');
                if (partes.Length == 2)
                {
                    string username = partes[0].Trim();
                    string nombre = partes[1].Trim();
                    txtUserName.Text = username;
                    txtNombre.Text = nombre;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string nombre = txtNombre.Text;
            string pw1 = txtPw1.Text;
            string pw2 = txtPw2.Text;
            string password = funciones_generales.GetMD5(pw1);

            var uId = funciones_generales.getIdUsuario();

            if (String.IsNullOrEmpty(pw1))
            {
                cmd = new SqlCommand("UPDATE Users SET username =@username, nombre =@nombre WHERE id = @id", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@id", uId);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("La actualización se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                if(pw1 == pw2)
                {
                    cmd = new SqlCommand("UPDATE Users SET username =@username, nombre =@nombre, password =@password WHERE id = @id", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@id", uId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@password", password);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("La actualización se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Las claves ingresadas no son iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }

            
            
        }
    }
}
