
-- Doel: Ophalen van de algemene gegevens van één bbewakingsregistratie
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_ALGGEG]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Registratie ophalen */

	select *, year(TMS_OPS_REG) as JR_REG
	from BBBEWREG
	where ID_REG = @IdBewReg


	/* 2. Bijlagen ophalen*/

	select *
	from BBBYLG
	where BBBYLG.ID_REG = @IdBewReg

	/* 3. Bestemmelingen ophalen */
	select BBBST.*, BBIND.NM_IND, BBIND.VNM_IND, BBIND.AD_EMAL_IND
	from BBBST
	join BBIND on BBIND.ID_IND = BBBST.ID_IND
	where BBBST.ID_REG = @IdBewReg

