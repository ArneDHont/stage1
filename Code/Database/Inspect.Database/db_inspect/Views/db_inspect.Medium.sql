CREATE VIEW [db_inspect].[Medium]
AS
SELECT 
	 [BrandblusCodeID] AS [MediumId]
	,[BrandblusCodeOmschr] AS [Name]
FROM 
	[dbo].[bmBrandblusCode]
