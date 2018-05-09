
-- Doel: Ophalen van één bewakingsegistratie,aanrijding
-- Auteur: Rajiv Blancke - Koen Heye 12/05/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBOGVTSP]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg


	/* 2. Gegevens aanrijding ophalen */
	
	select BBOGVTSP.*, BBIND.NM_IND, BBIND.VNM_IND
	from BBOGVTSP
	inner join BBBEWREG on BBOGVTSP.ID_REG = BBBEWREG.ID_REG
	inner join BBIND on BBOGVTSP.ID_MLD = BBIND.ID_IND		
	where BBOGVTSP.ID_REG = @IdBewReg

	/* 3. Aanrijding toestanden */
	Select BBOGVSTA.*
	FROM BBOGVSTA
   	WHERE BBOGVSTA.ID_REG = @IdBewReg

	/*4. Betrokkenen*/
	Select 	BBBTROGV.*,
		BBIND.NM_IND,
		BBIND.VNM_IND
	FROM BBBTROGV
     	INNER JOIN BBIND
	ON BBIND.ID_IND =  BBBTROGV.ID_IND_BTRK
	Where ID_REG = @IdBewReg

