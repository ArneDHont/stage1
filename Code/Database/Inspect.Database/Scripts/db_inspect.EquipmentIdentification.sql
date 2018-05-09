USE BBW

INSERT INTO [db_inspect].[EquipmentIdentification] (EquipmentId,[Value])
SELECT [EquipmentId],
	  '1B'+[Trigram]+RIGHT('00000'+ CONVERT(VARCHAR,[MateriaalVolgNr]),6) as [Value]     
FROM [dbo].[bmMateriaal] inner join [db_inspect].[EquipmentTypeExtensions] on [dbo].[bmMateriaal].[TypeMatID] = [db_inspect].[EquipmentTypeExtensions].[EquipmentTypeId] 