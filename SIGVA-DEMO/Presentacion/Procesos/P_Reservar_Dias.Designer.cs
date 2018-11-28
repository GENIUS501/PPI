namespace Presentacion
{
    partial class P_Reservar_Dias
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
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.Txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Txt_Fecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Fecha_Final = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Dias = new System.Windows.Forms.TextBox();
            this.Txt_Detalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dat_Dias_Disponibles = new System.Windows.Forms.DataGridView();
            this.diasDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSetDias_Disponibles = new Presentacion.SIGVADataSetDias_Disponibles();
            this.dias_DisponiblesTableAdapter = new Presentacion.SIGVADataSetDias_DisponiblesTableAdapters.Dias_DisponiblesTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.Dat_Dias_Reservados = new System.Windows.Forms.DataGridView();
            this.diasReservadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSetdiasreservados = new Presentacion.SIGVADataSetdiasreservados();
            this.label10 = new System.Windows.Forms.Label();
            this.dias_ReservadosTableAdapter = new Presentacion.SIGVADataSetdiasreservadosTableAdapters.Dias_ReservadosTableAdapter();
            this.Cmd_Reservar = new System.Windows.Forms.Button();
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.Txt_Cedula = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetDias_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Reservados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReservadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetdiasreservados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Location = new System.Drawing.Point(18, 71);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(40, 13);
            this.lbl_cedula.TabIndex = 2;
            this.lbl_cedula.Text = "Cedula";
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Buscar.Location = new System.Drawing.Point(127, 87);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Buscar.TabIndex = 4;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = false;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Inicial";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(26, 160);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // Txt_Apellido1
            // 
            this.Txt_Apellido1.Location = new System.Drawing.Point(144, 159);
            this.Txt_Apellido1.Name = "Txt_Apellido1";
            this.Txt_Apellido1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Apellido1.TabIndex = 11;
            // 
            // Txt_Apellido2
            // 
            this.Txt_Apellido2.Location = new System.Drawing.Point(259, 159);
            this.Txt_Apellido2.Name = "Txt_Apellido2";
            this.Txt_Apellido2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Apellido2.TabIndex = 12;
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(379, 159);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.Txt_Telefono.TabIndex = 13;
            // 
            // Txt_Fecha_Inicial
            // 
            this.Txt_Fecha_Inicial.Location = new System.Drawing.Point(26, 219);
            this.Txt_Fecha_Inicial.Name = "Txt_Fecha_Inicial";
            this.Txt_Fecha_Inicial.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Inicial.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha_Final";
            // 
            // Txt_Fecha_Final
            // 
            this.Txt_Fecha_Final.Location = new System.Drawing.Point(259, 218);
            this.Txt_Fecha_Final.Name = "Txt_Fecha_Final";
            this.Txt_Fecha_Final.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Final.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad de dias a reservar";
            // 
            // Txt_Cantidad_Dias
            // 
            this.Txt_Cantidad_Dias.Location = new System.Drawing.Point(26, 269);
            this.Txt_Cantidad_Dias.Name = "Txt_Cantidad_Dias";
            this.Txt_Cantidad_Dias.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cantidad_Dias.TabIndex = 18;
            // 
            // Txt_Detalle
            // 
            this.Txt_Detalle.Location = new System.Drawing.Point(169, 269);
            this.Txt_Detalle.Multiline = true;
            this.Txt_Detalle.Name = "Txt_Detalle";
            this.Txt_Detalle.Size = new System.Drawing.Size(130, 36);
            this.Txt_Detalle.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Detalle";
            // 
            // Dat_Dias_Disponibles
            // 
            this.Dat_Dias_Disponibles.AllowUserToAddRows = false;
            this.Dat_Dias_Disponibles.AllowUserToDeleteRows = false;
            this.Dat_Dias_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Dias_Disponibles.Location = new System.Drawing.Point(14, 325);
            this.Dat_Dias_Disponibles.Name = "Dat_Dias_Disponibles";
            this.Dat_Dias_Disponibles.ReadOnly = true;
            this.Dat_Dias_Disponibles.Size = new System.Drawing.Size(342, 119);
            this.Dat_Dias_Disponibles.TabIndex = 21;
            // 
            // diasDisponiblesBindingSource
            // 
            this.diasDisponiblesBindingSource.DataMember = "Dias_Disponibles";
            this.diasDisponiblesBindingSource.DataSource = this.sIGVADataSetDias_Disponibles;
            // 
            // sIGVADataSetDias_Disponibles
            // 
            this.sIGVADataSetDias_Disponibles.DataSetName = "SIGVADataSetDias_Disponibles";
            this.sIGVADataSetDias_Disponibles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dias_DisponiblesTableAdapter
            // 
            this.dias_DisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Dias Disponibles";
            // 
            // Dat_Dias_Reservados
            // 
            this.Dat_Dias_Reservados.AllowUserToAddRows = false;
            this.Dat_Dias_Reservados.AllowUserToDeleteRows = false;
            this.Dat_Dias_Reservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Dias_Reservados.Location = new System.Drawing.Point(383, 325);
            this.Dat_Dias_Reservados.Name = "Dat_Dias_Reservados";
            this.Dat_Dias_Reservados.ReadOnly = true;
            this.Dat_Dias_Reservados.Size = new System.Drawing.Size(341, 119);
            this.Dat_Dias_Reservados.TabIndex = 23;
            // 
            // diasReservadosBindingSource
            // 
            this.diasReservadosBindingSource.DataMember = "Dias_Reservados";
            this.diasReservadosBindingSource.DataSource = this.sIGVADataSetdiasreservados;
            // 
            // sIGVADataSetdiasreservados
            // 
            this.sIGVADataSetdiasreservados.DataSetName = "SIGVADataSetdiasreservados";
            this.sIGVADataSetdiasreservados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Dias reservados";
            // 
            // dias_ReservadosTableAdapter
            // 
            this.dias_ReservadosTableAdapter.ClearBeforeFill = true;
            // 
            // Cmd_Reservar
            // 
            this.Cmd_Reservar.Location = new System.Drawing.Point(224, 475);
            this.Cmd_Reservar.Name = "Cmd_Reservar";
            this.Cmd_Reservar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Reservar.TabIndex = 25;
            this.Cmd_Reservar.Text = "Reservar";
            this.Cmd_Reservar.UseVisualStyleBackColor = true;
            this.Cmd_Reservar.Click += new System.EventHandler(this.Cmd_Reservar_Click);
            // 
            // Cmd_Cancelar
            // 
            this.Cmd_Cancelar.Location = new System.Drawing.Point(421, 474);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancelar.TabIndex = 26;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = true;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha de cumplimiento de vacaciones";
            // 
            // Txt_Fecha_Ingreso
            // 
            this.Txt_Fecha_Ingreso.Location = new System.Drawing.Point(495, 159);
            this.Txt_Fecha_Ingreso.Name = "Txt_Fecha_Ingreso";
            this.Txt_Fecha_Ingreso.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Ingreso.TabIndex = 28;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(21, 90);
            this.Txt_Cedula.Mask = "000000000";
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cedula.TabIndex = 29;
            // 
            // P_Reservar_Dias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 524);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.Txt_Fecha_Ingreso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Cmd_Cancelar);
            this.Controls.Add(this.Cmd_Reservar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dat_Dias_Reservados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dat_Dias_Disponibles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Detalle);
            this.Controls.Add(this.Txt_Cantidad_Dias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Fecha_Final);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Fecha_Inicial);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.Txt_Apellido2);
            this.Controls.Add(this.Txt_Apellido1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmd_Buscar);
            this.Controls.Add(this.lbl_cedula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P_Reservar_Dias";
            this.Text = "P_Reservar_Dias";
            this.Load += new System.EventHandler(this.P_Reservar_Dias_Load);
            this.Controls.SetChildIndex(this.lbl_cedula, 0);
            this.Controls.SetChildIndex(this.Cmd_Buscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Txt_Nombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.Txt_Apellido1, 0);
            this.Controls.SetChildIndex(this.Txt_Apellido2, 0);
            this.Controls.SetChildIndex(this.Txt_Telefono, 0);
            this.Controls.SetChildIndex(this.Txt_Fecha_Inicial, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.Txt_Fecha_Final, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Txt_Cantidad_Dias, 0);
            this.Controls.SetChildIndex(this.Txt_Detalle, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.Dat_Dias_Disponibles, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.Dat_Dias_Reservados, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.Cmd_Reservar, 0);
            this.Controls.SetChildIndex(this.Cmd_Cancelar, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.Txt_Fecha_Ingreso, 0);
            this.Controls.SetChildIndex(this.Txt_Cedula, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetDias_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Reservados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReservadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetdiasreservados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Button Cmd_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Apellido1;
        private System.Windows.Forms.TextBox Txt_Apellido2;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Inicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Final;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Cantidad_Dias;
        private System.Windows.Forms.TextBox Txt_Detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dat_Dias_Disponibles;
        private SIGVADataSetDias_Disponibles sIGVADataSetDias_Disponibles;
        private System.Windows.Forms.BindingSource diasDisponiblesBindingSource;
        private SIGVADataSetDias_DisponiblesTableAdapters.Dias_DisponiblesTableAdapter dias_DisponiblesTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dat_Dias_Reservados;
        private System.Windows.Forms.Label label10;
        private SIGVADataSetdiasreservados sIGVADataSetdiasreservados;
        private System.Windows.Forms.BindingSource diasReservadosBindingSource;
        private SIGVADataSetdiasreservadosTableAdapters.Dias_ReservadosTableAdapter dias_ReservadosTableAdapter;
        private System.Windows.Forms.Button Cmd_Reservar;
        private System.Windows.Forms.Button Cmd_Cancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Ingreso;
        private System.Windows.Forms.MaskedTextBox Txt_Cedula;
    }
}