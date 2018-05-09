CREATE VIEW [db_inspect].[Equipment]
AS

SELECT        dbo.bmMateriaal.EquipmentId, dbo.bmMateriaal.TypeMatID AS EquipmentTypeId, dbo.bmMateriaal.SoortTypeMatID AS EquipmentTypeConfigurationId, dbo.bmMateriaal.MateriaalVolgNr AS Number, 
                         dbo.bmMateriaal.FabricatieNr AS SerialNumber, dbo.bmMateriaal.DatumVisueleKeuring AS DateVisualInspection, dbo.bmMateriaal.GewichtVisueleKeuring AS Weight, dbo.bmBrandblusCode.BrandblusCodeID
FROM            dbo.bmBrandblusCode INNER JOIN
                         dbo.bmSoortTypeMateriaal ON dbo.bmBrandblusCode.BrandblusCodeID = dbo.bmSoortTypeMateriaal.BrandblusCodeID AND 
                         dbo.bmBrandblusCode.BrandblusCodeID = dbo.bmSoortTypeMateriaal.BrandblusCodeID RIGHT OUTER JOIN
                         dbo.bmMateriaal ON dbo.bmSoortTypeMateriaal.SoortTypeMatID = dbo.bmMateriaal.SoortTypeMatID
WHERE        (dbo.bmMateriaal.DateDeleted IS NULL)