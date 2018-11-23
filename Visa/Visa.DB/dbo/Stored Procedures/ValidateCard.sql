CREATE PROCEDURE ValidateCard
(
	@CardNumber varchar(16),
	@ExpirationDate int
)
AS
BEGIN
	

	SELECT 0 As Id, @CardNumber As CardNumber, @ExpirationDate As ExpirationDate, 0 As TCard, 1 As VCard
	
END