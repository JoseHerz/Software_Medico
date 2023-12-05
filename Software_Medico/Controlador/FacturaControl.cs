using Software_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico.Controlador
{
    internal class FacturaControl
    {
        public bool CrearFactura(FacturaModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into FACTURACION_MEDICA(" +
                        "ID_FACTURA," +
                        "ID_PACIENTE," +
                        "FECHA_EMISION," +
                        "TOTAL," +
                        "METODO_PAGO," +
                        "ESTADO," +
                        "ID_EXPEDIENTE," +
                        "ID_USUARIO" +
                        ") select" +
                        " '" + Modelo.Id_Factura + "'," +
                        " '" + Modelo.Id_Paciente + "'," +
                        " '" + Modelo.Fecha_Emision + "'," +
                        " '" + Modelo.Total + "'," +
                        " '" + Modelo.Metodo_Pago + "'," +
                        " '" + Modelo.Estado + "'," +
                        " '" + Modelo.Id_Expediente + "'," +
                        " '" + Modelo.Id_Usuario + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }
        public bool ValidFactura(FacturaModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from FACTURACION_MEDICA Where ID_FACTURA = @IdFactura";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@IdFactura", Modelo.Id_Factura);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            existeDuplicado = true;
                        }

                    }

                    Con.Close();


                }

                return existeDuplicado;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Existe duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return existeDuplicado;
            }



        }

        public bool UpdateFactura(FacturaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE FACTURACION_MEDICA SET " +
                        "ID_PACIENTE =        '" + Modelo.Id_Paciente + "'," +
                        "FECHA_EMISION =      '" + Modelo.Fecha_Emision + "', " +
                        "TOTAL =              '" + Modelo.Total + "'" +
                        "METODO_PAGO =        '" + Modelo.Metodo_Pago + "'" +
                        "ESTADO =             '" + Modelo.Estado + "'" +
                        "ID_EXPEDIENTE =      '" + Modelo.Id_Expediente + "'" +
                        "ID_USUARIO =         '" + Modelo.Id_Usuario + "'" +
                        " WHERE ID_FACTURA =  '" + Modelo.Id_Factura + "';";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }

        public void ListarFactura()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from FACTURACION_MEDICA";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FacturaModel.GetFactura = dt;

        }
        public bool EliminarFactura(FacturaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM FACTURACION_MEDICA WHERE ID_FACTURA = '" + Modelo.Id_Factura + "';";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }



    }
}
