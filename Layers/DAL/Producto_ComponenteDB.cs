using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using appProyecto.Layers.Entidades.DTO;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase que se encarga de administrar la tabla Producto_Componente en la base de datos
    /// </summary>
    class Producto_ComponenteDB
    {
        /// <summary>
        /// Selecciona los componentes asociados a un producto determinado, esto por medio de un procedimiento almacenado
        /// </summary>
        /// <param name="idProducto">Representa el identificador del producto</param>
        /// <returns>Retorna una lista de objetos Componente, que estan asociados al producto indicado</returns>
        public static List<Componente> SeleccionarComponentes_DelProducto(int idProducto)
        {
            List<Componente> lista = new List<Componente>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_SeleccionarComponente_DeProducto_Componente";
                comando.Parameters.AddWithValue("@IdProducto", idProducto);

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
