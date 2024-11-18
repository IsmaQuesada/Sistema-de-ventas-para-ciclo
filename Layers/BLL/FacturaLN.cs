using appProyecto.Layers.Entidades.DTO;
using appProyecto.Layers.DAL;
using System.Collections.Generic;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de la lógica de negocio relacionada con los objetos de tipo Factura
    /// </summary>
    class FacturaLN
    {
        /// <summary>
        /// Obtiene el número siguiente de la factura que se generará
        /// </summary>
        /// <returns>Retorna el número siguiente de la factura que se generará</returns>
        public static int ObtenerNumeroFactura()
        {
            FacturaDB FacturaDB = new FacturaDB();
            return FacturaDB.ObtenerSiguienteNumeroFactura();
        }

        /// <summary>
        /// Guarda una Factura en la base de datos.
        /// Primero, verifica que haya suficiente cantidad de productos disponibles en la base de datos. 
        /// Si no hay suficiente cantidad, se lanza una excepción. Si todo está bien, se guarda la factura 
        /// </summary>
        /// <param name="pFactura"></param>
        /// <returns>Retorna la misma factura que se guardo en la base de datos</returns>
        public static Factura GuardarFactura(Factura pFactura)
        {
            foreach (DetalleFactura detalle in pFactura._ListaFacturaDetalle)
            {
                ProductoLN.ConfirmarExistencia(detalle.IdProducto, detalle.Cantidad);
            }

            return FacturaDB.InsertarFactura(pFactura);
        }

        /// <summary>
        /// Obtiene una lista de los productos comprados en una factura, dependiendo del id de este
        /// </summary>
        /// <param name="idFactura">El id de la factura de la cual se quieren obtener los productos comprados</param>
        /// <returns>Retorna una lista de objetos Producto correspondientes a los productos comprados en la factura especificada</returns>
        public static List<Producto> ObtenerProductosComprados(int idFactura)
        {
            return FacturaDB.ObtenerProductosPorIdFactura(idFactura);
        }
    }
}
