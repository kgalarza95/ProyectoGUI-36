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
using static System.Windows.Forms.ListView;

namespace ProyectoGUI_36
{
    public partial class frmRegCliente : Form
    {
        public frmRegCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro de salir","Titulo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            lblFechaL.Text = dtpFecha.Value.ToString();
            lblFechaC.Text = dtpFecha.Value.ToString("dd/MM/yyyy");
            lblDia.Text = dtpFecha.Value.ToString("dddd");
            lblMes.Text = dtpFecha.Value.ToString("MMMM");
            lblAnio.Text = dtpFecha.Value.ToString("yyyy");
        }

        private void rbPrimaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrimaria.Checked)
            {
                lblSeleccion.Text = "Primaria";
            }
            else
            {
                lblSeleccion.Text = "";
            }
        }

        /// <summary>
        /// metodo load para iniciar los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegCliente_Load(object sender, EventArgs e)
        {
            //agrega elementos al combo box
            cmbNivelEstudio.Items.Add("Primaria");
            cmbNivelEstudio.Items.Add("Secundaria");

            ///agrega elementos al list view
            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add("0919922252");
            itemAlumno.SubItems.Add("Johanna");
            itemAlumno.SubItems.Add("Zumba");

            itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add("0919922253");
            itemAlumno.SubItems.Add("Patricia");
            itemAlumno.SubItems.Add("Gamboa");




        }
       
        private void lvAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAlumno.SelectedItems.Count > 0)
            {
                ListViewItem listItem = lvAlumno.SelectedItems[0];

                MessageBox.Show(listItem.Text + " " + listItem.SubItems[1].Text +" "  + listItem.SubItems[2].Text);

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbNivelEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbNivelEstudio.SelectedIndex.ToString() + " - "+ cmbNivelEstudio.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void lblFechaC_Click(object sender, EventArgs e)
        {

        }
    }
}
