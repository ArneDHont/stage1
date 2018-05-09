CREATE TABLE [db_Inspect].[InspectionEquipmentFeedback]
(
	[InspectionEquipmentFeedbackId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , 
    [EquipmentId] BIGINT NULL, 
    [Status] NVARCHAR(50) NULL, 
    [FeedbackTypeId] INT NULL, 
    [Remark] NVARCHAR(50) NULL, 
    [TimeCompleted] DATETIME NULL, 
    [OperatorId] INT NULL, 
    [EquipmentLocationName] NVARCHAR(50) NULL, 
    [EquipmentLocationDescription] NVARCHAR(150) NULL, 
    [Vera] BIT NULL, 
    [Weight] FLOAT NULL, 
    CONSTRAINT [FK_InspectionEquipmentFeedback_ToFeedbackType] FOREIGN KEY ([FeedbackTypeId]) REFERENCES [db_Inspect].[FeedbackType]([FeedbackTypeId]), 
    CONSTRAINT [FK_InspectionEquipmentFeedback_ToBBBWPERS] FOREIGN KEY ([OperatorId]) REFERENCES [dbo].[BBBWPERS](ID_IND),    
    CONSTRAINT [FK_InspectionEquipmentFeedback_TobmMateriaal] FOREIGN KEY ([EquipmentId]) REFERENCES [dbo].[bmMateriaal]([EquipmentId])
)
