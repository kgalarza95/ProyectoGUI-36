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

namespace ProyectoGUI_36.registros
{
    public partial class frmPromedio2 : Form
    {
        public ListViewItem listItem;
        public frmPromedio2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmPromedio_Load(object sender, EventArgs e)
        {
            txtCedula.Text = listItem.Text;
            txtAlumno.Text = listItem.SubItems[1].Text +" " +listItem.SubItems[2].Text;
            llenarCombo();
        }
        private void llenarCombo()
        {
            cmbMateria.Items.Add("Programacion III");
            cmbMateria.Items.Add("Estructura de Datos");
            cmbMateria.Items.Add("Circuitos");
            cmbMateria.Items.Add("Estadistica");
            cmbMateria.Items.Add("Comportamiento Organizacional");
        }
        /// <summary>
        /// Agrega los datos en el listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Promedio objPromedio = new Promedio();
            objPromedio.obtenerPromedio(int.Parse(txtProceso.Text), int.Parse(txtExamen.Text));

            ///agrega elementos al list view
            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add(cmbMateria.Text);
            itemAlumno.SubItems.Add(txtProceso.Text);
            itemAlumno.SubItems.Add(txtExamen.Text);
            itemAlumno.SubItems.Add(objPromedio.MyPromedio.ToString());
            itemAlumno.SubItems.Add(objPromedio.obtenerEstado());
            calcularPromedioGeneral();
            
        }

        private void calcularPromedioGeneral()
        {
            double suma = 0;
            foreach (ListViewItem item in lvAlumno.Items)
            {

                suma = suma + double.Parse(item.SubItems[3].Text);


            }
            //Math.Round(promedio, 2);
            suma = suma / lvAlumno.Items.Count;
            txtPromedioGeneral.Text = Math.Round(suma,2).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = -1;
        }
    }
}
