
-- Doel: Ophalen van één bewakingsegistratie, openmaken kleerkast
-- Auteur: Rajiv Blancke - Koen Heye 13/04/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBBEWREG_BBOPKAST]
@IdBewReg int

AS

SET NOCOUNT OFF;
	/* 1. Algemene gegevens ophalen */
	exec USP_BBW_GET_ONE_BBBEWREG_ALGGEG
		@IdBewReg = @IdBewReg


	/* 2. Gegevens diefstal ophalen */
	
	select BBOPKAST.*, titu.NM_IND, titu.VNM_IND
			   , anvr.NM_IND, anvr.VNM_IND
			   , eigSid.NM_IND, eigSid.VNM_IND
			   , eigTitu.NM_IND, eigTitu.VNM_IND
	from BBOPKAST
	join BBBEWREG on BBOPKAST.ID_REG = BBBEWREG.ID_REG
	join BBIND as titu on BBOPKAST.ID_TITU_KAST = titu.ID_IND
	join BBIND as anvr on BBOPKAST.ID_DNS_OPS_KAST_VR = anvr.ID_IND
	join BBIND as eigSid on BBOPKAST.ID_OTV_EIG_SID = eigSid.ID_IND
	join BBIND as eigTitu on BBOPKAST.ID_OTV_EIG_TITU = eigTitu.ID_IND
	where BBOPKAST.ID_REG = @IdBewReg

