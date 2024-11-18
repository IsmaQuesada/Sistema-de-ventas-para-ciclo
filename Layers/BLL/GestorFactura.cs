using appProyecto.Layers.Entidades.DTO;
using System.Linq;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de los cálculos de los montos de cada Factura
    /// </summary>
    class GestorFactura
    {
        /// <summary>
        /// Representa la factura a la cúal se desea realizar estos cálculos
        /// </summary>
        public Factura _Factura { get; set; }

        /// <summary>
        /// Este método cálcula el subtotal en colones de una factura
        /// </summary>
        /// <returns>Retorna el subtotal en colones de la factura</returns>
        public decimal GetSubTotalColones()
        {
            return _Factura._ListaFacturaDetalle.Sum(p => p.Cantidad * p.Producto.PrecioColon);
        }

        /// <summary>
        /// Este método cálcula el impuesto en colones de una factura
        /// </summary>
        /// <returns>Retorna el impuesto en colones de la factura</returns>
        public decimal GetImpuestoColones()
        {
            return _Factura._ListaFacturaDetalle.Sum(p => p.ImpuestoColones);
        }

        /// <summary>
        /// Este método cálcula el subtotal en dólares de una factura
        /// </summary>
        /// <returns>Retorna el subtotal en dólares de la factura</returns>
        public decimal GetSubTotalDolares()
        {
            return _Factura._ListaFacturaDetalle.Sum(p => p.Cantidad * p.Producto.PrecioDolar);
        }

        /// <summary>
        /// Este método cálcula el impuesto en dólares de una factura
        /// </summary>
        /// <returns>Retorna el impuesto en dólares de la factura</returns>
        public decimal GetImpuestoDolares()
        {
            return _Factura._ListaFacturaDetalle.Sum(p => p.ImpuestoDolares);
        }

        /// <summary>
        /// Este método cálcula el total en colones de una factura. Luego, lo fija en la factura
        /// </summary>
        public void FijarTotalColones()
        {
            _Factura.TotalColones = GetSubTotalColones() + GetImpuestoColones();
        }

        /// <summary>
        /// Este método cálcula el total en dólares de una factura. Luego, lo fija en la factura
        /// </summary>
        public void FijarTotalDolares()
        {
            _Factura.TotalDolares = GetSubTotalDolares() + GetImpuestoDolares();
        }
    }
}
