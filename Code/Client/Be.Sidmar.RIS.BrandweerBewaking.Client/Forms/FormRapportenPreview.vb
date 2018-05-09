Option Infer On

Imports System.Windows.Forms
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Configuration

Public Class FormRapportenPreview
    Inherits Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents WinFormWebBrowser As System.Windows.Forms.WebBrowser

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.WinFormWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout
        '
        'WinFormWebBrowser
        '
        Me.WinFormWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinFormWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WinFormWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WinFormWebBrowser.Name = "WinFormWebBrowser"
        Me.WinFormWebBrowser.Size = New System.Drawing.Size(952, 574)
        Me.WinFormWebBrowser.TabIndex = 0
        '
        'FormRapportenPreview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 574)
        Me.Controls.Add(Me.WinFormWebBrowser)
        Me.Name = "FormRapportenPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapporten"
        Me.ResumeLayout(false)

End Sub

#End Region

#Region "Properties"
    Private _InterventieID As Long

    Public Property InterventieID() As Long
        Get
            Return Me._InterventieID
        End Get
        Set(ByVal Value As Long)
            Me._InterventieID = Value
        End Set
    End Property
#End Region



    Public Sub ToonRapport(ByVal folderRapport As String, ByVal naamRapport As String, _
                           Optional ByVal aParameterNaam1 As String = "", Optional ByVal aParameterValue1 As String = "", _
                           Optional ByVal aParameterNaam2 As String = "", Optional ByVal aParameterValue2 As String = "", _
                           Optional ByVal aParameterNaam3 As String = "", Optional ByVal aParameterValue3 As String = "")
        'Doel:         rapport tonen op scherm in Webbrowser
        'Auteur:       Hugo Meeusen - 26/04/2006
        'Aanpassingen: Nancy Coppens - 29/06/2006 => folderRapport en naamRapport doorgeven
        'Parameters:   we gaan er van uit dat er maximum 3 parameters zijn op een rapport
        '              als er geen parameters zijn, is aParameterNaam1 leeg
        'Opmerking:    rapporten kan je opvragen via deze url: http://reporting-dvlp.sidmar.agn/REPORTS

        Try

            'zo was het oorspronkelijk: alles hard gecodeerd
            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "InterventieBrandweer")
            'report.AddParameter("ID_INTV_BRDW", Me.InterventieID)

            Dim report As New ADF.Reporting.SRS.UrlAccess.Report(folderRapport, naamRapport)

            'Eventuele parameters doorgeven (niet alle rapporten hebben parameters)
            If aParameterNaam1 <> "" Then
                report.AddParameter(aParameterNaam1, aParameterValue1)

                If aParameterNaam2 <> "" Then
                    report.AddParameter(aParameterNaam2, aParameterValue2)

                    If aParameterNaam3 <> "" Then
                        report.AddParameter(aParameterNaam3, aParameterValue3)
                    End If
                End If
            End If


            'Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri(report.Url)
            Me.WinFormWebBrowser.Navigate( New Uri(report.Url))
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormRapportenPreview - ToonRapport" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' Rapport Brandweer interventie exporteren naar PDF.
    ''' Dit is nodig om het rapport te kunnen doormailen.
    ''' </summary>
    ''' <param name="folderRapport">folderRapport = /GENT/PLANT/PEB/BBW/</param>
    ''' <param name="naamRapport">Naam van het rapport.</param>
    ''' <param name="pathPdfFile">pathPDFfiles = bv. "c:\BBW\Registratie\"</param>
    ''' <param name="pInterventieId">Id van de interventie.</param>
    ''' <remarks>
    ''' Auteur: Nancy Coppens - 15/09/2006 (code gekregen van Hugo Meeusen - 26/04/2006)
    '''         Geert Maertens - 02/07/2013 (code voor oproep via ADF verwijderd, rechtstreekse implementatie)
    ''' </remarks>
    Public Sub ExportPdfBrandweerInterventie(ByVal folderRapport As String, ByVal naamRapport As String, _
                                             ByVal pathPdfFile As String, ByVal pInterventieId As String)
        Try
            Dim params As New Hashtable
            params.Add("ID_INTV_BRDW", pInterventieId)

            ExportPdfBewakingRegistratie(folderRapport, naamRapport, pathPdfFile, params)

            ' Gebruik niet langer de ADF routines!
            ' ------------------------------------
            'If Microsoft.VisualBasic.Right(folderRapport, 1) = "/" Then
            '    'bv. /GENT/PLANT/PEB/BBW/
            'Else
            '    folderRapport = folderRapport & "/" 'bv. /GENT/PLANT/PEB/BBW
            'End If

            'Dim proxy As New ADF.Reporting.SRS.SRSReport.Proxy.SQLReportServiceProxy
            'proxy.Render(folderRapport & naamRapport, pathPDFfile, _
            '             ADF.Reporting.SRS.Design.eFormat.PDF, params)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormRapportenPreview - ExportPDFBrandweerInterventie" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    ''' <summary>
    ''' Rapport Bewaking registratie exporteren naar PDF.
    ''' Dit is nodig om het rapport te kunnen doormailen.
    ''' </summary>
    ''' <param name="folderRapport">folderRapport = /GENT/PLANT/PEB/BBW/</param>
    ''' <param name="naamRapport">Naam van het rapport.</param>
    ''' <param name="pathPdfFile">folderPDFfiles = bv. "c:\BBW\Registratie\"</param>
    ''' <param name="params">Lijst met alle eventuele parameters.</param>
    ''' <remarks>
    ''' Auteur: Nancy Coppens - 15/09/2006 (code gekregen van Hugo Meeusen - 26/04/2006)
    '''         Geert Maertens - 02/07/2013 (code voor oproep via ADF verwijderd, rechtstreekse implementatie)
    ''' </remarks>
    Public Overloads Sub ExportPdfBewakingRegistratie(ByVal folderRapport As String, ByVal naamRapport As String,
                                                      ByVal pathPdfFile As String, ByVal params As Hashtable)
        Try
            If Not folderRapport.EndsWith("/") Then
                folderRapport += "/"
            End If

            ' Create the URI
            ' --------------
            Dim source = New StringBuilder()
            source.Append(ConfigurationManager.AppSettings("ReportServer"))
            source.Append(folderRapport)
            source.Append(naamRapport)
            'source.Append("&rs:Command=Render&rc:Toolbar=false&rs:Format=PDF")
            source.Append("&rs:Command=Render&rc:Toolbar=false&rs:Format=PDF&rs:ParameterLanguage=nl-BE")

            For Each key In params.Keys
                source.AppendFormat("&{0}={1}", key, params(key))
            Next

            ' Create directory - if it already exists the method does nothing
            Directory.CreateDirectory(Path.GetDirectoryName(pathPdfFile))

            ' Get the Graph from SSRS
            ' -----------------------
            Dim request = WebRequest.Create(source.ToString())
            request.Credentials = CredentialCache.DefaultCredentials
            request.Timeout = 1000000 ' = ten times the default for a HttpWebRequest

            Using response = request.GetResponse(), targetFile = File.Create(pathPdfFile)
                Debug.Assert(response.ContentType = "application/pdf")
                Debug.Assert(response.IsMutuallyAuthenticated)

                CopyBinaryStream(response.GetResponseStream(), targetFile)
            End Using

            ' Gebruik niet langer de ADF routines!
            ' ------------------------------------
            'Dim proxy As New ADF.Reporting.SRS.SRSReport.Proxy.SQLReportServiceProxy
            'proxy.Render(folderRapport & naamRapport, pathPDFfile, _
            '             ADF.Reporting.SRS.Design.eFormat.PDF, params)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormRapportenPreview - ExportPDFBewakingRegistratie" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace,
                            "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try

    End Sub

    ''' <summary>
    ''' Copy the complete content of a binary stream.
    ''' </summary>
    ''' <param name="source">The source stream.</param>
    ''' <param name="target">The target stream.</param>
    ''' <remarks>Geert Maertens - 2 juli 2013</remarks>
    Private Shared Sub CopyBinaryStream(ByVal source As Stream, ByVal target As Stream)

        Using graph = New BinaryReader(source),
              result = New BinaryWriter(target)

            Do
                Dim b = graph.ReadBytes(1024)
                If b.Length = 0 Then Exit Do
                result.Write(b)
            Loop
        End Using
    End Sub


    Public Overloads Sub ExportPDFBewakingRegistratie(ByVal folderRapport As String, ByVal naamRapport As String, _
                                            ByVal pathPDFfile As String, ByVal pRegistratieID As Long)

        'Siddien - 28 dec 2006 - aangepast voor dagverslag inlichtingen
        Dim params As New Hashtable

        Try
            params.Add("ID_REG", pRegistratieID)

            Me.ExportPdfBewakingRegistratie(folderRapport, naamRapport, pathPDFfile, params)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormRapportenPreview - ExportPDFBewakingRegistratie" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    ' Geert Maertens- 2 juli 2013 - deze functie wordt nergens gebruikt
    '
    'Public Sub ExportPDF()
    '    'Doel: rapport exporteren naar PDF
    '    '      dit is nodig om het rapport te kunnen doormailen
    '    'Auteur: Hugo Meeusen - 26/04/2006
    '    'Opmerking: is voorbeeld-code => wordt niet meer gebruikt

    '    Dim proxy As New ADF.Reporting.SRS.SRSReport.Proxy.SQLReportServiceProxy

    '    Dim params As New Hashtable
    '    params.Add("ID_INTV_BRDW", Me.InterventieID)

    '    proxy.Render("/GENT/PLANT/PEB/BBW/InterventieBrandweer", "c:\BBW\Interventie" & Me.InterventieID & ".pdf", _
    '                 ADF.Reporting.SRS.Design.eFormat.PDF, params)
    'End Sub

    Public Sub Print(ByVal folderRapport As String, ByVal naamRapport As String, ByVal naamPrinter As String, ByVal orientatie As ADF.Reporting.SRS.Design.eOrientation, ByVal dubbelzijdig As Boolean)
        'Doel: rapport exporteren naar printer
        'Auteur: Hugo Meeusen - 04/07/2006
        'Parameters: folderRapport = bv. /RIS/BMA
        '            naamRapport = bv. JaarrapportBlustoestelAfdType
        '            naamPrinter = bv. \\PSMSC010\PRISMBV1
        '            orientatie  = bv. ADF.Reporting.SRS.Design.eOrientation.landscape
        '            dubbelzijdig= bv. true
        'Opmerking: is voorbeeld-code => wordt niet meer gebruikt

        Dim proxy As New ADF.Reporting.SRS.SRSReport.Proxy.SQLReportServiceProxy


        Dim params As New Hashtable
        params.Add("ID_INTV_BRDW", Me.InterventieID)

        proxy.ToPrinter(folderRapport & "/" & naamRapport, naamPrinter, orientatie, dubbelzijdig)
    End Sub



End Class
