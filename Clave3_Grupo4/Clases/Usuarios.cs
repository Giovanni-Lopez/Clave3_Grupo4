using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4.Clases
{
    class Usuarios
    {
        private string usuario, nombre, contraseña, conContraseña;
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
    }
}
