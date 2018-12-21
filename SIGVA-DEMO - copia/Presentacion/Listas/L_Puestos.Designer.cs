namespace Presentacion
{
    partial class L_Puestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L_Puestos));
            this.sIGVADataSetPuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dat_Puestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetPuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Puestos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dat_Puestos
            // 
            this.Dat_Puestos.AllowUserToAddRows = false;
            this.Dat_Puestos.AllowUserToDeleteRows = false;
            this.Dat_Puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Puestos.Location = new System.Drawing.Point(0, 93);
            this.Dat_Puestos.Name = "Dat_Puestos";
            this.Dat_Puestos.ReadOnly = true;
            this.Dat_Puestos.Size = new System.Drawing.Size(341, 175);
            this.Dat_Puestos.TabIndex = 9;
            this.Dat_Puestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_Puestos_CellClick);
            // 
            // L_Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 348);
            this.Controls.Add(this.Dat_Puestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "L_Puestos";
            this.Text = "Lista de puestos";
            this.Evento_Agregar += new System.EventHandler(this.L_Puestos_Evento_Agregar);
            this.Evento_Modificar += new System.EventHandler(this.L_Puestos_Evento_Modificar);
            this.Evento_Borrar += new System.EventHandler(this.L_Puestos_Evento_Borrar);
            this.Evento_Consultar += new System.EventHandler(this.L_Puestos_Evento_Consultar);
            this.Evento_Cerrar += new System.EventHandler(this.L_Puestos_Evento_Cerrar);
            this.Load += new System.EventHandler(this.L_Puestos_Load);
            this.Controls.SetChildIndex(this.Dat_Puestos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sIGVADataSetPuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Puestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sIGVADataSetPuestosBindingSource;
        private System.Windows.Forms.DataGridView Dat_Puestos;
    }
}