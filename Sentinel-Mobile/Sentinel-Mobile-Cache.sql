

/** La table Anomalie **/
--Création
CREATE TABLE Anomalie (
    code  nvarchar(10) NOT NULL PRIMARY KEY,
    designation nvarchar(255) NOT NULL,
    typeanomalie nvarchar(10) NOT NULL
);

--Initialisation
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('AVA1','Eraflure','AVARIE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('AVA2','Brulure','AVARIE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('AVA3','Cassure','AVARIE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('AVA4','Egratignure','AVARIE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('AVA5','Autre','AVARIE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('MAN1','Pièce Mécanique','MANQUE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('MAN2','Carroserie','MANQUE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('MAN3','Accessoire','MANQUE');
INSERT INTO Anomalie (code, designation, typeanomalie) VALUES ('MAN4','Autre','MANQUE');

/** La table DeclarationAnomalie **/
--Création
CREATE TABLE DeclarationAnomalie (
    vin  nvarchar(17)  NOT NULL,
    codeAnomalie nvarchar(10) NOT NULL,
    dateDeclaration datetime NOT NULL,
	etape numeric,
	synchronisee numeric NOT NULL,
    CONSTRAINT PK_D PRIMARY KEY (vin,codeAnomalie,dateDeclaration)
);



/** La table ScanArrivage **/
CREATE TABLE ScanArrivage(
    vin nvarchar(17) PRIMARY KEY NOT NULL,
    datescanne datetime NOT NULL,
	etape numeric NOT NULL,
	synchronisee boolean
);


/** La table Paramètres **/
CREATE TABLE Parametres (
	nomParam nvarchar(50) NOT NULL PRIMARY KEY,
	valeurParam nvarchar(255)
);
