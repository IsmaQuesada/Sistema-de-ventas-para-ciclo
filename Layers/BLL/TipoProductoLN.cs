using appProyecto.Layers.Entidades;
using appProyecto.Layers.DAL;
using System;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos tipo producto
    /// </summary>
    public class TipoProductoLN
    {
        /// <summary>
        /// Método encargado de guardar el tipo producto en la BD, en caso de que no exista en está.
        /// Por otra parte, actualiza el tipo producto si existe en la BD
        /// </summary>
        /// <param name="tipo">Tipo producto que se desea guardar o actualizar en la base de datos</param>
        public void Guardar(TipoProducto tipo)
        {
            TipoProductoDB datos = new TipoProductoDB();
            if (TipoProductoDB.SeleccionarPorId(tipo.Id) == null)
            {
                datos.Insertar(tipo);
            }
            else
            {
                datos.Actualizar(tipo);
            }
        }

        /// <summary>
        /// Método encargado de eliminar un tipo producto por su id en la base de datos
        /// </summary>
        /// <param name="id">Representa el id del tipo producto que se desea eliminar</param>
        public void Eliminar(int id)
        {
            TipoProductoDB datos = new TipoProductoDB();

            if (TipoProductoDB.SeleccionarPorId(id) == null)
                throw new ApplicationException("El Tipo de producto no existe");

            datos.Eliminar(id);
        }

        /// <summary>
        /// Devuelve una lista de todos los tipo producto almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todos los productos de la base de datos</returns>
        public static List<TipoProducto> ObtenerTipoProductos()
        {
            return DAL.TipoProductoDB.SeleccionarTodas();
        }
    }
}
