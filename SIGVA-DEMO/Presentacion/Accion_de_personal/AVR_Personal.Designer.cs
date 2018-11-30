namespace Presentacion
{
    partial class AVR_Personal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SIGVADataSet3 = new Presentacion.SIGVADataSet3();
            this.AnualidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AnualidadesTableAdapter = new Presentacion.SIGVADataSet3TableAdapters.AnualidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnualidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AnualidadesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Accion_de_personal.Rpt_Accion_Personal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(832, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // SIGVADataSet3
            // 
            this.SIGVADataSet3.DataSetName = "SIGVADataSet3";
            this.SIGVADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AnualidadesBindingSource
            // 
            this.AnualidadesBindingSource.DataMember = "Anualidades";
            this.AnualidadesBindingSource.DataSource = this.SIGVADataSet3;
            // 
            // AnualidadesTableAdapter
            // 
            this.AnualidadesTableAdapter.ClearBeforeFill = true;
            // 
            // AVR_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 560);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AVR_Personal";
            this.Text = "AVR_Personal";
            this.Load += new System.EventHandler(this.AVR_Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnualidadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AnualidadesBindingSource;
        private SIGVADataSet3 SIGVADataSet3;
        private SIGVADataSet3TableAdapters.AnualidadesTableAdapter AnualidadesTableAdapter;
    }
}