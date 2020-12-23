namespace ControlDocs
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rtpvReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viktor2DataSet = new ControlDocs.Datos.DataSet.Viktor2DataSet();
            this.viewDocEnviosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DocEnviosTableAdapter = new ControlDocs.Datos.DataSet.Viktor2DataSetTableAdapters.View_DocEnviosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viktor2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDocEnviosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rtpvReportes
            // 
            this.rtpvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Data_Envios";
            reportDataSource1.Value = this.viewDocEnviosBindingSource;
            this.rtpvReportes.LocalReport.DataSources.Add(reportDataSource1);
            this.rtpvReportes.LocalReport.ReportEmbeddedResource = "ControlDocs.Informes.VentaItems.rdlc";
            this.rtpvReportes.Location = new System.Drawing.Point(0, 0);
            this.rtpvReportes.Name = "rtpvReportes";
            this.rtpvReportes.Size = new System.Drawing.Size(784, 561);
            this.rtpvReportes.TabIndex = 0;
            // 
            // viktor2DataSet
            // 
            this.viktor2DataSet.DataSetName = "Viktor2DataSet";
            this.viktor2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDocEnviosBindingSource
            // 
            this.viewDocEnviosBindingSource.DataMember = "View_DocEnvios";
            this.viewDocEnviosBindingSource.DataSource = this.viktor2DataSet;
            // 
            // view_DocEnviosTableAdapter
            // 
            this.view_DocEnviosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rtpvReportes);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viktor2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDocEnviosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rtpvReportes;
        private Datos.DataSet.Viktor2DataSet viktor2DataSet;
        private System.Windows.Forms.BindingSource viewDocEnviosBindingSource;
        private Datos.DataSet.Viktor2DataSetTableAdapters.View_DocEnviosTableAdapter view_DocEnviosTableAdapter;
    }
}