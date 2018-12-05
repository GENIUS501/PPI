namespace Presentacion
{
    partial class Rpt_Rango_Fechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_Rango_Fechas));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dat_Rango = new System.Windows.Forms.DataGridView();
            this.Cmd_Generar = new System.Windows.Forms.Button();
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Rango)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial";
            // 
            // Txt_Fecha_Ini
            // 
            this.Txt_Fecha_Ini.Location = new System.Drawing.Point(28, 116);
            this.Txt_Fecha_Ini.Name = "Txt_Fecha_Ini";
            this.Txt_Fecha_Ini.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Ini.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha final";
            // 
            // Txt_Fecha_Fin
            // 
            this.Txt_Fecha_Fin.Location = new System.Drawing.Point(269, 115);
            this.Txt_Fecha_Fin.Name = "Txt_Fecha_Fin";
            this.Txt_Fecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.Txt_Fecha_Fin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de dias disfrutados";
            // 
            // Dat_Rango
            // 
            this.Dat_Rango.AllowUserToAddRows = false;
            this.Dat_Rango.AllowUserToDeleteRows = false;
            this.Dat_Rango.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Rango.Location = new System.Drawing.Point(28, 192);
            this.Dat_Rango.Name = "Dat_Rango";
            this.Dat_Rango.ReadOnly = true;
            this.Dat_Rango.Size = new System.Drawing.Size(669, 150);
            this.Dat_Rango.TabIndex = 7;
            // 
            // Cmd_Generar
            // 
            this.Cmd_Generar.Location = new System.Drawing.Point(196, 407);
            this.Cmd_Generar.Name = "Cmd_Generar";
            this.Cmd_Generar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Generar.TabIndex = 8;
            this.Cmd_Generar.Text = "Generar";
            this.Cmd_Generar.UseVisualStyleBackColor = true;
            this.Cmd_Generar.Click += new System.EventHandler(this.Cmd_Generar_Click);
            // 
            // Cmd_Cancelar
            // 
            this.Cmd_Cancelar.Location = new System.Drawing.Point(397, 406);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancelar.TabIndex = 9;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = true;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.Location = new System.Drawing.Point(490, 116);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Buscar.TabIndex = 10;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = true;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // Rpt_Rango_Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 526);
            this.Controls.Add(this.Cmd_Buscar);
            this.Controls.Add(this.Cmd_Cancelar);
            this.Controls.Add(this.Cmd_Generar);
            this.Controls.Add(this.Dat_Rango);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Fecha_Fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Fecha_Ini);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rpt_Rango_Fechas";
            this.Text = "Reporte de rango de fechas";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_Fecha_Ini, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Txt_Fecha_Fin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Dat_Rango, 0);
            this.Controls.SetChildIndex(this.Cmd_Generar, 0);
            this.Controls.SetChildIndex(this.Cmd_Cancelar, 0);
            this.Controls.SetChildIndex(this.Cmd_Buscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Rango)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Ini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dat_Rango;
        private System.Windows.Forms.Button Cmd_Generar;
        private System.Windows.Forms.Button Cmd_Cancelar;
        private System.Windows.Forms.Button Cmd_Buscar;
    }
}