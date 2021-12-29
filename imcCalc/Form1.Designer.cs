namespace imcCalc
{
    partial class frmImc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImc));
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblClassificacaoImc = new System.Windows.Forms.Label();
            this.lbClassificacaoIMC = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(133, 130);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(72, 20);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura =";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPeso.Location = new System.Drawing.Point(257, 210);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(163, 35);
            this.txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.Color.Green;
            this.txtAltura.Location = new System.Drawing.Point(257, 123);
            this.txtAltura.Multiline = true;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(163, 35);
            this.txtAltura.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Location = new System.Drawing.Point(286, 292);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 43);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calcular!";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(132, 214);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(64, 20);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso =";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // lblClassificacaoImc
            // 
            this.lblClassificacaoImc.AutoSize = true;
            this.lblClassificacaoImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacaoImc.Location = new System.Drawing.Point(195, 519);
            this.lblClassificacaoImc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassificacaoImc.Name = "lblClassificacaoImc";
            this.lblClassificacaoImc.Size = new System.Drawing.Size(0, 20);
            this.lblClassificacaoImc.TabIndex = 7;
            this.lblClassificacaoImc.Click += new System.EventHandler(this.lblClassificacaoImc_Click);
            // 
            // lbClassificacaoIMC
            // 
            this.lbClassificacaoIMC.AutoSize = true;
            this.lbClassificacaoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacaoIMC.Location = new System.Drawing.Point(205, 511);
            this.lbClassificacaoIMC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbClassificacaoIMC.Name = "lbClassificacaoIMC";
            this.lbClassificacaoIMC.Size = new System.Drawing.Size(0, 20);
            this.lbClassificacaoIMC.TabIndex = 8;
            this.lbClassificacaoIMC.Click += new System.EventHandler(this.lbClassificacaoIMC_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(119, 399);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(111, 20);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado  =";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(253, 399);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 20);
            this.lbResultado.TabIndex = 10;
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // frmImc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(707, 615);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbClassificacaoIMC);
            this.Controls.Add(this.lblClassificacaoImc);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmImc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Imc";
            this.Load += new System.EventHandler(this.frmImc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblClassificacaoImc;
        private System.Windows.Forms.Label lbClassificacaoIMC;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lbResultado;
    }
}

