
namespace appProyecto.Layers.Entidades.DTO
{
    /// <summary>
    /// Clase que representa un detalle de factura
    /// </summary>
    class DetalleFactura
    {
        /// <summary>
        /// Identificador del detalle de factura
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Identificador de la factura a la que pertenece el detalle
        /// </summary>
        public int IdFactura { set; get; }

        /// <summary>
        /// Identificador del producto que se vendió en el detalle
        /// </summary>
        public int IdProducto { set; get; }

        /// <summary>
        /// Producto que se vendió en el detalle
        /// </summary>
        public Producto Producto { set; get; }

        /// <summary>
        /// Cantidad del producto vendido en el detalle
        /// </summary>
        public int Cantidad { set; get; }

        /// <summary>
        /// Subtotal en colones del detalle de factura
        /// </summary>
        public decimal SubTotalColones { set; get; }

        /// <summary>
        /// Subtotal en dólares del detalle de factura
        /// </summary>
        public decimal SubTotalDolares{ set; get; }

        /// <summary>
        /// Impuesto en colones del detalle de factura
        /// </summary>
        public decimal ImpuestoColones { set; get; }

        /// <summary>
        /// Impuesto en dólares del detalle de factura
        /// </summary>
        public decimal ImpuestoDolares { set; get; }
    }
}
