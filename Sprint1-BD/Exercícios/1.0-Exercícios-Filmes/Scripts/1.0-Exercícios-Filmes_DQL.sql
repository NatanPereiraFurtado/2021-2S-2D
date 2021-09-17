USE CATALOGO 

SELECT * FROM GENERO
SELECT * FROM FILME 

SELECT tituloFilme, nomeGenero, IdFilme 
FROM GENERO 
LEFT JOIN FILME 
ON GENERO.IdGenero = FILME.IdGenero;

SELECT tituloFilme, nomeGenero, IdFilme 
FROM GENERO
RIGHT JOIN FILME 
ON GENERO.IdGenero = FILME.IdGenero

SELECT tituloFilme, nomeGenero, IdFilme
FROM GENERO 
RIGHT JOIN FILME
ON GENERO.IdGenero = FILME.IdGenero;

SELECT tituloFilme, nomeGenero, IdFilme
FROM GENERO 
INNER JOIN FILME 
ON GENERO.IdGenero = FILME.IdGenero;