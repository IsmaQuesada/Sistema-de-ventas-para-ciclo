
namespace appProyecto.Layers.UI.Reportes
{
    partial class frmMostrarFactura
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
            this.facturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DSReportes = new appProyecto.Layers.UI.Reportes.DSReportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaTableAdapter = new appProyecto.Layers.UI.Reportes.DSReportesTableAdapters.FacturaTableAdapter();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnEnviarFactura = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // facturaBindingSource1
            // 
            this.facturaBindingSource1.DataMember = "Factura";
            this.facturaBindingSource1.DataSource = this.DSReportes;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DSFactura";
            reportDataSource1.Value = this.facturaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Layers.UI.Reportes.rptReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1129, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.DSReportes;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnEnviarFactura,
            this.toolStripSeparator1,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(1129, 55);
            this.tspBarraSuperior.TabIndex = 2;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnEnviarFactura
            // 
            this.toolStripBtnEnviarFactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnEnviarFactura.Image = global::appProyecto.Properties.Resources.send;
            this.toolStripBtnEnviarFactura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEnviarFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEnviarFactura.Name = "toolStripBtnEnviarFactura";
            this.toolStripBtnEnviarFactura.Size = new System.Drawing.Size(159, 52);
            this.toolStripBtnEnviarFactura.Text = "Enviar Factura";
            this.toolStripBtnEnviarFactura.Click += new System.EventHandler(this.toolStripBtnEnviarFactura_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSalir.Image = global::appProyecto.Properties.Resources.exitIcon;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(93, 52);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // frmMostrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 613);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmMostrarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMostrarFactura_FormClosed);
            this.Load += new System.EventHandler(this.frmMostrarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.FacturaTableAdapter FacturaTableAdapter;
        private System.Windows.Forms.BindingSource facturaBindingSource1;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.ToolStripButton toolStripBtnEnviarFactura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}