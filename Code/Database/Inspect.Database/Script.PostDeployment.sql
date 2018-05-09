


-- BBW Personnel
:r .\Scripts\dbo.BBINDTY.sql
:r .\Scripts\dbo.BBINDGSL.sql
:r .\Scripts\dbo.BBBWPLG.sql
:r .\Scripts\dbo.BBIND.sql
:r .\Scripts\dbo.BBBWPERS.sql

-- BBW Equipment
:r .\Scripts\dbo.bmAfdeling.sql
:r .\Scripts\dbo.bmBrandblusCode.sql
:r .\Scripts\dbo.bmTypeMateriaal.sql
:r .\Scripts\dbo.bmSoortTypeMateriaal.sql
:r .\Scripts\dbo.bmLeverancier.sql
:r .\Scripts\dbo.bmLocatie.sql
:r .\Scripts\dbo.bmMateriaal.sql



-- [db_inspect].[EquipmentTypeExtensions]
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (1, N'BLA')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (2, N'BRK')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (3, N'BCK')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (4, N'AXH')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (5, N'BGH')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (6, N'FTS')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (7, N'VCN')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (8, N'DSL')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (9, N'DFN')
INSERT INTO [db_inspect].[EquipmentTypeExtensions]([EquipmentTypeId], [Trigram]) VALUES (10, N'DFC')

--BBW EquipmentIdentification
:r .\Scripts\db_inspect.EquipmentIdentification.sql



-- [db_inspect].[FeedBackType]
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (1,N'Toestel niet gelood')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (2,N'Toestel handvat kapot')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (3,N'Toestel slang kapot of beschadigd')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (4,N'Toestel borgklem ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (5,N'Toestel roest')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (6,N'Haak af')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (7,N'Nummerbordje ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (8,N'Deksel geel/wit kapot of beschadigd')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (9,N'Rubberen sluiting kast kapot of verdwenen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (10,N'Reserve toestel aanwezig')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (11,N'Toestel niet genummerd')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (12,N'Nummer op toestel moeilijk of niet leesbaar')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (13,N'Toestel verdwenen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (14,N'Toestel moeilijk of niet bereikbaar')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (15,N'Aanduiding ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (16,N'Toestel te vervangen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (17,N'Toestel niet gereinigd')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (18,N'TAG onleesbaar/verdwenen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (19,N'Kast niet gelood')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (20,N'Slang 45/70 ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (21,N'Lans 45 ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (22,N'Kast niet te openen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (23,N'Kast of kraan moeilijk of niet bereikbaar')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (24,N'Kast of kraan niet te vinden')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (25,N'Kraan niet te openen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (26,N'Kraan kapot')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (27,N'Dichting 45/70 ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (28,N'Aansluiting 45/70 defect')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (29,N'Nummerbordje ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (30,N'Aanduiding ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (31,N'Kast te vervangen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (32,N'TAG onleesbaar/verdwenen')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (33,N'andere...')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (34,N'nummerbordje ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (35,N'aanduiding ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (36,N'afsluiter defect')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (37,N'spuitkop defect')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (38,N'slang kapot of lek')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (39,N'geen water')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (40,N'beschermkast beschadigd')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (41,N'nummerbordje ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (42,N'kast kapot')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (43,N'deken ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (44,N'brandcard ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (45,N'nummerbordje ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (46,N'aanduiding ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (47,N'koppeling kapot')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (48,N'dichting ontbreekt')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (49,N'kraan kapot')
INSERT INTO [db_inspect].[FeedBackType]([FeedbackTypeId],[Description]) VALUES (50,N'leiding roest of in slechte staat')





-- [EquipmentTypeFeedbackLink]
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,1)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,2)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,3)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,4)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,5)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,6)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,7)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,8)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,9)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,10)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,11)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,12)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,13)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,14)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,15)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,16)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,17)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (1,18)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,19)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,20)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,21)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,22)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,23)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,24)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,25)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,26)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,27)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,28)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,29)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,30)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,31)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (2,32)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,34)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,35)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,36)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,37)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,38)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,39)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (4,40)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (3,41)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (3,42)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (3,43)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (3,44)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (8,45)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (8,46)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (8,47)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (8,48)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (8,49)
INSERT INTO [db_inspect].[EquipmentTypeFeedbackLink]([EquipmentTypeId],[FeedbackTypeId]) VALUES (8,50)





-- [db_inspect].[OrganisationUnitExtensions]
--SET IDENTITY_INSERT [db_inspect].[OrganisationUnitExtensions] ON
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (1)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (3)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (5)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (6)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (7)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (9)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (12)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (13)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (14)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (16)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (17)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (19)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (20)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (21)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (24)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (27)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (28)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (35)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (46)
INSERT INTO [db_inspect].[OrganisationUnitExtensions]([OrganisationUnitId]) VALUES (56)
--SET IDENTITY_INSERT [db_inspect].[FeedBackType] OFF