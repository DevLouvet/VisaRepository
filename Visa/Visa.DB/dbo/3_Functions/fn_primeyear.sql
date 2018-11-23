IF OBJECT_ID('fn_primeyear', 'FN') IS NOT NULL
BEGIN
	DROP PROCEDURE fn_primeyear
END
GO

CREATE FUNCTION dbo.fn_primeyear
(
	@Year int
)
RETURNS BIT
AS
BEGIN
	DECLARE @IsPrimeNumber BIT = 0
	SELECT @IsPrimeNumber = 1
	FROM PrimeNumbers
	WHERE number = @Year
	RETURN @IsPrimeNumber
END
GO