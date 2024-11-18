using appProyecto.Layers.Interfaces;

namespace appProyecto.Layers.Entidades
{
    /// <summary>
    /// Clase que representa los tipos de producto, implementa la interfaz ICategorias
    /// </summary>
    public class TipoProducto : ICategorias
    {
        /// <summary>
        /// identificador único del tipo de producto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// descripción del tipo de producto
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Devuelve la descripción del tipo de producto
        /// </summary>
        /// <returns>Retorna la descripción del tipo de producto</returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
