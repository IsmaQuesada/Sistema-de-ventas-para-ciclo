using appProyecto.Layers.BLL;
using appProyecto.Layers.Entidades.DTO;
using appProyecto.Util;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmProductoPorComponente : Form
    {
        //Propiedad que se encargar de recibir la bicicleta que se seleccionó en producción
        public Producto Bicicleta { get; set; }

        //Propiedad que se encargar de recibir el tipo de bicicleta que se seleccionó en producción
        public bool TipoBici { get; set; }

        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmProductoPorComponente()
        {
            InitializeComponent();
        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            try
            {
                //Pregunta si lbDisponibles tiene items seleccionados 
                if (lbDisponibles.SelectedItem != null)
                {
                    //Obtiene el item seleccionado y luego los castea  
                    var prov = (Componente)lbDisponibles.SelectedItem;

                    //Crea un objeto tipo ProductoLN para poder agregarle el componente seleccionado al respectivo producto
                    var logica = new ProductoLN();

                    //Agrega el componente seleccionado a la bicicleta 
                    logica.AgregarComponente(Bicicleta.Id, prov.Id);

                    //Refresca la lista de lbDisponibles y lbEnsamblado para mostrar los componentes ensamblados y los disponibles 
                    Refrescar();
                }

                //Se registra un evento indicando que se ha ensamblado un componente 
                _MyLogControlEventos.InfoFormat("Se ensamblo un componente");
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), ex));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndesensamblar_Click(object sender, EventArgs e)
        {
            try
            {
                //Pregunta si lbEnsamblado tiene items seleccionados 
                if (lbEnsamblado.SelectedItem != null)
                {
                    //Obtiene el item seleccionado y luego los castea  
                    var comp = (Componente)lbEnsamblado.SelectedItem;

                    //Crea un objeto tipo ProductoLN para poder desensamblarle el componente seleccionado al respectivo producto
                    var logica = new ProductoLN();

                    //Desensambla el componente seleccionado a la bicicleta 
                    logica.RemoverComponente(Bicicleta.Id, comp.Id);

                    //Refresca la lista de lbDisponibles y lbEnsamblado para mostrar los componentes ensamblados y los disponibles 
                    Refrescar();
                }

                //Se registra un evento indicando que se ha desensambla un componente 
                _MyLogControlEventos.InfoFormat("Se desensambló un componente");
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), ex));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductoPorComponente_Load(object sender, EventArgs e)
        {
            try
            {
                //Refresca la lista de lbDisponibles y lbEnsamblado para mostrar los componentes ensamblados y los disponibles 
                Refrescar();

                //Se registra un evento indicando que se ha accedido al ensamblaje de componentes 
                _MyLogControlEventos.InfoFormat("Se accedió a ensamblaje de componentes");
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), ex));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            //Obtiene de la base de datos, una lista de todos los componentes disponibles para la bicicleta seleccionada
            List<Componente> listaDispoibles = ComponenteLN.ObtenerDisponiblesPorProducto(Bicicleta.Id);

            //Crea una lista para filtrar los componentes destinados a bicicletas de ruta y montaña 
            List<Componente> listaFiltrada = new List<Componente>();

            //Recorre las lista de componentes disponibles 
            foreach (var item in listaDispoibles)
            {
                //Si la variable "TipoBici" es True, hace referencia a las bicicletas de ruta
                if (TipoBici)
                {
                    if (item.TipoBicicleta.Equals("Ruta", StringComparison.CurrentCultureIgnoreCase))
                        listaFiltrada.Add(item);  //Añade el componente a la lista filtrada
                }
                else  //Si la variable "TipoBici" es False, hace referencia a las bicicletas de montaña
                {
                    if (item.TipoBicicleta.Equals("Montaña", StringComparison.CurrentCultureIgnoreCase))
                        listaFiltrada.Add(item);  //Añade el componente a la lista filtrada
                }
            }

            //Muestra los componente disponibles en lbDisponibles. Dependiendo del tipo de bici, si es ruta, solo muestra componentes de ruta.
            //Si es montaña, solo muestra componentes de montaña
            lbDisponibles.DataSource = listaFiltrada;

            //Si se ha seleccionado una bicicleta 
            if (Bicicleta != null)
            {
                //Muestra en lbEnsamblado los componentes ya ensamblados 
                lbEnsamblado.DataSource =
                 ComponenteLN.ObtenerPorIdProducto(Bicicleta.Id);
            }
        }

        private void frmProductoPorComponente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se registra un evento indicando que se termino el ensamblaje de componentes 
            _MyLogControlEventos.InfoFormat("Se cerro ensamblaje de componentes");
        }
    }
}
