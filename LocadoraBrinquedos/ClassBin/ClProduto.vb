Public Class ClProduto

    Private p_Id As Int64
    Private p_Descricao As String
    Private p_Capacidade As Double
    Private p_ValorMinuto As Double
    Private p_Codigo As Int32
    Private p_Informacao As String

    Sub New(Optional ByVal vId As Int64 = 0, Optional ByVal vCodigo As Int32 = 0, Optional ByVal vCapacidade As Double = 0, _
                  Optional ByVal vDescricao As String = "", Optional ByVal vInformacao As String = "", Optional ByVal vValorMinuto As Double = 0)
        Me.p_Id = vId : Me.p_Codigo = vCodigo : Me.p_Capacidade = vCapacidade
        Me.p_Descricao = vDescricao : Me.p_Informacao = vInformacao : Me.p_ValorMinuto = vValorMinuto
    End Sub

    Public Sub ZeraValores()
        Me.p_Id = 0 : Me.p_Codigo = 0 : Me.p_Capacidade = 0.0
        Me.p_Descricao = "" : Me.p_Informacao = "" : Me.p_ValorMinuto = 0
    End Sub

#Region "Get e Set"

    Public Property pId() As Int64
        Get
            Return Me.p_Id
        End Get
        Set(value As Int64)
            Me.p_Id = value
        End Set
    End Property

    Public Property pDescricao() As String
        Get
            Return Me.p_Descricao
        End Get
        Set(value As String)
            Me.p_Descricao = value
        End Set
    End Property

    Public Property pCapacidade() As Double
        Get
            Return Me.p_Capacidade
        End Get
        Set(value As Double)
            Me.p_Capacidade = value
        End Set
    End Property

    Public Property pCodigo() As Int32
        Get
            Return Me.p_Codigo
        End Get
        Set(value As Int32)
            Me.p_Codigo = value
        End Set
    End Property

    Public Property pInformacao() As String
        Get
            Return Me.p_Informacao
        End Get
        Set(value As String)
            Me.p_Informacao = value
        End Set
    End Property

    Public Property pValorMinuto() As Double
        Get
            Return Me.p_ValorMinuto
        End Get
        Set(value As Double)
            Me.p_ValorMinuto = value
        End Set
    End Property

#End Region

End Class
