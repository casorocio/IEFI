CREATE DATABASE IEFI;
GO

USE IEFI;
GO

CREATE TABLE Clientes (
	Id INT IDENTITY(1,1) NOT NULL,
	Nombre NCHAR(50) NOT NULL,
	IdProvincia int NOT NULL,
	CONSTRAINT PK_Clientes_Id PRIMARY KEY (Id)
	);

CREATE TABLE Provincias (
	Id INT IDENTITY(1,1) NOT NULL,
	Provincias NCHAR(50) NOT NULL,
	CONSTRAINT PK_Provincias_Id PRIMARY KEY (Id)
	);
