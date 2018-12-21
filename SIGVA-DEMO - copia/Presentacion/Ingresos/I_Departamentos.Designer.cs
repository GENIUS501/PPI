namespace Presentacion
{
    partial class I_Departamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_Departamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Departamento = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1DepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1Departamentos = new Presentacion.SIGVADataSet1Departamentos();
            this.dEPARTAMENTOSTableAdapter = new Presentacion.SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1DepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del departamento";
            // 
            // Txt_Departamento
            // 
            this.Txt_Departamento.Location = new System.Drawing.Point(15, 91);
            this.Txt_Departamento.Name = "Txt_Departamento";
            this.Txt_Departamento.Size = new System.Drawing.Size(100, 20);
            this.Txt_Departamento.TabIndex = 1;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(242, 438);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(385, 438);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.nombreDepartamentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dEPARTAMENTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Id_Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "Id_Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            this.idDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDepartamentoDataGridViewTextBoxColumn
            // 
            this.nombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Departamento";
            this.nombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "Nombre_Departamento";
            this.nombreDepartamentoDataGridViewTextBoxColumn.Name = "nombreDepartamentoDataGridViewTextBoxColumn";
            this.nombreDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEPARTAMENTOSBindingSource
            // 
            this.dEPARTAMENTOSBindingSource.DataMember = "DEPARTAMENTOS";
            this.dEPARTAMENTOSBindingSource.DataSource = this.sIGVADataSet1DepartamentosBindingSource;
            // 
            // sIGVADataSet1DepartamentosBindingSource
            // 
            this.sIGVADataSet1DepartamentosBindingSource.DataSource = this.sIGVADataSet1Departamentos;
            this.sIGVADataSet1DepartamentosBindingSource.Position = 0;
            // 
            // sIGVADataSet1Departamentos
            // 
            this.sIGVADataSet1Departamentos.DataSetName = "SIGVADataSet1Departamentos";
            this.sIGVADataSet1Departamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTAMENTOSTableAdapter
            // 
            this.dEPARTAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // I_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(720, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Txt_Departamento);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "I_Departamentos";
            this.Text = "I_Departamentos";
            this.Load += new System.EventHandler(this.I_Departamentos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_Departamento, 0);
            this.Controls.SetChildIndex(this.Btn_Agregar, 0);
            this.Controls.SetChildIndex(this.Btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1DepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Departamento;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sIGVADataSet1DepartamentosBindingSource;
        private SIGVADataSet1Departamentos sIGVADataSet1Departamentos;
        private System.Windows.Forms.BindingSource dEPARTAMENTOSBindingSource;
        private SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter dEPARTAMENTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepartamentoDataGridViewTextBoxColumn;
    }
}