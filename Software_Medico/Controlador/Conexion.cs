using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Software_Medico.Controlador
{
    internal class Conexion
    {
        public SqlConnection GetConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBDiseño"].ToString());
        }
    }
}
