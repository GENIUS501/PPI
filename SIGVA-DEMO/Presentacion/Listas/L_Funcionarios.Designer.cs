namespace Presentacion
{
    partial class L_Funcionarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_Departamentos = new System.Windows.Forms.ComboBox();
            this.dEPARTAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1Departamentos = new Presentacion.SIGVADataSet1Departamentos();
            this.sIGVADataSetfun = new Presentacion.SIGVADataSetfun();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter1 = new Presentacion.SIGVADataSetfunTableAdapters.FUNCIONARIOSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dEPARTAMENTOSTableAdapter = new Presentacion.SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            this.Txt_Cedula = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetfun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamentos";
            // 
            // Cbo_Departamentos
            // 
            this.Cbo_Departamentos.DataSource = this.dEPARTAMENTOSBindingSource;
            this.Cbo_Departamentos.DisplayMember = "Nombre_Departamento";
            this.Cbo_Departamentos.FormattingEnabled = true;
            this.Cbo_Departamentos.Location = new System.Drawing.Point(12, 172);
            this.Cbo_Departamentos.Name = "Cbo_Departamentos";
            this.Cbo_Departamentos.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Departamentos.TabIndex = 7;
            this.Cbo_Departamentos.ValueMember = "Id_Departamento";
            this.Cbo_Departamentos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dEPARTAMENTOSBindingSource
            // 
            this.dEPARTAMENTOSBindingSource.DataMember = "DEPARTAMENTOS";
            this.dEPARTAMENTOSBindingSource.DataSource = this.sIGVADataSet1Departamentos;
            // 
            // sIGVADataSet1Departamentos
            // 
            this.sIGVADataSet1Departamentos.DataSetName = "SIGVADataSet1Departamentos";
            this.sIGVADataSet1Departamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sIGVADataSetfun
            // 
            this.sIGVADataSetfun.DataSetName = "SIGVADataSetfun";
            this.sIGVADataSetfun.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.sIGVADataSetfun;
            // 
            // fUNCIONARIOSTableAdapter1
            // 
            this.fUNCIONARIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(862, 124);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dEPARTAMENTOSTableAdapter
            // 
            this.dEPARTAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cedula";
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.Location = new System.Drawing.Point(139, 118);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Buscar.TabIndex = 11;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = true;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(15, 121);
            this.Txt_Cedula.Mask = "0000000000";
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(118, 20);
            this.Txt_Cedula.TabIndex = 12;
            // 
            // L_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 348);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.Cmd_Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cbo_Departamentos);
            this.Controls.Add(this.label2);
            this.Name = "L_Funcionarios";
            this.Text = "Lista de funcionarios";
            this.Evento_Agregar += new System.EventHandler(this.L_Funcionarios_Evento_Agregar);
            this.Evento_Modificar += new System.EventHandler(this.L_Funcionarios_Evento_Modificar);
            this.Evento_Borrar += new System.EventHandler(this.L_Funcionarios_Evento_Borrar);
            this.Evento_Consultar += new System.EventHandler(this.L_Funcionarios_Evento_Consultar);
            this.Evento_Cerrar += new System.EventHandler(this.L_Funcionarios_Evento_Cerrar);
            this.Load += new System.EventHandler(this.L_Funcionarios_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Cbo_Departamentos, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Cmd_Buscar, 0);
            this.Controls.SetChildIndex(this.Txt_Cedula, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetfun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_Departamentos;
        private SIGVADataSetfun sIGVADataSetfun;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private SIGVADataSetfunTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SIGVADataSet1Departamentos sIGVADataSet1Departamentos;
        private System.Windows.Forms.BindingSource dEPARTAMENTOSBindingSource;
        private SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter dEPARTAMENTOSTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cmd_Buscar;
        private System.Windows.Forms.MaskedTextBox Txt_Cedula;
    }
}