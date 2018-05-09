
-- Doel: Ophalen alle aarden van een interventie voor brandweer
-- Auteur: Rajiv Blancke - Koen Heye 31/03/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBRTY]
@IntvType int

AS

SET NOCOUNT OFF;
if @IntvType is not null
begin
	select *
	from BBBRTY
	where BBBRTY.ID_TY_INTV = @IntvType
	order by SCF_BR_TY_INTV
end
else
begin
	select *
	from BBBRTY
	order by SCF_BR_TY_INTV
end

