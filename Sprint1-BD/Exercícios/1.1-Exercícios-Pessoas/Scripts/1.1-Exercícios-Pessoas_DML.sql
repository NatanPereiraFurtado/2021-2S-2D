USE EMPRESA;
GO

INSERT INTO PESSOA (nomePessoa)
VALUES ('David'),('Augustho');
GO

SELECT * FROM PESSOA

INSERT INTO TELEFONE (idPessoa,numeroTelefone)
VALUES (1,'999'), (2,'888');
GO

SELECT * FROM TELEFONE

INSERT INTO EMAIL (idPessoa,enderecoEmail)
VALUES (1,'david.pereira@email.com'), (2,'augustho.cavalcante@email.com');
GO

SELECT * FROM EMAIL

INSERT INTO CNH (idPessoa,descricao)
VALUES (1,'2306'), (2,'2260');
GO

SELECT * FROM CNH
SELECT * FROM EMAIL
SELECT * FROM TELEFONE
SELECT * FROM PESSOA