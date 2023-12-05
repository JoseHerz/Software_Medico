using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class ExpedienteModel
    {

        public int Id_Expediente { get; set; }

        public int Id_Cita { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Medico { get; set; }

        public DateTime Fecha_Ingreso { get; set; }

        public string Descripcion { get; set; }

        public int Id_Patologia { get; set; }

        public string Diagnostico { get; set; }
        public int Id_Examenes { get; set; }
        public string Resultado_Examen { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Usuario { get; set; }
        public int Cantidad { get; set; }
        public string Instrucciones { get; set; }

        public static DataTable GetExpediente { get; set; }




    }
}
