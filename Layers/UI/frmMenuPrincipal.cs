using appProyecto.Layers.Entidades.DTO;
using appProyecto.Util;
using log4net;
using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmMenuPrincipal : Form
    {
        //Propiedad que recibe el usuario que acaba de iniciar sesion
        public Usuario miUsuario { get; set; }

        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmMenuPrincipal()
        {
            InitializeComponent();
            PersonalizarFrame();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se registra un evento indicando que se termino el programa 
            _MyLogControlEventos.InfoFormat("Se ha cerrado el Programa");
            Close();
        }

        public void VerficarSeccion()
        {
            //Verifica si la propiedad usuario es nula 
            if (miUsuario != null)
            {
                if (miUsuario.TipoUsuario.Descripcion.Equals("Administrador"))
                {
                    //Habilita las opciones disponibles para un usuario de tipo "Administrador"
                    MantenimientosToolStripMenuItem.Enabled = true;
                    ProcesostoolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;

                    //Registra un evento indicando que se inicio sesion como un usuario de tipo "Administrador" 
                    _MyLogControlEventos.InfoFormat("Se iniciado sección como: Administrador");
                }

                if (miUsuario.TipoUsuario.Descripcion.Equals("Mantenimiento"))
                {
                    //Habilita las opciones disponibles para un usuario de tipo "Mantenimiento"
                    MantenimientosToolStripMenuItem.Enabled = true;
                    ProcesostoolStripMenuItem.Enabled = false;
                    reportesToolStripMenuItem.Enabled = false;

                    //Registra un evento indicando que se inicio sesion como un usuario de tipo "Mantenimiento" 
                    _MyLogControlEventos.InfoFormat("Se iniciado sección como: Mantenimiento");
                }

                if (miUsuario.TipoUsuario.Descripcion.Equals("Procesos"))
                {
                    //Habilita las opciones disponibles para un usuario de tipo "Procesos"
                    MantenimientosToolStripMenuItem.Enabled = false;
                    ProcesostoolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = false;

                    //Registra un evento indicando que se inicio sesion como un usuario de tipo "Procesos" 
                    _MyLogControlEventos.InfoFormat("Se iniciado sección como: Procesos");
                }

                if (miUsuario.TipoUsuario.Descripcion.Equals("Reportes"))
                {
                    //Habilita las opciones disponibles para un usuario de tipo "Reporte"
                    MantenimientosToolStripMenuItem.Enabled = false;
                    ProcesostoolStripMenuItem.Enabled = false;
                    reportesToolStripMenuItem.Enabled = true;

                    //Registra un evento indicando que se inicio sesion como un usuario de tipo "Reporte" 
                    _MyLogControlEventos.InfoFormat("Se iniciado sección como: Reportes");
                }
            }
            else //Si es nula, se deshabilitan los mantenimientos, procesos y reporte 
            {
                MantenimientosToolStripMenuItem.Enabled = false;
                ProcesostoolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
            }

            //Deshabilita el boton de iniciar sesion 
            IniciarSeccionToolStripMenuItem.Enabled = false;
            //Habilita el boton de iniciar sesion 
            cerrarSecciónToolStripMenuItem.Enabled = true;
        }


        private void MantenimientoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de mantenimiento de usuarios 
            frmMantenimientosUsuarios frmMantenimientosClientes = new frmMantenimientosUsuarios();
            frmMantenimientosClientes.MdiParent = this;
            frmMantenimientosClientes.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //Se registra un evento indicando que se inicio el programa 
                _MyLogControlEventos.InfoFormat("Se inició el Programa");
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

        private void PersonalizarFrame()
        {
            try
            {
                //Se encarga de añadir el color negro al frm 
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is MdiClient)
                    {
                        ctrl.BackColor = Color.FromArgb(32, 30, 45);
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

        private void MantenimientoTipoComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de Mantenimiento de tipo componenentes 
            frmMantenimientoTipoComponentes frmMantenimientosTipos = new frmMantenimientoTipoComponentes();
            frmMantenimientosTipos.MdiParent = this;
            frmMantenimientosTipos.Show();
        }

        private void MantenimientoComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de Mantenimiento de componenentes 
            frmMantenimientoComponentes frmComponentes = new frmMantenimientoComponentes();
            frmComponentes.MdiParent = this;
            frmComponentes.Show();
        }

        private void TipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de Mantenimiento de tipo de productos 
            frmMantenimientoTipoProductos frmTipoProducto = new frmMantenimientoTipoProductos();
            frmTipoProducto.MdiParent = this;
            frmTipoProducto.Show();
        }

        private void IniciarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de Mantenimiento de iniciar sesion
            frmIniciarSesion frmAcceder = new frmIniciarSesion();
            frmAcceder.MdiParent = this;
            frmAcceder.Show();
        }

        private void CerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            try
            {
                //Pregunta si quiere cerrar la sección
                var r = MessageBox.Show("¿Seguro que quieres cerrar la sesion?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    //Fija nulo la propiedad que almacena el usuario que esta activo ese momento 
                    miUsuario = null;

                    //Vuelve a verificar los permisos del tipo de usuario 
                    VerficarSeccion();
                }

                //Se registra un evento indicando que se cerro la sesion
                _MyLogControlEventos.InfoFormat("Se cerro sesion");

                //Deshabilita el boton de cerrar sesion y habilita el boton de iniciar sesion
                IniciarSeccionToolStripMenuItem.Enabled = true;
                cerrarSecciónToolStripMenuItem.Enabled = false;
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

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de facturación 
            frmFacturacion frmFacturar = new frmFacturacion();
            frmFacturar.MdiParent = this;
            frmFacturar.Show();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de producción
            frmPrepararProductos frmProductos = new frmPrepararProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }
        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de reporte de usuarios 
            Reportes.frmReporteUsuariosPorFecha frmReporteUsuarios = new Reportes.frmReporteUsuariosPorFecha();
            frmReporteUsuarios.MdiParent = this;
            frmReporteUsuarios.Show();
        }

        private void reporteDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el frame de reporte de ventas 
            Reportes.frmReporteDeVenta frm = new Reportes.frmReporteDeVenta();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
