'Auteur: Siddien
'Datum: okt. 2006
'Doel: bijhouden van mailserver en mailing functie centraliseren
Imports System.IO

Public Class MailBBW

    Private Const FromMailAddress As String = "bbw_appl@sidmar.arcelor.com"
    Private Const FromMailAddressCHIP As String = "bbw_appl@arcelormittal.com"
    Private Shared _mailServer As ADF.Mail.SmtpServer


    Public Shared Sub sendMail(ByVal mailTo As ArrayList, _
                               ByVal aText As String, _
                               ByVal subject As String, _
                               ByVal pathAttach As ArrayList)
        Try
            Dim arrResizedImages As New ArrayList

            If _mailServer Is Nothing Then
                Dim dataConfiguratie As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
                dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))


                _mailServer = New ADF.Mail.SmtpServer(dataConfiguratie.BBCONF.FindByGR_SLESLE("Algemeen", "Mailserver").WD)
            End If

            Dim aMail As New ADF.Mail.SmtpMail
            Dim mailString As String = ""

            For Each adres As String In mailTo
                mailString &= adres & ";"
            Next

            mailString = mailString.Remove(mailString.LastIndexOf(";"), 1)

            'If Not pathAttach = "" Then
            'aMail.Attachements.Add(pathAttach)
            'End If
            '17/12/2006 - Nancy Coppens - meerdere attachments kunnen toevoegen
            '29/12/2006 -DIEN - attachments verkleinen
            Dim pathBijlageResized As String

            For Each pathBijlage As String In pathAttach
                pathBijlageResized = pathBijlage

                If isFoto(pathBijlage) = True Then
                    'Indien de foto > 20 kb --> resizen
                    Dim oFileSize As New FileInfo(pathBijlage)
                    If oFileSize.Length() > 20000 Then
                        'nieuwe file aanmaken en na het versturen terug verwijderen
                        ImageResizer.resizeImage(pathBijlage, pathBijlageResized)
                        arrResizedImages.Add(pathBijlageResized)
                    End If
                End If


                aMail.Attachements.Add(pathBijlageResized)


            Next

            'aMail.To = mailTo
            aMail.To = mailString
            aMail.Importance = ADF.Mail.SmtpMail.Priority.High
            aMail.Subject = subject
            aMail.Body = aText
            aMail.From = FromMailAddress

            _mailServer.Connect()
            _mailServer.Send(aMail)
            _mailServer.Disconnect()

            'Verwijderen van verkleinde foto's
            Dim teVerwijderenImage As String
            For Each teVerwijderenImage In arrResizedImages
                File.Delete(teVerwijderenImage)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Send mail to PEB if no contact person for a SAP firm is found
    ''' </summary>
    ''' <param name="aID_SAP_FRM">nr firma SAP</param>
    ''' <param name="aNM_SAP_FRM">naam firma SAP</param>
    ''' <remarks>naco - 12/09/2016</remarks>
    Public Shared Sub SendMail_CHIP_NoContactPersonFound(ByVal aID_SAP_FRM As Integer, ByVal aNM_SAP_FRM As String)

        Try
            Dim dataConfiguratie As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
            dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))

            If _mailServer Is Nothing Then
                _mailServer = New ADF.Mail.SmtpServer(dataConfiguratie.BBCONF.FindByGR_SLESLE("Algemeen", "Mailserver").WD)
            End If

            Dim aMail As New ADF.Mail.SmtpMail
            Dim mailString As String = dataConfiguratie.BBCONF.FindByGR_SLESLE("CHIP", "WarningMail_SAPFirmNoEmailContact").WD

            aMail.To = mailString
            aMail.Importance = ADF.Mail.SmtpMail.Priority.High
            aMail.Subject = "BBW -> CHIP: geen contactpersoon gevonden voor firma " & aID_SAP_FRM & " - " & aNM_SAP_FRM
            aMail.Body = "Beste," & vbCrLf & vbCrLf &
                         "voor deze firma " & aID_SAP_FRM & " - " & aNM_SAP_FRM & vbCrLf &
                         "is geen contactpersoon gevonden in SAP." & vbCrLf & vbCrLf &
                         "Gelieve na te zien in SAP aub." & vbCrLf & vbCrLf & vbCrLf &
                         "Opm: dit is een automatische mail vanuit de BBW toepassing." & vbCrLf &
                         "Op deze mail kan geen reply gegeven worden."

            aMail.From = FromMailAddressCHIP

            _mailServer.Connect()
            _mailServer.Send(aMail)
            _mailServer.Disconnect()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' mail sturen naar contactpersoon externe firma met pdf (voor CHIP)
    ''' </summary>
    ''' <param name="mailTo"></param>
    ''' <param name="aText"></param>
    ''' <param name="aSubject"></param>
    ''' <remarks>naco - 12/09/2016</remarks>
    Public Shared Sub sendMailCHIP_ContactPerson(ByVal mailTo As String, _
                           ByVal aText As String, _
                           ByVal aSubject As String, _
                           ByVal pathdPDFfile As String)
        Try
            Dim arrResizedImages As New ArrayList
            Dim mailToPEB As String = mailTo

            Dim dataConfiguratie As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
            dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
            If _mailServer Is Nothing Then
                _mailServer = New ADF.Mail.SmtpServer(dataConfiguratie.BBCONF.FindByGR_SLESLE("Algemeen", "Mailserver").WD)
            End If

            Dim aMail As New ADF.Mail.SmtpMail

            aMail.Attachements.Add(pathdPDFfile)
            aMail.To = mailToPEB
            aMail.Bcc = "eddy.vanrenterghem@arcelormittal.com;hans.devijlder@arcelormittal.com;nancy.coppens@arcelormittal.com"
            'tijdelijk sept 2016 - testen welke mails naar de firma's zullen worden verstuurd (automatisch CHIP)
            '03/10/2016 - opstarten: mails naar firma's sturen (na testperiode sept 2016)
            aMail.Importance = ADF.Mail.SmtpMail.Priority.Normal
            aMail.Subject = aSubject
            aMail.Body = "Automatische mail vanuit toepassing BBW - Brandweer Bewaking (ArcelorMittal Gent) " & vbCrLf &
                         "---------------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                         aText & vbCrLf & vbCrLf &
                         "Opm: dit is een automatische mail vanuit de BBW toepassing (CHIP)." & vbCrLf &
                         "Op deze mail kan geen reply gegeven worden."

            '03/10/2016 - in dienst gaan
            '& vbCrLf & vbCrLf & vbCrLf &
            '"Voor vragen i.v.m. verslag, gelieve contact op te nemen met de bewaking van ArcelorMittal Gent - tel 09/347 36 90" & vbCrLf & vbCrLf &
            '"----------------------------------------------" & vbCrLf &
            '"september 2016 - testfase - mail zal in toekomst gestuurd worden naar: " & mailToPEB

            aMail.From = FromMailAddressCHIP

            _mailServer.Connect()
            _mailServer.Send(aMail)
            _mailServer.Disconnect()

            'Verwijderen van verkleinde foto's
            Dim teVerwijderenImage As String
            For Each teVerwijderenImage In arrResizedImages
                File.Delete(teVerwijderenImage)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' mail sturen naar contactpersoon externe firma met pdf (voor CHIP)
    ''' </summary>
    ''' <param name="mailTo"></param>
    ''' <param name="aText"></param>
    ''' <param name="aSubject"></param>
    ''' <remarks>naco - 12/09/2016</remarks>
    Public Shared Sub sendMailCHIP_ContactPerson_Translate(ByVal mailTo As String, _
                           ByVal aText As String, _
                           ByVal aSubject As String, _
                           ByVal pathdPDFfile As String,
                           ByVal aLanguage As String)

        Try

            Dim arrResizedImages As New ArrayList
            Dim mailToPEB As String = mailTo

            Dim dataConfiguratie As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
            dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
            If _mailServer Is Nothing Then
                _mailServer = New ADF.Mail.SmtpServer(dataConfiguratie.BBCONF.FindByGR_SLESLE("Algemeen", "Mailserver").WD)
            End If

            Dim aMail As New ADF.Mail.SmtpMail

            aMail.Attachements.Add(pathdPDFfile)
            aMail.To = mailToPEB
            aMail.Bcc = "eddy.vanrenterghem@arcelormittal.com;hans.devijlder@arcelormittal.com;nancy.coppens@arcelormittal.com"
            'tijdelijk sept 2016 - testen welke mails naar de firma's zullen worden verstuurd (automatisch CHIP)
            '03/10/2016 - opstarten: mails naar firma's sturen (na testperiode sept 2016)
            aMail.Importance = ADF.Mail.SmtpMail.Priority.Normal

            'subject
            '-------
            'AM Gent - Verslag bewaking (inbreuk regl) -
            Select Case aLanguage
                Case "NL"
                Case "EN"
                    aSubject = Replace(aSubject, "Verslag bewaking", "Registration security")
                Case "FR"
                    aSubject = Replace(aSubject, "Verslag bewaking", "Inscription surveillance")
                Case "DU"
                    aSubject = Replace(aSubject, "Verslag bewaking", "Registrierung Überwachung")
            End Select

            aMail.Subject = aSubject

            'text (body)
            '-----------
            Dim strDear As String = "Geachte"
            Dim strNewRegistration As String = "Er is een nieuwe registratie bewaking aangemaakt"
            Dim strDate As String = "Datum registratie:"
            Dim strType As String = "Registratietype:"
            Dim strPlace As String = "Plaats:"
            Dim strShortDescr As String = "Korte omschr:"
            Dim strNr As String = "Verslagnummer:"
            Dim strComposer As String = "Opsteller:"

            Select Case aLanguage
                Case "NL"
                Case "EN"
                    aText = Replace(aText, strDear, "Dear")
                    aText = Replace(aText, strNewRegistration, "A new registration is made by the security department")
                    aText = Replace(aText, strDate, "Date registration:")
                    aText = Replace(aText, strType, "Kind of registration:")
                    aText = Replace(aText, strPlace, "Place:")
                    aText = Replace(aText, strShortDescr, "Short description:")
                    aText = Replace(aText, strNr, "Nr registration:")
                    aText = Replace(aText, strComposer, "Written by:")

                Case "FR"
                    aText = Replace(aText, strDear, "Aux principaux concernés")
                    aText = Replace(aText, strNewRegistration, "Il y a une nouvelle inscription faite par le surveillance")
                    aText = Replace(aText, strDate, "Date d'enregistrement:")
                    aText = Replace(aText, strType, "Type d'enregistrement:")
                    aText = Replace(aText, strPlace, "Place:")
                    aText = Replace(aText, strShortDescr, "Brève description:")
                    aText = Replace(aText, strNr, "Numéro de rapport:")
                    aText = Replace(aText, strComposer, "Compositeur:")

                Case "DU"
                    aText = Replace(aText, strDear, "Am besten")
                    aText = Replace(aText, strNewRegistration, "Es gibt eine neue Registrierung gemacht durch die Überwachung")
                    aText = Replace(aText, strDate, "Datum:")
                    aText = Replace(aText, strType, "Art:")
                    aText = Replace(aText, strPlace, "Platz:")
                    aText = Replace(aText, strShortDescr, "Kurzbeschreibung:")
                    aText = Replace(aText, strNr, "Identifizierung:")
                    aText = Replace(aText, strComposer, "Zusammengestellt von:")

            End Select

            'text rond body
            '--------------
            Select Case aLanguage
                Case "NL"
                    aMail.Body = "Automatische mail vanuit toepassing BBW - Brandweer Bewaking (ArcelorMittal Gent) " & vbCrLf &
                    "---------------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                    aText & vbCrLf & vbCrLf &
                    "Opm: dit is een automatische mail vanuit de BBW toepassing (CHIP)." & vbCrLf & "Op deze mail kan geen reply gegeven worden."

                Case "EN"
                    aMail.Body = "Automatic mail from application BBW - Brandweer Bewaking (ArcelorMittal Gent) " & vbCrLf &
                    "---------------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                    aText & vbCrLf & vbCrLf &
                    "Remarkt: this is an automatic mail (application BBW - CHIP)." & vbCrLf & "Reply cannot be given to this mail."

                Case "FR"
                    aMail.Body = "Mail automatique de l'application BBW - Brandweer Bewaking (ArcelorMittal Gent) " & vbCrLf &
                     "---------------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                     aText & vbCrLf & vbCrLf &
                     "Remarque: mail automatique (application BBW - CHIP)." & vbCrLf & "On ne peut pas répondre à ce message."

                Case "DU"
                    aMail.Body = "Automatische mail vanuit toepassing BBW - Brandweer Bewaking (ArcelorMittal Gent) " & vbCrLf &
                     "---------------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                     aText & vbCrLf & vbCrLf &
                     "Bemerkung: dies ist eine automatische Mail (Anwendung BBW - CHIP)." & vbCrLf & "Man kann sich nicht auf diese E-Mail antworten."

            End Select


            '03/10/2016 - in dienst gaan
            '& vbCrLf & vbCrLf & vbCrLf &
            '"Voor vragen i.v.m. verslag, gelieve contact op te nemen met de bewaking van ArcelorMittal Gent - tel 09/347 36 90" & vbCrLf & vbCrLf &
            '"----------------------------------------------" & vbCrLf &
            '"september 2016 - testfase - mail zal in toekomst gestuurd worden naar: " & mailToPEB

            aMail.From = FromMailAddressCHIP

            _mailServer.Connect()
            _mailServer.Send(aMail)
            _mailServer.Disconnect()

            'Verwijderen van verkleinde foto's
            Dim teVerwijderenImage As String
            For Each teVerwijderenImage In arrResizedImages
                File.Delete(teVerwijderenImage)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Shared Function isFoto(ByVal pathBijlage As String) As Boolean
        Dim extensie As String = pathBijlage.Substring(pathBijlage.LastIndexOf("."))
        Select Case extensie
            Case ".gif", ".jpg", ".jpeg", ".bmp"
                Return True
            Case Else
                Return False
        End Select
    End Function

End Class
