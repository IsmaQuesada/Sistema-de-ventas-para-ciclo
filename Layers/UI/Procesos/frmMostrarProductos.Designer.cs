namespace appProyecto.Layers.UI
{
    partial class frmMostrarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBuscar,
            this.toolStripSeparator1,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tspBarraSuperior.Size = new System.Drawing.Size(754, 57);
            this.tspBarraSuperior.TabIndex = 10;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnBuscar
            // 
            this.toolStripBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnBuscar.Image = global::appProyecto.Properties.Resources.shopping_bag;
            this.toolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBuscar.Name = "toolStripBtnBuscar";
            this.toolStripBtnBuscar.Size = new System.Drawing.Size(113, 54);
            this.toolStripBtnBuscar.Text = "Buscar";
            this.toolStripBtnBuscar.Click += new System.EventHandler(this.toolStripBtnBuscar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSalir.Image = global::appProyecto.Properties.Resources.exitIcon;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(92, 54);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCódigo,
            this.colDescripcion,
            this.colTipoProducto,
            this.colFabricante,
            this.colImagen,
            this.colExistencia,
            this.colPrecio});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.Location = new System.Drawing.Point(0, 78);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(754, 318);
            this.dgvProductos.TabIndex = 11;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProducto_CellClick);
            // 
            // colCódigo
            // 
            this.colCódigo.DataPropertyName = "Id";
            this.colCódigo.HeaderText = "Código";
            this.colCódigo.Name = "colCódigo";
            this.colCódigo.ReadOnly = true;
            this.colCódigo.Width = 183;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 183;
            // 
            // colTipoProducto
            // 
            this.colTipoProducto.DataPropertyName = "TipoProducto";
            this.colTipoProducto.HeaderText = "Tipo de Producto";
            this.colTipoProducto.Name = "colTipoProducto";
            this.colTipoProducto.ReadOnly = true;
            this.colTipoProducto.Width = 183;
            // 
            // colFabricante
            // 
            this.colFabricante.DataPropertyName = "FabricanteProducto";
            this.colFabricante.HeaderText = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.ReadOnly = true;
            this.colFabricante.Width = 183;
            // 
            // colImagen
            // 
            this.colImagen.DataPropertyName = "ImagenProducto";
            this.colImagen.HeaderText = "Imagen del Producto";
            this.colImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImagen.Name = "colImagen";
            this.colImagen.ReadOnly = true;
            this.colImagen.Width = 183;
            // 
            // colExistencia
            // 
            this.colExistencia.DataPropertyName = "Existencia";
            this.colExistencia.HeaderText = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.ReadOnly = true;
            this.colExistencia.Width = 183;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "PrecioColon";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrecio.HeaderText = "Precio en colones";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 183;
            // 
            // frmMostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 396);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tspBarraSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMostrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarProductos";
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnBuscar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}