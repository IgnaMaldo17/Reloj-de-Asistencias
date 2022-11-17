Public Class EUSR
    Private _USR_ID As Integer
    Private _USR_NIC As String
    Private _USR_APE As String
    Private _USR_NOM As String
    Private _USR_PAS As String
    Private _USR_CRE_ID As Integer
    Private _USR_BAJ_ID As Integer

    Public Property USR_ID As Integer
        Get
            Return _USR_ID
        End Get
        Set(value As Integer)
            _USR_ID = value
        End Set
    End Property

    Public Property USR_NIC As String
        Get
            Return _USR_NIC
        End Get
        Set(value As String)
            _USR_NIC = value
        End Set
    End Property

    Public Property USR_APE As String
        Get
            Return _USR_APE
        End Get
        Set(value As String)
            _USR_APE = value
        End Set
    End Property

    Public Property USR_NOM As String
        Get
            Return _USR_NOM
        End Get
        Set(value As String)
            _USR_NOM = value
        End Set
    End Property

    Public Property USR_PAS As String
        Get
            Return _USR_PAS
        End Get
        Set(value As String)
            _USR_PAS = value
        End Set
    End Property

    Public Property USR_CRE_ID As Integer
        Get
            Return _USR_CRE_ID
        End Get
        Set(value As Integer)
            _USR_CRE_ID = value
        End Set
    End Property

    Public Property USR_BAJ_ID As Integer
        Get
            Return _USR_BAJ_ID
        End Get
        Set(value As Integer)
            _USR_BAJ_ID = value
        End Set
    End Property
End Class
