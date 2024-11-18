namespace appProyecto.Layers.UI
{
    partial class frmMantenimientoComponentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoBici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoComponente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoBici = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.tspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AllowUserToDeleteRows = false;
            this.dgvComponentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvComponentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFabricante,
            this.colTipoComponente,
            this.colDescripcion,
            this.colTipoBici});
            this.dgvComponentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvComponentes.Location = new System.Drawing.Point(0, 254);
            this.dgvComponentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvComponentes.MultiSelect = false;
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.Size = new System.Drawing.Size(1001, 296);
            this.dgvComponentes.TabIndex = 45;
            this.dgvComponentes.SelectionChanged += new System.EventHandler(this.dvgComponente_SelectionChanged);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colFabricante
            // 
            this.colFabricante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFabricante.DataPropertyName = "Fabricante_Componente";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFabricante.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFabricante.HeaderText = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.ReadOnly = true;
            // 
            // colTipoComponente
            // 
            this.colTipoComponente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoComponente.DataPropertyName = "TipoComponente";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoComponente.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTipoComponente.HeaderText = "Tipo de Componente";
            this.colTipoComponente.Name = "colTipoComponente";
            this.colTipoComponente.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colTipoBici
            // 
            this.colTipoBici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoBici.DataPropertyName = "TipoBicicleta";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoBici.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTipoBici.HeaderText = "Tipo de Bicicleta";
            this.colTipoBici.Name = "colTipoBici";
            this.colTipoBici.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(692, 80);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(278, 26);
            this.txtDescripcion.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(542, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Frabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(33, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tipo de Componente";
            // 
            // cmbTipoComponente
            // 
            this.cmbTipoComponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComponente.FormattingEnabled = true;
            this.cmbTipoComponente.Location = new System.Drawing.Point(208, 194);
            this.cmbTipoComponente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoComponente.Name = "cmbTipoComponente";
            this.cmbTipoComponente.Size = new System.Drawing.Size(278, 28);
            this.cmbTipoComponente.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(542, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Tipo de Bicicleta";
            // 
            // cmbTipoBici
            // 
            this.cmbTipoBici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoBici.FormattingEnabled = true;
            this.cmbTipoBici.Location = new System.Drawing.Point(692, 138);
            this.cmbTipoBici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoBici.Name = "cmbTipoBici";
            this.cmbTipoBici.Size = new System.Drawing.Size(278, 28);
            this.cmbTipoBici.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(33, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Código";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(208, 138);
            this.cmbFabricante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(278, 28);
            this.cmbFabricante.TabIndex = 58;
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnGuardar,
            this.toolStripSeparator1,
            this.toolStripBtnActualizar,
            this.toolStripSeparator4,
            this.toolStripBtnBorrar,
            this.toolStripSeparator2,
            this.toolStripBtnLimpiar});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.tspPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tspPrincipal.Size = new System.Drawing.Size(1001, 55);
            this.tspPrincipal.TabIndex = 59;
            // 
            // toolStripBtnGuardar
            // 
            this.toolStripBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnGuardar.Image = global::appProyecto.Properties.Resources.diskette;
            this.toolStripBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGuardar.Name = "toolStripBtnGuardar";
            this.toolStripBtnGuardar.Size = new System.Drawing.Size(114, 52);
            this.toolStripBtnGuardar.Text = "Guardar";
            this.toolStripBtnGuardar.Click += new System.EventHandler(this.toolStripBtnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripBtnActualizar
            // 
            this.toolStripBtnActualizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnActualizar.Image = global::appProyecto.Properties.Resources.refresh;
            this.toolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnActualizar.Name = "toolStripBtnActualizar";
            this.toolStripBtnActualizar.Size = new System.Drawing.Size(127, 52);
            this.toolStripBtnActualizar.Text = "Actualizar";
            this.toolStripBtnActualizar.Click += new System.EventHandler(this.toolStripBtnActualizar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripBtnBorrar
            // 
            this.toolStripBtnBorrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnBorrar.Image = global::appProyecto.Properties.Resources.eraser;
            this.toolStripBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBorrar.Name = "toolStripBtnBorrar";
            this.toolStripBtnBorrar.Size = new System.Drawing.Size(102, 52);
            this.toolStripBtnBorrar.Text = "Borrar";
            this.toolStripBtnBorrar.Click += new System.EventHandler(this.toolStripBtnBorrar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripBtnLimpiar
            // 
            this.toolStripBtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnLimpiar.Image = global::appProyecto.Properties.Resources.broom;
            this.toolStripBtnLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLimpiar.Name = "toolStripBtnLimpiar";
            this.toolStripBtnLimpiar.Size = new System.Drawing.Size(111, 52);
            this.toolStripBtnLimpiar.Text = "Limpiar";
            this.toolStripBtnLimpiar.Click += new System.EventHandler(this.toolStripBtnLimpiar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(208, 80);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(278, 26);
            this.txtCodigo.TabIndex = 61;
            // 
            // frmMantenimientoComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1001, 550);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.tspPrincipal);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoBici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoComponente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvComponentes);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Componentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantenimientoComponentes_FormClosed);
            this.Load += new System.EventHandler(this.frmMantenimientoEnsamblaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoComponente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoBici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoBici;
    }
}