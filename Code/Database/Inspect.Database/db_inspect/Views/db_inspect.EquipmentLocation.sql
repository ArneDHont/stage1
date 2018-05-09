CREATE VIEW [db_inspect].[EquipmentLocation]
AS 

SELECT
	[bmMateriaal].EquipmentId AS [EquipmentId]
	,[bmMateriaal].[LocatieID] AS [LocationId]
    ,CONVERT(NVARCHAR(10), UPPER([LocatieNr])) AS [Code]
	,UPPER(LTRIM(RTRIM([db_inspect].GetEquipmentLocationPrefix([LocatieNr])))) AS [Number]
	,UPPER(LTRIM(RTRIM([db_inspect].GetEquipmentLocationSuffix([LocatieNr])))) AS [Suffix]
	,CONVERT(NVARCHAR(50), UPPER(LTRIM(RTRIM([bmAfdeling].[AfdelingCode]))) + ' ' + UPPER(LTRIM(RTRIM([bmLocatie].[LocatieZone]))) + ' ' + UPPER(LTRIM(RTRIM([LocatieNr])))) AS [Name]
    ,[LocatieOmschr] AS [Description]
	,[LocatieNrOrderBy] AS [OrderNumber]
FROM 
	[dbo].[bmMateriaal]
		INNER JOIN [dbo].[bmLocatie]
			ON [bmLocatie].[LocatieID] = [bmMateriaal].[LocatieID]
		INNER JOIN [dbo].[bmAfdeling]
			ON [bmAfdeling].[AfdelingID] = [bmLocatie].[AfdelingID]
		INNER JOIN [db_inspect].[OrganisationUnitExtensions]
			ON [OrganisationUnitExtensions].[OrganisationUnitId] = [bmAfdeling].[AfdelingID]
WHERE
	[bmMateriaal].[DateDeleted] IS NULL