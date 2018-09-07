using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CidadeInteligente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoas telaCadPessoa = new Pessoas();
            telaCadPessoa.MdiParent = this;
            telaCadPessoa.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario telaCadFuncionario = new Funcionario();
            telaCadFuncionario.MdiParent = this;
            telaCadFuncionario.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente telaCadCliente = new Cliente();
            telaCadCliente.MdiParent = this;
            telaCadCliente.Show();
        }
    }
}
