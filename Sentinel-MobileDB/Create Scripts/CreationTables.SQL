 CREATE TABLE Anomalie (
    code  nvarchar(10) NOT NULL PRIMARY KEY,
    designation nvarchar(255) NOT NULL,
    typeanomalie nvarchar(10) NOT NULL
);

CREATE TABLE DeclarationAnomalie (
    vin  nvarchar(17)  NOT NULL,
    codeAnomalie nvarchar(10) NOT NULL,
    dateDeclaration datetime NOT NULL,
	etape numeric,
    CONSTRAINT PK_D PRIMARY KEY (vin,codeAnomalie,dateDeclaration)
);

CREATE TABLE Lot (
	id nvarchar(10),
	datePrevueArrive datetime
);

CREATE TABLE Parametres (
	nomParam nvarchar(50) NOT NULL PRIMARY KEY,
	valeurParam nvarchar(255)
);

CREATE TABLE ScanArrivage(
    vin nvarchar(17) PRIMARY KEY NOT NULL,
    datescanne datetime NOT NULL,
	etape numeric NOT NULL,
	synchronisee boolean
);

CREATE TABLE Vehicule (
	vin nvarchar(17) PRIMARY KEY NOT NULL,
	couleur nvarchar(20),
	lot nvarchar(10),
	model nvarchar(100)
);

CREATE TABLE Camion (
	numero nvarchar(10) PRIMARY KEY NOT NULL,
	transporteur nvarchar(100)
);

CREATE TABLE Chauffeur (
	id nvarchar (10) PRIMARY KEY NOT NULL,
	nom nvarchar (20),
	prenom nvarchar (20)
);


CREATE TABLE DocumentTransport (
	id nvarchar(10),
	dateDepart datetime,
	dateArrive datetime,
	lieuDepart nvarchar (10),
	lieuArrive nvarchar (10),
	chauffeur nvarchar (10),
	numCamion nvarchar (10)	
);


CREATE TABLE LigneDocumentTransport (
	vin nvarchar(17),
	destination nvarchar (10),
	CONSTRAINT PK_C PRIMARY KEY (vin,destination)
);

CREATE TABLE PointLivrable (
	code nvarchar(10),
	designation nvarchar(10),
	type tinyint
);