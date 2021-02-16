using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca36;

namespace ProyectoGUI_36.registros
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void metodo()
        {
            Cuadrado objCuadrado = new Cuadrado();
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            ///agrega elementos al list view
            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add("0919922252");
            itemAlumno.SubItems.Add("Johanna");
            itemAlumno.SubItems.Add("Zumba");

            itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add("0919922253");
            itemAlumno.SubItems.Add("Patricia");
            itemAlumno.SubItems.Add("Gamboa");

            itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add("0919922254");
            itemAlumno.SubItems.Add("Lorena");
            itemAlumno.SubItems.Add("Olivo");

            itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add("0919922255");
            itemAlumno.SubItems.Add("Adriana");
            itemAlumno.SubItems.Add("Acuña");
        }

        private void lvAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvAlumno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvAlumno.SelectedItems.Count > 0)
            {
                ListViewItem listItemSeleccionado = lvAlumno.SelectedItems[0];
                frmPromedio2 formularioPromedio = new frmPromedio2();
                formularioPromedio.listItem = listItemSeleccionado;
                formularioPromedio.StartPosition = FormStartPosition.CenterScreen;
                formularioPromedio.ShowDialog();
            }
        }
    }
}
