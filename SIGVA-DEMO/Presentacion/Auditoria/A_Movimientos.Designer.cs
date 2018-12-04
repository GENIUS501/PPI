namespace Presentacion
{
    partial class A_Movimientos
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
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            this.Dat_Bitacora = new System.Windows.Forms.DataGridView();
            this.idMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIGVADataSet2 = new Presentacion.SIGVADataSet2();
            this.bitacoraTableAdapter = new Presentacion.SIGVADataSet2TableAdapters.BitacoraTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmd_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sIGVADataSet_Bitacora = new Presentacion.SIGVADataSet_Bitacora();
            this.bitacoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bitacoraTableAdapter1 = new Presentacion.SIGVADataSet_BitacoraTableAdapters.BitacoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Bitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet_Bitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(119, 31);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(144, 20);
            this.Txt_Usuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.Location = new System.Drawing.Point(366, 31);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(84, 24);
            this.Cmd_Buscar.TabIndex = 4;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = true;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // Dat_Bitacora
            // 
            this.Dat_Bitacora.AllowUserToAddRows = false;
            this.Dat_Bitacora.AllowUserToDeleteRows = false;
            this.Dat_Bitacora.AutoGenerateColumns = false;
            this.Dat_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Bitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovimientoDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn,
            this.fechaHoraDataGridViewTextBoxColumn,
            this.tablaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.Dat_Bitacora.DataSource = this.bitacoraBindingSource1;
            this.Dat_Bitacora.Location = new System.Drawing.Point(17, 68);
            this.Dat_Bitacora.Name = "Dat_Bitacora";
            this.Dat_Bitacora.ReadOnly = true;
            this.Dat_Bitacora.Size = new System.Drawing.Size(542, 150);
            this.Dat_Bitacora.TabIndex = 5;
            // 
            // idMovimientoDataGridViewTextBoxColumn
            // 
            this.idMovimientoDataGridViewTextBoxColumn.DataPropertyName = "Id_Movimiento";
            this.idMovimientoDataGridViewTextBoxColumn.HeaderText = "Id_Movimiento";
            this.idMovimientoDataGridViewTextBoxColumn.Name = "idMovimientoDataGridViewTextBoxColumn";
            this.idMovimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "Accion";
            this.accionDataGridViewTextBoxColumn.HeaderText = "Accion";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            this.fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            this.fechaHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaDataGridViewTextBoxColumn
            // 
            this.tablaDataGridViewTextBoxColumn.DataPropertyName = "Tabla";
            this.tablaDataGridViewTextBoxColumn.HeaderText = "Tabla";
            this.tablaDataGridViewTextBoxColumn.Name = "tablaDataGridViewTextBoxColumn";
            this.tablaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bitacoraBindingSource
            // 
            this.bitacoraBindingSource.DataMember = "Bitacora";
            this.bitacoraBindingSource.DataSource = this.sIGVADataSet2;
            // 
            // sIGVADataSet2
            // 
            this.sIGVADataSet2.DataSetName = "SIGVADataSet2";
            this.sIGVADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacoraTableAdapter
            // 
            this.bitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dat_Bitacora);
            this.groupBox1.Controls.Add(this.Cmd_Buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 243);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitácora de Movimientos  por Nombre de Usuario";
            // 
            // Cmd_Imprimir
            // 
            this.Cmd_Imprimir.Location = new System.Drawing.Point(627, 194);
            this.Cmd_Imprimir.Name = "Cmd_Imprimir";
            this.Cmd_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Imprimir.TabIndex = 7;
            this.Cmd_Imprimir.Text = "Imprimir";
            this.Cmd_Imprimir.UseVisualStyleBackColor = true;
            this.Cmd_Imprimir.Click += new System.EventHandler(this.Cmd_Imprimir_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(627, 244);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 8;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Sesiones;
            this.pictureBox1.Location = new System.Drawing.Point(611, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // sIGVADataSet_Bitacora
            // 
            this.sIGVADataSet_Bitacora.DataSetName = "SIGVADataSet_Bitacora";
            this.sIGVADataSet_Bitacora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacoraBindingSource1
            // 
            this.bitacoraBindingSource1.DataMember = "Bitacora";
            this.bitacoraBindingSource1.DataSource = this.sIGVADataSet_Bitacora;
            // 
            // bitacoraTableAdapter1
            // 
            this.bitacoraTableAdapter1.ClearBeforeFill = true;
            // 
            // A_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Cmd_Imprimir);
            this.Controls.Add(this.groupBox1);
            this.Name = "A_Movimientos";
            this.Text = "A_Movimientos";
            this.Load += new System.EventHandler(this.A_Movimientos_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Cmd_Imprimir, 0);
            this.Controls.SetChildIndex(this.Btn_Salir, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Bitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSet_Bitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cmd_Buscar;
        private System.Windows.Forms.DataGridView Dat_Bitacora;
        private SIGVADataSet2 sIGVADataSet2;
        private System.Windows.Forms.BindingSource bitacoraBindingSource;
        private SIGVADataSet2TableAdapters.BitacoraTableAdapter bitacoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cmd_Imprimir;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SIGVADataSet_Bitacora sIGVADataSet_Bitacora;
        private System.Windows.Forms.BindingSource bitacoraBindingSource1;
        private SIGVADataSet_BitacoraTableAdapters.BitacoraTableAdapter bitacoraTableAdapter1;
    }
}