-- Doel: Ophalen van één brandweerinterventie, met bijhorende 
-- 1. kosten
-- 2. Interventietijden
-- 3. Bijlagen
-- 4. Bestemmelingen
-- Auteur: Rajiv Blancke - Koen Heye 31/03/2006

CREATE   PROCEDURE [dbo].[USP_BBW_GET_ONE_BBINTVBR]
@IdIntvBrdw int

AS

SET NOCOUNT OFF;
	/* 1. Interventie ophalen */

	select *,  convert(char(8), TMS_INTV, 8) as TYD_OPR
	from BBINTVBR
	where ID_INTV_BRDW = @IdIntvBrdw


	/* 2. Kosten ophalen */

	select ID_PR_MAT,  ID_INTV_BRDW, BBMATPR.ID_ART_INTV, SCF_ART_INTV,  Q_ART, PR_TOT_ART, PR_EH_ART_INTV
	from BBMATPR
	join BBINTART on BBINTART.ID_ART_INTV = BBMATPR.ID_ART_INTV
	where ID_INTV_BRDW = @IdIntvBrdw

	/* 3. Interventietijden ophalen */

	select ID_DU_INTV, BBINTVDU.ID_INTV_BRDW, BBINTVDU.ID_ART_INTV, TYD_OPR, TYD_KO,  TYD_END, SCF_ART_INTV
	from BBINTVDU
	join BBINTART on BBINTART.ID_ART_INTV = BBINTVDU.ID_ART_INTV
	where ID_INTV_BRDW = @IdIntvBrdw

	/* 4. Bijlagen ophalen */

	select BBBYLG.* 
	from BBBYLG 
	where BBBYLG.ID_INTV_BRDW = @IdIntvBrdw

	/* 5. Bestemmelingen ophalen */

	select BBBST.*, BBIND.NM_IND, BBIND.VNM_IND, BBIND.AD_EMAL_IND
	from BBBST
	join BBIND on BBIND.ID_IND = BBBST.ID_IND
	where ID_INTV_BRDW = @IdIntvBrdw