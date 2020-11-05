use prestamos

CREATE TABLE dbo.Periodos(
	perId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	perNombre VARCHAR(200)
);


CREATE TABLE dbo.VariablesDeConfiguracion(
	varConfiguracionId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	varConfiguracionNombre VARCHAR(200),
	varConfiguracionDescripcion VARCHAR(600),
	varConfiguracionValor VARCHAR(300)
);


CREATE TABLE dbo.FondoPrestamos(
	fonId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	fonNombre VARCHAR(200),
	fonDescripcion VARCHAR(600)
);

CREATE TABLE dbo.Estatus(
	estId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	estDescripcion VARCHAR(200)
);

CREATE TABLE dbo.Regional(
	regId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	regNombre VARCHAR(200),
	regDescripcion VARCHAR(200)
);

CREATE TABLE dbo.Prestamos(
	preId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	estId INT,
	cliId INT,
	usuId INT,
	usuNick VARCHAR(40),
	fonId INT,
	regID INT,
	preFechaCreado DATE,
	preMontoAprovado MONEY,
	preCuotas DECIMAL,
	perId INT,
	prePlazoMeses DECIMAL,
	preFechaPago DATE, 
	preFechaFinaliza DATE
	FOREIGN KEY(estId) REFERENCES Estatus(estId),
	FOREIGN KEY(cliId) REFERENCES Cliente(cliId),
	FOREIGN KEY(usuId,usuNick) REFERENCES Usuario(usuId,usuNick),
	FOREIGN KEY(fonId) REFERENCES FondoPrestamos(fonId),
	FOREIGN KEY(regID) REFERENCES Regional(regID),
	FOREIGN KEY(perId) REFERENCES Periodos(perId)
);

CREATE TABLE dbo.CuotasPrestamos(
	cuoPrestamoId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	preId INT,
	cuoPrestamoFechaPago DATE,
	cuoPrestamoFechaLimite DATE,
	cuoPrestamoFechaPagoRecibido DATE,
	cuoPrestamoNumeroTransaccion VARCHAR(300),
	cuoPrestamoValorCiclo MONEY,
	cuoPrestamoSaldo MONEY,
	cuoPrestamoIntereses MONEY,
	couPrestamoTotalPagarCiclo MONEY
	FOREIGN KEY(preId) REFERENCES Prestamos(preId)
);

