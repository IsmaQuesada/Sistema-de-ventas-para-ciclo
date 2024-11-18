namespace appProyecto.Layers.UI
{
    partial class frmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubtotalColon = new System.Windows.Forms.TextBox();
            this.txtImpuestoColon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalColon = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotalDolar = new System.Windows.Forms.TextBox();
            this.txtTotalDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImpuestoDolar = new System.Windows.Forms.TextBox();
            this.gpbMoneda = new System.Windows.Forms.GroupBox();
            this.rbDolar = new System.Windows.Forms.RadioButton();
            this.rbColon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.mskCodigoProduto = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnFacturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpbMoneda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDetalleFactura.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(18, 34);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(565, 284);
            this.dgvDetalleFactura.TabIndex = 11;
            // 
            // No
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.No.DefaultCellStyle = dataGridViewCellStyle1;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Código del Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descripcion";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Descripción ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Existencia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Cantidad ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.ToolTipText = "0";
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Precio del Producto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 604);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(1227, 22);
            this.sttBarraInferior.TabIndex = 9;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvDetalleFactura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(605, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 520);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox4.Location = new System.Drawing.Point(322, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 127);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pago en Colónes ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68208F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31792F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSubtotalColon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtImpuestoColon, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalColon, 1, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(238, 93);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Impuesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total";
            // 
            // txtSubtotalColon
            // 
            this.txtSubtotalColon.Location = new System.Drawing.Point(85, 3);
            this.txtSubtotalColon.Name = "txtSubtotalColon";
            this.txtSubtotalColon.ReadOnly = true;
            this.txtSubtotalColon.Size = new System.Drawing.Size(134, 26);
            this.txtSubtotalColon.TabIndex = 3;
            this.txtSubtotalColon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuestoColon
            // 
            this.txtImpuestoColon.Location = new System.Drawing.Point(85, 35);
            this.txtImpuestoColon.Name = "txtImpuestoColon";
            this.txtImpuestoColon.ReadOnly = true;
            this.txtImpuestoColon.Size = new System.Drawing.Size(134, 26);
            this.txtImpuestoColon.TabIndex = 4;
            this.txtImpuestoColon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Subtotal";
            // 
            // txtTotalColon
            // 
            this.txtTotalColon.Location = new System.Drawing.Point(85, 67);
            this.txtTotalColon.Name = "txtTotalColon";
            this.txtTotalColon.ReadOnly = true;
            this.txtTotalColon.Size = new System.Drawing.Size(134, 26);
            this.txtTotalColon.TabIndex = 5;
            this.txtTotalColon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(18, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 127);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pago en Dolares";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31792F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSubtotalDolar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalDolar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtImpuestoDolar, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 93);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Impuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total";
            // 
            // txtSubtotalDolar
            // 
            this.txtSubtotalDolar.Location = new System.Drawing.Point(86, 3);
            this.txtSubtotalDolar.Name = "txtSubtotalDolar";
            this.txtSubtotalDolar.ReadOnly = true;
            this.txtSubtotalDolar.Size = new System.Drawing.Size(133, 26);
            this.txtSubtotalDolar.TabIndex = 3;
            this.txtSubtotalDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDolar
            // 
            this.txtTotalDolar.Location = new System.Drawing.Point(86, 67);
            this.txtTotalDolar.Name = "txtTotalDolar";
            this.txtTotalDolar.ReadOnly = true;
            this.txtTotalDolar.Size = new System.Drawing.Size(133, 26);
            this.txtTotalDolar.TabIndex = 5;
            this.txtTotalDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // txtImpuestoDolar
            // 
            this.txtImpuestoDolar.Location = new System.Drawing.Point(86, 35);
            this.txtImpuestoDolar.Name = "txtImpuestoDolar";
            this.txtImpuestoDolar.ReadOnly = true;
            this.txtImpuestoDolar.Size = new System.Drawing.Size(133, 26);
            this.txtImpuestoDolar.TabIndex = 4;
            this.txtImpuestoDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpbMoneda
            // 
            this.gpbMoneda.Controls.Add(this.rbDolar);
            this.gpbMoneda.Controls.Add(this.rbColon);
            this.gpbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMoneda.ForeColor = System.Drawing.Color.LightGray;
            this.gpbMoneda.Location = new System.Drawing.Point(34, 401);
            this.gpbMoneda.Name = "gpbMoneda";
            this.gpbMoneda.Size = new System.Drawing.Size(200, 100);
            this.gpbMoneda.TabIndex = 15;
            this.gpbMoneda.TabStop = false;
            this.gpbMoneda.Text = "Pagar por:";
            // 
            // rbDolar
            // 
            this.rbDolar.AutoSize = true;
            this.rbDolar.Location = new System.Drawing.Point(18, 30);
            this.rbDolar.Name = "rbDolar";
            this.rbDolar.Size = new System.Drawing.Size(78, 22);
            this.rbDolar.TabIndex = 13;
            this.rbDolar.Text = "Dolares";
            this.rbDolar.UseVisualStyleBackColor = true;
            // 
            // rbColon
            // 
            this.rbColon.AutoSize = true;
            this.rbColon.Location = new System.Drawing.Point(18, 63);
            this.rbColon.Name = "rbColon";
            this.rbColon.Size = new System.Drawing.Size(82, 22);
            this.rbColon.TabIndex = 14;
            this.rbColon.Text = "Colónes";
            this.rbColon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox1.Controls.Add(this.gpbMoneda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.mskCantidad);
            this.groupBox1.Controls.Add(this.mskCodigoProduto);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescripcionProducto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtExistencia);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCedulaCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNumeroFactura);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 520);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(30, 325);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 32;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Image = global::appProyecto.Properties.Resources.shopping_bag;
            this.btnBuscarProducto.Location = new System.Drawing.Point(380, 188);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(124, 67);
            this.btnBuscarProducto.TabIndex = 30;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(166, 325);
            this.mskCantidad.Mask = "999999999999";
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(193, 24);
            this.mskCantidad.TabIndex = 33;
            // 
            // mskCodigoProduto
            // 
            this.mskCodigoProduto.Location = new System.Drawing.Point(166, 188);
            this.mskCodigoProduto.Mask = "99999999999";
            this.mskCodigoProduto.Name = "mskCodigoProduto";
            this.mskCodigoProduto.ReadOnly = true;
            this.mskCodigoProduto.Size = new System.Drawing.Size(193, 24);
            this.mskCodigoProduto.TabIndex = 31;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::appProyecto.Properties.Resources.carrito_de_compras;
            this.btnAgregar.Location = new System.Drawing.Point(380, 325);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 60);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Código Producto";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(166, 231);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.ReadOnly = true;
            this.txtDescripcionProducto.Size = new System.Drawing.Size(193, 24);
            this.txtDescripcionProducto.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(166, 280);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(193, 24);
            this.txtExistencia.TabIndex = 41;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(166, 361);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(193, 24);
            this.txtPrecio.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cliente";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(169, 91);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.ReadOnly = true;
            this.txtCedulaCliente.Size = new System.Drawing.Size(213, 24);
            this.txtCedulaCliente.TabIndex = 23;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Image = global::appProyecto.Properties.Resources.find_my_friend;
            this.btnBuscarCliente.Location = new System.Drawing.Point(399, 59);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(134, 56);
            this.btnBuscarCliente.TabIndex = 24;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "No. Factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(166, 43);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(210, 24);
            this.txtNumeroFactura.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nombre Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(166, 135);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(364, 24);
            this.txtNombreCliente.TabIndex = 27;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripSeparator2,
            this.toolStripBtnFacturar,
            this.toolStripSeparator1,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tspBarraSuperior.Size = new System.Drawing.Size(1227, 57);
            this.tspBarraSuperior.TabIndex = 38;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnNuevo.Image = global::appProyecto.Properties.Resources.agregar_archivo;
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(108, 54);
            this.toolStripBtnNuevo.Text = "Nuevo";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripBtnFacturar
            // 
            this.toolStripBtnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFacturar.Image")));
            this.toolStripBtnFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFacturar.Name = "toolStripBtnFacturar";
            this.toolStripBtnFacturar.Size = new System.Drawing.Size(121, 54);
            this.toolStripBtnFacturar.Text = "Facturar";
            this.toolStripBtnFacturar.Click += new System.EventHandler(this.toolStripBtnFacturar_Click);
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
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1227, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sttBarraInferior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tspBarraSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFacturacion_FormClosed);
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gpbMoneda.ResumeLayout(false);
            this.gpbMoneda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.MaskedTextBox mskCodigoProduto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnFacturar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.RadioButton rbColon;
        private System.Windows.Forms.RadioButton rbDolar;
        private System.Windows.Forms.GroupBox gpbMoneda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubtotalColon;
        private System.Windows.Forms.TextBox txtImpuestoColon;
        private System.Windows.Forms.TextBox txtTotalColon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotalDolar;
        private System.Windows.Forms.TextBox txtImpuestoDolar;
        private System.Windows.Forms.TextBox txtTotalDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}