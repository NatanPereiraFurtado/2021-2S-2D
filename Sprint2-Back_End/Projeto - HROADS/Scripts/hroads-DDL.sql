CREATE DATABASE HROADS
GO

USE HROADS
GO

CREATE TABLE tipoHabilidade(
IdTipoHabilidade TINYINT PRIMARY KEY IDENTITY,
nomeTipoHabilidade VARCHAR(20) NOT NULL
);
GO

CREATE TABLE habilidade(
IdHabilidade TINYINT PRIMARY KEY IDENTITY
IdTipoHabilidade TINYINT FOREIGN KEY REFERENCES tipoHabilidade(IdTipoHabilidade),
nomeHabilidade VARCHAR(50)
);
GO

CREATE TABLE classe(
IdClasse TINYINT PRIMARY KEY IDENTITY,
habilidadePrimaria TINYINT FOREIGN KEY REFERENCES habilidade(IdHabilidade),
nomeClasse VARCHAR(20) NOT NULL
);
GO

CREATE TABLE personagem(
IdPersonagem TINYINT PRIMARY KEY IDENTITY,
IdClasse TINYINT FOREIGN KEY REFERENCES classe(IdClasse),
nomePersonagem VARCHAR(20) NOT NULL,
capacidadeMaxVida TINYINT NOT NULL,
capacidadeMaxMana TINYINT NOT NULL,
dataAtualizacao Datetime NOT NULL,
dataCriacao
);
GO