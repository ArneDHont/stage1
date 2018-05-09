
-- Doel: Ophalen alle iondividutypes
-- Auteur: Rajiv Blancke - Koen Heye 03/05/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBTSP]

AS

SET NOCOUNT OFF;
	select BBTSP.*, BBTYTSP.SCF_TY_TSP, BBIND.NM_IND, BBIND.VNM_IND, BBFRM.*
	from BBTSP
	left join BBIND on BBTSP.ID_EIG_TSP = BBIND.ID_IND
	left join BBFRM on BBTSP.ID_FRM_TSP = BBFRM.ID_FRM
	left join BBTYTSP on BBTSP.ID_TY_TSP = BBTYTSP.ID_TY_TSP

