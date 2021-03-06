USE [prestamos]
GO
/****** Object:  StoredProcedure [dbo].[WWPrestamos]    Script Date: 12/18/2020 4:59:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[WWPrestamos]
	--PARAMETROS DE OPCIONES Y FILTROS
	@parametro varchar(200) = 'null',
	@returnId int = 0 OUTPUT,
	@accion varchar(200) = 'INS',
	@CONTADOR INT = 0 OUTPUT,
	@tieneCapitalAtrasado AS BIT = 0,
	@diasEnMora AS INT = 0,

	--PARAMETROS DE LA TABLA DE PRESTAMOS
	@preId INT = 0,
	@estId INT = 0,
	@cliId INT = 0,
	@usuId INT = 0,
	@usuNick VARCHAR(40) = '',
	@fonId INT = 0,
	@regID INT = 0,
	@preFechaCreado DATE = null,
	@preMontoAprovado MONEY = 0,
	@preCuotas MONEY = 0,
	@perId INT = 0,
	@prePlazoMeses DECIMAL = 0,
	@preFechaPago DATE = null, 
	@preFechaFinaliza DATE = null,
	@preInteresMoratorio INT = 1,
	@prePorcentajeInteres DECIMAL(18,2) = 12,
	@preGastosAdministrativos MONEY = 0,
	--PARAMTROS DE LA TABLA DE CUOTAS PRESTAMO
	@cuoPrestamoId INT =0,
	@cuoPrestamoFechaPago DATE = NULL,
	@cuoPrestamoFechaLimite DATE =NULL,
	@cuoPrestamoFechaPagoRecibido DATE = NULL,
	@cuoPrestamoNumeroTransaccion VARCHAR(300) = '',
	@cuoPrestamoValorCiclo MONEY = 0,
	@cuoPrestamoSaldo MONEY = 0,
	@cuoPrestamoIntereses MONEY =0,
	@couPrestamoTotalPagarCiclo MONEY = 0,
	@cuoPrestamoAbonoCapital MONEY = 0,
	@cuoPrestamoInteresMoratorio MONEY = 0,
	@cuoPrestamoMoraAcumulada MONEY = 0,
	@cuoPrestamoCapitalVencido MONEY = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @DiasProrrogaCalculoSigPago INT = 0
	--variable para almacenar si tiene capital vencido
	DECLARE @CapitalVencidoAcumular MONEY = 0
	DECLARE @MesesEnMora AS INT = 0

	DECLARE @CapitalVencidoAnterior MONEY = 0

	DECLARE @diasCalculo AS INT = 30;
	DECLARE @diasAnioCalculo AS INT = 365;

	--OBTENER LOS FONDOS
	IF @accion = 'SELECT_CB_FONDOS'
	BEGIN
		SELECT fonId AS 'ID'
      ,fonNombre AS 'FONDO'
		FROM [FondoPrestamos]
	END

	--OBTENER LAS REGIONALES
	IF @accion = 'SELECT_CB_REGIONALES'
	BEGIN
		SELECT regId AS 'ID'
      ,regNombre AS 'REGIONAL'
		FROM [Regional]
	END

	--PRESTAMOS

	IF @accion = 'INS_PRESTAMOS'
	BEGIN
		INSERT INTO Prestamos(estId,cliId,usuId,usuNick,fonId,regID,preFechaCreado,preMontoAprovado,perId,
		prePlazoMeses,preCuotas,preFechaPago,preFechaFinaliza,prePorcentajeInteres,preGastosAdministrativos,preInteresMoratorio) VALUES(
		2,
		@cliId,
		@usuId,
		@usuNick,
		@fonId,
		@regID,
		GETDATE(),
		@preMontoAprovado,
		@perId,
		@prePlazoMeses,
		ROUND((@preMontoAprovado/@prePlazoMeses),2),
		@preFechaPago,
		@preFechaFinaliza,
		@prePorcentajeInteres,
		@preGastosAdministrativos,
		@preInteresMoratorio 
		)
		SELECT SCOPE_IDENTITY()
    END

	IF @accion = 'INS_PRESTAMOS_CUOTAS'
	BEGIN
		SET @preMontoAprovado = (SELECT p.preMontoAprovado FROM Prestamos p WHERE p.preId = @preId)
		SET @prePlazoMeses = (SELECT p.prePlazoMeses FROM Prestamos p WHERE p.preId = @preId)
		SET @cuoPrestamoValorCiclo = ROUND((@preMontoAprovado/@prePlazoMeses),2)


		SET @prePorcentajeInteres = (SELECT p.prePorcentajeInteres FROM Prestamos p WHERE p.preId = @preId)
		SET @cuoPrestamoFechaPago = (SELECT TOP 1 cp.cuoPrestamoFechaPago FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoFechaPago DESC)

		IF @cuoPrestamoFechaPago IS NULL
			BEGIN 
				SET @cuoPrestamoFechaPago = (SELECT p.preFechaPago FROM Prestamos p WHERE p.preId = @preId)
				SET @cuoPrestamoSaldo = @preMontoAprovado
				SET @cuoPrestamoIntereses = ROUND((SELECT ((@preMontoAprovado * (( CONVERT(FLOAT,@prePorcentajeInteres) / 100.00)) / 365) * 30)),2)
			
				/*INTERES MORATORIO*/
				--Verificar si esta atrasado en el primer pago.
				SET @DiasProrrogaCalculoSigPago = (SELECT CONVERT(INT,vc.varConfiguracionValor) FROM VariablesDeConfiguracion vc WHERE vc.varConfiguracionId = 3)
				--obtener nueva fecha limite de pago en base a la fecha del pago anterior
				SET @cuoPrestamoFechaLimite = (SELECT DATEADD(DAY,@DiasProrrogaCalculoSigPago,p.preFechaPago) FROM Prestamos p WHERE p.preId = @preId)

				--Si al momento de llamar esta funcion no ha reportado pago, calcular los meses que no se ha reportado pagos para acumular esos montos al capital vencido
				IF @cuoPrestamoFechaLimite < CONVERT(DATE,GETDATE())
					BEGIN
					
						SET @MesesEnMora = dbo.FullMonthsSeparation(CONVERT(VARCHAR(50),@cuoPrestamoFechaLimite), CONVERT(VARCHAR(50),GETDATE()))
						--Si los meses en mora es mayor que 0 significa que esta en mora y se le suma el total del ciclo * el total de meses en mora
						IF @MesesEnMora > 0
							BEGIN 
								SET @CapitalVencidoAcumular = ROUND(ROUND(@cuoPrestamoValorCiclo,2)*@MesesEnMora,2)
							END
					END
				    SET @cuoPrestamoCapitalVencido = @CapitalVencidoAcumular
					SET @diasEnMora = (SELECT DATEDIFF(DAY,@cuoPrestamoFechaLimite,GETDATE()))
				    SET @cuoPrestamoInteresMoratorio = (SELECT ROUND(((@cuoPrestamoCapitalVencido * (( CONVERT(FLOAT,@preInteresMoratorio) / 100.00)) / 365) * @diasEnMora),2))
				/*FIN INTERES MORATORIO*/

				SET @cuoPrestamoAbonoCapital = ROUND((@couPrestamoTotalPagarCiclo - @cuoPrestamoIntereses - @cuoPrestamoInteresMoratorio),2)
			END
		ELSE
			BEGIN 

				SET @cuoPrestamoFechaPago = DATEADD(MONTH,1,@cuoPrestamoFechaPago)
				SET @cuoPrestamoAbonoCapital = ROUND((SELECT TOP 1 cp.cuoPrestamoAbonoCapital FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC),2)
				SET @cuoPrestamoSaldo = ROUND((SELECT TOP 1 cp.cuoPrestamoSaldo FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC),2)
				IF @cuoPrestamoSaldo >= @cuoPrestamoValorCiclo
					BEGIN
						--saldo anterior - abono actual
						SET @cuoPrestamoSaldo = ROUND((@cuoPrestamoSaldo - @cuoPrestamoAbonoCapital),2)
					END
				ELSE
					BEGIN 
						SET @cuoPrestamoSaldo = 0
					END
				SET @cuoPrestamoIntereses = ROUND((SELECT ((@cuoPrestamoSaldo * (( CONVERT(FLOAT,p.prePorcentajeInteres) / 100.00)) / 365) * 30) FROM Prestamos p WHERE p.preId = @preId),2)
				

				/*COMPROBAR SI NO HA REPORTADO PAGO PARA ACUMULAR CAPITAL VENCIDO*/
				
				SET @DiasProrrogaCalculoSigPago = (SELECT CONVERT(INT,vc.varConfiguracionValor) FROM VariablesDeConfiguracion vc WHERE vc.varConfiguracionId = 3)
				--obtener nueva fecha limite de pago en base a la fecha del pago anterior
				SET @cuoPrestamoFechaLimite = (SELECT TOP 1 DATEADD(DAY,@DiasProrrogaCalculoSigPago,DATEADD(MM,1,cp.cuoPrestamoFechaPago)) FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC)
			

				--Si al momento de llamar esta funcion no ha reportado pago, calcular los meses que no se ha reportado pagos para acumular esos montos al capital vencido
				IF @cuoPrestamoFechaLimite < GETDATE()
					BEGIN

						SET @MesesEnMora = dbo.FullMonthsSeparation(CONVERT(VARCHAR(50),@cuoPrestamoFechaLimite), CONVERT(VARCHAR(50),GETDATE()))
						--Si los meses en mora es mayor que 0 significa que esta en mora y se le suma el total del ciclo * el total de meses en mora
						IF @MesesEnMora > 0
							BEGIN 
								SET @CapitalVencidoAcumular = ROUND(ROUND(@cuoPrestamoValorCiclo,2)*@MesesEnMora,2)
							END
					END
				/*FIN COMPROBACION*/


				--calculo de interes moratorio
				--verificar si tiene capital vencido para calcular interes vencido
				SET @cuoPrestamoInteresMoratorio = 0
				--Verificar si tiene capital vencido y si el pago cubre el saldo de la mora sino sumarla al capital vencido por no pagar nada en las cuotas anteriores.
				SET @tieneCapitalAtrasado = (SELECT TOP 1 (CASE WHEN cp.cuoPrestamoCapitalVencido>0 THEN 1 ELSE 0 END) FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC)
				IF @tieneCapitalAtrasado = 1
					BEGIN
						--Verificar si el abono a capital actual (valor del ciclo) cubre el total del capital vencido anterior
						SET @CapitalVencidoAnterior = (SELECT TOP 1 ROUND(cp.cuoPrestamoCapitalVencido,2) FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC)
						IF @CapitalVencidoAnterior < @cuoPrestamoValorCiclo
							BEGIN
								SET @cuoPrestamoCapitalVencido = @CapitalVencidoAcumular
							END
						ELSE
							BEGIN
								SET @cuoPrestamoCapitalVencido = ROUND(@CapitalVencidoAcumular + (@cuoPrestamoValorCiclo-@CapitalVencidoAnterior),2)
							END

					 
						SET @diasEnMora = (SELECT DATEDIFF(DAY,@cuoPrestamoFechaLimite,GETDATE()))
						SET @cuoPrestamoInteresMoratorio = (SELECT ROUND(((@cuoPrestamoCapitalVencido * (( CONVERT(FLOAT,@preInteresMoratorio) / 100.00)) / 365) * @diasEnMora),2))
					END

				--nuevo abono a capital
				SET @cuoPrestamoAbonoCapital = ROUND((@couPrestamoTotalPagarCiclo - @cuoPrestamoIntereses - @cuoPrestamoInteresMoratorio),2)
			
			END

		IF @cuoPrestamoAbonoCapital < @cuoPrestamoValorCiclo and @cuoPrestamoSaldo > @cuoPrestamoValorCiclo
			BEGIN
			DECLARE @CapitalVencidoCicloActual MONEY = ROUND((@cuoPrestamoValorCiclo - @cuoPrestamoAbonoCapital),2)
			IF @cuoPrestamoCapitalVencido > 0
				BEGIN
					SET @cuoPrestamoCapitalVencido = (@cuoPrestamoCapitalVencido-@cuoPrestamoAbonoCapital+@CapitalVencidoCicloActual)
				END
			ELSE
				BEGIN
					SET @cuoPrestamoCapitalVencido = @CapitalVencidoCicloActual
				END
			
			END
		ELSE
			BEGIN
			IF @cuoPrestamoCapitalVencido > @couPrestamoTotalPagarCiclo
				BEGIN
					DECLARE @CapitalVencidoFaltante MONEY = ROUND(@cuoPrestamoCapitalVencido - @cuoPrestamoValorCiclo,2)
					SET @cuoPrestamoCapitalVencido = @CapitalVencidoFaltante
				END
			ELSE
				BEGIN 
					SET @cuoPrestamoCapitalVencido = 0
				END
			END


		DECLARE @DiasProrroga INT = 0
		SET @DiasProrroga = (SELECT CONVERT(INT,vc.varConfiguracionValor) FROM VariablesDeConfiguracion vc WHERE vc.varConfiguracionId = 3)
		--Insertar 
		INSERT INTO CuotasPrestamos(preId,cuoPrestamoFechaPago,cuoPrestamoFechaLimite,cuoPrestamoFechaPagoRecibido
		,cuoPrestamoNumeroTransaccion,cuoPrestamoValorCiclo,cuoPrestamoSaldo,cuoPrestamoIntereses,couPrestamoTotalPagarCiclo
		,cuoPrestamoAbonoCapital, cuoPrestamoInteresMoratorio,cuoPrestamoMoraAcumulada, cuoPrestamoCapitalVencido) VALUES(
			@preId,
			@cuoPrestamoFechaPago,
			DATEADD(DAY,@DiasProrroga,@cuoPrestamoFechaPago),
			GETDATE(),
			@cuoPrestamoNumeroTransaccion,
			@cuoPrestamoValorCiclo,
			@cuoPrestamoSaldo,
			@cuoPrestamoIntereses,
			@couPrestamoTotalPagarCiclo,
			@cuoPrestamoAbonoCapital,
			@cuoPrestamoInteresMoratorio,
			@cuoPrestamoMoraAcumulada,
			@cuoPrestamoCapitalVencido
		)
    END

	IF @accion = 'GET_VALOR_CICLO_PRESTAMO'
	BEGIN 
	--Mostrar valor base a pagar.
		--Comprobar si ya ha pagado alguna cuota
			--si no ha pagado, el valor a pagar va a ser la cuota mensual + los interes
			--si ya pago la primera cuota el valor a pagar va a ser la cuota mensual + interes + comprobar si tiene mora, calcularla y sumarla
		
		--LLenano variables globales de la condicion
		SET @prePorcentajeInteres = (SELECT p.prePorcentajeInteres FROM Prestamos p WHERE preId = @preId)
		SET @preInteresMoratorio = (SELECT p.preInteresMoratorio FROM Prestamos p WHERE preId = @preId)
		SET @prePlazoMeses = (SELECT p.prePlazoMeses FROM Prestamos p WHERE preId = @preId)
		SET @cuoPrestamoValorCiclo = (SELECT p.preCuotas FROM Prestamos p WHERE preId = @preId) -- Valor del ciclo esparado

		--Comprueba si existe registro de cuotas pagadas.
		IF (SELECT COUNT(*) FROM CuotasPrestamos WHERE preId = @preId) > 0
			BEGIN
				--comprobar si no ha pasado la fecha de pago para calcular el capital vencido.
				--obtener el monto total del prestamo, la tasa de interes y el plazo para calcular el monto a pagar sumando intereses.
			
				--Abono a capital ciclo anterior
				SET @cuoPrestamoAbonoCapital = (SELECT TOP 1 cp.cuoPrestamoAbonoCapital 
												FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC) --Abono a capital anterior para obtener el monto actual
				--Saldo anterior del prestamo
				SET @cuoPrestamoSaldo = (SELECT TOP 1 cp.cuoPrestamoSaldo FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC) --Saldo anterior para obtener el monto actual

				
				SET @DiasProrrogaCalculoSigPago = (SELECT CONVERT(INT,vc.varConfiguracionValor) FROM VariablesDeConfiguracion vc WHERE vc.varConfiguracionId = 3)
				--obtener nueva fecha limite de pago en base a la fecha del pago anterior
				SET @cuoPrestamoFechaLimite = (SELECT TOP 1 DATEADD(DAY,@DiasProrrogaCalculoSigPago,DATEADD(MM,1,cp.cuoPrestamoFechaPago)) FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC)
			
				
				--Si al momento de llamar esta funcion no ha reportado pago, calcular los meses que no se ha reportado pagos para acumular esos montos al capital vencido
				IF @cuoPrestamoFechaLimite < CONVERT(DATE,GETDATE())
					BEGIN

						SET @MesesEnMora = dbo.FullMonthsSeparation(CONVERT(VARCHAR(50),@cuoPrestamoFechaLimite), CONVERT(VARCHAR(50),GETDATE()))
						--Si los meses en mora es mayor que 0 significa que esta en mora y se le suma el total del ciclo * el total de meses en mora
						IF @MesesEnMora > 0
							BEGIN 
								SET @CapitalVencidoAcumular = ROUND(ROUND(@cuoPrestamoValorCiclo,2)*@MesesEnMora,2)
							END
					END
			
				--Saldo del nuevo ciclo a pagar para calcular el interes. Restamos el valor del abono a capital - el saldo del pago anterior.
				DECLARE @SaldoActual MONEY = (@cuoPrestamoSaldo-@cuoPrestamoAbonoCapital)

				--Calculamos el interes
				SET @cuoPrestamoIntereses = (SELECT ROUND(((@SaldoActual * (( CONVERT(FLOAT,@prePorcentajeInteres) / 100.00)) / 365) * 30),2))

				--verificar si tiene capital vencido para calcular interes vencido
				SET @cuoPrestamoInteresMoratorio = 0
				--Verificar si tiene capital vencido y si el pago cubre el saldo de la mora sino sumarla al capital vencido por no pagar nada en las cuotas anteriores.
				SET @tieneCapitalAtrasado = (SELECT TOP 1 (CASE WHEN cp.cuoPrestamoCapitalVencido>0 THEN 1 ELSE 0 END) FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC)
				IF @tieneCapitalAtrasado = 1
					BEGIN
						--Verificar si el abono a capital actual (valor del ciclo) cubre el total del capital vencido anterior
						SET @CapitalVencidoAnterior = (SELECT TOP 1 cp.cuoPrestamoCapitalVencido FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC)
						IF @CapitalVencidoAnterior < @cuoPrestamoValorCiclo
							BEGIN
								SET @cuoPrestamoCapitalVencido = @CapitalVencidoAcumular
							END
						ELSE
							BEGIN
								SET @cuoPrestamoCapitalVencido = ROUND(@CapitalVencidoAcumular + (@cuoPrestamoValorCiclo-@CapitalVencidoAnterior),2)
							END

					 
						SET @diasEnMora = (SELECT DATEDIFF(DAY,@cuoPrestamoFechaLimite,GETDATE()))
						SET @cuoPrestamoInteresMoratorio = (SELECT ROUND(((@cuoPrestamoCapitalVencido * (( CONVERT(FLOAT,@preInteresMoratorio) / 100.00)) / 365) * @diasEnMora),2))
					END

				--Si el saldo del nuevo ciclo a pagar es mayor al valor de la cuota mensual + intereses se hara el calculo en base al valor de la cuota mensual.
				IF @SaldoActual >= (@cuoPrestamoValorCiclo)
					BEGIN 
						SET @couPrestamoTotalPagarCiclo = ROUND(@cuoPrestamoValorCiclo + @cuoPrestamoIntereses + @cuoPrestamoInteresMoratorio,2)
					END
				ELSE
					BEGIN
					SET @couPrestamoTotalPagarCiclo = ROUND(@SaldoActual + @cuoPrestamoIntereses,2)
					END
				IF @SaldoActual = 0
					BEGIN
						SET @couPrestamoTotalPagarCiclo = 0
						UPDATE Prestamos SET estId = 5 WHERE preId = @preId
					END
				SELECT ROUND(@couPrestamoTotalPagarCiclo,2)
			END
		ELSE
			BEGIN
			--Saldo de la cuota sera el monto total del prestamo
				SET @cuoPrestamoSaldo = (SELECT p.preMontoAprovado FROM Prestamos p WHERE preId = @preId)
				--valor del ciclo de la primera cuota.
				SET @cuoPrestamoValorCiclo = @cuoPrestamoSaldo / @prePlazoMeses
				--Calculo del interes
				SET @cuoPrestamoIntereses = ROUND(((@cuoPrestamoSaldo * (( CONVERT(FLOAT,@prePorcentajeInteres) / 100.00)) / 365) * 30),2)

				--Verificar si esta atrasado en el primer pago.
				SET @DiasProrrogaCalculoSigPago = (SELECT CONVERT(INT,vc.varConfiguracionValor) FROM VariablesDeConfiguracion vc WHERE vc.varConfiguracionId = 3)
				--obtener nueva fecha limite de pago en base a la fecha del pago anterior
				SET @cuoPrestamoFechaLimite = (SELECT DATEADD(DAY,@DiasProrrogaCalculoSigPago,p.preFechaPago) FROM Prestamos p WHERE p.preId = @preId)

				--Si al momento de llamar esta funcion no ha reportado pago, calcular los meses que no se ha reportado pagos para acumular esos montos al capital vencido
				IF @cuoPrestamoFechaLimite < CONVERT(DATE,GETDATE())
					BEGIN
					
						SET @MesesEnMora = dbo.FullMonthsSeparation(CONVERT(VARCHAR(50),@cuoPrestamoFechaLimite), CONVERT(VARCHAR(50),GETDATE()))
						--Si los meses en mora es mayor que 0 significa que esta en mora y se le suma el total del ciclo * el total de meses en mora
						IF @MesesEnMora > 0
							BEGIN 
								SET @CapitalVencidoAcumular = ROUND(ROUND(@cuoPrestamoValorCiclo,2)*@MesesEnMora,2)
							END
					END
				    SET @cuoPrestamoCapitalVencido = @CapitalVencidoAcumular
					SET @diasEnMora = (SELECT DATEDIFF(DAY,@cuoPrestamoFechaLimite,GETDATE()))
				    SET @cuoPrestamoInteresMoratorio = ROUND(((@cuoPrestamoCapitalVencido * (( CONVERT(FLOAT,@preInteresMoratorio) / 100)) / 365) * @diasEnMora),2)
				SELECT ROUND((@cuoPrestamoValorCiclo + @cuoPrestamoIntereses + @cuoPrestamoInteresMoratorio),2)
			END
	END

	IF @accion = 'COMPROBAR_MONTO_PAGAR'
		BEGIN
			SET @prePorcentajeInteres = (SELECT p.prePorcentajeInteres FROM Prestamos p WHERE preId = @preId)
			IF (SELECT COUNT(*) FROM CuotasPrestamos cp WHERE preId = @preId) > 0
				BEGIN
					SELECT TOP 1 CASE WHEN
									ROUND(((cp.cuoPrestamoSaldo-cp.cuoPrestamoAbonoCapital)+(SELECT ROUND(((cp.cuoPrestamoSaldo * (( @prePorcentajeInteres / 100)) / 365) * 30),2))),2) > ROUND(@couPrestamoTotalPagarCiclo,2) THEN
										'true' 
									ELSE 
										'false' 
									END 
					FROM CuotasPrestamos cp WHERE cp.preId = @preId ORDER BY cp.cuoPrestamoId DESC
				END
			ELSE
				BEGIN
					SELECT CASE WHEN p.preMontoAprovado > @couPrestamoTotalPagarCiclo THEN 'true' ELSE 'false' END FROM Prestamos p WHERE preId = @preId
				END

		END

	IF @accion = 'INS_PRESTAMOS_PRIMERA_CUOTA'
	BEGIN
		DECLARE @DiasProrrogaPrimeraCuota INT = 0
		SET @DiasProrrogaPrimeraCuota = (SELECT CONVERT(INT,vc.varConfiguracionValor) FROM VariablesDeConfiguracion vc WHERE vc.varConfiguracionId = 3)
		--Insertar primera cuota
		INSERT INTO CuotasPrestamos(preId,cuoPrestamoFechaPago,cuoPrestamoFechaLimite,cuoPrestamoFechaPagoRecibido
		,cuoPrestamoNumeroTransaccion,cuoPrestamoValorCiclo,cuoPrestamoSaldo,cuoPrestamoIntereses,couPrestamoTotalPagarCiclo) VALUES(
			@preId,
			@cuoPrestamoFechaPago,
			DATEADD(DAY,@DiasProrrogaPrimeraCuota,@cuoPrestamoFechaPago),
			null,
			'',
			@cuoPrestamoValorCiclo,
			@cuoPrestamoSaldo,
			@cuoPrestamoIntereses,
			@couPrestamoTotalPagarCiclo
		)
    END

	IF @accion = 'SELECT_GRID_CLIENTE_PRESTAMOS_PARAMETRO'
	BEGIN
	SELECT 
      CONCAT(c.cliNombres, ' ', c.cliApellidos) AS 'NOMBRE'
	  ,c.[cliRTN] AS 'RTN'
      ,c.[cliTelefono] AS 'TELEFONO'
	  ,e.estDescripcion AS 'ESTADO'
	  ,p.preFechaCreado AS 'CREADO'
	  ,p.preMontoAprovado AS 'MONTO'
	  ,p.preCuotas AS 'CUOTAS'
	  ,p.prePlazoMeses AS 'PLAZO'
	  ,p.preFechaPago AS 'PAGO INICIAL'
	  ,p.preFechaFinaliza AS 'FINALIZA'
	  ,p.preId AS 'ID'
	  ,c.cliId AS 'CLIID'
	FROM [dbo].[Prestamos] AS p 
	INNER JOIN Cliente AS c ON p.cliId = c.cliId
	INNER JOIN Estatus e ON E.estId = p.estId
	INNER JOIN FondoPrestamos fp ON fp.fonId = p.fonId
	INNER JOIN Periodos pd ON pd.perId = p.perId
	INNER JOIN Regional r ON r.regId = p.regID
	WHERE e.estId <> 3 --CANCELADO
	and (
	CONCAT(c.cliNombres, ' ', c.cliApellidos) LIKE '%'+@parametro+'%' OR
	c.cliCorreo LIKE '%'+@parametro+'%' OR
	c.cliTelefono LIKE '%'+@parametro+'%' OR
	c.cliDireccion LIKE '%'+@parametro+'%' OR
	c.cliRTN LIKE '%'+@parametro+'%' OR
	e.estDescripcion LIKE '%'+@parametro+'%' OR
	fp.fonNombre LIKE '%'+@parametro+'%' OR
	r.regNombre LIKE '%'+@parametro+'%' OR
	(p.preFechaCreado BETWEEN CONVERT(DATE,@parametro) AND DATEADD(MONTH,2,CONVERT(DATE,@parametro)) 
		OR p.preFechaCreado BETWEEN DATEADD(MONTH,-2,CONVERT(DATE,@parametro)) AND CONVERT(DATE,@parametro)) OR
	p.preMontoAprovado BETWEEN (CONVERT(MONEY,@parametro) - 100) AND (CONVERT(money,@parametro) + 100) OR
	p.preCuotas BETWEEN (CONVERT(MONEY,@parametro) - 100) AND (CONVERT(money,@parametro) + 100) OR
	pd.perNombre LIKE '%'+@parametro+'%' OR
	p.prePlazoMeses BETWEEN (CONVERT(DECIMAL,@parametro) - 3) AND (CONVERT(DECIMAL,@parametro) + 3) OR
	(p.preFechaPago BETWEEN CONVERT(DATE,@parametro) AND DATEADD(MONTH,2,CONVERT(DATE,@parametro)) 
		OR p.preFechaPago BETWEEN DATEADD(MONTH,-2,CONVERT(DATE,@parametro)) AND CONVERT(DATE,@parametro)) OR
	(p.preFechaFinaliza BETWEEN CONVERT(DATE,@parametro) AND DATEADD(MONTH,2,CONVERT(DATE,@parametro)) 
		OR p.preFechaFinaliza BETWEEN DATEADD(MONTH,-2,CONVERT(DATE,@parametro)) AND CONVERT(DATE,@parametro))
	)
	END

	IF @accion = 'SELECT_GRID_CLIENTE_PRESTAMOS'
	BEGIN
	SELECT CONCAT(c.cliNombres, ' ', c.cliApellidos) AS 'NOMBRE'
	  ,c.[cliRTN] AS 'RTN'
      ,c.[cliTelefono] AS 'TELEFONO'
	  ,e.estDescripcion AS 'ESTADO'
	  ,p.preFechaCreado AS 'CREADO'
	  ,p.preMontoAprovado AS 'MONTO L'
	  ,p.preCuotas AS 'CUOTAS L'
	  ,p.prePlazoMeses AS 'PLAZO'
	  ,p.preFechaPago AS 'PAGO INICIAL'
	  ,p.preFechaFinaliza AS 'FINALIZA'
	  ,p.preId AS 'ID'
	  ,c.cliId AS 'CLIID'
	FROM [dbo].[Prestamos] AS p 
	INNER JOIN Cliente AS c ON p.cliId = c.cliId
	INNER JOIN Estatus e ON E.estId = p.estId
	INNER JOIN FondoPrestamos fp ON fp.fonId = p.fonId
	INNER JOIN Periodos pd ON pd.perId = p.perId
	INNER JOIN Regional r ON r.regId = p.regID
	WHERE e.estId <> 3 --CANCELADO
    END

	IF @accion = 'SELECT_GRID_CLIENTE_PRESTAMOS_ID'
	BEGIN
	SELECT CONCAT(c.cliNombres, ' ', c.cliApellidos) AS 'NOMBRE'
	  ,c.[cliRTN] AS 'RTN'
      ,c.[cliTelefono] AS 'TELEFONO'
	  ,e.estDescripcion AS 'ESTADO'
	  ,p.preFechaCreado AS 'CREADO'
	  ,p.preMontoAprovado AS 'MONTO L'
	  ,p.preCuotas AS 'CUOTAS L'
	  ,p.prePlazoMeses AS 'PLAZO'
	  ,p.preFechaPago AS 'PAGO INICIAL'
	  ,p.preFechaFinaliza AS 'FINALIZA'
	  ,p.preId AS 'ID'
	  ,c.cliId AS 'CLIID'
	  ,fp.fonId
	  ,r.regId
	  ,p.prePorcentajeInteres AS 'INTERES'
	  ,p.preGastosAdministrativos AS 'GASTOADM'
	  ,p.preInteresMoratorio
	  
	FROM [dbo].[Prestamos] AS p 
	INNER JOIN Cliente AS c ON p.cliId = c.cliId
	INNER JOIN Estatus e ON E.estId = p.estId
	INNER JOIN FondoPrestamos fp ON fp.fonId = p.fonId
	INNER JOIN Periodos pd ON pd.perId = p.perId
	INNER JOIN Regional r ON r.regId = p.regID
	WHERE p.preId = @preId 
	AND e.estId <> 3 --CANCELADO
    END

	IF @accion = 'SELECT_GRID_CLIENTE_CUOTAS_PRESTAMOS'
	BEGIN
	SELECT 
	cp.cuoPrestamoFechaPagoRecibido AS 'FECHA'
	,cp.cuoPrestamoNumeroTransaccion AS 'NO. TRANSACCION'
	,cp.cuoPrestamoAbonoCapital AS 'ABONO CAPITAL'
	,cp.cuoPrestamoIntereses AS 'INTERES CORRIENTE'
	,cp.cuoPrestamoInteresMoratorio AS 'INTERES MORATORIO'
	,cp.cuoPrestamoCapitalVencido AS 'CAPITAL ATRASADO'
	,cp.couPrestamoTotalPagarCiclo AS 'TOTAL PAGADO'
	,cp.cuoPrestamoSaldo AS 'SALDO'
	FROM [dbo].CuotasPrestamos cp
	WHERE cp.preId = @preId
    END

	IF @accion = 'SELECT_REPORTE_CLIENTE_CUOTAS_PRESTAMOS'
	BEGIN
	SELECT 
	cp.cuoPrestamoFechaPagoRecibido AS 'FECHA'
	,cp.cuoPrestamoFechaLimite
	,cp.cuoPrestamoFechaPago
	,cp.cuoPrestamoNumeroTransaccion AS 'NO. TRANSACCION'
	,cp.cuoPrestamoAbonoCapital AS 'ABONO CAPITAL'
	,cp.cuoPrestamoIntereses AS 'INTERES CORRIENTE'
	,cp.cuoPrestamoInteresMoratorio AS 'INTERES MORATORIO'
	,cp.cuoPrestamoCapitalVencido AS 'CAPITAL ATRASADO'
	,cp.couPrestamoTotalPagarCiclo AS 'TOTAL PAGADO'
	,cp.cuoPrestamoSaldo AS 'SALDO'
	FROM [dbo].CuotasPrestamos cp
	WHERE cp.preId = @preId
    END

	IF @accion = 'SELECT_REPORTE_PRESTAMO_CLIENTE'
	BEGIN
	SELECT 
	  c.cliNombres AS 'NOMBRE'
	  ,c.cliApellidos AS 'APELLIDO'
	  ,c.[cliRTN] AS 'RTN'
      ,c.[cliTelefono] AS 'TELEFONO'
	  ,e.estDescripcion AS 'ESTADO'
	  ,p.preFechaCreado AS 'CREADO'
	  ,p.preMontoAprovado AS 'MONTO L'
	  ,p.preCuotas AS 'CUOTAS L'
	  ,p.prePlazoMeses AS 'PLAZO'
	  ,p.preFechaPago AS 'PAGO INICIAL'
	  ,p.preFechaFinaliza AS 'FINALIZA'
	  ,p.preId AS 'ID'
	  ,c.cliId AS 'CLIID'
	  ,fp.fonId
	  ,fp.fonNombre
	  ,r.regId
	  ,r.regNombre
	  ,p.prePorcentajeInteres AS 'INTERES'
	  ,p.preGastosAdministrativos AS 'GASTOADM'
	  ,p.preInteresMoratorio
	  
	FROM [dbo].[Prestamos] AS p 
	INNER JOIN Cliente AS c ON p.cliId = c.cliId
	INNER JOIN Estatus e ON E.estId = p.estId
	INNER JOIN FondoPrestamos fp ON fp.fonId = p.fonId
	INNER JOIN Periodos pd ON pd.perId = p.perId
	INNER JOIN Regional r ON r.regId = p.regID
	WHERE p.preId = @preId 
    END

	IF @accion = 'DLT_PRESTAMO'
	BEGIN
		UPDATE Prestamos SET estId = 3 WHERE preId = @preId
    END

	--FIN PRESTAMOS

END

