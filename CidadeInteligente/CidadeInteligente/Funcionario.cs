using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace CidadeInteligente
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCargo.Text = "";
            txbSalario.Text = "";
            txbRamal.Text = "";
            txbRG.Text = "";
            txbCPF.Text = "";
            txbCTPS.Text = "";
            txbCNH.Text = "";

        }
    }
}
