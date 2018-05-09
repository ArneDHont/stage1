CREATE FUNCTION [db_inspect].[GetEquipmentLocationSuffix]
(
	@Number NVARCHAR(10)
)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @Result NVARCHAR(10)
	IF (PATINDEX('%[a-z]%', @Number) <= 1) OR (PATINDEX('%[0-9]%', @Number) = 0)
		BEGIN
			SET @Result = NULL
		END
	ELSE
		BEGIN
			SET @Result = NULLIF(SUBSTRING(@Number,  PATINDEX('%[a-z]%', @Number),  LEN(@Number) - PATINDEX('%[a-z]%', @Number) + 1), '')
		END
	RETURN @Result
END
