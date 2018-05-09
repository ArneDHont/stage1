
-- Doel: Ophalen alle iondividutypes
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBIND]

AS

SET NOCOUNT OFF;

	select BBIND.* , BBINDTY.SCF_TY_IND
	from BBIND
	left join BBINDTY on BBIND.ID_TY_IND = BBINDTY.ID_TY_IND

