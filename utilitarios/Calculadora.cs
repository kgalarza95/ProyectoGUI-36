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

namespace ProyectoGUI_36.utilitarios
{
    public partial class frmCalculadora : Form
    {
        CalBasico objCal;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            objCal = new CalBasico();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text+ "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }
    }
}
