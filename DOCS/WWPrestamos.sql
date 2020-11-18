-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.WWPrestamos 
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

	--PARAMTROS DE LA TABLA DE CUOTAS PRESTAMO
	@cuoPrestamoId INT =0,
	@cuoPrestamoFechaPago DATE = NULL,
	@cuoPrestamoFechaLimite DATE =NULL,
	@cuoPrestamoFechaPagoRecibido DATE = NULL,
	@cuoPrestamoNumeroTransaccion VARCHAR(300) = '',
	@cuoPrestamoValorCiclo MONEY = 0,
	@cuoPrestamoSaldo MONEY = 0,
	@cuoPrestamoIntereses MONEY =0,
	@couPrestamoTotalPagarCiclo MONEY = 0

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
END
GO
