using appProyecto.Layers.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Tipo_Usuario en la base de datos
    /// </summary>
    public class TipoUsuarioDB
    {
        /// <summary>
        /// Devuelve una lista de todos los tipo de usuario que estan en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos tipo usuario</returns>
        public static List<TipoUsuario> SeleccionarTodos()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarTipoUsuarios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoUsuario tipo = new TipoUsuario();
                    tipo.Id = (int)dr["Id"];
                    tipo.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(tipo);
                }
            }

            return lista;
        }

        /// <summary>
        /// Método que permite seleccionar un tipo de usuario por su identificador único
        /// </summary>
        /// <param name="id">Identificador del tipo de usuario a seleccionar</param>
        /// <returns>Retorna el tipo de usuario buscado. Si no existe un tipo de usuario con ese identificador, retorna null</returns>
        public static TipoUsuario SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarTipoUsuarioPorId";
                comando.Parameters.AddWithValue("@id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoUsuario tipo = new TipoUsuario();
                    tipo.Id = (int)reader["Id"];
                    tipo.Descripcion = reader["Descripcion"].ToString();

                    return tipo;
                }
            }

            return null;
        }
    }
}
