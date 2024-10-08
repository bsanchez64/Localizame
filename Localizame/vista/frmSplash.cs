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
    public partial class frmSplash : Form
    {
        private int messageIndex = 0;
        string[] mensajes = { "Cargando...", "Cargando DB...", "Inicializando módulos...", "Listo!" };

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = mensajes[messageIndex];
            messageIndex++;

            if (messageIndex >= mensajes.Length)
            {
                timer1.Stop();

                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();

                this.Hide();
            }
        }
    }
}
