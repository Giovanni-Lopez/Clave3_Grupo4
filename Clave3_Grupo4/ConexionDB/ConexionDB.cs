using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave3_Grupo4
{
    class ConexionDB
    {
        //Se crearan las conexiones  a la base de datos nombre: Clave3_Grupo4DB

        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "clave3_grupo4db";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public ConexionDB()
        {
            cadenaConexion = "Database= " + database +
                             "; DataSource= " + server +
                             "; User Id= " + user +
                             "; Password= " + password;
        }

        //para usar MySqlConnection debemos de instalar MySql.Data ultima version
        public MySqlConnection getConnection()
        {
            try
            {
                //Verifica si la conexion es nula o se encuentra cerrada o se daño 
                if (conexion == null || conexion.State == System.Data.ConnectionState.Closed || conexion.State == System.Data.ConnectionState.Broken)
                {
                    conexion = new MySqlConnection(cadenaConexion);
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar...\nVerifique conexión!!");
            }
                    
            return conexion;
        }

        /// <summary>
        /// Metodo utilizado para cerrar la conexion con la base de datos
        /// </summary>
        /// <returns></returns>
        public MySqlConnection closeConetion()
        {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Close();
            return conexion;
        }
    }
}
