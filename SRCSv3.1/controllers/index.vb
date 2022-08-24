Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports System.Data.OleDb

Module index

#Region "Flags"
    <Flags>
    Public Enum ContactGender
        Male
        Female
    End Enum
    Public Enum DialogRole
        [New]
        Edit
    End Enum
    Public Enum scoreUpdateType
        uScoreDetails
        uScoreValues
    End Enum



    Public Enum ContactTitle
        None
        Dr
        Miss
        Mr
        Mrs
        Ms
        Prof
    End Enum
#End Region

#Region "Random Functions"
    Public Function createTileItem(itemName As String) As TileBarItem
        Dim tile As New TileBarItem
        tile.AppearanceItem.Selected.BackColor = Color.CornflowerBlue
        tile.AppearanceItem.Hovered.BackColor = Color.Aqua
        tile.AppearanceItem.Pressed.BackColor = Color.CornflowerBlue
        Dim tileItemElement As New TileItemElement
        tileItemElement.Text = itemName ' "Form Teacher: " + _class.FormTeacher
        tile.Name = itemName
        tileItemElement.TextAlignment = TileItemContentAlignment.MiddleCenter
        tileItemElement.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        tileItemElement.Appearance.Normal.Font = New Font("Segoe UI Light", 11, FontStyle.Bold)

        tile.Elements.Add(tileItemElement)
        tile.TextAlignment = TileItemContentAlignment.MiddleCenter
        Return tile
    End Function

    Public Function wordedPosition(ByVal position As String) As String

        If position.EndsWith("1") Then
            If position = "11" Then
                Return position + "th"
            End If
            Return position + "st"

        End If

        If position.EndsWith("2") Then
            If position = "12" Then
                Return position + "th"
            End If
            Return position + "nd"
        End If

        If position.EndsWith("3") Then
            If position = "13" Then
                Return position + "th"
            End If
            Return position + "rd"
        End If

        Return position + "th"
    End Function

    Public Sub InitPersonComboBox(ByVal edit As RepositoryItemImageComboBox)
        Dim iCollection As New ImageCollection
        iCollection.AddImage(My.Resources.Mr)
        iCollection.AddImage(My.Resources.Ms)
        edit.Items.Add(New ImageComboBoxItem(My.Resources.Male, ContactGender.Male, 0))
        edit.Items.Add(New ImageComboBoxItem(My.Resources.Female, ContactGender.Female, 1))
        edit.SmallImages = iCollection
    End Sub
#End Region

#Region "Wait Dialog"
    Enum sWaitDlgStatus
        Show = 0
        Hide = 1
    End Enum
    Private dlg As DevExpress.Utils.WaitDialogForm = Nothing
    Public Sub WaitDlg(ByVal sStatus As sWaitDlgStatus,
                       Optional ByVal Caption As String = "Loading Default Settings...",
                       Optional ByVal Title As String = "Wait")
        Try
            Select Case sStatus
                Case sWaitDlgStatus.Show
                    If Not dlg Is Nothing Then
                        dlg.Dispose()
                        dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                    ElseIf dlg Is Nothing Then
                        dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                        dlg.SetCaption(Caption)
                        dlg.Show()
                    End If
                Case sWaitDlgStatus.Hide
                    dlg.Dispose()

            End Select
            'Application.DoEvents()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ShowAlertForm(alertOwnerForm As Form, caption As String, alertmessage As String)
        Dim alert As New DevExpress.XtraBars.Alerter.AlertControl
        alert.Show(alertOwnerForm, caption, alertmessage, True)
    End Sub
#End Region
#Region "Oledb"
    Public con As New OleDbConnection
    Public Sub conn()

        Try

            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\db.accdb")

            con.Open()

        Catch ex As Exception

        End Try
    End Sub
#End Region
End Module
Public Class ValidationRulesHelper
    Private Shared ruleIsNotBlank_Renamed As ConditionValidationRule = Nothing
    Public Shared ReadOnly Property RuleIsNotBlank() As ConditionValidationRule
        Get
            If ruleIsNotBlank_Renamed Is Nothing Then
                ruleIsNotBlank_Renamed = New ConditionValidationRule()
                ruleIsNotBlank_Renamed.ConditionOperator = ConditionOperator.IsNotBlank
                ruleIsNotBlank_Renamed.ErrorText = My.Resources.RuleIsNotBlankWarning
                ruleIsNotBlank_Renamed.ErrorType = ErrorType.Critical
            End If
            Return ruleIsNotBlank_Renamed
        End Get
    End Property
End Class
Public Class BaseSRCSModule
    Inherits DevExpress.XtraEditors.XtraUserControl
    Public Overridable Sub refreshData()
        MyBase.Refresh()
    End Sub
End Class