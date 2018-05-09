Option Explicit On
Option Infer On

Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Linq

Public Class HRMdata
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - lawv - 28/02/2011</remarks>
    Public Function GetFirma() As DataSet

        Dim wsFirma As New Proxy.HRMservice.Firma.Services
        wsFirma.Url = ADF.Configuration.ConfigurationSettings.UsedWebServices.Item("HRMServiceFirma").URL

        Dim dsFirma As New DataSet

        Try

            dsFirma.Merge(wsFirma.GetListFirma)

            Return dsFirma

        Catch ex As Exception
            Throw
        End Try

    End Function

    ''' <summary>
    ''' Get email-contacts of a SAP Firm nr - necessary to send automatically mail
    ''' </summary>
    ''' <param name="aID_FRM"></param>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens/Bart Bories - maart 2017</remarks>
    Public Shared Function GetSAPFirm_EmailContact_Firma(ByVal aID_FRM As Integer) As String

        Try

            'Dim strMailAddressesFirm As String = ""

            ''Bart Bories - 07/03/2017
            ''------------------------
            ''Nancy,
            ''Zoals daarnet besproken is er een nieuwe method aangemaakt in de firma service.
            ''http://wffrsqa.sidmar.be/HRMService.Firma/Services.asmx?op=GetCompanyWithEmailAddresses
            ''http://wffrsprod.sidmar.be/HRMService.Firma/Services.asmx?op=GetCompanyWithEmailAddresses

            ''Input: FirmaNr
            ''Output: Firma met lijst van Applicaties en bijhorend emailadres.

            'Dim ws As New Proxy.FRSService.Firma.Services
            'Dim resultMailsFirma As Proxy.FRSService.Firma.CompanyWithEmailAddresses = ws.GetCompanyWithEmailAddresses(aID_FRM)

            ''indien meerdere mail-adressen => gescheiden door ;
            'Dim BBWresult = resultMailsFirma.EmailAddresses.Where(Function(r) r.ApplicationDescription.ToUpper = "BBW")
            ''As Proxy.FRSService.Firma.EmailAddresses()
            ''Dim intCount As Integer = BBWresult.

            'For Each BBWmail As Proxy.FRSService.Firma.EmailAddresses In BBWresult
            '    strMailAddressesFirm = BBWresult.First.EmailAddress
            'Next

            ''If intCount > 0 Then
            ''    strMailAddressesFirm = BBWresult.First.EmailAddress
            ''Else 'als geen email-adressen gevonden voor applicatie BBW => zoeken naar email-adresse voor applicatie Default
            ''    Dim DefaultFirm = resultMailsFirma.EmailAddresses.Where(Function(r) r.ApplicationDescription.ToUpper = "DEFAULT")
            ''    If DefaultFirm.Count > 0 Then
            ''        strMailAddressesFirm = DefaultFirm.First.EmailAddress
            ''    End If
            ''End If

            'Return strMailAddressesFirm

            '-----------------------------
            Dim strMailAddressesFirm As String = ""

            'Bart Bories - 07/03/2017
            '------------------------
            'Nancy,
            'Zoals daarnet besproken is er een nieuwe method aangemaakt in de firma service.
            'http://wffrsqa.sidmar.be/HRMService.Firma/Services.asmx?op=GetCompanyWithEmailAddresses
            'http://wffrsprod.sidmar.be/HRMService.Firma/Services.asmx?op=GetCompanyWithEmailAddresses

            'Input: FirmaNr
            'Output: Firma met lijst van Applicaties en bijhorend emailadres.

            Dim ws As New FirmaService.Services()
            Dim resultMailsFirma As FirmaService.CompanyWithEmailAddresses = ws.GetCompanyWithEmailAddresses(aID_FRM)

            If resultMailsFirma Is Nothing Then
                Return strMailAddressesFirm 'return lege string
            Else

                'indien meerdere mail-adressen => gescheiden door ;
                Dim BBW = resultMailsFirma.EmailAddresses.Where(Function(r) r.ApplicationDescription.ToUpper = "BBW")
                If BBW.Count > 0 Then
                    strMailAddressesFirm = BBW.First.EmailAddress
                Else 'als geen email-adressen gevonden voor applicatie BBW => zoeken naar email-adresse voor applicatie Default
                    Dim DefaultFirm = resultMailsFirma.EmailAddresses.Where(Function(r) r.ApplicationDescription.ToUpper = "DEFAULT")
                    If DefaultFirm.Count > 0 Then
                        strMailAddressesFirm = DefaultFirm.First.EmailAddress
                    End If
                End If

                Return strMailAddressesFirm
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class
