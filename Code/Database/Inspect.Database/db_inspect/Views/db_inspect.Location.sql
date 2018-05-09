CREATE VIEW [db_inspect].[Location]
AS
SELECT
	 [LocatieID] AS [LocationId]
	,[AfdelingID] AS [OrganisationUnitId]
    ,[LocatieZone] AS [Name]
FROM 
	[dbo].[bmLocatie]
		INNER JOIN [db_inspect].[OrganisationUnitExtensions]
			ON [OrganisationUnitExtensions].[OrganisationUnitId] = [bmLocatie].[AfdelingID]