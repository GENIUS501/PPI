namespace Presentacion
{
    partial class frmListaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaBase));
            this.ContentPanel = new System.Windows.Forms.ToolStripContainer();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPiePagina = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContentPanel.TopToolStripPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            // 
            // ContentPanel.ContentPanel
            // 
            this.ContentPanel.ContentPanel.Size = new System.Drawing.Size(874, 0);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentPanel.Location = new System.Drawing.Point(0, 62);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(874, 25);
            this.ContentPanel.TabIndex = 3;
            this.ContentPanel.Text = "ToolStripContainer1";
            // 
            // ContentPanel.TopToolStripPanel
            // 
            this.ContentPanel.TopToolStripPanel.Controls.Add(this.ToolStrip);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.btnBorrar,
            this.btnConsultar,
            this.btnCerrar});
            this.ToolStrip.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip.Size = new System.Drawing.Size(286, 25);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.TabStop = true;
            this.ToolStrip.Text = "ToolStrip1";
            this.ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(59, 22);
            this.btnBorrar.Text = "Borrar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 22);
            this.btnCerrar.Text = "Cerrar";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPrincipal.Controls.Add(this.lbl_version);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.lblDescripcion);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(874, 62);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(780, 33);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(84, 13);
            this.lbl_version.TabIndex = 11;
            this.lbl_version.Text = "Version 0.1 beta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Municipalidad de Aserri";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblDescripcion.Location = new System.Drawing.Point(3, 35);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(148, 14);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Ingrese los datos Indicados...";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título del Mantenimiento";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPiePagina});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPiePagina
            // 
            this.lblPiePagina.Name = "lblPiePagina";
            this.lblPiePagina.Size = new System.Drawing.Size(118, 17);
            this.lblPiePagina.Text = "toolStripStatusLabel1";
            // 
            // frmListaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 348);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmListaBase";
            this.Text = "frmListaBase";
            this.Load += new System.EventHandler(this.frmListaBase_Load);
            this.ContentPanel.TopToolStripPanel.ResumeLayout(false);
            this.ContentPanel.TopToolStripPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripContainer ContentPanel;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton btnModificar;
        internal System.Windows.Forms.ToolStripButton btnBorrar;
        internal System.Windows.Forms.ToolStripButton btnConsultar;
        internal System.Windows.Forms.ToolStripButton btnCerrar;
        internal System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.Label lblDescripcion;
        internal System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPiePagina;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label label1;
    }
}