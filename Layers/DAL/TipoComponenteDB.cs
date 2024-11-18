using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using appProyecto.Layers.Entidades;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Tipo_Componente en la base de datos
    /// </summary>
    public class TipoComponenteDB
    {
        /// <summary>
        /// Método encargado de insertar un nuevo tipo de componente en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="tipo">Representa el objeto tipo de componente a insertar</param>
        public void Insertar(TipoComponente tipo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_InsertarTipoComponente";
                comando.Parameters.AddWithValue("@descripcion", tipo.Descripcion);


                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método actualiza los datos de un tipo de componente en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="tipo">Representa el objeto tipo de componente que se desea actualizar</param>
        public void Actualizar(TipoComponente tipo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ActualizarTipoComponente";
                comando.Parameters.AddWithValue("@id", tipo.Id);
                comando.Parameters.AddWithValue("descripcion", tipo.Descripcion);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Elimina un tipo de componente de la base de datos, a partir de su identificador
        /// </summary>
        /// <param name="id">Representa el identificador del tipo de componente a eliminar</param>
        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_EliminarTipoComponente";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Devuelve una lista de todos los tipo de componente que estan en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos tipo componente</returns>
        public static List<TipoComponente> SeleccionarTodas()
        {
            List<TipoComponente> lista = new List<TipoComponente>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarTipoComponentes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoComponente tipo = new TipoComponente();
                    tipo.Id = (int)dr["Id"];
                    tipo.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(tipo);
                }
            }

            return lista;
        }

        /// <summary>
        /// Método que permite seleccionar un tipo de componente por su identificador único
        /// </summary>
        /// <param name="id">Identificador del tipo de componente a seleccionar</param>
        /// <returns>Retorna el tipo de componente buscado. Si no existe un tipo de componente con ese identificador, retorna null</returns>
        public static TipoComponente SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarTipoComponentePorId";
                comando.Parameters.AddWithValue("@id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoComponente tipo = new TipoComponente();
                    tipo.Id = (int)reader["Id"];
                    tipo.Descripcion = reader["Descripcion"].ToString();

                    return tipo;
                }
            }

            return null;
        }
    }
}
