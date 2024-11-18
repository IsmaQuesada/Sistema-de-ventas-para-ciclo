using appProyecto.Layers.DAL;
using appProyecto.Util;
using log4net;
using Microsoft.Reporting.WinForms;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace appProyecto.Layers.UI.Reportes
{
    public partial class frmMostrarFactura : Form
    {
        //Permite el control de enventos por medio de Log4Net
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        //Propiedad que obtiene el número de factura 
        public int NumFactura { get; set; }

        //Propiedad que obtiene el correo del cliente 
        public string CorreoCliente { get; set; }

        public frmMostrarFactura()
        {
            InitializeComponent();
        }

        private void frmMostrarFactura_Load(object sender, EventArgs e)
        {
            try
            {
                //Conecta a la base de datos para recibir los datos del reporte
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    FacturaTableAdapter.Connection = db.Conexion as System.Data.SqlClient.SqlConnection;
                    // TODO: This line of code loads data into the 'DSReportes.Factura' table. You can move, or remove it, as needed.
                    this.FacturaTableAdapter.Fill(this.DSReportes.Factura, NumFactura);
                }
                
                //Selecciona la ruta en donde se guardo el QR de la compra 
                string ruta = @"file:///" + @"C:/TEMP/qr.png";

                // Habilitar imagenes externas
                this.reportViewer1.LocalReport.EnableExternalImages = true;

                //Le asigna el parametro al reporte 
                ReportParameter param = new ReportParameter("quickresponse", ruta);
                this.reportViewer1.LocalReport.SetParameters(param);
                
                //Refresca el reporte 
                this.reportViewer1.RefreshReport();

                //Registra un evento indicando que se accedió al reporte de facturas 
                _MyLogControlEventos.InfoFormat("Se accedió a Reporte de Factura");
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
            //Se cierra el reporte 
            this.Close();
        }

        private void EnviarCorreo()
        {
            //Correo donde se envia la factura 
            String CuentaCorreoElectronico = "ciclomamelbikes@gmail.com";
            String ContrasenaGeneradaGmail = "cgin xppp pqdx qpht";

            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Hola ! ";
            mensaje.Body = "Recibo de compra en Ciclo Mamel Bikes";
            mensaje.From = new MailAddress(CuentaCorreoElectronico);

            mensaje.To.Add(CorreoCliente.Trim()); //Correo del destinatario
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico,
            ContrasenaGeneradaGmail);

            smtp.EnableSsl = true;
            //Ruta donde se guarda pdf del reporte 
            Attachment attachment = new Attachment(@"c:\temp\reporte.pdf");
            mensaje.Attachments.Add(attachment);
            smtp.Send(mensaje);

            MessageBox.Show("Correo Enviado");
            Limpiar();
            this.Close();
        }

        private void Limpiar()
        {
            //Se limpia el Numero de factura y el correo del cliente 
            NumFactura = 0;
            CorreoCliente = "";
        }

        private void frmMostrarFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se registra un evento indicando que se termino el reporte de factura 
            _MyLogControlEventos.InfoFormat("Se cierra Reporte de Factura");
        }

        private void toolStripBtnEnviarFactura_Click(object sender, EventArgs e)
        {
            //Ruta donde se guardara el pdf del reporte 
            string ruta = @"c:\temp\reporte.pdf";

            try
            {
                //Si no existe la ruta c:\temp, lo crea 
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                //Crea una array de bytes que almacena el pdf del reporte
                byte[] Bytes = this.reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                //Se registra un evento indicando que se ha generado el PDF de la factura 
                _MyLogControlEventos.InfoFormat("Se ha generado el PDF de la Factura");

                //Se registra un evento indicando que se ha enviado el correo al cliente 
                _MyLogControlEventos.InfoFormat("Se envía la Factura al Correo del Cliente");
                EnviarCorreo();
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
