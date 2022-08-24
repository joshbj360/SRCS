
Imports DevExpress.Utils
Imports SRCSv3._1

Public Class SessionSettings
    Implements ISessionSettings

    Private academicSession_, term_, sessionID_ As String
    Private nextTermBegins_, nextTermEnds_ As Date
    Private noOfDaysSchOpen_ As Integer
    Public Sub New()
        Try
            Dim filePath As String = Application.StartupPath + "\db\config.txt"
            Dim sessionDict As New Dictionary(Of String, String)
            Dim allSessionsDict() As String = IO.File.ReadAllLines(filePath)
            'MsgBox(filePath)
            For Each line As String In allSessionsDict

                Dim a() As String = line.Split(","c)
                'sessionDict.Add(a(0), a(1))
                academicSession_ = a(0)
                term = a(1)
                noOfDaysSchOpen_ = CInt(a(3))

                sessionID_ = String.Format("{0}/{1}", academicSession_, term.Replace(" ", ""))

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub New(ByVal settingRow As DataRow)
        sessionID_ = String.Format("{0}", settingRow("sessionID"))
        academicSession_ = String.Format("{0}", settingRow("schYear"))
        term_ = String.Format("{0}", settingRow("schTerm"))
        nextTermBegins_ = CDate(String.Format("{0}", settingRow("nextTermBegins"))) ' setting("nextTermBegins")))
        nextTermEnds_ = CDate(String.Format("{0}", settingRow("nextTermEnd")))
        noOfDaysSchOpen_ = CInt(settingRow("noOfDaysSchOpen"))
    End Sub

    Public Property academicSession As String Implements ISessionSettings.academicSession
        Get
            Return academicSession_
        End Get
        Set(value As String)
            academicSession_ = value
        End Set
    End Property

    Public Property nextTermBegins As Date Implements ISessionSettings.nextTermBegins
        Get
            Return nextTermBegins_
        End Get
        Set(value As Date)
            nextTermBegins_ = value
        End Set
    End Property

    Public Property nextTermEnds As Date Implements ISessionSettings.nextTermEnds
        Get
            Return nextTermEnds_
        End Get
        Set(value As Date)
            nextTermEnds_ = value
        End Set
    End Property

    Public Property sessionID As String Implements ISessionSettings.sessionID
        Get
            Return sessionID_
        End Get
        Set(value As String)
            sessionID_ = value
        End Set
    End Property

    Public Property term As String Implements ISessionSettings.term
        Get
            Return term_
        End Get
        Set(value As String)
            term_ = value
        End Set
    End Property
    Public Property noOfDaysSchOpen As Integer Implements ISessionSettings.noOfDaysSchOpen
        Get
            Return noOfDaysSchOpen_
        End Get
        Set(value As Integer)
            noOfDaysSchOpen_ = value
        End Set
    End Property
End Class
Public Class SchoolSettings
    Implements ISchoolSettings

    Private sessionID_, noOfDaysSchOpen_, schAddress_, schContact_, schMotto_, schName_, SchEmail_,
             facebook_, twitter_, website_, linkedIn_ As String
    Private schLogo_ As Image
    Public Sub New()
    End Sub
    Public Sub New(dataRow As DataRow)
        sessionID_ = String.Format("{0}", dataRow("sessionID"))
        schAddress_ = String.Format("{0}", dataRow("SchAddress"))
        schContact_ = String.Format("{0}", dataRow("SchContactNo"))
        SchEmail_ = String.Format("{0}", dataRow("SchEmail"))
        '  schLogo_ = dataRow("SchLogo"))
        schMotto_ = String.Format("{0}", dataRow("SchMotto"))
        schName_ = String.Format("{0}", dataRow("SchName"))
        facebook_ = String.Format("{0}", dataRow("SchFacebook"))
        twitter_ = String.Format("{0}", dataRow("SchTwitter"))
        website_ = String.Format("{0}", dataRow("SchWebsite"))
        linkedIn_ = String.Format("{0}", dataRow("SchLinkedIn"))
    End Sub

    Public Property schAddress As String Implements ISchoolSettings.schAddress
        Get
            Return schAddress_
        End Get
        Set(value As String)
            schAddress_ = value
        End Set
    End Property

    Public Property schContact As String Implements ISchoolSettings.schContact
        Get
            Return schContact_
        End Get
        Set(value As String)
            schContact_ = value
        End Set
    End Property

    Public Property SchEmail As String Implements ISchoolSettings.SchEmail
        Get
            Return SchEmail_
        End Get
        Set(value As String)
            SchEmail_ = value
        End Set
    End Property

    Public Property schLogo As Image Implements ISchoolSettings.schLogo
        Get
            Return schLogo_
        End Get
        Set(value As Image)
            schLogo_ = value
        End Set
    End Property

    Public Property schMotto As String Implements ISchoolSettings.schMotto
        Get
            Return schMotto_
        End Get
        Set(value As String)
            schMotto_ = value
        End Set
    End Property

    Public Property schName As String Implements ISchoolSettings.schName
        Get
            Return schName_
        End Get
        Set(value As String)
            schName_ = value
        End Set
    End Property

    Public Property sessionID As String Implements ISchoolSettings.sessionID
        Get
            Return sessionID_
        End Get
        Set(value As String)
            sessionID_ = value
        End Set
    End Property

    Public Property facebook As String Implements ISchoolSettings.facebook
        Get
            Return facebook_
        End Get
        Set(value As String)
            facebook_ = value
        End Set
    End Property

    Public Property twitter As String Implements ISchoolSettings.twitter
        Get
            Return twitter_
        End Get
        Set(value As String)
            twitter_ = value
        End Set
    End Property

    Public Property website As String Implements ISchoolSettings.website
        Get
            Return website_
        End Get
        Set(value As String)
            website_ = value
        End Set
    End Property

    Public Property linkedIn As String Implements ISchoolSettings.linkedIn
        Get
            Return linkedIn_
        End Get
        Set(value As String)
            linkedIn_ = value
        End Set
    End Property
End Class
Public Class AdmissionSettings
    Implements IAdmission
    Private initialID_ As String

    Public Sub New(datarow As DataRow)
        initialID_ = String.Format("{0}", datarow("IDInitial"))
    End Sub
    Public Property IDInitial As String Implements IAdmission.IDInitial
        Get
            Return initialID_
        End Get
        Set(value As String)
            initialID_ = value
        End Set
    End Property
End Class

Public Class ReportSettings
    Implements IReportSettings

    Private dAssScore, dTestScore, dExamScore, dTotalScore, redMarkPercentage_, id_ As Integer
    Private showPosition_, useRedMark_, showScoreMaxOnSheet_ As DefaultBoolean
    Public Sub New()

    End Sub
    Public Sub New(sets As DataRow)
        dAssScore = CInt(String.Format("{0}", sets("assScore")))
        id_ = CInt(String.Format("{0}", sets("ID")))
        dTestScore = CInt(String.Format("{0}", sets("testScore")))
        dExamScore = CInt(String.Format("{0}", sets("examScore")))
        dTotalScore = CInt(String.Format("{0}", sets("totalScore")))
        redMarkPercentage_ = CInt(String.Format("{0}", sets("redMarkPercentage")))
        showPosition_ = CType(sets("showPosition"), DefaultBoolean)
        useRedMark_ = CType(sets("useRedMark"), DefaultBoolean)
        showScoreMaxOnSheet_ = CType(sets("showScoreMaxOnSheet"), DefaultBoolean)
    End Sub
    Public Property assScore As Integer Implements IReportSettings.assScore
        Get
            Return dAssScore
        End Get
        Set(value As Integer)
            dAssScore = value
        End Set
    End Property

    Public Property examScore As Integer Implements IReportSettings.examScore
        Get
            Return dExamScore
        End Get
        Set(value As Integer)
            dExamScore = value
        End Set
    End Property
    Public Property redMarkPercentage As Integer Implements IReportSettings.redMarkPercentage
        Get
            Return redMarkPercentage_
        End Get
        Set(value As Integer)
            redMarkPercentage_ = value
        End Set
    End Property

    Public Property showPosition As Boolean Implements IReportSettings.showPosition
        Get
            Return showPosition_
        End Get
        Set(value As Boolean)
            showPosition_ = value
        End Set
    End Property

    Public Property showScoreMaxOnSheet As DefaultBoolean Implements IReportSettings.showScoreMaxOnSheet
        Get
            Return showScoreMaxOnSheet_
        End Get
        Set(value As DefaultBoolean)
            showScoreMaxOnSheet_ = value
        End Set
    End Property

    Public Property testScore As Integer Implements IReportSettings.testScore
        Get
            Return dTestScore
        End Get
        Set(value As Integer)
            dTestScore = value
        End Set
    End Property

    Public Property totalScore As Integer Implements IReportSettings.totalScore
        Get
            Return dTotalScore
        End Get
        Set(value As Integer)
            dTotalScore = value
        End Set
    End Property

    Public Property useRedMark As DefaultBoolean Implements IReportSettings.useRedMark
        Get
            Return useRedMark_
        End Get
        Set(value As DefaultBoolean)
            useRedMark_ = value
        End Set
    End Property
End Class