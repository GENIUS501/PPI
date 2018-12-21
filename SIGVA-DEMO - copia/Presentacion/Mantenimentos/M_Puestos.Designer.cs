namespace Presentacion
{
    partial class M_Puestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Puestos));
            this.Txt_Id_Puesto = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Puesto = new System.Windows.Forms.TextBox();
            this.Cbo_Departamento = new System.Windows.Forms.ComboBox();
            this.dEPARTAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1Departamentos = new Presentacion.SIGVADataSet1Departamentos();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dEPARTAMENTOSTableAdapter = new Presentacion.SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Id_Puesto
            // 
            this.Txt_Id_Puesto.Location = new System.Drawing.Point(12, 171);
            this.Txt_Id_Puesto.Name = "Txt_Id_Puesto";
            this.Txt_Id_Puesto.Size = new System.Drawing.Size(100, 20);
            this.Txt_Id_Puesto.TabIndex = 2;
            // 
            // Txt_Nombre_Puesto
            // 
            this.Txt_Nombre_Puesto.Location = new System.Drawing.Point(147, 171);
            this.Txt_Nombre_Puesto.Name = "Txt_Nombre_Puesto";
            this.Txt_Nombre_Puesto.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre_Puesto.TabIndex = 3;
            // 
            // Cbo_Departamento
            // 
            this.Cbo_Departamento.DataSource = this.dEPARTAMENTOSBindingSource;
            this.Cbo_Departamento.DisplayMember = "Nombre_Departamento";
            this.Cbo_Departamento.FormattingEnabled = true;
            this.Cbo_Departamento.Location = new System.Drawing.Point(12, 104);
            this.Cbo_Departamento.Name = "Cbo_Departamento";
            this.Cbo_Departamento.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Departamento.TabIndex = 4;
            this.Cbo_Departamento.ValueMember = "Id_Departamento";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id del Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departamento";
            // 
            // dEPARTAMENTOSTableAdapter
            // 
            this.dEPARTAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // M_Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(723, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_Departamento);
            this.Controls.Add(this.Txt_Nombre_Puesto);
            this.Controls.Add(this.Txt_Id_Puesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "M_Puestos";
            this.Text = "M_Puestos";
            this.Evento_Aceptar += new System.EventHandler(this.M_Puestos_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.M_Puestos_Evento_Salir);
            this.Load += new System.EventHandler(this.M_Puestos_Load);
            this.Controls.SetChildIndex(this.Txt_Id_Puesto, 0);
            this.Controls.SetChildIndex(this.Txt_Nombre_Puesto, 0);
            this.Controls.SetChildIndex(this.Cbo_Departamento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Id_Puesto;
        private System.Windows.Forms.TextBox Txt_Nombre_Puesto;
        private System.Windows.Forms.ComboBox Cbo_Departamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SIGVADataSet1Departamentos sIGVADataSet1Departamentos;
        private System.Windows.Forms.BindingSource dEPARTAMENTOSBindingSource;
        private SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter dEPARTAMENTOSTableAdapter;
    }
}