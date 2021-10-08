using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrudBasico
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void tesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test fmr = new Test();
            fmr.MdiParent = this;
            fmr.Show();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrPelicula fmr = new FmrPelicula();
            fmr.MdiParent = this;
            fmr.Show();
        }

    }
}
