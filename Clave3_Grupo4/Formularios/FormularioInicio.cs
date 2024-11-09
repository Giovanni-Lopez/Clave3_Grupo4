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
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
                this.Hide();

                //Abrir el formulario de login
                FormularioLogin formularioLogin = new FormularioLogin();

                // Mostrar el formulario
                formularioLogin.Show();            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {            
                this.Hide();

                //Abrir el formulario de cliente
                FormularioGuardarClientes formularioCliente = new FormularioGuardarClientes();

                // Mostrar el formulario
                formularioCliente.Show();           
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Abrir el formulario de empleados
            FormularioGuardarEmpleados formularioEmpleados = new FormularioGuardarEmpleados();

            // Mostrar el formulario
            formularioEmpleados.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Abrir el formulario de producto
            FormularioProductos formularioProductos = new FormularioProductos();

            // Mostrar el formulario
            formularioProductos.Show();
        }
    }
}
