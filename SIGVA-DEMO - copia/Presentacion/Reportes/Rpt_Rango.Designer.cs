namespace Presentacion
{
    partial class Rpt_Rango
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_Rango));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Cant_Dias = new System.Windows.Forms.TextBox();
            this.dat_rango = new System.Windows.Forms.DataGridView();
            this.Cmd_Generar = new System.Windows.Forms.Button();
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_rango)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de dias a superarce";
            // 
            // Txt_Cant_Dias
            // 
            this.Txt_Cant_Dias.Location = new System.Drawing.Point(16, 105);
            this.Txt_Cant_Dias.Name = "Txt_Cant_Dias";
            this.Txt_Cant_Dias.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cant_Dias.TabIndex = 3;
            this.Txt_Cant_Dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cant_Dias_KeyPress);
            // 
            // dat_rango
            // 
            this.dat_rango.AllowUserToAddRows = false;
            this.dat_rango.AllowUserToDeleteRows = false;
            this.dat_rango.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_rango.Location = new System.Drawing.Point(16, 155);
            this.dat_rango.Name = "dat_rango";
            this.dat_rango.ReadOnly = true;
            this.dat_rango.Size = new System.Drawing.Size(695, 150);
            this.dat_rango.TabIndex = 4;
            this.dat_rango.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_rango_CellClick);
            // 
            // Cmd_Generar
            // 
            this.Cmd_Generar.Location = new System.Drawing.Point(220, 401);
            this.Cmd_Generar.Name = "Cmd_Generar";
            this.Cmd_Generar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Generar.TabIndex = 5;
            this.Cmd_Generar.Text = "Generar";
            this.Cmd_Generar.UseVisualStyleBackColor = true;
            this.Cmd_Generar.Click += new System.EventHandler(this.Cmd_Generar_Click);
            // 
            // Cmd_Cancelar
            // 
            this.Cmd_Cancelar.Location = new System.Drawing.Point(392, 401);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancelar.TabIndex = 6;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = true;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.Location = new System.Drawing.Point(123, 101);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Buscar.TabIndex = 7;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = true;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // Rpt_Rango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(723, 526);
            this.Controls.Add(this.Cmd_Buscar);
            this.Controls.Add(this.Cmd_Cancelar);
            this.Controls.Add(this.Cmd_Generar);
            this.Controls.Add(this.dat_rango);
            this.Controls.Add(this.Txt_Cant_Dias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rpt_Rango";
            this.Text = "Reporte de cantidad  de dias superior al dado";
            this.Load += new System.EventHandler(this.Rpt_Rango_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_Cant_Dias, 0);
            this.Controls.SetChildIndex(this.dat_rango, 0);
            this.Controls.SetChildIndex(this.Cmd_Generar, 0);
            this.Controls.SetChildIndex(this.Cmd_Cancelar, 0);
            this.Controls.SetChildIndex(this.Cmd_Buscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dat_rango)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Cant_Dias;
        private System.Windows.Forms.DataGridView dat_rango;
        private System.Windows.Forms.Button Cmd_Generar;
        private System.Windows.Forms.Button Cmd_Cancelar;
        private System.Windows.Forms.Button Cmd_Buscar;
    }
}