Public Class ESEC
    Private SEC_ID As Integer
    Private SEC_NOM As String
    Private SEC_CRE_DAT As DateTime
    Private SEC_CRE_ID As Integer
    Private SEC_BAJ_DAT As DateTime
    Private SEC_BAJ_ID As Integer

    Public Property SEC_ID1 As Integer
        Get
            Return SEC_ID
        End Get
        Set(value As Integer)
            SEC_ID = value
        End Set
    End Property

    Public Property SEC_NOM1 As String
        Get
            Return SEC_NOM
        End Get
        Set(value As String)
            SEC_NOM = value
        End Set
    End Property

    Public Property SEC_CRE_DAT1 As Date
        Get
            Return SEC_CRE_DAT
        End Get
        Set(value As Date)
            SEC_CRE_DAT = value
        End Set
    End Property

    Public Property SEC_CRE_ID1 As Integer
        Get
            Return SEC_CRE_ID
        End Get
        Set(value As Integer)
            SEC_CRE_ID = value
        End Set
    End Property

    Public Property SEC_BAJ_DAT1 As Date
        Get
            Return SEC_BAJ_DAT
        End Get
        Set(value As Date)
            SEC_BAJ_DAT = value
        End Set
    End Property

    Public Property SEC_BAJ_ID1 As Integer
        Get
            Return SEC_BAJ_ID
        End Get
        Set(value As Integer)
            SEC_BAJ_ID = value
        End Set
    End Property
End Class
