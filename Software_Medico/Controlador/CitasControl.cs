﻿using Software_Medico.Modelo;
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
    internal class CitasControl
    {

        public bool CrearCita(CitasModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into CITAS(" +
                        "ID_MEDICO," +
                        "ID_PACIENTE," +
                        "FECHA_CITA," +
                        "HORAINICIAL_CITA," +
                        "HORAFINAL_CITA," +
                        "DURACION," +
                        "ESTADO_CITA," +
                        "ID_TIPO_CITA," +
                        "ID_CLINICA," +
                        "ID_CONSULTORIO," +
                        "OBSERVACIONES," +
                        "ID_USUARIO" +
                        ") select" +

                        " '" + Modelo.Id_Medico + "'," +
                        " '" + Modelo.Id_Paciente + "'," +
                        " '" + Modelo.Fecha_Cita + "'," +
                        " '" + Modelo.HoraIni_Cita + "'," +
                        " '" + Modelo.HoraFin_Cita + "'," +
                        " '" + Modelo.Duracion + "'," +
                        " '" + Modelo.Estado_Cita + "'," +
                        " '" + Modelo.Id_Tipo_Cita + "'," +
                        " '" + Modelo.Id_Clinica + "'," +
                        " '" + Modelo.Id_Consultorio + "',"+
                        " '" + Modelo.Observacion + "'," +
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
        public bool ValidCita(CitasModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from CITAS Where ID_CITA = @Idcita";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Idcita", Modelo.Id_Cita);
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

        public bool UpdateCita(CitasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE CITAS SET " +
                        "ID_MEDICO =        '" + Modelo.Id_Medico + "'," +
                        "ID_PACIENTE =      '" + Modelo.Id_Paciente + "', " +
                      
                        "FECHA_CITA =       '" + Modelo.Fecha_Cita + "'" +
                        
                        "HORAINICIAL_CITA = '" + Modelo.HoraIni_Cita + "'" +
                        "HORAFINAL_CITA =   '" + Modelo.HoraFin_Cita + "'" +
                        "DURACION =         '" + Modelo.Duracion + "'" +
                        "ESTADO_CITA =      '" + Modelo.Estado_Cita + "'" +
                        "ID_TIPO_CITA =     '" + Modelo.Id_Tipo_Cita + "'" +
                        "ID_CLINICA =       '" + Modelo.Id_Clinica + "'" +
                        "ID_CONSULTORIO =   '" + Modelo.Id_Consultorio + "'" +
                        "OBSERVACIONES =    '" + Modelo.Observacion + "'" +
                        "ID_USUARIO =       '" + Modelo.Id_Usuario + "'" +
                        " WHERE ID_CITA =   '" + Modelo.Id_Cita + "';";


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

        public void ListarCita()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from CITAS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CitasModel.GetCitas = dt;

        }
        public bool EliminarCita(CitasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM CITAS WHERE ID_CITA = '" + Modelo.Id_Cita + "';";


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


        public string buscarNombre(string idpa)
        {

            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "SELECT CONCAT(NOMBRE,' ',APELLIDO) AS NOMBRE_COMPLETO FROM PACIENTES WHERE ID_PACIENTE = @idpac";

                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@idpac", idpa);
                    string nombre = (string)cmd.ExecuteScalar();
                    if (nombre != null)
                    {
                        return nombre;
                    }
                    else
                    {
                        return nombre = "Paciente no encontrado";
                    }


                }

                Con.Close();

            }
            
        }


        public DataTable CargarClinicaCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_CLINICA,NOMBRE_CLINICA from CLINICA ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }

        public DataTable CargarConsultorioCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "SELECT ID_CONSULTORIO ,NOMBRE_CONSULTORIO FROM CONSULTORIO";
          
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }

        public DataTable CargarDoctorCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_MEDICO,CONCAT(PRIMER_NOMBRE,' ',PRIMER_APELLIDO) as NOMBRE_MEDICO  from MEDICOS ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }



        public void ListarCita2(int idpac)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "SELECT p.ID_PACIENTE AS Codigo_Paciente, CONCAT(p.NOMBRE,' ',p.APELLIDO) AS NOMBRE_PACIENTE, " +
                                 "c.FECHA_CITA AS CITA, c.HORAINICIAL_CITA as HORA, CONCAT(d.PRIMER_NOMBRE,' ',d.SEGUNDO_APELLIDO) as DOCTOR, " +
                                 "cc.NOMBRE_CLINICA AS CLINICA, c.ESTADO_CITA AS ESTADO " +
                                 "FROM CITAS c " +
                                 "INNER JOIN PACIENTES p ON c.ID_PACIENTE = p.ID_PACIENTE " +
                                 "INNER JOIN MEDICOS d ON c.ID_MEDICO = d.ID_MEDICO " +
                                 "INNER JOIN CLINICA cc ON c.ID_CLINICA = cc.ID_CLINICA " +
                                 "WHERE c.ID_PACIENTE = @idpac";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@idpac", idpac);

                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd); // Utiliza el comando cmd en lugar de la cadena sql
                        adaptador.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CitasModel.GetCitas = dt;

        }






    }
}
