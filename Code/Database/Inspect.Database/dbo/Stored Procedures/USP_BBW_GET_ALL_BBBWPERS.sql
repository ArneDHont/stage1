
-- Doel: Ophalen alle personeelsleden
-- Auteur: Dien - okt. 2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBWPERS]
AS

SET NOCOUNT OFF;
		select *
		from BBBWPERS

