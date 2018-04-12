using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercie_5
{
    public partial class frmMDI : Form
    {
        /// <summary>
        /// constructeur du form MDI : ouverture de la fenêtre principale
        /// </summary>
        public frmMDI()
        {
            InitializeComponent();
            frmExo5 frmPrinc;//déclare une instance du form principal
            frmPrinc = new frmExo5();//instancie le form principal
            frmPrinc.MdiParent = this;//précise le conteneur MDI du form principal
            frmPrinc.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void chronoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }

        private void frmExo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
