namespace appProyecto.Layers.UI
{
    partial class frmMantenimientosUsuarios
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
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUusario = new System.Windows.Forms.Label();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFotografia = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bnBuscarNombre = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(252, 79);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ReadOnly = true;
            this.txtNombreCompleto.Size = new System.Drawing.Size(376, 26);
            this.txtNombreCompleto.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre Completo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(252, 139);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(376, 26);
            this.txtCorreo.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Correo";
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
            this.tspPrincipal.Size = new System.Drawing.Size(1375, 55);
            this.tspPrincipal.TabIndex = 51;
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
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(252, 203);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(275, 28);
            this.cmbTipoUsuario.TabIndex = 52;
            // 
            // lblTipoUusario
            // 
            this.lblTipoUusario.AutoSize = true;
            this.lblTipoUusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUusario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTipoUusario.Location = new System.Drawing.Point(27, 206);
            this.lblTipoUusario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUusario.Name = "lblTipoUusario";
            this.lblTipoUusario.Size = new System.Drawing.Size(120, 20);
            this.lblTipoUusario.TabIndex = 53;
            this.lblTipoUusario.Text = "Tipo de Usuario";
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenna.Location = new System.Drawing.Point(252, 264);
            this.txtContrasenna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContrasenna.MaxLength = 8;
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '*';
            this.txtContrasenna.Size = new System.Drawing.Size(275, 26);
            this.txtContrasenna.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(27, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Contraseña";
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.bnBuscarNombre);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtContrasenna);
            this.splitContainer1.Panel1.Controls.Add(this.txtCedula);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoUusario);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipoUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombreCompleto);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtCorreo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvUsuarios);
            this.splitContainer1.Size = new System.Drawing.Size(1375, 535);
            this.splitContainer1.SplitterDistance = 802;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox2.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(31, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(271, 72);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(21, 29);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(230, 26);
            this.dtpFechaNacimiento.TabIndex = 65;
            this.dtpFechaNacimiento.Value = new System.DateTime(2023, 4, 10, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox1.Controls.Add(this.pbFotografia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(346, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(181, 180);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fotografía";
            // 
            // pbFotografia
            // 
            this.pbFotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotografia.Image = global::appProyecto.Properties.Resources.photo;
            this.pbFotografia.Location = new System.Drawing.Point(18, 29);
            this.pbFotografia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.Size = new System.Drawing.Size(146, 137);
            this.pbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotografia.TabIndex = 56;
            this.pbFotografia.TabStop = false;
            this.pbFotografia.Click += new System.EventHandler(this.pbFotografia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(27, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Cédula ";
            // 
            // bnBuscarNombre
            // 
            this.bnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBuscarNombre.Image = global::appProyecto.Properties.Resources.find_my_friend;
            this.bnBuscarNombre.Location = new System.Drawing.Point(657, 24);
            this.bnBuscarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnBuscarNombre.Name = "bnBuscarNombre";
            this.bnBuscarNombre.Size = new System.Drawing.Size(117, 81);
            this.bnBuscarNombre.TabIndex = 62;
            this.bnBuscarNombre.Text = "Buscar";
            this.bnBuscarNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnBuscarNombre.UseVisualStyleBackColor = true;
            this.bnBuscarNombre.Click += new System.EventHandler(this.bnBuscarNombre_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(252, 24);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(376, 26);
            this.txtCedula.TabIndex = 60;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCedula,
            this.colFoto,
            this.colNombre,
            this.colCorreo,
            this.colTipoUsuario,
            this.colFechaNacimiento});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(567, 535);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dvgUsuario_SelectionChanged);
            // 
            // colCedula
            // 
            this.colCedula.DataPropertyName = "Cedula";
            this.colCedula.HeaderText = "Cedula";
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
            // colTipoUsuario
            // 
            this.colTipoUsuario.DataPropertyName = "TipoUsuario";
            this.colTipoUsuario.HeaderText = "Tipo Usuario";
            this.colTipoUsuario.Name = "colTipoUsuario";
            this.colTipoUsuario.ReadOnly = true;
            this.colTipoUsuario.Width = 183;
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
            // 
            // frmMantenimientosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1375, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMantenimientosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantenimientosUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.frmMantenimientos_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnLimpiar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUusario;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbFotografia;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button bnBuscarNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewImageColumn colFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}