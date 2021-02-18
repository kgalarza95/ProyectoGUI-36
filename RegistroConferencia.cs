using ProyectoGUI_36.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGUI_36
{
    public partial class RegistroConferencia : Form
    {
        public RegistroConferencia()
        {
            InitializeComponent();
        }

        private void RegistroConferencia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            Conferencia objConf = new Conferencia();

            objConf.setNombreConferencia(txtConferencia.Text);
            objConf.setNombreConferencista(txtConferencista.Text);
            objConf.setLugar(txtLugar.Text);
            objConf.setFecha(dtpFecha.Value.ToString("dd/MM/yyyy"));
            objConf.setHora(dtpFecha.Value.ToString("HH:mm"));
            objConf.setCategoria(cmbCategoria.Text);
            objConf.setCantAsistentes(int.Parse(txtAsistentes.Text));
            objConf.setValorEntrada(int.Parse(txtValorEntrada.Text));

            ListViewItem itemConf = new ListViewItem();
            itemConf = listConferencia.Items.Add(objConf.getNombreConferencia());

            //itemConf.SubItems.Add(objConf.getNombreConferencia());
            itemConf.SubItems.Add(objConf.getNombreConferencista());
            itemConf.SubItems.Add(objConf.getLugar());
            itemConf.SubItems.Add(objConf.getFecha());
            itemConf.SubItems.Add(objConf.getHora());
            itemConf.SubItems.Add(objConf.getCategoria());
            itemConf.SubItems.Add(objConf.getCantAsistentes().ToString());
            itemConf.SubItems.Add(objConf.getValorEntrada().ToString());
            itemConf.SubItems.Add(objConf.getTotal().ToString());

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConferencia.Text = "";
            txtConferencista.Text = "";
            txtLugar.Text = "";
            //txtFecha.Text = "";
            //txtCategoria.Text = "";
            txtAsistentes.Text = "";
            txtValorEntrada.Text = "";
        }
    }
}
