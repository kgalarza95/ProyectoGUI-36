
namespace ProyectoGUI_36
{
    partial class RegistroConferencia
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.txtConferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConferencista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAsistentes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.listConferencia = new System.Windows.Forms.ListView();
            this.nombreConferencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreConferencista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lugar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantAsistentes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Conferencias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConferencia
            // 
            this.txtConferencia.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConferencia.Location = new System.Drawing.Point(208, 103);
            this.txtConferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConferencia.Name = "txtConferencia";
            this.txtConferencia.Size = new System.Drawing.Size(159, 27);
            this.txtConferencia.TabIndex = 1;
            this.txtConferencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre Conferencia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "nombre Conferencista";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtConferencista
            // 
            this.txtConferencista.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConferencista.Location = new System.Drawing.Point(208, 151);
            this.txtConferencista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConferencista.Name = "txtConferencista";
            this.txtConferencista.Size = new System.Drawing.Size(159, 27);
            this.txtConferencista.TabIndex = 3;
            this.txtConferencista.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "lugar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(502, 103);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(186, 27);
            this.txtLugar.TabIndex = 5;
            this.txtLugar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "cantidad de Asistentes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAsistentes
            // 
            this.txtAsistentes.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsistentes.Location = new System.Drawing.Point(850, 103);
            this.txtAsistentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsistentes.Name = "txtAsistentes";
            this.txtAsistentes.Size = new System.Drawing.Size(159, 27);
            this.txtAsistentes.TabIndex = 7;
            this.txtAsistentes.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "valor de Entrada";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntrada.Location = new System.Drawing.Point(850, 151);
            this.txtValorEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(159, 27);
            this.txtValorEntrada.TabIndex = 9;
            this.txtValorEntrada.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "tecnologia",
            "social",
            "medicina",
            "leyes "});
            this.cmbCategoria.Location = new System.Drawing.Point(208, 199);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(159, 27);
            this.cmbCategoria.TabIndex = 11;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "categoria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "fecha y hora";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(502, 155);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(186, 27);
            this.dtpFecha.TabIndex = 15;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listConferencia
            // 
            this.listConferencia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreConferencia,
            this.nombreConferencista,
            this.lugar,
            this.fecha,
            this.hora,
            this.categoria,
            this.cantAsistentes,
            this.valorEntrada});
            this.listConferencia.HideSelection = false;
            this.listConferencia.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listConferencia.Location = new System.Drawing.Point(71, 255);
            this.listConferencia.Name = "listConferencia";
            this.listConferencia.Size = new System.Drawing.Size(955, 281);
            this.listConferencia.TabIndex = 16;
            this.listConferencia.UseCompatibleStateImageBehavior = false;
            this.listConferencia.View = System.Windows.Forms.View.Details;
            // 
            // nombreConferencia
            // 
            this.nombreConferencia.Text = "nombre Conferencia";
            this.nombreConferencia.Width = 153;
            // 
            // nombreConferencista
            // 
            this.nombreConferencista.Text = "nombre Conferencista";
            this.nombreConferencista.Width = 150;
            // 
            // lugar
            // 
            this.lugar.Text = "lugar";
            this.lugar.Width = 109;
            // 
            // fecha
            // 
            this.fecha.Text = "fecha";
            this.fecha.Width = 107;
            // 
            // hora
            // 
            this.hora.Text = "hora";
            // 
            // categoria
            // 
            this.categoria.Text = "Categoria";
            this.categoria.Width = 134;
            // 
            // cantAsistentes
            // 
            this.cantAsistentes.Text = "cant Asistentes";
            this.cantAsistentes.Width = 123;
            // 
            // valorEntrada
            // 
            this.valorEntrada.Text = "valor Entrada";
            this.valorEntrada.Width = 102;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::ProyectoGUI_36.Properties.Resources.limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(896, 199);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 50);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ProyectoGUI_36.Properties.Resources.guardar;
            this.btnAgregar.Location = new System.Drawing.Point(785, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 50);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // RegistroConferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 709);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listConferencia);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAsistentes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConferencista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConferencia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistroConferencia";
            this.Text = "RegistroConferencia";
            this.Load += new System.EventHandler(this.RegistroConferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConferencista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAsistentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListView listConferencia;
        private System.Windows.Forms.ColumnHeader nombreConferencia;
        private System.Windows.Forms.ColumnHeader nombreConferencista;
        private System.Windows.Forms.ColumnHeader lugar;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.ColumnHeader cantAsistentes;
        private System.Windows.Forms.ColumnHeader valorEntrada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}