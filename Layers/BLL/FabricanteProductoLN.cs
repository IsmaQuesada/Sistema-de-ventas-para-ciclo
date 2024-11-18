using appProyecto.Layers.Entidades;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos de tipo FabricanteProducto
    /// </summary>
    public class FabricanteProductoLN
    {
        /// <summary>
        /// Obtiene una lista de todos los fabricantes de productos
        /// </summary>
        /// <returns>Retorna una lista de objetos FabricanteProducto</returns>
        public static List<FabricanteProducto> ObtenerFabricantes()
        {
            return DAL.FabricanteProductoDB.SeleccionarTodas();
        }
    }
}
