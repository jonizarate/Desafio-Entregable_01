using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Entregable_01
{
    public class ClassUsuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreDeUsuario { get; set; }
        public int Contrasenia { get; set; }
        public string Mail { get; set; }

        public ClassUsuario(){
            UsuarioId=0;
            Nombre = "";
            Apellido = "";
            NombreDeUsuario = "";
            Contrasenia = 0;
            Mail = ""; 
        }
        public ClassUsuario(int usuarioId, string nombre, string apellido, string nombreDeUsuario, int contrasenia, string mail)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellido = apellido;
            NombreDeUsuario = nombreDeUsuario;
            Contrasenia = contrasenia;
            Mail = mail;
        }
    }
}
