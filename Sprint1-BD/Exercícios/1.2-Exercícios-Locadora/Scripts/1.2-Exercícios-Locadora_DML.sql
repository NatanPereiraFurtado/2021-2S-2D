USE LOCADORA 
GO

INSERT INTO EMPRESA(nomeEmpresa)
VALUES ('Localiza'), ('Aluga')
GO

SELECT * FROM EMPRESA 

INSERT INTO CLIENTE (NomeCliente)
VALUES ('Saulo'), ('Lucas');
GO

SELECT * FROM CLIENTE 

INSERT INTO MARCA(NomeMarca)
VALUES ('CHEVROLET'), ('PORSCHE');
GO

SELECT * FROM MARCA

INSERT INTO MODELO(IdMarca,NomeModelo)
VALUES (1,'Agile'), (2, '911 GT3');

SELECT * FROM MODELO

INSERT INTO VEICULO(IdModelo, ImEmpresa, Placa)
VALUES (1, 1, '666'), (1, 2, '999'), (2, 1, '777');
GO

SELECT * FROM VEICULO 

DELETE FROM VEICULO 

INSERT INTO ALUGUEL(IdVeiculo, IdCliente, IdEmpresa, DataAluguel)
VALUES (2, 2, 2, '08/09/2021', '10/09/2021');
GO