namespace Presentacion
{
    partial class VRrpt_rango
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Dias_DisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SIGVADataSet1 = new Presentacion.SIGVADataSet1();
            this.Dias_ReservadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Saldos_Disponibles = new Presentacion.Saldos_Disponibles();
            this.FUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Anos_Institucion_AnteriorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DEPARTAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PUESTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FUNCIONARIOSTableAdapter = new Presentacion.SIGVADataSet1TableAdapters.FUNCIONARIOSTableAdapter();
            this.Anos_Institucion_AnteriorTableAdapter = new Presentacion.SIGVADataSet1TableAdapters.Anos_Institucion_AnteriorTableAdapter();
            this.DEPARTAMENTOSTableAdapter = new Presentacion.SIGVADataSet1TableAdapters.DEPARTAMENTOSTableAdapter();
            this.PUESTOSTableAdapter = new Presentacion.SIGVADataSet1TableAdapters.PUESTOSTableAdapter();
            this.Dias_DisponiblesTableAdapter = new Presentacion.SIGVADataSet1TableAdapters.Dias_DisponiblesTableAdapter();
            this.Dias_ReservadosTableAdapter = new Presentacion.Saldos_DisponiblesTableAdapters.Dias_ReservadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_DisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_ReservadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldos_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anos_Institucion_AnteriorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEPARTAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUESTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dias_DisponiblesBindingSource
            // 
            this.Dias_DisponiblesBindingSource.DataMember = "Dias_Disponibles";
            this.Dias_DisponiblesBindingSource.DataSource = this.SIGVADataSet1;
            // 
            // SIGVADataSet1
            // 
            this.SIGVADataSet1.DataSetName = "SIGVADataSet1";
            this.SIGVADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dias_ReservadosBindingSource
            // 
            this.Dias_ReservadosBindingSource.DataMember = "Dias_Reservados";
            this.Dias_ReservadosBindingSource.DataSource = this.Saldos_Disponibles;
            // 
            // Saldos_Disponibles
            // 
            this.Saldos_Disponibles.DataSetName = "Saldos_Disponibles";
            this.Saldos_Disponibles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FUNCIONARIOSBindingSource
            // 
            this.FUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.FUNCIONARIOSBindingSource.DataSource = this.SIGVADataSet1;
            // 
            // Anos_Institucion_AnteriorBindingSource
            // 
            this.Anos_Institucion_AnteriorBindingSource.DataMember = "Anos_Institucion_Anterior";
            this.Anos_Institucion_AnteriorBindingSource.DataSource = this.SIGVADataSet1;
            // 
            // DEPARTAMENTOSBindingSource
            // 
            this.DEPARTAMENTOSBindingSource.DataMember = "DEPARTAMENTOS";
            this.DEPARTAMENTOSBindingSource.DataSource = this.SIGVADataSet1;
            // 
            // PUESTOSBindingSource
            // 
            this.PUESTOSBindingSource.DataMember = "PUESTOS";
            this.PUESTOSBindingSource.DataSource = this.SIGVADataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Funcionarios";
            reportDataSource1.Value = this.FUNCIONARIOSBindingSource;
            reportDataSource2.Name = "Anos_Anterior";
            reportDataSource2.Value = this.Anos_Institucion_AnteriorBindingSource;
            reportDataSource3.Name = "Anualidades";
            reportDataSource3.Value = this.Anos_Institucion_AnteriorBindingSource;
            reportDataSource4.Name = "Departamentos";
            reportDataSource4.Value = this.DEPARTAMENTOSBindingSource;
            reportDataSource5.Name = "Puestos";
            reportDataSource5.Value = this.PUESTOSBindingSource;
            reportDataSource6.Name = "Dias_Disponibles";
            reportDataSource6.Value = this.Dias_DisponiblesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Rpt_Rango.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(843, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // FUNCIONARIOSTableAdapter
            // 
            this.FUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Anos_Institucion_AnteriorTableAdapter
            // 
            this.Anos_Institucion_AnteriorTableAdapter.ClearBeforeFill = true;
            // 
            // DEPARTAMENTOSTableAdapter
            // 
            this.DEPARTAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // PUESTOSTableAdapter
            // 
            this.PUESTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Dias_DisponiblesTableAdapter
            // 
            this.Dias_DisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // Dias_ReservadosTableAdapter
            // 
            this.Dias_ReservadosTableAdapter.ClearBeforeFill = true;
            // 
            // VRrpt_rango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 413);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VRrpt_rango";
            this.Text = "VRrpt_rango";
            this.Load += new System.EventHandler(this.VRrpt_rango_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dias_DisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_ReservadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldos_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anos_Institucion_AnteriorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEPARTAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUESTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FUNCIONARIOSBindingSource;
        private SIGVADataSet1 SIGVADataSet1;
        private System.Windows.Forms.BindingSource Anos_Institucion_AnteriorBindingSource;
        private System.Windows.Forms.BindingSource DEPARTAMENTOSBindingSource;
        private System.Windows.Forms.BindingSource PUESTOSBindingSource;
        private System.Windows.Forms.BindingSource Dias_DisponiblesBindingSource;
        private SIGVADataSet1TableAdapters.FUNCIONARIOSTableAdapter FUNCIONARIOSTableAdapter;
        private SIGVADataSet1TableAdapters.Anos_Institucion_AnteriorTableAdapter Anos_Institucion_AnteriorTableAdapter;
        private SIGVADataSet1TableAdapters.DEPARTAMENTOSTableAdapter DEPARTAMENTOSTableAdapter;
        private SIGVADataSet1TableAdapters.PUESTOSTableAdapter PUESTOSTableAdapter;
        private SIGVADataSet1TableAdapters.Dias_DisponiblesTableAdapter Dias_DisponiblesTableAdapter;
        private System.Windows.Forms.BindingSource Dias_ReservadosBindingSource;
        private Saldos_Disponibles Saldos_Disponibles;
        private Saldos_DisponiblesTableAdapters.Dias_ReservadosTableAdapter Dias_ReservadosTableAdapter;
    }
}