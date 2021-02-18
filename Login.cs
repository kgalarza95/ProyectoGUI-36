using ProyectoGUI_36.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGUI_36
{
    public partial class Login : Form
    {
        List<Usuario> users;
        public frmMenuPrincipal formularioMenu;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cargarUsuario();
        }
        private void cargarUsuario()
        {
            users = new List<Usuario>();
            Usuario user = new Usuario("jmolina","123");
            users.Add(user);
            user = new Usuario("kguzman", "kguzman");
            users.Add(user);
            user = new Usuario("kvera", "125");
            users.Add(user);
            user = new Usuario("kevyn", "kevyn");
            users.Add(user);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }
        private void buscarUsuario()
        {
            Boolean result = false;
            foreach (Usuario item in users)
            {
                
                if (txtUsuario.Text.Trim().Equals(item.usuario) )
                {
                    if (txtClave.Text.Trim().Equals(item.clave))
                    {
                        //llamar a menu Principal
                        formularioMenu = new frmMenuPrincipal();
                        formularioMenu.Show();
                        //ocultar pantalla login
                        this.Hide();
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("La clave no coincide", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = true;
                    }
                }
              

            }
            if (result == false)
            {
                MessageBox.Show("El usuario " + txtUsuario.Text + " no existe","Sistema de Control",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
}
