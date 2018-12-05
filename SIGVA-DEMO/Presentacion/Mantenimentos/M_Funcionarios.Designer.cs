namespace Presentacion
{
    partial class M_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Funcionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.Cbo_Departamento = new System.Windows.Forms.ComboBox();
            this.dEPARTAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1DepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1Departamentos = new Presentacion.SIGVADataSet1Departamentos();
            this.Cbo_Puesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Anos_Institucion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cbo_Estatus = new System.Windows.Forms.ComboBox();
            this.Txt_Fecha_Anualidad = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cuadro = new System.Windows.Forms.GroupBox();
            this.Txt_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dEPARTAMENTOSTableAdapter = new Presentacion.SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1DepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cuadro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(184, 47);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(140, 20);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Primer apellido";
            // 
            // Txt_Apellido1
            // 
            this.Txt_Apellido1.Location = new System.Drawing.Point(344, 47);
            this.Txt_Apellido1.Name = "Txt_Apellido1";
            this.Txt_Apellido1.Size = new System.Drawing.Size(140, 20);
            this.Txt_Apellido1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Segundo apellido";
            // 
            // Txt_Apellido2
            // 
            this.Txt_Apellido2.Location = new System.Drawing.Point(504, 47);
            this.Txt_Apellido2.Name = "Txt_Apellido2";
            this.Txt_Apellido2.Size = new System.Drawing.Size(140, 20);
            this.Txt_Apellido2.TabIndex = 9;
            // 
            // Cbo_Departamento
            // 
            this.Cbo_Departamento.DataSource = this.dEPARTAMENTOSBindingSource;
            this.Cbo_Departamento.DisplayMember = "Nombre_Departamento";
            this.Cbo_Departamento.FormattingEnabled = true;
            this.Cbo_Departamento.Location = new System.Drawing.Point(6, 42);
            this.Cbo_Departamento.Name = "Cbo_Departamento";
            this.Cbo_Departamento.Size = new System.Drawing.Size(210, 21);
            this.Cbo_Departamento.TabIndex = 10;
            this.Cbo_Departamento.ValueMember = "Id_Departamento";
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
            // Cbo_Puesto
            // 
            this.Cbo_Puesto.FormattingEnabled = true;
            this.Cbo_Puesto.Location = new System.Drawing.Point(6, 83);
            this.Cbo_Puesto.Name = "Cbo_Puesto";
            this.Cbo_Puesto.Size = new System.Drawing.Size(210, 21);
            this.Cbo_Puesto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departamento";
            // 
            // Txt_Fecha_Ingreso
            // 
            this.Txt_Fecha_Ingreso.Location = new System.Drawing.Point(6, 135);
            this.Txt_Fecha_Ingreso.Name = "Txt_Fecha_Ingreso";
            this.Txt_Fecha_Ingreso.Size = new System.Drawing.Size(210, 20);
            this.Txt_Fecha_Ingreso.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // Txt_Anos_Institucion
            // 
            this.Txt_Anos_Institucion.Location = new System.Drawing.Point(229, 39);
            this.Txt_Anos_Institucion.Name = "Txt_Anos_Institucion";
            this.Txt_Anos_Institucion.Size = new System.Drawing.Size(39, 20);
            this.Txt_Anos_Institucion.TabIndex = 16;
            this.Txt_Anos_Institucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Anos_Institucion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Años Institucion Anterior";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(15, 108);
            this.Txt_Direccion.Multiline = true;
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(298, 99);
            this.Txt_Direccion.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Estatus";
            // 
            // Cbo_Estatus
            // 
            this.Cbo_Estatus.FormattingEnabled = true;
            this.Cbo_Estatus.Location = new System.Drawing.Point(229, 84);
            this.Cbo_Estatus.Name = "Cbo_Estatus";
            this.Cbo_Estatus.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Estatus.TabIndex = 23;
            // 
            // Txt_Fecha_Anualidad
            // 
            this.Txt_Fecha_Anualidad.Location = new System.Drawing.Point(6, 187);
            this.Txt_Fecha_Anualidad.Name = "Txt_Fecha_Anualidad";
            this.Txt_Fecha_Anualidad.Size = new System.Drawing.Size(210, 20);
            this.Txt_Fecha_Anualidad.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Fecha de anualidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Correo";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(139, 43);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(174, 20);
            this.Txt_Email.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.funcionario;
            this.pictureBox1.Location = new System.Drawing.Point(229, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // cuadro
            // 
            this.cuadro.Controls.Add(this.Txt_Cedula);
            this.cuadro.Controls.Add(this.Txt_Apellido2);
            this.cuadro.Controls.Add(this.label4);
            this.cuadro.Controls.Add(this.Txt_Apellido1);
            this.cuadro.Controls.Add(this.label3);
            this.cuadro.Controls.Add(this.Txt_Nombre);
            this.cuadro.Controls.Add(this.label2);
            this.cuadro.Controls.Add(this.label1);
            this.cuadro.Location = new System.Drawing.Point(13, 95);
            this.cuadro.Name = "cuadro";
            this.cuadro.Size = new System.Drawing.Size(704, 96);
            this.cuadro.TabIndex = 29;
            this.cuadro.TabStop = false;
            this.cuadro.Text = "Datos Personales";
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(17, 47);
            this.Txt_Cedula.Mask = "0000000000";
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(140, 20);
            this.Txt_Cedula.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Telefono);
            this.groupBox2.Controls.Add(this.Txt_Email);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Txt_Direccion);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 223);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Contacto";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(15, 43);
            this.Txt_Telefono.Mask = "00000000";
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(115, 20);
            this.Txt_Telefono.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Txt_Fecha_Anualidad);
            this.groupBox3.Controls.Add(this.Cbo_Estatus);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Txt_Anos_Institucion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Txt_Fecha_Ingreso);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Cbo_Puesto);
            this.groupBox3.Controls.Add(this.Cbo_Departamento);
            this.groupBox3.Location = new System.Drawing.Point(351, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 223);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Puesto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Años";
            // 
            // dEPARTAMENTOSTableAdapter
            // 
            this.dEPARTAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // M_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cuadro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "M_Funcionarios";
            this.Text = "M_Funcionarios";
            this.Evento_Aceptar += new System.EventHandler(this.M_Funcionarios_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.M_Funcionarios_Evento_Salir);
            this.Load += new System.EventHandler(this.M_Funcionarios_Load);
            this.Controls.SetChildIndex(this.cuadro, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1DepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cuadro.ResumeLayout(false);
            this.cuadro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Apellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Apellido2;
        private System.Windows.Forms.ComboBox Cbo_Departamento;
        private System.Windows.Forms.ComboBox Cbo_Puesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Ingreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Anos_Institucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cbo_Estatus;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Anualidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox cuadro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource sIGVADataSet1DepartamentosBindingSource;
        private SIGVADataSet1Departamentos sIGVADataSet1Departamentos;
        private System.Windows.Forms.BindingSource dEPARTAMENTOSBindingSource;
        private SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter dEPARTAMENTOSTableAdapter;
        private System.Windows.Forms.MaskedTextBox Txt_Cedula;
        private System.Windows.Forms.MaskedTextBox Txt_Telefono;
    }
}