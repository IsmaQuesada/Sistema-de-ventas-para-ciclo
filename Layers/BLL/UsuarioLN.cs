using appProyecto.Layers.Entidades.DTO;
using appProyecto.Layers.DAL;
using System;
using System.Collections.Generic;


namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos Usuario
    /// </summary>
    public class UsuarioLN
    {
        /// <summary>
        /// Método encargado de guardar el usuario en la BD, en caso de que no exista en está.
        /// Por otra parte, actualiza el usuario si existe en la BD
        /// </summary>
        /// <param name="usuario">Usuario que se desea guardar o actualizar en la base de datos</param>
        public void Guardar(Usuario usuario)
        {
            UsuarioDB datos = new UsuarioDB();
            if (UsuarioDB.SeleccionarPorId(usuario.Cedula) == null)
            {
                datos.Insertar(usuario);
            }
            else
            {
                datos.Actualizar(usuario);
            }
        }

        /// <summary>
        /// Método encargado de eliminar un usuario por su cédula en la base de datos
        /// </summary>
        /// <param name="cedula">Representa la cédula del usuario que se desea eliminar</param>
        public void Eliminar(string cedula)
        {
            UsuarioDB datos = new UsuarioDB();

            if (UsuarioDB.SeleccionarPorId(cedula) == null)
                throw new ApplicationException("El ususario no existe");

            datos.Eliminar(cedula);
        }

        /// <summary>
        /// Devuelve una lista de todos los usuarios almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todos los usuarios de la base de datos</returns>
        public static List<Usuario> ObtenerUsuarios()
        {
            return DAL.UsuarioDB.SeleccionarTodos();
        }

        /// <summary>
        /// Método encargado de obtener el usuario con la cédula indicada
        /// </summary>
        /// <param name="cedulaUsuario">Representa la cédula del usuario que se desea obtener</param>
        /// <returns>Retorna el usuario que se desea consultar en la base de datos</returns>
        public static Usuario ObtenerUsuarioPorCedula(string cedulaUsuario)
        {
            return DAL.UsuarioDB.SeleccionarPorId(cedulaUsuario);
        }

        /// <summary>
        /// Devuelve una lista de todos los usuarios tipo "Cliente" almacenados en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todos los clientes de la base de datos</returns>
        public static List<Usuario> ObtenerClientes()
        {
            return DAL.UsuarioDB.SeleccionarClientes();
        }
    }
}
