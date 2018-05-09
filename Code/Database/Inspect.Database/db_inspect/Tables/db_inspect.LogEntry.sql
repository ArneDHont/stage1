CREATE TABLE [db_inspect].[LogEntry]
(
	[LogEntryId] INT NOT NULL IDENTITY, 
    [Date] DATETIMEOFFSET NOT NULL, 
    [HostName] NVARCHAR(255) NULL, 
    [Thread] NVARCHAR(255) NULL, 
    [Level] NVARCHAR(50) NOT NULL, 
    [Logger] NVARCHAR(255) NOT NULL, 
    [Message] NVARCHAR(4000) NULL, 
    [Exception] NVARCHAR(4000) NULL, 
    CONSTRAINT [PK_LogEntry] PRIMARY KEY ([LogEntryId]) 
)

GO

CREATE INDEX [IX_LogEntry_Data] ON [db_inspect].[LogEntry] ([Date])

GO

CREATE INDEX [IX_LogEntry_Level] ON [db_inspect].[LogEntry] ([Level])
