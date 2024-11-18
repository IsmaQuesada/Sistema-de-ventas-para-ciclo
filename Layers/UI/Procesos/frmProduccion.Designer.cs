namespace appProyecto.Layers.UI
{
    partial class frmPrepararProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bnEnsamblaje = new System.Windows.Forms.Button();
            this.gbComponentes = new System.Windows.Forms.GroupBox();
            this.rbMontanna = new System.Windows.Forms.RadioButton();
            this.rbRuta = new System.Windows.Forms.RadioButton();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagenProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            this.gbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCódigo,
            this.colDescripcion,
            this.colTipoProducto,
            this.colFabricante,
            this.colImagenProducto,
            this.colExistencia,
            this.colPrecio});
            this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducto.Location = new System.Drawing.Point(0, 0);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(638, 400);
            this.dgvProducto.TabIndex = 12;
            this.dgvProducto.SelectionChanged += new System.EventHandler(this.dvgProducto_SelectionChanged);
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnGuardar,
            this.toolStripSeparator4,
            this.toolStripBtnActualizar,
            this.toolStripSeparator1,
            this.toolStripBtnBorrar,
            this.toolStripSeparator2,
            this.toolStripBtnLimpiar});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.tspPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tspPrincipal.Size = new System.Drawing.Size(1394, 55);
            this.tspPrincipal.TabIndex = 50;
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
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
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(167, 73);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 26);
            this.txtDescripcion.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Descripción";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(167, 23);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(237, 26);
            this.txtID.TabIndex = 52;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.lblCategoria.Location = new System.Drawing.Point(13, 26);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(59, 20);
            this.lblCategoria.TabIndex = 51;
            this.lblCategoria.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo de Producto";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(167, 124);
            this.cmbTipoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(199, 28);
            this.cmbTipoProducto.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(435, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Fabricante";
            // 
            // nudExistencia
            // 
            this.nudExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExistencia.Location = new System.Drawing.Point(548, 71);
            this.nudExistencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudExistencia.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(190, 26);
            this.nudExistencia.TabIndex = 60;
            this.nudExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExistencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(435, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Existencia";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(548, 127);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(190, 26);
            this.txtPrecio.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(389, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Precio en colones";
            // 
            // bnEnsamblaje
            // 
            this.bnEnsamblaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEnsamblaje.ForeColor = System.Drawing.Color.Black;
            this.bnEnsamblaje.Image = global::appProyecto.Properties.Resources.teamwork;
            this.bnEnsamblaje.Location = new System.Drawing.Point(145, 35);
            this.bnEnsamblaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnEnsamblaje.Name = "bnEnsamblaje";
            this.bnEnsamblaje.Size = new System.Drawing.Size(124, 81);
            this.bnEnsamblaje.TabIndex = 66;
            this.bnEnsamblaje.Text = "Ensamblar";
            this.bnEnsamblaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bnEnsamblaje.UseVisualStyleBackColor = true;
            this.bnEnsamblaje.Click += new System.EventHandler(this.bnEnsamblaje_Click);
            // 
            // gbComponentes
            // 
            this.gbComponentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.gbComponentes.Controls.Add(this.rbMontanna);
            this.gbComponentes.Controls.Add(this.rbRuta);
            this.gbComponentes.Controls.Add(this.bnEnsamblaje);
            this.gbComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComponentes.ForeColor = System.Drawing.Color.LightGray;
            this.gbComponentes.Location = new System.Drawing.Point(439, 181);
            this.gbComponentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbComponentes.Name = "gbComponentes";
            this.gbComponentes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbComponentes.Size = new System.Drawing.Size(288, 144);
            this.gbComponentes.TabIndex = 67;
            this.gbComponentes.TabStop = false;
            this.gbComponentes.Text = "Bicicletas";
            this.gbComponentes.Visible = false;
            // 
            // rbMontanna
            // 
            this.rbMontanna.AutoSize = true;
            this.rbMontanna.Location = new System.Drawing.Point(22, 92);
            this.rbMontanna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMontanna.Name = "rbMontanna";
            this.rbMontanna.Size = new System.Drawing.Size(90, 24);
            this.rbMontanna.TabIndex = 68;
            this.rbMontanna.TabStop = true;
            this.rbMontanna.Text = "Montaña";
            this.rbMontanna.UseVisualStyleBackColor = true;
            // 
            // rbRuta
            // 
            this.rbRuta.AutoSize = true;
            this.rbRuta.Checked = true;
            this.rbRuta.Location = new System.Drawing.Point(22, 35);
            this.rbRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRuta.Name = "rbRuta";
            this.rbRuta.Size = new System.Drawing.Size(62, 24);
            this.rbRuta.TabIndex = 67;
            this.rbRuta.TabStop = true;
            this.rbRuta.Text = "Ruta";
            this.rbRuta.UseVisualStyleBackColor = true;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(550, 20);
            this.cmbFabricante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(188, 28);
            this.cmbFabricante.TabIndex = 58;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.lblCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.gbComponentes);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrecio);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipoProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.nudExistencia);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFabricante);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProducto);
            this.splitContainer1.Size = new System.Drawing.Size(1394, 400);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox2.Controls.Add(this.pbImagen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(17, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(240, 203);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen del Producto";
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagen.Image = global::appProyecto.Properties.Resources.photo;
            this.pbImagen.Location = new System.Drawing.Point(18, 27);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(204, 166);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 64;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
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
            // colImagenProducto
            // 
            this.colImagenProducto.DataPropertyName = "ImagenProducto";
            this.colImagenProducto.HeaderText = "Imagen del Producto";
            this.colImagenProducto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImagenProducto.Name = "colImagenProducto";
            this.colImagenProducto.ReadOnly = true;
            this.colImagenProducto.Width = 183;
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
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrecio.HeaderText = "Precio en Colones";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 183;
            // 
            // frmPrepararProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1394, 455);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrepararProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preparar Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrepararProductos_FormClosed);
            this.Load += new System.EventHandler(this.frmPrepararProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            this.gbComponentes.ResumeLayout(false);
            this.gbComponentes.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnLimpiar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudExistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button bnEnsamblaje;
        private System.Windows.Forms.GroupBox gbComponentes;
        private System.Windows.Forms.RadioButton rbMontanna;
        private System.Windows.Forms.RadioButton rbRuta;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewImageColumn colImagenProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}