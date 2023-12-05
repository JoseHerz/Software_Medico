using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class PatologiasModel
    {
        public int Id_Patologia { get; set; }
        public string Nombre_Patologia { get; set; }
        public string Descripcion_Patologia { get; set; }

        public static DataTable GetPatologia { get; set; }

    }
}
