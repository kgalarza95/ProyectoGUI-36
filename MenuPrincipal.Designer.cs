﻿namespace ProyectoGUI_36
{
    partial class frmMenuPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarConferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegistros,
            this.transaccionesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.utilitariosToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 27);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuRegistros
            // 
            this.mnuRegistros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNotas});
            this.mnuRegistros.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.mnuRegistros.Name = "mnuRegistros";
            this.mnuRegistros.Size = new System.Drawing.Size(71, 23);
            this.mnuRegistros.Text = "Registros";
            // 
            // mnuNotas
            // 
            this.mnuNotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarConferenciaToolStripMenuItem});
            this.mnuNotas.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.mnuNotas.Name = "mnuNotas";
            this.mnuNotas.Size = new System.Drawing.Size(180, 24);
            this.mnuNotas.Text = "Conferencias";
            // 
            // registrarConferenciaToolStripMenuItem
            // 
            this.registrarConferenciaToolStripMenuItem.Name = "registrarConferenciaToolStripMenuItem";
            this.registrarConferenciaToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.registrarConferenciaToolStripMenuItem.Text = "Registrar Conferencia";
            this.registrarConferenciaToolStripMenuItem.Click += new System.EventHandler(this.registrarConferenciaToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.transaccionesToolStripMenuItem.Text = "Editar";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.utilitariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.utilitariosToolStripMenuItem.Text = "Ayuda";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistros;
        public System.Windows.Forms.ToolStripMenuItem mnuNotas;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarConferenciaToolStripMenuItem;
    }
}