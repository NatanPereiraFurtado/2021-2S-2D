USE HROADS
GO

INSERT INTO tipoHabilidade
VALUES ('Magia');
GO

INSERT INTO habilidade(nomeHabilidade, IdTipoHabilidade)
VALUES ('Recuperar VIda', 3);
GO

INSERT INTO classe(nomeClasse, habilidadePrimaria)
VALUES ('Arcanista', NULL);
GO

INSERT INTO personagem(nomePersonagem, IdClasse, capacidadeMaxVida, capacidadeMaxMana, daaAtualizacao, dataCriacao)
VALUES ('Lucas', 3, 40, 80, '05-09-2021', '16-07-2018');
GO

UPDATE personagem
SET nomePersonagem = 'Kat2'
WHERE nomePersonagem = 'Kat3';
GO

SELECT * FROM habilidade

SELECT * FROM classe