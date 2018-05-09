Imports Be.Sidmar.RIS.BrandweerBewaking.Client
Imports System.Security.Principal
Imports System.Threading

Public Class DataManagerBBW
    Inherits System.ComponentModel.Component

    Private myImp As New Impersonation

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    Friend WithEvents SqlConnectionBBW As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapterBBIND As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnectionBBW = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapterBBIND = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        '
        'SqlDataAdapterBBIND
        '
        Me.SqlDataAdapterBBIND.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapterBBIND.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "USP_BBW_GET_ALL_BBIND", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_IND", "ID_IND"), New System.Data.Common.DataColumnMapping("NM_IND", "NM_IND"), New System.Data.Common.DataColumnMapping("VNM_IND", "VNM_IND"), New System.Data.Common.DataColumnMapping("AD_IND", "AD_IND"), New System.Data.Common.DataColumnMapping("PO_COD_WNPL_IND", "PO_COD_WNPL_IND"), New System.Data.Common.DataColumnMapping("WNPL_IND", "WNPL_IND"), New System.Data.Common.DataColumnMapping("PLA_GBR_IND", "PLA_GBR_IND"), New System.Data.Common.DataColumnMapping("DT_GBR_IND", "DT_GBR_IND"), New System.Data.Common.DataColumnMapping("SAP_DIR", "SAP_DIR"), New System.Data.Common.DataColumnMapping("SAP_AFD", "SAP_AFD"), New System.Data.Common.DataColumnMapping("SAP_SECT", "SAP_SECT"), New System.Data.Common.DataColumnMapping("DT_UIT_DNS", "DT_UIT_DNS"), New System.Data.Common.DataColumnMapping("NR_TEL_SID", "NR_TEL_SID"), New System.Data.Common.DataColumnMapping("SCF_FIE", "SCF_FIE"), New System.Data.Common.DataColumnMapping("ID_GSL_IND", "ID_GSL_IND"), New System.Data.Common.DataColumnMapping("ID_TY_IND", "ID_TY_IND"), New System.Data.Common.DataColumnMapping("ID_FRM_IND_TK", "ID_FRM_IND_TK"), New System.Data.Common.DataColumnMapping("AD_EMAL_IND", "AD_EMAL_IND"), New System.Data.Common.DataColumnMapping("BST_IND", "BST_IND"), New System.Data.Common.DataColumnMapping("SCF_TY_IND", "SCF_TY_IND")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[USP_BBW_GET_ALL_BBIND]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnectionBBW
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))

    End Sub

#End Region

    Friend Function GetIndividuen() As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
        'Purpose: Get all records of table BBIND
        'Author:  Nancy Coppens - 02/03/2007
        'Remark: when you execute this code through a webservice, this action takes 45 seconds
        '        => to work more performant, we have chosen to use a DataAdapter

        Dim winPrinc As WindowsPrincipal
        Dim t As Thread

        Try
            Me.SqlConnectionBBW.ConnectionString = _
                ADF.Configuration.ConfigurationSettings.Databases.Item("SQLConnection").ConnectionString

            If myImp.impersonateValidUser("MgrBBW", "DOSIM000", "usr4WBB#") Then

                winPrinc = New WindowsPrincipal(WindowsIdentity.GetCurrent)
                t = System.Threading.Thread.CurrentThread
                't.ApartmentState = ApartmentState.STA
                t.SetApartmentState(ApartmentState.STA)
                Thread.CurrentPrincipal = winPrinc

            End If

            Dim ds As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
            SqlDataAdapterBBIND.SelectCommand.CommandType = CommandType.StoredProcedure
            SqlDataAdapterBBIND.SelectCommand.CommandText = "[USP_BBW_GET_ALL_BBIND]"

            Me.SqlDataAdapterBBIND.Fill(ds, "BBIND")

            Return ds
        Catch ex As Exception
            Throw
        Finally
            Try
                myImp.undoImpersonation()
            Catch ex As Exception
            End Try
        End Try

    End Function
End Class
