
-- Doel: Ophalen van één bewakingsregistratie, controle voertuig
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBKEUTSP]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg


	/* 2. Gegevens controle voertuig ophalen */
	
	select BBKEUTSP.*, best.NM_IND, best.VNM_IND, best.AD_IND, best.PO_COD_WNPL_IND, best.WNPL_IND
					  , verant.NM_IND, verant.VNM_IND, best.SAP_AFD
	from BBKEUTSP
	join BBBEWREG on BBKEUTSP.ID_REG = BBBEWREG.ID_REG
	join BBIND as best on BBKEUTSP.ID_STUR_TSP_KEU = best.ID_IND
 	left join BBIND as verant on BBKEUTSP.ID_DNS_VTW_WR_KEU = verant.ID_IND
	where BBBEWREG.ID_REG = @IdBewReg

		
	/* 3. Voertuig */
	select BBTSP.*, BBIND.NM_IND, BBIND.VNM_IND, BBFRM.*, BBTYTSP.SCF_TY_TSP
	from  BBTSP
	join BBKEUTSP on BBTSP.ID_TSP = BBKEUTSP.ID_TSP_KEU
	left join BBIND on BBTSP.ID_EIG_TSP = BBIND.ID_IND
	left join BBFRM on BBTSP.ID_FRM_TSP = BBFRM.ID_FRM
	left join BBTYTSP on BBTSP.ID_TY_TSP = BBTYTSP.ID_TY_TSP
	where BBKEUTSP.ID_REG = @IdBewReg

	/* 4. Firma */
	select BBFRM.*
	from  BBFRM
	join BBKEUTSP on BBFRM.ID_FRM = BBKEUTSP.ID_FRM
	where BBKEUTSP.ID_REG = @IdBewReg

