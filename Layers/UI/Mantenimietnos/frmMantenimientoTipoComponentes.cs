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
    public partial class frmMantenimientoTipoComponentes : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoTipoComponentes()
        {
            InitializeComponent();
        }

        private void frmMantenimientoTipoComponentes_Load(object sender, EventArgs e)
        {
            try
            {
                //Prepara el dgvTipoComponente para recibir la fuente de datos 
                Preparar_dgvTipoComponente();
                //Refresca los datos del dgvTipoComponente
                Refrescar();

                //Se registra un evento indicando que se accedió al mantenimiento de tipo componentes 
                _MyLogControlEventos.InfoFormat("Se accedió a Mantenimiento de Tipo Componentes");
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

        private void Preparar_dgvTipoComponente()
        {
            //Prepara el dgvTipoComponente para que los datos se muestren de la mejor manera 
            dgvTipoComponente.ClearSelection();
            dgvTipoComponente.AutoGenerateColumns = false;
            dgvTipoComponente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Refrescar()
        {
            //Si los Tipos de componente obtenidos de la base de datos son menores que cero, no se agregan al dgvTipoComponente 
            if (TipoComponenteLN.ObtenerTiposComponente().Count > 0)
            {
                //Obtiene todos los Tipos de componente de la base de datos y los muestra en el dgvTipoComponente 
                dgvTipoComponente.DataSource = TipoComponenteLN.ObtenerTiposComponente();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            //Limpias los campos
            txtID.Clear();
            txtDescripcion.Clear();

            //Si hay datos en el dgvTipoComponente,
            //quita la seleccion al dato que se este seleccionando en ese momento 
            if (dgvTipoComponente.DataSource != null)
            {
                dgvTipoComponente.CurrentRow.Selected = false;
            }
        }

        private void BorrarItem()
        {
            // DataBoundItem retorna el objeto seleccionado en el grid
            //Realiza el Casteo del objeto que se necesita crear 
            var tipo =
                 (TipoComponente)this.dgvTipoComponente.SelectedRows[0].DataBoundItem;


            if (tipo != null) //Si el objeto obtenido no es nulo 
            {
                //Borra el tipo de componente seleccionado, de la base de datos 
                TipoComponenteLN logica = new TipoComponenteLN();
                logica.Eliminar(tipo.Id);
            }
        }

        private void dvgTipoComponente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (dgvTipoComponente.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    //Realiza el Casteo del objeto que se necesita crear 
                    var tipo = (TipoComponente)dgvTipoComponente.SelectedRows[0].DataBoundItem;

                    //Muestra los datos del Tipo de componente que se selecciono en el dgvTipoComponente 
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

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones necesarias para poder guardar un Tipo de componente en la base de datos 
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe de ingresar una descripción para el tipo de componente",
                   "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtDescripcion.Focus();
                return;
            }

            try
            {
                //Obtiene los datos de los campos,
                //para crear el tipo de componente que se ingresara a la base de datos
                TipoComponente tipo = new TipoComponente();
                tipo.Descripcion = txtDescripcion.Text;

                //Guarda el tipo de componente creado en la base de datos 
                TipoComponenteLN logica = new TipoComponenteLN();
                logica.Guardar(tipo);

                //Refresca los datos mostrados en el dgvTipoComponente 
                Refrescar();

                //Se registra un evento indicando que se guardo un tipo de componente en la base de datos 
                _MyLogControlEventos.InfoFormat("Se guardo un Tipo Componente");
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
            //Se indica que se debe seleccionar un tipo de componente del dgvTipoComponente si desea actualizar un tipo de componente  
            if (dgvTipoComponente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el Tipo de componente que desea Actualizar!",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //Obtiene los nuevos datos del tipo de componente que se desea actualizar 
                TipoComponente tipo = new TipoComponente();
                tipo.Id = int.Parse(txtID.Text);
                tipo.Descripcion = txtDescripcion.Text;

                //Se actualiza el tipo de componente seleccionado en la base de datos 
                TipoComponenteLN logica = new TipoComponenteLN();
                logica.Guardar(tipo);

                //Refresca los datos del dgvTipoComponente 
                Refrescar();

                //Se registra un evento indicando que se actualizo un tipo de componente 
                _MyLogControlEventos.InfoFormat("Se actualizo un Tipo Componente");
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
                //Se indica que se debe seleecionar un tipo de componente del dgvTipoComponente si desea borrar un tipo de componente  
                if (dgvTipoComponente.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar el Tipo de componente que desea Borrar!",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Pregunta nuevamente si desea borrar el tipo de componente 
                var r = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    //Borra el tipo de componente 
                    BorrarItem();
                    //Refresca los datos del dgvTipoComponente 
                    Refrescar();

                    MessageBox.Show("Tipo de componente borrado con éxito :) ");
                }

                //Se registra un evento indicando que se borro un tipo de componente de la base de datos  
                _MyLogControlEventos.InfoFormat("Se borro un Tipo Componente");
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

        private void frmMantenimientoTipoComponentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se registra un evento indicando que se termino el mantenimiento de tipos de componente 
            _MyLogControlEventos.InfoFormat("Se cerro Mantenimiento de Tipo Componentes");
        }
    }
}
