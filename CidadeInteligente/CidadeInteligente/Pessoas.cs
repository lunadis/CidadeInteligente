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
            
            //criando objeto da classe de conzeão System.data.Sqlclient.
            SqlConnection conexao = new SqlConnection();
            //passando a string de conexão que nada mais é que o caominho para o acesso, senhas e permissões
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            //abrindo conexao
            conexao.Open();

            //aqui é onde a gente cria o comando do SQL
            string insertPessoa = string.Concat("insert into tb_pessoas (nmPessoa,dtNascimento,dsEstadoCivil,dsEndereco) values ('",pessoa1.nmPessoa,"','",pessoa1.dtNascimento,"','",pessoa1.dsEstadoCivil,"','",pessoa1.dsEndereco,"');");
            //instanciando o obejto que vai enviar o o comando para o sql como o preparedStatment do java
            // porém ja vai com dois argumentos: a string com o comando SQL e o "caminho" 
            SqlCommand comandoSQL = new SqlCommand(insertPessoa, conexao);
            //Executando o comando que inserimos no objeto, usando o caminho que passamos pelo objeto conexao.
            comandoSQL.ExecuteNonQuery();

            conexao.Close();
            lista_pessoas.Add(pessoa1);
        }

        private void inserirPessoaDocumento()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LOPESPC";
            conexao.Open();
            
            //query para selecionar o ultimo id inserido
            string verificarID = string.Concat("SELECT MAX(cdPessoa) FROM tb_pessoas");
            //obejeto que vai enviar o comando que verifica
            SqlCommand verificarIDSQL = new SqlCommand(verificarID, conexao);
            //Executando o comando e atribuido a um leitor (retorna o resultado da query no banco
            SqlDataReader resultID = verificarIDSQL.ExecuteReader();
           
            //instancia da classe pessoa
            PessoaDocumento pDocumentos1 = new PessoaDocumento();
            
            //processo de leitura do resultado da query é precisod e while, entende=se como: enquanto tiver linhas
            while (resultID.Read())
            {   
                // atribuindo o valor do resultado o zero entre () é a identificação da coluna, como um array de 0...99 
                pDocumentos1.cdPessoa = resultID.GetInt32(0);
            }
            Console.WriteLine(pDocumentos1.cdPessoa);
            pDocumentos1.nrRG = txbRG.Text;
            pDocumentos1.nrCPF = txbCPF.Text;
            pDocumentos1.nrCTPS = txbCTPS.Text;
            pDocumentos1.nrCNH = txbCNH.Text;
            
            // é preciso fechar a conexão depois de usar um reader(no caso o result ID)
           conexao.Close();
            //o bloco acima pode ser outro metodo
           
           conexao.Open();

           string insertPdoc = string.Concat("insert into tb_PessoaDocumento (cdPessoa,nrRG,nrCPF,nrCNH,nrCTPS,nrReservista) values(", pDocumentos1.cdPessoa, ",'", pDocumentos1.nrRG, "','", pDocumentos1.nrCPF, "','", pDocumentos1.nrCNH, "','", pDocumentos1.nrCTPS, "','", pDocumentos1.nrReservista, "');");
           SqlCommand comandoSQL = new SqlCommand(insertPdoc, conexao);
           comandoSQL.ExecuteNonQuery();

           conexao.Close();
            

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
            MessageBox.Show("Registro Cadastrado", "PESSOA");
        }
    }
}
