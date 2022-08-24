Public Interface ISessionSettings
    Property sessionID As String
    Property academicSession As String
    Property term As String
    Property nextTermBegins As Date
    Property nextTermEnds As Date
    Property noOfDaysSchOpen As Integer
End Interface

Public Interface ISchoolSettings
    Property sessionID As String
    Property schName As String
    Property schAddress As String
    Property schMotto As String
    Property schContact As String
    Property SchEmail As String
    Property facebook As String
    Property twitter As String
    Property website As String
    Property linkedIn As String
    Property schLogo As Image
End Interface
Public Interface IReportSettings
    Property assScore As Integer
    Property testScore As Integer
    Property examScore As Integer
    Property totalScore As Integer
    Property redMarkPercentage As Integer
    Property showPosition As Boolean
    Property useRedMark As DevExpress.Utils.DefaultBoolean
    Property showScoreMaxOnSheet As DevExpress.Utils.DefaultBoolean
End Interface

Public Interface IAdmission
    Property IDInitial As String
End Interface


Public Interface ISettingsController
#Region "schoolController"
    Sub updateSchoolSettings(schoolSettings As SchoolSettings)
    Sub updateSchoolSettingsSessionIDByID(sessionID As String)
    Function getSchoolSettings() As SchoolSettings

#End Region


#Region "sessionController"
    Sub addDefaultYearTerm(year As String, term As String, nextTermBegins As Date, Optional noOfDaysSchOpen As Integer = 1)
    Sub addSession(session As SessionSettings)
    Sub updateSession(session As SessionSettings)
    Sub deleteSession(sessionID As String)
    Function CurrentSession(Optional year As String = "", Optional term As String = "") As SessionSettings
    Function getAllSessions() As List(Of SessionSettings)
    Function getSessionSettingsBySessionID(SessionID As String) As SessionSettings
#End Region

#Region "admissionController"
    Sub updateAdmissionNumberInitial(initial As String, sessionID As String)
    Function getAdmissionSettings() As AdmissionSettings
#End Region

#Region "report controller"
    Function getReportSettings() As ReportSettings

    Sub updateReportSettings(reportSettings As ReportSettings)
#End Region

End Interface