CREATE PROC [dbo].[USP_WY_BBBEWREG_UPDATE]
  @ID_REG int,
  @ID_OPS int,
  @ID_TY_REG int,
  @TMS_OPS_REG datetime,
  @TMS_INC datetime,
  @SCF_REG varchar(250),
  @PLA_INC varchar(200),
  @VLG_REG_JR_BPL int,
  @DT_VZ_RAP_NW datetime,
  @DT_OK datetime,
  @DT_VZ_BST datetime,
  @OPM_OPS varchar(100),
  @OPM_CHEF_PO varchar(100),
  @OPM_HFD_BRW varchar(100),
  @DT_OPS_RAP_INTV datetime,
  @SAP_SUPPLIER_ID varchar(30),
  @DT_CHIP datetime,
  @OPM_CHIP varchar(100),
  @CHIP_YN bit,
  @Original_ID_REG int, --Primary Key Field
  @VeraLink varchar(500), -- VRST 11/03/2013
  @VeraReference varchar(100), -- VRST 11/03/2013
  @VerslagContractantYN bit -- VRST 11/03/2013

AS
SET NOCOUNT OFF

UPDATE [BBBEWREG] SET
  [ID_OPS] = @ID_OPS,
  [ID_TY_REG] = @ID_TY_REG,
  [TMS_OPS_REG] = @TMS_OPS_REG,
  [TMS_INC] = @TMS_INC,
  [SCF_REG] = @SCF_REG,
  [PLA_INC] = @PLA_INC,
  [VLG_REG_JR_BPL] = @VLG_REG_JR_BPL,
  [DT_VZ_RAP_NW] = @DT_VZ_RAP_NW,
  [DT_OK] = @DT_OK,
  [DT_VZ_BST] = @DT_VZ_BST,
  [OPM_OPS] = @OPM_OPS,
  [OPM_CHEF_PO] = @OPM_CHEF_PO,
  [OPM_HFD_BRW] = @OPM_HFD_BRW,
  [DT_OPS_RAP_INTV] = @DT_OPS_RAP_INTV,
  [SAP_SUPPLIER_ID] = @SAP_SUPPLIER_ID,
  [DT_CHIP] = @DT_CHIP,
  [OPM_CHIP] = @OPM_CHIP,
  [CHIP_YN] = @CHIP_YN,
  [VeraLink] = @VeraLink,
  [VeraReference] = @VeraReference,
  [VerslagContractantYN]= @VerslagContractantYN
WHERE [ID_REG] = @Original_ID_REG