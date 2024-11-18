using appProyecto.Layers.Entidades;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos Tipo Usuario
    /// </summary>
    public class TipoUsuarioLN
    {
        /// <summary>
        /// Devuelve una lista de todos los tipo usuario almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todos los tipo usuario de la base de datos</returns>
        public static List<TipoUsuario> ObtenerTipoUsuarios()
        {
            return DAL.TipoUsuarioDB.SeleccionarTodos();
        }
    }
}
