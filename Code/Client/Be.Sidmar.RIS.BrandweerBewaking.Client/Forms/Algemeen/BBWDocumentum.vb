Imports System.IO
Imports System.Windows.Forms

Public Class BBWDocumentum

    Public Shared Function UploadFileDocumentum(ByVal filePath As String, ByVal titel As String, ByVal objectname As String, ByVal documentumFolderPath As String) As String
        'Doel:   Uploaden van de bijlage behorende bij een verslag in documentum. 
        '       We krijgen van documentum een uniek ChronicleID te
        'Auteur: Mieke Duynslager - juli 2007

        Try
            Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Dim fileExtension As String = Path.GetExtension(filePath)
            Dim chronicleID As String
            Dim documentumService As New Proxy.BBWServiceDocumentumServicesProxy
            Dim content As Byte()
            Dim contentType As String
            Dim user As String = System.Environment.UserName
            ReDim content(fs.Length)

            'Read block of bytes from stream into the byte array
            fs.Read(content, 0, System.Convert.ToInt32(fs.Length))

            'Close the File Stream
            fs.Close()

            Select Case UCase(fileExtension)
                Case ".JPG"
                    contentType = "jpeg"
                Case ".PDF"
                    contentType = "pdf"
                Case ".DOC"
                    contentType = "msw8"
                Case ".BMP"
                    contentType = "bmp"
                Case ".XLS"
                    contentType = "excel8book"
                Case ".TXT"
                    contentType = "text"
                Case ".HTM"
                    contentType = "html"
                Case ".RTF"
                    contentType = "rtf"
                Case ".XML"
                    contentType = "xml"
                Case Else
                    MsgBox("De extensie van het document: ('" & fileExtension & "') is niet gekend in documentum." & vbCrLf & _
                        "Het document kan niet worden opgeladen.", MsgBoxStyle.Information, "Bijlage naar Documentum")
                    Return ""
            End Select

            'Retourneren van het chronicleID van documentum
            chronicleID = documentumService.ImportDocumentDirect(objectname, content, contentType, documentumFolderPath, user, titel, "NL")
            'Het documentumteam beweert dat we er alleen mogen vanuit gaan dat wanneer we bij de import een string terugkrijgen van
            '16 karakters lang dit een correct chronicleID is. 
            If Len(chronicleID) = 16 Then
                Return chronicleID
            Else
                MessageBox.Show("Er is een fout opgetreden bij het importeren van de bijlage naar documentum", _
                            "BBW Brandweer Bewaking Verslagen", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show("Er is een fout opgetreden bij het importeren van de bijlage naar documentum:  " & vbCrLf & _
                            "Class: BBWDocumentum - UploadFileDocumentum" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ""
        End Try
    End Function

    Public Shared Sub DeleteFileDocumentum(ByVal chronicleID As String)
        'Doel:   Verwijderen van de bijlage in documentum
        'Auteur: DUMI - Juli 2007
        'Bij het verwijderen van één of meerdere bijlagen uit de grid, de chronicle id(s) bijhouden in een array
        'en vervolgens bij bewaren één voor één verwijderen uit documentum.
        'delete
        Dim documentumService As New Proxy.BBWServiceDocumentumServicesProxy
        Dim user As String = System.Environment.UserName

        Try
            documentumService.DeleteDocument(chronicleID, user)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Er is een fout opgetreden bij het verwijderen van de bijlage in Documentum", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class
