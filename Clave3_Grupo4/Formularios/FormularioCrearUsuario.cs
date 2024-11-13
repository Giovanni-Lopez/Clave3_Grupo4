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

            Usuarios usuarios = new Usuarios();
            RegistroUsuario registro = new RegistroUsuario();
                usuarios.Usuario = txtUsuario.Text;
                usuarios.Contraseña = txtContraseña.Text;
                usuarios.ConContraseña = txtConfirmarContraseña.Text;
                usuarios.Nombre = txtNombre.Text;

                string respuesta = registro.ctrlRegistro(usuarios);

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
