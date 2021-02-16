using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGUI_36.registros;

namespace ProyectoGUI_36.transacciones
{
    public partial class frmFactura : Form
    {
        public frmConsClientes formulario;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            formulario = new frmConsClientes();
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.ShowDialog();
            if (formulario.objCliente != null)
            {
                txtCedula.Text = formulario.objCliente.cedula ;
                txtCliente.Text = formulario.objCliente.nombre + " " + formulario.objCliente.apellido;
                txtTelefono.Text= formulario.objCliente.telefono;
                txtDireccion.Text= formulario.objCliente.direccion;
                txtCorreo.Text= formulario.objCliente.correo;
            }

        }
    }
}
