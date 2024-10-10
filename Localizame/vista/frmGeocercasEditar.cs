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
    public partial class frmGeocercasEditar : Form
    {
        public frmGeocercasEditar()
        {
            InitializeComponent();
            cbxGeocercas.DataSource = funciones_generales.llenarGeocercasEditar();
        }
    }
}
