using appProyecto.Layers.Entidades;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos de tipo FabricanteComponente
    /// </summary>
    public class FabricanteComponenteLN
    {
        /// <summary>
        /// Obtiene todos los fabricantes de componentes almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista de objetos FabricanteComponente</returns>
        public static List<FabricanteComponente> ObtenerFabricantes()
        {
            return DAL.FabricanteComponenteDB.SeleccionarTodas();
        }
    }
}
