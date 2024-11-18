using appProyecto.Util;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI.Reportes
{
    public partial class frmReporteDeVenta : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteDeVenta()
        {
            InitializeComponent();
        }

        private void frmReporteDeVenta_Load(object sender, EventArgs e)
        {
            try
            {
                //Registra un evento indicando que se ingreso al reporte de ventas 
                _MyLogControlEventos.InfoFormat("Se accedió a Reporte de Ventas");
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

        private void bnMostrarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReporteDeVentaTableAdapter.Fill(this.DSReporteDeVentas.ReporteDeVenta, dtpFechaInicial.Value, dtpFechaFinal.Value);
                this.reportViewer1.RefreshReport();

                //Registra un evento indicando que se muestran los reportes de venta
                _MyLogControlEventos.InfoFormat("Se muestra los Reportes de Ventas");
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

        private void frmReporteDeVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Registra un evento indicando que se termina el reporte de venta
            _MyLogControlEventos.InfoFormat("Se cerro Reporte de Ventas");
        }
    }
}
