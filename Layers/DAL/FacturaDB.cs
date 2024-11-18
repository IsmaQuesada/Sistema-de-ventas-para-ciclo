using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using appProyecto.Layers.Entidades.DTO;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Factura y DetalleFactura en la base de datos
    /// </summary>
    class FacturaDB
    {
        /// <summary>
        /// Obtiene el siguiente número de factura a ser utilizado en el sistema, en caso de que el número de factura sea cero, se retornara un 1. 
        /// Todo esto por medio de un procedimiento almacenado 
        /// </summary>
        /// <returns>Retorna el número de factura siguiente a ser utilizado</returns>
        public int ObtenerSiguienteNumeroFactura()
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ObtenerSiguienteNumeroFactura";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Factura factura = new Factura();
                    factura.Id = (int)dr["ID"];

                    return factura.Id;
                }
            }
            return 1;
        }

        /// <summary>
        /// Método encargado de insertar una nueva factura en la base de datos.
        /// Además, también se inserta a la base de datos los detalles de esta factura, todo esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="pFactura">Representa el objeto factura a insertar</param>
        /// <returns>Retorna el objeto factura que se inserto en la base de datos</returns>
        public static Factura InsertarFactura(Factura pFactura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comandoFactura = new SqlCommand();
                comandoFactura.CommandType = System.Data.CommandType.StoredProcedure;
                comandoFactura.CommandText = "SP_InsertarFactura";
                comandoFactura.Parameters.AddWithValue("@Id", pFactura.Id);
                comandoFactura.Parameters.AddWithValue("@Cedula", pFactura.CedulaCliente);
                comandoFactura.Parameters.AddWithValue("@TotalColones", pFactura.TotalColones);
                comandoFactura.Parameters.AddWithValue("@TotalDolares", pFactura.TotalDolares);
                comandoFactura.Parameters.AddWithValue("@FechaFacturacion", pFactura.FechaFacturacion);

                db.ExecuteNonQuery(comandoFactura);
            }

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                foreach (DetalleFactura detalleFactura in pFactura._ListaFacturaDetalle)
                {
                    SqlCommand comandoDetalleFactura = new SqlCommand();
                    comandoDetalleFactura.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoDetalleFactura.CommandText = "SP_InsertarDetalleFactura";
                    comandoDetalleFactura.Parameters.AddWithValue("@Id", detalleFactura.Id);
                    comandoDetalleFactura.Parameters.AddWithValue("@IdFactura", detalleFactura.IdFactura);
                    comandoDetalleFactura.Parameters.AddWithValue("@IdProducto", detalleFactura.IdProducto);
                    comandoDetalleFactura.Parameters.AddWithValue("@SubTotalColones", detalleFactura.SubTotalColones);
                    comandoDetalleFactura.Parameters.AddWithValue("@SubTotalDolares", detalleFactura.SubTotalDolares);
                    comandoDetalleFactura.Parameters.AddWithValue("@Cantidad", detalleFactura.Cantidad);
                    comandoDetalleFactura.Parameters.AddWithValue("@ImpuestoColones", detalleFactura.ImpuestoColones);
                    comandoDetalleFactura.Parameters.AddWithValue("@ImpuestoDolares", detalleFactura.ImpuestoDolares);

                    db.ExecuteNonQuery(comandoDetalleFactura);
                }
            }

            return ObtenerFacturaPorId(pFactura.Id);
        }

        /// <summary>
        /// Obtiene una lista de productos comprados en una factura especifica, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="idFactura">Representa el id de la factura de la cual se desea obtener los productos</param>
        /// <returns>Retorna una lista de objetos Producto que fueron comprados en la factura especifica</returns>
        public static List<Producto> ObtenerProductosPorIdFactura(int idFactura)
        {
            List<Producto> listaProductos = new List<Producto>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ObtenerProductosComprados";
                comando.Parameters.AddWithValue("@IdFactura", idFactura);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto oProducto = new Producto();
                    oProducto.Id = int.Parse(dr["ID"].ToString());
                    oProducto.Descripcion = dr["Descripcion"].ToString();
                    oProducto.IdTipoProducto = int.Parse(dr["ID_TipoProducto"].ToString());
                    oProducto.TipoProducto = TipoProductoDB.SeleccionarPorId(oProducto.IdTipoProducto);
                    oProducto.IdFabricanteProducto = int.Parse(dr["ID_FabricanteProducto"].ToString());
                    oProducto.FabricanteProducto = FabricanteProductoDB.SeleccionarPorId(oProducto.IdFabricanteProducto);
                    oProducto.ImagenProducto = (byte[])dr["Imagen_Producto"];
                    oProducto.Existencia = int.Parse(dr["Existencia"].ToString());
                    oProducto.PrecioColon = decimal.Parse(dr["PrecioColon"].ToString());

                    listaProductos.Add(oProducto);
                }
            }
            return listaProductos;
        }

        /// <summary>
        /// Selecciona de la base de datos la factura indicada. Además, selecciona los detalles de la factura
        /// y los agrega a la lista "_ListaFacturaDetalle" dentro del objeto Factura. Todos esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="idFactura">Representa el id del objeto factura que se desea consultar</param>
        /// <returns>Retorna el objeto factura que se consulto, en caso de no encontrarlo se retorna "null"</returns>
        public static Factura ObtenerFacturaPorId(int idFactura)
        {
            Factura oFactura = null;

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ObtenerFacturaPorId";
                comando.Parameters.AddWithValue("@IdFactura", idFactura);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    oFactura = new Factura();
                    oFactura.CedulaCliente = reader["Cedula_Usuario"].ToString();
                    oFactura.FechaFacturacion = DateTime.Parse(reader["FechaFacturacion"].ToString());
                    oFactura.TotalColones = decimal.Parse(reader["TotalColones"].ToString());
                    oFactura.TotalDolares = decimal.Parse(reader["TotalDolares"].ToString());
                    oFactura.Id = int.Parse(reader["ID"].ToString());
                }
            }

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ObtenerDetalleFacturaPorIdFactura";
                comando.Parameters.AddWithValue("@IdFactura", idFactura);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DetalleFactura detalleFactura = new DetalleFactura();
                    detalleFactura.IdProducto = int.Parse(dr["ID_Producto"].ToString());
                    detalleFactura.Producto = ProductoDB.SeleccionarPorId(detalleFactura.IdProducto);
                    detalleFactura.Cantidad = int.Parse(dr["Cantidad"].ToString());
                    detalleFactura.SubTotalColones = decimal.Parse(dr["SubTotalColones"].ToString());
                    detalleFactura.SubTotalDolares = decimal.Parse(dr["SubTotalDolares"].ToString());
                    detalleFactura.IdFactura = int.Parse(dr["ID_Factura"].ToString());
                    detalleFactura.ImpuestoColones = decimal.Parse(dr["ImpuestoColones"].ToString());
                    detalleFactura.ImpuestoDolares = decimal.Parse(dr["ImpuestoDolares"].ToString());
                    detalleFactura.Id = int.Parse(dr["ID"].ToString());
                    oFactura.AddDetalle(detalleFactura);
                }
            }
            return oFactura;
        }
    }
}

