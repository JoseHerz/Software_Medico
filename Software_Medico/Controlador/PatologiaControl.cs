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
    internal class PatologiaControl
    {

        public bool CrearPatologia(PatologiasModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into PATOLOGIAS(" +
                        "ID_PATOLOGIA," +
                        "NOMBRE_PATOLOGIA," +
                        "DESCRIPCION_PATOLOGIA," +
                        ") select" +
                        " '" + Modelo.Id_Patologia + "'," +
                        " '" + Modelo.Nombre_Patologia + "'," +
                        " '" + Modelo.Descripcion_Patologia + "'";

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
        public bool ValidPatologia(PatologiasModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from PATOLOGIAS Where ID_PATOLOGIA = @Idpato";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Idpato", Modelo.Id_Patologia);
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

        public bool UpdatePatologia(PatologiasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE PATOLOGIAS SET " +
                        "NOMBRE_PATOLOGIA =         '" + Modelo.Nombre_Patologia + "'," +
                        "DESCRIPCION_PATOLOGIA =    '" + Modelo.Descripcion_Patologia + "', " +
                        "WHERE ID_PATOLOGIA =       '" + Modelo.Id_Patologia + "';";


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

        public void ListarPatologia()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from PATOLOGIAS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PatologiasModel.GetPatologia = dt;

        }

        public bool EliminarPatologia(PatologiasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM PATOLOGIAS WHERE ID_PATOLOGIA = '" + Modelo.Id_Patologia + "';";


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
