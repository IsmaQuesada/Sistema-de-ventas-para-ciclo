using appProyecto.Layers.Entidades.DTO;

namespace appProyecto.Factories
{
    /// <summary>
    /// Clase encargada de crear nuevos objetos del tipo DetalleFactura
    /// </summary>
    class FactoryDetalleFactura
    {
        /// <summary>
        /// Método encargado de crear un nuevo objeto del tipo DetalleFactura
        /// </summary>
        /// <param name="pDetalleFactura">Parámetro encargado de recibir un objeto DetalleFactura, para luego construirlo</param>
        /// <param name="pFactura">Parámetro que recibe un objeto Factura, el cual es la factura a la cual de quiere agregar el detalle</param>
        /// <param name="pProducto">Parámetro que recibe un objeto Producto, él cual es el producto que se quiere agregar al detalle</param>
        /// <param name="pCantidad">Un entero que representa la cantidad del producto que se quiere agregar al detalle</param>
        /// <returns>Retorna el nuevo objeto DetalleFactura o el DetalleFactura que se pasó como parámetro si no se creó uno nuevo</returns>
        public static DetalleFactura CrearDetalleFactura(DetalleFactura pDetalleFactura, Factura pFactura, Producto pProducto, int pCantidad)
        {
            pDetalleFactura = new DetalleFactura()
            {
                IdProducto = pProducto.Id,
                Cantidad = pCantidad,
                Producto = pProducto,
                IdFactura = pFactura.Id,
            };

            return pDetalleFactura;
        }
    }
}
