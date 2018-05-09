-- Doel: Ophalen alle inbreukartikelen of enkel deze van een bepaalde inbreuktype (bewaking)
-- Auteur: Rajiv Blancke - Koen Heye 04/04/2006
--Inbreuktype heeft 4 mogelijke waarden:
--	- 0 ==> alles ophalen
--	- overige zijn 1, 2 en 3; afhankelijk van de types die in tabel BBINBRTY zitten

CREATE PROCEDURE [dbo].[USP_BBW_GET_BBINBRAR]
@InbrType int

AS

SET NOCOUNT OFF;
	if @InbrType = 0
SELECT     TOP (100) PERCENT dbo.BBINBRAR.ID_ART_INBR, dbo.BBINBRAR.ID_TY_INBR, dbo.BBINBRAR.NR_ART_INBR, dbo.BBINBRAR.SCF_ART_INBR, 
                      dbo.BBINBRAR.InbreukKlasseID, dbo.BBINBRAR.SCF_ART_INBR_FR, dbo.BBINBRAR.SCF_ART_INBR_EN, dbo.BBINBRAR.SCF_ART_INBR_DE, 
                      dbo.BBINBRTY.SCF_TY_INBR, dbo.BBINBRKlasse.InbreukKlasse AS SCF_CLS_INBR
FROM         dbo.BBINBRAR INNER JOIN
                      dbo.BBINBRTY ON dbo.BBINBRAR.ID_TY_INBR = dbo.BBINBRTY.ID_TY_INBR INNER JOIN
                      dbo.BBINBRKlasse ON dbo.BBINBRAR.InbreukKlasseID = dbo.BBINBRKlasse.InbreukKlasseID
ORDER BY dbo.BBINBRAR.NR_ART_INBR
	else
		select BBINBRAR.*, BBINBRTY.SCF_TY_INBR
		from BBINBRAR
		join BBINBRTY on BBINBRAR.ID_TY_INBR = BBINBRTY.ID_TY_INBR
		where BBINBRAR.ID_TY_INBR = @InbrType
		order by NR_ART_INBR