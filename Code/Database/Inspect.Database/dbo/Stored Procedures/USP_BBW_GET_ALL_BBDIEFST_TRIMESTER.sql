﻿CREATE   PROCEDURE [dbo].[USP_BBW_GET_ALL_BBDIEFST_TRIMESTER]

AS

SET NOCOUNT OFF;		
	
	SELECT     YEAR(dbo.BBBEWREG.TMS_OPS_REG) AS JR_REG, (DATEPART(quarter, dbo.BBBEWREG.TMS_INC)) as Trimester ,dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.VLG_REG_JR_BPL, dbo.BBBEWREG.TMS_INC, 
	                    dbo.BBBEWREG.PLA_INC, dbo.BBBEWREG.SCF_REG, dbo.BBDIEFST.STA_MAT, dbo.BBDIEFST.WD_MAT, dbo.BBDIEFST.SCF_LNG_DIEF, 
	                    dbo.BBDIEFST.SCF_MAT_STLN, dbo.BBBEWREG.DT_VZ_RAP_NW, dbo.BBBEWREG.DT_OK, dbo.BBBEWREG.DT_VZ_BST,
						dbo.BBDIEFST.PolitieGevraagdDoorAfdYN, dbo.BBDIEFST.PolitieLangsgeweestYN, dbo.BBDIEFST.PolitiePVnummer
	FROM         dbo.BBBEWREG RIGHT OUTER JOIN
	                    dbo.BBDIEFST ON dbo.BBBEWREG.ID_REG = dbo.BBDIEFST.ID_REG
	WHERE	dbo.BBBEWREG.DateInvalid IS NULL
	ORDER BY dbo.BBBEWREG.TMS_INC
