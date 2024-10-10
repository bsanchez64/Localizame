using Localizame.controlador;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Localizame.modelo
{
    internal class funciones_generales
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;

        public static string nombre;
        public static string IdUsuario;
        public static string nivel;

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

        public static void setIdUsuario(string str)
        {
            funciones_generales.IdUsuario = str;
        }
        public static string getIdUsuario()
        {
            return IdUsuario;
        }

        public static void setNivel(string str)
        {
            funciones_generales.nivel = str;
        }
        public static string getNivel()
        {
            return nivel;
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

            placas.Add("Selecciona una opción");
            if (getNivel() == "administrador")
            {
                cmd = new SqlCommand("SELECT placa FROM pasoVehiculos GROUP BY placa", cn.AbrirConexion());
            }
            else
            {
                cmd = new SqlCommand("SELECT placa FROM pasoVehiculos WHERE propietario=@propietario GROUP BY placa", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@propietario", getIdUsuario());
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            using (da)
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

        public static List<string> llenarPropietariosCmBox()
        {
            List<string> propietarios = new List<string>();
            cmd = new SqlCommand("SELECT propietario FROM vehiculos GROUP BY propietario", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            using (da)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    propietarios.Add(row["propietario"].ToString());
                }
            }
            cn.CerrarConexion();
            return propietarios;
        }

        public static List<string> llenarGeocercasEditar()
        {
            List<string> propietarios = new List<string>();
            cmd = new SqlCommand("SELECT propietario FROM vehiculos GROUP BY propietario", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            using (da)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    propietarios.Add(row["propietario"].ToString());
                }
            }
            cn.CerrarConexion();
            return propietarios;
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

        public static string[] cargarMarcadores(string placa, DateTime fechaInicial, DateTime fechaFinal)
        {

            cmd = new SqlCommand("SELECT * FROM pasoVehiculos WHERE placa = @placa and fechaHora BETWEEN @fechaInicial and @fechaFinal ", cn.AbrirConexion());
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
                    string fechaHora = Convert.ToString(reader["fechaHora"]);
                    posiciones.Add($"{latitud}, {longitud}, {fechaHora}");
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

            cmd = new SqlCommand("SELECT TOP 1 * FROM pasoVehiculos WHERE placa = @placa ORDER BY id DESC", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@placa", placa);

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> posiciones = new List<string>();

            while (reader.Read())
            {
                double latitud = Convert.ToDouble(reader["latitud"]);
                double longitud = Convert.ToDouble(reader["longitud"]);
                string fechaHora = Convert.ToString(reader["fechaHora"]);
                posiciones.Add($"{latitud}, {longitud}, {fechaHora}");
            }
            cn.CerrarConexion();
            return posiciones.ToArray();
        }

        public static void llenarDataViewVehiculos(DataGridView gridVehiculos)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Vehiculos", cn.AbrirConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridVehiculos.DataSource = dt;
                cn.CerrarConexion();
            }
            catch (Exception)
            {

            }

        }

        public static void llenarDataViewUsuarios(DataGridView gridUsuarios)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Users", cn.AbrirConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridUsuarios.DataSource = dt;
                cn.CerrarConexion();
            }
            catch (Exception)
            {

            }

        }

        public static string[] buscarEditarVehiculo(int vId)
        {
            List<string> editar = new List<string>();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Vehiculos WHERE Id=@id", cn.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@id", vId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string placa = Convert.ToString(reader["placa"]);
                        string propietario = Convert.ToString(reader["propietario"]);
                        editar.Add($"{placa}, {propietario}");
                    }
                }
            }

            cn.CerrarConexion();
            return editar.ToArray();
        }


        public static string[] buscarEditarUsuario(int UId)
        {
            List<string> editar = new List<string>();

            using (SqlCommand cmd = new SqlCommand("SELECT username, nombre, nivel FROM Users WHERE Id=@id", cn.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@id", UId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = Convert.ToString(reader["username"]);
                        string nombre = Convert.ToString(reader["nombre"]);
                        string nivel = Convert.ToString(reader["nivel"]);
                        editar.Add($"{username}, {nombre}, {nivel}");
                    }
                }
            }
            cn.CerrarConexion();
            return editar.ToArray();
        }

        public static int validarExistencia(string cadena, string valorBuscar)
        {
            SqlCommand checkCmd = new SqlCommand(cadena, cn.AbrirConexion());
            checkCmd.Parameters.AddWithValue("@valor", valorBuscar);
            int count = (int)checkCmd.ExecuteScalar();
            return count;
        }

        public static void llenarDataViewOperadores(DataGridView gridVehiculos)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Operadores", cn.AbrirConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridVehiculos.DataSource = dt;
                cn.CerrarConexion();
            }
            catch (Exception)
            {
            }
        }
        public static string[] buscarEditarUsuario()
        {
            var uId = getIdUsuario();
            List<string> editar = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Id=@id", cn.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@id", uId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = Convert.ToString(reader["username"]);
                        string nombre = Convert.ToString(reader["nombre"]);
                        editar.Add($"{username}, {nombre}");
                    }
                }
            }
            cn.CerrarConexion();
            return editar.ToArray();
        }

        public static string[] buscarEditarOperador(int oId)
        {
            List<string> editar = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Operadores WHERE cedula=@cedula", cn.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@cedula", oId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = Convert.ToString(reader["nombre"]);
                        editar.Add($"{nombre}");
                    }
                }
            }
            cn.CerrarConexion();
            return editar.ToArray();
        }



    }
}