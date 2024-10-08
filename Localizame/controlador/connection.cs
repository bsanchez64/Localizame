﻿using Microsoft.Data.SqlClient;
using System.Data;

namespace Localizame.controlador
{
    public class connection
    {

        static private string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BrandonS\source\repos\Localizame\dblocalizame.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }
    }
}
