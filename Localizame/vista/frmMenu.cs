using Localizame.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localizame.vista
{
    public partial class frmMenu : Form
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

        public frmMenu()
        {

            InitializeComponent();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            lblBienvenido.Text = "Bienvenido, " + funciones_generales.getName();

            if (funciones_generales.getNivel() == "administrador")
            {
                lblUserPlat.Location = new Point(lblUserPlat.Location.X - 20, lblUserPlat.Location.Y);
                lblUserPlat.Text = "Gestionar \nPlataforma";
                
            }
            else
            {
                lblUserPlat.Text = "Perfil";
            }

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            funciones_generales.CerrarSesion();

        }

        private void frmMenu_MouseMove(object sender, MouseEventArgs e)
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

        private void pnlGestionRuta_MouseClick(object sender, MouseEventArgs e)
        {
            new frmGestionRutas().Show(this);
        }
        private void pnlGeocercas_MouseClick(object sender, MouseEventArgs e)
        {
            new frmMenuGeocercas().Show(this);
        }

        private void pnlGestionSoft_MouseClick(object sender, MouseEventArgs e)
        {
            if (funciones_generales.getNivel() == "administrador")
            {
                new frmMenuSoftware().Show(this);
            }
            else
            {
                MessageBox.Show("aca iría el perfil del usuario");
            }
        }

        private void pnlGestionRuta_MouseHover(object sender, EventArgs e)
        {
            pnlGestionRuta.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlGestionRuta_MouseLeave(object sender, EventArgs e)
        {
            pnlGestionRuta.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlGestionSoft_MouseHover(object sender, EventArgs e)
        {
            pnlGestionSoft.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlGestionSoft_MouseLeave(object sender, EventArgs e)
        {
            pnlGestionSoft.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlGeocercas_MouseHover(object sender, EventArgs e)
        {
            pnlGeocercas.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlGeocercas_MouseLeave(object sender, EventArgs e)
        {
            pnlGeocercas.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlInformes_MouseHover(object sender, EventArgs e)
        {
            pnlInformes.BackColor = Color.FromArgb(80, 0, 50, 231);
        }

        private void pnlInformes_MouseLeave(object sender, EventArgs e)
        {
            pnlInformes.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        
    }
}
