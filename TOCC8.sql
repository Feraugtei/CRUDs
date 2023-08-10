--create database TOCC8; 

--use TOCC8;

create table cliente (
codigo serial primary key,
nome varchar(100),
idade int check(idade>0));

select * from cliente; --consultar tabela