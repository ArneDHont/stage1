﻿
-- Doel: Ophalen laatste nummer voertuig
-- Auteur: DIEN - okt. 2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_LAST_BBTSP]
AS

SET NOCOUNT OFF;
	SELECT TOP 1 BBTSP.ID_TSP
	FROM BBTSP
	ORDER BY ID_TSP DESC
