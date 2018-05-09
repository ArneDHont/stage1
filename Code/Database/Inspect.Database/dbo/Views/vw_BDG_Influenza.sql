CREATE VIEW [dbo].[vw_BDG_Influenza]
AS
SELECT     dbo.BBAFD.KRT_AFD AS Afd, dbo.BBINTVBR.VLG_TY_INTV_JR AS Volgnr, dbo.BBINTVTY.SCF_TY_INTV AS TypeInterventie, 
                      dbo.BBINTVBR.TMS_INTV AS Tijdstip, dbo.BBINTVBR.PLA_INTV AS Plaats, dbo.BBBRTY.SCF_BR_TY_INTV AS Type, 
                      dbo.BBBRRD.SCF_BR_RD_INTV AS Oorzaak, dbo.BBINTVBR.IND_OPR_DR AS OpgeroepenDoor, 
                      '"' + REPLACE(REPLACE(dbo.BBINTVBR.SCF_LNG_INTV, CHAR(10), ' '), CHAR(13), '') + '"' AS Omschrijving
FROM         dbo.BBINTVBR LEFT OUTER JOIN
                      dbo.BBINTVTY ON dbo.BBINTVBR.ID_TY_INTV = dbo.BBINTVTY.ID_TY_INTV LEFT OUTER JOIN
                      dbo.BBBRTY ON dbo.BBINTVBR.ID_BR_TY_INTV = dbo.BBBRTY.ID_BR_TY_INTV LEFT OUTER JOIN
                      dbo.BBBRRD ON dbo.BBINTVBR.ID_BR_RD_INTV = dbo.BBBRRD.ID_BR_RD_INTV LEFT OUTER JOIN
                      dbo.BBAFD ON dbo.BBINTVBR.ID_AFD = dbo.BBAFD.ID_AFD
WHERE     (dbo.BBINTVTY.ID_TY_INTV = 3) AND (dbo.BBBRTY.ID_BR_TY_INTV = 35)


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "BBINTVBR (dbo)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BBINTVTY (dbo)"
            Begin Extent = 
               Top = 6
               Left = 265
               Bottom = 91
               Right = 417
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BBBRTY (dbo)"
            Begin Extent = 
               Top = 6
               Left = 455
               Bottom = 121
               Right = 621
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BBBRRD (dbo)"
            Begin Extent = 
               Top = 96
               Left = 265
               Bottom = 211
               Right = 433
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BBAFD (dbo)"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 226
               Right = 190
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
      Begin ColumnWidths = 10
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_BDG_Influenza';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   Column = 1440
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_BDG_Influenza';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_BDG_Influenza';

