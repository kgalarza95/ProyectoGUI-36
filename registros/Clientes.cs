using BibliotecaGeneral;
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
    public partial class frmConsClientes : Form
    {
        public Cliente objCliente;
        public frmConsClientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarDatosClientes();
        }
        private void cargarDatosClientes()
        {
            ///agrega elementos al list view
            ListViewItem itemCliente = new ListViewItem();
            itemCliente = lvCliente.Items.Add("0919922252");
            itemCliente.SubItems.Add("Johanna");
            itemCliente.SubItems.Add("Zumba");
            itemCliente.SubItems.Add("0999999999");
            itemCliente.SubItems.Add("Calle abc");
            itemCliente.SubItems.Add("coreo@prueba.com");
           

            itemCliente = new ListViewItem();
            itemCliente = lvCliente.Items.Add("0919922253");
            itemCliente.SubItems.Add("Patricia");
            itemCliente.SubItems.Add("Gamboa");
            itemCliente.SubItems.Add("0999999999");
            itemCliente.SubItems.Add("Calle abc");
            itemCliente.SubItems.Add("coreo@prueba.com");

            itemCliente = new ListViewItem();
            itemCliente = lvCliente.Items.Add("0919922254");
            itemCliente.SubItems.Add("Lorena");
            itemCliente.SubItems.Add("Olivo");
            itemCliente.SubItems.Add("0999999999");
            itemCliente.SubItems.Add("Calle abc");
            itemCliente.SubItems.Add("coreo@prueba.com");

            itemCliente = new ListViewItem();
            itemCliente = lvCliente.Items.Add("0919922255");
            itemCliente.SubItems.Add("Adriana");
            itemCliente.SubItems.Add("Acuña");
            itemCliente.SubItems.Add("0999999999");
            itemCliente.SubItems.Add("Calle abc");
            itemCliente.SubItems.Add("coreo@prueba.com");
        }

        private void lvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvCliente.SelectedItems.Count > 0)
            {
                ListViewItem listItemSeleccionado = lvCliente.SelectedItems[0];
                objCliente = new Cliente();
                objCliente.cedula= listItemSeleccionado.Text;
                objCliente.nombre = listItemSeleccionado.SubItems[1].Text;
                objCliente.apellido= listItemSeleccionado.SubItems[2].Text;
                objCliente.telefono = listItemSeleccionado.SubItems[3].Text;
                objCliente.direccion = listItemSeleccionado.SubItems[4].Text;
                objCliente.correo = listItemSeleccionado.SubItems[5].Text;
                this.Hide(); 
               
            }
        }

        private void lvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvCliente_Move(object sender, EventArgs e)
        {

        }
    }
}
