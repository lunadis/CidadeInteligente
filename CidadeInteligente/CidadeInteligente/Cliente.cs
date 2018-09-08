using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Classes;

namespace CidadeInteligente
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {  
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCPF.Text = "";
           
        }
        private void pesquisarCliente(string a) {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string pesquisarFun = string.Concat("Select p.cdPessoa,p.nmPessoa, d.nrCPF from tb_pessoas as p inner join tb_PessoaDocumento as d on p.cdPessoa = d.cdPessoa where d.nrCPF = '",a,"'");
            SqlCommand pesquisarFuncSQL = new SqlCommand(pesquisarFun, conexao);
            SqlDataReader resultPsq = pesquisarFuncSQL.ExecuteReader();
            while (resultPsq.Read())
            {
                lblCodigoCliente.Text = resultPsq.GetInt32(0).ToString();
                lblNomeCliente.Text = resultPsq.GetString(1);
            }
            conexao.Close();
        }
        private void inserirCliente(string a)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string inserirCliente1 = string.Concat("insert into tb_cliente(cdPessoa,dtInclusao) values (",a,",GETDATE())");
            SqlCommand inserirClienteSQL = new SqlCommand(inserirCliente1, conexao);
            inserirClienteSQL.ExecuteNonQuery();

            conexao.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarCliente(txbCPF.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inserirCliente(lblCodigoCliente.Text);
            MessageBox.Show("Registro Cadastrado", "CLIENTE");
        }


    }
}
