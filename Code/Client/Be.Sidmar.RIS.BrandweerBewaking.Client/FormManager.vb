Option Explicit On 
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Forms.Brandweer
Imports System.Windows.Forms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Forms.Bewaking


Public Class FormManager
    Inherits ADF.Presentation.Windows.Forms.FormManagerBase

    Private Shared _current As FormManager

    Private Sub New(ByVal parent As Form)
        MyBase.New(parent)
        _current = Me
    End Sub

    Public Property DataIndividuen() As DataSet

    Public Property DataIndividuen_Bestemmelingen() As Client.TDSIndividuen

    Public Property DataConfiguration() As DataSet

    Public Property PostOverste() As Boolean

    Public Property CanInvalidateReport() As Boolean

    Public Property BbwVerantwoordelijke() As Boolean

    Public Property BbwMilieuDienst() As Boolean

    Public Property Brandweer() As Boolean

    Public Property Bewaking() As Boolean

    Public Property Diefstal() As Boolean

    Public Property Snelheid() As Boolean

    Public Property Chip() As Boolean

    Public Property IKPvtw() As Boolean 'naco - 30/11/2012 - Inkoop verantwoordelijke


#Region " Static Methods "
    Public Shared ReadOnly Property Current() As FormManager
        Get
            Return _current
        End Get
    End Property

    Public Shared Function Create(Optional ByVal parent As Form = Nothing) As FormManager
        If (_current Is Nothing) Then
            _current = New FormManager(parent)
            Client2.FormManager.Create(parent)
        End If
        Return _current
    End Function

    Public Shared Sub Release()
        _current = Nothing
    End Sub
#End Region

    'TO DO 1. Add methods to open forms
    'Example:
#Region "Brandweer"
    Public Sub OpenFormNieuweBrandweerInterventies(ByVal modal As Boolean,
                                                   ByVal asSingleton As Boolean,
                                                   ByVal asMDIChild As Boolean,
                                                   ByVal interventieType As Integer,
                                                   ByVal interventieOmschrijving As String,
                                                   ByVal idInterventie As Integer)
        'Parameter: idInterventie = -1 => nieuw
        '           idInterventie <> -1 => bestaande wijzigen
        Try
            OpenChildForm(GetType(FormBrandweerInterventie), modal, asSingleton, asMDIChild, interventieType, interventieOmschrijving, idInterventie)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormManager - OpenFormNieuweBrandweerInterventies: " & vbCrLf & ex.Message & vbCrLf & "InnerException:" & vbCrLf & ex.InnerException.ToString, "Fout in BBW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Public Sub OpenFormBrandweerDienstverslag(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerDienstverslag), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormDienstverslagOverzicht(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Client2.FormManager.Current.OpenFormDienstverslagOverzicht(modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBrandweerMaandrapport(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerMaandrapport), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBrandweerjaarrapport(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerJaarrapport), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBrandweerOverzichtInterventies(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerOverzichtInterventies), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBrandweerOverzichtMilieuverontreinigingen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerMilieuverontreinigingen), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormMateriaalOpLocatie(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerMateriaalOpLocatie), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormMateriaalOpLocatieAfdeling(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerAfdelingMateriaal), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBrandweerVerzendingen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerVerzendingen), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBrandweerOverzichtStock(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerOverzichtStock), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBeheerAMC(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBeheerAMC), modal, asSingleton, asMDIChild)
    End Sub
#End Region
#Region "Bewaking"

    Public Sub OpenFormOverzichtBewakingRegistratieEntity(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingRegistratieOverzicht), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormNieuweBewakingRegistratieEntity(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        'OpenChildForm(GetType(FormBewakingRegistratie), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBewakingDienstverslagEntity(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingDienstverslag), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBewakingMaandrapport(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingMaandrapport), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBewakingjaarrapport(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingJaarrapport), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormAanrijding(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingAanrijding), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormAlcoholtest(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingAlcoholtest), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormControleVoertuigen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingControleVoertuigen), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormDiefstal(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingDiefstal), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormDiverseRegistratie(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingDiverseRegistratie), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormInbreukReglementen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingInbreukReglementen), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormOpenmakenKleerkast(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingOpenmakenKleerkast), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormSchadegeval(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingSchadegeval), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub

    Public Sub OpenFormDagVerslagPersoneelOverzicht(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormDagVerslagPersoneelOverzicht), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformDagVerslagInlichtingen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormDagverslagInlichtingenOverzicht), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformMaandrapportInbreuken(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingMaandInbrRegl), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformDiefstalPerTrimester(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingTrimesterDiefstal), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformSnelheidsovertredingen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingSnelheidsovertredingen), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformOvertredingen(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingOvertredingReglement), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformInkoop(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingInkoop), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformIKP_NaarCHIP(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingIKP_VinkjeCHIP), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformInkoopBrandweer(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBrandweerInkoop), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformBewakingIKP_VinkjeCHIP(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingIKP_VinkjeCHIP), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBewakingMilieuVerslag(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormBewakingMilieuVerslag), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenFormBewakingMilieuVerontreiniging(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean, Optional ByVal idRegistratie As Integer = -1)
        OpenChildForm(GetType(FormBewakingMilieuVerslag), modal, asSingleton, asMDIChild, idRegistratie)
    End Sub
#End Region

#Region "Codetabellen"
    Public Sub OpenFormCodetabellenEntity(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormCodetabellen), modal, asSingleton, asMDIChild)
    End Sub

    Public Sub OpenformCodeTablesBM(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormCodetablesBMat), modal, asSingleton, asMDIChild)
    End Sub
#End Region

#Region "UpdateFirma"
    Public Sub OpenFormUpdateFirma(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormUpdateFirmaBBW), modal, asSingleton, asMDIChild)
    End Sub
#End Region

End Class
