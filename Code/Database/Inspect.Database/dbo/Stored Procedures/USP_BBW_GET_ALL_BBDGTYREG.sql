﻿
-- Doel: Ophalen alle registratietypes dagverslag
-- Auteur: SIDDIEN okt 2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBDGTYREG]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBDGTYREG
	ORDER BY SCF_DG_PERS_TY_REG

