using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Localizame.modelo
{
    internal class funciones_generales
    {
        public static string nombre;
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

        public static void setName(string str)
        {
            funciones_generales.nombre = str;
        }
        public static string getName()
        {
            return nombre;
        }

        public static void CerrarSesion()
        {
            if (MessageBox.Show("¿Estás seguro de cerrar el programa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cerrar la aplicación: " + ex.Message);
                }
            }
        }

    }
}
