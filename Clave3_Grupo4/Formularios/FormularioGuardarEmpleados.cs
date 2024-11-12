using Clave3_Grupo4.Clases;
using System;
using MySql.Data.MySqlClient;
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
    public partial class FormularioGuardarEmpleados : Form
    {
        public FormularioGuardarEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            //Validando campos vacios
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(cmbTipoUsuario.SelectedItem != null ? cmbTipoUsuario.SelectedItem.ToString() : string.Empty))
            {
                MessageBox.Show("Por favor complete todos los campos...!!");
                return;
            }

            //Creando nueva instancia 
            
            RegistroEmpleados nuevoEmpleado = new RegistroEmpleados(txtNombres.Text, txtApellidos.Text, cmbTipoUsuario.Text);

            //metodo para que guarde nuestro registro
            nuevoEmpleado.GuardarRegistro();

            //Limpiando campos, luego de haber guardado
            txtNombres.Clear();
            txtApellidos.Clear();
            cmbTipoUsuario.Text = "Seleccione";
            CargarDatos(dgvEmpleados, "select * from empleados");
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

        private void FormularioGuardarEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos(dgvEmpleados,"select * from empleados");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombres.Text;
                string apellido = txtApellidos.Text;
                string usuario = cmbTipoUsuario.Text;
                string id = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                string sqlQuery = "update empleados set nombres ='" + nombre + "',apellidos = '" + apellido + "',tipo= '" + usuario + "' where idEmpleados =" + id;
                ConexionDB conexion = new ConexionDB();
                MySqlConnection connection = conexion.getConnection();
                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery,connection);
                sqlCommand.ExecuteNonQuery();
                txtNombres.Clear();
                txtApellidos.Clear();
                cmbTipoUsuario.SelectedIndex = -1;
                CargarDatos(dgvEmpleados, "select * from empleados");
                MessageBox.Show("Se actulizo el registro con exito");
                conexion.closeConetion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al actulizar el regsitro");
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombres.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            cmbTipoUsuario.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
