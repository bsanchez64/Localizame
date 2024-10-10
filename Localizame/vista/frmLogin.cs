using Localizame.controlador;
using Localizame.modelo;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Localizame.vista
{
    public partial class frmLogin : Form
    {
        funciones_generales funGen = new funciones_generales();
        connection cn = new connection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        string user, password;
        public int xClic, yClic;


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnSesionOn;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSesionOn_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            user = txtUsuario.Text;
            password = txtPassword.Text;

            var loading = new loading();
            loading.Show();

            if (string.IsNullOrEmpty(user))
            {
                loading.Close();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Debes ingresar un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (string.IsNullOrEmpty(password))
                {
                    loading.Close();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Debes ingresar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cmd = new SqlCommand("SELECT * FROM Users WHERE username = @user", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@user", user);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string passwordDb = reader["password"].ToString();
                            string nombreDb = reader["nombre"].ToString();
                            string idDb = reader["Id"].ToString();
                            string nivelDb = reader["nivel"].ToString();

                            string passwordLogin = funciones_generales.GetMD5(password);

                            if (passwordDb == passwordLogin)
                            {
                                funciones_generales.setName(nombreDb);
                                funciones_generales.setIdUsuario(idDb);
                                funciones_generales.setNivel(nivelDb);
                                //MessageBox.Show("Bienvenido, " + nombreDb);
                                Cursor.Current = Cursors.Default;
                                loading.Close();
                                this.Hide();
                                new frmMenu().ShowDialog();

                            }
                            else
                            {
                                loading.Close();
                                MessageBox.Show("La clave ingresada o el usuario no corresponden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                    else
                    {
                        loading.Close();
                        MessageBox.Show("No se encontraron resultados para el usuario: " + user, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                    cn.CerrarConexion();

                }
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmSplash frmSplash = new frmSplash();
            frmSplash.Close();
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
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
    }
}
