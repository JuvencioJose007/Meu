create table aluno (
RA int primary key,
nome varchar (30),
email varchar (40)
)
create table grupo (
codigo int primary key identity (1, 1),
nome_grupo varchar (30),
descricao varchar (50),
nota char(2) check (nota >= 0 and nota <= 10)
)
create table professor (
codigo int primary key identity (10000, 1),
nome varchar (30),
disciplina varchar (30)
)
create table avaliado(
codigo_grupo int foreign key references grupo (codigo),
codigo_professor int foreign key references professor (codigo),
calendario char (11),
horarios char (6)
)
insert into avaliado
values (1, 10000, '31/05/2018', '13:30'),
        (2, 10000, '05/04/2018', '12:30'),
        (2, 10001, '05/04/2018', '12:30'),
        (1, 10002, '08/06/2018', '14:00')

insert into aluno
values (51029, 'Juvencio Jose', 'jose-jose@gmail.com'),
        (51075, 'Raissa Soares', 'raissa-soares@hotmail.com'),
        (51030, 'Arthur Nunes', 'arthur-nunes@gmail.com'),
        (51035, 'Debora Siqueira', 'siqueira-debora@outlook.com')

insert into grupo
values ('Control Term', 'controle de temperatura em ambiente', 10),
        ('wolfTec', 'controle de temperatura em escritorios', 8)

insert into professor
values ('Anderson Silva', 'Tecnologia da informação'),
        ('Carlos Rafael', 'Algoritmo'),
        ('Siberia Martins','Infraestrutura')

select * from aluno
select * from professor 
select * from grupo
select * from avaliado