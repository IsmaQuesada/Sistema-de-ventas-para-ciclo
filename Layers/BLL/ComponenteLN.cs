using appProyecto.Layers.Entidades.DTO;
using appProyecto.Layers.DAL;
using System.Collections.Generic;
using System.Linq;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos Componente
    /// </summary>
    public class ComponenteLN
    {
        /// <summary>
        /// Método encargado de guardar el componente en la BD, en caso de que no exista en está.
        /// Por otra parte, actualiza el componente si existe en la BD
        /// </summary>
        /// <param name="componente">Componente que se desea guardar o actualizar en la base de datos</param>
        public void Guardar(Componente componente)
        {
            ComponenteDB db = new ComponenteDB();
            // Preguntar si el producto existe
            if (ComponenteDB.SeleccionarPorId(componente.Id) == null)
            {
                db.Insertar(componente);
            }
            else
            {
                db.Actualizar(componente);
            }
        }

        /// <summary>
        /// Método encargado de eliminar un componente por su id en la base de datos
        /// </summary>
        /// <param name="id">Representa el id del componente que se desea eliminar</param>
        public void Eliminar(long id)
        {
            ComponenteDB db = new ComponenteDB();
            db.Eliminar(id);
        }

        /// <summary>
        /// Devuelve una lista de todos los componentes almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todos los componente de la base de datos</returns>
        public static List<Componente> ObtenerTodos()
        {
            return ComponenteDB.SeleccionarTodos();
        }

        /// <summary>
        /// Devuelve una lista de componentes disponibles para un producto específico.
        /// </summary>
        /// <param name="prodId">El Id del producto para el que se busca obtener los componentes disponibles</param>
        /// <returns>Retorna lista que contiene todos los componentes que estan disponibles para ese producto</returns>
        public static List<Componente> ObtenerDisponiblesPorProducto(long prodId)
        {
            var todos = ObtenerTodos(); 

            var seleccionados = ObtenerPorIdProducto(prodId); 

            var disponible = new List<Componente>();

            foreach (var p in todos)
            {
                var existe = seleccionados.FirstOrDefault(x => x.Id == p.Id);
                if (existe == null)
                {
                    disponible.Add(p);
                }
            }
            return disponible;
        }

        /// <summary>
        /// Obtiene una lista de componentes asociados a un producto específico
        /// </summary>
        /// <param name="prodId">Representa el Id del producto</param>
        /// <returns>Una lista de objetos Componente asociados al producto especificado</returns>
        public static List<Componente> ObtenerPorIdProducto(long prodId)
        {
            var db = new ComponenteDB();
            return db.SeleccionarPorProducto(prodId);
        }
    }
}
