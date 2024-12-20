﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave3_Grupo4.Clases
{
    class RegistroEmpleados
    {
        //Clase donde se crearan los metodos o funciones para los empleados

        private string nombres;
        private string apellidos;
        private string tipoUsuario;

        //Encapsula las variables de tipo privadas
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        // Constructor vacio
        public RegistroEmpleados()
        {
        }

        //Constructor
        public RegistroEmpleados(string nombres, string apellidos, string tipoUsuario)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.tipoUsuario = tipoUsuario;
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

                    // Verifica si ya existe un gerente
                    string queryVerificar = "SELECT COUNT(*) FROM empleados WHERE LOWER(tipo) = 'gerente'";

                    using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conexion))
                    {
                        int cantidadGerentes = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        if (cantidadGerentes > 0 && this.TipoUsuario == "Gerente")
                        {
                            // Error ya existe un gerente
                            MessageBox.Show("Ya existe un registro de tipo Gerente. \nNo se pueden registrar más gerentes.");
                            return;
                        }
                    }

                    string query = "INSERT INTO empleados (nombres, apellidos, tipo) VALUES (@nombres, @apellidos, @tipo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        //Se le asignan valores a los parametros
                        cmd.Parameters.AddWithValue("@nombres", this.Nombres);
                        cmd.Parameters.AddWithValue("@apellidos", this.Apellidos);
                        cmd.Parameters.AddWithValue("@tipo", this.TipoUsuario);


                        //Ejecutamos comando
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado exitosamente....");
                    }
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

        // Método para eliminar un registro de empleado
        public void EliminarRegistro(int idEmpleado)
        {
            ConexionDB objConexion = new ConexionDB();
            MySqlConnection conexion = objConexion.getConnection();

            try
            {
                string query = "DELETE FROM empleados WHERE idEmpleados = @idEmpleado";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el registro: " + ex.Message);
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
