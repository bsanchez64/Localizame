using Microsoft.Data.SqlClient;
using System.Data;

namespace Localizame.controlador
{
    public class connection
    {

        //static private string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Coord. de sistemas\source\repos\Localizame\Localizame\dblocalizame.mdf;Integrated Security=True;Connect Timeout=30;";
        private static string CadenaConexion = @"Server=35.188.146.181;Database=localizame;User Id=sqlserver;Password=l0calizame2023;TrustServerCertificate=true;MultipleActiveResultSets=True;";

        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }
    }
}
