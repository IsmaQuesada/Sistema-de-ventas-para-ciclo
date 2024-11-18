using System;
using System.Collections.Generic;

namespace appProyecto.Layers.Entidades.DTO
{
    /// <summary>
    /// Clase encargada de representar una factura de venta
    /// </summary>
    class Factura
    {
        /// <summary>
        /// Identificador de la factura
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cédula del cliente que realiza la compra
        /// </summary>
        public string CedulaCliente{ get; set; }

        /// <summary>
        /// Total de la factura en colones
        /// </summary>
        public decimal TotalColones { get; set; }

        /// <summary>
        /// Total de la factura en dólares
        /// </summary>
        public decimal TotalDolares { get; set; }

        /// <summary>
        /// Fecha de la factura
        /// </summary>
        public DateTime FechaFacturacion { get; set; }

        /// <summary>
        /// Lista de objetos DetalleFactura, que contienen información detallada de cada producto vendido.
        /// </summary>
        public List<DetalleFactura> _ListaFacturaDetalle { get; } = new List<DetalleFactura>();

        /// <summary>
        /// Permite agregar un objeto DetalleFactura a la lista _ListaFacturaDetalle.
        /// </summary>
        /// <param name="DetalleFactura">Representa el detalle de la factura que se desea agregar al la lista</param>
        public void AddDetalle(DetalleFactura DetalleFactura)
        {
            _ListaFacturaDetalle.Add(DetalleFactura);
        }
    }
}
