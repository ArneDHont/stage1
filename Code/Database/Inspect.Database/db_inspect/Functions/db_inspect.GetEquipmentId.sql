
CREATE FUNCTION [db_inspect].[GetEquipmentId]
(
	@EquipmentTypeId INT,
	@Number INT
)
RETURNS BIGINT
WITH SCHEMABINDING
AS
BEGIN
	DECLARE @Result BIGINT

	SELECT @Result = CAST(CAST(@EquipmentTypeId AS varbinary(32)) + CAST(@Number AS varbinary(32)) AS BIGINT)

	return @Result
END
