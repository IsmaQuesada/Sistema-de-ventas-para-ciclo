using System;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de representar el cambio de dolar
    /// </summary>
    public class CambioDolar
    {
        /// <summary>
        /// Representa un código para identificar si es de compra o venta
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Representa la fecha del cambio 
        /// </summary>
        public DateTime Fecha { get; set; }
        /// <summary>
        /// Representa el monto en el cual se encuentra el cambio a dolar 
        /// </summary>
        public double Monto { get; set; }
    }
}
