namespace CidadeInteligente
{
    partial class Pessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pessoas));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbEstadoCivil = new System.Windows.Forms.TextBox();
            this.txbDtNascimento = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblCTPS = new System.Windows.Forms.Label();
            this.txbCTPS = new System.Windows.Forms.TextBox();
            this.lblCNH = new System.Windows.Forms.Label();
            this.txbCNH = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(75, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Pessoas";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 64);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(12, 87);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 3;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(12, 112);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(92, 13);
            this.lblDtNascimento.TabIndex = 4;
            this.lblDtNascimento.Text = "Data Nascimento:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(111, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(164, 20);
            this.txbNome.TabIndex = 5;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(111, 61);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(100, 20);
            this.txbEndereco.TabIndex = 6;
            // 
            // txbEstadoCivil
            // 
            this.txbEstadoCivil.Location = new System.Drawing.Point(111, 84);
            this.txbEstadoCivil.Name = "txbEstadoCivil";
            this.txbEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.txbEstadoCivil.TabIndex = 7;
            // 
            // txbDtNascimento
            // 
            this.txbDtNascimento.Location = new System.Drawing.Point(111, 109);
            this.txbDtNascimento.Name = "txbDtNascimento";
            this.txbDtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txbDtNascimento.TabIndex = 8;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(12, 140);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 9;
            this.lblRG.Text = "RG:";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(111, 135);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(100, 20);
            this.txbRG.TabIndex = 10;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 162);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 11;
            this.lblCPF.Text = "CPF:";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(111, 162);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 12;
            // 
            // lblCTPS
            // 
            this.lblCTPS.AutoSize = true;
            this.lblCTPS.Location = new System.Drawing.Point(12, 189);
            this.lblCTPS.Name = "lblCTPS";
            this.lblCTPS.Size = new System.Drawing.Size(38, 13);
            this.lblCTPS.TabIndex = 13;
            this.lblCTPS.Text = "CTPS:";
            // 
            // txbCTPS
            // 
            this.txbCTPS.Location = new System.Drawing.Point(111, 186);
            this.txbCTPS.Name = "txbCTPS";
            this.txbCTPS.Size = new System.Drawing.Size(100, 20);
            this.txbCTPS.TabIndex = 14;
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(12, 213);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(33, 13);
            this.lblCNH.TabIndex = 15;
            this.lblCNH.Text = "CNH:";
            // 
            // txbCNH
            // 
            this.txbCNH.Location = new System.Drawing.Point(111, 210);
            this.txbCNH.Name = "txbCNH";
            this.txbCNH.Size = new System.Drawing.Size(100, 20);
            this.txbCNH.TabIndex = 16;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(49, 248);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 47);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(140, 248);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 47);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(310, 307);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbCNH);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.txbCTPS);
            this.Controls.Add(this.lblCTPS);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txbDtNascimento);
            this.Controls.Add(this.txbEstadoCivil);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pessoas";
            this.Text = "Pessoa";
            this.Load += new System.EventHandler(this.Pessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbEstadoCivil;
        private System.Windows.Forms.TextBox txbDtNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblCTPS;
        private System.Windows.Forms.TextBox txbCTPS;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.TextBox txbCNH;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}