-- =============================================
-- Author:		Geert Maertens
-- Create date: 2012-11-07
-- Description:	Basisquery voor afdruk brief ivm een snelheidsovertreding.
-- =============================================
CREATE PROCEDURE [dbo].[USP_Rapport_Brief_Snelheidsovertreding] 
	@id		int	-- Registratie ID
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
	declare @snelheid as integer;
	declare @werknemer as nvarchar(100);
	declare @nrplaat as nvarchar(15);
	declare @max as integer;
	declare @recidive as integer;
	declare @sanctieId as integer;
	declare @sanctie as nvarchar(500);

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
		   @sanctieId = dbo.bbinbrva.SanctionId
	FROM dbo.bbbewreg
	INNER JOIN dbo.bbinbrrg ON dbo.bbinbrrg.id_reg = dbo.bbbewreg.id_reg
	INNER JOIN dbo.bbinbrva ON dbo.bbinbrva.id_reg = dbo.bbinbrrg.id_reg
	INNER JOIN dbo.bbind ON dbo.bbind.id_ind = dbo.bbinbrrg.id_inbr
	INNER JOIN dbo.bbtsp ON dbo.bbtsp.id_tsp = dbo.bbinbrrg.id_tsp
	LEFT  JOIN dbo.bbfrm ON dbo.bbfrm.id_frm = dbo.bbinbrva.idFirm
	WHERE dbo.bbbewreg.id_reg = @id;

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

	-- Delen van de brief
	-- ------------------
	SELECT (SELECT value FROM #tekst WHERE id = 1) as "titel",
		   @naam as "naam",
		   @adres as "adres", 
		   @postnr as "postnr", 
		   @woonpl as "woonpl", 
		   @datum as "postdatum", 
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
		   (SELECT value FROM #tekst WHERE id = 22) as "btw";

	DROP TABLE #tekst;
END