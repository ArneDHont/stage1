CREATE TABLE [db_Inspect].[OrganisationUnitExtensions]
(
	[OrganisationUnitId] INT NOT NULL PRIMARY KEY, 
    [Remark] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_OrganisationUnitExtensions_bmAfdeling] FOREIGN KEY ([OrganisationUnitId]) REFERENCES [dbo].[bmAfdeling]([AfdelingID])
)
