using System;
using System.Drawing;
using appProyecto.Layers.BLL;
using System.Windows.Forms;
using System.IO;
using log4net;
using System.Text;
using System.Reflection;
using appProyecto.Util;
using System.Data.SqlClient;
using appProyecto.Layers.Entidades.DTO;
using System.Collections.Generic;
using System.Linq;

namespace appProyecto.Layers.UI
{
    public partial class frmPrepararProductos : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmPrepararProductos()
        {
            InitializeComponent();
        }

        private void CargarComboTipoProductos()
        {
            //Obtiene los tipos de producto disponibles en la base de datos 
            cmbTipoProducto.DataSource = BLL.TipoProductoLN.ObtenerTipoProductos();
            //Muestra solamente la descripcion en el combo 
            cmbTipoProducto.DisplayMember = "Descripcion";
            //El valor obtenido por medio del combo es el Id del producto 
            cmbTipoProducto.ValueMember = "Id";
            //Selecciona el indice -1 del combo 
            cmbTipoProducto.SelectedIndex = -1;
        }

        private void CargarComboFabricantes()
        {
            //Obtiene los fabricantes de productos disponibles en la base de datos 
            cmbFabricante.DataSource = BLL.FabricanteProductoLN.ObtenerFabricantes();
            //Muestra solamente la descripcion en el combo 
            cmbFabricante.DisplayMember = "Descripcion";
            //El valor obtenido por medio del combo es el Id del fabricante  
            cmbFabricante.ValueMember = "Id";
            //Selecciona el indice -1 del combo 
            cmbFabricante.SelectedIndex = -1;
        }

        private void Preparar_dgvProducto()
        {
            //Prepara el dgvProducto para que los datos se muestren de la mejor manera 
            dgvProducto.ClearSelection();
            dgvProducto.AutoGenerateColumns = false;
            dgvProducto.RowTemplate.Height = 120;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Refrescar()
        {
            //Si los productos obtenidos de la base de datos son menores que cero, no se agregan al dgvProducto 
            if (ProductoLN.ObtenerTodos().Count > 0)
            {
                //Obtiene todos los productos de la base de datos y los muestra en el dgvProducto 
                dgvProducto.DataSource = ProductoLN.ObtenerTodos();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            //Limpia los campos, combos y la imagen mostrados 
            txtID.Clear();
            txtDescripcion.Clear();
            cmbTipoProducto.SelectedIndex = -1;
            cmbFabricante.SelectedIndex = -1;
            nudExistencia.Value = 1;
            txtPrecio.Clear();
            pbImagen.Image = Properties.Resources.photo;
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.Tag = null;

            //Ya no es visible el groupBox para ensamblar componentes
            gbComponentes.Visible = false;

            //Si hay datos en el dgvProducto,
            //quita la seleccion al dato que se este seleccionando en ese momento 
            if (dgvProducto.DataSource != null)
            {
                dgvProducto.CurrentRow.Selected = false;
            }
        }

        private void frmPrepararProductos_Load(object sender, EventArgs e)
        {
            try
            {
                Util.Utilitarios.CultureInfo();

                //Prepara el dgvProducto para recibir la fuente de datos 
                Preparar_dgvProducto();

                //Llena el combo de Tipo Productos
                CargarComboTipoProductos();
                //Llena el combo de Fabricantes
                CargarComboFabricantes();

                //Refresca los datos del dgvProducto
                Refrescar();

                //Registra un evento indicando que se ingreso al proceso de Producción
                _MyLogControlEventos.InfoFormat("Se accedió a Proceso de Producción");
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

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            decimal precio = 0.0m;
            try
            {
                //Validaciones necesarias para poder guardar un producto a la base de datos 
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Es necesario que ingrese una descripción del componente",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus();
                    return;
                }

                if (cmbTipoProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el tipo de producto",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoProducto.Focus();
                    return;
                }

                if (cmbFabricante.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el fabricante del producto",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbFabricante.Focus();
                    return;
                }

                if (decimal.TryParse(txtPrecio.Text, out precio) == false)
                {
                    MessageBox.Show("El precio es un dato requerido y debe ser numérico",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecio.Clear();
                    txtPrecio.Focus();
                    return;
                }

                if (pbImagen.Tag == null)
                {
                    MessageBox.Show("Es necesario que ingrese una imagen del producto",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Obtiene los datos de los campos,
                //para crear el producto que se ingresara a la base de datos
                Producto p = new Producto()
                {
                    Descripcion = txtDescripcion.Text,
                    IdTipoProducto = (int)cmbTipoProducto.SelectedValue,
                    IdFabricanteProducto = (int)cmbFabricante.SelectedValue,
                    Existencia = (int)nudExistencia.Value,
                    PrecioColon = decimal.Parse(txtPrecio.Text),
                    ImagenProducto = (byte[])this.pbImagen.Tag
                };

                //Guarda el producto creado en la base de datos 
                var logica = new BLL.ProductoLN();
                logica.Guardar(p);

                //Refresca los datos mostrados en el dgvProducto 
                Refrescar();

                //Se registra un evento indicado que se ha guardado un producto en la base de datos
                _MyLogControlEventos.InfoFormat("Se guarda un Producto");
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

        private void toolStripBtnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia todos los campos 
            LimpiarCampos();
        }

        private void dvgProducto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    //Realiza el Casteo del objeto que se necesita crear
                    var producto = (Producto)dgvProducto.SelectedRows[0].DataBoundItem;
                    txtID.Text = producto.Id.ToString();
                    txtDescripcion.Text = producto.Descripcion;
                    cmbTipoProducto.SelectedValue = producto.IdTipoProducto;
                    cmbFabricante.SelectedValue = producto.IdFabricanteProducto;
                    nudExistencia.Value = producto.Existencia;
                    txtPrecio.Text = producto.PrecioColon.ToString("0.00");
                    pbImagen.Image = new Bitmap(new MemoryStream(producto.ImagenProducto));
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbImagen.Tag = producto.ImagenProducto;

                    //Verifica si el producto es de tipo bicileta
                    if (cmbTipoProducto.Text.Equals("Bicicleta", StringComparison.CurrentCultureIgnoreCase))
                    {
                        //Si el producto es una bicicleta, se mostrara el gbComponentes que permite administrar los componentes de la bicicleta 
                        gbComponentes.Visible = true;
                    }
                    else
                    {
                        // Si el producto no es una bicicleta, desaparece gbComponentes 
                        gbComponentes.Visible = false;
                    }
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

        private void pbImagen_Click(object sender, EventArgs e)
        {
            try
            {
                //Se muestra un OpenFileDialog para seleccionar una imagen para el producto 
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                //Indica los formatos de las imagenes permitidas 
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {
                   
                    this.pbImagen.ImageLocation = opt.FileName;
                    //Se muestra la imagen en el PictureBox
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbImagen.Tag = (byte[])cadenaBytes;

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

        private void toolStripBtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se indica que se debe seleccionar un producto del dgvProducto si desea actualizar un producto  
                if (dgvProducto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar el producto que desea Actualizar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Obtiene los nuevos datos del producto que se desea actualizar
                Producto p = new Producto()
                {
                    Id = int.Parse(txtID.Text),
                    Descripcion = txtDescripcion.Text,
                    IdTipoProducto = (int)cmbTipoProducto.SelectedValue,
                    IdFabricanteProducto = (int)cmbFabricante.SelectedValue,
                    Existencia = (int)nudExistencia.Value,
                    PrecioColon = decimal.Parse(txtPrecio.Text),
                    ImagenProducto = (byte[])this.pbImagen.Tag
                };

                //Se actualiza el producto seleccionado en la base de datos 
                var logica = new BLL.ProductoLN();
                logica.Guardar(p);

                //Refresca los datos del dgvProducto 
                Refrescar();

                //Se registra un evento indicando que se actualizo un producto 
                _MyLogControlEventos.InfoFormat("Se actualiza un Producto");
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

        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se indica que se debe seleecionar un producto del dgvProducto si desea borrar un producto  
                if (dgvProducto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar el producto que desea Borrar!",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Pregunta nuevamente si desea borrar el producto 
                var r = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    // Borra el producto
                    BorrarItem();

                    //Refresca los datos del dgvProducto 
                    Refrescar();

                    MessageBox.Show("Producto Borrado con exito :)");
                }

                //Se registra un evento indicando que se borro un producto de la base de datos  
                _MyLogControlEventos.InfoFormat("Se borra un Producto");
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

        private void BorrarItem()
        {
            // DataBoundItem retorna el objeto seleccionado en el grid
            //Realiza el Casteo del objeto que se necesita crear 
            var producto = (Producto)dgvProducto.SelectedRows[0].DataBoundItem;

            if (producto != null)//Si el objeto obtenido no es nulo 
            {
           
                ProductoLN logica = new ProductoLN();

                //Pregunta si el producto es una bicicleta, esto para realizar su rescpectivo borrado en estos casos

                if (producto.TipoProducto.Descripcion.Equals("Bicicleta", StringComparison.CurrentCultureIgnoreCase))
                    logica.EliminarBicicleta(producto.Id);      //Borra el producto seleccionado, de la base de datos 
                else
                    logica.Eliminar(producto.Id);      //Borra el producto seleccionado, de la base de datos 
            }
        }

        private void bnEnsamblaje_Click(object sender, EventArgs e)
        {
            //Comprueba si la bicicleta es de ruta 
            bool ruta = rbRuta.Checked;
            //Crea una lista de componentes
            List<Componente> listaComponentes = null;

            try
            {
                //verificamos que exista un objeto seleccionado
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    //obtiene el objeto del dgvProducto y lo almacena en esa variable
                    Producto producto = (Producto)
                        dgvProducto.SelectedRows[0].DataBoundItem;

                    //Pregunta si el producto es una bicicleta
                    if (producto.TipoProducto.Descripcion.Equals("Bicicleta"))
                    {
                        //Obtiene los componentes de esa bicicleta 
                        listaComponentes = Producto_ComponenteLN.ObtenerComponentes(producto.Id);

                        //Si se quiere agregar componentes de ruta, y este ya tiene componentes de montaña, no permite agregarle componentes de ruta
                        if (listaComponentes.Exists(c => c.TipoBicicleta.Equals("Montaña", StringComparison.CurrentCultureIgnoreCase)) && ruta)
                        {
                                MessageBox.Show("Esta bicicleta es de Montaña, no es posible ensamblarle componentes de Ruta",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                        }

                        //Si se quiere agregar componentes de Montaña, y este ya tiene componentes de ruta, no permite agregarle componentes de Montaña
                        if (listaComponentes.Exists(c => c.TipoBicicleta.Equals("Ruta", StringComparison.CurrentCultureIgnoreCase)) && ruta == false)
                        {
                                MessageBox.Show("Esta bicicleta es de Ruta, no es posible ensamblarle componentes de Montaña",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                        }
                    }

                    //construcción de la instancia del formulario
                    var frm = new frmProductoPorComponente();

                    //asignando el producto seleccionado al atributo del formulario
                    frm.Bicicleta = producto;

                    //asigna el tipo de bicicleta seleccionada 
                    frm.TipoBici = ruta ? ruta : false;

                    //mostramos el form con el showDialog()
                    frm.ShowDialog();
                }
                else
                {
                    //Debe seleccionar una bicicleta, para poder ensamblarle componentes 
                    MessageBox.Show("Debe seleccionar la bicicleta que desea ensamblar",
                       "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void frmPrepararProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Registra un evento indicando que se termino el proceso de Producción
            _MyLogControlEventos.InfoFormat("Se cerro Proceso de Producción");
        }
    }
}
