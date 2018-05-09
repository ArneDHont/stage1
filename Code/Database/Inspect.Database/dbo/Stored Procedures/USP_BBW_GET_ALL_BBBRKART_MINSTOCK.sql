
-- Doel: Ophalen alle verbruiksartikelen, waarvoor huidige stock < min stock
-- Auteur: Nancy Coppens - 07/12/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBRKART_MINSTOCK]

AS

SET NOCOUNT OFF;

	select *
	from BBBRKART
	where stk_act_art < stk_min_art
	order by SCF_ART

