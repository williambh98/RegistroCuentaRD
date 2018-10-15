using RegistroCuentaRD.Entidades;
using RegistroCuentaRD.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCuentaRD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cuenta ct = new Cuenta();
            ct.MdiParent = this;
            ct.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
