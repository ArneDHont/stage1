
-- Doel: 	Ophalen maandoverzicht dagverslag
-- Auteur: DIEN - okt. 2006


CREATE PROCEDURE [dbo].[USP_BMA_GET_REPORT_MaandoverzichtDagverslag]
	(@jaar integer, @maand integer)

AS

SET NOCOUNT OFF;
/*
nr: 	0: algmeen (geen post)
	1: post 1
	2: post 2
	4: post 4
*/
declare @tableOmschrijving table (id_dg_po_dl int, scf_dg_po_dl varchar(50), vlg int, nr int)

-- Algemeen
insert into @tableOmschrijving (id_dg_po_dl, scf_dg_po_dl, vlg, nr)
select ID_DG_PO_DL, SCF_DG_PO_DL, VLG, 0
from bbdgpodl
where inv_po = 0

--Post 1,2 en 4
insert into @tableOmschrijving( id_dg_po_dl, scf_dg_po_dl, vlg, nr)
select ID_DG_PO_DL, SCF_DG_PO_DL + ' ,P.1', VLG, 1
from bbdgpodl
where inv_po = 1
insert into @tableOmschrijving( id_dg_po_dl, scf_dg_po_dl, vlg, nr)
select ID_DG_PO_DL, SCF_DG_PO_DL + ' ,P.2', VLG, 2
from bbdgpodl
where inv_po = 1
insert into @tableOmschrijving( id_dg_po_dl, scf_dg_po_dl, vlg, nr)
select ID_DG_PO_DL, SCF_DG_PO_DL + ' ,P.4', VLG, 4
from bbdgpodl
where inv_po = 1




select 
isnull(datepart(m, BBDGPO.TMS_REG_DG_PO) , @maand)as maand,
isnull(datepart(dd, BBDGPO.TMS_REG_DG_PO),1) as dag,
isnull(datepart(yyyy, BBDGPO.TMS_REG_DG_PO), @jaar) as jaar,
BBDGPO.TMS_REG_DG_PO,
isnull(case t.nr
 when 0 then BBDGPO.Q_PO_ALG
 when 1 then BBDGPO.Q_PO_1
 when 2 then BBDGPO.Q_PO_2
 when 4 then BBDGPO.Q_PO_4
end,0) as totaalTelling,
 t.scf_dg_po_dl,
 t.VLG 
from  @tableOmschrijving t
left outer join BBDGPO
on t.id_dg_po_dl = BBDGPO.id_dg_po_dl
and datepart(m, tms_reg_dg_po) = @maand
and datepart(yyyy, tms_reg_dg_po) = @jaar
order by  t.vlg asc

