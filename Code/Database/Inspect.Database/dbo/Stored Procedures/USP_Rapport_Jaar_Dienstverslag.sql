-- =============================================
-- Author:		Geert Maertens
-- Create date: 27 jan 2012
-- Description:	Voorbereiden van de data
--				voor het jaarrapport van de
--				dienstverslagen.
-- =============================================
CREATE PROCEDURE [dbo].[USP_Rapport_Jaar_Dienstverslag] 
	@jaar int
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @groepId	int;
	DECLARE @actieId	int;
	DECLARE @groep		nvarchar(80);
	DECLARE @actie		nvarchar(50);
	DECLARE @maand		int;
	DECLARE @minuten	int;

	CREATE TABLE #result
	(
	  groepId	int NOT NULL,
	  actieId	int NOT NULL,
	  groep		nvarchar(80),
	  actie		nvarchar(50),
	  jan		int NOT NULL DEFAULT 0,
	  feb		int NOT NULL DEFAULT 0,
	  mrt		int NOT NULL DEFAULT 0,
	  apr		int NOT NULL DEFAULT 0,
	  mei		int NOT NULL DEFAULT 0,
	  jun		int NOT NULL DEFAULT 0,
	  jul		int NOT NULL DEFAULT 0,
	  aug		int NOT NULL DEFAULT 0,
	  sep		int NOT NULL DEFAULT 0,
	  okt		int NOT NULL DEFAULT 0,
	  nov		int NOT NULL DEFAULT 0,
	  dec		int NOT NULL DEFAULT 0,
	  tot		int,
	  perc		float,
	  PRIMARY KEY(groepId, actieId)
	);

	-- Basic Query
	-- -----------
	DECLARE c CURSOR FORWARD_ONLY FOR
		SELECT g.ActieCodeGroepId, a.ActieCodeId, g.ActieCodeGroepOmschr, a.ActieOmschr, month(v.Datum) AS "Maand", sum(d.AantalUur) * 60 + sum(d.AantalMinuten) AS "Minuten"

		FROM dbo.bvActieGroep g
		INNER JOIN dbo.bvActie a ON a.ActieCodeGroepId = g.ActieCodeGroepId
		INNER JOIN dbo.bvDagVerslagActie d ON d.ActieCodeId = a.ActieCodeId
		INNER JOIN dbo.bvDagVerslag v ON v.DagVerslagId = d.DagVerslagId

		WHERE g.ActieCodeGroepId < 11
		  AND a.InDagVerslagYN = 1
		  AND year(v.Datum) = @jaar

		GROUP BY g.ActieCodeGroepId, a.ActieCodeId, g.ActieCodeGroepOmschr, a.ActieOmschr, month(v.Datum);

	OPEN c; 

	-- Collect the Results
	-- -------------------
	FETCH NEXT FROM c INTO @groepId, @actieId, @groep, @actie, @maand, @minuten;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF EXISTS( SELECT * FROM #result WHERE groepId = @groepId AND actieId = @actieId )
		BEGIN
			IF @maand = 1
				UPDATE #result SET jan = jan + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 2
				UPDATE #result SET feb = feb + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 3			
				UPDATE #result SET mrt = mrt + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 4			
				UPDATE #result SET apr = apr + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 5			
				UPDATE #result SET mei = mei + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 6			
				UPDATE #result SET jun = jun + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 7			
				UPDATE #result SET jul = jul + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 8			
				UPDATE #result SET aug = aug + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 9			
				UPDATE #result SET sep = sep + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 10			
				UPDATE #result SET okt = okt + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 11			
				UPDATE #result SET nov = nov + @minuten WHERE groepId = @groepId AND actieId = @actieId;
			ELSE IF @maand = 12			
				UPDATE #result SET dec = dec + @minuten WHERE groepId = @groepId AND actieId = @actieId;
		END
		ELSE
		BEGIN
			IF @maand = 1
				INSERT INTO #result (groepId, actieId, groep, actie, jan) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 2
				INSERT INTO #result (groepId, actieId, groep, actie, feb) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 3										
				INSERT INTO #result (groepId, actieId, groep, actie, mrt) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 4										
				INSERT INTO #result (groepId, actieId, groep, actie, apr) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 5										
				INSERT INTO #result (groepId, actieId, groep, actie, mei) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 6										
				INSERT INTO #result (groepId, actieId, groep, actie, jun) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 7										
				INSERT INTO #result (groepId, actieId, groep, actie, jul) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 8										
				INSERT INTO #result (groepId, actieId, groep, actie, aug) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 9										
				INSERT INTO #result (groepId, actieId, groep, actie, sep) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 10										
				INSERT INTO #result (groepId, actieId, groep, actie, okt) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 11										
				INSERT INTO #result (groepId, actieId, groep, actie, nov) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
			ELSE IF @maand = 12										
				INSERT INTO #result (groepId, actieId, groep, actie, dec) VALUES (@groepId, @actieId, @groep, @actie, @minuten);
		END;

		FETCH NEXT FROM c INTO @groepId, @actieId, @groep, @actie, @maand, @minuten;
	END;

	CLOSE c;
	DEALLOCATE c;

	-- Calculate the Year Totals
	-- -------------------------
	UPDATE #result
	SET	tot = jan + feb + mrt + apr + mei + jun + jul + aug + sep + okt + nov + dec;

	-- Calculate the Percentages on a Yearly Basis
	-- -------------------------------------------
	UPDATE #result
	SET perc = (tot * 1.0) / (SELECT sum(tot) FROM #result);

	-- And return the Result
	-- ---------------------
	SELECT groepId, actieId, groep, actie,
		   jan, feb, mrt, apr, mei, jun,
		   jul, aug, sep, okt, nov, dec, tot, perc
	FROM #result ORDER BY groepId, actieId;
	
	DROP TABLE #result;
END