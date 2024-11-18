using System;
using System.Collections.Generic;
using System.Data;

namespace appProyecto.Layers.BLL
{
    /// <summary>
    /// Clase encargada de solicitar el cambio del dolar
    /// </summary>
    public class ServiceBCCR
    {
        //Agregar los credenciales para el uso del consumo API del Dolar BCCR

        /// <summary>
        /// Token necesario para utilizar el WebService
        /// </summary>
        private readonly string TOKEN = "2MODPMA3AE";

        /// <summary>
        /// Nombre necesario para obtener los datos
        /// </summary>
        private readonly string NOMBRE = "CamcioDolar";

        /// <summary>
        /// Correo al que se registro al WebService
        /// </summary>
        private readonly string CORREO = "quesadasalaci@gmail.com";

        /// <summary>
        /// Método encargado de obtener el cambio de dolar en las fechas indicadas
        /// </summary>
        /// <param name="pFechaInicial">Representa la fecha inical al que se desea consulta el cambio</param>
        /// <param name="pFechaFinal">Representa la fecha final al que se desea consulta el cambio</param>
        /// <param name="pCompraoVenta">Representa si se desea consultar el cambio a dolar para su venta o compra</param>
        /// <returns>Retorna una lista de objetos CambioDolar</returns>
        public IEnumerable<CambioDolar> GetDolar(DateTime pFechaInicial, DateTime pFechaFinal, String pCompraoVenta)
        {
            //Se crean las variables a utilizar
            List<CambioDolar> lista = new List<CambioDolar>();
            DataSet dataset = null;
            string fecha_inicial, fecha_final;
            string tipoCompraoVenta;

            // Se convierten las fechas a string en el formato solicitado
            fecha_inicial = pFechaInicial.ToString("dd/MM/yyyy");
            fecha_final = pFechaFinal.ToString("dd/MM/yyyy");

            // se compara si es compra (317) o venta (318)
            tipoCompraoVenta = pCompraoVenta.Equals("c", StringComparison.InvariantCulture) ? "317" : "318";

            // Protocolo de comunicaciones
            System.Net.ServicePointManager.SecurityProtocol =
           System.Net.SecurityProtocolType.Tls12;

            // Se instancia al Servicio Web
            BCCR.wsindicadoreseconomicosSoapClient client =
            new
           BCCR.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");
            // Se invoca.
            dataset = client.ObtenerIndicadoresEconomicos(tipoCompraoVenta,
           fecha_inicial, fecha_final, NOMBRE, "N", CORREO, TOKEN);
            //Se carga el taset
            DataTable table = dataset.Tables[0];
            //Se recorre el dataset
            foreach (DataRow row in table.Rows)
            {
                // Validar el error. No es la forma correcta pero bueno.
                if (row[0].ToString().Contains("error"))
                {
                    throw new Exception(row[0].ToString());
                }
                //Se asignan lso valores a la clase de tipo dolar
                CambioDolar dolar = new CambioDolar();
                dolar.Codigo = row[0].ToString();
                dolar.Fecha = DateTime.Parse(row[1].ToString());
                dolar.Monto = Convert.ToDouble(row[2].ToString());
                lista.Add(dolar);
            }
            //Se retorna la lista
            return lista;
        }
    }
}
