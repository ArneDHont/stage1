-- =============================================
-- Author:		Nancy Coppens
-- Create date: 17/11/2017
-- Description:	Lijst van klachten voor CHIP ophalen - extra zoeken op firmanr
-- =============================================
CREATE PROCEDURE [dbo].[UPS_BBW_GET_ALL_CHIP_KLACHTEN_SAPfirmanr] 
	@DateFrom nvarchar(19),
	@DateTo   nvarchar(19),
	@SAP_SUPPLIER_ID nvarchar(30)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [VW_CHIP_KLACHTEN] 
	WHERE [TMS_INC] >= @DateFrom 
	AND [TMS_INC] <= @DateTo
	AND SAP_SUPPLIER_ID = @SAP_SUPPLIER_ID
END