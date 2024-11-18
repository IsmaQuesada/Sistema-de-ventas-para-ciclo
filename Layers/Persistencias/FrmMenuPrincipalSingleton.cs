using appProyecto.Layers.UI;

namespace appProyecto.Layers.DAL
{
    /// <summary>
    /// Clase singleton que se encarga de la instancia del frmMenuPrincipal, esta clase no permite ser heredada
    /// </summary>
    public sealed class FrmMenuPrincipalSingleton
    {
        /// <summary>
        /// Atributo que contiene la instancia del frmMenuPrincipal
        /// </summary>
        private static frmMenuPrincipal _instance;

        /// <summary>
        /// Constructor privado que no permite que la clase pueda ser instanciada en otras clases
        /// </summary>
        private FrmMenuPrincipalSingleton()
        {
        }

        /// <summary>
        /// Método encargado de crear la instancia del frmMenuPrincipal una única vez
        /// </summary>
        /// <returns>Retorna el atributo _instance, que posee la instancia del frmMenuPrincipal</returns>
        public static frmMenuPrincipal GetInstance()
        {
            if (_instance == null)
            {
                _instance = new frmMenuPrincipal();
            }

            return _instance;
        }
    }
}
