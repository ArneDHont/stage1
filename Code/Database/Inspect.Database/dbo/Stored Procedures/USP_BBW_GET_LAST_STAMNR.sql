﻿
-- Doel: Ophalen laatste stamnummer
-- Auteur: DIEN - okt. 2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_LAST_STAMNR]
AS

SET NOCOUNT OFF;
	SELECT TOP 1 BBIND.ID_IND
	FROM BBIND
	ORDER BY ID_IND DESC

