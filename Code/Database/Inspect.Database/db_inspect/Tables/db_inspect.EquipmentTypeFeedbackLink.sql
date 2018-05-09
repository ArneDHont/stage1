CREATE TABLE [db_inspect].[EquipmentTypeFeedbackLink]
(
    [EquipmentTypeId] INT NOT NULL, 
    [FeedbackTypeId] INT NOT NULL, 
    PRIMARY KEY ([EquipmentTypeId], [FeedbackTypeId]), 
    CONSTRAINT [FK_EquipmentTypeFeedbackLink_FeedbackType] FOREIGN KEY ([FeedbackTypeId]) REFERENCES [db_inspect].[FeedbackType]([FeedbackTypeId]), 
    CONSTRAINT [FK_EquipmentTypeFeedbackLink_bmTypeMateriaal] FOREIGN KEY ([EquipmentTypeId]) REFERENCES [dbo].[bmTypeMateriaal]([TypeMatID]), 
    
)
