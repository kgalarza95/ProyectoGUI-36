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

        private void mnuNotas_Click(object sender, EventArgs e)
        {
            frmPromedio formulario = new frmPromedio();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            this.mnuNotas.Enabled = false;
            formulario.mensaje = "Programacion III 3-5 Ciclo II";
            formulario.Show();
           
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegCliente formulario = new frmRegCliente();
            formulario.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos formulario = new frmAlumnos();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();

        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCalculadora formulario = new frmCalculadora();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();

        }

        private void mnuFactura_Click(object sender, EventArgs e)
        {
            frmFactura formulario = new frmFactura();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();
        }

        private void promedioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {/*
            frmPromedio2 formulario = new frmPromedio2();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            this.mnuNotas.Enabled = false;
           
            formulario.Show();
            */
        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
