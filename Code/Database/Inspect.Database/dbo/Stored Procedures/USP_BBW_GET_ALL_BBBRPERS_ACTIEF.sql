
-- Doel: Ophalen alle Brandweerpersoneelsleden
-- Auteur: Rajiv Blancke - Koen Heye 03/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBRPERS_ACTIEF]
AS

SET NOCOUNT OFF;
		select BBBWPERS.ID_IND, NM_IND, VNM_IND, SCF_PLG_IND
		from BBBWPERS
		join BBIND on BBBWPERS.ID_IND = BBIND.ID_IND
		join BBBWPLG on BBBWPLG.ID_PLG_IND = BBBWPERS.ID_PLG_IND
		where BRDW = 1
		and BBBWPERS.ActiefYN = 1
		ORDER BY NM_IND