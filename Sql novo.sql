create database BDTurismo

use BDTurismo
		  

create table tbl_usuario 
(
cdlogin_usuario int primary key identity,
email_usuario varchar (50) not null,
senha_usuario varchar (50) not null,
nm_usuario varchar (50) not null,
cpf_usuario varchar (15) not null
)

insert into tbl_usuario
(email_usuario,senha_usuario,nm_usuario,cpf_usuario) values ('admin','admin01','adminn','11111111111')

select * from tbl_usuario

create table tbl_cliente 
(
cd_cliente int primary key identity,
nasc_cliente varchar(10) not null,
sexo_cliente char(1) not null,
cep_cliente varchar (11) not null,
email_cliente varchar (50) not null,
cpf_cliente varchar (11) not null,
nome_cliente varchar (50) not null,
celular_cliente varchar (15) not null
)


select * from tbl_cliente



create table tbl_venda 
(
cd_venda int primary key identity,
cdlogin_usuario int,
cd_cliente int,
formadepagamento_venda varchar (20) not null,
foreign key (cdlogin_usuario) references tbl_usuario(cdlogin_usuario),
foreign key (cd_cliente) references tbl_cliente(cd_cliente),
)


create table tbl_pacote
(
cd_pacote int primary key identity,
hospedagem_pacote  varchar (50) not null,
hrsaida_pacote varchar (8) not null,
dtsaida_pacote date not null,
dtretorno_pacote date not null,
destino_pacote varchar (50) not null,
nm_pacote varchar (50) not null,
preco_pacote varchar (15) not null,
cd_venda int,
foreign key (cd_venda) references tbl_venda(cd_venda)
)

select * from tbl_pacotee


