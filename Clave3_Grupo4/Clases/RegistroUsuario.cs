using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4.Clases
{
    /// <summary>
    /// Clase donde se crearan los metodos y funciones para el registro de usuarios
    /// </summary>
    class RegistroUsuario
    {
        private string usuario, nombre, contraseña,conContraseña;
        private int id, idTipo;
        
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public string ConContraseña
        {
            get { return conContraseña; }
            set { conContraseña = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Metodo para validar a la horar de realizar el registro
        /// </summary>
        /// <returns></returns>
        public string ctrlRegistro()
        {
            string respuesta = "";
            if (string.IsNullOrEmpty(this.Usuario)||string.IsNullOrEmpty(this.Contraseña)||string.IsNullOrEmpty(this.ConContraseña)||string.IsNullOrEmpty(this.Nombre))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (this.Contraseña == this.ConContraseña)
                {
                    if (existUsuario(this.Usuario))
                    {
                        respuesta = "El usario ya existe";
                    }
                    else
                    {
                        this.Contraseña = generarSha1(this.Contraseña);
                        registroUusario();
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }

            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para registrar el usaurio
        /// </summary>
        /// <returns></returns>
        public int registroUusario()
        {
          
                ConexionDB conexion = new ConexionDB();
                MySqlConnection connection = conexion.getConnection();

                conexion.getConnection();
                string sql = "INSERT INTO usuarios (Usuario, Contraseña, Nombre, idTipo) " +
                             "VALUES (@Usuario,@Contraseña,@Nombre,@idTipo)";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Usuario", this.Usuario);
                command.Parameters.AddWithValue("@Contraseña", this.Contraseña);
                command.Parameters.AddWithValue("@Nombre", this.Nombre);
                command.Parameters.AddWithValue("@idTipo", 1);

                int resultado = command.ExecuteNonQuery();

                return resultado;
           
        }
        /// <summary>
        /// Metodo para verificar si el usuario existe
        /// </summary>
        /// <param name="usaurio"></param>
        /// <returns></returns>
        public bool existUsuario(string usaurio)
        {
            ConexionDB conexion = new ConexionDB();
            MySqlConnection connection = conexion.getConnection();
            MySqlDataReader reader;

            conexion.getConnection();

            string comando = "Select idUsuario from usuarios where Usuario like @Usuario";
            MySqlCommand command = new MySqlCommand(comando,connection);

            command.Parameters.AddWithValue("@Usuario",this.Usuario);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private string generarSha1(string cadena)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] data = encoding.GetBytes(cadena);
            byte[] resultado;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            resultado = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i<resultado.Length;i++)
            {
                if (resultado[i]<16)
                {
                    sb.Append("0");
                }
                sb.Append(resultado[i].ToString("x"));
            }
            return sb.ToString();
        }

    }
}
