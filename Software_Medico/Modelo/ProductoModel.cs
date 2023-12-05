using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Medico.Modelo
{
    internal class ProductoModel
    {
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
        public string Unidad_Medida { get; set; }
        public DateTime Fecha_Caducidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public string Ubicacion { get; set; }
        public int Id_Tipo_Inventario { get; set; }
        public bool Estatus { get; set; }
        public string Indicaciones { get; set; }

        public static DataTable GetProducto { get; set; }


    }
}
