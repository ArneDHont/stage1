
-- Doel: Ophalen alle aanspreektitels
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINDGSL]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBINDGSL
	ORDER BY SCF_IND_GSL_RAP

