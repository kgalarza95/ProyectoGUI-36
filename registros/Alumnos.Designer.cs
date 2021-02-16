namespace ProyectoGUI_36.registros
{
    partial class frmAlumnos
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
            this.lvAlumno = new System.Windows.Forms.ListView();
            this.colCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvAlumno
            // 
            this.lvAlumno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCedula,
            this.colNombre,
            this.colApellido});
            this.lvAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAlumno.GridLines = true;
            this.lvAlumno.HideSelection = false;
            this.lvAlumno.Location = new System.Drawing.Point(0, 0);
            this.lvAlumno.Name = "lvAlumno";
            this.lvAlumno.Size = new System.Drawing.Size(800, 450);
            this.lvAlumno.TabIndex = 2;
            this.lvAlumno.UseCompatibleStateImageBehavior = false;
            this.lvAlumno.View = System.Windows.Forms.View.Details;
            this.lvAlumno.SelectedIndexChanged += new System.EventHandler(this.lvAlumno_SelectedIndexChanged);
            this.lvAlumno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAlumno_MouseDoubleClick);
            // 
            // colCedula
            // 
            this.colCedula.Text = "Cedula";
            this.colCedula.Width = 174;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAlumno);
            this.Name = "frmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAlumno;
        private System.Windows.Forms.ColumnHeader colCedula;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
    }
}