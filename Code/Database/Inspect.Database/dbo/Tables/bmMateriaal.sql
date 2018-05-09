CREATE TABLE [dbo].[bmMateriaal] (
    [TypeMatID]                   INT            NOT NULL,
    [MateriaalVolgNr]             INT            NOT NULL,
    [LocatieID]                   INT            NULL,
    [LocatieNr]                   NVARCHAR (5)   NULL,
    [LocatieNrOrderBy]            INT            CONSTRAINT [DF_bmMateriaal_LocatieNrOrderBy] DEFAULT ((0)) NULL,
    [LocatieOmschr]               NVARCHAR (150) NULL,
    [VisueleControleFreq]         SMALLINT       NULL,
    [BeheerderID]                 NVARCHAR (4)   NULL,
    [SoortTypeMatID]              INT            NULL,
    [LeverancierID]               INT            NULL,
    [FabricatieNr]                NVARCHAR (20)  NULL,
    [LeveringsDatum]              DATETIME       NULL,
    [DatumLaatsteKeuring]         DATETIME       NULL,
    [DatumVisueleKeuring]         DATETIME       NULL,
    [GewichtVisueleKeuring]       FLOAT (53)     NULL,
    [DatumPoederControle]         DATETIME       NULL,
    [DatumVolgendePoederControle] DATETIME       NULL,
    [DatumHervullingNaGebruik]    DATETIME       NULL,
    [HervullingGemeld]            TINYINT        NULL,
    [DatumHerkeuringLeverancier]  DATETIME       NULL,
    [VervangenDoor]               INT            NULL,
    [Opmerking]                   NTEXT          NULL,
    [GecontroleerdYN]             BIT            NULL,
    [GecontroleerdPoederYN]       BIT            NULL,
    [BeheerderAfdelingID]         INT            NULL,
    [VolgnummerAfdeling]          INT            NULL,
    [StatusId]                    INT            NULL,
    [StatusTmsChange]             DATETIME       NULL,
    [DateDeleted]                 DATETIME       NULL,
    [UserDeleted]                 NVARCHAR (100) NULL,
	[EquipmentId]  AS ([db_inspect].[GetEquipmentId]([TypeMatID],[MateriaalVolgNr])) PERSISTED,
    CONSTRAINT [PK_bmMateriaal] PRIMARY KEY CLUSTERED ([TypeMatID] ASC, [MateriaalVolgNr] ASC),
	CONSTRAINT [AK_bmMateriaal_EquipmentId] UNIQUE NONCLUSTERED ([EquipmentId] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Gemeten gewicht bij de laatste visuele keuring', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmMateriaal', @level2type = N'COLUMN', @level2name = N'GewichtVisueleKeuring';


GO

CREATE INDEX [IX_bmMateriaal_EquipmentId] ON [dbo].[bmMateriaal] ([EquipmentId])
GO

CREATE INDEX [IX_bmMateriaal_LocatieID] ON [dbo].[bmMateriaal] ([LocatieID]) INCLUDE ([LocatieNrOrderBy],[EquipmentId])
GO