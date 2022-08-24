Imports System.ComponentModel

Public Class indexForm
    Private control_ As BaseSRCSModule
    Private sender_ As BaseSRCSModule
    Public Sub New(sender As BaseSRCSModule, control As BaseSRCSModule)
        ' This call is required by the designer.
        InitializeComponent()
        sender_ = sender
        control_ = control
        control_.Dock = DockStyle.Fill
        Me.Controls.Add(control_)
    End Sub

    Private Sub indexForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        sender_.refreshData()
    End Sub
End Class