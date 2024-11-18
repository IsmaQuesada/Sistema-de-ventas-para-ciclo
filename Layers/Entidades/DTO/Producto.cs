
namespace appProyecto.Layers.Entidades.DTO
{
    /// <summary>
    /// Clase encargada de representar un producto en el inventario
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Representa el identificador del producto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Representa la descripción del producto
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Identificador del tipo de producto que es 
        /// </summary>
        public int IdTipoProducto { get; set; }

        /// <summary>
        /// Un objeto del tipo TipoProducto que representa el tipo de producto que es
        /// </summary>
        public TipoProducto TipoProducto { get; set; }

        /// <summary>
        /// Un entero que representa el id del fabricante del producto
        /// </summary>
        public int IdFabricanteProducto { get; set; }

        /// <summary>
        /// Un objeto del tipo FabricanteProducto que representa el fabricante del producto
        /// </summary>
        public FabricanteProducto FabricanteProducto { get; set; }

        /// <summary>
        /// Propiedad de arreglo de bytes que representa la imagen del producto
        /// </summary>
        public byte[] ImagenProducto { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad en stock del producto
        /// </summary>
        public int Existencia { get; set; }

        /// <summary>
        /// Obtiene o establece el precio del producto en colones
        /// </summary>
        public decimal PrecioColon { get; set; }

        /// <summary>
        /// Obtiene o establece el precio del producto en dólares 
        /// </summary>
        public decimal PrecioDolar { get; set; }
    }
}
