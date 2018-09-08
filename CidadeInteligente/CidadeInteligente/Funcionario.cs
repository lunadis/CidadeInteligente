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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void pesquisarFunc(int a) {

            
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string pesquisarFun = string.Concat("SELECT cdPessoa, nmPessoa FROM tb_pessoas where cdPessoa =",a,"");
            SqlCommand pesquisarFuncSQL = new SqlCommand(pesquisarFun,conexao);
            SqlDataReader resultPsq = pesquisarFuncSQL.ExecuteReader();
            while (resultPsq.Read()) {
                lblCodigo.Text = resultPsq.GetInt32(0).ToString();
                lblnmFuncionario.Text = (resultPsq.GetString(1));
            }
            conexao.Close();

        }
        private void pesquisarFunc(string c)
        {


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string pesquisarFun = string.Concat("SELECT cdPessoa, nmPessoa FROM tb_pessoas where nmPessoa LIKE '%",c,"%'");
            SqlCommand pesquisarFuncSQL = new SqlCommand(pesquisarFun, conexao);
            SqlDataReader resultPsq = pesquisarFuncSQL.ExecuteReader();
            while (resultPsq.Read())
            {
                lblCodigo.Text = resultPsq.GetInt32(0).ToString();
                lblnmFuncionario.Text = (resultPsq.GetString(1));
            }
            conexao.Close();

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                pesquisarFunc(nmFunc.Text);
            }
            else{                
                pesquisarFunc(Convert.ToInt32(txtId.Text));
            }
            
        }
        private void inserirFunc() {

            Pfuncionario pfunc1 = new Pfuncionario();

            pfunc1.cdPessoa = Convert.ToInt32(lblCodigo.Text);
            pfunc1.nmCargo = txbCargo.Text;
            pfunc1.nrSalario = txbSalario.Text;
            pfunc1.nrRamal = txbSalario.Text;

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            string inserirFunc1 = string.Concat("insert into tb_Funcionario(cdPessoa, nmCargo,nrSalario,nrRamal) values (",pfunc1.cdPessoa,",'",pfunc1.nmCargo,"',",pfunc1.nrSalario,",",pfunc1.nrRamal,")");
            SqlCommand inserirFuncSQL = new SqlCommand(inserirFunc1, conexao);
            inserirFuncSQL.ExecuteNonQuery();

            conexao.Close();

            
        
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inserirFunc();
            MessageBox.Show("Registro Cadastrado", "FUNCIONARIO");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCargo.Text = "";
            txbSalario.Text = "";
            txbRamal.Text = "";
        }

    
    }
}
