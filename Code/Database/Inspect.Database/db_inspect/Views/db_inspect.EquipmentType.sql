CREATE VIEW [db_inspect].[EquipmentType]
AS
SELECT 
	 [TypeMatID] AS [EquipmentTypeId]
	 ,COALESCE([EquipmentTypeExtensions].[Trigram], RIGHT(3, N'000' + CONVERT(NVARCHAR(3), [TypeMatID]))) AS [Code]
     ,[TypeMatOmschr] AS [Name]
FROM 
	[dbo].[bmTypeMateriaal]
		LEFT OUTER JOIN [db_inspect].[EquipmentTypeExtensions]
			ON [EquipmentTypeExtensions].[EquipmentTypeId] = [TypeMatID]
