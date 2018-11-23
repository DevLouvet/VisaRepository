IF OBJECT_ID('ValidateCard', 'P') IS NOT NULL
BEGIN
	DROP PROCEDURE ValidateCard
END
GO

CREATE PROCEDURE ValidateCard
(
	@CardNumber varchar(16),
	@ExpirationDate int
)
AS
BEGIN
	DECLARE @IdExist INT = 0
			, @TCard INT = NULL
			, @VCard INT = 0

	SELECT @IdExist = Id, @TCard = TCard, @VCard = VCard
	FROM dbo.Cards
	WHERE CardNumber = @CardNumber
		 AND ExpirationDate =  @ExpirationDate

	IF @TCard IS NULL
	BEGIN
		SET @TCard = CASE WHEN LEFT(@CardNumber, 1) = '4' THEN 1
						  WHEN LEFT(@CardNumber, 1) = '5' THEN 2
						  WHEN LEFT(@CardNumber, 2) = '34' OR LEFT(@CardNumber, 2) = '37' THEN 3
						  WHEN LEFT(@CardNumber, 4) = '3528' OR LEFT(@CardNumber, 4) = '3589' THEN 4
						  ELSE 0 END
	END
	
	IF @VCard IS NULL
	BEGIN
		DECLARE @Year INT = CAST(RIGHT(@ExpirationDate, 4) AS INT)
		SET @VCard = CASE WHEN (@TCard = 1 AND ((@Year % 4 = 0 AND @Year % 100 <> 0) OR @Year % 400 = 0))
							  OR (@TCard = 2 AND dbo.fn_primeyear(@Year) = 1) 
							  OR (@TCard = 3 AND LEN(@CardNumber) = 15)
							  OR @TCard = 4 
							  THEN 1
						  ELSE 2 END
	END
	
	IF @IdExist <> 0
	BEGIN
		UPDATE Cards
		SET TCard = @TCard,
			VCard = @VCard
		WHERE Id = @IdExist
	END

	SELECT @IdExist As Id, @CardNumber As CardNumber, @ExpirationDate As ExpirationDate, @TCard As TCard, @VCard As VCard
END
GO