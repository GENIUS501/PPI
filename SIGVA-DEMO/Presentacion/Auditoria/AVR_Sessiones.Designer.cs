namespace Presentacion
{
    partial class AVR_Sessiones
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
            this.SessionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SIGVADataSet = new Presentacion.SIGVADataSet();
            this.Ent_SessionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SessionesTableAdapter = new Presentacion.SIGVADataSetTableAdapters.SessionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SessionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ent_SessionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionesBindingSource
            // 
            this.SessionesBindingSource.DataMember = "Sessiones";
            this.SessionesBindingSource.DataSource = this.SIGVADataSet;
            // 
            // SIGVADataSet
            // 
            this.SIGVADataSet.DataSetName = "SIGVADataSet";
            this.SIGVADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ent_SessionesBindingSource
            // 
            this.Ent_SessionesBindingSource.DataSource = typeof(Entidades.Ent_Sessiones);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SessionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Auditoria.Rpt_Sessiones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // SessionesTableAdapter
            // 
            this.SessionesTableAdapter.ClearBeforeFill = true;
            // 
            // AVR_Sessiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 534);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AVR_Sessiones";
            this.Text = "AVR_Sessiones";
            this.Load += new System.EventHandler(this.AVR_Sessiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGVADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ent_SessionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Ent_SessionesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SessionesBindingSource;
        private SIGVADataSet SIGVADataSet;
        private SIGVADataSetTableAdapters.SessionesTableAdapter SessionesTableAdapter;
    }
}