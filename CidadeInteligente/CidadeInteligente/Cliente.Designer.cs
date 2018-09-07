namespace CidadeInteligente
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.txbCNH = new System.Windows.Forms.TextBox();
            this.lblCNH = new System.Windows.Forms.Label();
            this.txbCTPS = new System.Windows.Forms.TextBox();
            this.lblCTPS = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbDtInclusao = new System.Windows.Forms.TextBox();
            this.lblDtInclusao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCNH
            // 
            this.txbCNH.Location = new System.Drawing.Point(113, 162);
            this.txbCNH.Name = "txbCNH";
            this.txbCNH.Size = new System.Drawing.Size(100, 20);
            this.txbCNH.TabIndex = 24;
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(14, 165);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(33, 13);
            this.lblCNH.TabIndex = 23;
            this.lblCNH.Text = "CNH:";
            // 
            // txbCTPS
            // 
            this.txbCTPS.Location = new System.Drawing.Point(113, 138);
            this.txbCTPS.Name = "txbCTPS";
            this.txbCTPS.Size = new System.Drawing.Size(100, 20);
            this.txbCTPS.TabIndex = 22;
            // 
            // lblCTPS
            // 
            this.lblCTPS.AutoSize = true;
            this.lblCTPS.Location = new System.Drawing.Point(14, 141);
            this.lblCTPS.Name = "lblCTPS";
            this.lblCTPS.Size = new System.Drawing.Size(38, 13);
            this.lblCTPS.TabIndex = 21;
            this.lblCTPS.Text = "CTPS:";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(113, 114);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 20;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(14, 114);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 19;
            this.lblCPF.Text = "CPF:";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(113, 87);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(100, 20);
            this.txbRG.TabIndex = 18;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(14, 92);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 17;
            this.lblRG.Text = "RG:";
            // 
            // txbDtInclusao
            // 
            this.txbDtInclusao.Location = new System.Drawing.Point(113, 61);
            this.txbDtInclusao.Name = "txbDtInclusao";
            this.txbDtInclusao.Size = new System.Drawing.Size(100, 20);
            this.txbDtInclusao.TabIndex = 25;
            // 
            // lblDtInclusao
            // 
            this.lblDtInclusao.AutoSize = true;
            this.lblDtInclusao.Location = new System.Drawing.Point(12, 64);
            this.lblDtInclusao.Name = "lblDtInclusao";
            this.lblDtInclusao.Size = new System.Drawing.Size(91, 13);
            this.lblDtInclusao.TabIndex = 26;
            this.lblDtInclusao.Text = "Data de Inclusão:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 17);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(125, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 47);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(34, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 47);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(238, 261);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDtInclusao);
            this.Controls.Add(this.txbDtInclusao);
            this.Controls.Add(this.txbCNH);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.txbCTPS);
            this.Controls.Add(this.lblCTPS);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.lblRG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCNH;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.TextBox txbCTPS;
        private System.Windows.Forms.Label lblCTPS;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbDtInclusao;
        private System.Windows.Forms.Label lblDtInclusao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}