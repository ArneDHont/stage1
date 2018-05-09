CREATE VIEW [dbo].[vwBrMateriaal]
AS
SELECT     dbo.bmMateriaal.TypeMatID, dbo.bmMateriaal.MateriaalVolgNr, dbo.bmTypeMateriaal.TypeMatOmschr, 
                      dbo.bmBrandblusCode.BrandblusCodeOmschr, dbo.bmMateriaal.FabricatieNr, dbo.bmAfdeling.AfdelingCode, dbo.bmLocatie.LocatieZone, 
                      dbo.bmMateriaal.LocatieNr, dbo.bmMateriaal.LocatieOmschr, dbo.bmLeverancier.NaamLeverancier, 
                      dbo.bmAfdelingBeheerder.BeheerderAfdelingNaam, dbo.bmMateriaal.LeveringsDatum, dbo.bmMateriaal.VisueleControleFreq, 
                      dbo.bmMateriaal.DatumVisueleKeuring, dbo.bmMateriaal.GewichtVisueleKeuring
FROM         dbo.bmAfdeling RIGHT OUTER JOIN
                      dbo.bmLocatie ON dbo.bmAfdeling.AfdelingID = dbo.bmLocatie.AfdelingID RIGHT OUTER JOIN
                      dbo.bmMateriaal ON dbo.bmLocatie.LocatieID = dbo.bmMateriaal.LocatieID LEFT OUTER JOIN
                      dbo.bmTypeMateriaal ON dbo.bmMateriaal.TypeMatID = dbo.bmTypeMateriaal.TypeMatID LEFT OUTER JOIN
                      dbo.bmLeverancier ON dbo.bmMateriaal.LeverancierID = dbo.bmLeverancier.LeverancierID LEFT OUTER JOIN
                      dbo.bmAfdelingBeheerder ON dbo.bmMateriaal.BeheerderAfdelingID = dbo.bmAfdelingBeheerder.BeheerderAfdelingID LEFT OUTER JOIN
                      dbo.bmSoortTypeMateriaal ON dbo.bmMateriaal.SoortTypeMatID = dbo.bmSoortTypeMateriaal.SoortTypeMatID LEFT OUTER JOIN
                      dbo.bmBrandblusCode ON dbo.bmSoortTypeMateriaal.BrandblusCodeID = dbo.bmBrandblusCode.BrandblusCodeID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[44] 4[19] 2[19] 3) )"
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
         Begin Table = "bmAfdeling (dbo)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 106
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmLocatie (dbo)"
            Begin Extent = 
               Top = 5
               Left = 284
               Bottom = 105
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmMateriaal (dbo)"
            Begin Extent = 
               Top = 7
               Left = 555
               Bottom = 346
               Right = 786
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmTypeMateriaal (dbo)"
            Begin Extent = 
               Top = 8
               Left = 862
               Bottom = 108
               Right = 1034
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmLeverancier (dbo)"
            Begin Extent = 
               Top = 241
               Left = 272
               Bottom = 326
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmAfdelingBeheerder (dbo)"
            Begin Extent = 
               Top = 239
               Left = 839
               Bottom = 339
               Right = 1036
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmSoortTypeMateriaal (dbo)"
            Begin Extent = 
               Top = 109
               Left = 274
               ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwBrMateriaal';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Bottom = 224
               Right = 459
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bmBrandblusCode (dbo)"
            Begin Extent = 
               Top = 116
               Left = 20
               Bottom = 216
               Right = 209
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
      Begin ColumnWidths = 14
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
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1845
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwBrMateriaal';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwBrMateriaal';

