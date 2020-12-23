using ControlDocs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDocs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Text = Resources.nombre_app;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.vicktor_logo;
            this.Refresh();
        }

        private void tsmEnvios_Click(object sender, EventArgs e)
        {
            FrmEnvios frmEnvios = new FrmEnvios();
            frmEnvios.MdiParent = this;
            frmEnvios.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
        
            reportes.Show();
        }
    }
}
