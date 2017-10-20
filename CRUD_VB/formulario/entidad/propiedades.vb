Public Class propiedades

    Public idalu As Integer
    Public Property _idalu() As Integer
        Get
            Return idalu
        End Get
        Set(ByVal value As Integer)
            idalu = value
        End Set
    End Property

    Private nomalu As String
    Public Property _nomalu() As String
        Get
            Return nomalu
        End Get
        Set(ByVal value As String)
            nomalu = value
        End Set
    End Property

    Private apealu As String
    Public Property _apealu() As String
        Get
            Return apealu
        End Get
        Set(ByVal value As String)
            apealu = value
        End Set
    End Property

    Private dnialu As String
    Public Property _dnialu() As String
        Get
            Return dnialu
        End Get
        Set(ByVal value As String)
            dnialu = value
        End Set
    End Property

End Class
