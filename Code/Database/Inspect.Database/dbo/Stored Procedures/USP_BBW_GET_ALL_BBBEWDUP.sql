
-- Doel: Ophalen alle gedupeerden van een bewakingsregistratie (enkel voor controle voertuigen, inbreuk op
-- reglementen en schadegeval
-- Auteur: Rajiv Blancke - Koen Heye 02/05/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBEWDUP]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBBEWDUP
	ORDER BY ID_BEW_DUP

