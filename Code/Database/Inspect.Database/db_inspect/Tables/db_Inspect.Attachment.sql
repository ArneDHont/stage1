CREATE TABLE [db_inspect].[Attachment]
(
	[AttachmentId] INT NOT NULL IDENTITY , 
    [FileName] NVARCHAR(100) NOT NULL, 
    [Size] BIGINT NOT NULL, 
    [DateCreated ] DATETIME NOT NULL, 
    CONSTRAINT [PK_Attachment] PRIMARY KEY ([AttachmentId])
)
