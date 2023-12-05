using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class FacturaModel
    {

        public int Id_Factura { get; set; }
        public int Id_Paciente { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public decimal Total { get; set; }
        public string Metodo_Pago { get; set; }
        public string Estado { get; set; }
        public int Id_Expediente { get; set; }

        public int Id_Usuario { get; set; }

        public static DataTable GetFactura { get; set; }

    }
}
