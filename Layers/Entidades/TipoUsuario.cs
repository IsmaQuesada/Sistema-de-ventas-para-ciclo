using appProyecto.Layers.Interfaces;

namespace appProyecto.Layers.Entidades
{
    /// <summary>
    /// Clase que representa los tipos de usuario, implementa la interfaz ICategorias
    /// </summary>
    public class TipoUsuario : ICategorias
    {
        /// <summary>
        /// identificador único del tipo de usuario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// descripción del tipo de usuario
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Devuelve la descripción del tipo de usuario
        /// </summary>
        /// <returns>Retorna la descripción del tipo de usuario</returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
