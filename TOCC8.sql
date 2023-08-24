create table mensagem(
codigo serial primary key,
usuario varchar(50) not null,
msg varchar(4096));