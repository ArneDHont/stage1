
CREATE PROCEDURE [dbo].[USP_BBW_GET_BBINTVBR_MAX_VALUES] (
 @ID_TY_INTV int,
 @jaarIntv datetime,
 @ID_Afd int,
 @id_intv int out,
 @aantalIntvJaar int out,
 @aantalIntvAfd int out

)
AS

/* ophalen hoogste id, var primary key */
select @id_intv = max(ID_INTV_BRDW) + 1
from BBINTVBR

/* ophalen aantal interventies van een gekozen type per jaar */
select @aantalIntvJaar = max(VLG_TY_INTV_JR)
from BBINTVBR
where ID_TY_INTV = @ID_TY_INTV and year(TMS_INTV) = @jaarIntv

/* ophalen aantal interventies van een gekozen type per afdeling/jaar */
select @aantalIntvAfd = max(VLG_TY_INTV_AFD)
from BBINTVBR
where ID_AFD = @ID_AFD and ID_TY_INTV = @ID_TY_INTV and year(TMS_INTV) =@jaarIntv

/* aantal Interventies per Jaar is null, waarde op 0 zetten */
if @aantalIntvJaar is null
	set @aantalIntvJaar = 1
else
	set @aantalIntvJaar = @aantalIntvJaar + 1

/* aantal Interventies per Afd/Jaar is null, waarde op 0 zetten */
if @aantalIntvAfd is null
	set @aantalIntvAfd = 1
else

	set @aantalIntvAfd = @aantalIntvAfd + 1

