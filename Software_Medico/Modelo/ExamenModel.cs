using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class ExamenModel
    {

        public int Id_Examenes { get; set; }
        public string Nombre_Examen { get; set; }
        public bool Estatus { get; set; }

        public static DataTable GetExamen { get; set; }

    }
}
