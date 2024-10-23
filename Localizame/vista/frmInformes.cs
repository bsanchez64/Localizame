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
    public partial class frmInformes : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        public frmInformes()
        {
            InitializeComponent();
        }


        private void pnlInforme1_MouseHover(object sender, EventArgs e)
        {
            pnlInforme1.BackColor = Color.FromArgb(80, 0, 50, 231);

        }

        private void pnlInforme1_MouseLeave(object sender, EventArgs e)
        {
            pnlInforme1.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void pnlInforme2_MouseHover(object sender, EventArgs e)
        {
            pnlInforme2.BackColor = Color.FromArgb(80, 0, 50, 231);

        }

        private void pnlInforme2_MouseLeave(object sender, EventArgs e)
        {
            pnlInforme2.BackColor = Color.FromArgb(0, 0, 50, 231);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            funciones_generales.CerrarSesion();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();


        }

        private void pnlInforme1_MouseClick(object sender, MouseEventArgs e)
        {
            frmInformes1 frmInformes1 = new frmInformes1();
            frmInformes1.ShowDialog();
        }
    }
}
