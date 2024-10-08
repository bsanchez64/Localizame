using Localizame.modelo;

namespace Localizame.vista
{
    public partial class frmMenuSoftware : Form
    {
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

        public frmMenuSoftware()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void frmMenuSoftware_MouseMove(object sender, MouseEventArgs e)
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


        private void pnlUsuarios_MouseLeave(object sender, EventArgs e)
        {
            pnlUsuarios.BackColor = Color.FromArgb(0, 0, 50, 231);

        }

        private void pnlUsuarios_MouseHover(object sender, EventArgs e)
        {
            pnlUsuarios.BackColor = Color.FromArgb(80, 0, 50, 231);

        }

        private void pnlVehiculos_MouseLeave(object sender, EventArgs e)
        {
            pnlVehiculos.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlVehiculos_MouseHover(object sender, EventArgs e)
        {
            pnlVehiculos.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlOperadores_MouseLeave(object sender, EventArgs e)
        {
            pnlOperadores.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlOperadores_MouseHover(object sender, EventArgs e)
        {
            pnlOperadores.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void pnlUsuarios_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pnlVehiculos_MouseClick(object sender, MouseEventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo();
            frmVehiculo.ShowDialog();
        }

        private void pnlOperadores_MouseClick(object sender, MouseEventArgs e)
        {
            frmOperadores frmOperadores = new frmOperadores();
            frmOperadores.ShowDialog();
        }
    }
}
