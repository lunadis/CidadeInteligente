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
    public partial class Pessoas : Form
    {
        public Pessoas()
        {
            InitializeComponent();
        }

        List<Pessoa> lista_pessoas = new List<Pessoa>();
        List<PessoaDocumento> lista_documentos = new List<PessoaDocumento>();

        private void Pessoas_Load(object sender, EventArgs e)
        {
            

        }

        private void inserirPessoa()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nmPessoa = txbNome.Text;
            pessoa1.dsEndereco = txbEndereco.Text;
            pessoa1.dsEstadoCivil = txbEstadoCivil.Text;
            pessoa1.dtNascimento = Convert.ToDateTime(txbDtNascimento.Text);

            lista_pessoas.Add(pessoa1);
        }

        private void inserirPessoaDocumento()
        {
            PessoaDocumento pDocumentos1 = new PessoaDocumento();

            pDocumentos1.nrRG = txbRG.Text;
            pDocumentos1.nrCPF = txbCPF.Text;
            pDocumentos1.nrCTPS = txbCTPS.Text;
            pDocumentos1.nrCNH = txbCNH.Text;

            lista_documentos.Add(pDocumentos1);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbEndereco.Text = "";
            txbEstadoCivil.Text = "";
            txbRG.Text = "";
            txbCPF.Text = "";
            txbCTPS.Text = "";
            txbCNH.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inserirPessoa();
            inserirPessoaDocumento();
        }
    }
}
