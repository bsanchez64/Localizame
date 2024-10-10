using Localizame.controlador;
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
using Localizame.modelo;

namespace Localizame.vista
{
    public partial class frmUsuarios : Form
    {
        int Id;
        public static connection cn = new connection();
        public static SqlCommand cmd;
        public int xClic, yClic;
        public frmUsuarios()
        {
            InitializeComponent();
            funciones_generales.llenarDataViewUsuarios(gridUsuarios);
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUsuarios.Columns["Id"].DisplayIndex = 0;
            gridUsuarios.Columns["username"].DisplayIndex = 1;
            gridUsuarios.Columns["password"].Visible = false;
            gridUsuarios.Columns["nombre"].DisplayIndex = 3;
            gridUsuarios.Columns["nivel"].DisplayIndex = 4;
            gridUsuarios.Columns["Editar"].DisplayIndex = 5;
            gridUsuarios.Columns["Eliminar"].DisplayIndex = 6;
            gridUsuarios.RowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenuSoftware frmMenuSoftware = new frmMenuSoftware();
            this.Hide();
            frmMenuSoftware.ShowDialog();
        }

        private void frmUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClic = e.X; yClic = e.Y;

            }
            else
            {
                this.Left = this.Left + (e.X);
                this.Top = this.Top + (e.Y);

            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            gridUsuarios.Columns["Editar"].Width = 45;
            gridUsuarios.Columns["Eliminar"].Width = 55;
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                Id = Convert.ToInt32(gridUsuarios.CurrentRow.Cells["Id"].Value.ToString());
                frmUsuariosEditar editarRegistro = new frmUsuariosEditar(Id);
                editarRegistro.ShowDialog();
                funciones_generales.llenarDataViewUsuarios(gridUsuarios);
            }
            if (gridUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToInt32(gridUsuarios.CurrentRow.Cells["Id"].Value.ToString());
                frmUsuariosEditar editarRegistro = new frmUsuariosEditar(Id);

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de borrar este usuario?", "Borrar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM Users WHERE Id = @Id", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Id", Id);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Se elimino el usuario con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el ID proporcionado o no se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                funciones_generales.llenarDataViewUsuarios(gridUsuarios);
            }


        }

        private void btnNuevoVh_Click(object sender, EventArgs e)
        {
            frmUsuarioAgregar AggUsuario = new frmUsuarioAgregar();
            AggUsuario.ShowDialog();
            funciones_generales.llenarDataViewUsuarios(gridUsuarios);
        }
    }
}
