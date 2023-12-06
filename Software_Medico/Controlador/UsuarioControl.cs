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
    internal class UsuarioControl
    {


        public bool CrearUser(UsuarioModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into USUARIOS(" +
                 
                        "NOMBRE," +
                        "APELLIDO," +
                        "CORREO_ELECTRONICO," +
                        "CLAVE," +
                        "ID_USUARIO_ROL," +
                        "ESTATUS," +
                        "HUELLA" +
                        ") select" +
                     
                        " '" + Modelo.Nombre + "'," +
                        " '" + Modelo.Apellido + "'," +
                        " '" + Modelo.Correo_Electronico + "'," +
                        " '" + Modelo.Clave + "'," +
                        " '" + Modelo.Id_Usuario_Rol + "'," +
                        " '" + Modelo.Estatus + "'," +
                        " '" + Modelo.Huella + "'";

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
        public bool ValidUser(UsuarioModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from USUARIOS Where ID_USUARIO = @Iduser";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Iduser", Modelo.Id_Usuario);
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

        public bool UpdateUser(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE USUARIOS SET " +
                        "NOMBRE =                      '" + Modelo.Nombre + "'," +
                        "APELLIDO =                    '" + Modelo.Apellido + "', " +
                        "CORREO_ELECTRONICO =          '" + Modelo.Correo_Electronico + "'" +
                        "CLAVE =                       '" + Modelo.Clave + "'" +
                        "ID_USUARIO_ROL =              '" + Modelo.Id_Usuario_Rol + "'" +
                        "ESTATUS =                     '" + Modelo.Estatus + "'" +
                        "HUELLA =                      '" + Modelo.Huella + "'" +
                        " WHERE ID_USUARIO =           '" + Modelo.Id_Usuario + "';";


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

        public void ListarUser()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from USUARIOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UsuarioModel.GetUsuario = dt;

        }
        public bool EliminarUser(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM USUARIOS WHERE ID_USUARIO = '" + Modelo.Id_Usuario + "';";


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


        public DataTable CargarRolCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_USUARIO_ROL,DESCRIPCION from USUARIO_ROL ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }






    }
}
