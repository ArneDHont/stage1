
Namespace DMC

    'Arcelor generated code (2006-04-10 15:45:53)
    Public Class UpdateDataAdaptersBBW

        Public Shared Function daBBAFD(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBAFD", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_AFD", System.Data.SqlDbType.VarChar, 200, "SCF_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("KRT_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@KRT_AFD", System.Data.SqlDbType.VarChar, 3, "KRT_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBARTGR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBARTGR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_GR_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GR_ART", System.Data.SqlDbType.Int, 4, "ID_GR_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_GR_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_GR_ART", System.Data.SqlDbType.VarChar, 30, "SCF_GR_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GR_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_GR_ART", System.Data.SqlDbType.Int, 4, "ID_GR_ART", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBEWDUP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBEWDUP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BEW_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BEW_DUP", System.Data.SqlDbType.Int, 4, "ID_BEW_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_BEW_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_BEW_DUP", System.Data.SqlDbType.VarChar, 50, "SCF_BEW_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BEW_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BEW_DUP", System.Data.SqlDbType.Int, 4, "ID_BEW_DUP", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBRKART(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBRKART", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_ART_BRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_ART_BRK", System.Data.SqlDbType.Int, 4, "ID_ART_BRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GR_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GR_ART", System.Data.SqlDbType.Int, 4, "ID_GR_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_EH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_EH", System.Data.SqlDbType.VarChar, 10, "ID_EH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_ART_BRK_SAP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_ART_BRK_SAP", System.Data.SqlDbType.VarChar, 20, "NR_ART_BRK_SAP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_ART", System.Data.SqlDbType.VarChar, 80, "SCF_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("STK_ACT_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@STK_ACT_ART", System.Data.SqlDbType.Int, 4, "STK_ACT_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("STK_MIN_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@STK_MIN_ART", System.Data.SqlDbType.Int, 4, "STK_MIN_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("STK_MAX_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@STK_MAX_ART", System.Data.SqlDbType.Float, 8, "STK_MAX_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PR_EH_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PR_EH_ART_INTV", System.Data.SqlDbType.Float, 8, "PR_EH_ART_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_WY_L") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_WY_L", System.Data.SqlDbType.DateTime, 8, "DT_WY_L", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_ART_BRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_ART_BRK", System.Data.SqlDbType.Int, 4, "ID_ART_BRK", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function




        Public Shared Function daBBBRKTSP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBRKTSP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BRK_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_TSP", System.Data.SqlDbType.Int, 4, "ID_BRK_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_BRK_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_BRK_TSP", System.Data.SqlDbType.VarChar, 20, "SCF_BRK_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BRK_TSP", System.Data.SqlDbType.Int, 4, "ID_BRK_TSP", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBRRD(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBRRD", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BR_RD_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BR_RD_INTV", System.Data.SqlDbType.Int, 4, "ID_BR_RD_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_BR_RD_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_BR_RD_INTV", System.Data.SqlDbType.VarChar, 30, "SCF_BR_RD_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_BZ") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_BZ", System.Data.SqlDbType.Bit, 1, "INDI_BZ", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BR_RD_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BR_RD_INTV", System.Data.SqlDbType.Int, 4, "ID_BR_RD_INTV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBRTY(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBRTY", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BR_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BR_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_BR_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_BR_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_BR_TY_INTV", System.Data.SqlDbType.VarChar, 30, "SCF_BR_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_BZ") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_BZ", System.Data.SqlDbType.Bit, 1, "INDI_BZ", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BR_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BR_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_BR_TY_INTV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function


        Public Shared Function daBBBTROGV(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBTROGV", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BTRK_OGV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BTRK_OGV", System.Data.SqlDbType.Int, 4, "ID_BTRK_OGV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND_BTRK", System.Data.SqlDbType.Int, 4, "ID_IND_BTRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_BTRK", System.Data.SqlDbType.Int, 4, "ID_TY_BTRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_TSP", System.Data.SqlDbType.Int, 4, "ID_BRK_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM_VZK", System.Data.SqlDbType.Int, 4, "ID_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_POLIS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_POLIS", System.Data.SqlDbType.VarChar, 20, "NR_POLIS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ROMP_LTSL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ROMP_LTSL", System.Data.SqlDbType.VarChar, 500, "ROMP_LTSL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("MAT_LTSL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@MAT_LTSL", System.Data.SqlDbType.VarChar, 500, "MAT_LTSL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("KAR_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@KAR_TSP", System.Data.SqlDbType.Bit, 1, "KAR_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("Q_IND_TSP_BRTK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Q_IND_TSP_BRTK", System.Data.SqlDbType.VarChar, 2, "Q_IND_TSP_BRTK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_TRL_VKM_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_TRL_VKM_TSP", System.Data.SqlDbType.Bit, 1, "INDI_TRL_VKM_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_Q_KG_VKM_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_Q_KG_VKM_TSP", System.Data.SqlDbType.VarChar, 10, "SCF_Q_KG_VKM_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("RB_NR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@RB_NR", System.Data.SqlDbType.VarChar, 100, "RB_NR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("RB_CAT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@RB_CAT", System.Data.SqlDbType.VarChar, 50, "RB_CAT", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("RB_DAT_UITG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@RB_DAT_UITG", System.Data.SqlDbType.DateTime, 8, "RB_DAT_UITG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("RB_PL_UITG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@RB_PL_UITG", System.Data.SqlDbType.VarChar, 100, "RB_PL_UITG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("BTW_NR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@BTW_NR", System.Data.SqlDbType.VarChar, 20, "BTW_NR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("HD_NM_VN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@HD_NM_VN", System.Data.SqlDbType.VarChar, 100, "HD_NM_VN", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TSP", System.Data.SqlDbType.Int, 4, "ID_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BTRK_OGV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BTRK_OGV", System.Data.SqlDbType.Int, 4, "ID_BTRK_OGV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBWPERS(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBWPERS", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PLG_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PLG_IND", System.Data.SqlDbType.Int, 4, "ID_PLG_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@BRDW", System.Data.SqlDbType.Bit, 1, "BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("WAK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@WAK", System.Data.SqlDbType.Bit, 1, "WAK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function
        Public Shared Function daBBAFDAMC(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBAFDAMC", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function


        Public Shared Function daBBBWPLG(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBWPLG", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_PLG_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PLG_IND", System.Data.SqlDbType.Int, 4, "ID_PLG_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_PLG_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_PLG_IND", System.Data.SqlDbType.VarChar, 50, "SCF_PLG_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PLG_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PLG_IND", System.Data.SqlDbType.Int, 4, "ID_PLG_IND", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBDIEFDU(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBDIEFDU", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_DUP_DIEF") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DUP_DIEF", System.Data.SqlDbType.VarChar, 30, "ID_DUP_DIEF", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_DUP", System.Data.SqlDbType.Char, 10, "SCF_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_NR_ST_VP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_NR_ST_VP", System.Data.SqlDbType.Bit, 1, "INDI_NR_ST_VP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_NM_FRM_VP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_NM_FRM_VP", System.Data.SqlDbType.Bit, 1, "INDI_NM_FRM_VP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DUP_DIEF") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_DUP_DIEF", System.Data.SqlDbType.VarChar, 30, "ID_DUP_DIEF", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBDIEFST(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBDIEFST", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_MLD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_MLD", System.Data.SqlDbType.Int, 4, "ID_MLD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DUP_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DUP_IND", System.Data.SqlDbType.Int, 4, "ID_DUP_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DUP", System.Data.SqlDbType.Int, 4, "ID_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_MAT_STLN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_MAT_STLN", System.Data.SqlDbType.VarChar, 500, "SCF_MAT_STLN", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("STA_MAT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@STA_MAT", System.Data.SqlDbType.VarChar, 500, "STA_MAT", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("WD_MAT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@WD_MAT", System.Data.SqlDbType.Float, 8, "WD_MAT", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_BTW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_BTW", System.Data.SqlDbType.VarChar, 20, "NR_BTW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_LNG_DIEF") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_LNG_DIEF", System.Data.SqlDbType.VarChar, 3000, "SCF_LNG_DIEF", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Current, da)
            End If

            If tableMapping.ColumnMappings.Contains("PolitieGevraagdDoorAfdYN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PolitieGevraagdDoorAfdYN", System.Data.SqlDbType.Bit, 2, "PolitieGevraagdDoorAfdYN", System.Data.DataRowVersion.Current, da)
            End If

            If tableMapping.ColumnMappings.Contains("PolitieLangsgeweestYN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PolitieLangsgeweestYN", System.Data.SqlDbType.Bit, 2, "PolitieLangsgeweestYN", System.Data.DataRowVersion.Current, da)
            End If

            If tableMapping.ColumnMappings.Contains("PolitiePVnummer") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PolitiePVnummer", System.Data.SqlDbType.VarChar, 100, "PolitiePVnummer", System.Data.DataRowVersion.Current, da)
            End If

            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function


        Public Shared Function daBBEH(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBEH", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_EH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_EH", System.Data.SqlDbType.VarChar, 10, "ID_EH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_EH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_EH", System.Data.SqlDbType.VarChar, 30, "SCF_EH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_EH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_EH", System.Data.SqlDbType.VarChar, 10, "ID_EH", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBFRM(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBFRM", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Float, 8, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_FRM", System.Data.SqlDbType.VarChar, 50, "NM_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("STRA_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@STRA_FRM", System.Data.SqlDbType.VarChar, 50, "STRA_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PO_COD_PLA_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PO_COD_PLA_FRM", System.Data.SqlDbType.VarChar, 10, "PO_COD_PLA_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_FRM", System.Data.SqlDbType.VarChar, 50, "PLA_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_FRM", System.Data.SqlDbType.Float, 8, "ID_FRM", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBDGPO(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBDGPO", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_DG_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DG_PO", System.Data.SqlDbType.Int, 4, "ID_DG_PO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DG_PO_DL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DG_PO_DL", System.Data.SqlDbType.Int, 4, "ID_DG_PO_DL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_REG_DG_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_REG_DG_PO", System.Data.SqlDbType.SmallDateTime, 4, "TMS_REG_DG_PO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("Q_PO_1") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Q_PO_1", System.Data.SqlDbType.BigInt, 8, "Q_PO_1", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("Q_PO_2") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Q_PO_2", System.Data.SqlDbType.BigInt, 8, "Q_PO_2", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("Q_PO_4") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Q_PO_4", System.Data.SqlDbType.BigInt, 8, "Q_PO_4", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("Q_PO_ALG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Q_PO_ALG", System.Data.SqlDbType.BigInt, 8, "Q_PO_ALG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DG_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_DG_PO", System.Data.SqlDbType.Int, 4, "ID_DG_PO", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function


        Public Shared Function daBBDGPERS(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBDGPERS", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_DG_PERS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DG_PERS", System.Data.SqlDbType.Int, 4, "ID_DG_PERS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_REG_DG_PERS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_REG_DG_PERS", System.Data.SqlDbType.DateTime, 8, "TMS_REG_DG_PERS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DG_PERS_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DG_PERS_TY_REG", System.Data.SqlDbType.Int, 4, "ID_DG_PERS_TY_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM", System.Data.SqlDbType.VarChar, 50, "OPM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DG_PERS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_DG_PERS", System.Data.SqlDbType.Int, 4, "ID_DG_PERS", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBDGTYREG(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBDGTYREG", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_DG_PERS_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DG_PERS_TY_REG", System.Data.SqlDbType.Int, 4, "ID_DG_PERS_TY_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_DG_PERS_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_DG_PERS_TY_REG", System.Data.SqlDbType.VarChar, 100, "SCF_DG_PERS_TY_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DG_PERS_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_DG_PERS_TY_REG", System.Data.SqlDbType.Int, 4, "ID_DG_PERS_TY_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBDGPODL(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBDGPODL", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_DG_PO_DL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DG_PO_DL", System.Data.SqlDbType.Int, 4, "ID_DG_PO_DL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_DG_PO_DL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_DG_PO_DL", System.Data.SqlDbType.VarChar, 50, "SCF_DG_PO_DL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INV_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INV_PO", System.Data.SqlDbType.Bit, 1, "INV_PO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VLG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VLG", System.Data.SqlDbType.Int, 4, "VLG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DG_PO_DL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_DG_PO_DL", System.Data.SqlDbType.Int, 4, "ID_DG_PO_DL", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINBRAR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINBRAR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_ART_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_ART_INBR", System.Data.SqlDbType.Int, 4, "ID_ART_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_INBR", System.Data.SqlDbType.Int, 4, "ID_TY_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_ART_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_ART_INBR", System.Data.SqlDbType.VarChar, 50, "NR_ART_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_ART_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_ART_INBR", System.Data.SqlDbType.VarChar, 2000, "SCF_ART_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_ART_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_ART_INBR", System.Data.SqlDbType.Int, 4, "ID_ART_INBR", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        'Public Shared Function daBBINBRRG(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
        '    Dim da As System.Data.SqlClient.SqlDataAdapter
        '    da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINBRRG", ADF.Data.DbHelper.ActionEnum.Update)
        '    ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
        '    If tableMapping.ColumnMappings.Contains("ID_REG") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("ID_BEW_DUP") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BEW_DUP", System.Data.SqlDbType.Int, 4, "ID_BEW_DUP", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("ID_INBR") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INBR", System.Data.SqlDbType.Int, 4, "ID_INBR", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("ID_FRM") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("ID_TSP") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TSP", System.Data.SqlDbType.Int, 4, "ID_TSP", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("VKLR_INBR") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@VKLR_INBR", System.Data.SqlDbType.VarChar, 300, "VKLR_INBR", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("OPM_EX_INBR_VSF") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_EX_INBR_VSF", System.Data.SqlDbType.VarChar, 150, "OPM_EX_INBR_VSF", System.Data.DataRowVersion.Current, da)
        '    End If
        '    If tableMapping.ColumnMappings.Contains("ID_REG") Then
        '        ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
        '    End If
        '    Return da
        'End Function
        Public Shared Function daBBINBRINDTY(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINBRINDTY", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_INBR_IND_TY") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INBR_IND_TY", System.Data.SqlDbType.Int, 4, "ID_INBR_IND_TY", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_INBR_IND_TY") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_INBR_IND_TY", System.Data.SqlDbType.VarChar, 50, "SCF_INBR_IND_TY", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INBR_IND_TY") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_INBR_IND_TY", System.Data.SqlDbType.Int, 4, "ID_INBR_IND_TY", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINBRRG(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINBRRG", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BEW_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BEW_DUP", System.Data.SqlDbType.Int, 4, "ID_BEW_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INBR", System.Data.SqlDbType.Int, 4, "ID_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TSP", System.Data.SqlDbType.Int, 4, "ID_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VKLR_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VKLR_INBR", System.Data.SqlDbType.VarChar, 3000, "VKLR_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_EX_INBR_VSF") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_EX_INBR_VSF", System.Data.SqlDbType.VarChar, 3000, "OPM_EX_INBR_VSF", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INBR_IND_TY") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INBR_IND_TY", System.Data.SqlDbType.Int, 4, "ID_INBR_IND_TY", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINBRTY(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINBRTY", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TY_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_INBR", System.Data.SqlDbType.Int, 4, "ID_TY_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_TY_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_TY_INBR", System.Data.SqlDbType.VarChar, 30, "SCF_TY_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TY_INBR", System.Data.SqlDbType.Int, 4, "ID_TY_INBR", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINBRVA(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINBRVA", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_INBRVA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INBRVA", System.Data.SqlDbType.Int, 4, "ID_INBRVA", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_ART_INBR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_ART_INBR", System.Data.SqlDbType.Int, 4, "ID_ART_INBR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SNL_OK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SNL_OK", System.Data.SqlDbType.Int, 4, "SNL_OK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SNL_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SNL_REG", System.Data.SqlDbType.Int, 4, "SNL_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INBRVA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_INBRVA", System.Data.SqlDbType.Int, 4, "ID_INBRVA", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBIND(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBIND", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_IND", System.Data.SqlDbType.Int, 4, "ID_TY_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM_IND_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM_IND_TK", System.Data.SqlDbType.Int, 4, "ID_FRM_IND_TK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_IND", System.Data.SqlDbType.VarChar, 50, "NM_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VNM_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VNM_IND", System.Data.SqlDbType.VarChar, 50, "VNM_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("AD_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@AD_IND", System.Data.SqlDbType.VarChar, 150, "AD_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PO_COD_WNPL_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PO_COD_WNPL_IND", System.Data.SqlDbType.VarChar, 10, "PO_COD_WNPL_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("WNPL_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@WNPL_IND", System.Data.SqlDbType.VarChar, 60, "WNPL_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_GBR_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_GBR_IND", System.Data.SqlDbType.VarChar, 60, "PLA_GBR_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_GBR_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_GBR_IND", System.Data.SqlDbType.DateTime, 8, "DT_GBR_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("AD_EMAL_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@AD_EMAL_IND", System.Data.SqlDbType.VarChar, 100, "AD_EMAL_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GSL_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GSL_IND", System.Data.SqlDbType.Int, 4, "ID_GSL_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("BST_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@BST_IND", System.Data.SqlDbType.Bit, 1, "BST_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SAP_DIR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SAP_DIR", System.Data.SqlDbType.VarChar, 5, "SAP_DIR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SAP_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SAP_AFD", System.Data.SqlDbType.VarChar, 5, "SAP_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SAP_SECT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SAP_SECT", System.Data.SqlDbType.VarChar, 5, "SAP_SECT", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_UIT_DNS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_UIT_DNS", System.Data.SqlDbType.DateTime, 8, "DT_UIT_DNS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("BST_ACTIVE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@BST_ACTIVE", System.Data.SqlDbType.Bit, 1, "BST_ACTIVE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINDGSL(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINDGSL", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_GSL_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GSL_IND", System.Data.SqlDbType.Int, 4, "ID_GSL_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_IND_GSL_RAP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_IND_GSL_RAP", System.Data.SqlDbType.VarChar, 10, "SCF_IND_GSL_RAP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GSL_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_GSL_IND", System.Data.SqlDbType.Int, 4, "ID_GSL_IND", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINDTY(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINDTY", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TY_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_IND", System.Data.SqlDbType.Int, 4, "ID_TY_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_TY_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_TY_IND", System.Data.SqlDbType.Char, 50, "SCF_TY_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TY_IND", System.Data.SqlDbType.Int, 4, "ID_TY_IND", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINTART(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINTART", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_ART_INTV", System.Data.SqlDbType.Int, 4, "ID_ART_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_EH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_EH", System.Data.SqlDbType.VarChar, 10, "ID_EH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GR_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GR_ART", System.Data.SqlDbType.Int, 4, "ID_GR_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_ART_INTV", System.Data.SqlDbType.VarChar, 50, "SCF_ART_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PR_EH_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PR_EH_ART_INTV", System.Data.SqlDbType.Float, 8, "PR_EH_ART_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TSP_DU_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TSP_DU_INTV", System.Data.SqlDbType.Bit, 1, "TSP_DU_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_ART_INTV", System.Data.SqlDbType.Int, 4, "ID_ART_INTV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function


        Public Shared Function daBBINTVBR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINTVBR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_INTV_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INTV_BRDW", System.Data.SqlDbType.Int, 4, "ID_INTV_BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BR_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BR_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_BR_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BR_RD_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BR_RD_INTV", System.Data.SqlDbType.Int, 4, "ID_BR_RD_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OPS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OPS", System.Data.SqlDbType.Int, 4, "ID_OPS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_CHEF_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_CHEF_PO", System.Data.SqlDbType.Int, 4, "ID_CHEF_PO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_HFD_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_HFD_BRDW", System.Data.SqlDbType.Int, 4, "ID_HFD_BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OK", System.Data.SqlDbType.Int, 4, "ID_OK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("IND_OPR_DR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@IND_OPR_DR", System.Data.SqlDbType.VarChar, 50, "IND_OPR_DR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_INTV", System.Data.SqlDbType.DateTime, 8, "TMS_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VLG_TY_INTV_JR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VLG_TY_INTV_JR", System.Data.SqlDbType.Int, 4, "VLG_TY_INTV_JR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VLG_TY_INTV_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VLG_TY_INTV_AFD", System.Data.SqlDbType.Int, 4, "VLG_TY_INTV_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_INTV", System.Data.SqlDbType.VarChar, 1000, "PLA_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OK_VU_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OK_VU_TK", System.Data.SqlDbType.VarChar, 50, "ID_OK_VU_TK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_LNG_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_LNG_INTV", System.Data.SqlDbType.VarChar, 8000, "SCF_LNG_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_BRD_BLUS_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_BRD_BLUS_AFD", System.Data.SqlDbType.Bit, 1, "INDI_BRD_BLUS_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_BRD_BLUS_SID") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_BRD_BLUS_SID", System.Data.SqlDbType.Bit, 1, "INDI_BRD_BLUS_SID", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_BRDW_SID_OPR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_BRDW_SID_OPR", System.Data.SqlDbType.Bit, 1, "INDI_BRDW_SID_OPR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_RAP_INC_OTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_RAP_INC_OTV", System.Data.SqlDbType.Bit, 1, "INDI_RAP_INC_OTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_OPS_RAP_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_OPS_RAP_INTV", System.Data.SqlDbType.DateTime, 8, "DT_OPS_RAP_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_VZ_RAP_NW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_VZ_RAP_NW", System.Data.SqlDbType.DateTime, 8, "DT_VZ_RAP_NW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_OK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_OK", System.Data.SqlDbType.DateTime, 8, "DT_OK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_VZ_BST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_VZ_BST", System.Data.SqlDbType.DateTime, 8, "DT_VZ_BST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_OPS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_OPS", System.Data.SqlDbType.VarChar, 100, "OPM_OPS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_CHEF_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_CHEF_PO", System.Data.SqlDbType.VarChar, 100, "OPM_CHEF_PO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_HFD_BRW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_HFD_BRW", System.Data.SqlDbType.VarChar, 100, "OPM_HFD_BRW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("BST_OUD_PG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@BST_OUD_PG", System.Data.SqlDbType.VarChar, 300, "BST_OUD_PG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INTV_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_INTV_BRDW", System.Data.SqlDbType.Int, 4, "ID_INTV_BRDW", System.Data.DataRowVersion.Original, da)
            End If
            'Vera reports SIDVRST - 08/03/2012
            If tableMapping.ColumnMappings.Contains("VeraLink") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VeraLink", System.Data.SqlDbType.VarChar, 500, "VeraLink", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VeraReference") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VeraReference", System.Data.SqlDbType.VarChar, 100, "VeraReference", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VerslagContractantYN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VerslagContractantYN", System.Data.SqlDbType.Bit, 1, "VerslagContractantYN", System.Data.DataRowVersion.Current, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINTVDU(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINTVDU", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_DU_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DU_INTV", System.Data.SqlDbType.Int, 4, "ID_DU_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INTV_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INTV_BRDW", System.Data.SqlDbType.Int, 4, "ID_INTV_BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_ART_INTV", System.Data.SqlDbType.Int, 4, "ID_ART_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TYD_OPR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TYD_OPR", System.Data.SqlDbType.DateTime, 8, "TYD_OPR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TYD_KO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TYD_KO", System.Data.SqlDbType.DateTime, 8, "TYD_KO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TYD_END") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TYD_END", System.Data.SqlDbType.DateTime, 8, "TYD_END", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DU_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_DU_INTV", System.Data.SqlDbType.Int, 4, "ID_DU_INTV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBINTVTY(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBINTVTY", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_TY_INTV", System.Data.SqlDbType.VarChar, 30, "SCF_TY_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TY_INTV", System.Data.SqlDbType.Int, 4, "ID_TY_INTV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBKEUTSP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBKEUTSP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_STUR_TSP_KEU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_STUR_TSP_KEU", System.Data.SqlDbType.Int, 4, "ID_STUR_TSP_KEU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TSP_KEU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TSP_KEU", System.Data.SqlDbType.Int, 4, "ID_TSP_KEU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DNS_VTW_WR_KEU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DNS_VTW_WR_KEU", System.Data.SqlDbType.Int, 4, "ID_DNS_VTW_WR_KEU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BEW_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BEW_DUP", System.Data.SqlDbType.Int, 4, "ID_BEW_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_WRF_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_WRF_TSP", System.Data.SqlDbType.Int, 4, "ID_WRF_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_ORG_KEU_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_ORG_KEU_TSP", System.Data.SqlDbType.VarChar, 100, "SCF_ORG_KEU_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_L_KEU_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_L_KEU_TSP", System.Data.SqlDbType.DateTime, 8, "DT_L_KEU_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_VKLR_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_VKLR_TSP", System.Data.SqlDbType.VarChar, 2000, "OPM_VKLR_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("FA_BST_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@FA_BST_TSP", System.Data.SqlDbType.VarChar, 300, "FA_BST_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_DFC_REG_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_DFC_REG_TSP", System.Data.SqlDbType.VarChar, 500, "SCF_DFC_REG_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("RGL_NEM_KEU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@RGL_NEM_KEU", System.Data.SqlDbType.VarChar, 2000, "RGL_NEM_KEU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function



        Public Shared Function daBBMATPR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBMATPR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_PR_MAT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PR_MAT", System.Data.SqlDbType.Int, 4, "ID_PR_MAT", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INTV_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INTV_BRDW", System.Data.SqlDbType.Int, 4, "ID_INTV_BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_ART_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_ART_INTV", System.Data.SqlDbType.Int, 4, "ID_ART_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("Q_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Q_ART", System.Data.SqlDbType.Int, 4, "Q_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PR_TOT_ART") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PR_TOT_ART", System.Data.SqlDbType.Float, 8, "PR_TOT_ART", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PR_MAT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PR_MAT", System.Data.SqlDbType.Int, 4, "ID_PR_MAT", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBOGVBTR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBOGVBTR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BTRK_OGV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BTRK_OGV", System.Data.SqlDbType.Int, 4, "ID_BTRK_OGV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BTRK", System.Data.SqlDbType.Int, 4, "ID_BTRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BTRK_OGV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BTRK_OGV", System.Data.SqlDbType.Int, 4, "ID_BTRK_OGV", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBOGVTSP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBOGVTSP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_MLD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_MLD", System.Data.SqlDbType.Int, 4, "ID_MLD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_LNG_OGV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_LNG_OGV", System.Data.SqlDbType.VarChar, 8000, "SCF_LNG_OGV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OGV_VAST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OGV_VAST", System.Data.SqlDbType.Int, 4, "ID_OGV_VAST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INF_EX") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INF_EX", System.Data.SqlDbType.VarChar, 200, "INF_EX", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_OGV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_OGV", System.Data.SqlDbType.VarChar, 100, "PLA_OGV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_STA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_STA", System.Data.SqlDbType.VarChar, 100, "SCF_STA", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ZBH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ZBH", System.Data.SqlDbType.VarChar, 500, "ZBH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("WND_RIC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@WND_RIC", System.Data.SqlDbType.VarChar, 500, "WND_RIC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("WND_KR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@WND_KR", System.Data.SqlDbType.VarChar, 500, "WND_KR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("GBEU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@GBEU", System.Data.SqlDbType.VarChar, 500, "GBEU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBOPKAST(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBOPKAST", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TITU_KAST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TITU_KAST", System.Data.SqlDbType.Int, 4, "ID_TITU_KAST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DNS_OPS_KAST_VR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DNS_OPS_KAST_VR", System.Data.SqlDbType.Int, 4, "ID_DNS_OPS_KAST_VR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OTV_EIG_SID") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OTV_EIG_SID", System.Data.SqlDbType.Int, 4, "ID_OTV_EIG_SID", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OTV_EIG_TITU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OTV_EIG_TITU", System.Data.SqlDbType.Int, 4, "ID_OTV_EIG_TITU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_RD_OPN_KAST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_RD_OPN_KAST", System.Data.SqlDbType.VarChar, 3000, "SCF_RD_OPN_KAST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_EIG_SID") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_EIG_SID", System.Data.SqlDbType.VarChar, 1000, "SCF_EIG_SID", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_EIG_TITU") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_EIG_TITU", System.Data.SqlDbType.VarChar, 1000, "SCF_EIG_TITU", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INF_EX_OPN_KAST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INF_EX_OPN_KAST", System.Data.SqlDbType.VarChar, 1000, "INF_EX_OPN_KAST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBREGTY(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBREGTY", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_REG", System.Data.SqlDbType.Int, 4, "ID_TY_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_TY_REG", System.Data.SqlDbType.VarChar, 30, "SCF_TY_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TY_REG", System.Data.SqlDbType.Int, 4, "ID_TY_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBREGVSH(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBREGVSH", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM_VZK", System.Data.SqlDbType.Int, 4, "ID_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_FRM_BTRK_ALT") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_FRM_BTRK_ALT", System.Data.SqlDbType.VarChar, 300, "SCF_FRM_BTRK_ALT", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_BTW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_BTW", System.Data.SqlDbType.VarChar, 20, "NR_BTW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_KRT_REG_VSH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_KRT_REG_VSH", System.Data.SqlDbType.VarChar, 1000, "SCF_KRT_REG_VSH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_LNG_REG_VSH") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_LNG_REG_VSH", System.Data.SqlDbType.VarChar, 8000, "SCF_LNG_REG_VSH", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_POLIS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_POLIS", System.Data.SqlDbType.VarChar, 30, "NR_POLIS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_AFD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_AFD", System.Data.SqlDbType.Int, 4, "ID_AFD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBSCAD(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBSCAD", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_MLD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_MLD", System.Data.SqlDbType.Int, 4, "ID_MLD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TSP", System.Data.SqlDbType.Int, 4, "ID_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM_VZK", System.Data.SqlDbType.Int, 4, "ID_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OBJ_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OBJ_SCAD", System.Data.SqlDbType.Int, 4, "ID_OBJ_SCAD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BEW_DUP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BEW_DUP", System.Data.SqlDbType.Int, 4, "ID_BEW_DUP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_BTW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_BTW", System.Data.SqlDbType.VarChar, 20, "NR_BTW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_POLIS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_POLIS", System.Data.SqlDbType.VarChar, 20, "NR_POLIS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TY_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TY_SCAD", System.Data.SqlDbType.VarChar, 2000, "TY_SCAD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("RD_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@RD_SCAD", System.Data.SqlDbType.VarChar, 2000, "RD_SCAD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_SCAD", System.Data.SqlDbType.VarChar, 5000, "OPM_SCAD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBSCADAN(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBSCADAN", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_OBJ_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OBJ_SCAD", System.Data.SqlDbType.Int, 4, "ID_OBJ_SCAD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_OBJ_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_OBJ_SCAD", System.Data.SqlDbType.VarChar, 50, "SCF_OBJ_SCAD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OBJ_SCAD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_OBJ_SCAD", System.Data.SqlDbType.Int, 4, "ID_OBJ_SCAD", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBTSP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBTSP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TSP", System.Data.SqlDbType.Int, 4, "ID_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_TSP", System.Data.SqlDbType.Int, 4, "ID_TY_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_EIG_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_EIG_TSP", System.Data.SqlDbType.Int, 4, "ID_EIG_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM_TSP", System.Data.SqlDbType.Int, 4, "ID_FRM_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_TSP_ARC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_TSP_ARC", System.Data.SqlDbType.Bit, 1, "INDI_TSP_ARC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_TSP_PRIV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_TSP_PRIV", System.Data.SqlDbType.Bit, 1, "INDI_TSP_PRIV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_MRK_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_MRK_TSP", System.Data.SqlDbType.VarChar, 20, "SCF_MRK_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PL_NR_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PL_NR_TSP", System.Data.SqlDbType.VarChar, 15, "PL_NR_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INH_CYL_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INH_CYL_TSP", System.Data.SqlDbType.VarChar, 10, "INH_CYL_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("JR_BOU_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@JR_BOU_TSP", System.Data.SqlDbType.VarChar, 4, "JR_BOU_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_CHAS_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_CHAS_TSP", System.Data.SqlDbType.VarChar, 20, "NR_CHAS_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_KEU_L_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_KEU_L_TSP", System.Data.SqlDbType.DateTime, 8, "DT_KEU_L_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TSP", System.Data.SqlDbType.Int, 4, "ID_TSP", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function


        Public Shared Function daBBTYBTRK(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBTYBTRK", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TY_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_BTRK", System.Data.SqlDbType.Char, 10, "ID_TY_BTRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_TY_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_TY_BTRK", System.Data.SqlDbType.Char, 10, "SCF_TY_BTRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TY_BTRK", System.Data.SqlDbType.Char, 10, "ID_TY_BTRK", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBTYTSP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBTYTSP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TY_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_TSP", System.Data.SqlDbType.Int, 4, "ID_TY_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_TY_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_TY_TSP", System.Data.SqlDbType.VarChar, 100, "SCF_TY_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TY_TSP", System.Data.SqlDbType.Int, 4, "ID_TY_TSP", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBVZKFRM(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBVZKFRM", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM_VZK", System.Data.SqlDbType.Int, 4, "ID_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_FRM_VZK", System.Data.SqlDbType.VarChar, 100, "NM_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("AD_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@AD_FRM_VZK", System.Data.SqlDbType.VarChar, 200, "AD_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_FRM_VZK", System.Data.SqlDbType.VarChar, 100, "PLA_FRM_VZK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM_VZK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_FRM_VZK", System.Data.SqlDbType.Int, 4, "ID_FRM_VZK", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLGGD(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLGGD", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GGD", System.Data.SqlDbType.Char, 50, "ID_GGD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_GGD", System.Data.SqlDbType.VarChar, 50, "NM_GGD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("COD_BVG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@COD_BVG", System.Data.SqlDbType.Char, 1, "COD_BVG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_GGD", System.Data.SqlDbType.Char, 50, "ID_GGD", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLGR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLGR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_GR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GR", System.Data.SqlDbType.Char, 50, "ID_GR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_GR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_GR", System.Data.SqlDbType.VarChar, 50, "NM_GR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_GR", System.Data.SqlDbType.Char, 50, "ID_GR", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLGRPR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLGRPR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_GR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GR", System.Data.SqlDbType.Char, 50, "ID_GR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_GR", System.Data.SqlDbType.Char, 50, "ID_GR", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLIND(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLIND", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Char, 50, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("KRT_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@KRT_IND", System.Data.SqlDbType.Char, 50, "KRT_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_IND", System.Data.SqlDbType.VarChar, 50, "NM_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_IND", System.Data.SqlDbType.Char, 50, "ID_IND", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLINDPR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLINDPR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Char, 50, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_IND", System.Data.SqlDbType.Char, 50, "ID_IND", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLPGGD(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLPGGD", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TOEP_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP_PRFL", System.Data.SqlDbType.Char, 50, "ID_TOEP_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP_GGD", System.Data.SqlDbType.Char, 50, "ID_TOEP_GGD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_GGD", System.Data.SqlDbType.Char, 50, "ID_GGD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP_PRFL", System.Data.SqlDbType.Char, 50, "ID_TOEP_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP_GGD", System.Data.SqlDbType.Char, 50, "ID_TOEP_GGD", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_GGD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_GGD", System.Data.SqlDbType.Char, 50, "ID_GGD", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLPLA(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLPLA", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_PLA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PLA", System.Data.SqlDbType.Char, 50, "ID_PLA", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_PLA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_PLA", System.Data.SqlDbType.VarChar, 50, "NM_PLA", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PLA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PLA", System.Data.SqlDbType.Char, 50, "ID_PLA", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLPLAPR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLPLAPR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_PLA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PLA", System.Data.SqlDbType.Char, 50, "ID_PLA", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PLA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PLA", System.Data.SqlDbType.Char, 50, "ID_PLA", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLPRFL(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLPRFL", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_PRFL", System.Data.SqlDbType.VarChar, 50, "NM_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLPTKWR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLPTKWR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TOEP_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP_PRFL", System.Data.SqlDbType.Char, 50, "ID_TOEP_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP_TK_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP_TK_WR", System.Data.SqlDbType.Char, 50, "ID_TOEP_TK_WR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_WR", System.Data.SqlDbType.Char, 50, "ID_WR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TK", System.Data.SqlDbType.Char, 50, "ID_TK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP_PRFL", System.Data.SqlDbType.Char, 50, "ID_TOEP_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_PRFL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_PRFL", System.Data.SqlDbType.Char, 50, "ID_PRFL", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP_TK_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP_TK_WR", System.Data.SqlDbType.Char, 50, "ID_TOEP_TK_WR", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_WR", System.Data.SqlDbType.Char, 50, "ID_WR", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TK", System.Data.SqlDbType.Char, 50, "ID_TK", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLTKWR(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLTKWR", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_WR", System.Data.SqlDbType.Char, 50, "ID_WR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TK", System.Data.SqlDbType.Char, 50, "ID_TK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_TK", System.Data.SqlDbType.VarChar, 50, "NM_TK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_WR", System.Data.SqlDbType.VarChar, 50, "NM_WR", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_WR") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_WR", System.Data.SqlDbType.Char, 50, "ID_WR", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TK", System.Data.SqlDbType.Char, 50, "ID_TK", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBVLTOEP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BVLTOEP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NM_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM_TOEP", System.Data.SqlDbType.VarChar, 50, "NM_TOEP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_CRE_RE", System.Data.SqlDbType.DateTime, 8, "TMS_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_CRE_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_CRE_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_CRE_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_WY_L_RE", System.Data.SqlDbType.DateTime, 8, "TMS_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BRK_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BRK_WY_L_RE", System.Data.SqlDbType.Char, 8, "ID_BRK_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TOEP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TOEP", System.Data.SqlDbType.Char, 50, "ID_TOEP", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("NR_WY_L_RE") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_NR_WY_L_RE", System.Data.SqlDbType.Int, 4, "NR_WY_L_RE", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBWRFTSP(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBWRFTSP", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_WRF_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_WRF_TSP", System.Data.SqlDbType.Int, 4, "ID_WRF_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_WRF_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_WRF_TSP", System.Data.SqlDbType.VarChar, 50, "SCF_WRF_TSP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_WRF_TSP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_WRF_TSP", System.Data.SqlDbType.Int, 4, "ID_WRF_TSP", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBALCTST(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBALCTST", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_MLD") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_MLD", System.Data.SqlDbType.Int, 4, "ID_MLD", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BTRK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BTRK", System.Data.SqlDbType.Int, 4, "ID_BTRK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_FRM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_FRM", System.Data.SqlDbType.Int, 4, "ID_FRM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_LNG_TST_ALC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_LNG_TST_ALC", System.Data.SqlDbType.VarChar, 8000, "SCF_LNG_TST_ALC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TYD_TST_ALC_1") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TYD_TST_ALC_1", System.Data.SqlDbType.VarChar, 10, "TYD_TST_ALC_1", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_TST_1_POS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_TST_1_POS", System.Data.SqlDbType.Bit, 1, "INDI_TST_1_POS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_TST_ALC_1") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_TST_ALC_1", System.Data.SqlDbType.VarChar, 100, "PLA_TST_ALC_1", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TYD_TST_ALC_2") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TYD_TST_ALC_2", System.Data.SqlDbType.VarChar, 10, "TYD_TST_ALC_2", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INDI_TST_2_POS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INDI_TST_2_POS", System.Data.SqlDbType.Bit, 1, "INDI_TST_2_POS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_TST_ALC_2") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_TST_ALC_2", System.Data.SqlDbType.VarChar, 100, "PLA_TST_ALC_2", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_RGL_NEM") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_RGL_NEM", System.Data.SqlDbType.VarChar, 2000, "SCF_RGL_NEM", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("INF_EX_TST_ALC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@INF_EX_TST_ALC", System.Data.SqlDbType.VarChar, 2000, "INF_EX_TST_ALC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBEWREG(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBEWREG", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_OPS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_OPS", System.Data.SqlDbType.Int, 4, "ID_OPS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_TY_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TY_REG", System.Data.SqlDbType.Int, 4, "ID_TY_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_OPS_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_OPS_REG", System.Data.SqlDbType.DateTime, 8, "TMS_OPS_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("TMS_INC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@TMS_INC", System.Data.SqlDbType.DateTime, 8, "TMS_INC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_REG", System.Data.SqlDbType.VarChar, 250, "SCF_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_INC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_INC", System.Data.SqlDbType.VarChar, 200, "PLA_INC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VLG_REG_JR_BPL") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VLG_REG_JR_BPL", System.Data.SqlDbType.Int, 4, "VLG_REG_JR_BPL", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_VZ_RAP_NW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_VZ_RAP_NW", System.Data.SqlDbType.DateTime, 8, "DT_VZ_RAP_NW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_OK") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_OK", System.Data.SqlDbType.DateTime, 8, "DT_OK", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_VZ_BST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_VZ_BST", System.Data.SqlDbType.DateTime, 8, "DT_VZ_BST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_OPS") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_OPS", System.Data.SqlDbType.VarChar, 100, "OPM_OPS", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_CHEF_PO") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_CHEF_PO", System.Data.SqlDbType.VarChar, 100, "OPM_CHEF_PO", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_HFD_BRW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_HFD_BRW", System.Data.SqlDbType.VarChar, 100, "OPM_HFD_BRW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_OPS_RAP_INTV") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_OPS_RAP_INTV", System.Data.SqlDbType.DateTime, 8, "DT_OPS_RAP_INTV", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SAP_SUPPLIER_ID") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SAP_SUPPLIER_ID", System.Data.SqlDbType.VarChar, 30, "SAP_SUPPLIER_ID", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("DT_CHIP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@DT_CHIP", System.Data.SqlDbType.DateTime, 8, "DT_CHIP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("OPM_CHIP") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@OPM_CHIP", System.Data.SqlDbType.VarChar, 100, "OPM_CHIP", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("CHIP_YN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@CHIP_YN", System.Data.SqlDbType.Bit, 1, "CHIP_YN", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            'Vera reports SIDVRST - 08/03/2012
            If tableMapping.ColumnMappings.Contains("VeraLink") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VeraLink", System.Data.SqlDbType.VarChar, 500, "VeraLink", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VeraReference") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VeraReference", System.Data.SqlDbType.VarChar, 100, "VeraReference", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("VerslagContractantYN") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@VerslagContractantYN", System.Data.SqlDbType.Bit, 1, "VerslagContractantYN", System.Data.DataRowVersion.Current, da)
            End If
            Return da
        End Function


        Public Shared Function daBBOGVSTA(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBOGVSTA", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_STA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_STA", System.Data.SqlDbType.Int, 4, "ID_STA", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Original, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_STA") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_STA", System.Data.SqlDbType.Int, 4, "ID_STA", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBST(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBST", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BST", System.Data.SqlDbType.Int, 4, "ID_BST", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INTV_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INTV_BRDW", System.Data.SqlDbType.Int, 4, "ID_INTV_BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_IND") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_IND", System.Data.SqlDbType.Int, 4, "ID_IND", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BST") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BST", System.Data.SqlDbType.Int, 4, "ID_BST", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

        Public Shared Function daBBBYLG(ByVal tableMapping As System.Data.Common.DataTableMapping) As System.Data.SqlClient.SqlDataAdapter
            Dim da As System.Data.SqlClient.SqlDataAdapter
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_BBBYLG", ADF.Data.DbHelper.ActionEnum.Update)
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da)
            If tableMapping.ColumnMappings.Contains("ID_BYLG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_BYLG", System.Data.SqlDbType.Int, 4, "ID_BYLG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_INTV_BRDW") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_INTV_BRDW", System.Data.SqlDbType.Int, 4, "ID_INTV_BRDW", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_REG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_REG", System.Data.SqlDbType.Int, 4, "ID_REG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("PLA_BYLG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@PLA_BYLG", System.Data.SqlDbType.VarChar, 100, "PLA_BYLG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("SCF_BYLG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF_BYLG", System.Data.SqlDbType.VarChar, 200, "SCF_BYLG", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_DOC") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_DOC", System.Data.SqlDbType.VarChar, 50, "ID_DOC", System.Data.DataRowVersion.Current, da)
            End If
            If tableMapping.ColumnMappings.Contains("ID_BYLG") Then
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_BYLG", System.Data.SqlDbType.Int, 4, "ID_BYLG", System.Data.DataRowVersion.Original, da)
            End If
            Return da
        End Function

    End Class
End Namespace
