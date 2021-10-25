USE Inlock_games_BD
GO

SELECT * FROM USUARIO
GO

SELECT * FROM ESTUDIO
GO

SELECT * FROM JOGOS
GO

SELECT nomeStudio, nomeJogo FROM JOGOS
RIGHT JOIN ESTUDIO
ON JOGOS.idStudio = ESTUDIO.idStudio;
GO

SELECT idUsuario, email, senha FROM USUARIO
WHERE email = 'cliente@cliente.com' AND senha = 'cliente';
GO

SELECT idJogos, nomeJogo FROM JOGOS
WHERE idJogos = 2;
GO

SELECT idUsuario, nomeStudio FROM ESTUDIO
WHERE idStudio = 3;
GO

SELECT ISNULL(idJogos, 0), ISNULL(JOGOS.idStudio, 0), ISNULL(nomeStudio, 'Não Cadastrado'), ISNULL(nomeJogo, 'Não Cadastrado'), ISNULL(descricao, 'Sem descrição'), ISNULL(dataLancamento, ''), ISNULL(valor,0) FROM  JOGOS
FULL OUTER JOIN ESTUDIO ON JOGOS.idStudio = ESTUDIO.idStudio
GO