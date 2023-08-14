create table produto (
codigo serial primary key,
descricao varchar(100),
dataValidade date,
preco float,
taxaLucro float);

select * from produto;