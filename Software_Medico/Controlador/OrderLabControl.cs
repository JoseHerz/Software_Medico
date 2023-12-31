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
    internal class OrderLabControl
    {

        public bool CrearOrderLab(OrderLabModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into ORDENES_LABORATORIO(" +
                        "ID_ORDEN_LABORATORIO," +
                        "ID_PACIENTE," +
                        "ID_EXPEDIENTE," +
                        "ID_MEDICO," +
                        "FECHA_ORDEN," +
                        "ID_EXAMEN," +
                        "ESTADO_ORDEN," +
                        "RESULTADOS," +
                        "ID_LABORATORIO," +
                        "ID_USUARIO" +
                        ") select" +
                        " '" + Modelo.Id_Orden_Laboratorio + "'," +
                        " '" + Modelo.Id_Paciente + "'," +
                        " '" + Modelo.Id_Expediente + "'," +
                        " '" + Modelo.Id_Medico + "'," +
                        " '" + Modelo.Fecha_Orden + "'," +
                        " '" + Modelo.Id_Examen + "'," +
                        " '" + Modelo.Estado_Orden + "'," +
                        " '" + Modelo.Resultados + "'," +
                        " '" + Modelo.Id_Laboratorio + "'," +
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
        public bool ValidOrderLab(OrderLabModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from ORDENES_LABORATORIO Where ID_ORDEN_LABORATORIO = @Idorderlab";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Idorderlab", Modelo.Id_Orden_Laboratorio);
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

        public bool UpdateOrderLab(OrderLabModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE ORDENES_LABORATORIO SET " +
                        "ID_PACIENTE =                      '" + Modelo.Id_Paciente + "'," +
                        "ID_EXPEDIENTE =                    '" + Modelo.Id_Expediente + "', " +
                        "ID_MEDICO =                        '" + Modelo.Id_Medico + "'" +
                        "FECHA_ORDEN =                      '" + Modelo.Fecha_Orden + "'" +
                        "ID_EXAMEN =                        '" + Modelo.Id_Examen + "'" +
                        "ESTADO_ORDEN =                     '" + Modelo.Estado_Orden + "'" +
                        "RESULTADOS =                       '" + Modelo.Resultados + "'" +
                        "ID_LABORATORIO =                   '" + Modelo.Id_Laboratorio + "'" +
                        "ID_USUARIO =                       '" + Modelo.Id_Usuario + "'" +
                        " WHERE ID_ORDEN_LABORATORIO =      '" + Modelo.Id_Orden_Laboratorio + "';";


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

        public void ListarOrderLab()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from ORDENES_LABORATORIO";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OrderLabModel.GetOrderLab = dt;

        }
        public bool EliminarOrderLab(OrderLabModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM ORDENES_LABORATORIO WHERE ID_ORDEN_LABORATORIO = '" + Modelo.Id_Orden_Laboratorio + "';";


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
