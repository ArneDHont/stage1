


CREATE VIEW [dbo].[VW_CHIP_KLACHTEN]
AS
SELECT        dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.TMS_OPS_REG, dbo.BBBEWREG.TMS_INC, dbo.BBREGTY.SCF_TY_REG AS TYPE_REG, dbo.BBBEWREG.PLA_INC, 
                         dbo.BBBEWREG.SCF_REG, dbo.BBBEWREG.SAP_SUPPLIER_ID, dbo.BBBEWREG.DT_CHIP, dbo.BBBEWREG.OPM_CHIP, '-' AS ID_IND, '-' AS NM_IND, 
                         '-' AS VNM_IND, dbo.BBSCAD.TY_SCAD AS ExtraInfoBBW1, dbo.BBSCAD.RD_SCAD AS ExtraInfoBBW2, dbo.BBBEWREG.CHIPReadTms AS tmsCHIPgelezen 
FROM            dbo.BBBEWREG INNER JOIN
                         dbo.BBREGTY ON dbo.BBBEWREG.ID_TY_REG = dbo.BBREGTY.ID_TY_REG INNER JOIN
                         dbo.BBSCAD ON dbo.BBBEWREG.ID_REG = dbo.BBSCAD.ID_REG
WHERE        (dbo.BBBEWREG.CHIP_YN = 1) AND dbo.BBBEWREG.ID_TY_REG IN (5)
UNION
SELECT        dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.TMS_OPS_REG, dbo.BBBEWREG.TMS_INC, dbo.BBREGTY.SCF_TY_REG AS TYPE_REG, dbo.BBBEWREG.PLA_INC, 
                         dbo.BBBEWREG.SCF_REG, dbo.BBBEWREG.SAP_SUPPLIER_ID, dbo.BBBEWREG.DT_CHIP, dbo.BBBEWREG.OPM_CHIP, '-' AS ID_IND, '-' AS NM_IND, 
                         '-' AS VNM_IND, dbo.BBREGVSH.SCF_KRT_REG_VSH AS ExtraInfoBBW1, LEFT(dbo.BBREGVSH.SCF_LNG_REG_VSH, 3000) AS ExtraInfoBBW2, dbo.BBBEWREG.CHIPReadTms AS tmsCHIPgelezen 
FROM            dbo.BBBEWREG INNER JOIN
                         dbo.BBREGTY ON dbo.BBBEWREG.ID_TY_REG = dbo.BBREGTY.ID_TY_REG INNER JOIN
                         dbo.BBREGVSH ON dbo.BBBEWREG.ID_REG = dbo.BBREGVSH.ID_REG
WHERE        (dbo.BBBEWREG.CHIP_YN = 1) AND dbo.BBBEWREG.ID_TY_REG IN (7, 9)
UNION
SELECT        dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.TMS_OPS_REG, dbo.BBBEWREG.TMS_INC, dbo.BBREGTY.SCF_TY_REG AS TYPE_REG, dbo.BBBEWREG.PLA_INC, 
                         dbo.BBBEWREG.SCF_REG, dbo.BBBEWREG.SAP_SUPPLIER_ID, dbo.BBBEWREG.DT_CHIP, dbo.BBBEWREG.OPM_CHIP, 
                         dbo.BBKEUTSP.ID_STUR_TSP_KEU AS ID_IND, dbo.BBIND.NM_IND AS NM_IND, dbo.BBIND.VNM_IND AS VNM_IND, '-' AS ExtraInfoBBW1, 
                         '-' AS ExtraInfoBBW2, dbo.BBBEWREG.CHIPReadTms AS tmsCHIPgelezen  
FROM            dbo.BBIND RIGHT OUTER JOIN
                         dbo.BBKEUTSP ON dbo.BBIND.ID_IND = dbo.BBKEUTSP.ID_STUR_TSP_KEU RIGHT OUTER JOIN
                         dbo.BBBEWREG INNER JOIN
                         dbo.BBREGTY ON dbo.BBBEWREG.ID_TY_REG = dbo.BBREGTY.ID_TY_REG ON dbo.BBKEUTSP.ID_REG = dbo.BBBEWREG.ID_REG
WHERE        (dbo.BBBEWREG.CHIP_YN = 1) AND dbo.BBREGTY.ID_TY_REG = 2
UNION
SELECT        dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.TMS_OPS_REG, dbo.BBBEWREG.TMS_INC, dbo.BBREGTY.SCF_TY_REG AS TYPE_REG, dbo.BBBEWREG.PLA_INC, 
                         dbo.BBBEWREG.SCF_REG, dbo.BBBEWREG.SAP_SUPPLIER_ID, dbo.BBBEWREG.DT_CHIP, dbo.BBBEWREG.OPM_CHIP, dbo.BBINBRRG.ID_INBR AS ID_IND, 
                         dbo.BBIND.NM_IND AS NM_IND, dbo.BBIND.VNM_IND AS VNM_IND, dbo.BBINBRRG.VKLR_INBR AS ExtraInfoBBW1, 
                         dbo.BBINBRRG.OPM_EX_INBR_VSF AS ExtraInfoBBW2, dbo.BBBEWREG.CHIPReadTms AS tmsCHIPgelezen 
FROM            dbo.BBIND RIGHT OUTER JOIN
                         dbo.BBINBRRG ON dbo.BBIND.ID_IND = dbo.BBINBRRG.ID_INBR RIGHT OUTER JOIN
                         dbo.BBBEWREG INNER JOIN
                         dbo.BBREGTY ON dbo.BBBEWREG.ID_TY_REG = dbo.BBREGTY.ID_TY_REG ON dbo.BBINBRRG.ID_REG = dbo.BBBEWREG.ID_REG
WHERE        (dbo.BBBEWREG.CHIP_YN = 1) AND (dbo.BBREGTY.ID_TY_REG = 4)
UNION
SELECT        dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.TMS_OPS_REG, dbo.BBBEWREG.TMS_INC, dbo.BBREGTY.SCF_TY_REG AS TYPE_REG, dbo.BBBEWREG.PLA_INC, 
                         dbo.BBBEWREG.SCF_REG, dbo.BBBEWREG.SAP_SUPPLIER_ID, dbo.BBBEWREG.DT_CHIP, dbo.BBBEWREG.OPM_CHIP, dbo.BBALCTST.ID_BTRK, 
                         dbo.BBIND.NM_IND, dbo.BBIND.VNM_IND, '-' AS ExtraInfoBBW1, '-' AS ExtraInfoBBW2, dbo.BBBEWREG.CHIPReadTms AS tmsCHIPgelezen 
FROM            dbo.BBBEWREG INNER JOIN
                         dbo.BBREGTY ON dbo.BBBEWREG.ID_TY_REG = dbo.BBREGTY.ID_TY_REG LEFT OUTER JOIN
                         dbo.BBALCTST ON dbo.BBBEWREG.ID_REG = dbo.BBALCTST.ID_REG LEFT OUTER JOIN
                         dbo.BBIND ON dbo.BBALCTST.ID_BTRK = dbo.BBIND.ID_IND
WHERE        (dbo.BBBEWREG.CHIP_YN = 1) AND (dbo.BBREGTY.ID_TY_REG = 8)



GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[33] 2[7] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BBBEWREG (dbo)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VW_CHIP_KLACHTEN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VW_CHIP_KLACHTEN';

