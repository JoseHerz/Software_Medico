using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class OrderLabModel
    {

        public int Id_Orden_Laboratorio { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Expediente { get; set; }
        public int Id_Medico { get; set; }
        public DateTime Fecha_Orden { get; set; }
        public int Id_Examen { get; set; }
        public bool Estado_Orden { get; set; }
        public string Resultados { get; set; }
        public int Id_Laboratorio { get; set; }

        public static DataTable GetOrderLab { get; set; }

    }
}
