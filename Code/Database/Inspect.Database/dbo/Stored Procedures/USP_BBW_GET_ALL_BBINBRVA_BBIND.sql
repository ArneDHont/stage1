
-- Doel: Ophalen van alle inbreuken van 1 bepaalde persoon
-- Auteur: Rajiv Blancke - Koen Heye 04/05/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINBRVA_BBIND]
@IdInd int,
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Reeds vastgestelde inbreuken ophalen voor een bepaalde individu */
	select BBINBRVA.*, BBINBRAR.NR_ART_INBR, BBINBRAR.SCF_ART_INBR
			    , BBBEWREG.TMS_INC, BBBEWREG.VLG_REG_JR_BPL
			    , BBBEWREG.TMS_OPS_REG
	from BBINBRVA
	join BBINBRRG on BBINBRVA.ID_REG = BBINBRRG.ID_REG
	join BBINBRAR on BBINBRVA.ID_ART_INBR = BBINBRAR.ID_ART_INBR
	left join BBBEWREG on BBINBRRG.ID_REG = BBBEWREG.ID_REG
	where BBINBRRG.ID_INBR = @IdInd
	and BBBEWREG.ID_REG <> @IdBewReg

