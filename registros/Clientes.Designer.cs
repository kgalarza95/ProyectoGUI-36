namespace ProyectoGUI_36.registros
{
    partial class frmConsClientes
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
            this.lvCliente = new System.Windows.Forms.ListView();
            this.colCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvCliente
            // 
            this.lvCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colTelefono,
            this.colDireccion,
            this.colCorreo});
            this.lvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCliente.GridLines = true;
            this.lvCliente.HideSelection = false;
            this.lvCliente.Location = new System.Drawing.Point(0, 0);
            this.lvCliente.Name = "lvCliente";
            this.lvCliente.Size = new System.Drawing.Size(800, 450);
            this.lvCliente.TabIndex = 3;
            this.lvCliente.UseCompatibleStateImageBehavior = false;
            this.lvCliente.View = System.Windows.Forms.View.Details;
            this.lvCliente.SelectedIndexChanged += new System.EventHandler(this.lvCliente_SelectedIndexChanged);
            this.lvCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCliente_MouseDoubleClick);
            this.lvCliente.Move += new System.EventHandler(this.lvCliente_Move);
            // 
            // colCedula
            // 
            this.colCedula.Text = "Cedula";
            this.colCedula.Width = 90;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 150;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 150;
            // 
            // colTelefono
            // 
            this.colTelefono.Text = "Teléfono";
            this.colTelefono.Width = 90;
            // 
            // colDireccion
            // 
            this.colDireccion.Text = "Dirección";
            this.colDireccion.Width = 200;
            // 
            // colCorreo
            // 
            this.colCorreo.Text = "Correo";
            this.colCorreo.Width = 150;
            // 
            // frmConsClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCliente);
            this.Name = "frmConsClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCliente;
        private System.Windows.Forms.ColumnHeader colCedula;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colTelefono;
        private System.Windows.Forms.ColumnHeader colDireccion;
        private System.Windows.Forms.ColumnHeader colCorreo;
    }
}