using System.Configuration;

namespace appProyecto.Layers.DAL
{
    class Conexion
    {
        public static string Cadena
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                    ["Properties.Settings.Cadena"].
                    ConnectionString;
            }
        }
    }
}
