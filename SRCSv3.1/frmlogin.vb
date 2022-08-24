Imports DevExpress.LookAndFeel
Imports System.Data.OleDb
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Public Class frmlogin
    Dim cmd As New OleDbCommand
    Dim max, j As Integer
    Dim both, uid, pw As Integer
    Dim i As Integer = 1
    Public user As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        LabelControl4.Text = "Copyright(c) 2015 - " + Today.Year.ToString
        GlobalCurrentSession = DefaultCurrentSession
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet

        If (txtusername.Text = "" Or txtpassword.Text = "") Then
            XtraMessageBox.Show("Username or Password is Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
        Else
            Try
                WaitDlg(sWaitDlgStatus.Show)
                cmd = New OleDbCommand("select count(*) from userTable where [username]='" + txtusername.Text + "'", con)
                Dim no As Integer = cmd.ExecuteScalar
                If no > 0 Then
                    da = New OleDbDataAdapter("select * from userTable where [username]='" + txtusername.Text + "'", con)
                    da.Fill(ds, "user")
                    If txtpassword.Text = ds.Tables("user").Rows(0).Item("password").ToString Then
                        ActiveUser = userController_.getAllUsers.FirstOrDefault(Function(x) (x.userName = txtusername.Text) And (x.password = txtpassword.Text))
                        '   MsgBox(ActiveUser.fullName)
                    Else
                        XtraMessageBox.Show("Incorrect UserName or Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtpassword.Text = ""
                        txtpassword.Focus()
                        Exit Sub
                    End If
                    logged()
                    WaitDlg(sWaitDlgStatus.Hide)
                ElseIf (no = 0) Then
                    XtraMessageBox.Show("Incorrect UserName or Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusername.Focus()
                    txtusername.SelectAll()

                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Function IsFirstRun() As Boolean
        Dim filePath As String = Application.StartupPath + "\db\FirstConfig.txt"
        Dim sessionDict As New Dictionary(Of String, String)
        Dim allSessionsDict() As String = IO.File.ReadAllLines(filePath)
        Dim IsFirstRun_ As String = ""
        For Each line As String In allSessionsDict
            Dim a() As String = line.Split(","c)
            'sessionDict.Add(a(0), a(1))
            IsFirstRun_ = a(0)
        Next
        Return CBool(IsFirstRun_)
    End Function
    Private Sub WirteIsFirstRun(Value As String)
        Dim filePath As String = Application.StartupPath + "\db\FirstConfig.txt"
        Dim writer As IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter(filePath, False)
        writer.WriteLine(String.Format("{0},", Value))
        writer.Close()
    End Sub
    Public Sub logged()
        Dim dte As Date = Today.Date
        Dim tme As Date = Now.TimeOfDay.ToString

        Try
            cmd = New OleDbCommand("insert into userLogTable (u_name,dte,tme) values('" & txtusername.Text & "','" & dte & "','" & tme & "')", con)
            cmd.ExecuteNonQuery()
            If IsFirstRun() Or CheckEdit1.Checked Then
                setupDashboard.Show()
                WirteIsFirstRun("False")
            Else
                MainForm.Show()
            End If

        Catch ex As Exception

        End Try

        ' XtraMessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn()
        Dim _blankContextMenu As New ContextMenu()
        txtpassword.ContextMenu = _blankContextMenu
        txtusername.ContextMenu = _blankContextMenu

    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub frmlogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' MainForm.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 14

        If i > 64 Then
            MainForm.Show()
            '   process.Close()
            'MainForm.Enabled = True
            'MainForm.Opacity = 100%
            Timer1.Stop()

            Me.Close()
        End If
    End Sub

End Class