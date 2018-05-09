﻿
-- Doel: Ophalen alle betrokkenen van een aanrijding
-- Auteur: DIEN  okt 2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBTROGV]
	 @id_reg int
AS

SET NOCOUNT OFF;
	SELECT BBBTROGV.*,  BBIND.NM_IND, BBIND.VNM_IND
	FROM BBBTROGV
	INNER JOIN BBIND
	ON BBIND.ID_IND = BBBTROGV.ID_IND_BTRK
	WHERE ID_REG = @id_reg

