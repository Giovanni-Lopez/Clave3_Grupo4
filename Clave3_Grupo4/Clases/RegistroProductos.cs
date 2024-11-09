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
        private string nombres;
        private string tipoProductos;
        private double saldo;
        private int idCliente;

        //Encapsula las variables de tipo privadas
        public string Nombres
        {
            get { return nombres;}
            set { nombres = value; }
        }

        public string TipoProductos
        {
            get { return tipoProductos; }
            set { tipoProductos = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        //Contructor
        public RegistroProductos(string nombres, string tipoProductos, double saldo, int idCliente)
        {
            this.nombres = nombres;
            this.tipoProductos = tipoProductos;
            this.saldo = saldo;
            this.idCliente = idCliente;
        }

        //Metodo para guardar registro
        public void GuardarRegistro()
        {
            //Nueva Instancia de la clase ConexionDB
            ConexionDB objConexion = new ConexionDB();

            //Obtener la conexion
            MySqlConnection conexion = objConexion.getConnection();

            try
            {
                string query = "INSERT INTO productos (nombreProducto, tipoProducto, saldo, idCliente) VALUES (@nombreProductos, @tipoProductos, @idCliente)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    //Se le asignan valores a los parametros
                    cmd.Parameters.AddWithValue("@nombreProductos", this.Nombres);
                    cmd.Parameters.AddWithValue("@tipoProductos", this.TipoProductos);
                    cmd.Parameters.AddWithValue("@saldo", this.Saldo);
                    cmd.Parameters.AddWithValue("idCliente", this.IdCliente);

                    //Ejecutamos comando
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro guardado exitosamente....");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se producjo un error al guardar el registro: " + ex.Message);
            }

            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }
    }
}
