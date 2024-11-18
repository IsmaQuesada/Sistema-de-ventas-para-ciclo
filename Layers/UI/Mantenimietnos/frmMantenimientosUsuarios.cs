using appProyecto.Layers.BLL;
using appProyecto.Layers.Entidades.DTO;
using appProyecto.Util;
using log4net;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI
{
    public partial class frmMantenimientosUsuarios : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientosUsuarios()
        {
            InitializeComponent();
            //Fija la fecha actual en el dtpFechaNacimiento
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            try
            {
                //Prepara el dgvUsuarios para recibir la fuente de datos 
                Preparar_dgvUsuario();
                //Llena el combo de Tipos de usuarios 
                LlenarCombo();
                //Refresca los datos del dgvUsuarios
                Refrescar();

                //Se registra un evento indicando que se accedió al mantenimiento de usuarios 
                _MyLogControlEventos.InfoFormat("Se accedió a Mantenimiento de Usuarios");
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

        private void Preparar_dgvUsuario()
        {
            //Prepara el dgvUsuarios para que los datos se muestren de la mejor manera 
            dgvUsuarios.ClearSelection();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.RowTemplate.Height = 100;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void LlenarCombo()
        {
            //Obtiene los tipos de usuarios disponibles 
            cmbTipoUsuario.DataSource = BLL.TipoUsuarioLN.ObtenerTipoUsuarios();
            //Muestra solamente la descripcion en el combo 
            cmbTipoUsuario.DisplayMember = "Descripcion";
            //El valor obtenido por medio del combo es el Id del tipo de usuario 
            cmbTipoUsuario.ValueMember = "Id";
            //Selecciona el indice -1 del combo 
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private void Refrescar()
        {
            //Si los usuarios obtenidos de la base de datos son menores que cero, no se agregan al dgvUsuarios 
            if (UsuarioLN.ObtenerUsuarios().Count > 0)
            {
                //Obtiene todos los usuarios de la base de datos y los muestra en el dgvUsuarios 
                dgvUsuarios.DataSource = UsuarioLN.ObtenerUsuarios();
                LimpiarCampos();
            }
        }

        private void BorrarItem()
        {
            // DataBoundItem retorna el objeto seleccionado en el grid
            //Realiza el Casteo del objeto que se necesita crear 
            var client =
                 (Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem;

            if (client != null) //Si el objeto obtenido no es nulo 
            {
                //Borra el usuario seleccionado, de la base de datos 
                UsuarioLN logica = new UsuarioLN();
                logica.Eliminar(client.Cedula);
            }
        }

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                //Validaciones necesarias para poder guardar un usuario a la base de datos 
                if (pbFotografia.Tag == null)
                {
                    MessageBox.Show("Es necesario que ingrese una Fotografía", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("La cédula es requerida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCedula.Focus();
                    return;
                }


                if (string.IsNullOrEmpty(txtNombreCompleto.Text))
                {
                    MessageBox.Show("El nombre es requerido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreCompleto.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Es necesario que ingrese su correo electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCorreo.Focus();
                    return;
                }

                if (cmbTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el tipo de usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtContrasenna.Text))
                {
                    MessageBox.Show("Es necesario que ingrese una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContrasenna.Focus();
                    return;
                }

                //Obtiene los datos de los campos,
                //para crear el usuario que se ingresara a la base de datos
                Usuario usuario = new Usuario()
                {
                    NombreCompleto = txtNombreCompleto.Text,
                    Cedula = txtCedula.Text,
                    Correo = txtCorreo.Text,
                    IdTipoUsuario = (int)cmbTipoUsuario.SelectedValue,
                    Contrasennia = txtContrasenna.Text.Trim(),
                    Fotografia = (byte[])this.pbFotografia.Tag,
                    FechaNacimiento = dtpFechaNacimiento.Value
                };

                //Guarda el usuario creado en la base de datos 
                UsuarioLN logica = new UsuarioLN();
                logica.Guardar(usuario);

                //Refresca los datos mostrados en el dgvUsuarios 
                Refrescar();

                //Se registra un evento indicando que se guardo un usuario en la base de datos 
                _MyLogControlEventos.InfoFormat("Se guardo un Usuario");
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
            //Se indica que se debe seleccionar un usuario del dgvUsuarios si desea actualizar un usuario  
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el usuario que desea Actualizar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //Obtiene los nuevos datos del usuario que se desea actualizar 
                Usuario usuario = new Usuario()
                {
                    NombreCompleto = txtNombreCompleto.Text,
                    Cedula = txtCedula.Text,
                    Correo = txtCorreo.Text,
                    IdTipoUsuario = (int)cmbTipoUsuario.SelectedValue,
                    Contrasennia = txtContrasenna.Text.Trim(),
                    Fotografia = (byte[])this.pbFotografia.Tag,
                    FechaNacimiento = dtpFechaNacimiento.Value
                };

                //Se actualiza el usuario seleccionado en la base de datos 
                UsuarioLN logica = new UsuarioLN();
                logica.Guardar(usuario);

                //Refresca los datos del dgvUsuarios 
                Refrescar();

                //Se registra un evento indicando que se actualizo un usuario 
                _MyLogControlEventos.InfoFormat("Se actualizo un Usuario");
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
                //Se indica que se debe seleecionar un usuario del dgvUsuarios si desea borrar un usuario  
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar el usuario que desea Borrar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Pregunta nuevamente si desea borrar el usuario 
                var r = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    //Borra el usuario 
                    BorrarItem();
                    //Refresca los datos del dgvUsuarios 
                    Refrescar();

                    MessageBox.Show("Usuario borrado con exito :)");
                }

                //Se registra un evento indicando que se borro un usuario de la base de datos  
                _MyLogControlEventos.InfoFormat("Se borro un Usuario");
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
            //Limpia los campos 
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            try
            {
                //Limpia los campos, combos, fecha y la imagen mostrados 
                txtNombreCompleto.Clear();
                txtCorreo.Clear();
                txtCedula.Clear();
                cmbTipoUsuario.SelectedIndex = -1;
                txtContrasenna.Clear();
                pbFotografia.Image = Properties.Resources.photo;
                pbFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotografia.Tag = null;
                dtpFechaNacimiento.Value = DateTime.Now;

                //Si hay datos en el dgvUsuarios,
                //quita la seleccion al dato que se este seleccionando en ese momento 
                if (dgvUsuarios.DataSource != null)
                {
                    dgvUsuarios.CurrentRow.Selected = false;
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

        private void dvgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    //Realiza el Casteo del objeto que se necesita crear 
                    var usuario = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;

                    //Se muestran los datos del usuario seleccionado en el dgvUsuarios 
                    txtNombreCompleto.Text = usuario.NombreCompleto;
                    txtCedula.Text = usuario.Cedula;
                    txtCorreo.Text = usuario.Correo;
                    cmbTipoUsuario.SelectedValue = usuario.TipoUsuario.Id;
                    txtContrasenna.Text = usuario.Contrasennia;
                    pbFotografia.Image = new Bitmap(new MemoryStream(usuario.Fotografia));
                    pbFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbFotografia.Tag = usuario.Fotografia;
                    dtpFechaNacimiento.Value = usuario.FechaNacimiento;
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

        private void pbFotografia_Click(object sender, EventArgs e)
        {
            try
            {
                //Se muestra un OpenFileDialog para que el usuario seleccione una fotografia 
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
                    this.pbFotografia.ImageLocation = opt.FileName;
                    //Se muestra la imagen en el PictureBox
                    pbFotografia.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbFotografia.Tag = (byte[])cadenaBytes;

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

        //Metodo asyn que conecta con el webService de hacienda 
        private async void SolicitarNombre()
        {
            //Crear un objeto HtpCliente, necsario para realizar la solicitud Http 
            HttpClient client = new HttpClient();
            //Obtiene la cédula digitada por el usuario 
            var cedula = txtCedula.Text;
            //Crear un objeto persona (Entidad necesaria para deserializar el archivo Json obtenido por medio del WebService) 
            Persona oPersona = null;

            // Se indica el url para acceder al webService, aquí se debe poner el número de cédula que se desea buscar
            var url = $"https://api.hacienda.go.cr/fe/ae?identificacion={cedula}";

            //Espera a recibir una respuesta del url indicado 
            var response = await client.GetAsync(url);

            //Pregunta si hubo respuesta del url 
            if (response.IsSuccessStatusCode)
            {
                //Si hubo respuesta, espera a obtener el archivo Json 
                var jsonResponse = await response.Content.ReadAsStringAsync();

                //Se deserializa el archivo Json, apara convertirlo en un objeto persona 
                oPersona = JSONGenericObject<Persona>.JSonToObject(jsonResponse);

                //Obtiene el nombre de la persona con la cédula indicada
                txtNombreCompleto.Text = oPersona.nombre;
            }

            //Si el objeto persona es nulo, no se encontro en hacienda una persona con el número de cédula indicada 
            if (oPersona == null)
            {
                MessageBox.Show("Usted no ha sido encontrado en Hacienda, por favor verifique si la cédula digitada es la correcta",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCedula.Focus();
                return;
            }
        }

        private void bnBuscarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                //Se indica que es necesario digitar el número de cédula del usuario
                if (string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("Debe digitar su número de cédula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCedula.Focus();
                    return;
                }

                //Limpia el txtNombreCompleto
                txtNombreCompleto.Clear();

                //Solicita en hacienda, el nombre del la persona con la cédula indicada 
                SolicitarNombre();
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

        private void frmMantenimientosUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se registra un evento indicando que se termino el mantenimiento de usuarios 
            _MyLogControlEventos.InfoFormat("Se cerro Mantenimiento de Usuarios");
        }
    }
}
