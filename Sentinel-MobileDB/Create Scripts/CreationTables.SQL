 CREATE TABLE Anomalie (
    code  nvarchar(100) NOT NULL PRIMARY KEY,
    designation nvarchar(255) NOT NULL,
    typeanomalie int NOT NULL
);

CREATE TABLE Camion (
	id nvarchar(100) PRIMARY KEY NOT NULL,
	transporteur nvarchar(100) NOT NULL,
	modele nvarchar(100) NOT NULL
);

CREATE TABLE Chauffeur (
	id nvarchar (100) NOT NULL PRIMARY KEY ,
	nomPrenom nvarchar (100)NOT NULL,
	transporteur nvarchar (100)NOT NULL
);

CREATE TABLE DeclarationAnomalie (
    vin  nvarchar(17)  NOT NULL,
    codeAnomalie nvarchar(100) NOT NULL,
    dateDeclaration datetime NOT NULL,
	etape tinyint,
	synchronisee tinyint,
	validee tinyint,	
    CONSTRAINT PK_D PRIMARY KEY (vin,codeAnomalie,dateDeclaration)
);



CREATE TABLE Operation (
	id nvarchar(100) NOT NULL PRIMARY KEY,
	typeOperation int  NOT NULL,
	dateDepart datetime NOT NULL,
	lieuDepart nvarchar (100) NOT NULL,
	lieuArrive nvarchar (100) NOT NULL,
	chauffeur nvarchar (100) NOT NULL,
	numCamion nvarchar (100) NOT NULL	
);


CREATE TABLE LigneOperation (
	vin nvarchar(17) NOT NULL ,
	destination nvarchar (100) NOT NULL,
	CONSTRAINT PK_C PRIMARY KEY (vin,destination)
);



CREATE TABLE Lot (
	id nvarchar(100)NOT NULL PRIMARY KEY,
	codeArrivage int NOT NULL
);

CREATE TABLE Parametres (
	nomParam nvarchar(100) NOT NULL PRIMARY KEY,
	valeurParam nvarchar(3000) NOT NULL
);


CREATE TABLE PointLivrable (
	code nvarchar(100) NOT NULL PRIMARY KEY,
	designation nvarchar(100) NOT NULL,
	type tinyint NOT NULL
);

CREATE TABLE ScanVehicule(
    vin nvarchar(17) PRIMARY KEY NOT NULL,
    datescanne datetime NOT NULL,
	etape numeric NOT NULL,
	synchronisee boolean NOT NULL,
	codePtLivrable nvarchar(100) NOT NULL
);

CREATE TABLE Vehicule (
	vin nvarchar(17) PRIMARY KEY NOT NULL,
	couleur nvarchar(100)NOT NULL,
	lot nvarchar(100)NOT NULL,
	model nvarchar(100)NOT NULL
);


CREATE TABLE Zone (
	code nvarchar(100)NOT NULL PRIMARY KEY,
	codeparc nvarchar(100) NOT NULL,
	nom nvarchar(100)NOT NULL ,
	libre tinyint NOT NULL,
	nbrMaxPlateformes int NOT NULL	
);

CREATE TABLE Plateforme (
	codeZone nvarchar(100) NOT NULL,
	code nvarchar(100) NOT NULL,
	nbrMaxRanges int NOT NULL,
	CONSTRAINT PK_D PRIMARY KEY (nom ,codeZone)
);


CREATE TABLE Range (
	code nvarchar(100) NOT NULL,
	codeZone nvarchar (100) NOT NULL,
	codePlateforme nvarchar (100) NOT NULL,
	nbrMaxPlaces int NOT NULL,
	CONSTRAINT PK_D PRIMARY KEY (code ,codeZone,codePlateforme)
);



CREATE TABLE Arrivage (
	code bigint NOT NULL PRIMARY KEY,
	datePrevue datetime NOT NULL,
	source nvarchar(100) NOT NULL
);


CREATE TABLE Positionnement (
	vin nvarchar(17) NOT NULL,
	CodeParc nvarchar(100) NOT NULL,
	CodeZone nvarchar(100) NOT NULL,
	CodePlateforme nvarchar(100) NOT NULL,
	CodeRangee nvarchar(100) NOT NULL,
	NumeroDsRangee nvarchar(100) NOT NULL,
	datepositionnement datetime NOT NULL,
	synchronise tinyint NOT NULL,
	valide tinyint NOT NULL
);