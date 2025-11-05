create database if not exists escola;
use escola;

create table if not exists alunos (
  Id int auto_increment primary key,
  Nome VARCHAR(100) not null,
  Idade INT not null,
  Curso VARCHAR(50) not null
);

# Testes
select * from alunos;
delete from alunos;
truncate table alunos;
