namespace Presentacion
{
    partial class L_Puestos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIGVADataSet1 = new Presentacion.SIGVADataSet1();
            this.pUESTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUESTOSTableAdapter = new Presentacion.SIGVADataSet1TableAdapters.PUESTOSTableAdapter();
            this.idPuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUESTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPuestoDataGridViewTextBoxColumn,
            this.nombrePuestoDataGridViewTextBoxColumn,
            this.idDepartamentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pUESTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 230);
            this.dataGridView1.TabIndex = 5;
            // 
            // sIGVADataSet1
            // 
            this.sIGVADataSet1.DataSetName = "SIGVADataSet1";
            this.sIGVADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUESTOSBindingSource
            // 
            this.pUESTOSBindingSource.DataMember = "PUESTOS";
            this.pUESTOSBindingSource.DataSource = this.sIGVADataSet1;
            // 
            // pUESTOSTableAdapter
            // 
            this.pUESTOSTableAdapter.ClearBeforeFill = true;
            // 
            // idPuestoDataGridViewTextBoxColumn
            // 
            this.idPuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_Puesto";
            this.idPuestoDataGridViewTextBoxColumn.HeaderText = "Id_Puesto";
            this.idPuestoDataGridViewTextBoxColumn.Name = "idPuestoDataGridViewTextBoxColumn";
            this.idPuestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePuestoDataGridViewTextBoxColumn
            // 
            this.nombrePuestoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Puesto";
            this.nombrePuestoDataGridViewTextBoxColumn.HeaderText = "Nombre_Puesto";
            this.nombrePuestoDataGridViewTextBoxColumn.Name = "nombrePuestoDataGridViewTextBoxColumn";
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Id_Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "Id_Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            // 
            // L_Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 348);
            this.Controls.Add(this.dataGridView1);
            this.Name = "L_Puestos";
            this.Text = "L_Puestos";
            this.Load += new System.EventHandler(this.L_Puestos_Load);
            #region "Eventos heredados de la base"
            this.Evento_Agregar += new System.EventHandler(this.L_Puestos_Evento_Agregar);
            this.Evento_Modificar += new System.EventHandler(this.L_Puestos_Evento_Modificar);
            this.Evento_Borrar += new System.EventHandler(this.L_Puestos_Evento_Borrar);
            this.Evento_Consultar += new System.EventHandler(this.L_Puestos_Evento_Consultar);
            this.Evento_Cerrar += new System.EventHandler(this.L_Puestos_Evento_Cerrar);
            #endregion
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUESTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SIGVADataSet1 sIGVADataSet1;
        private System.Windows.Forms.BindingSource pUESTOSBindingSource;
        private SIGVADataSet1TableAdapters.PUESTOSTableAdapter pUESTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
    }
}