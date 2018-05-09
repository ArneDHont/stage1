-- =============================================
-- Author:		Geert Maertens
-- Create date: 2011-12-02
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[ExtractMin] 
(
	@s nvarchar(5)
)
RETURNS int
AS
BEGIN
	DECLARE @Result int

	SELECT @Result =
		CASE charindex (':', @s)
			WHEN 2 THEN substring(@s, 3, 5)
			WHEN 3 THEN substring(@s, 4, 5)
			ELSE 0
		END;

	RETURN @Result
END