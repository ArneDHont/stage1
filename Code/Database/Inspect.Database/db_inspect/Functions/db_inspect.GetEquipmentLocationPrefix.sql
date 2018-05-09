CREATE FUNCTION [db_inspect].[GetEquipmentLocationPrefix]
(
	@Number NVARCHAR(10)
)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @Suffix NVARCHAR(10)
	SET @Suffix = [db_inspect].GetEquipmentLocationSuffix(@Number);

	DECLARE @Result NVARCHAR(10)
	IF (@Suffix IS NOT NULL)
		BEGIN
			SET @Result = REPLACE(@Number, @Suffix, '')
		END
	ELSE
		BEGIN
			SET @Result = @Number
		END
	RETURN @Result
END
