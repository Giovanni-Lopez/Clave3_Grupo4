using System.Data.SqlClient;
using MySql.Data.MySqlClient;
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || !int.TryParse(txtDui.Text, out int dui) || string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                MessageBox.Show("Por favor complete todos los campos...!!");
                return;
            }

            //Creando nueva instancia 
            RegistroClientes nuevoCliente = new RegistroClientes(txtNombre.Text, txtApellido.Text, dui, cbxEstado.Text);

            //metodo para que guarde nuestro registro
            nuevoCliente.GuardarRegistro();

            //Limpiando campos, luego de haber guardado
            txtNombre.Clear();
            txtApellido.Clear();
            txtDui.Clear();
            cbxEstado.Text = string.Empty;
            CargarDatos(dgvClientes, "select * from clientes");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrado de formulario y desconexion de la basa de datos
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.closeConetion();
            MessageBox.Show("Desconexion de la base de datos");
            Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Abrir el formulario de login
            FormularioProductos formularioProduct = new FormularioProductos();

            // Mostrar el formulario
            formularioProduct.Show();
        }

        private void CargarDatos(DataGridView dgv, string sqlString)
        {
            ConexionDB conexion = new ConexionDB();
            MySqlConnection connection = conexion.getConnection();
            MySqlCommand command = new MySqlCommand(sqlString, connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            dgv.DataSource = dt;

            conexion.closeConetion();

        }

        private void FormularioGuardarClientes_Load(object sender, EventArgs e)
        {
            CargarDatos(dgvClientes,"select * from clientes");
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtDui.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            cbxEstado.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtNombre.Text;
                string dui = txtDui.Text;
                string estado = cbxEstado.Text;
                string id = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                string cadena = "update clientes set nombres = '" + nombre + "',apellidos= '" + apellido + "',DUI= '" + dui + "',estado= '" + estado+"' where idClientes="+id;
                ConexionDB conexion = new ConexionDB();
                MySqlConnection connection = conexion.getConnection();
                MySqlCommand comando = new MySqlCommand(cadena, connection);
                comando.ExecuteNonQuery();
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDui.Text = string.Empty;
                cbxEstado.SelectedIndex = -1;
                CargarDatos(dgvClientes, "select * from clientes");
                MessageBox.Show("Se actulizo el registro con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedieron actulizar los datos");
            }
        }
    }
}
