using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4
{
    class RegistroClientes
    {

        //Clase donde se crearan los metodos o funciones para los clientes
        private string nombre;
        private string apellidos;
        private string dui;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dui { get => dui; set => dui = value; }

        //public string Nombre
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}
    }
}
