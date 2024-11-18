using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using appProyecto.Layers.Entidades.DTO;
using System;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Componente en la base de datos
    /// </summary>
    public class ComponenteDB
    {
        /// <summary>
        /// Método encargado de insertar un nuevo componente en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="componente">Representa el objeto componente a insertar</param>
        public void Insertar(Componente componente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarComponente";
                comando.Parameters.AddWithValue("@descripcion", componente.Descripcion);
                comando.Parameters.AddWithValue("@IdTipoComponente", componente.IdTipoComponente);
                comando.Parameters.AddWithValue("@IdFabricante", componente.IdFabricante);
                comando.Parameters.AddWithValue("@tipoBici", componente.TipoBicicleta);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método actualiza los datos de un componente en la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="componente">Representa el objeto componente que se desea actualizar</param>
        public void Actualizar(Componente componente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarComponente";
                comando.Parameters.AddWithValue("@id", componente.Id);
                comando.Parameters.AddWithValue("@descripcion", componente.Descripcion);
                comando.Parameters.AddWithValue("@IdTipoComponente", componente.IdTipoComponente);
                comando.Parameters.AddWithValue("@IdFabricante", componente.IdFabricante);
                comando.Parameters.AddWithValue("@tipoBici", componente.TipoBicicleta);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Selecciona todos los componentes de la base de datos y los retorna en una lista, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <returns>Retorna una lista de objetos de la clase Componente que representa todos los componentes de la base de datos</returns>
        public static List<Componente> SeleccionarTodos()
        {
            List<Componente> lista = new List<Componente>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarComponentes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Componente componente = new Componente();
                    componente.Id = (int)dr["ID"];
                    componente.Descripcion = dr["Descripcion"].ToString();
                    componente.IdFabricante = (int)dr["ID_FabricanteComponente"];
                    componente.Fabricante_Componente = FabricanteComponenteDB.SeleccionarPorId(componente.IdFabricante);
                    componente.TipoBicicleta = dr["TipoBici"].ToString();
                    componente.IdTipoComponente = (int)dr["ID_TipoComponente"];
                    componente.TipoComponente = TipoComponenteDB.SeleccionarPorId(componente.IdTipoComponente);

                    lista.Add(componente);
                }
            }

            return lista;
        }

        /// <summary>
        /// Se encarga de buscar un componente específico en la base de datos, identificado por su id. Esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="id">Representa el id del componente que se desea buscar</param>
        /// <returns>Retorna el objeto Componente si se encuentra un registro en la base de datos que corresponda al id ingresado. 
        /// Si no se encuentra, se retorna "null".</returns>
        public static Componente SeleccionarPorId(long id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarComponentePorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Componente componente = new Componente();
                    componente.Id = (int)dr["ID"];
                    componente.Descripcion = dr["Descripcion"].ToString();
                    componente.IdFabricante = (int)dr["ID_FabricanteComponente"];
                    componente.Fabricante_Componente = FabricanteComponenteDB.SeleccionarPorId(componente.IdFabricante);
                    componente.TipoBicicleta = dr["TipoBici"].ToString();
                    componente.IdTipoComponente = (int)dr["ID_TipoComponente"];
                    componente.TipoComponente = TipoComponenteDB.SeleccionarPorId(componente.IdTipoComponente);

                    return componente;
                }
            }
            return null;
        }

        /// <summary>
        /// Método encargado de eliminar un componente de la base de datos, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="id">Representa el identificador del componente a eliminar</param>
        public void Eliminar(long id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarComponente";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Método encargado de consultar los componentes que pertenecen a un producto en particular, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="productoId">Representa el identificador del producto</param>
        /// <returns>Retorna una lista de objetos de la clase Componente que representa todos los componentes que pertenecen al producto indicado</returns>
        public List<Componente> SeleccionarPorProducto(long productoId)
        {
            List<Componente> lista = new List<Componente>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarProductoPorComponente";
                comando.Parameters.AddWithValue("@IdProducto", productoId);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Componente componente = new Componente();
                    componente.Id = (int)dr["ID"];
                    componente.Descripcion = dr["Descripcion"].ToString();
                    componente.IdFabricante = (int)dr["ID_FabricanteComponente"];
                    componente.Fabricante_Componente = FabricanteComponenteDB.SeleccionarPorId(componente.IdFabricante);
                    componente.TipoBicicleta = dr["TipoBici"].ToString();
                    componente.IdTipoComponente = (int)dr["ID_TipoComponente"];
                    componente.TipoComponente = TipoComponenteDB.SeleccionarPorId(componente.IdTipoComponente);

                    lista.Add(componente);
                }
            }

            return lista;
        }
    }
}
