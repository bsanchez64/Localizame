using Localizame.modelo;

namespace Localizame.vista
{
    public partial class frmMenuGeocercas : Form
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
        public frmMenuGeocercas()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void frmMenuGeocercas_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuGeocercas_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void pnlVerGeocercas_MouseHover(object sender, EventArgs e)
        {
            pnlVerGeocercas.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlVerGeocercas_MouseLeave(object sender, EventArgs e)
        {
            pnlVerGeocercas.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlAddGeocercas_MouseHover(object sender, EventArgs e)
        {
            pnlAddGeocercas.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlAddGeocercas_MouseLeave(object sender, EventArgs e)
        {
            pnlAddGeocercas.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlEditGeocerca_MouseLeave(object sender, EventArgs e)
        {
            pnlEditGeocerca.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlEditGeocerca_MouseHover(object sender, EventArgs e)
        {
            pnlEditGeocerca.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlDeleteGeo_MouseLeave(object sender, EventArgs e)
        {
            pnlDeleteGeo.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlDeleteGeo_MouseHover(object sender, EventArgs e)
        {
            pnlDeleteGeo.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlAddGeocercas_MouseClick(object sender, MouseEventArgs e)
        {
            new frmGeocercas().Show(this);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlDeleteGeo_Click(object sender, EventArgs e)
        {
            frmGeocercasEliminar frmGeocercasEliminar = new frmGeocercasEliminar();
            frmGeocercasEliminar.Show(this);
        }

        private void pnlVerGeocercas_Click(object sender, EventArgs e)
        {
            frmGeocercasVer frmGeocercasVer = new frmGeocercasVer();
            frmGeocercasVer.Show(this);
        }
    }
}
