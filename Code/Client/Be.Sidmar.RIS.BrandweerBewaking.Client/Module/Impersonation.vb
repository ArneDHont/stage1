Imports System.Security.Principal
Imports System.Runtime.InteropServices

Public Class Impersonation

    Const SecurityImpersonation As Integer = 2

    Dim LOGON32_LOGON_INTERACTIVE As Integer = 2
    Dim LOGON32_PROVIDER_DEFAULT As Integer = 0

    Dim impersonationContext As WindowsImpersonationContext

    Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As String, ByVal lpszDomain As String, ByVal lpszPassword As String, ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, ByRef phToken As IntPtr) As Integer
    Declare Auto Function DuplicateToken Lib "advapi32.dll" (ByVal ExistingTokenHandle As IntPtr, ByVal ImpersonationLevel As Integer, ByRef DuplicateTokenHandle As IntPtr) As Integer

    Public Function impersonateValidUser(ByVal userName As String, ByVal domain As String, ByVal password As String) As Boolean

        Dim tempWindowsIdentity As WindowsIdentity
        Dim token As IntPtr
        Dim tokenDuplicate As IntPtr

        Addresult(("Before impersonation: " + WindowsIdentity.GetCurrent().Name))

        If LogonUser(userName, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, token) <> 0 Then

            If DuplicateToken(token, 2, tokenDuplicate) <> 0 Then

                tempWindowsIdentity = New WindowsIdentity(tokenDuplicate)
                impersonationContext = tempWindowsIdentity.Impersonate()

                If impersonationContext Is Nothing Then
                    impersonateValidUser = False
                Else
                    impersonateValidUser = True
                End If

            Else
                impersonateValidUser = False
            End If

        Else

            Dim ret As Integer = Marshal.GetLastWin32Error()

            Debug.WriteLine(String.Format("LogonUser failed with error code : {0}", ret))
            Debug.WriteLine(ControlChars.Cr + String.Format("Error: [{0}] {1}" + ControlChars.Cr, ret, GetErrorMessage(ret)))
            impersonateValidUser = False

        End If

        Addresult(("After impersonation: " + WindowsIdentity.GetCurrent().Name))

    End Function

    Public Sub undoImpersonation()
        impersonationContext.Undo()
    End Sub

    <DllImport("kernel32.dll")> _
  Public Shared Function FormatMessage(ByVal dwFlags As Integer, ByRef lpSource As IntPtr, ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByRef lpBuffer As [String], _
      ByVal nSize As Integer, ByRef Arguments As IntPtr) As Integer
    End Function

    Public Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal handle As IntPtr) As Boolean

    Public Shared Function GetErrorMessage(ByVal errorCode As Integer) As String

        Dim FORMAT_MESSAGE_ALLOCATE_BUFFER As Integer = &H100
        Dim FORMAT_MESSAGE_IGNORE_INSERTS As Integer = &H200
        Dim FORMAT_MESSAGE_FROM_SYSTEM As Integer = &H1000

        Dim messageSize As Integer = 255
        Dim lpMsgBuf As String = ""
        Dim dwFlags As Integer = FORMAT_MESSAGE_ALLOCATE_BUFFER Or FORMAT_MESSAGE_FROM_SYSTEM Or FORMAT_MESSAGE_IGNORE_INSERTS

        Dim ptrlpSource As IntPtr = IntPtr.Zero
        Dim prtArguments As IntPtr = IntPtr.Zero

        Dim retVal As Integer = FormatMessage(dwFlags, ptrlpSource, errorCode, 0, lpMsgBuf, messageSize, prtArguments)

        If 0 = retVal Then
            Throw New Exception("Failed to format message for error code " + errorCode.ToString() + ". ")
        End If

        Return lpMsgBuf

    End Function 'GetErrorMessage

    Function DoImpersonateAction(ByVal Username As String, ByVal Domain As String, ByVal Password As String) As Boolean

        Dim tokenHandle As New IntPtr(0)
        Dim dupeTokenHandle As New IntPtr(0)

        Addresult(("Before Action: " + WindowsIdentity.GetCurrent().Name))
        DoImpersonateAction = False

        Try
            ' Call LogonUser to obtain a handle to an access token.
            Dim returnValue As Boolean = LogonUser(Username, Domain, Password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, tokenHandle)

            Addresult("LogonUser called.")

            If False = returnValue Then

                Dim ret As Integer = Marshal.GetLastWin32Error()
                Addresult(String.Format("LogonUser failed with error code : {0}", ret))
                Addresult(ControlChars.Cr + String.Format("Error: [{0}] {1}" + ControlChars.Cr, ret, GetErrorMessage(ret)))
                Exit Function

            End If

            Dim success As String

            If returnValue Then success = "Yes" Else success = "No"
            Addresult(("Did LogonUser succeed? " + success))
            Addresult(("Value of Windows NT token: " + tokenHandle.ToString()))

            ' Check the identity.
            Addresult(("Before impersonation: " + WindowsIdentity.GetCurrent().Name))

            Dim retVal As Boolean = DuplicateToken(tokenHandle, SecurityImpersonation, dupeTokenHandle)

            If False = retVal Then

                CloseHandle(tokenHandle)
                Addresult("Exception thrown in trying to duplicate token.")
                Exit Function

            End If

            ' TThe token that is passed to the following constructor must 
            ' be a primary token in order to use it for impersonation.
            Dim newId As New WindowsIdentity(dupeTokenHandle)
            Dim impersonatedUser As WindowsImpersonationContext = newId.Impersonate()

            ' Check the identity.
            Addresult(("After impersonation: " + WindowsIdentity.GetCurrent().Name))

            'DoImpersonateAction = DoAction()

            ' Stop impersonating the user.
            impersonatedUser.Undo()

            ' Check the identity.
            Addresult(("After Undo: " + WindowsIdentity.GetCurrent().Name))

            ' Free the tokens.
            If Not System.IntPtr.op_Equality(tokenHandle, IntPtr.Zero) Then
                CloseHandle(tokenHandle)
            End If

            If Not System.IntPtr.op_Equality(dupeTokenHandle, IntPtr.Zero) Then
                CloseHandle(dupeTokenHandle)
            End If

        Catch ex As Exception

            Addresult(("Exception occurred. " + ex.Message))
        End Try

    End Function

    Private Sub Addresult(ByVal message As String)
        Debug.WriteLine(message)
    End Sub

End Class
