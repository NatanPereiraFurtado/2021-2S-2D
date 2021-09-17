USE PCLINICS
GO

SELECT * FROM CLINICA(nomeClinica, enderecoClinica) 
VALUES ('PetMed', 'rua Gomes')
GO

INSERT INTO DONO(nomeDono)
VALUES('David');
GO

INSERT INTO TIPO(nomeTipo, IdRaca)
VALUES ('Cachorro', 2)
GO

INSERT INTO PET(IdDono, IdTipo, nomePet, dataNiver)
VALUES (3, 1, 'Nina', '07-09-2018')
GO

INSERT INTO VETERINARIO (IdClinica, NomeVet, CRMV)
VALUES (1, 'Ricardo', '99999')
GO

INSERT INTO CONSULTA(IdPet, IdClinica, IdVeterinario, DataCONS, Descricao)
VALUES (1, 1, 1, '10-09-2021', 'Animal estava com raiva')
GO