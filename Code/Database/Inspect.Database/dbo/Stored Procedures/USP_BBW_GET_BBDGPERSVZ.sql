
-- Doel: Ophalen dagverslag verstuurd
-- Auteur: Dien - jan. 2007

CREATE   PROCEDURE [dbo].[USP_BBW_GET_BBDGPERSVZ]
  @DT_VZ datetime
AS

SET DATEFORMAT DMY
		select *
		from BBDGPERSVZ
		where DT_VZ = @DT_VZ

