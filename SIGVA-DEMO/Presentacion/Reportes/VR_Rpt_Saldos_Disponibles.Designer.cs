namespace Presentacion
{
    partial class VR_Rpt_Saldos_Disponibles
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
            this.Dias_DisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Saldos_Disponibles = new Presentacion.Saldos_Disponibles();
            this.Dias_ReservadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dias_DisponiblesTableAdapter = new Presentacion.Saldos_DisponiblesTableAdapters.Dias_DisponiblesTableAdapter();
            this.Dias_ReservadosTableAdapter = new Presentacion.Saldos_DisponiblesTableAdapters.Dias_ReservadosTableAdapter();
            this.FUNCIONARIOSTableAdapter = new Presentacion.Saldos_DisponiblesTableAdapters.FUNCIONARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_DisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldos_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_ReservadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUNCIONARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dias_DisponiblesBindingSource
            // 
            this.Dias_DisponiblesBindingSource.DataMember = "Dias_Disponibles";
            this.Dias_DisponiblesBindingSource.DataSource = this.Saldos_Disponibles;
            // 
            // Saldos_Disponibles
            // 
            this.Saldos_Disponibles.DataSetName = "Saldos_Disponibles";
            this.Saldos_Disponibles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dias_ReservadosBindingSource
            // 
            this.Dias_ReservadosBindingSource.DataMember = "Dias_Reservados";
            this.Dias_ReservadosBindingSource.DataSource = this.Saldos_Disponibles;
            // 
            // FUNCIONARIOSBindingSource
            // 
            this.FUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.FUNCIONARIOSBindingSource.DataSource = this.Saldos_Disponibles;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dias_Disponibles";
            reportDataSource1.Value = this.Dias_DisponiblesBindingSource;
            reportDataSource2.Name = "Dias_Reservados";
            reportDataSource2.Value = this.Dias_ReservadosBindingSource;
            reportDataSource3.Name = "Funcionarios";
            reportDataSource3.Value = this.FUNCIONARIOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Rpt_Saldos_Disponibles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(735, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dias_DisponiblesTableAdapter
            // 
            this.Dias_DisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // Dias_ReservadosTableAdapter
            // 
            this.Dias_ReservadosTableAdapter.ClearBeforeFill = true;
            // 
            // FUNCIONARIOSTableAdapter
            // 
            this.FUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // VR_Rpt_Saldos_Disponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VR_Rpt_Saldos_Disponibles";
            this.Text = "VR_Rpt_Saldos_Disponibles";
            this.Load += new System.EventHandler(this.VR_Rpt_Saldos_Disponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dias_DisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldos_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dias_ReservadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUNCIONARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Dias_DisponiblesBindingSource;
        private Saldos_Disponibles Saldos_Disponibles;
        private System.Windows.Forms.BindingSource Dias_ReservadosBindingSource;
        private System.Windows.Forms.BindingSource FUNCIONARIOSBindingSource;
        private Saldos_DisponiblesTableAdapters.Dias_DisponiblesTableAdapter Dias_DisponiblesTableAdapter;
        private Saldos_DisponiblesTableAdapters.Dias_ReservadosTableAdapter Dias_ReservadosTableAdapter;
        private Saldos_DisponiblesTableAdapters.FUNCIONARIOSTableAdapter FUNCIONARIOSTableAdapter;
    }
}