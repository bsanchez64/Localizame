using Localizame.modelo;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Localizame.controlador;
using System.Numerics;

namespace Localizame.vista
{
    public partial class frmVehiculo : Form
    {

        int Id;
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public frmVehiculo()
        {
            InitializeComponent();
            funciones_generales.llenarDataViewVehiculos(gridVehiculos);
            gridVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVehiculos.Columns["Id"].DisplayIndex = 0;
            gridVehiculos.Columns["Placa"].DisplayIndex = 1;
            gridVehiculos.Columns["Propietario"].DisplayIndex = 2;
            gridVehiculos.Columns["Editar"].DisplayIndex = 3;
            gridVehiculos.Columns["Eliminar"].DisplayIndex = 4;
            gridVehiculos.RowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            gridVehiculos.Columns["Editar"].Width = 45;
            gridVehiculos.Columns["Eliminar"].Width = 55;


        }

        private void gridVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (gridVehiculos.Columns[e.ColumnIndex].Name=="Editar")
            {
                Id = Convert.ToInt32(gridVehiculos.CurrentRow.Cells["Id"].Value.ToString());
                frmVehiculoEditar editarRegistro = new frmVehiculoEditar(Id);
                editarRegistro.ShowDialog();
                funciones_generales.llenarDataViewVehiculos(gridVehiculos);
            } 
            
            if (gridVehiculos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToInt32(gridVehiculos.CurrentRow.Cells["Id"].Value.ToString());
                frmVehiculoEditar editarRegistro = new frmVehiculoEditar(Id);

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de borrar este vehículo?", "Borrar Vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM Vehiculos WHERE Id = @Id", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Id", Id);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Se elimino el vehiculo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún vehículo con la placa proporcionada o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }             

                funciones_generales.llenarDataViewVehiculos(gridVehiculos);
            }
        }
    }
}
