USE master;
GO

DROP DATABASE ProjetoAcademia;
GO

CREATE DATABASE ProjetoAcademia;
GO

USE ProjetoAcademia;
GO

CREATE TABLE Aluno(
	CodAluno INT NOT NULL PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL,
	Cpf CHAR(15) NOT NULL UNIQUE,
	Rg VARCHAR(10) NOT NULL,
	Email VARCHAR(50) UNIQUE,
	DataNascimento DATE NOT NULL
);
GO

CREATE TABLE Plano(
	CodPlano INT NOT NULL PRIMARY KEY IDENTITY,
	NomePlano VARCHAR(35) NOT NULL,
	ValorPlano MONEY
);
GO

CREATE TABLE Matricula(
	CodMatricula INT NOT NULL PRIMARY KEY IDENTITY,
	CodPlano INT,
	CodAluno INT,
	DataMatricula DATE NOT NULL,
	DataVencimento DATE NOT NULL
);
GO

CREATE TABLE Usuario(
	CodUsuario INT NOT NULL PRIMARY KEY IDENTITY,
	NomeUsuario VARCHAR(24),
	Senha VARCHAR(10),
	TipoUsuario VARCHAR(15)
);
GO

ALTER TABLE Matricula
	ADD CONSTRAINT FK_Plano
	FOREIGN KEY (CodPlano) REFERENCES Plano(CodPlano);
GO

ALTER TABLE Matricula
	ADD CONSTRAINT FK_Aluno
	FOREIGN KEY (CodAluno) REFERENCES Aluno(CodAluno);
GO

SELECT m.CodMatricula AS 'C�digo da Matricula', p.NomePlano AS 'Plano', a.Nome AS 'Aluno', DataMatricula AS 'Data de Matricula', DataVencimento AS 'Data de Vencimento' 
FROM Matricula m JOIN Plano p ON m.CodPlano = p.CodPlano JOIN Aluno a ON a.CodAluno = m.CodAluno
ORDER BY a.Nome