using appProyecto.Layers.Entidades.DTO;
using appProyecto.Layers.DAL;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos producto
    /// </summary>
    public class ProductoLN
    {
        /// <summary>
        /// Método encargado de guardar el producto en la BD, en caso de que no exista en está.
        /// Por otra parte, actualiza el producto si existe en la BD
        /// </summary>
        /// <param name="producto">Producto que se desea guardar o actualizar en la base de datos</param>
        public void Guardar(Producto producto)
        {
            ProductoDB db = new ProductoDB();
            // Preguntar si el producto existe
            if (ProductoDB.SeleccionarPorId(producto.Id) == null)
            {
                db.Insertar(producto);
            }
            else
            {
                db.Actualizar(producto);
            }
        }

        /// <summary>
        /// Método encargado de eliminar un producto por su id en la base de datos
        /// </summary>
        /// <param name="id">Representa el id del producto que se desea eliminar</param>
        public void Eliminar(long id)
        {
            ProductoDB db = new ProductoDB();
            db.Eliminar(id);
        }

        /// <summary>
        /// Método encargado de eliminar un producto de tipo "Bicicleta" en la base de datos, esto por medio de su id
        /// </summary>
        /// <param name="id">Representa el id del Bicicleta que se desea eliminar</param>
        public void EliminarBicicleta(long id)
        {
            ProductoDB db = new ProductoDB();
            db.EliminarBicicleta(id);
        }

        /// <summary>
        /// Devuelve una lista de todos los productos almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todos los productos de la base de datos</returns>
        public static List<Producto> ObtenerTodos()
        {
            return ProductoDB.SeleccionarTodos();
        }

        /// <summary>
        /// Este método permite agregar un componente a un producto en la base de datos
        /// </summary>
        /// <param name="prodId">Representa el id del producto al que se desea agregar el componente</param>
        /// <param name="comId">Representa el id del componente que se desea agregar</param>
        public void AgregarComponente(long prodId, int comId)
        {
            var db = new ProductoDB();
            db.InsertarComponente(prodId, comId);
        }

        /// <summary>
        /// Este método actualiza la existencia de un producto en la base de datos, dado su id y la cantidad vendida en ese momento
        /// </summary>
        /// <param name="idProducto">Representa el id del producto al que se desea actualizar su existencia</param>
        /// <param name="cantidadVendida">Representa el la cantidad que se vendio de ese producto</param>
        public static void ActualizarExistencia(int idProducto, int cantidadVendida)
        {
            var db = new ProductoDB();
            db.ActualizarExistencia(idProducto, cantidadVendida);
        }

        /// <summary>
        /// Este método elimina un componente asociado a un producto específico en la base de datos
        /// </summary>
        /// <param name="prodId">Representa el id del producto al que se desea remover el componente señalado</param>
        /// <param name="compId">Representa el id del componente que se desea remover</param>
        public void RemoverComponente(long prodId, int compId)
        {
            var db = new ProductoDB();
            db.EliminarComponente(prodId, compId);
        }

        /// <summary>
        /// Este método verifica si existe la cantidad suficiente del producto en el inventario
        /// </summary>
        /// <param name="pId">Representa el id del producto que se desea comprar en ese momento</param>
        /// <param name="pCantidadSolicitada">Representa la cantidad solicitada de ese producto en la actual compra</param>
        /// <returns>Retorna el objeto Producto solicitado en ese momento. En caso contrario, devuelve null</returns>
        public static Producto ConfirmarExistencia(int pId, int pCantidadSolicitada)
        {
            var db = new ProductoDB();
            Producto oProducto = db.ObtenerExistencia(pId, pCantidadSolicitada);

            return oProducto;
        }
    }
}
