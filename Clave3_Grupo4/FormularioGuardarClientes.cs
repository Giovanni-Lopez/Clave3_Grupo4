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
    public partial class FormularioGuardarClientes : Form
    {
        public FormularioGuardarClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validando campos vacios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || !int.TryParse(txtDui.Text, out int dui))
            {
                MessageBox.Show("Por favor complete todos los campos...!!");
                return;
            }

            //Creando nueva instancia 
            RegistroClientes nuevoCliente = new RegistroClientes(txtNombre.Text, txtApellido.Text, dui);

            //metodo para que guarde nuestro registro
            nuevoCliente.GuardarRegistro();

            //Limpiando campos, luego de haber guardado
            txtNombre.Clear();
            txtApellido.Clear();
            txtDui.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrado de formulario y desconexion de la basa de datos
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.closeConetion();
            MessageBox.Show("Desconexion de la base de datos");
            Close();
        }
    }
}
