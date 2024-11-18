using appProyecto.Layers.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Fabricante_Componente en la base de datos
    /// </summary>
    public class FabricanteComponenteDB
    {
        /// <summary>
        /// Selecciona todos los fabricante de componentes de la base de datos y los retorna en una lista, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos de la clase FabricanteComponente, 
        /// que representa todos los fabricante de componentes de la base de datos</returns>
        public static List<FabricanteComponente> SeleccionarTodas()
        {
            List<FabricanteComponente> lista = new List<FabricanteComponente>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarFabricanteComponentes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    FabricanteComponente fabricante = new FabricanteComponente();
                    fabricante.Id = (int)dr["Id"];
                    fabricante.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(fabricante);
                }
            }

            return lista;
        }

        /// <summary>
        /// Se encarga de buscar un fabricante de componentes específico en la base de datos, 
        /// identificado por su id. Esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="id">Representa el id del fabricante de componentes que se desea buscar</param>
        /// <returns>Retorna el objeto fabricante de componentes si se encuentra un registro en la base de datos que corresponda al id ingresado. 
        /// Si no se encuentra, se retorna "null"</returns>
        public static FabricanteComponente SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarFabricanteComponentePorId";
                comando.Parameters.AddWithValue("@id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    FabricanteComponente fabricante = new FabricanteComponente();
                    fabricante.Id = (int)reader["Id"];
                    fabricante.Descripcion = reader["Descripcion"].ToString();

                    return fabricante;
                }
            }

            return null;
        }
    }
}
