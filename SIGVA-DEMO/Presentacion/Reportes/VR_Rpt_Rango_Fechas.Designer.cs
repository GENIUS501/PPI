namespace Presentacion
{
    partial class VR_Rpt_Rango_Fechas
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
            this.Dias_ReservadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SIGVADataSetrpt_rango = new Presentacion.SIGVADataSetrpt_rango();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dias_ReservadosTableAdapter = new Presentacion.SIGVADataSetrpt_rangoTableAdapters.Dias_ReservadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_ReservadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSetrpt_rango)).BeginInit();
            this.SuspendLayout();
            // 
            // Dias_ReservadosBindingSource
            // 
            this.Dias_ReservadosBindingSource.DataMember = "Dias_Reservados";
            this.Dias_ReservadosBindingSource.DataSource = this.SIGVADataSetrpt_rango;
            // 
            // SIGVADataSetrpt_rango
            // 
            this.SIGVADataSetrpt_rango.DataSetName = "SIGVADataSetrpt_rango";
            this.SIGVADataSetrpt_rango.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRpt_Rango_Fechas";
            reportDataSource1.Value = this.Dias_ReservadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Rpt_Rango_Fechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dias_ReservadosTableAdapter
            // 
            this.Dias_ReservadosTableAdapter.ClearBeforeFill = true;
            // 
            // VR_Rpt_Rango_Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 462);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VR_Rpt_Rango_Fechas";
            this.Text = "VR_Rpt_Rango_Fechas";
            this.Load += new System.EventHandler(this.VR_Rpt_Rango_Fechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dias_ReservadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSetrpt_rango)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Dias_ReservadosBindingSource;
        private SIGVADataSetrpt_rango SIGVADataSetrpt_rango;
        private SIGVADataSetrpt_rangoTableAdapters.Dias_ReservadosTableAdapter Dias_ReservadosTableAdapter;
    }
}