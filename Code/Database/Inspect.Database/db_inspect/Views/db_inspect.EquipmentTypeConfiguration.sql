CREATE VIEW [db_inspect].[EquipmentTypeConfiguration]
AS 

SELECT
	 [bmSoortTypeMateriaal].[SoortTypeMatID] AS [EquipmentTypeConfigurationId]
	,[bmSoortTypeMateriaal].[TypeMatID] AS [EquipmentTypeId]
	,[bmSoortTypeMateriaal].[BrandblusCodeID] AS [MediumId]
	,[bmSoortTypeMateriaal].[BrandblusInhoud] AS [Weight]
	,[bmSoortTypeMateriaal].[SoortTypeMatOmschr] AS [Name]
FROM 
	[dbo].[bmSoortTypeMateriaal]
		--INNER JOIN [dbo].[bmTypeMateriaal] -- Enforce as required FK because it is missing in the database
		--	ON  [bmTypeMateriaal].[TypeMatID] = [bmSoortTypeMateriaal].[TypeMatID]
		--LEFT OUTER  JOIN [dbo].[bmBrandblusCode] -- Enforce optional FK
		--	ON [bmBrandblusCode].[BrandblusCodeID] = [bmSoortTypeMateriaal].[BrandblusCodeID]
--WHERE
--	NOT ([bmSoortTypeMateriaal].[BrandblusCodeID] IS NOT NULL AND [bmBrandblusCode].[BrandblusCodeID] IS NULL) -- Enforce optional FK
