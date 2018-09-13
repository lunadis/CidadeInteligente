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
    public partial class ConsultarPessoa : Form
    {
        public ConsultarPessoa()
        {
            InitializeComponent();
            retornarPessoas();
        }
        private void retornarPessoas() {

            dgvPessoas.DataSource = null;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            string retorPessoas = string.Concat("SELECT * FROM tb_pessoas");
            conexao.Open();
            SqlCommand retorPessoasSQL = new SqlCommand(retorPessoas, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(retorPessoasSQL);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoas.DataSource = dt;

            conexao.Close();
            


        }      
        private void pesquisarPessoa(int a) {

            dgvPessoas.DataSource = null;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string pesquisarPe = string.Concat("SELECT * FROM tb_pessoas where cdPessoa =",a,"");
            SqlCommand pesquisarPeSQL = new SqlCommand(pesquisarPe,conexao);
            SqlDataAdapter sda = new SqlDataAdapter(pesquisarPeSQL);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoas.DataSource = dt;

            conexao.Close();
        }
        private void pesquisarPessoa(string c)
        {

            dgvPessoas.DataSource = null;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string pesquisarPe = string.Concat("SELECT * FROM tb_pessoas where nmPessoa LIKE '%", c, "%'");
            SqlCommand pesquisarPeSQL = new SqlCommand(pesquisarPe, conexao);
             SqlDataAdapter sda = new SqlDataAdapter(pesquisarPeSQL);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoas.DataSource = dt;

            conexao.Close();

        }
        private void atualizarPessoa()
        {
            dgvPessoas.DataSource = null;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string atPessoa = string.Concat("UPDATE tb_pessoas SET dsEstadoCivil = '", txbEstadoCivil.Text, "' where cdPessoa = ", lblid.Text, ";" +
                                            "UPDATE tb_pessoas SET nmPessoa = '", txbNome.Text, "' where cdPessoa = ", lblid.Text, ";" +
                                            "UPDATE tb_pessoas SET dsEndereco = '", txbEndereco.Text, "' where cdPessoa = ", lblid.Text, ";" +
                                            "UPDATE tb_pessoas SET dtNascimento = '", txbDtNascimento.Text, "' where cdPessoa = ", lblid.Text, "");
            SqlCommand atPessoaSQL = new SqlCommand(atPessoa, conexao);
            atPessoaSQL.ExecuteNonQuery();
            conexao.Close();

        }
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNome.Text = dgvPessoas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbEndereco.Text = dgvPessoas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbEstadoCivil.Text = dgvPessoas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbDtNascimento.Text = dgvPessoas.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblid.Text = dgvPessoas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void limpar() {
            retornarPessoas();
            txbNome.Text = null;
            txbEstadoCivil.Text = null;
            txbEndereco.Text = null;
            txbDtNascimento.Text = null;
            txbRG.Text = null;
            txbCPF.Text = null;
            txbCTPS.Text = null;
            txbCNH.Text = null;
            lblid.Text = null;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            atualizarPessoa();
            limpar();
            retornarPessoas();
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                pesquisarPessoa(txbnmPessoa.Text);
            }
            else
            {
                pesquisarPessoa(Convert.ToInt32(txtId.Text));
            }
        }
    }
}
