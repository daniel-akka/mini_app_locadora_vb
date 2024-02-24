Public Class ClAtendente

    Private a_Id As Int64
    Private a_Nome As String

    Sub New(Optional ByVal vId As Int64 = 0, Optional ByVal vNome As String = "")
        Me.a_Id = vId : Me.a_Nome = vNome
    End Sub

    Public Sub ZeraValores()
        Me.a_Id = 0 : Me.a_Nome = ""
    End Sub

#Region "Get e Set"

    Public Property aId() As Int64
        Get
            Return Me.a_Id
        End Get
        Set(value As Int64)
            Me.a_Id = value
        End Set
    End Property

    Public Property aNome() As String
        Get
            Return Me.a_Nome
        End Get
        Set(value As String)
            Me.a_Nome = value
        End Set
    End Property

#End Region

End Class
