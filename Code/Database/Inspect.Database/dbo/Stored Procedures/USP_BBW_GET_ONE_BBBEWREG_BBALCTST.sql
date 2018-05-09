
-- Doel: Ophalen van één bbewakingsregistratie, alcoholtest
-- Auteur: Rajiv Blancke - Koen Heye 11/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBALCTST]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg

	/* 2. Gegevens schadegeval ophalen */
	
	select BBALCTST.*, ind1.NM_IND, ind1.VNM_IND, ind2.NM_IND, ind2.VNM_IND,
				ind2.ID_TY_IND, ind2.SAP_AFD, BBFRM.NM_FRM, 
				BBFRM.STRA_FRM, BBFRM.PO_COD_PLA_FRM, BBFRM.PLA_FRM
	from BBALCTST
	join BBBEWREG on BBALCTST.ID_REG = BBBEWREG.ID_REG	
	join BBIND as ind1 on BBALCTST.ID_MLD = ind1.ID_IND
	join BBIND as ind2 on BBALCTST.ID_BTRK = ind2.ID_IND
	left join BBFRM on BBALCTST.ID_FRM = BBFRM.ID_FRM	
	where BBBEWREG.ID_REG = @IdBewReg

