using Localizame.modelo;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Localizame.controlador;
using System.Numerics;

namespace Localizame.vista
{
    public partial class frmOperadores : Form
    {
        int Cedula;
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public int xClic, yClic;
        public frmOperadores()
        {
            InitializeComponent();
            funciones_generales.llenarDataViewOperadores(gridOperadores);
            gridOperadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOperadores.Columns["Cedula"].DisplayIndex = 0;
            gridOperadores.Columns["Nombre"].DisplayIndex = 1;
            gridOperadores.Columns["Editar"].DisplayIndex = 2;
            gridOperadores.Columns["Eliminar"].DisplayIndex = 3;
            gridOperadores.RowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
            gridOperadores.Columns["Editar"].Width = 45;
            gridOperadores.Columns["Eliminar"].Width = 55;
        }

        private void gridOperadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridOperadores.Columns[e.ColumnIndex].Name == "Editar")
            {
                Cedula = Convert.ToInt32(gridOperadores.CurrentRow.Cells["cedula"].Value.ToString());
                frmOperadorEditar frmOperadorEditar = new frmOperadorEditar(Cedula);
                frmOperadorEditar.ShowDialog();
                funciones_generales.llenarDataViewOperadores(gridOperadores);
            }

            if (gridOperadores.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Cedula = Convert.ToInt32(gridOperadores.CurrentRow.Cells["Cedula"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de borrar este Operador?", "Borrar Vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM Operadores WHERE cedula = @cedula", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@cedula", Cedula);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Se elimino el Operador con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún Operador con la cedula proporcionada o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                funciones_generales.llenarDataViewOperadores(gridOperadores);
            }
        }

        private void btnNuevoVh_Click(object sender, EventArgs e)
        {
            frmOperadorAgregar frmOperadorAgregar = new frmOperadorAgregar();
            frmOperadorAgregar.ShowDialog();
            funciones_generales.llenarDataViewOperadores(gridOperadores);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();   
        }
    }
}
