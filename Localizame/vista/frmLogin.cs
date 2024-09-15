﻿using Microsoft.Data.SqlClient;
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
using System.Security.Cryptography;

namespace Localizame.vista
{
    public partial class frmLogin : Form
    {
        connection cn = new connection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        string user, password;
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSesionOn_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            
            user = txtUsuario.Text;
            password = txtPassword.Text;

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Debes ingresar un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Debes ingresar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    cmd = new SqlCommand("SELECT * FROM Users WHERE username = @user", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@user", user);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            string usernameDb = reader["username"].ToString();
                            string passwordDb = reader["password"].ToString();

                            string passwordLogin = GetMD5(password);

                            if (passwordDb == passwordLogin)
                            {
                                MessageBox.Show("Bienvenido, " + usernameDb);
                                frmMenu.Show();
                                this.Close();
                                
                            }
                            else
                            {
                                MessageBox.Show("La clave ingresada o el usuario no corresponden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados para el usuario: " + user, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                    cn.CerrarConexion();

                }
            }


        }
    }
}
