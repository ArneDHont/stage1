
CREATE PROCEDURE [dbo].[USP_BBW_GET_BBBEWREG_MAX_VALUES] (
 @tmsRegistratie datetime,
 @id_reg int out,
 @volgnr_reg_jaar int out
)
AS

/* ophalen hoogste id, var primary key */
select @id_reg = max(ID_REG) 
from BBBEWREG

if @id_reg is null 
	set @id_reg = 1
else
	set @id_reg = @id_reg + 1


/* ophalen maximum volgnummer van een registratie in 1 jaar */
select @volgnr_reg_jaar = max(VLG_REG_JR_BPL)
from BBBEWREG
where  year(TMS_INC) = year(@tmsRegistratie)
--where  year(TMS_OPS_REG) = year(@tmsRegistratie) - naco 09/01/2017 - gaf iedere keer problemen bij een jaarovergang indien een verslag van het vorige jaar werd opgemaakt

/* als het volgnummer van een registratie in een jaar null is, waarde op 0 zetten */
if @volgnr_reg_jaar is null
	set @volgnr_reg_jaar = 1
else
	set @volgnr_reg_jaar = @volgnr_reg_jaar + 1

