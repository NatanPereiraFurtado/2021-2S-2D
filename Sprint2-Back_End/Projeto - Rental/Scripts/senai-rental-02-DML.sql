USE M_Rental
GO

INSERT INTO MARCA (nomeMarca)
VALUES ('Nissan'), ('Peugeot');
GO

INSERT INTO EMPRESA(nomeEmpresa)
VALUES ('WHEEL');
GO

INSERT INTO CLIENTE(nomeCliente, CNH)
VALUES ('Rubens','987'), ('David','654');
GO

INSERT INTO MODELO (idMarca,nomeModelo)
VALUES (1, 'Versa'), (2, 'Kicks'), (2, '308');
GO

INSERT INTO VEICULOS(idModelo, Placa)
VALUES (3,'2P4'), (1,'7L5'), (2, '5K8');
GO

INSERT INTO ALUGUEL(idCliente, idVeiculos)
VALUES (1, 1), (1,2), (2,3);
GO

UPDATE EMPRESA
SET idVeiculos = 3
WHERE idEmpresa = 1
GO

UPDATE CLIENTE
SET CNH = '230622609'
WHERE idCliente = 1
GO

UPDATE CLIENTE
SET CNH = '062260923'
WHERE idCliente = 2
GO

UPDATE VEICULOS
SET Placa = 'RGB-3H66'
WHERE idVeiculos = 1
GO

UPDATE VEICULOS
SET Placa = 'KMK-6Z23'
WHERE idVeiculos = 2
GO

UPDATE VEICULOS
SET Placa = 'NPF-7J16'
WHERE idVeiculos = 3
GO

UPDATE ALUGUEL
SET DiaEmissao = '20210910', DataDevolussao = '20210817'
WHERE idAluguel = 1
GO

UPDATE ALUGUEL
SET DiaEmissao = '20210924', DataDevolussao = '20210931'
WHERE idAluguel = 2
GO

UPDATE ALUGUEL
SET DiaEmissao = '2021127', DataDevolussao = '20211004'
WHERE idAluguel = 3
GO