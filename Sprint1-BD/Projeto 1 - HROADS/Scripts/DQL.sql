USE HROADS
GO

SELECT * FROM personagem;
GO

SELECT * FROM classe;
GO

SELECT * FROM personagem;

SELECT * FROM tipoHabilidade;
GO

SELECT * FROM habilidade
GO

SELECT nomeClasse Classe
FROM classe;
GO

SELECT TOP 3 nomePersonagem, nomeClasse, capacidadeMaxVida, capacidadeMaxMana,
ROW_NUMBER() OVER(ORDER BY capacidadeMaxVida) as 'ROW_NUMBER',
RANK() OVER(OERDER BY capacidadeMaxVida) as 'Rank',
DENSE_RANK() OVER(ORDER BY capacidadeMaxVida) as 'DENSE_RANK'
FROM personagem
INNER JOIN classe
ON personagem.IdClasse = classe.IdClasse;
GO

SELECT
COUNT(*) as 'Quantidade de habilidade cadastradas'
FROM habilidade

SELECT IdHabilidade
FROM habilidade
ORDER BY IdHabilidade ASC;
GO

SELECT * FROM tipoHabilidade;
GO

SELECT nomeHabilidade, nomeTipoHabilidade
FROM habilidade
LEFT JOIN tipoHabilidade
ON habilidade.IdHabilidade = tipoHabilidade.IdHabilidade

SELECT nomePersonagem, nomeclasse 
FROM personagem 
LEFT JOIN classe 
ON personagem.IdClasse = classe.IdClasse

SELECT nomePersonagem, nomeclasse
FROM personagem
RIGHT JOIN classe
ON
personagem.IdClasse = classe.IdClasse

SELECT nomeClasse, nomeHabilidade as 'Habilidade Primaria'
FROM classe
LEFT JOIN habilidade
ON classe.habilidadePrimaria = habilidade.IdHabilidade

SELECT nomeClasse, nomehabilidade Habilidade
FROM classe
INNER JOIN habilidade
ON classe.habilidadePrimaria = habilidade.IdHabilidade

SELECT nomeClasse, nomeHabilidade as 'Habilidade Primaria'
FROM classe
RIGHT JOIN habilidade
ON classe.habilidadePrimaria = habilidade.IdHabilidade 
