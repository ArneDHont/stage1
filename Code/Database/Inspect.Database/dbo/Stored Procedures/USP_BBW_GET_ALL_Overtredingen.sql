-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_Overtredingen]
	-- Add the parameters for the stored procedure here
	@Intern bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT	bbinbrrg.id_reg                 AS "RegistratieID", 
			bbind.nm_ind                    AS "Naam",
			bbind.vnm_ind                   AS "Voornaam", 
			bbind.id_ind                    AS "StamnrOvertreder",
			bbinbrindty.scf_inbr_ind_ty     AS "OvertrederType", 
			bbbewreg.tms_inc                AS "Tijdstip", 
			month(bbbewreg.tms_inc)         AS "Maand", 
			year(bbbewreg.tms_inc)          AS "Jaar", 
			bbbewreg.pla_inc                AS "Plaats", 
			bbinbrva.snl_ok                 AS "ToegelatenSnelheid", 
			bbinbrva.snl_reg                AS "GeregistreerdeSnelheid", 
			bbinbrar.nr_art_inbr            AS "Artnr", 
			bbinbrar.scf_art_inbr           AS "Artikel", 
			bbinbrty.scf_ty_inbr            AS "InbreukType", 
			bbbewreg.vlg_reg_jr_bpl         AS "Volgnr",
			bbinbrva.pbh_nok_snl_dt_van     AS "RijverbodVan",
			bbinbrva.pbh_nok_snl_dt_tot     AS "RijverbodTot",
			bbinbrva.pbh_dt_ovk             AS "AfspraakPBH",
			bbinbrva.pbh_tms_print          AS "AfdrukTijdstip",
			bbinbrva.sodie_cnt_id           AS "SoDieContactId",
			bbind.sap_dir, 
			bbind.sap_afd, 
			bbind.sap_sect,
			dbo.bbinbrva.DatePrintLetterExt AS "DatumBrief",
			dbo.bbinbrva.KindOfSanction     AS "SoortSanctie",
			dbo.bbinbrva.[Language]         AS "TaalBrief",
			dbo.bbfrm.nm_frm                AS "NaamFirma",
			dbo.BBINBRSanction.SanctionDescr AS "SanctieOmschrijving",
			dbo.BBINBRSanction.SanctionDuration As "SanctieDuur", 
            dbo.BBINBRSanction.SanctionPeriod As "SanctiePeriode", 
            dbo.BBINBRKlasse.InbreukKlasse As "Inbreukklasse" 

FROM				  dbo.BBINBRRG INNER JOIN
                      dbo.BBINBRVA ON bbinbrrg.id_reg = bbinbrva.id_reg INNER JOIN
                      dbo.BBINBRAR ON bbinbrva.id_art_inbr = bbinbrar.id_art_inbr INNER JOIN
                      dbo.BBINBRTY ON bbinbrar.id_ty_inbr = bbinbrty.id_ty_inbr INNER JOIN
                      dbo.BBBEWREG ON bbinbrrg.id_reg = bbbewreg.id_reg INNER JOIN
                      dbo.BBIND ON bbinbrrg.id_inbr = bbind.id_ind INNER JOIN
                      dbo.BBINBRKlasse ON dbo.BBINBRAR.InbreukKlasseID = dbo.BBINBRKlasse.InbreukKlasseID LEFT OUTER JOIN
                      dbo.BBINBRSanction ON dbo.BBINBRVA.SanctionID = dbo.BBINBRSanction.SanctionID LEFT OUTER JOIN
                      dbo.BBFRM ON bbinbrva.idfirm = bbfrm.id_frm LEFT OUTER JOIN
                      dbo.BBINBRINDTY ON bbinbrrg.id_inbr_ind_ty = bbinbrindty.id_inbr_ind_ty
WHERE ((@Intern = 1 AND bbinbrindty.scf_inbr_ind_ty Like '%Arcelor Gent%') OR
	   (@Intern != 1 AND bbinbrindty.scf_inbr_ind_ty Not Like '%Arcelor Gent%'))
ORDER By bbind.id_ind    DESC


END