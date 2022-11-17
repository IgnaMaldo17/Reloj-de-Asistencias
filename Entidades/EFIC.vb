Public Class EFIC
    Private _FIC_EMP_ID As Integer
    Private _FIC_ALT_PC As String

    Public Property FIC_EMP_ID As Integer
        Get
            Return _FIC_EMP_ID
        End Get
        Set(value As Integer)
            _FIC_EMP_ID = value
        End Set
    End Property

    Public Property FIC_ALT_PC As String
        Get
            Return _FIC_ALT_PC
        End Get
        Set(value As String)
            _FIC_ALT_PC = value
        End Set
    End Property
End Class
