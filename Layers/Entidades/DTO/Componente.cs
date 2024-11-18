
namespace appProyecto.Layers.Entidades.DTO
{
    /// <summary>
    /// La clase Componente representa un componente utilizado en la construcción de una bicicleta
    /// </summary>
    public class Componente
    {
        /// <summary>
        /// Un entero que representa el id del componente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Una cadena de texto que describe el componente
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Un objeto del tipo TipoComponente que representa el tipo de componente que es
        /// </summary>
        public TipoComponente TipoComponente { get; set; }

        /// <summary>
        /// Un entero que representa el id del tipo de componente que es
        /// </summary>
        public int IdTipoComponente { get; set; }

        /// <summary>
        /// Un objeto del tipo FabricanteComponente que representa el fabricante del componente
        /// </summary>
        public FabricanteComponente Fabricante_Componente { get; set; }

        /// <summary>
        /// Un entero que representa el id del fabricante del componente
        /// </summary>
        public int IdFabricante { get; set; }

        /// <summary>
        /// Una cadena de texto que indica para qué tipo de bicicleta está diseñado el componente
        /// </summary>
        public string TipoBicicleta { get; set; }

        /// <summary>
        /// Un método que devuelve una cadena de texto que representa el componente
        /// </summary>
        /// <returns>Retorna la descripción del componente</returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
