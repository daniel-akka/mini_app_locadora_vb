Public Class ClConfiguracoes

    Private idconfg As Int64
    Private limite_desconto As Double
    Private senhaPadrao As String
    Public liberar As Boolean = False

    Sub New(Optional ByVal vId As Int64 = 0, Optional ByVal vlimite_desconto As Double = 0, Optional ByVal vsenhaPadrao As String = "")
        Me.idconfg = vId : Me.limite_desconto = vlimite_desconto : Me.senhaPadrao = vsenhaPadrao
    End Sub

    Public Sub ZeraValores()
        Me.idconfg = 0 : Me.limite_desconto = 0 : Me.senhaPadrao = ""
    End Sub

#Region "Get e Set"

    Public Property tId() As Int64
        Get
            Return Me.idconfg
        End Get
        Set(value As Int64)
            Me.idconfg = value
        End Set
    End Property

    Public Property tLimiteDesconto() As Double
        Get
            Return Me.limite_desconto
        End Get
        Set(value As Double)
            Me.limite_desconto = value
        End Set
    End Property

    Public Property tSenhaPadrao() As String
        Get
            Return Me.senhaPadrao
        End Get
        Set(value As String)
            Me.senhaPadrao = value
        End Set
    End Property

#End Region

End Class
