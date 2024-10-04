using Microsoft.Data.SqlClient;
using System.Data;

namespace Localizame.controlador
{
    public partial class ucVehiculos : UserControl
    {
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public string xid;

        public ucVehiculos()
        {
            InitializeComponent();
        }

        private void ucVehiculos_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT placa FROM Vehiculos", cn.AbrirConexion());
                da.Fill(dt);
                DataRow newRow = dt.NewRow();
                newRow["placa"] = "Seleccione una opción";
                dt.Rows.InsertAt(newRow, 0);
                cbxVehiculos.DisplayMember = "placa";
                cbxVehiculos.ValueMember = "placa";
                cbxVehiculos.DataSource = dt;
            }
                
        }

        private void cbxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            xid = cbxVehiculos.SelectedValue.ToString();

        }
    }
}
