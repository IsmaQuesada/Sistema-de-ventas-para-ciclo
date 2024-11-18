using appProyecto.Layers.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Tipo_Producto en la base de datos
    /// </summary>
    public class TipoProductoDB
    {
        /// <summary>
        /// Método encargado de insertar un nuevo tipo de producto en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="tipo">Representa el objeto tipo de producto a insertar</param>
        public void Insertar(TipoProducto tipo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_InsertarTipoProducto";
                comando.Parameters.AddWithValue("@descripcion", tipo.Descripcion);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método actualiza los datos de un tipo de producto en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="tipo">Representa el objeto tipo de producto que se desea actualizar</param>
        public void Actualizar(TipoProducto tipo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_ActualizarTipoProducto";
                comando.Parameters.AddWithValue("@id", tipo.Id);
                comando.Parameters.AddWithValue("descripcion", tipo.Descripcion);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Elimina un tipo de producto de la base de datos, a partir de su identificador
        /// </summary>
        /// <param name="id">Representa el identificador del tipo de producto a eliminar</param>
        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_EliminarTipoProducto";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Devuelve una lista de todos los tipo de producto que estan en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos tipo producto</returns>
        public static List<TipoProducto> SeleccionarTodas()
        {
            List<TipoProducto> lista = new List<TipoProducto>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarTipoProductos";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoProducto tipo = new TipoProducto();
                    tipo.Id = (int)dr["Id"];
                    tipo.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(tipo);
                }
            }

            return lista;
        }

        /// <summary>
        /// Método que permite seleccionar un tipo de producto por su identificador único
        /// </summary>
        /// <param name="id">Identificador del tipo de producto a seleccionar</param>
        /// <returns>Retorna el tipo de producto buscado. Si no existe un tipo de producto con ese identificador, retorna null</returns>
        public static TipoProducto SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarTipoProductoPorId";
                comando.Parameters.AddWithValue("@id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoProducto tipo = new TipoProducto();
                    tipo.Id = (int)reader["Id"];
                    tipo.Descripcion = reader["Descripcion"].ToString();

                    return tipo;
                }
            }

            return null;
        }
    }
}
