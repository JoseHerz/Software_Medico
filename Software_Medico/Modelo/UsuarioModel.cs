using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class UsuarioModel
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo_Electronico { get; set; }
        public string Clave { get; set; }
        public int Id_Usuario_Rol { get; set; }
        public bool Estatus { get; set; }
        public string Huella { get; set; }

        public static DataTable GetUsuario { get; set; }


    }
}
