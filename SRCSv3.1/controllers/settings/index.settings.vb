Module indexSettings
    Public setsController As SettingsController = New SettingsController
    Public admController As AdmissionSettings = setsController.getAdmissionSettings

    ''This DefaultCurrentSession variable only gets refreshed when the app is
    '' restarted. It loads its data from the config.txt file.
    Public DefaultCurrentSession As SessionSettings = New SessionSettings

    Private _currentSession As SessionSettings
    ''' <summary>
    ''' GlobalCurrentSession temporary holds the session settings when there is a session or term change.
    ''' It can be used globally throughout the app.
    ''' It should not be changed anywhere in the app, except at SessionSetupView module.
    ''' </summary>
    ''' <returns></returns>
    Public Property GlobalCurrentSession As SessionSettings
        Get
            Return _currentSession
        End Get
        Set(value As SessionSettings)
            _currentSession = value
        End Set
    End Property
End Module
