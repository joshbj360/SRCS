Imports SRCSv3._1

Public Class SettingsController
    Implements ISettingsController

#Region "school settings"

    Public Sub updateSchoolSettings(sch As SchoolSettings) Implements ISettingsController.updateSchoolSettings
        Dim da As New dbDataSetTableAdapters.schoolSettingsTableTableAdapter
        da.UpdateSchSettingsBySessinoID(sch.schName,
                                        sch.schAddress,
                                        sch.schMotto,
                                        sch.SchEmail,
                                        sch.schContact,
                                        sch.website,
                                        sch.facebook,
                                        sch.twitter,
                                        sch.linkedIn,
                                        sch.sessionID
                                        )
        MsgBox("updated")
    End Sub
    Public Sub updateSchoolSettingsSessionIDByID(sessionID As String) Implements ISettingsController.updateSchoolSettingsSessionIDByID
        Dim da As New dbDataSetTableAdapters.schoolSettingsTableTableAdapter
        da.UpdateSessionIDByID(sessionID, 1)
    End Sub
    Public Function getSchoolSettings() As SchoolSettings Implements ISettingsController.getSchoolSettings
        Dim da As dbDataSetTableAdapters.schoolSettingsTableTableAdapter = New dbDataSetTableAdapters.schoolSettingsTableTableAdapter
        Return New SchoolSettings(da.GetData.FirstOrDefault)
    End Function

#End Region

#Region "Session Settings"
    Public Sub addDefaultYearTerm(
                                 year As String,
                                 term As String,
                                 nextTermBegins As Date,
                                 Optional noOfDaysSchOpen As Integer = 1
                                 ) Implements ISettingsController.addDefaultYearTerm
        Dim filePath As String = Application.StartupPath + "\db\config.txt"
        Dim writer As IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter(filePath, False)
        writer.WriteLine(String.Format("{0},{1},{2}", year, term, noOfDaysSchOpen))
        writer.Close()
    End Sub
    Public Sub addSession(session As SessionSettings) Implements ISettingsController.addSession
        Dim da As New dbDataSetTableAdapters.sessionSettingsTableTableAdapter
        deleteSession(session.sessionID)
        da.Insert(
        session.academicSession,
        session.nextTermBegins,
        session.term,
        session.nextTermEnds,
        session.sessionID,
        session.noOfDaysSchOpen
        )


    End Sub
    Public Sub deleteSession(sessionID As String) Implements ISettingsController.deleteSession
        Dim da As New dbDataSetTableAdapters.sessionSettingsTableTableAdapter
        da.Delete(sessionID)
    End Sub
    Public Sub updateSession(session As SessionSettings) Implements ISettingsController.updateSession
        Dim da As New dbDataSetTableAdapters.sessionSettingsTableTableAdapter
    End Sub
    Public Function CurrentSession(Optional year As String = "", Optional term As String = "") As SessionSettings Implements ISettingsController.CurrentSession

        Return getAllSessions.FirstOrDefault(Function(x) x.academicSession = year And x.term = term)
    End Function
    Public Function getAllSessions() As List(Of SessionSettings) Implements ISettingsController.getAllSessions
        Dim ss As List(Of SessionSettings) = New List(Of SessionSettings)
        Dim da As New dbDataSetTableAdapters.sessionSettingsTableTableAdapter
        For Each row As dbDataSet.sessionSettingsTableRow In da.GetData.Rows

            ss.Add(New SessionSettings(row))
        Next
        Return ss
        '' MsgBox(ss.Count)
    End Function
    Public Function getSessionSettingsBySessionID(SessionID As String) As SessionSettings Implements ISettingsController.getSessionSettingsBySessionID
        Return getAllSessions.FirstOrDefault(Function(x) x.sessionID = SessionID)
    End Function
#End Region

#Region "report settings"
    Public Function getReportSettings() As ReportSettings Implements ISettingsController.getReportSettings
        Dim da As New dbDataSetTableAdapters.reportSettingsTableAdapter
        Dim allReportSettings As New List(Of ReportSettings)
        For Each row As dbDataSet.reportSettingsRow In da.GetData.Rows
            allReportSettings.Add(New ReportSettings(row))
        Next

        Return allReportSettings.FirstOrDefault
    End Function



    Public Sub updateReportSettings(reportSettings As ReportSettings) Implements ISettingsController.updateReportSettings
        Dim da As New dbDataSetTableAdapters.reportSettingsTableAdapter

        da.UpdateQueryByID(
            reportSettings.assScore.ToString,
            reportSettings.testScore,
            reportSettings.examScore,
            reportSettings.totalScore,
            reportSettings.redMarkPercentage,
            reportSettings.showPosition,
            CBool(reportSettings.useRedMark),
            CBool(reportSettings.showScoreMaxOnSheet)
        )

    End Sub
#End Region

#Region "admission settings"

    Public Function getAdmissionSettings() As AdmissionSettings Implements ISettingsController.getAdmissionSettings
        Dim da As dbDataSetTableAdapters.schoolSettingsTableTableAdapter = New dbDataSetTableAdapters.schoolSettingsTableTableAdapter
        Dim setting As AdmissionSettings = New AdmissionSettings(da.GetData.FirstOrDefault)
        Return setting
    End Function

    Public Sub updateAdmissionNumberInitial(initial As String, sessionID As String) Implements ISettingsController.updateAdmissionNumberInitial
        Dim da As New dbDataSetTableAdapters.schoolSettingsTableTableAdapter
        da.UpdateIDInitialBySessionID(initial, sessionID)
    End Sub



#End Region
End Class
