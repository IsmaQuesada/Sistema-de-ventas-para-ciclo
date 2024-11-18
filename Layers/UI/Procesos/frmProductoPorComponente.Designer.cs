namespace appProyecto.Layers.UI
{
    partial class frmProductoPorComponente
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
            this.btndesensamblar = new System.Windows.Forms.Button();
            this.btnEnsamblar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEnsamblado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDisponibles = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndesensamblar
            // 
            this.btndesensamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesensamblar.Location = new System.Drawing.Point(291, 153);
            this.btndesensamblar.Name = "btndesensamblar";
            this.btndesensamblar.Size = new System.Drawing.Size(87, 35);
            this.btndesensamblar.TabIndex = 7;
            this.btndesensamblar.Text = "<<";
            this.btndesensamblar.UseVisualStyleBackColor = true;
            this.btndesensamblar.Click += new System.EventHandler(this.btndesensamblar_Click);
            // 
            // btnEnsamblar
            // 
            this.btnEnsamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnsamblar.Location = new System.Drawing.Point(291, 78);
            this.btnEnsamblar.Name = "btnEnsamblar";
            this.btnEnsamblar.Size = new System.Drawing.Size(87, 33);
            this.btnEnsamblar.TabIndex = 6;
            this.btnEnsamblar.Text = ">>";
            this.btnEnsamblar.UseVisualStyleBackColor = true;
            this.btnEnsamblar.Click += new System.EventHandler(this.btnEnsamblar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbEnsamblado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(416, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 231);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componentes Ensamblados";
            // 
            // lbEnsamblado
            // 
            this.lbEnsamblado.FormattingEnabled = true;
            this.lbEnsamblado.ItemHeight = 20;
            this.lbEnsamblado.Location = new System.Drawing.Point(48, 34);
            this.lbEnsamblado.Name = "lbEnsamblado";
            this.lbEnsamblado.Size = new System.Drawing.Size(144, 184);
            this.lbEnsamblado.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDisponibles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(33, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Componentes Disponibles";
            // 
            // lbDisponibles
            // 
            this.lbDisponibles.FormattingEnabled = true;
            this.lbDisponibles.ItemHeight = 20;
            this.lbDisponibles.Location = new System.Drawing.Point(33, 34);
            this.lbDisponibles.Name = "lbDisponibles";
            this.lbDisponibles.Size = new System.Drawing.Size(142, 184);
            this.lbDisponibles.TabIndex = 0;
            // 
            // frmProductoPorComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(688, 292);
            this.Controls.Add(this.btndesensamblar);
            this.Controls.Add(this.btnEnsamblar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductoPorComponente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ensamblaje de componentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductoPorComponente_FormClosed);
            this.Load += new System.EventHandler(this.frmProductoPorComponente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndesensamblar;
        private System.Windows.Forms.Button btnEnsamblar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbEnsamblado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDisponibles;
    }
}