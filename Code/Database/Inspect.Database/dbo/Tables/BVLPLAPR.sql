CREATE TABLE [dbo].[BVLPLAPR] (
    [ID_PLA]  CHAR (50) NOT NULL,
    [ID_PRFL] CHAR (50) NOT NULL,
    [ID_TOEP] CHAR (50) NOT NULL,
    CONSTRAINT [BVLPLAPR_PK] PRIMARY KEY CLUSTERED ([ID_PLA] ASC, [ID_PRFL] ASC, [ID_TOEP] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BVLPLA_BVLPLAPR_FK1] FOREIGN KEY ([ID_PLA]) REFERENCES [dbo].[BVLPLA] ([ID_PLA]),
    CONSTRAINT [BVLPRFL_BVLPLAPR_FK1] FOREIGN KEY ([ID_TOEP], [ID_PRFL]) REFERENCES [dbo].[BVLPRFL] ([ID_TOEP], [ID_PRFL])
);


GO
CREATE NONCLUSTERED INDEX [I_BVLPLAPR_01]
    ON [dbo].[BVLPLAPR]([ID_TOEP] ASC, [ID_PRFL] ASC) WITH (FILLFACTOR = 70);


GO
/* Create table level triggers for table BVLPLAPR.                                            */

/* Create triggers to enforce referential integrity.                                          */



Create trigger [dbo].[BVLPLAPRinsert] on [dbo].[BVLPLAPR] 

for insert 

as

/* Microsoft Visual Studio generated code. */

BEGIN

  declare

	@rowsAffected int,

	@nullRows int,

	@validRows int, 

	@errorNumber int,

	@errorMsg varchar(255)



  select @rowsAffected = @@rowcount



  /* Clause for ON INSERT to referencing table : NO ACTION. */

  if update("ID_TOEP") or

     update("ID_PRFL")

    begin

      select @nullRows = 0



      select @validRows = count(*)

      from inserted, "BVLPRFL"

      where inserted."ID_TOEP" = "BVLPRFL"."ID_TOEP" and

          inserted."ID_PRFL" = "BVLPRFL"."ID_PRFL"



      if @validRows != @rowsAffected

        begin

          select @errorNumber = 30001,

                 @errorMsg = 'Cannot insert/update into table "BVLPLAPR" because the values entered for "ID_TOEP", "ID_PRFL" in "BVLPLAPR" must correspond to the values of primary key column(s) of the table "BVLPRFL"'

          goto errorHandler

        end

    end



  return

  errorHandler:

    raiserror (@errorNumber, -1, -1, @errorMsg)

  rollback transaction

END
GO
Create trigger [dbo].[BVLPLAPRupdate] on [dbo].[BVLPLAPR] 

for update 

as

/* Microsoft Visual Studio generated code. */

BEGIN

  declare

	@rowsAffected int,

	@nullRows int,

	@validRows int, 

	@errorNumber int,

	@errorMsg varchar(255)



  select @rowsAffected = @@rowcount



  /* Clause for ON UPDATE to referencing table : NO ACTION. */

  if update("ID_TOEP") or

     update("ID_PRFL")

    begin

      select @nullRows = 0



      select @validRows = count(*)

      from inserted, "BVLPRFL"

      where inserted."ID_TOEP" = "BVLPRFL"."ID_TOEP" and

          inserted."ID_PRFL" = "BVLPRFL"."ID_PRFL"



      if @validRows != @rowsAffected

        begin

          select @errorNumber = 30001,

                 @errorMsg = 'Cannot insert/update into table "BVLPLAPR" because the values entered for "ID_TOEP", "ID_PRFL" in "BVLPLAPR" must correspond to the values of primary key column(s) of the table "BVLPRFL"'

          goto errorHandler

        end

    end



  return

  errorHandler:

  raiserror (@errorNumber, -1, -1, @errorMsg)

  rollback transaction

END