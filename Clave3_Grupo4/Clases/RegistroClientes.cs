using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clave3_Grupo4
{

    // Enum para el estado del cliente
    public enum EstadoCliente
    {
        Activo,
        Baja
    }

    class RegistroClientes
    {

        //Clase donde se crearan los metodos o funciones para los clientes
        private string nombres;
        private string apellidos;
        private int dui;
        private string estado;
        


        //Encapsula las variables de tipo privadas
        public string Nombres {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public int DUI
        {
            get { return dui; }
            set { dui = value; }
        }

        public string Estado
        {
            get { return estado; }
            set{ estado = value;}

        }

        // Constructor vacio
        public RegistroClientes()
        {
        }

        //Constructor
        public RegistroClientes(string nombres, string apellidos, int dui, string estado)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dui = dui;
            this.estado = estado;
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
                string query = "INSERT INTO clientes (nombres, apellidos, dui, estado) VALUES (@nombres, @apellidos, @dui, @estado)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    //Se le asignan valores a los parametros
                    cmd.Parameters.AddWithValue("@nombres", this.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", this.Apellidos);
                    cmd.Parameters.AddWithValue("@dui", this.DUI);
                    cmd.Parameters.AddWithValue("@estado", this.Estado);

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

        public void EliminarRegistro(int idCliente)
        {
            // Nueva instancia de la clase ConexionDB
            ConexionDB objConexion = new ConexionDB();

            // Obtener la conexión
            MySqlConnection conexion = objConexion.getConnection();

            try
            {
                // se hace la consulta SQL para eliminar el registro
                string query = "DELETE FROM clientes WHERE idClientes = @idCliente";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    // Asignar valor al parámetro
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    // Ejecutar el comando
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un registro con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar el registro: " + ex.Message);
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
