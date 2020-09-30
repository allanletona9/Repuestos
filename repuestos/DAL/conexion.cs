using System;
using System.Data.SqlClient;

namespace DAL
{
    public class conexion
    {
        public SqlConnection conectar()
        {
            string sCadenaConexion = "server=keyshard; database=db_repuestos;Integrated Security= True  ";
            SqlConnection conectar = new SqlConnection();
            /*DESKTOP-M8BBGJ3\\SQLEXPRESS*/
            try
            {
                conectar.ConnectionString = sCadenaConexion;
                conectar.Open();
                return conectar;

            }
            catch (Exception ex)
            {
                //Excepcion por si la base de datos no se conecta
                Console.WriteLine("Error en la conexion a la base de datos" + ex.Message);
                return null;

            }

        }
    }
}
