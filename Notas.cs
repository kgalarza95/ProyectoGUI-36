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
    public partial class frmPromedio : Form
    {
        public string mensaje;

        public frmPromedio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promedio promedio;
            promedio = new Promedio();

            try
            {
                promedio.nota1 = int.Parse(txtNota1.Text);
                promedio.nota2 = int.Parse(txtNota2.Text);
                promedio.nota3 = int.Parse(txtNota3.Text);
                promedio.nota4 = int.Parse(txtNota4.Text);
                promedio.Alumno = txtAlumno.Text;
                promedio.Cedula = txtCedula.Text;


                if (validarRepetido(promedio.Cedula) == true)
                {
                    MessageBox.Show("El numero de cedula ya existe");
                    limpiarControles();
                }
                else
                {
                    agregarDatos(promedio);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar datos");
            }
            
        }

        private void limpiarControles()
        {
            txtAlumno.Text = "";
            txtCedula.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            
        }

        private void agregarDatos(Promedio objProm)
        {
            ///agrega elementos al list view
            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = lvAlumno.Items.Add(objProm.Cedula);
            itemAlumno.SubItems.Add(objProm.Alumno);
            itemAlumno.SubItems.Add(objProm.nota1.ToString());
            itemAlumno.SubItems.Add(objProm.nota2.ToString());
            itemAlumno.SubItems.Add(objProm.nota3.ToString());
            itemAlumno.SubItems.Add(objProm.nota4.ToString());
            itemAlumno.SubItems.Add(objProm.obtenerPromedio().ToString());
            itemAlumno.SubItems.Add(objProm.obtenerNotaBaja().ToString());
            itemAlumno.SubItems.Add(objProm.obtenerEstado());

            limpiarControles();

        }
        /// <summary>
        /// Metodo para validar si ya existe el numero de cedula, 
        /// retorna false si no existe
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        private Boolean validarRepetido(string cedula)
        {
           
            foreach (ListViewItem item in lvAlumno.Items)
            {
                if (item.Text.Equals(cedula))
                {
                    //item.SubItems[1].Text.Equals(xxx)
                    return true;
                }
                      
            }
            return false;
                

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmNotas_FormClosed(object sender, FormClosedEventArgs e)
        {

            frmMenuPrincipal obj = (frmMenuPrincipal) this.MdiParent;
            obj.mnuNotas.Enabled = true;


        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
