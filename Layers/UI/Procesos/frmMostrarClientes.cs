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
    public partial class frmMostrarClientes : Form
    {
        //Propiedad que almacena el cliente que se seleccionara en la ventana 
        public Usuario Cliente { get; private set; } = null;
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmMostrarClientes()
        {
            InitializeComponent();
        }

        private void Preparar_dgvClientes()
        {
            //Se encarga de preparar el dgvClientes para recibir y mostrar los datos necesarios
            dgvClientes.ClearSelection();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.RowTemplate.Height = 100;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Refrescar()
        {
            //Pregunta si hay clientes disponibles, si no hay, no carga datos dentro del dgvClientes
            if (UsuarioLN.ObtenerClientes().Count > 0)
            {
                //Obtiene los datos de todos los clientes en la base de datos y los muestra en el dgvClientes
                dgvClientes.DataSource = UsuarioLN.ObtenerClientes();
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            //Si se cierra la ventana, la "resultado" de la ventana es "Cancel"
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dvgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClientes.RowCount > 0 && dgvClientes.SelectedRows.Count > 0)
                {
                    if (dgvClientes.CurrentCell.Selected)
                    {
                        //Fija en la propiedad Cliente el cliente que se selecciono en el dgvClientes
                        Cliente = dgvClientes.SelectedRows[0].DataBoundItem as Usuario;
                        //El resultado de la ventana es un "OK"
                        this.DialogResult = DialogResult.OK;
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

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Prepara el dgvClientes para recibir los datos 
                Preparar_dgvClientes();
                //Refresca los datos del dgvClientes
                Refrescar();
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
    }
}
