create database Intermex
use Intermex


Create table Categorias(
id_categoria int primary key not null identity (1,1),
Nombre_categoria varchar (20)
)



Create table Revista(
id_revista int identity (1,1) primary key ,
Titulo varchar(25),
Descripcion varchar(50),
Edicion int,
CodigoBarras varchar(15),
Precio decimal, 
FechaPublicacion date,
Categoria_Id int,
constraint FK_Categoria_Id foreign key (Categoria_Id)
references Categorias (id_categoria)
)

select * from Revista


insert into Categorias (Nombre_categoria)
values('Ciencia')
insert into Categorias (Nombre_categoria)
values('Historia')
insert into Categorias (Nombre_categoria)
values('Comics')
select * from Categorias




















