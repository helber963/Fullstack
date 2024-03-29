--DDL
CREATE DATABASE RpgOlineDB

USE RpgOlineDB

CREATE TABLE Usuarios (
	UsuarioID INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(250) NOT NULL
)
--Classes
CREATE TABLE Classes (
	ClasseID INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)

CREATE TABLE Personagens(
	PersonagemID INT PRIMARY KEY IDENTITY,
	NomePersonagem VARCHAR(15) UNIQUE NOT NULL,
	UsuarioID INT UNIQUE FOREIGN KEY REFERENCES Usuarios(UsuarioID),
	ClasseID INT FOREIGN KEY REFERENCES Classes(ClasseID)
)

CREATE TABLE Habilidades(
	HabilidadeID INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE ClasseHabilidade(
	ClasseID INT FOREIGN KEY REFERENCES Classes(ClasseID),
	HabilidadeID INT FOREIGN KEY REFERENCES Habilidades(HabilidadeID)
)

ALTER TABLE Personagens 
ALTER COLUMN NomePersonagem VARCHAR(100)

-- DML - COLOCAR DADOS
INSERT INTO Usuarios VALUES ( 'helber@gmail.com', '12345')
INSERT INTO Usuarios VALUES ( 'chaves@gmail.com', HASHBYTES('SHA2_512','12345'))
INSERT INTO Classes VALUES ('Barbaro','Ele � realemente barbaro')
INSERT INTO Habilidades VALUES ('Soc�o na Costela'), ('Dedo molhado no ouvido'), ('Cuec�o'), ('Pedala Robinho')
INSERT INTO Personagens (NomePersonagem, UsuarioID, ClasseID) VALUES ('Klebin', 1, 1)
INSERT INTO Personagens (NomePersonagem, UsuarioID, ClasseID) VALUES ('Klebin_cabeca_de_lampada', 2, 1)
INSERT INTO ClasseHabilidade (ClasseID, HabilidadeID) VALUES (1, 3), (1, 2), (1, 1)

UPDATE Usuarios
SET Senha = '98754'
WHERE UsuarioID = 1


-- DQL - CONSULTAS

SELECT * FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Personagens
SELECT * FROM Habilidades
SELECT * FROM ClasseHabilidade

SELECT * FROM Personagens 
INNER JOIN Classes
ON Personagens.ClasseID = Classes.ClasseID

--Exemplo JOIN

CREATE DATABASE ExemplosJOIN

USE ExemplosJOIN

--DDL
CREATE TABLE TabelaA(
	Nome VARCHAR (50) NULL
)
CREATE TABLE TabelaB(
	Nome VARCHAR (50) NULL
)

--DML

INSERT INTO TabelaA VALUES ('Fernanda')
INSERT INTO TabelaA VALUES ('Josefa')
INSERT INTO TabelaA VALUES ('Luiz')
INSERT INTO TabelaA VALUES ('Fernando')

INSERT INTO TabelaB VALUES ('Carlos'), ('Manoel'), ('Luiz'), ('Fernando')

--DQL

SELECT * FROM TabelaA
SELECT * FROM TabelaB

SELECT TabelaA.Nome AS TabelaA, TabelaB.Nome AS TabelaB FROM TabelaA
INNER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome AS TabelaA, TabelaB.Nome AS TabelaB FROM TabelaA
LEFT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome AS TabelaA, TabelaB.Nome AS TabelaB FROM TabelaA
RIGHT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome AS TabelaA, TabelaB.Nome AS TabelaB FROM TabelaA
FULL OUTER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome