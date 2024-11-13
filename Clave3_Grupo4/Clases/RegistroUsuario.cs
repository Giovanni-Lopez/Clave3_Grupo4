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
       
        /// <summary>
        /// Metodo para validar a la horar de realizar el registro
        /// </summary>
        /// <returns></returns>
        public string ctrlRegistro(Usuarios usuarios)
        {
            string respuesta = "";
            if (string.IsNullOrEmpty(usuarios.Usuario)||string.IsNullOrEmpty(usuarios.Contraseña)||string.IsNullOrEmpty(usuarios.ConContraseña)||string.IsNullOrEmpty(usuarios.Nombre))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuarios.Contraseña == usuarios.ConContraseña)
                {
                    if (existUsuario(usuarios.Usuario))
                    {
                        respuesta = "El usario ya existe";
                    }
                    else
                    {
                        usuarios.Contraseña = generarSha1(usuarios.Contraseña);
                        registroUusario(usuarios);
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
        public int registroUusario(Usuarios usuarios)
        {
          
                ConexionDB conexion = new ConexionDB();
                MySqlConnection connection = conexion.getConnection();

                conexion.getConnection();
                string sql = "INSERT INTO usuarios (Usuario, Contraseña, Nombre, idTipo) " +
                             "VALUES (@Usuario,@Contraseña,@Nombre,@idTipo)";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                command.Parameters.AddWithValue("@Contraseña", usuarios.Contraseña);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
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

            command.Parameters.AddWithValue("@Usuario", usaurio);

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

        public string generarSha1(string cadena)
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

        public Usuarios existeUsuario(string usaurio)
        {
            ConexionDB conexion = new ConexionDB();
            MySqlConnection connection = conexion.getConnection();
            MySqlDataReader reader;

            conexion.getConnection();

            string comando = "Select idUsuario,Contraseña,idTipo  from usuarios where Usuario like @Usuario";
            MySqlCommand command = new MySqlCommand(comando, connection);

            command.Parameters.AddWithValue("@Usuario", usaurio);

            reader = command.ExecuteReader();

            Usuarios usr = new Usuarios() ;

            while (reader.Read())
            {
                usr.Id = int.Parse(reader["idUsuario"].ToString());
                usr.Contraseña = reader["Contraseña"].ToString();
                usr.IdTipo = int.Parse(reader["idTipo"].ToString());
            }

            return usr;
        }

    }
}
