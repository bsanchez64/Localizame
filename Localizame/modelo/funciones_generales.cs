﻿using Localizame.controlador;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Policy;
using System.Numerics;
using System.Windows.Forms;
using System.Diagnostics;

namespace Localizame.modelo
{
    internal class funciones_generales
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;

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

        public static List<string> llenardatosCmBox()
        {
            List<string> placas = new List<string>();
            placas.Add("Selecciona una opcion");
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT placa FROM Vehiculos GROUP BY placa", cn.AbrirConexion()))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    placas.Add(row["placa"].ToString());
                }
            }
            cn.CerrarConexion();
            return placas;
        }


        public static double ConvertirCoordenada1dg(double coordinate)
        {
            string coordinateString = coordinate.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string firstDigit = coordinateString.Substring(0, 1);
            string remainingDigits = coordinateString.Substring(1);
            string formattedCoordinate = $"{firstDigit}.{remainingDigits}";
            return double.Parse(formattedCoordinate, System.Globalization.CultureInfo.InvariantCulture);
        }
        public static double ConvertirCoordenada2dg(double coordinate)
        {
            string coordinateString = Math.Abs(coordinate).ToString(System.Globalization.CultureInfo.InvariantCulture);
            string sign = coordinate < 0 ? "-" : "";
            if (coordinateString.Length < 2)
            {
                throw new ArgumentException("La coordenada debe tener al menos 2 dígitos.");
            }
            string firstDigits;
            string remainingDigits;

            if (coordinateString.Length == 2)
            {
                firstDigits = coordinateString.Substring(0, 2);
                remainingDigits = "0"; 
            }
            else
            {
                firstDigits = coordinateString.Substring(0, 2);
                remainingDigits = coordinateString.Substring(2);
            }

            string formattedCoordinate = $"{sign}{firstDigits}.{remainingDigits}";
            return double.Parse(formattedCoordinate, System.Globalization.CultureInfo.InvariantCulture);
        }

        public DateTime QuitarHoras(DateTime dateTime)
        {
            // Establecer la hora a medianoche
            return dateTime.Date; // Esto devuelve solo la fecha
        }

        public static string[] cargarMarcadores(string placa, DateTime fechaInicial,DateTime fechaFinal)
        {

            cmd = new SqlCommand("SELECT * FROM Vehiculos WHERE placa = @placa and fechaHora BETWEEN @fechaInicial and @fechaFinal ", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@fechaInicial", fechaInicial);
            cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> posiciones = new List<string>();

            if (reader.Read())
            {
                while (reader.Read())
                {
                    double latitud = Convert.ToDouble(reader["latitud"]);
                    double longitud = Convert.ToDouble(reader["longitud"]);
                    posiciones.Add($"{latitud}, {longitud}");
                }
            }
            else
            {
                MessageBox.Show("Esta consulta no tiene resultados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
            cn.CerrarConexion();
            return posiciones.ToArray();
        }

        public static string[] cargarUltimaPosicion(string placa)
        {

            cmd = new SqlCommand("SELECT TOP 1 * FROM Vehiculos WHERE placa = @placa ORDER BY id DESC", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@placa", placa);

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> posiciones = new List<string>();

            while (reader.Read())
            {
                // Suponiendo que latitud y longitud están almacenadas como enteros
                double latitud = Convert.ToDouble(reader["latitud"]);
                double longitud = Convert.ToDouble(reader["longitud"]);
                string fechaHora = Convert.ToString(reader["fechaHora"]);
                posiciones.Add($"{latitud}, {longitud}, {fechaHora}");
            }
            cn.CerrarConexion();
            return posiciones.ToArray();
        }


    }
}
