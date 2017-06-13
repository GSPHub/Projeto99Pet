CREATE DATABASE CrudAnimal
GO

USE CrudAnimal
GO

CREATE TABLE Animal
(
	IdAnimal	INT IDENTITY(1,1)	NOT NULL,
	Nome		VARCHAR(40)			NOT NULL,
	Sexo		VARCHAR(10)			NOT NULL,
	Especie		VARCHAR(10)			NOT NULL,
	Peso		FLOAT (10)				NULL,
	Idade		VARCHAR(3)				NULL,
	Tipo		VARCHAR(10)			NOT NULL,
	Raca		VARCHAR(30)			NOT NULL,
	Observacao	VARCHAR(100)			NULL
)

ALTER TABLE Animal
	ADD CONSTRAINT PK_IdAnimal PRIMARY KEY (IdAnimal)

ALTER TABLE Animal
    ADD CONSTRAINT chk_Sexo CHECK (Sexo ='Masculino' OR Sexo ='Feminino')

ALTER TABLE Animal
	ADD CONSTRAINT chk_Especie CHECK (Especie ='Gato' OR Especie ='Cachorro' OR Especie ='Aves' OR Especie ='Roedores' OR Especie ='Outros')

ALTER TABLE Animal
	ADD CONSTRAINT chk_Tipo CHECK (Tipo ='Filhote' OR Tipo ='Adulto');


CREATE TABLE Disponibilidade
(
	IdDisponibilidade INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
	Segunda		BIT					 NULL,
	Terca		BIT					 NULL,
	Quarta		BIT					 NULL, 
	Quinta		BIT					 NULL,
	Sexta		BIT					 NULL,
	Sabado		BIT					 NULL, 
	Domingo		BIT					 NULL, 
)

CREATE TABLE Cuidar_Especie
(
	IdCuidar_Especie INT IDENTITY(1,1)	PRIMARY KEY NOT NULL,
	Cães		BIT					NULL,
	Gatos		BIT					NULL, 
	Roedores	BIT					NULL,
	Aves		BIT					NULL,
	Outros		BIT					NULL, 
)

CREATE TABLE Tipo_Servico
(
	IdTipo_Servico INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
	Passeio					BIT		 NULL,
	Banho					BIT		 NULL, 
	Hospedagem				BIT		 NULL,
	Tosa					BIT		 NULL,
	Cuiodados_Medicos		BIT		 NULL,

)


CREATE TABLE Servico
(
	IdServico INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
	IdDisponibilidade INT FOREIGN KEY REFERENCES Disponibilidade (IdDisponibilidade),
	IdCuidar_Especie INT FOREIGN KEY REFERENCES Cuidar_Especie (IdCuidar_Especie),
	IdTipo_Servico INT FOREIGN KEY REFERENCES Tipo_Servico (IdTipo_Servico),
	Descricao	VARCHAR(100)			NULL,

)
