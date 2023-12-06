using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class EspecialidadModel
    {
        public int Id_Especialidad { get; set; }
        public string Nombre_Especialidad { get; set; }
     

        public static DataTable GetEspecialidad { get; set; }


    }
}
