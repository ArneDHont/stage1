
-- Doel: Ophalen van één bewakingsegistratie, inbreuk op reglementen
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBINBRRG]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg


	/* 2. Gegevens inbreuk op reglementen ophalen */
	
	select BBINBRRG.*, BBIND.NM_IND, BBIND.VNM_IND, BBIND.AD_IND
							      , BBIND.PO_COD_WNPL_IND, BBIND.WNPL_IND, BBIND.SAP_AFD
	from BBINBRRG
	join BBBEWREG on BBINBRRG.ID_REG = BBBEWREG.ID_REG
	join BBIND on BBINBRRG.ID_INBR = BBIND.ID_IND		
	where BBINBRRG.ID_REG = @IdBewReg

	/* 3. Vastgestelde inbreuken ophalen */
	select BBINBRVA.*, BBINBRAR.NR_ART_INBR, BBINBRAR.SCF_ART_INBR
	from BBINBRVA
	join BBINBRRG on BBINBRVA.ID_REG = BBINBRRG.ID_REG
	join BBINBRAR on BBINBRVA.ID_ART_INBR = BBINBRAR.ID_ART_INBR
	where BBINBRVA.ID_REG = @IdBewReg

	/* 4. Voertuig */
	select BBTSP.*, BBIND.NM_IND, BBIND.VNM_IND, BBFRM.*, BBTYTSP.SCF_TY_TSP
	from  BBTSP
	join BBINBRRG on BBTSP.ID_TSP = BBINBRRG.ID_TSP
	left join BBIND on BBTSP.ID_EIG_TSP = BBIND.ID_IND
	left join BBFRM on BBTSP.ID_FRM_TSP = BBFRM.ID_FRM
	left join BBTYTSP on BBTSP.ID_TY_TSP = BBTYTSP.ID_TY_TSP
	where BBINBRRG.ID_REG = @IdBewReg

	/* 5. Firma */
	select BBFRM.*
	from  BBFRM
	join BBINBRRG on BBFRM.ID_FRM = BBINBRRG.ID_FRM
	where BBINBRRG.ID_REG = @IdBewReg

