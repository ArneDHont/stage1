
-- Doel: Ophalen van één bewakingsregistratie, schadegeval
-- Auteur: Rajiv Blancke - Koen Heye 10/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBSCAD]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg

	/* 2. Gegevens schadegeval ophalen */

	select BBSCAD.*, BBSCADAN.SCF_OBJ_SCAD, BBIND.NM_IND, BBIND.VNM_IND
			, BBIND.AD_IND, BBIND.PO_COD_WNPL_IND, WNPL_IND, BBIND.SAP_AFD			 
	from BBSCAD
	join BBBEWREG on BBSCAD.ID_REG = BBBEWREG.ID_REG
	join BBSCADAN on BBSCAD.ID_OBJ_SCAD = BBSCADAN.ID_OBJ_SCAD
	join BBIND on BBSCAD.ID_MLD = BBIND.ID_IND	
	where BBBEWREG.ID_REG = @IdBewReg

	/* 3. Voertuig */
	select BBTSP.*, BBIND.NM_IND, BBIND.VNM_IND, BBFRM.*, BBTYTSP.SCF_TY_TSP
	from  BBTSP
	join BBSCAD on BBTSP.ID_TSP = BBSCAD.ID_TSP
	left join BBIND on BBTSP.ID_EIG_TSP = BBIND.ID_IND
	left join BBFRM on BBTSP.ID_FRM_TSP = BBFRM.ID_FRM
	left join BBTYTSP on BBTSP.ID_TY_TSP = BBTYTSP.ID_TY_TSP
	where BBSCAD.ID_REG = @IdBewReg
	
	/* 4. Firma */
	select BBFRM.*
	from  BBFRM
	join BBSCAD on BBFRM.ID_FRM = BBSCAD.ID_FRM
	where BBSCAD.ID_REG = @IdBewReg

	/* 5. Verzekeringsfirma */
	select BBVZKFRM.*
	from  BBVZKFRM
	join BBSCAD on BBVZKFRM.ID_FRM_VZK = BBSCAD.ID_FRM_VZK
	where BBSCAD.ID_REG = @IdBewReg

