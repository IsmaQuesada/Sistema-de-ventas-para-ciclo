using appProyecto.Layers.DAL;
using appProyecto.Util;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI.Reportes
{
    public partial class frmReporteUsuariosPorFecha : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteUsuariosPorFecha()
        {
            InitializeComponent();
        }

        private void frmReporteUsuariosPorFecha_Load(object sender, EventArgs e)
        {
            try
            {
                //Registra un evento indicando que se ingreso al reporte de Usuarios 
                _MyLogControlEventos.InfoFormat("Se accedió a Reporte de Usuarios");
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

        private void bnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    UsuarioTableAdapter.Connection = db.Conexion as System.Data.SqlClient.SqlConnection;

                    // TODO: This line of code loads data into the 'DSReportes.Usuario' table. You can move, or remove it, as needed.
                    this.UsuarioTableAdapter.Fill(this.DSReportes.Usuario, dtpFechaInicial.Value, dtpFechaFinal.Value);
                }

                this.reportViewer1.RefreshReport();

                //Registra un evento indicando que se muestran los reportes de usuarios
                _MyLogControlEventos.InfoFormat("Se muestran los Usuarios");
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

        private void frmReporteUsuariosPorFecha_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Registra un evento indicando que se termina el reporte de usuarios
            _MyLogControlEventos.InfoFormat("Se cerro Reporte de Usuarios");
        }
    }
}
