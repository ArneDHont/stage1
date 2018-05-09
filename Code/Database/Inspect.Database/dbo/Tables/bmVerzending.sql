CREATE TABLE [dbo].[bmVerzending] (
    [VerzendingID]    INT      IDENTITY (1, 1) NOT NULL,
    [TypeMatID]       INT      NULL,
    [MateriaalVolgNr] INT      NULL,
    [LeverancierID]   INT      NULL,
    [DatumVerstuurd]  DATETIME NULL,
    [DatumTerug]      DATETIME NULL,
    [HerkeurdYN]      BIT      NULL,
    [Opmerking]       NTEXT    NULL
);

