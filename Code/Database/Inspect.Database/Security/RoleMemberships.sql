ALTER ROLE [db_owner] ADD MEMBER [uRole_RelMgr];


GO

ALTER ROLE [db_datareader] ADD MEMBER [uRole_DataReader];


GO

ALTER ROLE [db_datareader] ADD MEMBER [uRole_Appl];


GO

ALTER ROLE [db_datawriter] ADD MEMBER [uRole_Appl];


GO
