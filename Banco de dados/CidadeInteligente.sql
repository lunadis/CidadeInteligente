use master
drop database CidadeInteligente
go

create database CidadeInteligente
go

use CidadeInteligente
go


create table tb_pessoas(
	cdPessoa int NOT NULL identity (1,1),
	nmPessoa varchar(250),
	dsEndereco varchar(250),
	dsEstadoCivil varchar(250),
	dtNascimento date,

	PRIMARY KEY (cdPessoa)
)
create table tb_PessoaDocumento(
	cdPessoaDocumento int NOT NULL identity (1,1),
	cdPessoa int NOT NULL,
	nrRG varchar(32),
	nrCPF varchar(60),
	nrReservista varchar(32),
	nrCTPS varchar(32),
	nrCNH varchar(32),
	
	PRIMARY KEY (cdPessoaDocumento),
	FOREIGN KEY (cdPessoa) references tb_pessoas (cdPessoa)
)
create table tb_Funcionario(
	cdFuncionario int not null identity (1,1),
	cdPessoa int not null,
	nmCargo varchar(150),
	nrSalario varchar(50),
	nrRamal varchar(12),
	
	PRIMARY KEY (cdFuncionario),
	FOREIGN KEY (cdPessoa) references tb_pessoas (cdPessoa)	
)
create table tb_cliente(
	cdCliente int not null identity (1,1),
	cdPessoa int not null,
	dtInclusao date,
	
	primary key (cdCliente),
	foreign key (cdPessoa) references tb_pessoas (cdPessoa)
)

insert into tb_cliente(cdPessoa,dtInclusao) values (3,GETDATE());
SELECT * FROM tb_cliente;

Select p.cdPessoa,p.nmPessoa, d.nrCPF from tb_pessoas as p inner join tb_PessoaDocumento as d on p.cdPessoa = d.cdPessoa where d.nrCPF = '321';


select * from tb_pessoas;
select * from tb_PessoaDocumento;
select * from tb_Funcionario
SELECT cdPessoa, nmPessoa,  FROM tb_pessoas where nmPessoa LIKE 'paloma%' ;