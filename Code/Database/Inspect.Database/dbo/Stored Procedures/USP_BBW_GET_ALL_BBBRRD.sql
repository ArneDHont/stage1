
-- Doel: Ophalen alle oorzaken van een interventie voor brandweer
-- Auteur: Rajiv Blancke - Koen Heye 31/03/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBRRD]
@IntvType int

AS

SET NOCOUNT OFF;
if @IntvType is not null
begin
	select *
	 from BBBRRD
	where BBBRRD.ID_TY_INTV = @IntvType
	order by SCF_BR_RD_INTV
end
else
begin
	select *
	 from BBBRRD
	order by SCF_BR_RD_INTV
end

