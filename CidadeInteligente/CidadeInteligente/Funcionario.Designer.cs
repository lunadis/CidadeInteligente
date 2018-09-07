namespace CidadeInteligente
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbCNH = new System.Windows.Forms.TextBox();
            this.lblCNH = new System.Windows.Forms.Label();
            this.txbCTPS = new System.Windows.Forms.TextBox();
            this.lblCTPS = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.LBLcpf = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbRamal = new System.Windows.Forms.TextBox();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.txbCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(167, 245);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 46);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(60, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 46);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbCNH
            // 
            this.txbCNH.Location = new System.Drawing.Point(111, 198);
            this.txbCNH.Name = "txbCNH";
            this.txbCNH.Size = new System.Drawing.Size(100, 20);
            this.txbCNH.TabIndex = 35;
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(4, 201);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(33, 13);
            this.lblCNH.TabIndex = 34;
            this.lblCNH.Text = "CNH:";
            // 
            // txbCTPS
            // 
            this.txbCTPS.Location = new System.Drawing.Point(111, 174);
            this.txbCTPS.Name = "txbCTPS";
            this.txbCTPS.Size = new System.Drawing.Size(100, 20);
            this.txbCTPS.TabIndex = 33;
            // 
            // lblCTPS
            // 
            this.lblCTPS.AutoSize = true;
            this.lblCTPS.Location = new System.Drawing.Point(6, 177);
            this.lblCTPS.Name = "lblCTPS";
            this.lblCTPS.Size = new System.Drawing.Size(38, 13);
            this.lblCTPS.TabIndex = 32;
            this.lblCTPS.Text = "CTPS:";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(111, 150);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 31;
            // 
            // LBLcpf
            // 
            this.LBLcpf.AutoSize = true;
            this.LBLcpf.Location = new System.Drawing.Point(7, 150);
            this.LBLcpf.Name = "LBLcpf";
            this.LBLcpf.Size = new System.Drawing.Size(30, 13);
            this.LBLcpf.TabIndex = 30;
            this.LBLcpf.Text = "CPF:";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(111, 123);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(100, 20);
            this.txbRG.TabIndex = 29;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(7, 126);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 28;
            this.lblRG.Text = "RG:";
            // 
            // txbRamal
            // 
            this.txbRamal.Location = new System.Drawing.Point(111, 97);
            this.txbRamal.Name = "txbRamal";
            this.txbRamal.Size = new System.Drawing.Size(100, 20);
            this.txbRamal.TabIndex = 26;
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(111, 74);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(100, 20);
            this.txbSalario.TabIndex = 25;
            // 
            // txbCargo
            // 
            this.txbCargo.Location = new System.Drawing.Point(111, 51);
            this.txbCargo.Name = "txbCargo";
            this.txbCargo.Size = new System.Drawing.Size(100, 20);
            this.txbCargo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ramal da Empresa:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(6, 81);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 21;
            this.lblSalario.Text = "Salário:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(7, 54);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 20;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(70, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 17);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Cadastro de Funcionários";
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(341, 314);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbCNH);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.txbCTPS);
            this.Controls.Add(this.lblCTPS);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.LBLcpf);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txbRamal);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.txbCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbCNH;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.TextBox txbCTPS;
        private System.Windows.Forms.Label lblCTPS;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label LBLcpf;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbRamal;
        private System.Windows.Forms.TextBox txbSalario;
        private System.Windows.Forms.TextBox txbCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTitulo;
    }
}