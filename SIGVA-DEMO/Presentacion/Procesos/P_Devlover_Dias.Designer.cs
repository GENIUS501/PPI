namespace Presentacion
{
    partial class P_Devlover_Dias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Devlover_Dias));
            this.label1 = new System.Windows.Forms.Label();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            this.Txt_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.Txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Numero_Boleta = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad_Dias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Detalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dat_Dias_Disponibles = new System.Windows.Forms.DataGridView();
            this.diasDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSetDiasDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSetDias_Disponibles = new Presentacion.SIGVADataSetDias_Disponibles();
            this.dias_DisponiblesTableAdapter = new Presentacion.SIGVADataSetDias_DisponiblesTableAdapters.Dias_DisponiblesTableAdapter();
            this.Dat_Dias_Reservados = new System.Windows.Forms.DataGridView();
            this.diasReservadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSetdiasreservados = new Presentacion.SIGVADataSetdiasreservados();
            this.dias_ReservadosTableAdapter = new Presentacion.SIGVADataSetdiasreservadosTableAdapters.Dias_ReservadosTableAdapter();
            this.Dat_Dias_Devolucion = new System.Windows.Forms.DataGridView();
            this.dIASDEVOLUCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSetdiasdevueltos = new Presentacion.SIGVADataSetdiasdevueltos();
            this.dIAS_DEVOLUCIONTableAdapter = new Presentacion.SIGVADataSetdiasdevueltosTableAdapters.DIAS_DEVOLUCIONTableAdapter();
            this.Cmd_Devolver = new System.Windows.Forms.Button();
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Txt_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetDiasDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetDias_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Reservados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReservadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetdiasreservados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIASDEVOLUCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetdiasdevueltos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cedula";
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.Location = new System.Drawing.Point(122, 78);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Buscar.TabIndex = 4;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = true;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // Txt_Fecha_Ingreso
            // 
            this.Txt_Fecha_Ingreso.Location = new System.Drawing.Point(486, 143);
            this.Txt_Fecha_Ingreso.Name = "Txt_Fecha_Ingreso";
            this.Txt_Fecha_Ingreso.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Ingreso.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Fecha de cumplimiento de vacaciones";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(370, 143);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.Txt_Telefono.TabIndex = 36;
            // 
            // Txt_Apellido2
            // 
            this.Txt_Apellido2.Location = new System.Drawing.Point(250, 143);
            this.Txt_Apellido2.Name = "Txt_Apellido2";
            this.Txt_Apellido2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Apellido2.TabIndex = 35;
            // 
            // Txt_Apellido1
            // 
            this.Txt_Apellido1.Location = new System.Drawing.Point(135, 143);
            this.Txt_Apellido1.Name = "Txt_Apellido1";
            this.Txt_Apellido1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Apellido1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefono";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(17, 144);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Segundo Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Numero de boleta";
            // 
            // Txt_Numero_Boleta
            // 
            this.Txt_Numero_Boleta.Location = new System.Drawing.Point(17, 209);
            this.Txt_Numero_Boleta.Name = "Txt_Numero_Boleta";
            this.Txt_Numero_Boleta.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero_Boleta.TabIndex = 40;
            this.Txt_Numero_Boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero_Boleta_KeyPress);
            // 
            // Txt_Cantidad_Dias
            // 
            this.Txt_Cantidad_Dias.Location = new System.Drawing.Point(135, 208);
            this.Txt_Cantidad_Dias.Name = "Txt_Cantidad_Dias";
            this.Txt_Cantidad_Dias.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cantidad_Dias.TabIndex = 41;
            this.Txt_Cantidad_Dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_Dias_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cantidad de dias a devolver";
            // 
            // Txt_Detalle
            // 
            this.Txt_Detalle.Location = new System.Drawing.Point(293, 208);
            this.Txt_Detalle.Multiline = true;
            this.Txt_Detalle.Name = "Txt_Detalle";
            this.Txt_Detalle.Size = new System.Drawing.Size(123, 41);
            this.Txt_Detalle.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Detalle";
            // 
            // Dat_Dias_Disponibles
            // 
            this.Dat_Dias_Disponibles.AllowUserToAddRows = false;
            this.Dat_Dias_Disponibles.AllowUserToDeleteRows = false;
            this.Dat_Dias_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Dias_Disponibles.Location = new System.Drawing.Point(372, 390);
            this.Dat_Dias_Disponibles.Name = "Dat_Dias_Disponibles";
            this.Dat_Dias_Disponibles.ReadOnly = true;
            this.Dat_Dias_Disponibles.Size = new System.Drawing.Size(344, 89);
            this.Dat_Dias_Disponibles.TabIndex = 45;
            // 
            // diasDisponiblesBindingSource
            // 
            this.diasDisponiblesBindingSource.DataMember = "Dias_Disponibles";
            this.diasDisponiblesBindingSource.DataSource = this.sIGVADataSetDiasDisponiblesBindingSource;
            // 
            // sIGVADataSetDiasDisponiblesBindingSource
            // 
            this.sIGVADataSetDiasDisponiblesBindingSource.DataSource = this.sIGVADataSetDias_Disponibles;
            this.sIGVADataSetDiasDisponiblesBindingSource.Position = 0;
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
            // Dat_Dias_Reservados
            // 
            this.Dat_Dias_Reservados.AllowUserToAddRows = false;
            this.Dat_Dias_Reservados.AllowUserToDeleteRows = false;
            this.Dat_Dias_Reservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Dias_Reservados.Location = new System.Drawing.Point(15, 269);
            this.Dat_Dias_Reservados.Name = "Dat_Dias_Reservados";
            this.Dat_Dias_Reservados.ReadOnly = true;
            this.Dat_Dias_Reservados.Size = new System.Drawing.Size(442, 91);
            this.Dat_Dias_Reservados.TabIndex = 46;
            this.Dat_Dias_Reservados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_Dias_Reservados_CellClick);
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
            // dias_ReservadosTableAdapter
            // 
            this.dias_ReservadosTableAdapter.ClearBeforeFill = true;
            // 
            // Dat_Dias_Devolucion
            // 
            this.Dat_Dias_Devolucion.AllowUserToAddRows = false;
            this.Dat_Dias_Devolucion.AllowUserToDeleteRows = false;
            this.Dat_Dias_Devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Dias_Devolucion.Location = new System.Drawing.Point(9, 390);
            this.Dat_Dias_Devolucion.Name = "Dat_Dias_Devolucion";
            this.Dat_Dias_Devolucion.ReadOnly = true;
            this.Dat_Dias_Devolucion.Size = new System.Drawing.Size(341, 90);
            this.Dat_Dias_Devolucion.TabIndex = 47;
            // 
            // dIASDEVOLUCIONBindingSource
            // 
            this.dIASDEVOLUCIONBindingSource.DataMember = "DIAS_DEVOLUCION";
            this.dIASDEVOLUCIONBindingSource.DataSource = this.sIGVADataSetdiasdevueltos;
            // 
            // sIGVADataSetdiasdevueltos
            // 
            this.sIGVADataSetdiasdevueltos.DataSetName = "SIGVADataSetdiasdevueltos";
            this.sIGVADataSetdiasdevueltos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIAS_DEVOLUCIONTableAdapter
            // 
            this.dIAS_DEVOLUCIONTableAdapter.ClearBeforeFill = true;
            // 
            // Cmd_Devolver
            // 
            this.Cmd_Devolver.Location = new System.Drawing.Point(250, 486);
            this.Cmd_Devolver.Name = "Cmd_Devolver";
            this.Cmd_Devolver.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Devolver.TabIndex = 49;
            this.Cmd_Devolver.Text = "Devolver";
            this.Cmd_Devolver.UseVisualStyleBackColor = true;
            this.Cmd_Devolver.Click += new System.EventHandler(this.Cmd_Devolver_Click);
            // 
            // Cmd_Cancelar
            // 
            this.Cmd_Cancelar.Location = new System.Drawing.Point(380, 485);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancelar.TabIndex = 50;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = true;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(17, 81);
            this.Txt_Cedula.Mask = "0000000000";
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cedula.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Dias Disponibles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Dias Devueltos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Dias Disfrutados";
            // 
            // P_Devlover_Dias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(724, 521);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.Cmd_Cancelar);
            this.Controls.Add(this.Cmd_Devolver);
            this.Controls.Add(this.Dat_Dias_Devolucion);
            this.Controls.Add(this.Dat_Dias_Reservados);
            this.Controls.Add(this.Dat_Dias_Disponibles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Detalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Cantidad_Dias);
            this.Controls.Add(this.Txt_Numero_Boleta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Fecha_Ingreso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.Txt_Apellido2);
            this.Controls.Add(this.Txt_Apellido1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmd_Buscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "P_Devlover_Dias";
            this.Text = "Devolucion de Dias";
            this.Load += new System.EventHandler(this.P_Devlover_Dias_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Cmd_Buscar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txt_Nombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.Txt_Apellido1, 0);
            this.Controls.SetChildIndex(this.Txt_Apellido2, 0);
            this.Controls.SetChildIndex(this.Txt_Telefono, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.Txt_Fecha_Ingreso, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.Txt_Numero_Boleta, 0);
            this.Controls.SetChildIndex(this.Txt_Cantidad_Dias, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Txt_Detalle, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.Dat_Dias_Disponibles, 0);
            this.Controls.SetChildIndex(this.Dat_Dias_Reservados, 0);
            this.Controls.SetChildIndex(this.Dat_Dias_Devolucion, 0);
            this.Controls.SetChildIndex(this.Cmd_Devolver, 0);
            this.Controls.SetChildIndex(this.Cmd_Cancelar, 0);
            this.Controls.SetChildIndex(this.Txt_Cedula, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetDiasDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetDias_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Reservados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReservadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetdiasreservados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Dias_Devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIASDEVOLUCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetdiasdevueltos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cmd_Buscar;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Ingreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.TextBox Txt_Apellido2;
        private System.Windows.Forms.TextBox Txt_Apellido1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Numero_Boleta;
        private System.Windows.Forms.TextBox Txt_Cantidad_Dias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dat_Dias_Disponibles;
        private System.Windows.Forms.BindingSource sIGVADataSetDiasDisponiblesBindingSource;
        private SIGVADataSetDias_Disponibles sIGVADataSetDias_Disponibles;
        private System.Windows.Forms.BindingSource diasDisponiblesBindingSource;
        private SIGVADataSetDias_DisponiblesTableAdapters.Dias_DisponiblesTableAdapter dias_DisponiblesTableAdapter;
        private System.Windows.Forms.DataGridView Dat_Dias_Reservados;
        private SIGVADataSetdiasreservados sIGVADataSetdiasreservados;
        private System.Windows.Forms.BindingSource diasReservadosBindingSource;
        private SIGVADataSetdiasreservadosTableAdapters.Dias_ReservadosTableAdapter dias_ReservadosTableAdapter;
        private System.Windows.Forms.DataGridView Dat_Dias_Devolucion;
        private SIGVADataSetdiasdevueltos sIGVADataSetdiasdevueltos;
        private System.Windows.Forms.BindingSource dIASDEVOLUCIONBindingSource;
        private SIGVADataSetdiasdevueltosTableAdapters.DIAS_DEVOLUCIONTableAdapter dIAS_DEVOLUCIONTableAdapter;
        private System.Windows.Forms.Button Cmd_Devolver;
        private System.Windows.Forms.Button Cmd_Cancelar;
        private System.Windows.Forms.MaskedTextBox Txt_Cedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}