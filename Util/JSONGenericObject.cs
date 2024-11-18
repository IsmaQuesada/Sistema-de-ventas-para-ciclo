using Newtonsoft.Json;

namespace appProyecto.Util
{
    public class JSONGenericObject<T>
    {
        public static T JSonToObject(string pDatos)
        {
            T @object = (T)JsonConvert.DeserializeObject<T>(pDatos);

            return @object;

        }
    }
}
