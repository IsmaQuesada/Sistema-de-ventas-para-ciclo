using appProyecto.Layers.BLL;
using appProyecto.Layers.Entidades;
using appProyecto.Util;
using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmMantenimientoTipoProductos : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoTipoProductos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoTipoProductos_Load(object sender, EventArgs e)
        {
            try
            {
                //Prepara el dgvTipoProductos para recibir la fuente de datos 
                Preparar_dgvTipoProducto();
                //Refresca los datos del dgvTipoProductos
                Refrescar();

                //Se registra un evento indicando que se accedió al mantenimiento de tipo productos 
                _MyLogControlEventos.InfoFormat("Se accedió a Mantenimiento de Tipo Productos");
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

        private void Preparar_dgvTipoProducto()
        {
            //Prepara el dgvTipoProducto para que los datos se muestren de la mejor manera 
            dgvTipoProducto.ClearSelection();
            dgvTipoProducto.AutoGenerateColumns = false;
            dgvTipoProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void BorrarItem()
        {
            // DataBoundItem retorna el objeto seleccionado en el grid
            //Realiza el Casteo del objeto que se necesita crear 
            var tipo =
                 (TipoProducto)this.dgvTipoProducto.SelectedRows[0].DataBoundItem;

            if (tipo != null) //Si el objeto obtenido no es nulo 
            {
                //Borra el tipo de producto seleccionado, de la base de datos 
                TipoProductoLN logica = new TipoProductoLN();
                logica.Eliminar(tipo.Id);
            }
        }

        private void Refrescar()
        {
            //Si los Tipos de producto obtenidos de la base de datos son menores que cero, no se agregan al dgvTipoProducto 
            if (TipoProductoLN.ObtenerTipoProductos().Count > 0)
            {
                //Obtiene todos los Tipos de producto de la base de datos y los muestra en el dgvTipoProducto 
                dgvTipoProducto.DataSource = TipoProductoLN.ObtenerTipoProductos();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            //Limpias los campos
            txtID.Clear();
            txtDescripcion.Clear();

            //Si hay datos en el dgvTipoProducto,
            //quita la seleccion al dato que se este seleccionando en ese momento 
            if (dgvTipoProducto.DataSource != null)
            {
                dgvTipoProducto.CurrentRow.Selected = false;
            }
        }

        private void toolStripBtnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia todos los campos 
            LimpiarCampos();
        }

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones necesarias para poder guardar un Tipo de producto en la base de datos 
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe de ingresar una descripción para el tipo de producto",
                   "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtDescripcion.Focus();
                return;
            }

            try
            {
                //Obtiene los datos de los campos,
                //para crear el tipo de producto que se ingresara a la base de datos
                TipoProducto tipo = new TipoProducto();
                tipo.Descripcion = txtDescripcion.Text;

                //Guarda el tipo de producto creado en la base de datos 
                TipoProductoLN logica = new TipoProductoLN();
                logica.Guardar(tipo);

                //Refresca los datos mostrados en el dgvTipoProducto 
                Refrescar();

                //Se registra un evento indicando que se guardo un tipo de producto en la base de datos 
                _MyLogControlEventos.InfoFormat("Se guardo un Tipo Producto");
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

        private void toolStripBtnActualizar_Click(object sender, EventArgs e)
        {
            //Se indica que se debe seleccionar un tipo de producto del dgvTipoProducto si desea actualizar un tipo de producto  
            if (dgvTipoProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Producto que desea Actualizar!",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //Obtiene los nuevos datos del tipo de producto que se desea actualizar 
                TipoProducto tipo = new TipoProducto();
                tipo.Id = int.Parse(txtID.Text);
                tipo.Descripcion = txtDescripcion.Text;

                //Se actualiza el tipo de producto seleccionado en la base de datos 
                TipoProductoLN logica = new TipoProductoLN();
                logica.Guardar(tipo);

                //Refresca los datos del dgvTipoProducto 
                Refrescar();

                //Se registra un evento indicando que se actualizo un tipo de producto 
                _MyLogControlEventos.InfoFormat("Se actualizo un Tipo Producto");
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
            //Se indica que se debe seleecionar un tipo de producto del dgvTipoProducto si desea borrarlo de la base de datos 
            if (dgvTipoProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Producto que desea Borrrar!",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //Pregunta nuevamente si desea borrar el tipo de producto 
                var r = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    //Borra el tipo de producto 
                    BorrarItem();
                    //Refresca los datos del dgvTipoProducto 
                    Refrescar();

                    MessageBox.Show("Tipo de Producto borrado con éxito :) ");
                }

                _MyLogControlEventos.InfoFormat("Se borro un Tipo Producto");
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

        private void dvgTipoProducto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (dgvTipoProducto.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    //Realiza el Casteo del objeto que se necesita crear 
                    var tipo = (TipoProducto)dgvTipoProducto.SelectedRows[0].DataBoundItem;

                    //Muestra los datos del Tipo de producto que se selecciono en el dgvTipoProducto 
                    txtID.Text = tipo.Id.ToString();
                    txtDescripcion.Text = tipo.Descripcion;
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

        private void frmMantenimientoTipoProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MyLogControlEventos.InfoFormat("Se cerro Mantenimiento de Tipo Productos");
        }
    }
}
