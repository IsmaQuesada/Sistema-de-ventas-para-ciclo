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
    public partial class frmMostrarProductos : Form
    {
        //Propiedad que almacena el producto que se seleccionara en la ventana 
        public Producto Producto { get; private set; } = null;
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmMostrarProductos()
        {
            InitializeComponent();
        }

        private void Preparar_dgvProductos()
        {
            //Se encarga de preparar el dgvProductos para recibir y mostrar los datos necesarios
            dgvProductos.ClearSelection();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.RowTemplate.Height = 100;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Refrescar()
        {
            //Pregunta si hay productos disponibles, si no hay, no carga datos dentro del dgvProductos
            if (ProductoLN.ObtenerTodos().Count > 0)
            {
                //Obtiene los datos de todos los productos en la base de datos y los muestra en el dgvProductos
                dgvProductos.DataSource = ProductoLN.ObtenerTodos();
            }
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Util.Utilitarios.CultureInfo();
                //Prepara el dgvProductos para recibir los datos 
                Preparar_dgvProductos();
                //Refresca los datos del dgvProductos
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

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            //Si se cierra la ventana, la "resultado" de la ventana es "Cancel"
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dvgProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0 && dgvProductos.SelectedRows.Count > 0)
                {
                    if (dgvProductos.CurrentCell.Selected)
                    {
                        //Fija en la propiedad Producto el producto que se selecciono en el dgvProductos
                        Producto = dgvProductos.SelectedRows[0].DataBoundItem as Producto;
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
    }
}
