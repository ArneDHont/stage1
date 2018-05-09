CREATE TABLE [db_inspect].[InspectionSummary]
(
	[InspectionSummaryId] INT NOT NULL  IDENTITY, 
    [OperatorId] INT NOT NULL, 
    [BackupOperatorId] INT NULL, 
    [OrganisationUnitId] INT NOT NULL, 
    [LocationId] INT NOT NULL, 
    [DateStarted] DATETIME NOT NULL, 
    [DateFinished] DATETIME NOT NULL, 
    [Completed] BIT NOT NULL, 
	[TotalToInspect] INT NOT NULL,
    [TotalInspected] INT NOT NULL, 
    [TotalApproved] INT NOT NULL, 
    [TotalDisapproved] INT NOT NULL, 
    [Remarks] NVARCHAR(150) NULL, 
     
    CONSTRAINT [FK_InspectionSummary_User_Operator] FOREIGN KEY ([OperatorId]) REFERENCES [dbo].[BBIND]([ID_IND]), 
    CONSTRAINT [FK_InspectionSummary_User_BackupOperator] FOREIGN KEY ([BackupOperatorId]) REFERENCES [dbo].[BBIND]([ID_IND]), 
    CONSTRAINT [FK_InspectionSummary_OrganizationUnit] FOREIGN KEY ([OrganisationUnitId]) REFERENCES [dbo].[bmAfdeling]([AfdelingID]), 
    CONSTRAINT [FK_InspectionSummary_Location] FOREIGN KEY ([LocationId]) REFERENCES [dbo].[bmLocatie]([LocatieID]), 
    CONSTRAINT [PK_InspectionSummary] PRIMARY KEY ([InspectionSummaryId])
)
