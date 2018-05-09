-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_Rapport_Brief_Verkeersovertreding]
	-- Add the parameters for the stored procedure here
	@RegistratieID			int	-- Registratie ID
AS
BEGIN
SET NOCOUNT ON;

	-- Haal de variabele Info
	-- ----------------------
	declare @taal as nvarchar(10);
	declare @naam as nvarchar(50);
	declare @adres as nvarchar(50);
	declare @postnr as nvarchar(10);
	declare @woonpl as nvarchar(50);
	declare @datum as datetime;
	declare @datumInbreuk as datetime;
	declare @rijverbodVan as datetime;
	declare @rijverbodtot as datetime;
	declare @snelheid as integer;
	declare @werknemer as nvarchar(100);
	declare @nrplaat as nvarchar(15);
	declare @max as integer;
	declare @recidive as integer;
	declare @sanctieId as integer;
	declare @sanctie as nvarchar(500);
	declare @inbreukklasseId as integer;
	declare @locatie as nvarchar(250);
	declare @geregistreerdeSnelheid as integer;
	declare @toegelatenSnelheid as integer;
	declare @typeInfraction as nvarchar(100);
	declare @infractionId as integer;

	select @taal = coalesce(dbo.bbinbrva.Language, 'NL'), 
		   @naam = dbo.bbfrm.nm_frm,
		   @adres = dbo.bbfrm.stra_frm,
		   @postnr = dbo.bbfrm.po_cod_pla_frm,
		   @woonpl = dbo.bbfrm.pla_frm,
		   @datum = dbo.bbbewreg.tms_inc,
		   @snelheid = dbo.bbinbrva.snl_reg,
		   @werknemer = rtrim(dbo.bbind.vnm_ind) + ' ' + dbo.bbind.nm_ind,
		   @nrplaat = dbo.bbtsp.pl_nr_tsp,
		   @max = dbo.bbinbrva.snl_ok,
		   @recidive = dbo.bbinbrva.Recidive,
		   @sanctieId = dbo.bbinbrva.SanctionId,
		   @inbreukklasseId  = dbo.BBINBRKlasse.InbreukKlasseID,
		   @rijverbodvan = dbo.bbinbrva.PBH_NOK_SNL_DT_VAN,
		   @rijverbodtot = dbo.bbinbrva.PBH_NOK_SNL_DT_Tot,
		   @locatie = dbo.BBBEWREG.PLA_INC,
		   @toegelatenSnelheid  = dbo.bbinbrva.SNL_OK, 
		   @geregistreerdeSnelheid = dbo.bbinbrva.SNL_REG,
		   @datumInbreuk = dbo.bbbewreg.TMS_INC,
		   @typeInfraction = dbo.bbinbrva.KindOfSanction,
		   @infractionId = dbo.BBINBRVA.ID_ART_INBR
	FROM       dbo.BBBEWREG INNER JOIN
                   dbo.BBINBRRG ON dbo.BBINBRRG.ID_REG = dbo.BBBEWREG.ID_REG INNER JOIN
                   dbo.BBINBRVA ON dbo.BBINBRVA.ID_REG = dbo.BBINBRRG.ID_REG INNER JOIN
                   dbo.BBIND ON dbo.BBIND.ID_IND = dbo.BBINBRRG.ID_INBR INNER JOIN
                   dbo.BBTSP ON dbo.BBTSP.ID_TSP = dbo.BBINBRRG.ID_TSP INNER JOIN
                   dbo.BBINBRAR ON dbo.BBINBRVA.ID_ART_INBR = dbo.BBINBRAR.ID_ART_INBR INNER JOIN
                   dbo.BBINBRKlasse ON dbo.BBINBRAR.InbreukKlasseID = dbo.BBINBRKlasse.InbreukKlasseID LEFT OUTER JOIN
                   dbo.BBFRM ON dbo.BBFRM.ID_FRM = dbo.BBINBRVA.IdFirm
	WHERE dbo.bbbewreg.id_reg = @RegistratieID;

	select @sanctie = CASE @taal
						WHEN 'FR' THEN SanctionFR
						WHEN 'EN' THEN SanctionEN
						WHEN 'DE' THEN SanctionDE
						ELSE SanctionNL
					  END
	FROM dbo.BBINBRSanction
	WHERE SanctionID = @sanctieId;

	-- Haal de vaste teksten in de gevraagde taal
	-- ------------------------------------------
	CREATE TABLE #tekst
	(
	id		INT PRIMARY KEY,
	value	NVARCHAR(250)
	)

	INSERT INTO #tekst (id, value)
	SELECT TranslationNr,
		   CASE @taal
			 WHEN 'FR' THEN ValueFR
			 WHEN 'EN' THEN ValueEN
			 WHEN 'DE' THEN ValueDE
			 ELSE ValueNL
		   END
	FROM dbo.BBTranslation;
		-- Haal de diverse inbreukklassen op
	-- ------------------------------------------
	CREATE TABLE #tekst2
	(
	id		INT PRIMARY KEY,
	value	NVARCHAR(250)
	)

	INSERT INTO #tekst2 (id, value)
	SELECT InbreukKlasseID,
		   CASE @taal
			 WHEN 'FR' THEN ValueFR
			 WHEN 'EN' THEN ValueEN
			 WHEN 'DE' THEN ValueDE
			 ELSE ValueNL
		   END
	FROM dbo.BBINBRKlasse;


	-- Haal de diverse inbreukklassen op
	-- ------------------------------------------
	CREATE TABLE #tekst3
	(
	id		INT PRIMARY KEY,
	value	NVARCHAR(250)
	)

	INSERT INTO #tekst3 (id, value)
	SELECT SanctionID,
		   CASE @taal
			 WHEN 'FR' THEN SanctionFR
			 WHEN 'EN' THEN SanctionEN
			 WHEN 'DE' THEN SanctionDE
			 ELSE SanctionNL
		   END
	FROM dbo.BBINBRSanction;
	
	-- Haal de overtreden artikelnummer op
	-- ------------------------------------------
	CREATE TABLE #tekst4
	(
	id		INT PRIMARY KEY,
	value	NVARCHAR(MAX)
	)

	INSERT INTO #tekst4 (id, value)
	SELECT ID_ART_INBR,
		   CASE @taal
			 WHEN 'FR' THEN SCF_ART_INBR_FR
			 WHEN 'EN' THEN SCF_ART_INBR_EN
			 WHEN 'DE' THEN SCF_ART_INBR_DE
			 ELSE SCF_ART_INBR
		   END
	FROM dbo.BBINBRAR;

	-- Delen van de brief
	-- ------------------
	SELECT (SELECT value FROM #tekst WHERE id = 1) as "titel",
		   (SELECT value FROM #tekst2 WHERE id = @sanctieId) as "SanctieOmschrijving",
		   (SELECT value FROM #tekst3 WHERE id = @inbreukklasseId) as "InbreukklasseValue",
			(SELECT value FROM #tekst4 WHERE id = @infractionId) as "InbreukArtikel", 
		   @naam as "naam",
		   @adres as "adres", 
		   @postnr as "postnr", 
		   @woonpl as "woonpl", 
		   @datum as "postdatum",
           @sanctie as "sanctieValue",
           @locatie as "locatieValue",
		   @datumInbreuk as "datumInbreukValue",
	       @rijverbodVan as "datumRijverbodVan",
		   @rijverbodtot as "datumRijverbodTot",
           @geregistreerdeSnelheid as "geregistreerdeSnelheidValue",
           @toegelatenSnelheid as "toegelatenSnelheidValue",
		   @typeInfraction as "aantalInbreuken",
		   (SELECT value FROM #tekst WHERE id = 2) as "ref1",
		   (SELECT value FROM #tekst WHERE id = 4) as "ref2",
		   (SELECT value FROM #tekst WHERE id = 3) as "betreft1",
		   (SELECT value FROM #tekst WHERE id = 5) as "betreft2",
		   (SELECT value FROM #tekst WHERE id = 6) as "aanspreking",
		   (SELECT value FROM #tekst WHERE id = 7) as "p1t1",
		   @datum as "p1t2", 
		   (SELECT value FROM #tekst WHERE id = 8) as "p1t3",
		   @snelheid as "p1t4", 
		   (SELECT value FROM #tekst WHERE id = 9) as "p1t5",
		   (SELECT value FROM #tekst WHERE id = 10) as "werknemer1",
		   @werknemer as "werknemer2",
		   (SELECT value FROM #tekst WHERE id = 11) as "nrplaat1",
		   @nrplaat as "nrplaat2",
		   (SELECT value FROM #tekst WHERE (id = 12 and @max = 50) OR (id = 13 and @max != 50)) as "p2",
		   (SELECT value FROM #tekst WHERE id = 14) as "type1",
		   (SELECT value FROM #tekst WHERE (id = 23 and @recidive = 1) OR (id = 24 and @recidive = 2) OR (id = 25 and @recidive != 1 and @recidive != 2)) as "type2", 
		   (SELECT value FROM #tekst WHERE id = 15) as "sanctie1",
		   @sanctie as "sanctie2",
		   (SELECT value FROM #tekst WHERE id = 16) as "hoogachtend",
		   (SELECT value FROM #tekst WHERE id = 17) as "opsteller1",
		   (SELECT value FROM #tekst WHERE id = 18) as "opsteller2",
		   (SELECT value FROM #tekst WHERE id = 19) as "bijlage",
		   (SELECT value FROM #tekst WHERE id = 20) as "adres1",
		   (SELECT value FROM #tekst WHERE id = 21) as "adres2",
		   (SELECT value FROM #tekst WHERE id = 22) as "btw",
		   (SELECT value FROM #tekst WHERE id = 26) as "Tijdstip",
		   (SELECT value FROM #tekst WHERE id = 28) as "klasse",
		   (SELECT value FROM #tekst WHERE id = 29) as "locatie",
		   (SELECT value FROM #tekst WHERE id = 30) as "Geregisteerde Snelheid",
		   (SELECT value FROM #tekst WHERE id = 31) as "Toegelaten Snelheid",
		   (SELECT value FROM #tekst WHERE id = 32) as "Rijverbod van",
		   (SELECT value FROM #tekst WHERE id = 33) as "RijverbodTot",
		   (SELECT value FROM #tekst WHERE id = 34) as "ArtikelNrTitel";
	DROP TABLE #tekst;
	DROP TABLE #tekst2;
	DROP TABLE #tekst3;
	DROP TABLE #tekst4;
END