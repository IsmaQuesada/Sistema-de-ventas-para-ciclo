using appProyecto.Layers.BLL;
using appProyecto.Layers.Entidades.DTO;
using appProyecto.Util;
using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmMantenimientoComponentes : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoComponentes()
        {
            InitializeComponent();
        }

        private void frmMantenimientoEnsamblaje_Load(object sender, EventArgs e)
        {
            try
            {
                //Prepara el data griend view para recibir la fuente de datos
                Preparar_DgvComponente();
                //Carga los tipos de componente en el cmbTipoComponente
                CargarTiposComponente();
                //Carga los tipos de bicicleta, para elegir a cual tipo de bicicleta esta destinada el componente
                CargarTiposBicicleta();
                //Carga los Fabricante de componentes que hay disponibles 
                CargarFabricantes();
                //Obtiene los datos necesarios para el DgvComponentes
                Refrescar();

                //Registra un evento indicando que se ingreso al mantenimiento de componentes
                _MyLogControlEventos.InfoFormat("Se accedió a Mantenimiento de Componentes");
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), ex));
                //Registra el error 
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_DgvComponente()
        {
            //Se encarga de preparar el DgvComponentes para recibir y mostrar los datos necesarios
            dgvComponentes.ClearSelection();
            dgvComponentes.AutoGenerateColumns = false;
            dgvComponentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Refrescar()
        {
            //Pregunta si hay componentes disponibles, sino hay, no carga datos dentro del dgvComponentes
            if (ComponenteLN.ObtenerTodos().Count > 0)
            {
                //Obtiene los datos de todos los componentes de la base de datos 
                dgvComponentes.DataSource = ComponenteLN.ObtenerTodos();
                LimpiarCampos();
            }
        }

        
        private void LimpiarCampos()
        {
            //Limpia los campos de texto y combos
            txtCodigo.Clear();
            cmbFabricante.SelectedIndex = -1;
            cmbTipoComponente.SelectedIndex = -1;
            txtDescripcion.Clear();
            cmbTipoBici.SelectedIndex = -1;

            //Si hay datos en el dgvComponenets, quita la selección a un dato del dgvComponentes
            if (dgvComponentes.DataSource != null)
            {
                dgvComponentes.CurrentRow.Selected = false;
            }
        }

        private void CargarTiposComponente()
        {
            //Carga los Tipos de componente disponibles
            cmbTipoComponente.DataSource = BLL.TipoComponenteLN.ObtenerTiposComponente();
            //Muestra solamente la descripcion en el combo
            cmbTipoComponente.DisplayMember = "Descripcion";
            //El valor que se obtiene por medio del combo, es el Id de tipo de componente
            cmbTipoComponente.ValueMember = "Id";
            //Selecciona el indice -1 del combo 
            cmbTipoComponente.SelectedIndex = -1;
        }

        private void CargarTiposBicicleta()
        {
            //Añade los tipos de bicileta disponibles
            cmbTipoBici.Items.Add("Ruta");
            cmbTipoBici.Items.Add("Montaña");
            cmbTipoBici.SelectedIndex = -1;
        }

        private void CargarFabricantes()
        {
            //Carga los fabricante de componenentes disponibles 
            cmbFabricante.DataSource = BLL.FabricanteComponenteLN.ObtenerFabricantes();
            //Muestra solamente la descripcion en el combo
            cmbFabricante.DisplayMember = "Descripcion";
            //El valor que se obtiene por medio del combo, es el Id del fabricante
            cmbFabricante.ValueMember = "Id";
            cmbFabricante.SelectedIndex = -1;
        }

        private void BorrarItem()
        {
            // DataBoundItem retorna el objeto seleccionado en el grid
            //Realiza el Casteo del objeto que se necesita crear 
            var comp = (Componente)dgvComponentes.SelectedRows[0].DataBoundItem;

            if (comp != null)
            {
                //Si el objeto obtenido no es nulo, lo elimina de la Base de datos
                ComponenteLN logica = new ComponenteLN();
                logica.Eliminar(comp.Id);
            }
        }

        private void dvgComponente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (dgvComponentes.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    //Realiza el Casteo del objeto que se necesita crear 
                    var comp = (Componente)dgvComponentes.SelectedRows[0].DataBoundItem;

                    //Obtiene los datos del objeto y los muestra en la interfaz 
                    txtCodigo.Text = comp.Id.ToString();
                    txtDescripcion.Text = comp.Descripcion;
                    cmbTipoComponente.SelectedValue = comp.TipoComponente.Id;
                    cmbFabricante.SelectedValue = comp.Fabricante_Componente.Id;
                    cmbTipoBici.SelectedItem = comp.TipoBicicleta;
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

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones necesarias para poder guardar un componente en la Base de datos 
            if (cmbFabricante.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el fabricante del componente",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbFabricante.Focus();
                return;
            }

            if (cmbTipoComponente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de componente",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTipoComponente.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Es necesario que ingrese una descripción del componente",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return;
            }

            if (cmbTipoBici.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de bicicleta para el componente",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTipoBici.Focus();
                return;
            }

            try
            {
               Componente c = new Componente();

                //Se crea el objeto que se almacenara en la DB
                c.Descripcion = txtDescripcion.Text;
                c.IdTipoComponente = (int)cmbTipoComponente.SelectedValue;
                c.IdFabricante = (int)cmbFabricante.SelectedValue;
                c.TipoBicicleta = cmbTipoBici.Text;

                // llama al metodo para guardar la informacion en la DB
                var logica = new BLL.ComponenteLN();
                logica.Guardar(c);
                Refrescar();

                //Registra un evento indicando que se gurado un componente 
                _MyLogControlEventos.InfoFormat("Se guardo un Componente");
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
                //Debe selecciona en el DgvComponentes el componente que desea borrar
                if (dgvComponentes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar el componente que desea Borrar!",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Pregunta nuevamente si desea borrar el componente
                var r = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    BorrarItem();
                    Refrescar();
                    MessageBox.Show("Componente Borrado con exito :)");
                }

                //Se registra un envento indicando que se borro un componente de la base de datos 
                _MyLogControlEventos.InfoFormat("Se borro un Componente");
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
            //Limpias los campos 
            LimpiarCampos();
        }

        private void toolStripBtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Indica que debe seleccionar un componente del DgvComponentes, para poder actualizarlo 
                if (dgvComponentes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar el componente que desea Actualizar!",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

               Componente c = new Componente();

                //Se crea el objeto con los nuevos datos que se actualizaran en la DB
                c.Id = int.Parse(txtCodigo.Text);
                c.Descripcion = txtDescripcion.Text;
                c.IdTipoComponente = (int)cmbTipoComponente.SelectedValue;
                c.IdFabricante = (int)cmbFabricante.SelectedValue;
                c.TipoBicicleta = cmbTipoBici.Text;

                // llama al metodo para guardar la informacion en la DB
                var logica = new BLL.ComponenteLN();
                logica.Guardar(c);
                Refrescar();

                //Se registra un evento indicando que se actualizo un componente
                _MyLogControlEventos.InfoFormat("Se actualizo un Componente");
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

        private void frmMantenimientoComponentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Registra un evento indicando que se a terminado el mantenimiento de componentes 
            _MyLogControlEventos.InfoFormat("Se cerro Mantenimiento de Componentes");
        }
    }
}
