namespace appProyecto.Layers.UI
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.procesosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IniciarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProcesostoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // procesosToolStripMenuItem1
            // 
            this.procesosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.IniciarSeccionToolStripMenuItem,
            this.cerrarSecciónToolStripMenuItem});
            this.procesosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.procesosToolStripMenuItem1.Image = global::appProyecto.Properties.Resources.more;
            this.procesosToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.procesosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.procesosToolStripMenuItem1.Name = "procesosToolStripMenuItem1";
            this.procesosToolStripMenuItem1.Size = new System.Drawing.Size(194, 52);
            this.procesosToolStripMenuItem1.Text = "  Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.salirToolStripMenuItem.Image = global::appProyecto.Properties.Resources.exitIcon;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(221, 54);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // IniciarSeccionToolStripMenuItem
            // 
            this.IniciarSeccionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.IniciarSeccionToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.IniciarSeccionToolStripMenuItem.Image = global::appProyecto.Properties.Resources.user;
            this.IniciarSeccionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IniciarSeccionToolStripMenuItem.Name = "IniciarSeccionToolStripMenuItem";
            this.IniciarSeccionToolStripMenuItem.Size = new System.Drawing.Size(221, 54);
            this.IniciarSeccionToolStripMenuItem.Text = "Iniciar Sesion";
            this.IniciarSeccionToolStripMenuItem.Click += new System.EventHandler(this.IniciarSeccionToolStripMenuItem_Click);
            // 
            // cerrarSecciónToolStripMenuItem
            // 
            this.cerrarSecciónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cerrarSecciónToolStripMenuItem.Enabled = false;
            this.cerrarSecciónToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.cerrarSecciónToolStripMenuItem.Image = global::appProyecto.Properties.Resources.usb_port;
            this.cerrarSecciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarSecciónToolStripMenuItem.Name = "cerrarSecciónToolStripMenuItem";
            this.cerrarSecciónToolStripMenuItem.Size = new System.Drawing.Size(221, 54);
            this.cerrarSecciónToolStripMenuItem.Text = "Cerrar Sección";
            this.cerrarSecciónToolStripMenuItem.Click += new System.EventHandler(this.CerrarSecciónToolStripMenuItem_Click);
            // 
            // MantenimientosToolStripMenuItem
            // 
            this.MantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripMenuItem,
            this.fabricantesToolStripMenuItem,
            this.ComponentesToolStripMenuItem,
            this.tiposDeProductoToolStripMenuItem});
            this.MantenimientosToolStripMenuItem.Enabled = false;
            this.MantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MantenimientosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.MantenimientosToolStripMenuItem.Image = global::appProyecto.Properties.Resources.website;
            this.MantenimientosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem";
            this.MantenimientosToolStripMenuItem.Size = new System.Drawing.Size(194, 52);
            this.MantenimientosToolStripMenuItem.Text = "  Mantenimientos";
            // 
            // UsuarioToolStripMenuItem
            // 
            this.UsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.UsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.UsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UsuarioToolStripMenuItem.Image")));
            this.UsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem";
            this.UsuarioToolStripMenuItem.Size = new System.Drawing.Size(279, 54);
            this.UsuarioToolStripMenuItem.Text = "Usuarios";
            this.UsuarioToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoUsuarioToolStripMenuItem_Click);
            // 
            // fabricantesToolStripMenuItem
            // 
            this.fabricantesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.fabricantesToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.fabricantesToolStripMenuItem.Image = global::appProyecto.Properties.Resources.shapes;
            this.fabricantesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            this.fabricantesToolStripMenuItem.Size = new System.Drawing.Size(279, 54);
            this.fabricantesToolStripMenuItem.Text = "Tipo de Componentes";
            this.fabricantesToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoTipoComponentesToolStripMenuItem_Click);
            // 
            // ComponentesToolStripMenuItem
            // 
            this.ComponentesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ComponentesToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.ComponentesToolStripMenuItem.Image = global::appProyecto.Properties.Resources.network_interface_card;
            this.ComponentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComponentesToolStripMenuItem.Name = "ComponentesToolStripMenuItem";
            this.ComponentesToolStripMenuItem.Size = new System.Drawing.Size(279, 54);
            this.ComponentesToolStripMenuItem.Text = "Componentes";
            this.ComponentesToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoComponentesToolStripMenuItem_Click);
            // 
            // tiposDeProductoToolStripMenuItem
            // 
            this.tiposDeProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tiposDeProductoToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.tiposDeProductoToolStripMenuItem.Image = global::appProyecto.Properties.Resources.washing_dishes;
            this.tiposDeProductoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tiposDeProductoToolStripMenuItem.Name = "tiposDeProductoToolStripMenuItem";
            this.tiposDeProductoToolStripMenuItem.Size = new System.Drawing.Size(279, 54);
            this.tiposDeProductoToolStripMenuItem.Text = "Tipo de Productos";
            this.tiposDeProductoToolStripMenuItem.Click += new System.EventHandler(this.TipoDeProductoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem1,
            this.MantenimientosToolStripMenuItem,
            this.ProcesostoolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(213, 241);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProcesostoolStripMenuItem
            // 
            this.ProcesostoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem,
            this.producciónToolStripMenuItem});
            this.ProcesostoolStripMenuItem.Enabled = false;
            this.ProcesostoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesostoolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcesostoolStripMenuItem.Image = global::appProyecto.Properties.Resources.industrial;
            this.ProcesostoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcesostoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProcesostoolStripMenuItem.Name = "ProcesostoolStripMenuItem";
            this.ProcesostoolStripMenuItem.Size = new System.Drawing.Size(194, 52);
            this.ProcesostoolStripMenuItem.Text = "  Procesos";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.facturaciónToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.facturaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaciónToolStripMenuItem.Image")));
            this.facturaciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(205, 54);
            this.facturaciónToolStripMenuItem.Text = "Facturación ";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.producciónToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.producciónToolStripMenuItem.Image = global::appProyecto.Properties.Resources.costo;
            this.producciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(205, 54);
            this.producciónToolStripMenuItem.Text = "Producción";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeUsuariosToolStripMenuItem,
            this.reporteDeVentaToolStripMenuItem});
            this.reportesToolStripMenuItem.Enabled = false;
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportesToolStripMenuItem.Image = global::appProyecto.Properties.Resources.report;
            this.reportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(194, 52);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            this.reporteDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.reporteDeUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.reporteDeUsuariosToolStripMenuItem.Image = global::appProyecto.Properties.Resources.desconocido;
            this.reporteDeUsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            this.reporteDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(267, 56);
            this.reporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios";
            this.reporteDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeUsuariosToolStripMenuItem_Click);
            // 
            // reporteDeVentaToolStripMenuItem
            // 
            this.reporteDeVentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.reporteDeVentaToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.reporteDeVentaToolStripMenuItem.Image = global::appProyecto.Properties.Resources.coins;
            this.reporteDeVentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeVentaToolStripMenuItem.Name = "reporteDeVentaToolStripMenuItem";
            this.reporteDeVentaToolStripMenuItem.Size = new System.Drawing.Size(267, 56);
            this.reporteDeVentaToolStripMenuItem.Text = "Reporte de Venta";
            this.reporteDeVentaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentaToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::appProyecto.Properties.Resources.ProyectoPogra_1__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(536, 241);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProductoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProcesostoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IniciarSeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentaToolStripMenuItem;
    }
}