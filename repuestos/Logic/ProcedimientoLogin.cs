using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;


namespace Logic
{
   public class ProcedimientoLogin
    {
        public bool llamarProcedimiento(string usuario, string clave)
        {
            try
            {
                conexion cn = new conexion();
                SqlCommand cmd = new SqlCommand ("procedimientoLogin", cn.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", SqlDbType.Text).Value = usuario;
                cmd.Parameters.AddWithValue("@clave", SqlDbType.Text).Value = clave;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    cmd.Connection.Close();
                    reader.Close();
                   
                    return true;
                }
                else
                {
                    cmd.Connection.Close();
                    reader.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return false;

            }

        }   
    }
}
