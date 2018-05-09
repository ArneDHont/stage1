CREATE TABLE [db_Inspect].[InspectionEquipmentFeedbackAttachment]
(
	[AttachmentId] INT NOT NULL, 
	[InspectionEquipmentFeedbackId] INT NOT NULL , 
    
	CONSTRAINT [FK_InspectionEquipmentFeedbackAttachment_Attachment] FOREIGN KEY (AttachmentId) REFERENCES [db_Inspect].[Attachment]([AttachmentId]), 
    CONSTRAINT [FK_InspectionEquipmentFeedbackAttachment_InspectionEquipmentFeedback] FOREIGN KEY ([InspectionEquipmentFeedbackId]) REFERENCES [db_Inspect].[InspectionEquipmentFeedback]([InspectionEquipmentFeedbackId]), 
    CONSTRAINT [PK_InspectionEquipmentFeedbackAttachment] PRIMARY KEY ([AttachmentId]) 
)
