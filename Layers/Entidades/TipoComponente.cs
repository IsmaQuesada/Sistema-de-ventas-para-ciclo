using appProyecto.Layers.Interfaces;

namespace appProyecto.Layers.Entidades
{
    /// <summary>
    /// Clase que representa los tipos de componente, implementa la interfaz ICategorias
    /// </summary>
    public class TipoComponente : ICategorias
    {
        /// <summary>
        /// identificador único del tipo de Componente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// descripción del tipo de Componente
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Devuelve la descripción del tipo de Componente
        /// </summary>
        /// <returns>Retorna la descripción del tipo de Componente</returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
