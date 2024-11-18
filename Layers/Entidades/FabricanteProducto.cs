using appProyecto.Layers.Interfaces;

namespace appProyecto.Layers.Entidades
{
    /// <summary>
    /// Clase que representa un fabricante de productos, implementa la interfaz ICategorias
    /// </summary>
    public class FabricanteProducto : ICategorias
    {
        /// <summary>
        /// identificador único del fabricante de producto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// descripción del fabricante de producto
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Devuelve la descripción del fabricante
        /// </summary>
        /// <returns>Retorna la descripción del fabricante </returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
