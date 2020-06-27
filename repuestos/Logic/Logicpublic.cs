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
        
        public DataTable logicaInsertarRepuestos(string nombre, string descripcion, string precio_unitario)
        {
            SqlDataAdapter sqlInsertar =dal_datos.insertarRepuestos(nombre, descripcion, precio_unitario);
            DataTable dtInsertar = new DataTable();
            sqlInsertar.Fill(dtInsertar);
            return dtInsertar;
        }


        public DataTable logicaModificarRepuestos(int id, string nombre, string descripcion, string precio_unitario, string estado)
        {
            SqlDataAdapter sqlModificar = dal_datos.modificarRepuestos(id, nombre, descripcion, precio_unitario, estado);
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
    }
}

