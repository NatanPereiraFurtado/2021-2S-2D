USE SP_Medical_Group
GO

INSERT INTO ENDERECO (RuaAvenida,Numero,Bairro,Cidade,siglaEstado,CEP)
VALUES ('Av. Pedro Álvares Cabral',NULL,'Vila Mariana','Sao Paulo', 'SP','04094-050'),
('Av. Paulista','1578','Bela Vista','Sao Paulo', 'SP','01310-200'),
('R. Gomes Leal','112','Vila Dionisia','Sao Paulo', 'SP','0-200'),
('R. do Horto','931','Horto Florestal','São Paulo', 'SP','02377-000'),
('R. Cristiano Olsen',NULL,'jardim Sumaré','Araçatuba', 'SP','160015-244'),
('Av. São João',NULL,'Vila Joana','Jundiaí', 'SP','13216-000'),
('Rua da Imprensa',NULL,'Monte Castelo','Campo Grande', 'SP','19002-290'),
('R. Rodovia Raposo Tavares',NULL,'Lageadinho','Cotia', 'SP','06709-015')
GO


INSERT INTO CLINICA (nomeFantasia,razaoSocial,idEndereco,CNPJ)
VALUES ('Clinica Saude','SP Medical Group', 8,'10.673.694/0001-81')
GO

SELECT * FROM MEDICO

INSERT INTO SITUACAO (Descrição)
VALUES ('Realizado'), ('Cancelado'),('Agendado')
GO
INSERT INTO TIPO_DE_USUARIO (nomeTipo)
VALUES ('Administrador'),('Comum')
GO



INSERT INTO ESPECIALIDADE (NomeEscpecialidade)
VALUES ('Acupultura') ,('Anestesiologia'),('Angiologia'),('Cardiologia'),('Cirurgia Cardiovascular'),('Cirurgia da Mao'),('Cirurgia do Aparelho Digestivo'),('Cirurgia Geral'),('Cirurgia Pediatrica'),('Cirurgia Plastica'),('Cirurgia Toracica'),('Cirurgia Vascula'),('Dermatologia'),('Radioterapia'),('Urologia'),('Pediatria'),('Psiquiatria')
GO

INSERT INTO MEDICO (idClinica,idEspecialidade,Nome,Email,Senha,CRM)
VALUES (2,2,'Luisa Fontes','luisa.fontes@spmedicalgroup.com.br','12345678','54679-SP'),(2,17,'Roberto Rodigues','roberto.rodrigues@spmedicalgroup.com.br','12345678','53679-SP'),(2,16,'Anna Santos','anna.santos@spmedicalgroup.com.br','12345678','65679-SP')
GO
 
INSERT INTO USUARIO (idTipoUsuario,idEndereco,Nome,Email,Senha,DataNascimento,Telefone, Rg,CPF)
VALUES (2, 1,'Marcus', 'marcus@gmail.com','12345678', '1983/10/13','11 3456-7654','43522543-5','94839859000'),
(2, 2,'Rubens', 'rubens@gmail.com','12345678', '2001/07/23','11 98765-6543','32654345-7','73556944057'),
(2,3, 'Heriton','heriton@gmail.com','12345678','1978/10/10','11 97208-4453','54636525-3','16839338002'),
(2,4, 'Henrique','henrique@gmail.com','12345678','1985/10/13','11 3456-6543','54366362-5','14332654765'),
(2,5, 'David','david@hotmail.com','12345678','1975/08/27','11 7656-6377','53254444-1','91305348010'),
(2,6, 'Renato','renato@gmail.com','12345678','1972/03/21','11 95436-8769','54566266-7','79799299004'),
(2,7, 'Anna','anna@outlook.com','12345678','2018/03/05',NULL,'54566266-8','13771913039')
GO



INSERT INTO CONSULTA (idSituacao,idUsuario,idMedico,DataConsulta,Descricao)
VALUES (1,13,4,'01/20/2020 15:00','Remedio diagnosticado'),
(2,8,3,'06/01/2020 10:00','Cancelado'),
(1,9,3,'07/02/2020 11:00','Ultima Sessao Terapeutica'),
(1,8,3,'06/02/2018 10:00','Diagnostico feito'),
(2,10,2,'07/02/2019 11:00','Cancelado'),
(3,13,4,'08/03/2020 15:00','Para consulta'),
(3,10,2,'09/03/2020 11:00','Para consulta')
GO