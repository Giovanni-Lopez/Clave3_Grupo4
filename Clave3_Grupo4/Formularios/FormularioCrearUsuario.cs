using Clave3_Grupo4.Formularios;
using Clave3_Grupo4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave3_Grupo4.Formularios
{
    public partial class FormularioCrearUsuario : Form
    {
        public FormularioCrearUsuario()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
          
                RegistroUsuario usuario = new RegistroUsuario();
                usuario.Usuario = txtUsuario.Text;
                usuario.Contraseña = txtContraseña.Text;
                usuario.ConContraseña = txtConfirmarContraseña.Text;
                usuario.Nombre = txtNombre.Text;

                string respuesta = usuario.ctrlRegistro();

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado");
                txtUsuario.Clear();
                txtNombre.Clear();
                txtContraseña.Clear();
                txtConfirmarContraseña.Clear();
                    
                }
            }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            FormularioLogin formularioLogin = new FormularioLogin();

            this.Hide();

            formularioLogin.Show();
        }
    }
}
