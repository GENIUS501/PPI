namespace Presentacion
{
    partial class I_Funcionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.Txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbo_Departamento = new System.Windows.Forms.ComboBox();
            this.dEPARTAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet1Departamentos = new Presentacion.SIGVADataSet1Departamentos();
            this.Cbo_Puesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Rad_Posee = new System.Windows.Forms.RadioButton();
            this.Rad_noposee = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Anos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Cmd_Agregar = new System.Windows.Forms.Button();
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Txt_Fecha_Anualidad = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dEPARTAMENTOSTableAdapter = new Presentacion.SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(27, 87);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(121, 20);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // Txt_Apellido1
            // 
            this.Txt_Apellido1.Location = new System.Drawing.Point(184, 87);
            this.Txt_Apellido1.Name = "Txt_Apellido1";
            this.Txt_Apellido1.Size = new System.Drawing.Size(121, 20);
            this.Txt_Apellido1.TabIndex = 2;
            // 
            // Txt_Apellido2
            // 
            this.Txt_Apellido2.Location = new System.Drawing.Point(348, 87);
            this.Txt_Apellido2.Name = "Txt_Apellido2";
            this.Txt_Apellido2.Size = new System.Drawing.Size(129, 20);
            this.Txt_Apellido2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Segundo Apellido";
            // 
            // Cbo_Departamento
            // 
            this.Cbo_Departamento.DataSource = this.dEPARTAMENTOSBindingSource;
            this.Cbo_Departamento.DisplayMember = "Nombre_Departamento";
            this.Cbo_Departamento.FormattingEnabled = true;
            this.Cbo_Departamento.Location = new System.Drawing.Point(27, 144);
            this.Cbo_Departamento.Name = "Cbo_Departamento";
            this.Cbo_Departamento.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Departamento.TabIndex = 4;
            this.Cbo_Departamento.ValueMember = "Id_Departamento";
            this.Cbo_Departamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Cbo_Puesto
            // 
            this.Cbo_Puesto.FormattingEnabled = true;
            this.Cbo_Puesto.Location = new System.Drawing.Point(184, 144);
            this.Cbo_Puesto.Name = "Cbo_Puesto";
            this.Cbo_Puesto.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Puesto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Puesto";
            // 
            // Rad_Posee
            // 
            this.Rad_Posee.AutoSize = true;
            this.Rad_Posee.Location = new System.Drawing.Point(93, 289);
            this.Rad_Posee.Name = "Rad_Posee";
            this.Rad_Posee.Size = new System.Drawing.Size(55, 17);
            this.Rad_Posee.TabIndex = 9;
            this.Rad_Posee.TabStop = true;
            this.Rad_Posee.Text = "Posee";
            this.Rad_Posee.UseVisualStyleBackColor = true;
            this.Rad_Posee.Click += new System.EventHandler(this.Rad_Posee_Click);
            // 
            // Rad_noposee
            // 
            this.Rad_noposee.AutoSize = true;
            this.Rad_noposee.Location = new System.Drawing.Point(213, 289);
            this.Rad_noposee.Name = "Rad_noposee";
            this.Rad_noposee.Size = new System.Drawing.Size(71, 17);
            this.Rad_noposee.TabIndex = 10;
            this.Rad_noposee.TabStop = true;
            this.Rad_noposee.Text = "No posee";
            this.Rad_noposee.UseVisualStyleBackColor = true;
            this.Rad_noposee.Click += new System.EventHandler(this.Rad_noposee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Posee anualidades de instituciones publicas";
            // 
            // Txt_Cantidad_Anos
            // 
            this.Txt_Cantidad_Anos.Location = new System.Drawing.Point(31, 325);
            this.Txt_Cantidad_Anos.Name = "Txt_Cantidad_Anos";
            this.Txt_Cantidad_Anos.Size = new System.Drawing.Size(41, 20);
            this.Txt_Cantidad_Anos.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad de años provenientes de la institucion anterior";
            // 
            // Txt_Fecha_Ingreso
            // 
            this.Txt_Fecha_Ingreso.Location = new System.Drawing.Point(31, 381);
            this.Txt_Fecha_Ingreso.Name = "Txt_Fecha_Ingreso";
            this.Txt_Fecha_Ingreso.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Ingreso.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de Ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Direccion";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(235, 199);
            this.Txt_Direccion.Multiline = true;
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(242, 62);
            this.Txt_Direccion.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(27, 199);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(169, 20);
            this.Txt_Email.TabIndex = 7;
            // 
            // Cmd_Agregar
            // 
            this.Cmd_Agregar.Location = new System.Drawing.Point(319, 416);
            this.Cmd_Agregar.Name = "Cmd_Agregar";
            this.Cmd_Agregar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Agregar.TabIndex = 14;
            this.Cmd_Agregar.Text = "Agregar";
            this.Cmd_Agregar.UseVisualStyleBackColor = true;
            this.Cmd_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cmd_Cancelar
            // 
            this.Cmd_Cancelar.Location = new System.Drawing.Point(402, 416);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancelar.TabIndex = 15;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = true;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_Fecha_Anualidad
            // 
            this.Txt_Fecha_Anualidad.Location = new System.Drawing.Point(262, 381);
            this.Txt_Fecha_Anualidad.Name = "Txt_Fecha_Anualidad";
            this.Txt_Fecha_Anualidad.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Anualidad.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Fecha de anualidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.funcionario;
            this.pictureBox1.Location = new System.Drawing.Point(539, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Telefono);
            this.groupBox1.Controls.Add(this.Txt_Cedula);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Txt_Fecha_Anualidad);
            this.groupBox1.Controls.Add(this.Cmd_Cancelar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Txt_Direccion);
            this.groupBox1.Controls.Add(this.Cmd_Agregar);
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_Fecha_Ingreso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_Cantidad_Anos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Rad_noposee);
            this.groupBox1.Controls.Add(this.Rad_Posee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cbo_Puesto);
            this.groupBox1.Controls.Add(this.Cbo_Departamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Apellido2);
            this.groupBox1.Controls.Add(this.Txt_Apellido1);
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Funcionarios";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(348, 145);
            this.Txt_Telefono.Mask = "00000000";
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(129, 20);
            this.Txt_Telefono.TabIndex = 6;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(27, 42);
            this.Txt_Cedula.Mask = "0000000000";
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(121, 20);
            this.Txt_Cedula.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Años";
            // 
            // dEPARTAMENTOSTableAdapter
            // 
            this.dEPARTAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // I_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "I_Funcionarios";
            this.Text = "Ingresar Funcionarios";
            this.Load += new System.EventHandler(this.I_Funcionarios_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet1Departamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Apellido1;
        private System.Windows.Forms.TextBox Txt_Apellido2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbo_Departamento;
        private System.Windows.Forms.ComboBox Cbo_Puesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Rad_Posee;
        private System.Windows.Forms.RadioButton Rad_noposee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Cantidad_Anos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Ingreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Cmd_Agregar;
        private System.Windows.Forms.Button Cmd_Cancelar;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Anualidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private SIGVADataSet1Departamentos sIGVADataSet1Departamentos;
        private System.Windows.Forms.BindingSource dEPARTAMENTOSBindingSource;
        private SIGVADataSet1DepartamentosTableAdapters.DEPARTAMENTOSTableAdapter dEPARTAMENTOSTableAdapter;
        private System.Windows.Forms.MaskedTextBox Txt_Telefono;
        private System.Windows.Forms.MaskedTextBox Txt_Cedula;
    }
}