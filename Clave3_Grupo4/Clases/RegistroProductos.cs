using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave3_Grupo4
{
    class RegistroProductos
    {
        //Clase donde se crearan los metodos o funciones para los productos
        private string nombreProducto;
        private string tipoProducto;
        private double saldo;
        private int clienteId;

        //Encapsula las variables de tipo privadas
        public string NombreProducto
        {
            get { return nombreProducto;}
            set { nombreProducto = value; }
        }

        public string TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }
        }

        //Constructor vacio
        public RegistroProductos()
        {

        }

        //Contructor
        // Constructor para inicializar la clase
        public RegistroProductos(string nombreProducto, string tipoProducto, double saldo, int clienteId)
        {
            this.nombreProducto = nombreProducto;
            this.tipoProducto = tipoProducto;
            this.saldo = saldo;
            this.clienteId = clienteId;
        }

        // Método para guardar el registro del producto
        public void GuardarRegistro()
        {
            ConexionDB objConexion = new ConexionDB();
            MySqlConnection conexion = objConexion.getConnection();
           
            try
            {
                string query = "INSERT INTO productos (nombreProducto, tipoProducto, saldo, clienteid) VALUES (@nombreProducto, @tipoProducto, @saldo, @clienteid)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreProducto", this.NombreProducto);
                    cmd.Parameters.AddWithValue("@tipoProducto", this.TipoProducto);
                    cmd.Parameters.AddWithValue("@saldo", this.Saldo);
                    cmd.Parameters.AddWithValue("@clienteid", this.ClienteId);

                    // Ejecuta la consulta
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto guardado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        // Método para eliminar un producto
        public void EliminarProducto(int idProducto)
        {
            ConexionDB objConexion = new ConexionDB();
            MySqlConnection conexion = objConexion.getConnection();

            try
            {
                string query = "DELETE FROM productos WHERE idProducto = @idProducto";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
