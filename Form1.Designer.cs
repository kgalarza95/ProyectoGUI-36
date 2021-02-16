namespace ProyectoGUI_36
{
    partial class frmRegCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbNivelEstudio = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbPrimaria = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rbSecundaria = new System.Windows.Forms.RadioButton();
            this.rbTercerNivel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblFechaC = new System.Windows.Forms.Label();
            this.lblFechaL = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvAlumno = new System.Windows.Forms.ListView();
            this.colCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(23, 101);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbNivelEstudio
            // 
            this.cmbNivelEstudio.FormattingEnabled = true;
            this.cmbNivelEstudio.Location = new System.Drawing.Point(111, 62);
            this.cmbNivelEstudio.Name = "cmbNivelEstudio";
            this.cmbNivelEstudio.Size = new System.Drawing.Size(100, 21);
            this.cmbNivelEstudio.TabIndex = 3;
            this.cmbNivelEstudio.SelectedIndexChanged += new System.EventHandler(this.cmbNivelEstudio_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(37, 142);
            this.dtpFecha.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbPrimaria
            // 
            this.rbPrimaria.AutoSize = true;
            this.rbPrimaria.Location = new System.Drawing.Point(76, 56);
            this.rbPrimaria.Name = "rbPrimaria";
            this.rbPrimaria.Size = new System.Drawing.Size(62, 17);
            this.rbPrimaria.TabIndex = 6;
            this.rbPrimaria.TabStop = true;
            this.rbPrimaria.Text = "Primaria";
            this.rbPrimaria.UseVisualStyleBackColor = true;
            this.rbPrimaria.CheckedChanged += new System.EventHandler(this.rbPrimaria_CheckedChanged);
            // 
            // rbSecundaria
            // 
            this.rbSecundaria.AutoSize = true;
            this.rbSecundaria.Location = new System.Drawing.Point(76, 79);
            this.rbSecundaria.Name = "rbSecundaria";
            this.rbSecundaria.Size = new System.Drawing.Size(79, 17);
            this.rbSecundaria.TabIndex = 7;
            this.rbSecundaria.TabStop = true;
            this.rbSecundaria.Text = "Secundaria";
            this.rbSecundaria.UseVisualStyleBackColor = true;
            // 
            // rbTercerNivel
            // 
            this.rbTercerNivel.AutoSize = true;
            this.rbTercerNivel.Location = new System.Drawing.Point(76, 103);
            this.rbTercerNivel.Name = "rbTercerNivel";
            this.rbTercerNivel.Size = new System.Drawing.Size(83, 17);
            this.rbTercerNivel.TabIndex = 8;
            this.rbTercerNivel.TabStop = true;
            this.rbTercerNivel.Text = "Tercer Nivel";
            this.rbTercerNivel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.cmbNivelEstudio);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(48, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Principales";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Controls.Add(this.tabPage3);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(433, 280);
            this.tabPrincipal.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSeleccion);
            this.tabPage2.Controls.Add(this.lblMes);
            this.tabPage2.Controls.Add(this.lblAnio);
            this.tabPage2.Controls.Add(this.lblDia);
            this.tabPage2.Controls.Add(this.lblFechaC);
            this.tabPage2.Controls.Add(this.lblFechaL);
            this.tabPage2.Controls.Add(this.rbPrimaria);
            this.tabPage2.Controls.Add(this.dtpFecha);
            this.tabPage2.Controls.Add(this.rbTercerNivel);
            this.tabPage2.Controls.Add(this.rbSecundaria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(219, 60);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(54, 13);
            this.lblSeleccion.TabIndex = 14;
            this.lblSeleccion.Text = "Selección";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(134, 215);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 13;
            this.lblMes.Text = "Mes";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(36, 215);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 12;
            this.lblAnio.Text = "Año";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(234, 215);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 11;
            this.lblDia.Text = "día";
            // 
            // lblFechaC
            // 
            this.lblFechaC.AutoSize = true;
            this.lblFechaC.Location = new System.Drawing.Point(36, 187);
            this.lblFechaC.Name = "lblFechaC";
            this.lblFechaC.Size = new System.Drawing.Size(64, 13);
            this.lblFechaC.TabIndex = 10;
            this.lblFechaC.Text = "Fecha corta";
            // 
            // lblFechaL
            // 
            this.lblFechaL.AutoSize = true;
            this.lblFechaL.Location = new System.Drawing.Point(34, 165);
            this.lblFechaL.Name = "lblFechaL";
            this.lblFechaL.Size = new System.Drawing.Size(66, 13);
            this.lblFechaL.TabIndex = 9;
            this.lblFechaL.Text = "Fecha  larga";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAlumno);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.lvAlumno.Location = new System.Drawing.Point(3, 3);
            this.lvAlumno.Name = "lvAlumno";
            this.lvAlumno.Size = new System.Drawing.Size(419, 248);
            this.lvAlumno.TabIndex = 1;
            this.lvAlumno.UseCompatibleStateImageBehavior = false;
            this.lvAlumno.View = System.Windows.Forms.View.Details;
            this.lvAlumno.SelectedIndexChanged += new System.EventHandler(this.lvAlumno_SelectedIndexChanged);
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
            // frmRegCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 312);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmRegCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.frmRegCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbNivelEstudio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbPrimaria;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbSecundaria;
        private System.Windows.Forms.RadioButton rbTercerNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFechaL;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblFechaC;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvAlumno;
        private System.Windows.Forms.ColumnHeader colCedula;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
    }
}

