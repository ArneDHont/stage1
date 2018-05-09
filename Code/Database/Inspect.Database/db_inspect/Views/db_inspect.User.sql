CREATE VIEW [db_inspect].[User]
	AS SELECT        dbo.BBIND.ID_IND AS UserId, CONVERT(nvarchar(20), dbo.BBBWPERS.ID_IND) AS EmployeeNumber, LTRIM(RTRIM(dbo.BBIND.NM_IND)) AS LastName, LTRIM(RTRIM(dbo.BBIND.VNM_IND)) AS FirstName, 
                         SUBSTRING(dbo.BBBWPLG.SCF_PLG_IND, PATINDEX('%[^0]%', dbo.BBBWPLG.SCF_PLG_IND + '.'), LEN(dbo.BBBWPLG.SCF_PLG_IND)) AS Team, dbo.BBBWPERS.ActiefYN AS Active, ISNULL(dbo.BBBWPERS.BRDW, 0) 
                         AS BRDW, dbo.BBBWPLG.PLG_Mail
	FROM            dbo.BBBWPERS INNER JOIN
                         dbo.BBBWPLG ON dbo.BBBWPERS.ID_PLG_IND = dbo.BBBWPLG.ID_PLG_IND INNER JOIN
                         dbo.BBIND ON dbo.BBBWPERS.ID_IND = dbo.BBIND.ID_IND