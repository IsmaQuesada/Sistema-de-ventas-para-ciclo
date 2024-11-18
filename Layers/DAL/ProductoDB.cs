using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using appProyecto.Layers.Entidades.DTO;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Producto en la base de datos
    /// </summary>
    public class ProductoDB
    {
        /// <summary>
        /// Método encargado de insertar un nuevo producto en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="producto">Representa el objeto producto a insertar</param>
        public void Insertar(Producto producto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_InsertarProducto";
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@IdTipoProducto", producto.IdTipoProducto);
                comando.Parameters.AddWithValue("@IdFabricanteProducto", producto.IdFabricanteProducto);
                comando.Parameters.AddWithValue("@Imagen", producto.ImagenProducto);
                comando.Parameters.AddWithValue("@Existencia", producto.Existencia);
                comando.Parameters.AddWithValue("@Precio", producto.PrecioColon);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método actualiza los datos de un producto en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="producto">Representa el objeto producto que se desea actualizar</param>
        public void Actualizar(Producto producto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ActualizarProducto";
                comando.Parameters.AddWithValue("@ID", producto.Id);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@IdTipoProducto", producto.IdTipoProducto);
                comando.Parameters.AddWithValue("@IdFabricanteProducto", producto.IdFabricanteProducto);
                comando.Parameters.AddWithValue("@Imagen", producto.ImagenProducto);
                comando.Parameters.AddWithValue("@Existencia", producto.Existencia);
                comando.Parameters.AddWithValue("@Precio", producto.PrecioColon);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza la existencia de un producto en la base de datos después de una venta, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="idProducto">Representa el id del producto que se desea actualizar su existencia</param>
        /// <param name="cantidadVendida">Representa la cantidad vendida de ese producto</param>
        public void ActualizarExistencia(int idProducto, int cantidadVendida)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ActualizarExistencia";
                comando.Parameters.AddWithValue("@Id", idProducto);
                comando.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Devuelve una lista de todos los Productos que estan en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos producto</returns>
        public static List<Producto> SeleccionarTodos()
        {
            List<Producto> lista = new List<Producto>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarProductos";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto producto = new Producto();
                    producto.Id = (int)dr["ID"];
                    producto.Descripcion = dr["Descripcion"].ToString();
                    producto.IdTipoProducto = (int)dr["ID_TipoProducto"];
                    producto.TipoProducto = TipoProductoDB.SeleccionarPorId(producto.IdTipoProducto);
                    producto.IdFabricanteProducto = (int)dr["ID_FabricanteProducto"];
                    producto.FabricanteProducto = FabricanteProductoDB.SeleccionarPorId(producto.IdFabricanteProducto);
                    producto.Existencia = (int)dr["Existencia"];
                    producto.ImagenProducto = (byte[])dr["Imagen_Producto"];
                    producto.PrecioColon = (decimal)dr["PrecioColon"];

                    lista.Add(producto);
                }
            }

            return lista;
        }

        /// <summary>
        /// Método que permite seleccionar un producto por su identificador único
        /// </summary>
        /// <param name="id">Identificador del producto a seleccionar</param>
        /// <returns>Retorna el producto buscado. Si no existe un producto con ese identificador, retorna null</returns>
        public static Producto SeleccionarPorId(long id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarProductoPorId";
                comando.Parameters.AddWithValue("@Id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto producto = new Producto();
                    producto.Id = (int)dr["ID"];
                    producto.Descripcion = dr["Descripcion"].ToString();
                    producto.IdTipoProducto = (int)dr["ID_TipoProducto"];
                    producto.TipoProducto = TipoProductoDB.SeleccionarPorId(producto.IdTipoProducto);
                    producto.IdFabricanteProducto = (int)dr["ID_FabricanteProducto"];
                    producto.FabricanteProducto = FabricanteProductoDB.SeleccionarPorId(producto.IdFabricanteProducto);
                    producto.Existencia = (int)dr["Existencia"];
                    producto.ImagenProducto = (byte[])dr["Imagen_Producto"];
                    producto.PrecioColon = (decimal)dr["PrecioColon"];

                    return producto;
                }
            }
            return null;
        }

        /// <summary>
        /// Elimina un producto de la base de datos, a partir de su identificador
        /// </summary>
        /// <param name="id">Representa el identificador del producto a eliminar</param>
        public void Eliminar(long id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_EliminarProducto";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método elimina una bicicleta de la base de datos a través de su id
        /// </summary>
        /// <param name="id">Representa el identificador de la bicicleta a eliminar</param>
        public void EliminarBicicleta(long id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_EliminarBicicletas";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método permite insertar un componente en un producto específico en la base de datos
        /// </summary>
        /// <param name="productoId">Representa el id del producto que se le desea agregar el componente</param>
        /// <param name="componenteId">Representa el id del componente que se desea agregar</param>
        public void InsertarComponente(long productoId, int componenteId)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_InsertarProducto_Componente";
                comando.Parameters.AddWithValue("@IdProducto", productoId);
                comando.Parameters.AddWithValue("@IdComponente", componenteId);

                db.ExecuteNonQuery(comando);

            }
        }

        /// <summary>
        /// Elimina la relación entre un producto y un componente especificados mediante sus ids
        /// </summary>
        /// <param name="productoId">Representa el id del producto que se le desea remover el componente</param>
        /// <param name="componenteId">Representa el id del componente que se desea remover</param>
        public void EliminarComponente(long productoId, int componenteId)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_EliminarProducto_Componente";
                comando.Parameters.AddWithValue("@IdProducto", productoId);
                comando.Parameters.AddWithValue("@IdComponente", componenteId);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// El objetivo de este método es obtener la información del producto y validar si existe la cantidad necesaria en inventario
        /// </summary>
        /// <param name="pId">Representa el id del producto que se esta solicitando</param>
        /// <param name="pCantidadSolicitada">Representa la cantidad que se esta solicitando de ese producto</param>
        /// <returns>Se evalúa si hay disponible la cantidad solicitada del producto, si no hay disponible lo suficiente se lanza una excepción.
        /// De lo contrario, si la cantidad solicitada está disponible en inventario, se retorna el objeto oProducto correspondiente al producto consultado.</returns>
        public Producto ObtenerExistencia(int pId, int pCantidadSolicitada)
        {
            Producto oProducto = SeleccionarPorId(pId);

            if (oProducto.Existencia == 0)
                throw new Exception("No hay dispoble stock de este producto");

            if (oProducto.Existencia < pCantidadSolicitada)
                throw new Exception($"No hay cantidad suficiente en inventario para el producto {oProducto.Id} {oProducto.Descripcion}, cantidad disponible: {oProducto.Existencia}");
            else
                return oProducto;
        }
    }
}
