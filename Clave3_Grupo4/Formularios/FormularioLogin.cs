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

namespace Clave3_Grupo4
{
    public partial class FormularioLogin : Form
    {
        private ConexionDB mConexion;
        public FormularioLogin()
        {
            InitializeComponent();
            mConexion = new ConexionDB();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;
            try
            {

                ControlLogin ctr = new ControlLogin();

                string respuesta = ctr.ctrlLogin(usuario, contraseña);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("Se inicio secion con exito");

                    FormularioInicio formularioInicio = new FormularioInicio();

                    formularioInicio.Show();

                    this.Hide();
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error durante el inicio de secion");
            }                             
        }

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Abrir el formularioRegistroEmpleados
            FormularioCrearUsuario formularioCrearUsuario = new FormularioCrearUsuario();


            // Mostrar el formulario
            formularioCrearUsuario.Show();
        }
    }
}
