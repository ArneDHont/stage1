CREATE VIEW [db_inspect].[OrganisationUnit]
AS

SELECT
	[AfdelingID] AS [OrganisationUnitId]
	,[AfdelingCode] AS [Code]
	,[AfdelingNaam] AS [Name]
FROM 
	[dbo].[bmAfdeling]
		INNER JOIN [db_inspect].[OrganisationUnitExtensions]
			ON [OrganisationUnitExtensions].[OrganisationUnitId] = [bmAfdeling].[AfdelingID]
GO
