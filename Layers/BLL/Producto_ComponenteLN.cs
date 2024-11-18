using appProyecto.Layers.Entidades.DTO;
using appProyecto.Layers.DAL;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio de la relación M:M entre Producto y Componente
    /// </summary>
    public class Producto_ComponenteLN
    {
        /// <summary>
        /// Obtiene una lista de componentes de un producto dado por su id
        /// </summary>
        /// <param name="idProducto">id del producto</param>
        /// <returns>Retorna una lista de componentes que están asignados a ese producto</returns>
        public static List<Componente> ObtenerComponentes(int idProducto)
        {
            return Producto_ComponenteDB.SeleccionarComponentes_DelProducto(idProducto);
        }
    }
}
