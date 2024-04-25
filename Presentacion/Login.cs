using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = texUsuario.Text;
            String contr = texContraseña.Text;

            if (formularioValido(usuario,contr))
            {
                login(usuario, contr);
            }
        }

        private void login(string usuario, string contr)
        {
            Dal repositorio = new Dal();
            DataSet datos = repositorio.login(usuario, contr);
            if (datos == null)
            {
                MessageBox.Show("USUARIO INCORRECTO");
            }
            else
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
                this.Hide();

            }

        }

        private bool formularioValido(string usuario, string contr)
        {
            if(usuario == "")
            {
                MessageBox.Show("INGRESAR DATOS EN LOS CAMPOS");
                return false;
            }
            if (contr == "")
            {
                MessageBox.Show("FALTA INGRESAR CONTRASEÑA");
                return false;
            }
            return true;
        }

        private void texUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayusucula(e);

        }
        public void Mayusucula(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
