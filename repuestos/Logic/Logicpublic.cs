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
    public class Logicpublic
    {
        DALpublic dal_datos = new DALpublic();
        public DataTable logic_ObtenerRepuestos()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerProductos();
                DataTable dtobtenerProductos = new DataTable();
                sqlObtener.Fill(dtobtenerProductos);
                return dtobtenerProductos;

            }catch(Exception ex)
            {
                Console.WriteLine("Error en la obtencion de repuestos, capa logica: " + ex.Message);
                return null;
            }

    }

        public DataTable logicaBuscarRepuestos(string nombre)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarRepuestos(nombre);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }

       

        public DataTable logicaInsertarRepuestos(int id_repuesto, string id_tipo_repuesto,string cod_fabricante, string descripcion,string costo_repuesto1,string costo_repuesto2,string costo_repuesto3,string costo_repuesto4,string precio_venta1,string precio_venta2,string precio_venta3,string precio_venta4, int cantidad,string facturar_sin_existencia,int precio_factura)
        {
            SqlDataAdapter sqlInsertar =dal_datos.insertarRepuestos(id_repuesto,id_tipo_repuesto,cod_fabricante, descripcion,costo_repuesto1,costo_repuesto2,costo_repuesto3,costo_repuesto4,precio_venta1,precio_venta2,precio_venta3,precio_venta4,cantidad,facturar_sin_existencia,precio_factura);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarRepuestos(int id, string id_tipo_repuesto, string cod_fabricante, string descripcion, string costo_repuesto1, string costo_repuesto2, string costo_repuesto3, string costo_repuesto4, string precio_venta1, string precio_venta2, string precio_venta3, string precio_venta4, int cantidad, string facturar_sin_existencia,int precio_factura, string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificarRepuestos(id, id_tipo_repuesto, cod_fabricante, descripcion, costo_repuesto1, costo_repuesto2, costo_repuesto3, costo_repuesto4, precio_venta1, precio_venta2, precio_venta3, precio_venta4, cantidad, facturar_sin_existencia,precio_factura, estado);
            DataTable dtModificar = new DataTable();
            sqlModificar.Fill(dtModificar);
            return dtModificar;
        }

        public DataTable logicaEliminarRepuestos(int id)
        {
            SqlDataAdapter sqlEliminar = dal_datos.eliminarRepuestos(id);
            DataTable dtEliminar = new DataTable();
            sqlEliminar.Fill(dtEliminar);
            return dtEliminar;
        }
        ///////////////////////////////////Clientes/////////////////////////
        public DataTable logic_Obtenerclientes()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerclientes();
        DataTable dtobtenerclientes = new DataTable();
        sqlObtener.Fill(dtobtenerclientes);
                return dtobtenerclientes;

            }catch(Exception ex)
            {
                Console.WriteLine("Error en la obtencion de proveedores, capa logica: " + ex.Message);
                return null;
            }

    }

        public DataTable logicaBuscarclientes(string nombre)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarclientes(nombre);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }

        public DataTable logicaBuscarnit(string nit)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarnit(nit);
            DataTable dtBuscar2 = new DataTable();
            sqlBuscar.Fill(dtBuscar2);
            return dtBuscar2;
        }

        public DataTable logicaInsertarclientes(string nombre, string nit)
        {
            SqlDataAdapter sqlInsertar = dal_datos.insertarclientes(nombre, nit);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarclientes(int id, string nombre, string nit,string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificarclientes(id, nombre, nit, estado);
            DataTable dtModificar = new DataTable();
            sqlModificar.Fill(dtModificar);
            return dtModificar;
        }

        public DataTable logicaEliminarclientes(int id)
        {
            SqlDataAdapter sqlEliminar = dal_datos.eliminarclientes(id);
            DataTable dtEliminar = new DataTable();
            sqlEliminar.Fill(dtEliminar);
            return dtEliminar;
        }
        /////////////////////////////////Proveedores//////////////////////////////////
        public DataTable logic_Obtenerproveedores()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerproveedores();
        DataTable dtobtenerproveedores = new DataTable();
        sqlObtener.Fill(dtobtenerproveedores);
                return dtobtenerproveedores;

            }catch(Exception ex)
            {
                Console.WriteLine("Error en la obtencion de proveedores, capa logica: " + ex.Message);
                return null;
            }

    }

        //   Diego Gomez
        public DataTable logic_ObtenerPreoveedores()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.ObtenerPreoveedores();
                DataTable dtobtenertipoRep = new DataTable();
                sqlObtener.Fill(dtobtenertipoRep);
                return dtobtenertipoRep;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logic_ObtenerPrductosOC()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.ObtenerPrductosOC();
                DataTable dtobtenertipoRep = new DataTable();
                sqlObtener.Fill(dtobtenertipoRep);
                return dtobtenertipoRep;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logicaconsultadatos(string valor)
        {
            try
            {

                SqlDataAdapter sqlInsertar = dal_datos.logicaconsultadatos(valor);
                DataTable dtInsertar = new DataTable();
                sqlInsertar.Fill(dtInsertar);
                return dtInsertar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }


        public DataTable productosoc(string valor)
        {
            try
            {

                SqlDataAdapter sqlInsertar = dal_datos.productosoc(valor);
                DataTable dtInsertar = new DataTable();
                sqlInsertar.Fill(dtInsertar);
                return dtInsertar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable ocEncabezadoProve(string nombre)
        {
            try
            {

                SqlDataAdapter sqlInsertar = dal_datos.ocEncabezadoProve(nombre);
                DataTable dtInsertar = new DataTable();
                sqlInsertar.Fill(dtInsertar);
                return dtInsertar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }
        
        public DataTable ocEncabezado(string total,string fecha, string id)
        {
            try
            {

                SqlDataAdapter sqlInsertar = dal_datos.ocEncabezado(total,fecha,id);
                DataTable dtInsertar = new DataTable();
                sqlInsertar.Fill(dtInsertar);
                return dtInsertar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }
        // ----------------------------------------------------------------------------------------------------------------------------------------

        public DataTable logicaBuscarproveedores(string nombre)
{
    SqlDataAdapter sqlBuscar = dal_datos.buscarproveedores(nombre);
    DataTable dtBuscar = new DataTable();
    sqlBuscar.Fill(dtBuscar);
    return dtBuscar;
}

public DataTable logicaInsertarproveedores(string nombre, string nit,string direccion)
{
    SqlDataAdapter sqlInsertar = dal_datos.insertarproveedores(nombre, nit,direccion);
    DataTable dtInsertar = new DataTable();
    sqlInsertar.Fill(dtInsertar);
    return dtInsertar;
}


public DataTable logicaModificarproveedores(int id, string nombre, string nit, string direccion,string estado)
{
    SqlDataAdapter sqlModificar = dal_datos.modificarproveedores(id, nombre, nit,direccion, estado);
    DataTable dtModificar = new DataTable();
    sqlModificar.Fill(dtModificar);
    return dtModificar;
}

public DataTable logicaEliminarproveedores(int id)
{
    SqlDataAdapter sqlEliminar = dal_datos.eliminarproveedores(id);
    DataTable dtEliminar = new DataTable();
    sqlEliminar.Fill(dtEliminar);
    return dtEliminar;
}

        ///////marca///
        public DataTable logic_Obtenermarca()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenermarca();
                DataTable dtobtenermarca = new DataTable();
                sqlObtener.Fill(dtobtenermarca);
                return dtobtenermarca;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de marca, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logicaBuscarmarca(string nombre)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarmarca(nombre);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }

        public DataTable logicaInsertarmarca(string nombre)
        {
            SqlDataAdapter sqlInsertar = dal_datos.insertarmarca(nombre);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarmarca(int id, string nombre, string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificarmarca(id, nombre, estado);
            DataTable dtModificar = new DataTable();
            sqlModificar.Fill(dtModificar);
            return dtModificar;
        }

        public DataTable logicaEliminarmarca(int id)
        {
            SqlDataAdapter sqlEliminar = dal_datos.eliminarmarca(id);
            DataTable dtEliminar = new DataTable();
            sqlEliminar.Fill(dtEliminar);
            return dtEliminar;
        }


        /////////tipo_pago///////////
        public DataTable logic_Obtenerpago()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerpago();
                DataTable dtobtenerpago = new DataTable();
                sqlObtener.Fill(dtobtenerpago);
                return dtobtenerpago;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de pago, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logicaBuscarpago(string nombre)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarpago(nombre);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }

        public DataTable logicaInsertarpago(string nombre)
        {
            SqlDataAdapter sqlInsertar = dal_datos.insertarpago(nombre);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarpago(int id, string nombre, string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificarpago(id, nombre, estado);
            DataTable dtModificar = new DataTable();
            sqlModificar.Fill(dtModificar);
            return dtModificar;
        }

        public DataTable logicaEliminarpago(int id)
        {
            SqlDataAdapter sqlEliminar = dal_datos.eliminarpago(id);
            DataTable dtEliminar = new DataTable();
            sqlEliminar.Fill(dtEliminar);
            return dtEliminar;
        }

        ///Usuarios///////
        public DataTable logic_Obtenerusuarios()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerusuarios();
                DataTable dtobtenerusuarios = new DataTable();
                sqlObtener.Fill(dtobtenerusuarios);
                return dtobtenerusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de usuarios, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logicaBuscarusuarios(string nombre)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarusuarios(nombre);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }

        public DataTable logicaInsertarusuarios(string nombre, string apellido, string password)
        {
            SqlDataAdapter sqlInsertar = dal_datos.insertarusuarios(nombre,apellido, password);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarusuarios(int id, string nombre, string apellido, string password, string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificarusuarios(id, nombre, apellido, password, estado);
            DataTable dtModificar = new DataTable();
            sqlModificar.Fill(dtModificar);
            return dtModificar;
        }

        public DataTable logicaEliminarusuarios(int id)
        {
            SqlDataAdapter sqlEliminar = dal_datos.eliminarusuarios(id);
            DataTable dtEliminar = new DataTable();
            sqlEliminar.Fill(dtEliminar);
            return dtEliminar;
        }
        /*ALLAN LETONA*/

        public DataTable logicaGetInventario()
        {
            try
            {
                SqlDataAdapter sqlGetInventario = dal_datos.getInventrio();
                DataTable dtInventario = new DataTable();
                sqlGetInventario.Fill(dtInventario);
                return dtInventario;
            }catch(Exception ex)
            {
                Console.WriteLine("Error en capa logica obtencion de inventario: " + ex.Message);
                return null;
            }
        }

        public DataTable logicaGetProductoKardex(int iCodigoproducto)
        {
            try
            {
                SqlDataAdapter sqlGetKardex = dal_datos.getProductoKardex(iCodigoproducto);
                DataTable dtKardex = new DataTable();
                sqlGetKardex.Fill(dtKardex);
                return dtKardex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica obtencion de producto Kardex: " + ex.Message);
                return null;
            }
        }
        public DataTable logicaGetVentasKardex(int iCodigoproducto, string fechaInicio, string fechaFin)
        {
            try
            {
                SqlDataAdapter sqlGetKardex = dal_datos.getVentasKardex(iCodigoproducto, fechaInicio, fechaFin);
                DataTable dtKardex = new DataTable();
                sqlGetKardex.Fill(dtKardex);
                return dtKardex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica obtencion de ventas Kardex: " + ex.Message);
                return null;
            }
        }
        public DataTable logicaGetComprasKardex(int iCodigoproducto, string fechaInicio, string fechaFin)
        {
            try
            {
                SqlDataAdapter sqlGetKardex = dal_datos.getComprasKardex(iCodigoproducto, fechaInicio, fechaFin);
                DataTable dtKardex = new DataTable();
                sqlGetKardex.Fill(dtKardex);
                return dtKardex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica obtencion de compras Kardex: " + ex.Message);
                return null;
            }
        }

        public DataTable logicaInsertarFactEnc(int PK_factura, int PK_cliente, int PK_tipopago, string serie, string descuento, string fecha, double subtotal, double valor_descuento, double total, string comentario, string estado)
        {
            try
            {
                SqlDataAdapter sqlInsertFactEnc = dal_datos.insertarFacturaEncabezado(PK_factura, PK_cliente, PK_tipopago, serie, descuento, fecha, subtotal, valor_descuento , total, comentario, estado);
                DataTable dtFacEnc = new DataTable();
                sqlInsertFactEnc.Fill(dtFacEnc);
                return dtFacEnc;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica insercion de factura encabezado: " + ex.Message);
                return null;
            }
        }

        public DataTable logicaInsertarFactDet(int PK_factura, int PK_repuesto, double precio, int cantidad)
        {
            try
            {
                SqlDataAdapter sqlInsertFacDet = dal_datos.insertarFacturaDetalle(PK_factura, PK_repuesto, precio, cantidad);
                DataTable dtFacDet = new DataTable();
                sqlInsertFacDet.Fill(dtFacDet);
                return dtFacDet;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica insercion factura detalle: " + ex.Message);
                return null;
            }
        }

        public DataTable logicaInsertarVentaEfectivo(int PK_factura, double saldo, string estado)
        {
            try
            {
                SqlDataAdapter sqlInsertFacDet = dal_datos.insertarVentaEfectivo(PK_factura, saldo, estado);
                DataTable dtFacDet = new DataTable();
                sqlInsertFacDet.Fill(dtFacDet);
                return dtFacDet;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica insercion venta efectivo: " + ex.Message);
                return null;
            }
        }

        public DataTable logicaInsertarVentaCredito(int PK_factura, double saldo, string estado)
        {
            try
            {
                SqlDataAdapter sqlInsertFacDet = dal_datos.insertarVentaCredito(PK_factura, saldo, estado);
                DataTable dtFacDet = new DataTable();
                sqlInsertFacDet.Fill(dtFacDet);
                return dtFacDet;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa logica insercion venta credito: " + ex.Message);
                return null;
            }
        }

        public DataTable logic_obtenerRepuestosVentas()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerRepuestosParaFacturacion();
                DataTable dtobtenerProductos = new DataTable();
                sqlObtener.Fill(dtobtenerProductos);
                return dtobtenerProductos;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de repuestos para facturacion, capa logica: " + ex.Message);
                return null;
            }

        }


        ////////////////insertar inventario////   
        public DataTable logicaInsertarinventario(int id_repuesto)
        {
            SqlDataAdapter sqlInsertar = dal_datos.insertarinventario(id_repuesto);
            DataTable dtInsertarI = new DataTable();
            sqlInsertar.Fill(dtInsertarI);
            return dtInsertarI;
        }
        public DataTable logic_ObtenerInv()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerInv();
                DataTable dtobtenerProductos = new DataTable();
                sqlObtener.Fill(dtobtenerProductos);
                return dtobtenerProductos;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de inventario, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logicaBuscarInventario(string id)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarinventario(id);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }
        ////////Tipo de Repuesto////
        public DataTable logic_Obtenertiporep()
        {
            try
            {

                SqlDataAdapter sqlObtener = dal_datos.obtenerTipoRepuesto();
                DataTable dtobtenertipoRep = new DataTable();
                sqlObtener.Fill(dtobtenertipoRep);
                return dtobtenertipoRep;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de tipo de repuesto, capa logica: " + ex.Message);
                return null;
            }

        }

        public DataTable logicaBuscarTipoRe(string nombre)
        {
            SqlDataAdapter sqlBuscar = dal_datos.buscarTipoRe(nombre);
            DataTable dtBuscar = new DataTable();
            sqlBuscar.Fill(dtBuscar);
            return dtBuscar;
        }
        public DataTable logicaInsertarTipoRe(string nombre)
        {
            SqlDataAdapter sqlInsertar = dal_datos.insertartiporepuesto(nombre);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarTipoRe(int id, string nombre, string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificartiporepuesto(id, nombre, estado);
            DataTable dtModificar = new DataTable();
            sqlModificar.Fill(dtModificar);
            return dtModificar;
        }

        public DataTable logicaEliminarTipoRe(int id)
        {
            SqlDataAdapter sqlEliminar = dal_datos.eliminartiporepuesto(id);
            DataTable dtEliminar = new DataTable();
            sqlEliminar.Fill(dtEliminar);
            return dtEliminar;
        }


    }
}
