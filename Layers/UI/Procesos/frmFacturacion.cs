using appProyecto.Factories;
using appProyecto.Layers.BLL;
using appProyecto.Layers.Entidades.DTO;
using appProyecto.Util;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmFacturacion : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        //Crea objetos de tipo usuario, que se encargar de obtener el cliente que comprara en ese momento 
        private Usuario cliente = null;

        //Crear un objeto de tipo factura que representara la factura que se creara en ese momento 
        private Factura factura = null;

        //Crear un objeto GestorDetalleFactura, este se encargara de la logíca de los detalles de una factura 
        private GestorDetalleFactura oGestorDetalleFactura = new GestorDetalleFactura();

        //Crear un objeto GestorFactura, este se encargara de la logíca de la factura 
        private GestorFactura oGestorFactura = new GestorFactura();

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Se crea un frame con todos los cliente del sistema, aquí se seleccionara el cliente que realizara la compra
            frmMostrarClientes oFrmMostrarClientes = new frmMostrarClientes();

            try
            { 
                
                if (!string.IsNullOrEmpty(this.txtCedulaCliente.Text))
                {
                    cliente = UsuarioLN.ObtenerUsuarioPorCedula(txtCedulaCliente.Text);
                }
                else
                {
                    // Se muestra una ventana que muestra todos los cliente del sistema 
                    oFrmMostrarClientes.ShowDialog();

                    //Si el resultado de la venta es un "OK"
                    if (oFrmMostrarClientes.DialogResult == DialogResult.OK)
                    {
                        //Obtendra el cliente que se seleccionó en la ventana
                        cliente = oFrmMostrarClientes.Cliente;
                    }
                }

                //Si el objeto cliente esta vacío, se indicara que no se ha seleccionado ningún cliente 
                if (cliente == null)
                {
                    MessageBox.Show("No se ha seleccionado un Cliente",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Mostarar la cédula y el nombre del cliente seleccionado 
                this.txtNombreCliente.Text = cliente.NombreCompleto;
                this.txtCedulaCliente.Text = cliente.Cedula;

                //Toma los datos ya mostrados y los fija en la factura que se está creando en ese momento 
                factura = new Factura()
                {
                    Id = int.Parse(txtNumeroFactura.Text),
                    CedulaCliente = txtCedulaCliente.Text,
                    FechaFacturacion = DateTime.Now
                };

                //Deshabilita el botón para buscar clientes
                btnBuscarCliente.Enabled = false;

                //Se registra un evento indicando que se está realizando una factura
                _MyLogControlEventos.InfoFormat("Se está realizando una factura");
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


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Se crear un frame para mostrar los productos disponibles en el sistema 
            frmMostrarProductos oFrmMostrarProducto = new frmMostrarProductos();
            //Crea un objeto producto 
            Producto oProducto = null;

            try
            {
                //Muestra una ventana con todos los productos disponibles 
                oFrmMostrarProducto.ShowDialog();

                //Si la respuesta obtenida de la ventana es un "OK"
                if (oFrmMostrarProducto.DialogResult == DialogResult.OK)
                {
                    //Obtiene el producto que se selecccionó en esa ventana 
                    oProducto = oFrmMostrarProducto.Producto;

                    //Muestra los datos de ese producto en los campos 
                    txtDescripcionProducto.Text = oProducto.Descripcion;
                    this.mskCodigoProduto.Text = oProducto.Id.ToString();
                    this.txtPrecio.Text = "₡ " + oProducto.PrecioColon.ToString("0.00");
                    this.txtExistencia.Text = oProducto.Existencia.ToString();
                    this.mskCantidad.Focus();
                }

                //Si el producto es nulo, se indica que no se ha seleccionado ningún producto 
                if (oProducto == null)
                {
                    MessageBox.Show("No se ha seleccionado un Producto",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el frame 
            Close();
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            //Limpia todos los campos 
            Limpiar();
        }

        private void Limpiar()
        {
            try
            {
                //"Limpia" el objeto cliente que se genero 
                cliente = null;
                //Limpia todos los campos 
                this.txtCedulaCliente.Text = "";
                this.txtImpuestoColon.Text = "";
                this.txtSubtotalColon.Text = "";
                this.txtTotalColon.Text = "";
                this.txtImpuestoDolar.Text = "";
                this.txtSubtotalDolar.Text = "";
                this.txtTotalDolar.Text = "";
                this.txtPrecio.Text = "";
                this.mskCantidad.Text = "";
                this.mskCodigoProduto.Text = "";
                this.txtNombreCliente.Text = "-";
                this.txtExistencia.Text = "";
                this.txtDescripcionProducto.Text = "";
                rbDolar.Checked = false;
                rbColon.Checked = false;

                //"Limpia" la factura generada 
                factura = null;
                this.dgvDetalleFactura.Rows.Clear();
                //Obtiene el número de factura 
                this.txtNumeroFactura.Text = FacturaLN.ObtenerNumeroFactura().ToString();
                //Habilita el botón para seleccionar clientes 
                btnBuscarCliente.Enabled = true;

                //Se registra un evento indicando que se renovo la factura 
                _MyLogControlEventos.InfoFormat("Se renueva la factura");
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

        private void toolStripBtnFacturar_Click(object sender, EventArgs e)
        {
            //Declara una variable entera que almacenara el número de factura de ese momento
            int numeroFactura = 0;
            //Crea un objeto usuario, para obtener el cliente que acaba de realizar la compra en ese momento 
            Usuario clienteAtendido = null;

            try
            {
                //Realiza varias validaciones necesarias para comprobar datos que se necesitan para facturar 
                if (cliente == null)
                {
                    MessageBox.Show("Debe Seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtCedulaCliente.Focus();
                    return;
                }

                if (oGestorFactura._Factura == null)
                {
                    MessageBox.Show("No hay datos por facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (oGestorFactura._Factura._ListaFacturaDetalle.Count == 0)
                {
                    MessageBox.Show("No hay items en la factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Guarda en la base de datos la factura realizada en ese momento 
                factura = FacturaLN.GuardarFactura(oGestorFactura._Factura);

                //Actualiza la exitencia de los productos que se compraron en esa factura 
                foreach (var item in oGestorFactura._Factura._ListaFacturaDetalle)
                {
                    ProductoLN.ActualizarExistencia(item.IdProducto, item.Cantidad);
                }

                //Obtiene el número de factura
                numeroFactura = factura.Id;
                //Obtiene el cliente que realizo la compra en ese momento 
                clienteAtendido = cliente;

                //Comprueba si la factura se genero correctamente
                if (factura == null)
                    MessageBox.Show("Error al crear factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    toolStripBtnNuevo_Click(null, null); //En caso de generarlo correctamente, se limpian todos los campos de la interfaz 

                //Genera el QR de la compra 
                GenerarQR(numeroFactura);

                //Muestra una ventana con los detalles de la compra 
                Reportes.frmMostrarFactura frmFactura = new Reportes.frmMostrarFactura();
                //Fija en la ventana el numero de factura que se acaba de facturar 
                frmFactura.NumFactura = numeroFactura;
                //Obtiene el correo electrónico del cliente que realizo la compra 
                frmFactura.CorreoCliente = clienteAtendido.Correo;
                //Muestra la ventana 
                frmFactura.Show();

                //Se registra un evento indicando que se ha realizado una compra 
                _MyLogControlEventos.InfoFormat("Se ha realizado una compra");
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

        private void GenerarQR(int numeroFactura)
        {
            //Fija la ruta en la que se guardara el QR
            string rutaImagen = @"c:\temp\qr.png";

            //Obtiene todos los productos que se compraron en la factura indicada 
            List<Producto> listaProductos = FacturaLN.ObtenerProductosComprados(numeroFactura);
            
            //Crea un StringBuilder para crear una cadena para el QR
            StringBuilder detalleProductos = new StringBuilder();

            //Declara una lista de objetos "Componente"
            List<Componente> listaComponentes = null;

            detalleProductos.Append("--> Productos adquiridos: \n");

            //Recorre la lista de productos comprados y los muestra en la cadena
            foreach (var producto in listaProductos)
            {
                detalleProductos.Append("-Producto: " + producto.Descripcion + "  -Tipo de Producto: " + producto.TipoProducto.Descripcion
                    + "  -Fabricante: " + producto.FabricanteProducto.Descripcion + "\n");

                //Pregunta si ese producto es una Bicicleta 
                if (producto.TipoProducto.Descripcion.Equals("Bicicleta"))
                {
                    //Crear el la lista de componentes
                    listaComponentes = new List<Componente>();
                    //Obtiene todos los componentes que estan relacionados con ese producto 
                    listaComponentes = Producto_ComponenteLN.ObtenerComponentes(producto.Id);

                    detalleProductos.Append("\nBicicleta: " + producto.Descripcion + " --> Componentes de la bicicleta: ");

                    //Muestra en la cadena cada uno de sus componentes 
                    foreach (var componente in listaComponentes)
                    {
                        detalleProductos.Append("\n" + componente.Descripcion);
                        detalleProductos.Append("  -Tipo de Componente: " + componente.TipoComponente.Descripcion
                            + "  -Fabricante: " + componente.Fabricante_Componente.Descripcion + "\n\n");
                    }
                }
            }

            //Sobreescribe un QR que esta almacenado en la ruta indicada 
            if (File.Exists(rutaImagen))
                File.Delete(rutaImagen);

            // Crear imagen quickresponse, por medio de los datos que se agregaron en el StringBuilder 
            Image quickResponseImage = Util.QuickResponse.QuickResponseGenerador(detalleProductos.ToString(), 53);

            // Salvarla en c:\temp para luego ser leida
            quickResponseImage.Save(rutaImagen, ImageFormat.Png);
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                //Obtiene el número de factura que esta disponible en ese momento 
                this.txtNumeroFactura.Text = FacturaLN.ObtenerNumeroFactura().ToString();
                Util.Utilitarios.CultureInfo();

                //Registra un evento indicando que se accedio al proceso de facturación
                _MyLogControlEventos.InfoFormat("Se accedió a Proceso de Facturación");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Declara un objeto "DetalleFactura" 
            DetalleFactura oDetalleFactura = null;
            //Crea una variable de tipo decimal para almacenar el cambio del dolar 
            decimal cambio = 0m;
            //Crea un objeto tipo ServicioBCCR para acceder al tipo de cambio de ese momento 
            ServiceBCCR servicioBCCR = new ServiceBCCR();

            try
            {
                //Si el objeto factura es nulo, quiere decir que no se ha seleccionado un cliente 
                if (factura == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente para continuar",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que el Producto ya no se haya agregado
                if (factura._ListaFacturaDetalle.Count > 0)
                {
                    // Si ya se agrego no permitir agregarlo nuevamente
                    if (factura._ListaFacturaDetalle.FindAll(p => p.IdProducto == int.Parse(mskCodigoProduto.Text)).Count > 0)
                    {
                        MessageBox.Show("El producto ya fue agregado previamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //Valida que se ingrese la cantidad que se desea comprar de ese producto 
                if (string.IsNullOrEmpty(this.mskCantidad.Text))
                {
                    MessageBox.Show("Debe ingresar la cantidad de artículos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskCantidad.Focus();
                    return;
                }

                //Si la cantidad ingresada es 0 o menos, se le indica el error 
                if (int.Parse(this.mskCantidad.Text) == 0)
                {
                    MessageBox.Show("La cantidad de artículos debe ser mayor a cero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskCantidad.Focus();
                    return;
                }

                //Se le indica en que moneda quiere realizar el pago 
                if (!rbDolar.Checked && !rbColon.Checked)
                {
                    MessageBox.Show("Debe seleccionar la moneda con la que desea pagar",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gpbMoneda.Focus();
                    return;
                }

                //Confirma si hay stock suficiente de ese producto, para realizar la venta solicitada por el cliente 
                Producto oProducto = ProductoLN.ConfirmarExistencia(int.Parse(this.mskCodigoProduto.Text), int.Parse(this.mskCantidad.Text));
                this.txtExistencia.Text = oProducto.Existencia.ToString();

                //Obtiene el tipo de cambio en ese momento 
                foreach (var item in servicioBCCR.GetDolar(DateTime.Now, DateTime.Now, "C"))
                {
                    cambio = (decimal)item.Monto;
                }

                //Comprueba si el cliente quiere pagar en dolares 
                if (rbDolar.Checked)
                {
                    //Si desea pagar en dolares, se le aplica el tipo de cambio al producto solicitado 
                    oProducto.PrecioDolar = oProducto.PrecioColon / cambio;
                    oProducto.PrecioColon = 0;
                }

                //Llama al FactoryDetalleFactura para que cree un detalleFactura con los datos obtenidos hasta ese momento 
                oDetalleFactura = FactoryDetalleFactura.CrearDetalleFactura(oDetalleFactura, factura, oProducto, int.Parse(this.mskCantidad.Text));

                //Fija en el GestorDetalleFactura el detalle de factura que se desea administrar en ese momento 
                oGestorDetalleFactura._DetalleFactura = oDetalleFactura;

                //Comprueba si se desea pagar en dolar 
                if (rbDolar.Checked)
                {
                    //Calcula los costos del producto que se desea comprar en ese momento 
                    oGestorDetalleFactura.FijarSubTotaDolares();
                    oGestorDetalleFactura.FijarImpuestoDolares();
                }
                else //Sino, el pago se hara en colones
                {
                    //Calcula los costos del producto que se desea comprar en ese momento 
                    oGestorDetalleFactura.FijarSubTotalColones();
                    oGestorDetalleFactura.FijarImpuestoColones();
                }
                //Fija al DetalleFactura, el id de la Factura a la cúal pertenece
                oGestorDetalleFactura.FijarIdDetalleFactura(factura);

                //Añade a la factura el detalle de la compra de ese momento 
                factura.AddDetalle(oDetalleFactura);

                //Asigna al GestorFactura la factura que se desea administrar en ese momento 
                oGestorFactura._Factura = factura;

                //Muestra en el dgvDetalleFactura los detalles de la compra que se esta realizando en ese momento
                string[] lineaFactura = { oDetalleFactura.Id.ToString(),
                                         this.mskCodigoProduto.Text,
                                         this.txtDescripcionProducto.Text,
                                         oDetalleFactura.Cantidad.ToString(),
                                         //Pregunta si se desea pagar el producto en dolar o colones,
                                         //dependiendo de cual, se muestra los costos respectivos de cada moneda
                                         rbDolar.Checked? "$ " + oDetalleFactura.Producto.PrecioDolar.ToString("0.00") :
                                          "₡ " + oDetalleFactura.Producto.PrecioColon.ToString("0.00")
                                         };
                this.dgvDetalleFactura.Rows.Add(lineaFactura);
                
                //Calcula los montos de la factura que se esta realizando en ese momento 
                CalcularMontos();
                //Limpia los campos que estan relacionados con el producto que se desea comprar en ese momento 
                this.mskCantidad.Text = "";
                this.txtDescripcionProducto.Text = "";
                this.txtExistencia.Text = "";
                this.mskCodigoProduto.Text = "";
                txtPrecio.Text = "";
                mskCodigoProduto.Focus();

                //Se registra un evento indicando que se ha agregado un producto a la compra 
                _MyLogControlEventos.InfoFormat("Se agregada un producto a la compra");
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

        private void CalcularMontos()
        {
            //Dependiendo de la moneda en la que se desea realizar la compra,
            //Se realizan los calculos de los costos totales de cada producto 
            //que se compro en la factura o compra que se esta realizando en ese momento
            //Luego muestra en la interfaz los costos de ese momento 
            if (rbDolar.Checked)
            {
                oGestorFactura.FijarTotalDolares();
                this.txtSubtotalDolar.Text = "$ " + oGestorFactura.GetSubTotalDolares().ToString("0.00");
                this.txtImpuestoDolar.Text = "$ " + oGestorFactura.GetImpuestoDolares().ToString("0.00");
                this.txtTotalDolar.Text = "$ " + oGestorFactura._Factura.TotalDolares.ToString("0.00");
            }
            else
            {
                oGestorFactura.FijarTotalColones();
                this.txtSubtotalColon.Text = "₡ " + oGestorFactura.GetSubTotalColones().ToString("0.00");
                this.txtImpuestoColon.Text = "₡ " + oGestorFactura.GetImpuestoColones().ToString("0.00");
                this.txtTotalColon.Text = "₡ " + oGestorFactura._Factura.TotalColones.ToString("0.00");
            }
        }

        private void frmFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se registra un evento indicando que se termino el proceso de facturación 
            _MyLogControlEventos.InfoFormat("Se cierra Proceso de Facturación");
        }
    }
}
