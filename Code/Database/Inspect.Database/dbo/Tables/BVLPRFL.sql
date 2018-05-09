CREATE TABLE [dbo].[BVLPRFL] (
    [ID_TOEP]        CHAR (50)    NOT NULL,
    [ID_PRFL]        CHAR (50)    NOT NULL,
    [NM_PRFL]        VARCHAR (50) NULL,
    [TMS_CRE_RE]     DATETIME     NULL,
    [ID_BRK_CRE_RE]  CHAR (8)     NULL,
    [TMS_WY_L_RE]    DATETIME     NULL,
    [ID_BRK_WY_L_RE] CHAR (8)     NULL,
    [NR_WY_L_RE]     INT          NULL,
    CONSTRAINT [BVLPRFL_PK] PRIMARY KEY CLUSTERED ([ID_TOEP] ASC, [ID_PRFL] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BVLTOEP_BVLPRFL_FK1] FOREIGN KEY ([ID_TOEP]) REFERENCES [dbo].[BVLTOEP] ([ID_TOEP])
);


GO
/* Create/Recreate user defined triggers for all the newly create and changed tables.         */

/* Create table level triggers for table BVLPRFL.                                             */

Create trigger [dbo].[BVLPRFLdelete] on [dbo].[BVLPRFL] 

for delete 

as

/* Microsoft Visual Studio generated code. */

BEGIN

  declare

	@errorNumber int,

	@errorMsg varchar(255)



  /* Clause for ON DELETE to referenced table : NO ACTION */

  if exists(

    select * from deleted, "BVLPLAPR"    where "BVLPLAPR"."ID_TOEP" = deleted."ID_TOEP" and

      "BVLPLAPR"."ID_PRFL" = deleted."ID_PRFL")

    begin

      select @errorNumber = 30004,

             @errorMsg = 'Cannot delete from "BVLPRFL" because "BVLPLAPR" exists.'

      goto errorHandler

    end



  return

  errorHandler:

    raiserror (@errorNumber, -1, -1, @errorMsg)

  rollback transaction

END