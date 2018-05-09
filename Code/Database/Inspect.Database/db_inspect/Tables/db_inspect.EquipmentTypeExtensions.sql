CREATE TABLE [db_inspect].[EquipmentTypeExtensions]
(
	[EquipmentTypeId] INT NOT NULL, 
	[Trigram] NVARCHAR(3) NOT NULL,
    CONSTRAINT [PK_EquipmentTypeExtensions] PRIMARY KEY ([EquipmentTypeId]), 
    CONSTRAINT [FK_EquipmentTypeExtensions_EquipmentType] FOREIGN KEY (EquipmentTypeId) REFERENCES [dbo].[bmTypeMateriaal]([TypeMatID])
)
