using ProyectoGUI_36.registros;
using ProyectoGUI_36.utilitarios;
using ProyectoGUI_36.transacciones;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

     


        private void registrarConferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           RegistroConferencia obj = new RegistroConferencia();
            /*obj.Show();
           this.Hide();*/

            frmPromedio formulario = new frmPromedio();
            this.IsMdiContainer = true;
            obj.MdiParent = this;
            this.mnuNotas.Enabled = false;
            obj.Show();
        }
    }
}
