
-- Doel: Ophalen alle Bawakingspersoneelsleden
-- Auteur: Rajiv Blancke - Koen Heye 13/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ALL_BBWAKPERS]
AS

SET NOCOUNT OFF;
		select BBBWPERS.ID_IND, NM_IND, VNM_IND, SCF_PLG_IND
		from BBBWPERS
		join BBIND on BBBWPERS.ID_IND = BBIND.ID_IND
		join BBBWPLG on BBBWPLG.ID_PLG_IND = BBBWPERS.ID_PLG_IND
		where WAK = 1
		order by NM_IND

