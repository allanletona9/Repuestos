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
        
        string sRecuperarRepuestos = "  select * from tbl_repuestos";
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
        public SqlDataAdapter insertarRepuestos(int id_tipo_repuesto, string cod_fabricante, string descripcion, string costo_repuesto1, string costo_repuesto2, string costo_repuesto3, string costo_repuesto4, string precio_venta1, string precio_venta2, string precio_venta3, string precio_venta4, string cantidad, string facturar_sin_existencia)
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

               
                string sInsertarRepuestos = "INSERT INTO tbl_repuestos( PK_idrepuestos,PK_idtiporepuesto,codigo_fabricante, descripcion_repuesto,costo_repuesto1,costo_repuesto2,costo_repuesto3,costo_repuesto4,precio_venta1,precio_venta2,precio_venta3,precio_venta4,cantidad,facturar_sin_existencia,estado_repuesto ) VALUES ('" + max + "', '" + id_tipo_repuesto + "', '" + descripcion + "','" + costo_repuesto1 + "','" + costo_repuesto2 + "','" + costo_repuesto3 + "','" + costo_repuesto4 + "','" + precio_venta1 + "','" + precio_venta2 + "','" + precio_venta3 + "','" + precio_venta4 + "','" + cantidad + "', '" + facturar_sin_existencia +  "', '1' ) ";
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

        public SqlDataAdapter modificarRepuestos(int id, int id_tipo_repuesto, string cod_fabricante, string descripcion, string costo_repuesto1, string costo_repuesto2, string costo_repuesto3, string costo_repuesto4, string precio_venta1, string precio_venta2, string precio_venta3, string precio_venta4, string cantidad, string facturar_sin_existencia, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_repuestos SET PK_idtiporepuesto = '" + id_tipo_repuesto + "', codigo_fabricante = '" + cod_fabricante + "',descripcion_repuesto = '" + descripcion + "',costo_repuesto1= '" + costo_repuesto1 + "',costo_repuesto2= '" + costo_repuesto2 + "',costo_repuesto3= '" + costo_repuesto3 + "',costo_repuesto4= '" + costo_repuesto4 + "',precio_venta1= '" + precio_venta1 + "',precio_venta2= '" + precio_venta2 + "',precio_venta3= '" + precio_venta3 + "',precio_venta4= '" + precio_venta4 + "',cantidad= '" + cantidad + "',facturar_sin_existencia = '" + facturar_sin_existencia + "', estado_repuesto = '" + estado + "' WHERE PK_Idrepuestos = '" + id + "'";
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

        public SqlDataAdapter getProductoKardex(int iCodigoproducto)
        {
            try
            {
                string sRecuperarKardex = "SELECT r.PK_idrepuesto, r.descripcion_repuesto, i.existencias FROM tbl_repuestos AS r INNER JOIN tbl_inventario AS i WITH(NOLOCK) ON r.PK_idrepuesto = i.PK_idrepuesto WHERE i.PK_idrepuesto = '"+iCodigoproducto+ "' ;";
                SqlDataAdapter sqlRecuperarKardex = new SqlDataAdapter(sRecuperarKardex, cn.conectar());
                sqlRecuperarKardex.SelectCommand.Connection.Close();
                return sqlRecuperarKardex;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion del producto de Kardex: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter getVentasKardex(int iCodigoproducto, string fechaInicio, string fechaFin)
        {
            try
            {
                string sRecuperarKardex = "  SELECT fe.fecha_fact, fe.PK_idFactEnc, r.descripcion_repuesto,'VENTA' AS venta ,fd.cantidad FROM tbl_factura_encabezado AS fe INNER JOIN tbl_factura_detalle AS fd WITH(NOLOCK) ON fe.PK_idFactEnc = fd.PK_idFactEnc INNER JOIN tbl_repuestos AS r ON fd.PK_idrepuesto = r.PK_idrepuesto WHERE r.PK_idrepuesto = '"+iCodigoproducto+"' AND fe.fecha_fact BETWEEN '"+fechaInicio+"' AND '"+fechaFin+"' ";
                SqlDataAdapter sqlRecuperarKardex = new SqlDataAdapter(sRecuperarKardex, cn.conectar());
                sqlRecuperarKardex.SelectCommand.Connection.Close();
                return sqlRecuperarKardex;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de las ventas de Kardex: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter getComprasKardex(int iCodigoproducto, string fechaInicio, string fechaFin)
        {
            try
            {
                string sRecuperarKardex = "  SELECT ce.fecha_compra, ce.PK_idcompraenc, r.descripcion_repuesto, 'COMPRA' AS compra, cd.cantidad_compra FROM tbl_compras_encabezado AS ce INNER JOIN tbl_compras_detalle AS cd WITH(NOLOCK) ON ce.PK_idcompraenc = cd.PK_idcompraenc INNER JOIN tbl_repuestos AS r ON cd.PK_idrepuesto = r.PK_idrepuesto WHERE r.PK_idrepuesto = '"+iCodigoproducto+"' AND ce.fecha_compra BETWEEN '"+fechaInicio+"' AND '"+fechaFin+"'";
                SqlDataAdapter sqlRecuperarKardex = new SqlDataAdapter(sRecuperarKardex, cn.conectar());
                sqlRecuperarKardex.SelectCommand.Connection.Close();
                return sqlRecuperarKardex;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de las compras de Kardex: " + ex.Message);
                return null;
            }
        }

    }
}
