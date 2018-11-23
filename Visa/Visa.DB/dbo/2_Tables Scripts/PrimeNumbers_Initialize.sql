
DECLARE @counter INT
SET @counter = 2
WHILE @counter < 10000
BEGIN
	IF NOT EXISTS(SELECT TOP 1 number FROM PrimeNumbers WHERE @counter % number = 0 )
	INSERT INTO PrimeNumbers SELECT @counter
	set @counter = @counter + 1
END
