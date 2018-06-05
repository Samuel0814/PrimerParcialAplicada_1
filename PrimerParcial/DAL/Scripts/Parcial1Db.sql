CREATE DATABASE Parcial1Db
GO
USE Parcial1Db
GO
CREATE TABLE Grupos(
	GrupoId int primary key identity,
	Fecha date,
	Descripcion varchar(50),
	Cantidad int,
	Grupos int,
	Integrantes int
);