Imports SRCSv3._1
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraGrid.Views.Grid.GridView
Public Class testForm
    'Dim WithEvents Button As IClass = New MyButton
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'Button.Parent = Me
        ' Add any initialization after the InitializeComponent() call.
        Dim s As New settingsView
        s.Dock = DockStyle.Fill
        PanelControl1.Controls.Add(s)

    End Sub
    '    Public Sub ClickEventHandler(sender As Object, e As EventArgs) Handles Button.Click
    '        MsgBox("pip solo")
    '    End Sub

    '    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    '    End Sub
End Class
'Public Interface IClass
'    Event Click(ByVal sender As Object, e As EventArgs)
'    Property Parent
'End Interface
'Public Class MyButton
'    Inherits Button
'    Implements IClass

'    Private Property IClass_Parent As Object Implements IClass.Parent
'        Get
'            Return MyBase.Parent
'        End Get
'        Set(value As Object)
'            MyBase.Parent = value
'        End Set
'    End Property

'    Private Event IClass_Click(sender As Object, e As EventArgs) Implements IClass.Click
'    Private Sub myButton_click(sender As Object, e As EventArgs) Handles Me.Click
'        RaiseEvent IClass_Click(sender, e)
'    End Sub
'End Class