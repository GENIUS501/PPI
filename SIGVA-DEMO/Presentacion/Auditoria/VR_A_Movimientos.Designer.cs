namespace Presentacion
{
    partial class VR_A_Movimientos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VR_A_Movimientos));
            this.BitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SIGVADataSet_Bitacora = new Presentacion.SIGVADataSet_Bitacora();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BitacoraTableAdapter = new Presentacion.SIGVADataSet_BitacoraTableAdapters.BitacoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet_Bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // BitacoraBindingSource
            // 
            this.BitacoraBindingSource.DataMember = "Bitacora";
            this.BitacoraBindingSource.DataSource = this.SIGVADataSet_Bitacora;
            // 
            // SIGVADataSet_Bitacora
            // 
            this.SIGVADataSet_Bitacora.DataSetName = "SIGVADataSet_Bitacora";
            this.SIGVADataSet_Bitacora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetRpt_Movimientos";
            reportDataSource2.Value = this.BitacoraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Auditoria.A_Movimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(887, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // BitacoraTableAdapter
            // 
            this.BitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // VR_A_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 478);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VR_A_Movimientos";
            this.Text = "Reporte Movimientos";
            this.Load += new System.EventHandler(this.VR_A_Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet_Bitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BitacoraBindingSource;
        private SIGVADataSet_Bitacora SIGVADataSet_Bitacora;
        private SIGVADataSet_BitacoraTableAdapters.BitacoraTableAdapter BitacoraTableAdapter;
    }
}