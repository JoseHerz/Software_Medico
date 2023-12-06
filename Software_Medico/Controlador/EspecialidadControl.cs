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
    internal class EspecialidadControl
    {

        public bool CrearEspecialidad(EspecialidadModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into ESPECIALIDADES_MEDICAS(" +
                        "ID_ESPECIALIDAD," +
                        "NOMBRE_ESPECIALIDAD," +

                        ") select" +
                        " '" + Modelo.Id_Especialidad + "'," +
                        " '" + Modelo.Nombre_Especialidad + "',";
                    

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
        public bool ValidEspecialidad(EspecialidadModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from ESPECIALIDADES_MEDICAS Where ID_ESPECIALIDAD = @Idespe";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Idespe", Modelo.Id_Especialidad);
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

        public bool UpdateEspecialidad(EspecialidadModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE ESPECIALIDADES_MEDICAS SET " +
                        "NOMBRE_EXAMEN =        '" + Modelo.Nombre_Especialidad + "'," +
                        
                        "WHERE ID_ESPECIALIDAD =    '" + Modelo.Id_Especialidad + "';";


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

        public void ListarEspecialidad()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select ID_ESPECIALIDAD,NOMBRE_ESPECIALIDAD FROM ESPECIALIDADES_MEDICAS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EspecialidadModel.GetEspecialidad = dt;

        }
        public bool EliminarEspecialidad(EspecialidadModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM ESPECIALIDADES_MEDICAS WHERE ID_ESPECIALIDAD = '" + Modelo.Id_Especialidad + "';";


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

        public DataTable CargarEspecialidadCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_ESPECIALIDAD,NOMBRE_ESPECIALIDAD from ESPECIALIDADES_MEDICAS ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }



    }
}
