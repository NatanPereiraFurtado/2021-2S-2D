USE Inlock_games_BD;
GO

INSERT INTO TIPO_USUARIO(titulo)
VALUES ('ADMINISTRADOR'),('CLIENTE')
GO

INSERT INTO USUARIO(idTipoUsuario, email, senha)
VALUES(1, 'adm@admin.com', 'admin'),(2, 'cliente@cliente.com', 'cliente')
GO

INSERT INTO ESTUDIO(nomeStudio)
VALUES ('Blizzard'),('Rockstar Studio'),('Square Enix')
GO

INSERT INTO JOGOS(idStudio, nomeJogo, descricao, dataLancamento, valor)
VALUES (1, 'Diablo 3', 'É um jogo que contem bastante ação e é viciante, seja você um novato ou um fã.', '15/02/2012', 'R$99,00'),(2, 'Red Dead Redemption II', 'Jogo de ação-aventura western.', '26/10/2018', 'R$120,00')
GO