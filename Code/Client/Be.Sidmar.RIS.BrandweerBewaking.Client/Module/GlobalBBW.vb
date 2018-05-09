Module GlobalBBW

    Public Function IsReportInvalid(ByVal idReg As Integer) As Boolean
        Dim proxy As New Proxy.BBWServiceManagementServicesProxy
        Return proxy.IsReportInvalid(idReg)
    End Function

End Module
