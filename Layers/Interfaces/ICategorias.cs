
namespace appProyecto.Layers.Interfaces
{
    /// <summary>
    /// La interfaz ICategorias define los miembros que deben tener todas las clases que implementan estas propiedades y método
    /// </summary>
    public interface ICategorias
    {
        /// <summary>
        /// propiedad que representa un identificador 
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// propiedad que representa una descripción 
        /// </summary>
        string Descripcion { get; set; }

        /// <summary>
        ///  método que devuelve la descripción de la categoría como una cadena de caracteres
        /// </summary>
        /// <returns>retorna la descripción del objeto </returns>
        string ToString();
    }
}
