
-- Doel: Ophalen van één bbewakingsregistratie, diverseRegistratie
-- Auteur: Rajiv Blancke - Koen Heye 14/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBREGVSH]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg


	/* 2. Gegevens van een diverse registratie ophalen */
	
	select BBREGVSH.*, BBFRM.NM_FRM, BBFRM.STRA_FRM, BBFRM.PO_COD_PLA_FRM, BBFRM.PLA_FRM
			      , BBVZKFRM.NM_FRM_VZK, BBVZKFRM.AD_FRM_VZK, BBVZKFRM.PLA_FRM_VZK
	from BBREGVSH
	join BBBEWREG on BBREGVSH.ID_REG = BBBEWREG.ID_REG		
	join BBFRM on BBREGVSH.ID_FRM = BBFRM.ID_FRM	
	left join BBVZKFRM on BBREGVSH.ID_FRM_VZK = BBVZKFRM.ID_FRM_VZK
	where BBREGVSH.ID_REG = @IdBewReg

