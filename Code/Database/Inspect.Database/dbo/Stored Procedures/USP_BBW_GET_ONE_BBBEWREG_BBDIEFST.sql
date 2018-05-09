
-- Doel: Ophalen van één bewakingsegistratie, diefstal
-- Auteur: Rajiv Blancke - Koen Heye 12/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBDIEFST]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg


	/* 2. Gegevens diefstal ophalen */
	
	select BBDIEFST.*, mld.NM_IND, mld.VNM_IND, mld.AD_IND, mld.PO_COD_WNPL_IND, mld.WNPL_IND
			   , dupind.NM_IND, dupind.VNM_IND
	from BBDIEFST
	join BBBEWREG on BBDIEFST.ID_REG = BBBEWREG.ID_REG
	join BBIND as mld on BBDIEFST.ID_MLD = mld.ID_IND
	left join BBIND as dupind on BBDIEFST.ID_DUP_IND = dupind.ID_IND
	where BBDIEFST.ID_REG = @IdBewReg

	select BBFRM.*
	from BBFRM
	join BBDIEFST on BBFRM.ID_FRM = BBDIEFST.ID_FRM
	where BBDIEFST.ID_REG = @IdBewReg

