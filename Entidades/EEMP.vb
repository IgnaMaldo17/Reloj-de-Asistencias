Public Class EEMP
    Dim _EMP_ID As Integer
    Dim _EMP_DNI As Integer
    Dim _EMP_APE As String
    Dim _EMP_NOM As String
    Dim _EMP_DIR As String
    Dim _EMP_SEC_ID As Integer
    Dim _EMP_DAT_NAC As Date
    Dim _EMP_CRE_DAT As DateTime
    Dim _EMP_CRE_ID As Integer
    Dim _EMP_ID2 As Integer

    Public Property EMP_ID As Integer
        Get
            Return _EMP_ID
        End Get
        Set(value As Integer)
            _EMP_ID = value
        End Set
    End Property

    Public Property EMP_DNI As Integer
        Get
            Return _EMP_DNI
        End Get
        Set(value As Integer)
            _EMP_DNI = value
        End Set
    End Property

    Public Property EMP_APE As String
        Get
            Return _EMP_APE
        End Get
        Set(value As String)
            _EMP_APE = value
        End Set
    End Property

    Public Property EMP_NOM As String
        Get
            Return _EMP_NOM
        End Get
        Set(value As String)
            _EMP_NOM = value
        End Set
    End Property

    Public Property EMP_DIR As String
        Get
            Return _EMP_DIR
        End Get
        Set(value As String)
            _EMP_DIR = value
        End Set
    End Property

    Public Property EMP_SEC_ID As Integer
        Get
            Return _EMP_SEC_ID
        End Get
        Set(value As Integer)
            _EMP_SEC_ID = value
        End Set
    End Property

    Public Property EMP_DAT_NAC As Date
        Get
            Return _EMP_DAT_NAC
        End Get
        Set(value As Date)
            _EMP_DAT_NAC = value
        End Set
    End Property

    Public Property EMP_CRE_DAT As Date
        Get
            Return _EMP_CRE_DAT
        End Get
        Set(value As Date)
            _EMP_CRE_DAT = value
        End Set
    End Property

    Public Property EMP_CRE_ID As Integer
        Get
            Return _EMP_CRE_ID
        End Get
        Set(value As Integer)
            _EMP_CRE_ID = value
        End Set
    End Property


End Class
