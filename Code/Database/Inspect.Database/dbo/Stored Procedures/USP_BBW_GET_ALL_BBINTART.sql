
-- Doel: Ophalen alle materiaalkosten
-- Auteur: Rajiv Blancke - Koen Heye 07/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINTART]

AS

SET NOCOUNT OFF;

	select *
	from BBINTART
	order by SCF_ART_INTV

