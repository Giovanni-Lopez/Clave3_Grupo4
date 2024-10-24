using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clave3_Grupo4
{
    class RegistroClientes
    {

        //Clase donde se crearan los metodos o funciones para los clientes
        private string nombres;
        private string apellidos;
        private int dui;

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

        //Constructor
        public RegistroClientes(string nombres, string apellidos, int dui)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dui = dui;
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
                string query = "INSERT INTO clientes (nombres, apellidos, dui) VALUES (@nombres, @apellidos, @dui)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    //Se le asignan valores a los parametros
                    cmd.Parameters.AddWithValue("@nombres", this.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", this.Apellidos);
                    cmd.Parameters.AddWithValue("@dui", this.DUI);

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
