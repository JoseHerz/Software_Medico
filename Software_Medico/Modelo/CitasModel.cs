using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class CitasModel
    {
       public int Id_Cita {  get; set; }
       public int Id_Medico { get; set; }
       public int Id_Paciente  { get; set; }
        public DateTime Fecha_Cita  { get; set; }
       
        public DateTime HoraIni_Cita { get; set; }
        public DateTime HoraFin_Cita { get; set; }
        public int Duracion { get; set; }
        public string Estado_Cita { get; set; }
        public int Id_Tipo_Cita { get; set; }
        public int Id_Clinica { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Consultorio { get; set; }
        public string Observacion { get; set; }

        public static DataTable GetCitas { get; set; }











    }
}
