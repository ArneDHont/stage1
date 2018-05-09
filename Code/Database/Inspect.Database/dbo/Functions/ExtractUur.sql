-- =============================================
-- Author:		Geert Maertens
-- Create date: 201112-02
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[ExtractUur] 
(
	@s nvarchar(5)
)
RETURNS int
AS
BEGIN
	DECLARE @Result int

	SELECT @Result =
		CASE charindex (':', @s)
			WHEN 2 THEN substring(@s, 1, 1)
			WHEN 3 THEN substring(@s, 1, 2)
			ELSE 0
		END;

	RETURN @Result
END