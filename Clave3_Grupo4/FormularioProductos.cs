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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validando campos vacios
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(cmbTipoProducto.SelectedItem != null ? cmbTipoProducto.SelectedItem.ToString() : string.Empty))
            {
                MessageBox.Show("Por favor complete todos los campos...!!");
                return;
            }

            //Creando nueva instancia 
            RegistroProductos nuevoProducto = new RegistroProductos(txtNombreProducto.Text, cmbTipoProducto.Text);

            //metodo para que guarde nuestro registro
            nuevoProducto.GuardarRegistro();

            //Limpiando campos, luego de haber guardado
            txtNombreProducto.Clear();            
            cmbTipoProducto.Text = "Seleccione";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Abrir el formulario de inicio
            FormularioInicio formularioInicio = new FormularioInicio();

            // Mostrar el formulario
            formularioInicio.Show();
        }
    }
}
