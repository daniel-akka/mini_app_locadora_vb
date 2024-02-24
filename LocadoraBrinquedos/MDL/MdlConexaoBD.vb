Module MdlConexaoBD

    Public conectionPadrao As String = _
    "Server=localhost;Port=5432;UserId=postgres;Password=.akka.;Database=CONCORDIA;" & _
    "maxPoolSize=100;Timeout=7;CommandTimeout=7;"

    Public mdlListProdutos As New List(Of ClProduto)
    Public mdlListTempos As New List(Of ClTempo)
    Public mdlListAtendentes As New List(Of ClAtendente)
    Public mdlListLocacoesNaoFinalizadas As New List(Of ClMovimentacao)
    Public mdlListLocacoesFinalizadas As New List(Of ClMovimentacao)

    'Objetos Configuracoes
    Public mdlConfiguracoes As New ClConfiguracoes
    Public mdlConfiguracoesDAO As New ClConfiguracoesDAO

End Module
