using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4.Clases
{
    class ControlLogin
    {
        public string ctrlLogin(string usuario, string Contraseña)
        {
            RegistroUsuario registro = new RegistroUsuario();
            string respuesta = "";
            Usuarios datosUsuarios = null;

            if (string.IsNullOrEmpty(usuario)||string.IsNullOrEmpty(Contraseña))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuarios = registro.existeUsuario(usuario);
                if (datosUsuarios == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuarios.Contraseña!= registro.generarSha1(Contraseña))
                    {
                        respuesta = "El usuario  y/o contraseña no coinciden";
                    }
                }
            }

            return respuesta;

        }
    }
}
