using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing.Drawing2D;

namespace Gimnasio.Clases
{
    public class Usuario 
    {
        private DBConn conexion = new DBConn();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public static string Nombre { get; set; }
        public static string Clave { get; set; }
        public static string Tipo { get; set; }


        public static int ValidarUsuario(string Correo, string Clave)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.AbrirConexionn())
                {
                    SqlCommand cmd = new SqlCommand("VALIDAR_USUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CORREO", Correo));
                    cmd.Parameters.Add(new SqlParameter("@CLAVE", Clave));
                    ;

                    // retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;
                            Nombre = rdr[2].ToString();
                            Tipo = rdr[3].ToString();
                            if (Tipo == "Admin")
                            {
                                retorno = 1;
                                return retorno; 
                            }
                            else
                            {
                                retorno = 4;
                                return retorno;
                            }
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;
        }


        public DataTable ConsultarCuenta(string correo, string clave)
        {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "CONSULTAR_CUENTA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CORREO", correo);
                comando.Parameters.AddWithValue("@CLAVE", clave);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }
        

    }
}