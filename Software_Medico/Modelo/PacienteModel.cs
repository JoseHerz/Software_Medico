using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class PacienteModel
    {
        public int Id_Paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Historia_Medica { get; set; }
        public string Grupo_Sanguineo { get; set; }
        public string Alergias { get; set; }
        public string Enfermedades_Cronicas { get; set; }
        public string Seguro_Medico { get; set; }
        public string Numero_Seguro_Medico { get; set; }
        public int Id_Usuario { get; set; }
        public bool Estatus { get; set; }


        public static DataTable GetPaciente { get; set; }

    }
}
