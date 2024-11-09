using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4.Clases
{
    class Usuarios
    {
        //Clase donde se crearan los metodos o funciones para los clientes
       
        /// <summary>
       /// IDusuario es autoincrementable por eso no se ha escrito
       /// </summary>
      
        private string idEmpleado;
        private string nombreUsuario;
        private string contraseñaUsuario;

        //Encapsula las variables de tipo privadas
        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string ContraseñaUsuario
        {
            get { return contraseñaUsuario; }
            set { contraseñaUsuario = value; }
        }

         //Constructor
        public Usuarios(string idEmpleado, string nombreUsuario, string contraseñaUsuario)
        {
            this.idEmpleado = idEmpleado;
            this.nombreUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
        }

        //Metodo para iniciar sesión
        public void iniciarSesion()
        {
            
        }
    }
}
