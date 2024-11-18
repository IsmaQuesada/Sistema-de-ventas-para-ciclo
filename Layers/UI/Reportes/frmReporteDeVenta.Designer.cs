
namespace appProyecto.Layers.UI.Reportes
{
    partial class frmReporteDeVenta
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteDeVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DSReporteDeVentas = new appProyecto.Layers.UI.Reportes.DSReporteDeVentas();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bnMostrarVentas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.ReporteDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteDeVentaTableAdapter = new appProyecto.Layers.UI.Reportes.DSReporteDeVentasTableAdapters.ReporteDeVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteDeVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDeVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteDeVentaBindingSource1
            // 
            this.reporteDeVentaBindingSource1.DataMember = "ReporteDeVenta";
            this.reporteDeVentaBindingSource1.DataSource = this.DSReporteDeVentas;
            // 
            // DSReporteDeVentas
            // 
            this.DSReporteDeVentas.DataSetName = "DSReporteDeVentas";
            this.DSReporteDeVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.bnMostrarVentas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 480);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar por fecha de facturación";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DSReporteVentas";
            reportDataSource1.Value = this.reporteDeVentaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Layers.UI.Reportes.rptReporteDeVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(740, 385);
            this.reportViewer1.TabIndex = 5;
            // 
            // bnMostrarVentas
            // 
            this.bnMostrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnMostrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMostrarVentas.Image = global::appProyecto.Properties.Resources.shopping_bag;
            this.bnMostrarVentas.Location = new System.Drawing.Point(561, 20);
            this.bnMostrarVentas.Name = "bnMostrarVentas";
            this.bnMostrarVentas.Size = new System.Drawing.Size(129, 60);
            this.bnMostrarVentas.TabIndex = 4;
            this.bnMostrarVentas.Text = "Mostrar Ventas";
            this.bnMostrarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnMostrarVentas.UseVisualStyleBackColor = true;
            this.bnMostrarVentas.Click += new System.EventHandler(this.bnMostrarVentas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(392, 40);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(129, 26);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(131, 40);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(121, 26);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // ReporteDeVentaBindingSource
            // 
            this.ReporteDeVentaBindingSource.DataMember = "ReporteDeVenta";
            this.ReporteDeVentaBindingSource.DataSource = this.DSReporteDeVentas;
            // 
            // ReporteDeVentaTableAdapter
            // 
            this.ReporteDeVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 480);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmReporteDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReporteDeVenta_FormClosed);
            this.Load += new System.EventHandler(this.frmReporteDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteDeVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDeVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnMostrarVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteDeVentaBindingSource;
        private DSReporteDeVentas DSReporteDeVentas;
        private DSReporteDeVentasTableAdapters.ReporteDeVentaTableAdapter ReporteDeVentaTableAdapter;
        private System.Windows.Forms.BindingSource reporteDeVentaBindingSource1;
    }
}