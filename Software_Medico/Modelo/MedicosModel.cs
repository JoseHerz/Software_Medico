using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class MedicosModel
    {
        public int Id_Medico { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public int Id_Usuario { get; set; }
        public int Credenciales { get; set; }
        public int Id_Horario { get; set; }
        public string Telefono { get; set; }
        public int Id_Especialidad { get; set; }
        public string Sexo { get; set; }



        public static DataTable GetMedico { get; set; }

    }
}
