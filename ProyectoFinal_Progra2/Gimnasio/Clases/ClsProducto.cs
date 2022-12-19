using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Gimnasio.Clases
{
    public class ClsProducto
    {
        
        public static int codigo { get; set; }
        public static string nombre { get; set; }
        public static float precio { get; set; }

        public static int BuscarProducto(string cod)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.AbrirConexionn())
                {
                    SqlCommand cmd = new SqlCommand("SELECCIONAR_PRODUCTO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", cod));
                    ;

                    // retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;
                            nombre = rdr["nombre"].ToString();
                            precio = float.Parse(rdr["precio"].ToString());
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
    }
}