namespace appProyecto.Layers.UI
{
    partial class frmMostrarClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.tspBarraSuperior.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspBarraSuperior.Size = new System.Drawing.Size(760, 55);
            this.tspBarraSuperior.TabIndex = 8;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnBuscar
            // 
            this.toolStripBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnBuscar.Image = global::appProyecto.Properties.Resources.find_my_friend;
            this.toolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBuscar.Name = "toolStripBtnBuscar";
            this.toolStripBtnBuscar.Size = new System.Drawing.Size(111, 52);
            this.toolStripBtnBuscar.Text = "Buscar";
            this.toolStripBtnBuscar.Click += new System.EventHandler(this.toolStripBtnBuscar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSalir.Image = global::appProyecto.Properties.Resources.exitIcon;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(92, 52);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCedula,
            this.colFoto,
            this.colNombre,
            this.colCorreo,
            this.colFechaNacimiento});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClientes.Location = new System.Drawing.Point(0, 76);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(760, 317);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuario_CellClick);
            // 
            // colCedula
            // 
            this.colCedula.DataPropertyName = "Cedula";
            this.colCedula.HeaderText = "Cédula ";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            // 
            // colFoto
            // 
            this.colFoto.DataPropertyName = "Fotografia";
            this.colFoto.HeaderText = "Fotografia";
            this.colFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colFoto.Name = "colFoto";
            this.colFoto.ReadOnly = true;
            this.colFoto.Width = 183;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "NombreCompleto";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 183;
            // 
            // colCorreo
            // 
            this.colCorreo.DataPropertyName = "Correo";
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 183;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colFechaNacimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.ReadOnly = true;
            this.colFechaNacimiento.Width = 120;
            // 
            // frmMostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.tspBarraSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMostrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarClientes";
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnBuscar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewImageColumn colFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
    }
}