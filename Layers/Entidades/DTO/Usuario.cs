using System;

namespace appProyecto.Layers.Entidades.DTO
{
    /// <summary>
    /// La clase Usuario representa un usuario del sistema
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// propiedad de cadena que representa el número de identificación del usuario
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// propiedad de cadena que representa el nombre completo del usuario
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// propiedad de cadena que representa el correo electrónico del usuario
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// propiedad entera que representa el identificador del tipo de usuario al que pertenece
        /// </summary>
        public int IdTipoUsuario { get; set; }

        /// <summary>
        /// propiedad de tipo TipoUsuario que representa el tipo de usuario al que pertenece
        /// </summary>
        public TipoUsuario TipoUsuario { get; set; }

        /// <summary>
        /// propiedad de cadena que representa la contraseña del usuario
        /// </summary>
        public string Contrasennia { get; set; }

        /// <summary>
        /// propiedad de tipo DateTime que representa la fecha de nacimiento del usuario
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// propiedad de arreglo de bytes que representa la fotografía del usuario
        /// </summary>
        public byte[] Fotografia { get; set; }
    }
}
