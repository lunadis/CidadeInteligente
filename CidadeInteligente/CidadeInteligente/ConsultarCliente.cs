using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CidadeInteligente
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            retornarCliente();
        }
        private void retornarCliente() {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            string retCliente = string.Concat("exec retornoCliente");
            conexao.Open();
            SqlCommand retClienteSQL = new SqlCommand(retCliente,conexao);
            SqlDataAdapter sda = new SqlDataAdapter(retClienteSQL);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvCliente.DataSource = dt;

            conexao.Close();
        
        }
        private void pesquisarCliente(string a)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string pesquisarFun = string.Concat("select p.nmPessoa,p.dsEndereco, pd.nrCPF, cli.dtInclusao from tb_pessoas as p inner join tb_cliente as cli on cli.cdPessoa = p.cdPessoa inner join tb_PessoaDocumento as pd on pd.cdPessoa = cli.cdPessoa  where pd.nrCPF = '", a, "'");
            SqlCommand pesquisarFuncSQL = new SqlCommand(pesquisarFun, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(pesquisarFuncSQL);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvCliente.DataSource = dt;

            conexao.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarCliente(txbCPF.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCPF.Text = null;
            retornarCliente();
        }
    }
}
