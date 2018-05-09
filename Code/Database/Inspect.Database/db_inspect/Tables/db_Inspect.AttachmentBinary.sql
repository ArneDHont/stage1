CREATE TABLE [db_inspect].[AttachmentBinary]
(
	[AttachmentId] INT NOT NULL, 
    [Data] VARBINARY(MAX) NOT NULL, 
    CONSTRAINT [PK_AttachmentBinary] PRIMARY KEY ([AttachmentId]), 
    CONSTRAINT [FK_AttachmentBinary_Attachment] FOREIGN KEY ([AttachmentId]) REFERENCES [db_inspect].[Attachment]([AttachmentId])
)
