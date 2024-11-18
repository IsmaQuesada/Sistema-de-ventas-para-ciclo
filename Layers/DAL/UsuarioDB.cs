using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using appProyecto.Layers.Entidades.DTO;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Usuario en la base de datos
    /// </summary>
    public class UsuarioDB
    {
        /// <summary>
        /// Método encargado de insertar un nuevo usuario en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="user">Representa el objeto usuario a insertar</param>
        public void Insertar(Usuario user)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_InsertarUsuario";
                comando.Parameters.AddWithValue("@NombreCompleto", user.NombreCompleto);
                comando.Parameters.AddWithValue("@Cedula", user.Cedula);
                comando.Parameters.AddWithValue("@Correo", user.Correo);
                comando.Parameters.AddWithValue("@IdTipoUsuario", user.IdTipoUsuario);
                comando.Parameters.AddWithValue("@Contrasennia", user.Contrasennia);
                comando.Parameters.AddWithValue("@Fotografia", user.Fotografia);
                comando.Parameters.AddWithValue("@FechaNacimiento", user.FechaNacimiento);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método actualiza los datos de un usuario en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="user">Representa el objeto usuario que se desea actualizar</param>
        public void Actualizar(Usuario user)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ActualizarUsuario";
                comando.Parameters.AddWithValue("@Cedula", user.Cedula);
                comando.Parameters.AddWithValue("@NombreCompleto", user.NombreCompleto);
                comando.Parameters.AddWithValue("@Correo", user.Correo);
                comando.Parameters.AddWithValue("@IdTipoUsuario", user.IdTipoUsuario);
                comando.Parameters.AddWithValue("@Contrasennia", user.Contrasennia);
                comando.Parameters.AddWithValue("@FechaNacimiento", user.FechaNacimiento);
                comando.Parameters.AddWithValue("@Fotografia", user.Fotografia);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Elimina un usuario de la base de datos, a partir de su cédula
        /// </summary>
        /// <param name="Cedula">Representa la cédula del usuario a eliminar</param>
        public void Eliminar(string Cedula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_EliminarUsuario";
                comando.Parameters.AddWithValue("@Cedula", Cedula);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Devuelve una lista de todos los usuarios que estan en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos usuario</returns>
        public static List<Usuario> SeleccionarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarUsuarios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Cedula = dr["Cedula"].ToString();
                    usuario.NombreCompleto = dr["NombreCompleto"].ToString();
                    usuario.Correo = dr["Correo"].ToString();
                    usuario.IdTipoUsuario = (int)dr["ID_TipoUsuario"];
                    usuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(usuario.IdTipoUsuario);
                    usuario.Contrasennia = dr["Contrasennia"].ToString();
                    usuario.Fotografia = (byte[])dr["Fotografia"];
                    usuario.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());

                    lista.Add(usuario);
                }
            }

            return lista;
        }

        /// <summary>
        /// Devuelve una lista de todos los usuarios de tipo "Cliente" que estan en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos usuario</returns>
        public static List<Usuario> SeleccionarClientes()
        {
            List<Usuario> lista = new List<Usuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarClientes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Cedula = dr["Cedula"].ToString();
                    usuario.NombreCompleto = dr["NombreCompleto"].ToString();
                    usuario.Correo = dr["Correo"].ToString();
                    usuario.IdTipoUsuario = (int)dr["ID_TipoUsuario"];
                    usuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(usuario.IdTipoUsuario);
                    usuario.Contrasennia = dr["Contrasennia"].ToString();
                    usuario.Fotografia = (byte[])dr["Fotografia"];
                    usuario.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());

                    lista.Add(usuario);
                }
            }

            return lista;
        }

        /// <summary>
        /// Método que permite seleccionar un usuario por su cédula
        /// </summary>
        /// <param name="cedula">Cédula del usuario a seleccionar</param>
        /// <returns>Retorna el usuario buscado. Si no existe un usuario con esa cédula, retorna null</returns>
        public static Usuario SeleccionarPorId(string cedula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarUsuarioPorId";
                comando.Parameters.AddWithValue("@Cedula", cedula);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Cedula = reader["Cedula"].ToString();
                    usuario.NombreCompleto = reader["NombreCompleto"].ToString();
                    usuario.Correo = reader["Correo"].ToString();
                    usuario.IdTipoUsuario = (int)reader["ID_TipoUsuario"];
                    usuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(usuario.IdTipoUsuario);
                    usuario.Contrasennia = reader["Contrasennia"].ToString();
                    usuario.Fotografia = (byte[])reader["Fotografia"];
                    usuario.FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString());

                    return usuario;
                }
            }

            return null;
        }
    }
}
