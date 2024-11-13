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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando campos vacios
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(cmbTipoProducto.SelectedItem != null ? cmbTipoProducto.SelectedItem.ToString() : string.Empty))
                {
                    MessageBox.Show("Por favor complete todos los campos...!!");
                    return;
                }

                //Creando nueva instancia 
                RegistroProductos nuevoProducto = new RegistroProductos(txtNombreProducto.Text, cmbTipoProducto.Text, Convert.ToDouble(txtSaldo.Text), Convert.ToInt32(cbxCliente.Text));

                //metodo para que guarde nuestro registro
                nuevoProducto.GuardarRegistro();

                //Limpiando campos, luego de haber guardado
                txtNombreProducto.Clear();
                cmbTipoProducto.Text = "Seleccione";

                CargarDatos(dgvDatosProductos, "Select * from productos");
            }catch(Exception ex)
            {
                MessageBox.Show("Error al guardar el registro");
            }
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

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarDatos(dgvDatosProductos,"Select * from productos");
        }

        private void CargarClientes()
        {
            // Lista para almacenar los clientes
            List<Clases.Cliente> listaClientes = new List<Clases.Cliente>();

            // Crear una instancia de ConexionDB para obtener la conexión
            ConexionDB objConexion = new ConexionDB();
            MySqlConnection conexion = objConexion.getConnection();

            if (conexion != null)
            {
                string query = "SELECT idClientes, CONCAT(nombres, ' ', apellidos) AS NombreCompleto FROM clientes";
                MySqlCommand command = new MySqlCommand(query, conexion);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Crear el objeto Cliente y agregarlo a la lista
                        Clases.Cliente cliente = new Clases.Cliente{
                            IdClientes = reader.GetInt32("idClientes"),
                            NombreCompleto = reader.GetString("NombreCompleto")
                        };
                        listaClientes.Add(cliente);
                    }
                }

                // Cerrar la conexión
                conexion.Close();
            }

            // Asignar la lista al ComboBox
            cbxCliente.DataSource = listaClientes;
            cbxCliente.DisplayMember = "NombreCompleto"; // Muestra el nombre completo
            cbxCliente.ValueMember = "IdClientes"; // Usar IdClientes como valor
        }

        private void CargarDatos(DataGridView dgv, string sqlString)
        {
            ConexionDB conexion = new ConexionDB();
            MySqlConnection connection =  conexion.getConnection();
            MySqlCommand command = new MySqlCommand(sqlString,connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            dgv.DataSource = dt;

            conexion.closeConetion();

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreProducto.Text;
                string Tipo = cmbTipoProducto.Text;
                string id = dgvDatosProductos.CurrentRow.Cells[0].Value.ToString();
                string sqlComando = "update productos set nombreProducto ='" + nombre + "',tipoProducto = '" + Tipo + "' where idproducto =" + id;
                ConexionDB conexion = new ConexionDB();
                MySqlConnection connection = conexion.getConnection();
                MySqlCommand command = new MySqlCommand(sqlComando, connection);
                command.ExecuteNonQuery();
                txtNombreProducto.Clear();
                cmbTipoProducto.SelectedIndex = -1;
                CargarDatos(dgvDatosProductos, "Select * from productos");
                MessageBox.Show("Se actulizaron los datos con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actulizar los datos");
            }
        }
        /// <summary>
        /// Permite que al darle click en una celda de el datagridview 
        /// se muestren los datos de esa fila en los campos lo que facilita 
        /// la modificacion de los registros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDatosProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProducto.Text = dgvDatosProductos.CurrentRow.Cells[1].Value.ToString();
            cmbTipoProducto.Text = dgvDatosProductos.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
