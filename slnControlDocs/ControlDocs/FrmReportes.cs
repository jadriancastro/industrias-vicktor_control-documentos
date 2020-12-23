using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlDocs
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'viktor2DataSet.View_DocEnvios' Puede moverla o quitarla según sea necesario.
            this.view_DocEnviosTableAdapter.Fill(this.viktor2DataSet.View_DocEnvios);

            var path = System.IO.Path.Combine(Application.StartupPath, "Informes", "VentaItems.rdlc");
            rtpvReportes.LocalReport.ReportPath = path;

            this.rtpvReportes.RefreshReport();



        }
    }
}
