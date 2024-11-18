using appProyecto.Layers.BLL;
using appProyecto.Layers.Entidades.DTO;
using appProyecto.Layers.DAL;
using appProyecto.Util;
using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmIniciarSesion : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos"); 

        public frmIniciarSesion()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Crea un objeto usuario
            Usuario usuario;

            //Obtiene una instancia del FrmPrincipal por medio de singleton 
            frmMenuPrincipal frmMenu = FrmMenuPrincipalSingleton.GetInstance();

            try
            {
                //Verifica si ingreso la cédula
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Debe digitar la cédula del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    return;
                }

                //Obtiene el usuario por medio de su número de cédula 
                usuario = UsuarioLN.ObtenerUsuarioPorCedula(txtUsuario.Text);

                // si el objeto esta vacío, no existe el usuario en el sistema 
                if (usuario == null)
                {
                    var r = MessageBox.Show("El Usuario ingresado no existe, verifique la cédula ingresada", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    return;
                }

                //Verifica si ingreso la contraseña
                if (string.IsNullOrEmpty(txtContrasena.Text))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContrasena.Focus();
                    return;
                }

                //Verifica si la contraseña ingresada es igual a la registrada por el usuario 
                if (!usuario.Contrasennia.Equals(txtContrasena.Text))
                {
                    var r = MessageBox.Show("La contraseña que ha ingresado es incorrecta", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                toolStripPbBarra.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    this.toolStripPbBarra.Value += 10;
                    this.sttBarraInferior.Refresh();
                }

                //Envia el usuario que inicio sección, al framePrincipal 
                frmMenu.miUsuario = usuario;
                //Verifica la seccion
                frmMenu.VerficarSeccion();

                Close();
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
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el frame 
            Close();
        }

        private void frmIniciarSeccion_Load(object sender, EventArgs e)
        {
            try
            {
                //Se registra un evento indicando que se accedio al login 
                _MyLogControlEventos.InfoFormat("Login iniciado");
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
