CREATE DATABASE ALUMNOS;

USE ALUMNOS;

CREATE TABLE ALUMNO(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRES VARCHAR(100),
APELLIDOS VARCHAR(100),
TELEFONO INT,
DIRECCION VARCHAR(50));

INSERT INTO ALUMNO VALUES('Paco','Sopa','234523123','calle 53#52-623')

SELECT * FROM ALUMNO
