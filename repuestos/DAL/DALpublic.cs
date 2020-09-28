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
        
        string sRecuperarRepuestos = "select * from tbl_repuestos";
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
            string sBuscar = "SELECT PK_idrepuesto,PK_idtiporepuesto,codigo_fabricante, descripcion_repuesto,costo_repuesto1,costo_repuesto2,costo_repuesto3,costo_repuesto4,precio_venta1,precio_venta2,precio_venta3,precio_venta4,cantidad,facturar_sin_existencia,precio_factura,estado_repuesto FROM tbl_repuestos WHERE descripcion_repuesto LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }



       

        public SqlDataAdapter insertarRepuestos(int id_repuesto,string id_tipo_repuesto, string cod_fabricante, string descripcion, string costo_repuesto1, string costo_repuesto2, string costo_repuesto3, string costo_repuesto4, string precio_venta1, string precio_venta2, string precio_venta3, string precio_venta4, int cantidad, string facturar_sin_existencia,int precio_factura)
        {
            try
            {
               

               
                string sInsertarRepuestos = "INSERT INTO tbl_repuestos( PK_idrepuesto ,PK_idtiporepuesto,codigo_fabricante, descripcion_repuesto,costo_repuesto1,costo_repuesto2,costo_repuesto3,costo_repuesto4,precio_venta1,precio_venta2,precio_venta3,precio_venta4,cantidad,facturar_sin_existencia,precio_factura,estado_repuesto ) VALUES (  '" + id_repuesto + "', '" + id_tipo_repuesto + "', '" + cod_fabricante + "','" + descripcion + "','" + costo_repuesto1 + "','" + costo_repuesto2 + "','" + costo_repuesto3 + "','" + costo_repuesto4 + "','" + precio_venta1 + "','" + precio_venta2 + "','" + precio_venta3 + "','" + precio_venta4 + "','" + cantidad + "', '" + facturar_sin_existencia + "','" + precio_factura + "', '1' ) ";
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

        public SqlDataAdapter modificarRepuestos(int id, string id_tipo_repuesto, string cod_fabricante, string descripcion, string costo_repuesto1, string costo_repuesto2, string costo_repuesto3, string costo_repuesto4, string precio_venta1, string precio_venta2, string precio_venta3, string precio_venta4, int cantidad, string facturar_sin_existencia,int precio_factura, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_repuestos SET PK_idtiporepuesto = '" + id_tipo_repuesto + "', codigo_fabricante = '" + cod_fabricante + "',descripcion_repuesto = '" + descripcion + "',costo_repuesto1= '" + costo_repuesto1 + "',costo_repuesto2= '" + costo_repuesto2 + "',costo_repuesto3= '" + costo_repuesto3 + "',costo_repuesto4= '" + costo_repuesto4 + "',precio_venta1= '" + precio_venta1 + "',precio_venta2= '" + precio_venta2 + "',precio_venta3= '" + precio_venta3 + "',precio_venta4= '" + precio_venta4 + "',cantidad= '" + cantidad + "',facturar_sin_existencia = '" + facturar_sin_existencia + "',precio_factura = '" + precio_factura + "', estado_repuesto = '" + estado + "' WHERE PK_Idrepuesto = '" + id + "'";
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
                string sEliminar = "UPDATE tbl_repuestos SET estado_repuesto = '0' WHERE PK_idrepuesto = '" + id + "'";
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

                string sRecuperarclientes = "select PK_idcliente,nombre_cliente,nit_cliente, estado_cliente, Case When estado_cliente = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_cliente";
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
            string sBuscar = "select PK_idcliente,nombre_cliente,nit_cliente, estado_cliente, Case When estado_cliente = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_cliente WHERE nombre_cliente LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter buscarnit(string nit)
        {
            string sBuscar = "select PK_idcliente,nombre_cliente,nit_cliente, estado_cliente, Case When estado_cliente = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_cliente WHERE nit_cliente LIKE '%" + nit + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarclientes(string nombre, string nit)
        {
            try
            {
                
                string sInsertarclientes = "INSERT INTO tbl_cliente( nombre_cliente,nit_cliente,estado_cliente ) VALUES ( '"+ nombre + "', '" + nit + "', '1' ) ";
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

                string sRecuperarproveedores = "SELECT PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor,Case When estado_proveedor = 1 then 'Activo' Else 'Inactivo' End as Estado2 FROM tbl_proveedor ";
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

        // Diego Gomez
        public SqlDataAdapter ObtenerPreoveedores()
        {
            try
            {

                string sRecuperarTipoRep = "select PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor from tbl_proveedor where estado_proveedor='1'";
                SqlDataAdapter sqlRecuperarTipoRep = new SqlDataAdapter(sRecuperarTipoRep, cn.conectar());
                sqlRecuperarTipoRep.SelectCommand.Connection.Close();
                return sqlRecuperarTipoRep;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Tipos de Repuestos: " + ex.Message);
                return null;
            }
        }


        public SqlDataAdapter ObtenerPrductosOC()
        {
            try
            {

                string sRecuperarTipoRep = "select PK_idrepuesto,descripcion_repuesto from tbl_repuestos";
                SqlDataAdapter sqlRecuperarTipoRep = new SqlDataAdapter(sRecuperarTipoRep, cn.conectar());
                sqlRecuperarTipoRep.SelectCommand.Connection.Close();
                return sqlRecuperarTipoRep;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Tipos de Repuestos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter logicaconsultadatos(string valor)
        {
            try
            {
                string sInsertarmarca = "select PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor,Case When estado_proveedor = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_proveedor where nombre_proveedor='" + valor + "'";
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

        public SqlDataAdapter productosoc(string valor)
        {
            try
            {
                string sInsertarmarca = "select PK_idrepuesto,PK_idtiporepuesto,descripcion_repuesto,costo_repuesto1,costo_repuesto2,costo_repuesto3,costo_repuesto4,precio_venta1,precio_venta2,precio_venta3,precio_venta4 from tbl_repuestos where descripcion_repuesto='" + valor + "'";
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

        public SqlDataAdapter ocEncabezadoProve(string nombre)
        {
            try
            {
                string sInsertarmarca = "select PK_idproveedor from tbl_proveedor where nombre_proveedor='"+ nombre + "'";
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
        
        public SqlDataAdapter ocEncabezado(string total,string fecha, string id)
        {
            try
            {
                string sInsertarmarca = " insert into tbl_compras_encabezado (PK_idproveedor,fecha_compra,total_compra,estado_compra) values ('" +id+ "','" +fecha+ "','" +total+ "','1') use db_repuestos";
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
        
        public SqlDataAdapter ocDetalleRepuesto(string producto)
        {
            try
            {
                string sInsertarmarca = "select PK_idrepuesto from tbl_repuestos where descripcion_repuesto='"+producto+"'";
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
        
        public SqlDataAdapter ocDetallEcompra()
        {
            try
            {
                string sInsertarmarca = "select top 1 PK_idcompraenc from tbl_compras_encabezado order by PK_idcompraenc desc ";
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
        
        public SqlDataAdapter InsertarOC(String idOC, string Idre, String precio, string cantidad)
        {
            try
            {
                string sInsertarmarca = "insert into tbl_compras_detalle (PK_idcompraenc,PK_idrepuesto,precio_compra,cantidad_compra) values ('" +idOC+ "','" +Idre+ "',' "+precio+" ','"+cantidad+"')";
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

        // ------------------------------------------------------------------------------------------------------------------------------


        public SqlDataAdapter buscarproveedores(string nombre)
{
    string sBuscar = "SELECT PK_idproveedor,nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor,Case When estado_proveedor = 1 then 'Activo' Else 'Inactivo' End as Estado2 FROM tbl_proveedor  WHERE nombre_proveedor LIKE '%" + nombre + "%';";
    SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
    return sqlBuscar;
}

public SqlDataAdapter insertarproveedores(string nombre, string nit,string direccion)
{
    try
    {  

        string sInsertarproveedor = "INSERT INTO tbl_proveedor(nombre_proveedor,nit_proveedor,direccion_proveedor,estado_proveedor  ) VALUES ( '" + nombre + "', '" + nit + "','" + direccion + "', '1' ) ";
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

                string sRecuperarmarca = "select PK_idmarca,nombre_marca,estado_marca,Case When estado_marca = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_marcas_vehiculo";
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
            string sBuscar = "select PK_idmarca,nombre_marca,estado_marca,Case When estado_marca = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_marcas_vehiculo WHERE nombre_marca LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarmarca(string nombre)
        {
            try
            {
              

                string sInsertarmarca = "INSERT INTO tbl_marcas_vehiculo (nombre_marca,estado_marca ) VALUES ( '" + nombre + "', '1' ) ";
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

                string sRecuperarpago = "SELECT PK_idTipopago,nombre_tipopago,estado_tipopago,Case When estado_tipopago = 1 then 'Activo' Else 'Inactivo' End as Estado2 FROM tbl_tipo_pago ";
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
            string sBuscar = "SELECT PK_idTipopago,nombre_tipopago,estado_tipopago,Case When estado_tipopago = 1 then 'Activo' Else 'Inactivo' End as Estado2 FROM tbl_tipo_pago  WHERE nombre_tipopago LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarpago(string nombre)
        {
            try
            {
               

                string sInsertarpago = "INSERT INTO tbl_tipo_pago (nombre_tipopago,estado_tipopago) VALUES ( '" + nombre + "', '1' ) ";
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
        ////////////////////////////Usuarios////////////////////////////////
        public SqlDataAdapter obtenerusuarios()
        {
            try
            {

                string sRecuperarusuarios = "select PK_idusuario,nombre_usuario,apellido_usuario,password_usuario,estado_usuario,Case When estado_usuario = 1 then 'Activo' Else 'Inactivo' End as Estado2 from tbl_usuarios";
                SqlDataAdapter sqlRecuperarusuarios = new SqlDataAdapter(sRecuperarusuarios, cn.conectar());
                sqlRecuperarusuarios.SelectCommand.Connection.Close();
                return sqlRecuperarusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de usuarios: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter buscarusuarios(string nombre)
        {
            string sBuscar = "select PK_idusuario,nombre_usuario,apellido_usuario,password_usuario,estado_usuario,Case When estado_usuario = 1 then 'Activo' Else 'Inactivo' End as Estado2  FROM tbl_usuarios WHERE nombre_usuario LIKE '%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter insertarusuarios(string nombre, string apellido, string password)
        {
            try
            {

                string sInsertarusuarios = "INSERT INTO tbl_usuarios(nombre_persona,nombre_usuario,password_usuario,estado_usuario  ) VALUES ( '" + nombre + "', '" + apellido + "','" + password + "', '1' ) ";
                SqlDataAdapter sqlInsertarusuarios = new SqlDataAdapter(sInsertarusuarios, cn.conectar());
                sqlInsertarusuarios.SelectCommand.Connection.Close();
                return sqlInsertarusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de usuarios en capa datos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter modificarusuarios(int id, string nombre, string apellido, string password, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_usuarios SET nombre_persona = '" + nombre + "', nombre_usuario = '" + apellido + "', password_usuario = '" + password + "', estado_usuario  = '" + estado + "' WHERE PK_idusuario = '" + id + "'";
                SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
                return sqlModificar;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la modificacion del usuario: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter eliminarusuarios(int id)
        {
            try
            {
                string sEliminar = "UPDATE tbl_usuarios SET estado_usuario  = '0' WHERE PK_idusuario = '" + id + "'";
                SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
                return sqlEliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la eliminacion del usuario en capa datos: " + ex.Message);
                return null;
            }
        }
        /*ALLAN LETONA*/

        public SqlDataAdapter getInventrio()
        {
            try
            {
                string sRecuperarInventario = "spc_obtiene_inventario";
                SqlDataAdapter sqlRecuperarInventario = new SqlDataAdapter(sRecuperarInventario, cn.conectar());
                sqlRecuperarInventario.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
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

        public SqlDataAdapter insertarFacturaEncabezado(int PK_factura, int PK_cliente, int PK_tipopago, string serie, string descuento, string fecha, double subtotal, double valor_descuento, double total, string comentario, string estado )
        {
            try
            {
                string sInsertarFactEnc = " INSERT INTO tbl_factura_encabezado(PK_idFactEnc, PK_idcliente, PK_idTipopago, serie_fact, desc_fact, fecha_fact, subtotal, descuento, total, comentario, estado_fact)" +
                    " VALUES('"+PK_factura+ "', '" + PK_cliente + "', '" + PK_tipopago + "', '" + serie + "', '" + descuento + "', '" + fecha + "', '" + subtotal + "', '"+ valor_descuento + "' ,'" + total + "', '" + comentario + "', '" + estado + "' ); ";
                SqlDataAdapter sqlInsertarFactEnc = new SqlDataAdapter(sInsertarFactEnc, cn.conectar());
                sqlInsertarFactEnc.SelectCommand.Connection.Close();
                return sqlInsertarFactEnc;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de factura encabezado: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter insertarFacturaDetalle(int PK_factura, int PK_repuesto, double precio, int cantidad)
        {
            try
            {
                string sInsertarFactDet = "  INSERT INTO tbl_factura_detalle(PK_idFactEnc, PK_idrepuesto, precio, cantidad) " +
                    "VALUES('"+PK_factura+ "', '" + PK_repuesto + "', '" + precio + "', '" + cantidad + "') ";
                SqlDataAdapter sqlInsertarFactDet = new SqlDataAdapter(sInsertarFactDet, cn.conectar());
                sqlInsertarFactDet.SelectCommand.Connection.Close();
                return sqlInsertarFactDet;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de factura detalle: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter insertarVentaEfectivo(int PK_factura, double saldo, string estado)
        {
            try
            {
                string sInsertarVentaEfectivo = "INSERT INTO tbl_venta_efectivo(PK_idFactEnc, saldo_pendiente, estado_ventaefectivo) " +
                    "VALUES('"+PK_factura+ "', '" + saldo + "', '" + estado + "' )";
                SqlDataAdapter sqlInsertarVentaEfectivo = new SqlDataAdapter(sInsertarVentaEfectivo, cn.conectar());
                sqlInsertarVentaEfectivo.SelectCommand.Connection.Close();
                return sqlInsertarVentaEfectivo;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de venta efectivo: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter insertarVentaCredito(int PK_factura, double saldo, string estado)
        {
            try
            {
                string sInsertarVentaCredito = "  INSERT INTO tbl_venta_credito(PK_idFactEnc, saldo_pendiente, estado_ventacredito) " +
                    "VALUES('"+ PK_factura + "','" + saldo + "', '" + estado + "')";
                SqlDataAdapter sqlInsertarVentaCredito = new SqlDataAdapter(sInsertarVentaCredito, cn.conectar());
                sqlInsertarVentaCredito.SelectCommand.Connection.Close();
                return sqlInsertarVentaCredito;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de venta credito: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter obtenerRepuestosParaFacturacion()
        {
            try
            {

                string sRecuperarRepuestos = "SELECT rep.PK_idrepuesto, rep.PK_idtiporepuesto ,rep.codigo_fabricante, rep.descripcion_repuesto, trep.descripcion_tiporepuesto, inv.existencias , rep.precio_factura, rep.facturar_sin_existencia, rep.precio_venta1, rep.precio_venta2, rep.precio_venta3, rep.precio_venta4 FROM tbl_tiporepuesto AS trep INNER JOIN tbl_repuestos AS rep WITH(NOLOCK) ON trep.PK_idtiporepuesto = rep.PK_idtiporepuesto INNER JOIN tbl_inventario AS inv WITH(NOLOCK) ON rep.PK_idrepuesto = inv.PK_idrepuesto ";
                SqlDataAdapter sqlRecuperarRepuestos = new SqlDataAdapter(sRecuperarRepuestos, cn.conectar());
                sqlRecuperarRepuestos.SelectCommand.Connection.Close();
                return sqlRecuperarRepuestos;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Repuestos para facturacion: " + ex.Message);
                return null;
            }
        }
         
        
        public SqlDataAdapter ordenescompra()
        {
            try
            {

                string sRecuperarRepuestos = "select * from tbl_compras_encabezado";
                SqlDataAdapter sqlRecuperarRepuestos = new SqlDataAdapter(sRecuperarRepuestos, cn.conectar());
                sqlRecuperarRepuestos.SelectCommand.Connection.Close();
                return sqlRecuperarRepuestos;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Repuestos para facturacion: " + ex.Message);
                return null;
            }
        }

        /*------------------------------------------------------------------------------------------------------------*/

        ///////////////insertar inventario////////////
        public SqlDataAdapter insertarinventario(int id_repuesto)
        {
            try
            {

                string sInsertarinventario = "INSERT INTO tbl_inventario( PK_idrepuesto,existencias ) VALUES ( '" + id_repuesto + "', '0' ) ";
                SqlDataAdapter sqlInsertarinventario = new SqlDataAdapter(sInsertarinventario, cn.conectar());
                sqlInsertarinventario.SelectCommand.Connection.Close();
                return sqlInsertarinventario;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de Inventario en capa datos: " + ex.Message);
                return null;
            }
        }
        public SqlDataAdapter buscarinventario(string id)
        {
            string sBuscar = "SELECT PK_idInventario,PK_idrepuesto,existencias FROM tbl_inventario WHERE PK_idrepuesto LIKE '%" + id + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }

        public SqlDataAdapter obtenerInv()
        {
            try
            {

                string sRecuperarInv = "select * from tbl_inventario";
                SqlDataAdapter sqlRecuperarInv = new SqlDataAdapter(sRecuperarInv, cn.conectar());
                sqlRecuperarInv.SelectCommand.Connection.Close();
                return sqlRecuperarInv;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Repuestos: " + ex.Message);
                return null;
            }
        }
        ///tipo de repuesto//
        public SqlDataAdapter obtenerTipoRepuesto()
        {
            try
            {

                string sRecuperarTipoRep = "SELECT PK_idtiporepuesto,descripcion_tiporepuesto,estado_tiporepuesto,Case When estado_tiporepuesto = 1 then 'Activo' Else 'Inactivo' End as Estado2 FROM tbl_tiporepuesto ";
                SqlDataAdapter sqlRecuperarTipoRep = new SqlDataAdapter(sRecuperarTipoRep, cn.conectar());
                sqlRecuperarTipoRep.SelectCommand.Connection.Close();
                return sqlRecuperarTipoRep;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de Tipos de Repuestos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter buscarTipoRe(string nombre)
        {
            string sBuscar = "SELECT PK_idtiporepuesto,descripcion_tiporepuesto,estado_tiporepuesto,Case When estado_tiporepuesto = 1 then 'Activo' Else 'Inactivo' End as Estado2 FROM tbl_tiporepuesto  WHERE descripcion_tiporepuesto LIKE'%" + nombre + "%';";
            SqlDataAdapter sqlBuscar = new SqlDataAdapter(sBuscar, cn.conectar());
            return sqlBuscar;
        }
        public SqlDataAdapter insertartiporepuesto(string nombre)
        {
            try
            {


                string sInsertartipore = "INSERT INTO tbl_tiporepuesto  (descripcion_tiporepuesto,estado_tiporepuesto ) VALUES ( '" + nombre + "', '1' ) ";
                SqlDataAdapter sqlInsertartipore = new SqlDataAdapter(sInsertartipore, cn.conectar());
                sqlInsertartipore.SelectCommand.Connection.Close();
                return sqlInsertartipore;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la insercion de tipo de repuesto en capa datos: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter modificartiporepuesto(int id, string nombre, string estado)
        {
            try
            {
                string sModificar = "UPDATE tbl_tiporepuesto SET descripcion_tiporepuesto = '" + nombre + "', estado_tiporepuesto  = '" + estado + "' WHERE PK_idtiporepuesto = '" + id + "'";
                SqlDataAdapter sqlModificar = new SqlDataAdapter(sModificar, cn.conectar());
                return sqlModificar;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la modificacion del tipo de repuesto: " + ex.Message);
                return null;
            }
        }

        public SqlDataAdapter eliminartiporepuesto(int id)
        {
            try
            {
                string sEliminar = "UPDATE tbl_tiporepuesto SET estado_tiporepuesto = '0' WHERE PK_idtiporepuesto = '" + id + "'";
                SqlDataAdapter sqlEliminar = new SqlDataAdapter(sEliminar, cn.conectar());
                return sqlEliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la eliminacion del tipo de repuesto: " + ex.Message);
                return null;
            }
        }

    }
}