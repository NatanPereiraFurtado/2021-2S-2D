CREATE DATABASE Inlock_games_BD
GO

USE Inlock_games_BD
GO

CREATE TABLE ESTUDIO(
idStudio SMALLINT PRIMARY KEY IDENTITY(1,1),
nomeStudio VARCHAR(25) NOT NULL
);
GO

CREATE TABLE JOGOS(
idJogos SMALLINT PRIMARY KEY IDENTITY(1,1),
idStudio SMALLINT FOREIGN KEY REFERENCES ESTUDIO(idStudio),
nomeJogo VARCHAR(20),
descricao VARCHAR(150),
dataLancamento DATE,
valor VARCHAR(15)
);
GO

CREATE TABLE TIPO_USUARIO(
idTipoUsuario SMALLINT PRIMARY KEY IDENTITY(1,1),
titulo VARCHAR(20) NOT NULL
);
GO

CREATE TABLE USUARIO(
idUsuario SMALLINT PRIMARY KEY IDENTITY(1,1),
idTipoUsuario SMALLINT FOREIGN KEY REFERENCES TIPO_USUARIO(idTipoUsuario),
email VARCHAR(35) NOT NULL,
senha VARCHAR(35) NOT NULL
);
GO