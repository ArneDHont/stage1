
-- Doel: Ophalen alle verbruiksartikelen
-- Auteur: Rajiv Blancke - Koen Heye 21/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBRKART]

AS

SET NOCOUNT OFF;

	select *
	from BBBRKART
	order by SCF_ART

