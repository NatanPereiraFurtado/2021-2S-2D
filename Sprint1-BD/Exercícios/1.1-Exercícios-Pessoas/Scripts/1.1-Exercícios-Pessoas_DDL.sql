CREATE DATABASE EMPRESA;
GO

USE EMPRESA;
GO

CREATE TABLE PESSOA (
	idPessoa SMALLINT PRIMARY KEY IDENTITY (1,1),
	nomePessoa VARCHAR(20) NOT NULL
);
GO

CREATE TABLE TELEFONE(
	idTelefone SMALLINT PRIMARY KEY IDENTITY (1,1),
	numeroTelefone VARCHAR(15) NOT NULL,
	idPessoa SMALLINT FOREIGN KEY REFERENCES PESSOA(idPessoa)
);
GO

CREATE TABLE EMAIL(
	idEmail SMALLINT PRIMARY KEY IDENTITY (1,1),
	enderecoEmail VARCHAR(35) NOT NULL,
	idPessoa SMALLINT FOREIGN KEY REFERENCES PESSOA(idPessoa)
);
GO

CREATE TABLE CNH(
	idCNH SMALLINT PRIMARY KEY IDENTITY (1,1),
	descricao VARCHAR(35) NOT NULL UNIQUE,
	idPessoa SMALLINT FOREIGN KEY REFERENCES PESSOA(idPessoa),
);
GO