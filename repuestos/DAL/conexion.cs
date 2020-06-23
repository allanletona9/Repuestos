using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class conexion
    {
        public SqlConnection conectar()
        {
            string sCadenaConexion = " server=DESKTOP-00E9Q34\\VINBA; database=db_repuestos;Integrated Security= True  ";
            SqlConnection conectar = new SqlConnection();

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
