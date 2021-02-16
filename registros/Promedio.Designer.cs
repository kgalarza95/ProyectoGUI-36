namespace ProyectoGUI_36.registros
{
    partial class frmPromedio2
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lvAlumno = new System.Windows.Forms.ListView();
            this.colMateria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExamen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotaFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtProceso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPromedioGeneral = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(581, 5);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 20);
            this.lblMensaje.TabIndex = 39;
            // 
            // lvAlumno
            // 
            this.lvAlumno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMateria,
            this.colProceso,
            this.colExamen,
            this.colNotaFinal,
            this.colEstado});
            this.lvAlumno.GridLines = true;
            this.lvAlumno.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAlumno.HideSelection = false;
            this.lvAlumno.Location = new System.Drawing.Point(12, 120);
            this.lvAlumno.MultiSelect = false;
            this.lvAlumno.Name = "lvAlumno";
            this.lvAlumno.Size = new System.Drawing.Size(569, 248);
            this.lvAlumno.TabIndex = 34;
            this.lvAlumno.UseCompatibleStateImageBehavior = false;
            this.lvAlumno.View = System.Windows.Forms.View.Details;
            // 
            // colMateria
            // 
            this.colMateria.Text = "Materia";
            this.colMateria.Width = 150;
            // 
            // colProceso
            // 
            this.colProceso.Text = "Nota GF y GP";
            this.colProceso.Width = 80;
            // 
            // colExamen
            // 
            this.colExamen.Text = "Nota Examen";
            this.colExamen.Width = 80;
            // 
            // colNotaFinal
            // 
            this.colNotaFinal.Text = "Nota Final";
            this.colNotaFinal.Width = 80;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCedula.Location = new System.Drawing.Point(77, 9);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 25;
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(359, 46);
            this.txtProceso.MaxLength = 2;
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(57, 20);
            this.txtProceso.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "GF y FP:";
            // 
            // txtAlumno
            // 
            this.txtAlumno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAlumno.Location = new System.Drawing.Point(272, 10);
            this.txtAlumno.MaxLength = 30;
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(309, 20);
            this.txtAlumno.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Examen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Materia:";
            // 
            // txtExamen
            // 
            this.txtExamen.Location = new System.Drawing.Point(525, 46);
            this.txtExamen.MaxLength = 2;
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(56, 20);
            this.txtExamen.TabIndex = 42;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(77, 46);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(198, 21);
            this.cmbMateria.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Promedio General:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPromedioGeneral
            // 
            this.txtPromedioGeneral.Location = new System.Drawing.Point(167, 404);
            this.txtPromedioGeneral.MaxLength = 2;
            this.txtPromedioGeneral.Name = "txtPromedioGeneral";
            this.txtPromedioGeneral.Size = new System.Drawing.Size(57, 20);
            this.txtPromedioGeneral.TabIndex = 45;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::ProyectoGUI_36.Properties.Resources.borrador;
            this.btnLimpiar.Location = new System.Drawing.Point(535, 72);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 44);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ProyectoGUI_36.Properties.Resources.mensaje;
            this.btnAgregar.Location = new System.Drawing.Point(481, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(49, 44);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPromedio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.txtPromedioGeneral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.txtExamen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lvAlumno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label1);
            this.Name = "frmPromedio2";
            this.Text = "Promedio";
            this.Load += new System.EventHandler(this.frmPromedio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListView lvAlumno;
        private System.Windows.Forms.ColumnHeader colMateria;
        private System.Windows.Forms.ColumnHeader colProceso;
        private System.Windows.Forms.ColumnHeader colExamen;
        private System.Windows.Forms.ColumnHeader colNotaFinal;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtProceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPromedioGeneral;
    }
}