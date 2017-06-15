 CREATE TABLE Anomalie (
    code  nvarchar(100) NOT NULL PRIMARY KEY,
    designation nvarchar(255) NOT NULL,
    typeanomalie int NOT NULL
);

CREATE TABLE Camion (
	id nvarchar(10) PRIMARY KEY NOT NULL,
	transporteur nvarchar(100) NOT NULL,
	disponible tinyint NOT NULL
);

CREATE TABLE Chauffeur (
	id nvarchar (10) NOT NULL PRIMARY KEY ,
	nom nvarchar (20)NOT NULL,
	prenom nvarchar (20)NOT NULL,
	disponible tinyint NOT NULL
);

CREATE TABLE DeclarationAnomalie (
    vin  nvarchar(17)  NOT NULL,
    codeAnomalie nvarchar(10) NOT NULL,
    dateDeclaration datetime NOT NULL,
	etape numeric,
    CONSTRAINT PK_D PRIMARY KEY (vin,codeAnomalie,dateDeclaration)
);



CREATE TABLE DocumentTransport (
	id nvarchar(10) NOT NULL PRIMARY KEY,
	dateDepart datetime NOT NULL,
	dateArrive datetime NOT NULL,
	lieuDepart nvarchar (10) NOT NULL,
	lieuArrive nvarchar (10) NOT NULL,
	chauffeur nvarchar (10) NOT NULL,
	numCamion nvarchar (10) NOT NULL	
);


CREATE TABLE LigneDocumentTransport (
	vin nvarchar(17) NOT NULL ,
	destination nvarchar (10) NOT NULL,
	CONSTRAINT PK_C PRIMARY KEY (vin,destination)
);



CREATE TABLE Lot (
	id nvarchar(10)NOT NULL PRIMARY KEY,
	codeArrivage int NOT NULL
);

CREATE TABLE Parametres (
	nomParam nvarchar(50) NOT NULL PRIMARY KEY,
	valeurParam nvarchar(255) NOT NULL
);


CREATE TABLE PointLivrable (
	code nvarchar(10) NOT NULL PRIMARY KEY,
	designation nvarchar(10) NOT NULL,
	type tinyint NOT NULL
);

CREATE TABLE ScanArrivage(
    vin nvarchar(17) PRIMARY KEY NOT NULL,
    datescanne datetime NOT NULL,
	etape numeric NOT NULL,
	synchronisee boolean NOT NULL,
	codePtLivrable nvarchar(100) NOT NULL
);

CREATE TABLE Vehicule (
	vin nvarchar(17) PRIMARY KEY NOT NULL,
	couleur nvarchar(20)NOT NULL,
	lot nvarchar(10)NOT NULL,
	model nvarchar(100)NOT NULL
);


CREATE TABLE Zone (
	nom nvarchar(20)NOT NULL PRIMARY KEY,
	codePtLivrable nvarchar(10)NOT NULL,
	libre tinyint NOT NULL,
	nbMaxPlateformes int NOT NULL	
);

CREATE TABLE Plateforme (
	nom nvarchar(10) NOT NULL,
	nomZone nvarchar(20) NOT NULL,
	nbMaxRanges int NOT NULL,
	CONSTRAINT PK_D PRIMARY KEY (nom ,nomZone)
);


CREATE TABLE Range (
	nom nvarchar(10) NOT NULL,
	nomPlateforme nvarchar(10) NOT NULL,
	nomZone nvarchar(20) NOT NULL,
	nbMaxPlaces int NOT NULL,
	CONSTRAINT PK_D PRIMARY KEY (nom ,nomPlateforme,nomZone)
);

CREATE TABLE PlaceRangee (
	dateDebut datetime NOT NULL PRIMARY KEY,
	dateFin datetime NOT NULL,
	numPlace int NOT NULL,
	courante tinyint NOT NULL
);


CREATE TABLE Arrivage (
	code bigint NOT NULL PRIMARY KEY,
	datePrevue datetime NOT NULL,
	source nvarchar(100) NOT NULL
);
