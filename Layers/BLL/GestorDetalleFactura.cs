using appProyecto.Layers.Entidades.DTO;
using System.Linq;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de los cálculos de los montos de cada DetalleFactura
    /// </summary>
    class GestorDetalleFactura
    {
        /// <summary>
        /// Representa el objeto DetalleFactura al que se desea realizar los cálculos
        /// </summary>
        public DetalleFactura _DetalleFactura { get; set; }

        /// <summary>
        /// Este método, cálcula el subtotal en colones del objetos DetalleFactura deseado, 
        /// además fija este subtotal en la propiedad SubTotalColones dentro de la clase DetalleFactura
        /// </summary>
        public void FijarSubTotalColones()
        {
            _DetalleFactura.SubTotalColones = _DetalleFactura.Cantidad * _DetalleFactura.Producto.PrecioColon;
        }

        /// <summary>
        /// Este método, se encarga de calcular y fijar el valor del impuesto en colones para el objeto DetalleFactura
        /// </summary>
        public void FijarImpuestoColones()
        {
            _DetalleFactura.ImpuestoColones = ((decimal)13m / 100m) * _DetalleFactura.SubTotalColones;
        }

        /// <summary>
        /// Este método, cálcula el subtotal en dólares del objetos DetalleFactura deseado, 
        /// además fija este subtotal en la propiedad SubTotalDolares dentro de la clase DetalleFactura
        /// </summary>
        public void FijarSubTotaDolares()
        {
            _DetalleFactura.SubTotalDolares = _DetalleFactura.Cantidad * _DetalleFactura.Producto.PrecioDolar;
        }

        /// <summary>
        /// Este método, se encarga de calcular y fijar el valor del impuesto en dólares para el objeto DetalleFactura
        /// </summary>
        public void FijarImpuestoDolares()
        {
            _DetalleFactura.ImpuestoDolares = ((decimal)13m / 100m) * _DetalleFactura.SubTotalDolares;
        }

        /// <summary>
        /// Este método se encarga de fijar un nuevo Id para el DetalleFactura que se está agregando a una Factura
        /// </summary>
        /// <param name="pFactura">Representa la factura a la cúal se le quiere agregar este detalle factura</param>
        public void FijarIdDetalleFactura(Factura pFactura)
        {
            _DetalleFactura.Id = pFactura._ListaFacturaDetalle.Count == 0 ?
                                                 1 : pFactura._ListaFacturaDetalle.Max(p => p.Id) + 1;
        }
    }
}
