using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4.Clases
{
    class Cliente
    {
        public int IdClientes { get; set; }
        public string NombreCompleto { get; set; }

        // Definir el ToString() para mostrar el nombre completo en el ComboBox
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
