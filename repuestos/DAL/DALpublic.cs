using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;


namespace DAL
{
    public class DALpublic
    {
        conexion cn = new conexion();
        public SqlDataAdapter obtenerProductos()
{
        try{
        
        string sRecuperarRepuestos = "SELECT PK_Idrepuestos,nombre_repuestos,descripcion_repuesto,precio_unitario,estado_repuesto FROM tbl_repuestos ";
        SqlDataAdapter sqlRecuperarRepuestos = new SqlDataAdapter(sRecuperarRepuestos, cn.conectar());
        sqlRecuperarRepuestos.SelectCommand.Connection.Close();
            return sqlRecuperarRepuestos;

        }catch(Exception ex)
        {
        Console.WriteLine("Error en la obtencion de Repuestos: "  +  ex.Message);
        return null;
}
        }

        public SqlDataAdapter buscarRepuestos(string nombre)
        {
            string sBuscar = "SELECT PK_Idrepuestos,nombre_repuestos,descripcion_repuesto,precio_unitario,estado_repuesto FROM tbl_repuestos WHERE nombre_repuestos LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }
        public SqlDataAdapter insertarRepuestos(string nombre, string descripcion, string precio_unitario)
        {
            try
            {
                /*METODO PARA AUTO INCREMENTAR EL ID SIGUIENTE*/
                int max = 0;
                string sMax = "SELECT MAX(PK_Idrepuestos) FROM tbl_repuestos";
                SqlCommand sqlMax = new SqlCommand(sMax, cn.conectar());
                SqlDataReader almacena = sqlMax.ExecuteReader();

                while (almacena.Read())
                {
                    max = almacena.GetInt32(0);
                }

                max++;
                almacena.Close();

               
                string sInsertarRepuestos = "INSERT INTO tbl_repuestos( PK_Idrepuestos,nombre_repuestos,descripcion_repuesto,precio_unitario,estado_repuesto ) VALUES ('" + max + "', '"  + nombre + "', '" + descripcion + "', '" + precio_unitario +  "', '1' ) ";
                SqlDataAdapter sqlInsertarRepuestos = new SqlDataAdapter(sInsertarRepuestos, cn.conectar());
                sqlInsertarRepuestos.SelectCommand.Connection.Close();
                return sqlInsertarRepuestos;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de Repuestos en capa datos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter modificarRepuestos(int id, string nombre, string descripcion, string precio_unitario, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_repuestos SET nombre_repuestos = '" + nombre + "', descripcion_repuesto = '" + descripcion + "',precio_unitario = '" + precio_unitario + "', estado_repuesto = '" + estado + "' WHERE PK_Idrepuestos = '" + id + "'";
                SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
                return sqlModificar;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la modificacion del repuesto: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter eliminarRepuestos(int id)
        {
            try
            {
                string sEliminar = "UPDATE tbl_repuestos SET estado_repuesto = '0' WHERE PK_Idrepuestos = '" + id + "'";
                SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
                return sqlEliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la eliminacion de repuestos: " + ex.Message);
                return null;
            }
        }
        /////////////////////////////////////////Clientes//////////////////////////////////////////
        public SqlDataAdapter obtenerclientes()
        {
            try
            {

                string sRecuperarclientes = "SELECT PK_idcliente,nombre_cliente,nit_cliente,estado_cliente FROM tbl_cliente ";
                SqlDataAdapter sqlRecuperarclientes = new SqlDataAdapter(sRecuperarclientes, cn.conectar());
                sqlRecuperarclientes.SelectCommand.Connection.Close();
                return sqlRecuperarclientes;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de clientes: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter buscarclientes(string nombre)
        {
            string sBuscar = "SELECT PK_idcliente,nombre_cliente,nit_cliente,estado_cliente FROM tbl_cliente WHERE nombre_cliente LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarclientes(string nombre, string nit)
        {
            try
            {
                /*METODO PARA AUTO INCREMENTAR EL ID SIGUIENTE*/
                int max = 0;
                string sMax = "SELECT MAX(PK_idcliente) FROM tbl_cliente";
                SqlCommand sqlMax = new SqlCommand(sMax, cn.conectar());
                SqlDataReader almacena = sqlMax.ExecuteReader();

                while (almacena.Read())
                {
                    max = almacena.GetInt32(0);
                }

                max++;
                almacena.Close();


                string sInsertarclientes = "INSERT INTO tbl_cliente( PK_idcliente,nombre_cliente,nit_cliente,estado_cliente ) VALUES ('" + max + "', '" + nombre + "', '" + nit + "', '1' ) ";
                SqlDataAdapter sqlInsertarclientes = new SqlDataAdapter(sInsertarclientes, cn.conectar());
                sqlInsertarclientes.SelectCommand.Connection.Close();
                return sqlInsertarclientes;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de clientes en capa datos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter modificarclientes(int id, string nombre, string nit, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_cliente SET nombre_cliente = '" + nombre + "', nit_cliente = '" + nit  + "', estado_cliente = '" + estado + "' WHERE PK_idcliente = '" + id + "'";
                SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
                return sqlModificar;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la modificacion del cliente: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter eliminarclientes(int id)
        {
            try
            {
                string sEliminar = "UPDATE tbl_cliente SET estado_cliente = '0' WHERE PK_idcliente = '" + id + "'";
                SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
                return sqlEliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la eliminacion de cliente: " + ex.Message);
                return null;
            }
        }
        ////////////////////////////proveedores////////////////////////////////
        public SqlDataAdapter obtenerproveedores()
        {
            try
            {

                string sRecuperarproveedores = "SELECT PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor FROM tbl_proveedor ";
        SqlDataAdapter sqlRecuperarproveedores = new SqlDataAdapter(sRecuperarproveedores, cn.conectar());
        sqlRecuperarproveedores.SelectCommand.Connection.Close();
                return sqlRecuperarproveedores;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de proveedores: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter buscarproveedores(string nombre)
{
    string sBuscar = "SELECT PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor FROM tbl_proveedor WHERE nombre_proveedor LIKE '%" + nombre + "%';";
    SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
    return sqlBuscar;
}

public SqlDataAdapter insertarproveedores(string nombre, string nit,string direccion)
{
    try
    {
        /*METODO PARA AUTO INCREMENTAR EL ID SIGUIENTE*/
        int max = 0;
        string sMax = "SELECT MAX(PK_idproveedor) FROM tbl_proveedor";
        SqlCommand sqlMax = new SqlCommand(sMax, cn.conectar());
        SqlDataReader almacena = sqlMax.ExecuteReader();

        while (almacena.Read())
        {
            max = almacena.GetInt32(0);
        }

        max++;
        almacena.Close();


        string sInsertarproveedor = "INSERT INTO tbl_( SELECT PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor  ) VALUES ('" + max + "', '" + nombre + "', '" + nit + "','" + direccion + "', '1' ) ";
        SqlDataAdapter sqlInsertarproveedores = new SqlDataAdapter(sInsertarproveedor, cn.conectar());
        sqlInsertarproveedores.SelectCommand.Connection.Close();
        return sqlInsertarproveedores;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Error en la insercion de proveedores en capa datos: " + ex.Message);
        return null;
    }
}

public SqlDataAdapter modificarproveedores(int id, string nombre, string nit,string direccion, string estado)
{
    try
    {
        string sModificar = "UPDATE tbl_proveedor SET nombre_proveedor = '" + nombre + "', nit_proveedor = '" + nit + "', direccion_proveedor = '" + direccion + "', estado_proveedor = '" + estado + "' WHERE PK_idproveedor = '" + id + "'";
        SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
        return sqlModificar;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Error en la modificacion del proveedor: " + ex.Message);
        return null;
    }
}

public SqlDataAdapter eliminarproveedores(int id)
{
    try
    {
        string sEliminar = "UPDATE tbl_proveedor SET estado_proveedor = '0' WHERE PK_idproveedor = '" + id + "'";
        SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
        return sqlEliminar;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error en la eliminacion de proveedor: " + ex.Message);
        return null;
    }
}

        //////////////////////////marca///////////////////////////////
        public SqlDataAdapter obtenermarca()
        {
            try
            {

                string sRecuperarmarca = "SELECT PK_idmarca,nombre_marca,estado_marca FROM tbl_marcas_vehiculo ";
                SqlDataAdapter sqlRecuperarmarca= new SqlDataAdapter(sRecuperarmarca, cn.conectar());
                sqlRecuperarmarca.SelectCommand.Connection.Close();
                return sqlRecuperarmarca;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de marcas: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter buscarmarca(string nombre)
        {
            string sBuscar = "SELECT PK_idmarca,nombre_marca,estado_marca FROM tbl_marcas_vehiculo WHERE nombre_marca LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarmarca(string nombre)
        {
            try
            {
                /*METODO PARA AUTO INCREMENTAR EL ID SIGUIENTE*/
                int max = 0;
                string sMax = "SELECT MAX(PK_idmarca) FROM tbl_marcas_vehiculo";
                SqlCommand sqlMax = new SqlCommand(sMax, cn.conectar());
                SqlDataReader almacena = sqlMax.ExecuteReader();

                while (almacena.Read())
                {
                    max = almacena.GetInt32(0);
                }

                max++;
                almacena.Close();


                string sInsertarmarca = "INSERT INTO tbl_marcas_vehiculo ( SELECT PK_idmarca,nombre_marca,estado_marca ) VALUES ('" + max + "', '" + nombre + "', '1' ) ";
                SqlDataAdapter sqlInsertarmarca = new SqlDataAdapter(sInsertarmarca, cn.conectar());
                sqlInsertarmarca.SelectCommand.Connection.Close();
                return sqlInsertarmarca;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de marca en capa datos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter modificarmarca(int id, string nombre, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_marcas_vehiculo SET nombre_marca = '" + nombre + "', estado_marca = '" + estado + "' WHERE PK_idmarca = '" + id + "'";
                SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
                return sqlModificar;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la modificacion de la marca: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter eliminarmarca(int id)
        {
            try
            {
                string sEliminar = "UPDATE tbl_marcas_vehiculo SET estado_marca = '0' WHERE PK_idmarca = '" + id + "'";
                SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
                return sqlEliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la eliminacion de la marca: " + ex.Message);
                return null;
            }
        }

        /////tipo de pago//////////

        public SqlDataAdapter obtenerpago()
        {
            try
            {

                string sRecuperarpago = "SELECT PK_idTipopago,nombre_tipopago,estado_tipopago FROM tbl_tipo_pago ";
                SqlDataAdapter sqlRecuperarpago = new SqlDataAdapter(sRecuperarpago, cn.conectar());
                sqlRecuperarpago.SelectCommand.Connection.Close();
                return sqlRecuperarpago;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Tipos de pago: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter buscarpago(string nombre)
        {
            string sBuscar = "SELECT PK_idTipopago,nombre_tipopago,estado_tipopago WHERE nombre_tipopago LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarpago(string nombre)
        {
            try
            {
                /*METODO PARA AUTO INCREMENTAR EL ID SIGUIENTE*/
                int max = 0;
                string sMax = "SELECT MAX(PK_idTipopago) FROM tbl_tipo_pago";
                SqlCommand sqlMax = new SqlCommand(sMax, cn.conectar());
                SqlDataReader almacena = sqlMax.ExecuteReader();

                while (almacena.Read())
                {
                    max = almacena.GetInt32(0);
                }

                max++;
                almacena.Close();


                string sInsertarpago = "INSERT INTO tbl_tipo_pago ( SELECT PK_idTipopago,nombre_tipopago,estado_tipopago) VALUES ('" + max + "', '" + nombre + "', '1' ) ";
                SqlDataAdapter sqlInsertarpago = new SqlDataAdapter(sInsertarpago, cn.conectar());
                sqlInsertarpago.SelectCommand.Connection.Close();
                return sqlInsertarpago;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de tipo de pago en capa datos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter modificarpago(int id, string nombre, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_tipo_pago SET nombre_tipopago = '" + nombre + "', estado_tipopago = '" + estado + "' WHERE PK_idTipopago = '" + id + "'";
                SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
                return sqlModificar;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la modificacion del tipo de pago: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter eliminarpago(int id)
        {
            try
            {
                string sEliminar = "UPDATE tbl_tipo_pago SET estado_tipopago = '0' WHERE PK_idTipopago = '" + id + "'";
                SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
                return sqlEliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la eliminacion del tipo de pago: " + ex.Message);
                return null;
            }
        }

        /*ALLAN LETONA*/

        public SqlDataAdapter getInventrio()
        {
            try
            {
                string sRecuperarInventario = "SELECT rep.PK_idrepuesto,rep.descripcion_repuesto, trep.descripcion_tiporepuesto, MAX(fe.fecha_fact) AS ultima_venta, rep.codigo_fabricante, rep.precio_venta1, rep.precio_venta2, rep.precio_venta3, rep.precio_venta4 FROM tbl_tiporepuesto AS trep INNER JOIN tbl_repuestos AS rep WITH(NOLOCK) ON trep.PK_idtiporepuesto = rep.PK_idtiporepuesto INNER JOIN tbl_inventario AS inv WITH(NOLOCK) ON rep.PK_idrepuesto = inv.PK_idrepuesto CROSS JOIN tbl_factura_encabezado AS fe WITH(NOLOCK) INNER JOIN tbl_factura_detalle AS fd WITH(NOLOCK) ON fe.PK_idFactEnc = fd.PK_idFactEnc WHERE rep.PK_idrepuesto IN(fd.PK_idrepuesto) GROUP BY rep.PK_idrepuesto,rep.descripcion_repuesto, trep.descripcion_tiporepuesto, rep.codigo_fabricante, rep.precio_venta1, rep.precio_venta2, rep.precio_venta3, rep.precio_venta4 ";
                SqlDataAdapter sqlRecuperarInventario = new SqlDataAdapter(sRecuperarInventario, cn.conectar());
                sqlRecuperarInventario.SelectCommand.Connection.Close();
                return sqlRecuperarInventario;

            }catch(Exception ex)
            {
                Console.WriteLine("Error en la obtencion del inventario: "+ex.Message);
                return null;
            }
        }

    }
}
