CREATE TABLE [db_inspect].[EquipmentIdentification]
(
	[EquipmentIdentificationId] BIGINT NOT NULL IDENTITY,
	[EquipmentId] BIGINT NOT NULL,
	[Value] NVARCHAR(14), 
    CONSTRAINT [PK_EquipmentIdentification] PRIMARY KEY ([EquipmentIdentificationId]), 
    CONSTRAINT [FK_EquipmentIdentification_Equipment] FOREIGN KEY ([EquipmentId]) REFERENCES [dbo].[bmMateriaal]([EquipmentId])
)
