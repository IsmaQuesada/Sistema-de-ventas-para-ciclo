
namespace appProyecto.Layers.UI.Reportes
{
    partial class frmReporteUsuariosPorFecha
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
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSReportes = new appProyecto.Layers.UI.Reportes.DSReportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsuarioTableAdapter = new appProyecto.Layers.UI.Reportes.DSReportesTableAdapters.UsuarioTableAdapter();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnMostrarUsuarios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "Usuario";
            this.UsuarioBindingSource.DataSource = this.DSReportes;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DSUsuarios";
            reportDataSource1.Value = this.UsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Layers.UI.Reportes.rptReporteUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(749, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.DSReportes;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(137, 33);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(121, 26);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(400, 33);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(129, 26);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Final";
            // 
            // bnMostrarUsuarios
            // 
            this.bnMostrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnMostrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMostrarUsuarios.Image = global::appProyecto.Properties.Resources.find_my_friend;
            this.bnMostrarUsuarios.Location = new System.Drawing.Point(567, 14);
            this.bnMostrarUsuarios.Name = "bnMostrarUsuarios";
            this.bnMostrarUsuarios.Size = new System.Drawing.Size(137, 59);
            this.bnMostrarUsuarios.TabIndex = 4;
            this.bnMostrarUsuarios.Text = "Mostrar Usuario";
            this.bnMostrarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.bnMostrarUsuarios.Click += new System.EventHandler(this.bnMostrarUsuarios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnMostrarUsuarios);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar por fecha de nacimiento";
            // 
            // frmReporteUsuariosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 479);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmReporteUsuariosPorFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReporteUsuariosPorFecha_FormClosed);
            this.Load += new System.EventHandler(this.frmReporteUsuariosPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.UsuarioTableAdapter UsuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnMostrarUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}