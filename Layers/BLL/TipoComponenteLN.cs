using appProyecto.Layers.Entidades;
using appProyecto.Layers.DAL;
using System;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos Tipo componente
    /// </summary>
    public class TipoComponenteLN
    {
        /// <summary>
        /// Método encargado de guardar el tipo componente en la BD, en caso de que no exista en está.
        /// Por otra parte, actualiza el tipo componente si existe en la BD
        /// </summary>
        /// <param name="tipo">Tipo componente que se desea guardar o actualizar en la base de datos</param>
        public void Guardar(TipoComponente tipo)
        {
            TipoComponenteDB datos = new TipoComponenteDB();
            if (TipoComponenteDB.SeleccionarPorId(tipo.Id) == null)
            {
                datos.Insertar(tipo);
            }
            else
            {
                datos.Actualizar(tipo);
            }
        }

        /// <summary>
        /// Método encargado de eliminar un tipo componente por su id en la base de datos
        /// </summary>
        /// <param name="id">Representa el id del tipo componente que se desea eliminar</param>
        public void Eliminar(int id)
        {
            TipoComponenteDB datos = new TipoComponenteDB();

            if (TipoComponenteDB.SeleccionarPorId(id) == null)
                throw new ApplicationException("El Tipo de componente no existe");

            datos.Eliminar(id);
        }

        /// <summary>
        /// Devuelve una lista de todos los tipo componente almacenados en la base de datos.
        /// </summary>
        /// <returns>Retorna una lista con todos los tipo componente de la base de datos</returns>
        public static List<TipoComponente> ObtenerTiposComponente()
        {
            return DAL.TipoComponenteDB.SeleccionarTodas();
        }
    }
}
