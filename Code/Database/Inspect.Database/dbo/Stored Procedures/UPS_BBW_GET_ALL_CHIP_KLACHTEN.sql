-- =============================================
-- Author:		Lawrence Verbruggen
-- Create date: 21/02/2011
-- Description:	Lijst van klachten voor CHIP ophalen
-- =============================================
CREATE PROCEDURE [dbo].[UPS_BBW_GET_ALL_CHIP_KLACHTEN] 
	@DateFrom nvarchar(19),
	@DateTo   nvarchar(19)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [VW_CHIP_KLACHTEN] 
	WHERE [TMS_INC] >= @DateFrom AND [TMS_INC] <= @DateTo
	AND SAP_SUPPLIER_ID IS NOT NULL 
END