using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gimnasio.Clases
{
    public class DBConn
    {
        private static SqlConnection Conexion = new SqlConnection("Server=PORTATIL-0362\\SQLEXPRESS; DataBase=GIMNASIO;Integrated Security = True");
        public SqlConnection conexion = new SqlConnection("Server=PORTATIL-0362\\SQLEXPRESS; DataBase=GIMNASIO;Integrated Security = True");


        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public static SqlConnection AbrirConexionn()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

        public static SqlConnection CerrarConexionn()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}