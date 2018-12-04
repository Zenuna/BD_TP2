use BD5B6TP2_JouaniquePerreault
if object_id('Dependants','U') is not null  DROP TABLE Dependants;
if object_id('Depenses','U') is not null  DROP TABLE Depenses;
if object_id('Reabonnements','U') is not null  DROP TABLE Reabonnements;
if object_id('PartiesJouees','U') is not null  DROP TABLE PartiesJouees;
if object_id('Abonnements','U') is not null  DROP TABLE Abonnements;
if object_id('Terrains','U') is not null  DROP TABLE Terrains;
if object_id('Services','U') is not null  DROP TABLE Services;
if object_id('Employes','U') is not null  DROP TABLE Employes;
if object_id('TypesEmploye','U') is not null  DROP TABLE TypesEmploye;
if object_id('PrixDepensesAbonnements','U') is not null  DROP TABLE PrixDepensesAbonnements;
if object_id('TypesAbonnement','U') is not null  DROP TABLE TypesAbonnement;
if object_id('Provinces','U') is not null  DROP TABLE Provinces;
if object_id('Sexe','U') is not null DROP TABLE Sexe;
CREATE TABLE Sexe(
	idSexe char(1) not null,
	Description varchar(5) not null
	CONSTRAINT PK_Sexe PRIMARY KEY(idSexe)
	);
INSERT INTO Sexe(idSexe,Description) VALUES
('H','Homme'),
('F','Femme');
CREATE TABLE Provinces(
	Id varchar(2) not null,
	Nom varchar(25) not null,
	Remarque varchar(50),
	CONSTRAINT PK_Provinces PRIMARY KEY(Id)
);
INSERT INTO Provinces (Id,Nom) VALUES
('AB','Alberta'),
('BC','Colombie-Britannique'),
('MB','Manitoba'),
('NB','Nouveau-Brunswick'),
('NL','Terre-Neuve et Labrador'),
('NT','Territoires du Nord-Ouest'),
('NS','Nouvelle-Écosse'),
('NU','Nunavut'),
('ON','Ontario'),
('PE','Île-du-Prince-Édouard'),
('QC','Québec'),
('SK','Saskatchewan'),
('YT','Territoire du Yukon');
SELECT * FROM Provinces;

CREATE TABLE TypesAbonnement(
	No int not null,
	Description varchar(50) not null,
	Remarque varchar(50),
	CONSTRAINT PK_TypeAbonnement PRIMARY KEY(No)
);
INSERT INTO TypesAbonnement (No, Description) VALUES
(1,'Personne seule'),
(2,'Âge d''or'),
(3,'Couple'),
(4,'Famille (couple + 1 enfant)'),
(5,'Famille (couple + 2 enfants)'),
(6,'Famille (couple + 3 enfants ou plus)');
SELECT * FROM TypesAbonnement;

CREATE TABLE PrixDepensesAbonnements(
	NoTypeAbonnement int not null,
	Annee int not null,
	Prix money not null,
	DepensesObligatoires money not null,
	Remarque varchar(50),
	CONSTRAINT PK_PrixDepensesAbonnements PRIMARY KEY (NoTypeAbonnement,Annee),
	CONSTRAINT FK_NoTypeAbonnementDepense FOREIGN KEY (NoTypeAbonnement) REFERENCES TypesAbonnement(No)
);
INSERT INTO PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) VALUES
(1,2017,850,400),
(2,2017,500,400),
(3,2017,1200,700),
(4,2017,1700,700),
(5,2017,1900,700),
(6,2017,2100,700);
SELECT * FROM PrixDepensesAbonnements;

CREATE TABLE TypesEmploye(
	No int not null,
	Description varchar(25) not null,
	Remarque varchar(50),
	CONSTRAINT PK_TypesEmploye PRIMARY KEY(No)
);
INSERT INTO TypesEmploye (No,Description,Remarque) VALUES
(1,'Administrateur','Il n''y en a qu''un et son numéro est 1'),
(2,'Direction',null),
(3,'Propriétaire d''un club',null),
(4,'Employé d''un club',null),
(5,'Employé d''un Pro-Shop',null),
(6,'Employé d''un restaurant',null),
(7,'Professeur de golf',null);
SELECT * FROM TypesEmploye;

CREATE TABLE Employes(
	No int not null,
	MotDePasse varchar(50) not null,
	Nom varchar(50) not null,
	Prenom varchar(50) not null,
	Sexe char(1) not null,
	Age int not null,
	NoCivique varchar(10) not null,
	Rue varchar(50) not null,
	Ville varchar(50) not null,
	IdProvince varchar(2) not null,
	CodePostal varchar(6) not null,
	Telephone varchar(10) not null,
	Cellulaire varchar(10),
	Courriel varchar(50) not null,
	SalaireHoraire money not null,
	NoTypeEmploye int not null,
	Remarque varchar(50),
	CONSTRAINT PK_Employes PRIMARY KEY(No),
	CONSTRAINT FK_ProvinceEmploye FOREIGN KEY (IdProvince) REFERENCES Provinces (Id),
	CONSTRAINT FK_NoTypeEmploye FOREIGN KEY(NoTypeEmploye) REFERENCES TypesEmploye(No),
	CONSTRAINT FK_SexeEmploye FOREIGN KEY(Sexe) REFERENCES Sexe(idSexe)
);
INSERT INTO Employes (No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Cellulaire,Courriel,SalaireHoraire,NoTypeEmploye) 
VALUES (1,'','Admin','Admin','H',66,666,'Hell St','Helltown','NT','A1B2C3','6666666666',null,'lucifer@cgodin.qc.ca',666,1);
SELECT * From Employes;

CREATE TABLE Services(
	No int not null,
	TypeService varchar(50) not null,
	NoEmploye int not null,
	Remarque varchar(50),
	CONSTRAINT PK_Services PRIMARY KEY(No),
	CONSTRAINT FK_NoEmploye FOREIGN KEY (NoEmploye) REFERENCES Employes(No)
);

CREATE TABLE Terrains(
	No int not null,
	Nom varchar(50) not null,
	NombreTrous int not null,
	Description varchar(50) not null,
	Remarque varchar(50),
	CONSTRAINT PK_Terrains PRIMARY KEY(No)
);
INSERT INTO Terrains (No,Nom,NombreTrous,Description) VALUES
(1,'Terrain #1',9,'Petit terrain #1'),
(2,'Terrain #2',9,'Petit terrain #2'),
(3,'Terrain #3',9,'Petit terrain #3'),
(4,'Terrain #4',18,'Grand terrain #1'),
(5,'Terrain #5',18,'Grand terrain #2'),
(6,'Terrain #6',18,'Grand terrain #3');
SELECT * From Terrains;

CREATE TABLE Abonnements(
	Id varchar(30) not null,
	DateAbonnement Date not null,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Sexe char(1) not null,
	DateNaissance Date not null,
	NoCivique varchar(10) not null,
	Rue varchar(30) not null,
	Ville varchar(30) not null,
	IdProvince varchar(2) not null,
	CodePostal varchar(6) not null,
	Telephone varchar(10) not null,
	Cellulaire varchar(10),
	Courriel varchar(50) not null,
	NoTypeAbonnement int not null,
	Remarque varchar(50),
	CONSTRAINT PK_Abonnements PRIMARY KEY(Id),
	CONSTRAINT FK_IdProvince FOREIGN KEY (IdProvince) REFERENCES Provinces (Id),
	CONSTRAINT FK_NoTypeAbonnement FOREIGN KEY (NoTypeAbonnement) REFERENCES TypesAbonnement(No),
	CONSTRAINT FK_SexeAbonnement FOREIGN KEY (Sexe) REFERENCES Sexe(idSexe)
);

CREATE TABLE PartiesJouees(
	IdAbonnement varchar(30) not null,
	NoTerrain int not null,
	DatePartie Date not null,
	Pointage int not null,
	Remarque varchar(50),
	CONSTRAINT PK_PartiesJouees PRIMARY KEY(IdAbonnement,NoTerrain,DatePartie),
	CONSTRAINT FK_IDAbonnement FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id),
	CONSTRAINT FK_NoTerrain FOREIGN KEY (NoTerrain) REFERENCES TERRAINS (No)
);

CREATE TABLE Reabonnements(
	IdAbonnement varchar(30) not null,
	DateRenouvellement Date not null,
	Remarque varchar(50),
	CONSTRAINT PK_Reabonnement PRIMARY KEY (IdAbonnement,DateRenouvellement),
	CONSTRAINT FK_IdAbonnementReab FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id)
);

CREATE TABLE Depenses(
	No int not null,
	IdAbonnement varchar(30) not null,
	DateDepense Date not null,
	Montant money not null,
	NoService int not null,
	Remarque varchar(50),
	CONSTRAINT PK_Depenses PRIMARY KEY (No),
	CONSTRAINT FK_AbonnementDepense FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id),
	CONSTRAINT FK_ServiceDep FOREIGN KEY (NoService) REFERENCES Services(No)
);

CREATE TABLE Dependants(
	Id varchar(30) not null,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Sexe char(1) not null,
	DateNaissance Date not null,
	IdAbonnement varchar(30) not null,
	Remarque varchar(50),
	CONSTRAINT PK_Dependants PRIMARY KEY (Id),
	CONSTRAINT FK_AbonnementDependant FOREIGN KEY (IdAbonnement) REFERENCES Abonnements(Id),
	CONSTRAINT FK_SexeDependants FOREIGN KEY (Sexe) REFERENCES Sexe(idSexe)
);

PRINT ' ----------- CONSTRUCTION BDD COMPLÉTÉE ----------- '