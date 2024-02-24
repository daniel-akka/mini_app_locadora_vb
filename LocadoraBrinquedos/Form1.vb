Imports System.Threading

Public Class FrmPrincipal

    Dim _threadsTrazObjetos As Thread

    Private Sub FrmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F11
                Dim mFrmTermo As New FrmTermoResponsabilidade
                mFrmTermo.ShowDialog()
                mFrmTermo = Nothing

        End Select

    End Sub

    Private Sub ProdutosMenuCadProduto_Click(sender As Object, e As EventArgs) Handles ProdutosMenuCadProduto.Click
        Dim frmCadProd As New FrmCadProduto
        frmCadProd.ShowDialog()
        frmCadProd = Nothing
    End Sub

    Private Sub TemposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemposToolStripMenuItem.Click
        Dim frmCadTempo As New FrmCadTempo
        frmCadTempo.ShowDialog()
        frmCadTempo = Nothing
    End Sub

    Private Sub AtendentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtendentesToolStripMenuItem.Click
        Dim frmCadAtendente As New FrmCadAtendente
        frmCadAtendente.ShowDialog()
        frmCadAtendente = Nothing
    End Sub

    Private Sub LocaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocaçõesToolStripMenuItem.Click
        Dim frmLocacoes As New FrmMovimentoLocacoes
        frmLocacoes.ShowDialog()
        frmLocacoes = Nothing
        
    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem.Click
        Dim configuracaoDAO As New ClConfiguracoesDAO
        Dim mconfiguracao As New ClConfiguracoes
        configuracaoDAO.TrazConfiguracoesID(mconfiguracao, MdlConexaoBD.conectionPadrao)
        mconfiguracao.liberar = False
        Dim frmTestaSenha As New FrmSenhaPadrao
        frmTestaSenha.configuracao = mconfiguracao
        frmTestaSenha.ShowDialog()
        If mconfiguracao.liberar Then
            Dim frmRelatLocacoes As New FrmRelatorioLocacoes
            frmRelatLocacoes.ShowDialog()
            frmRelatLocacoes = Nothing
        End If
       
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Thread Tempo Excedido:
        _threadsTrazObjetos = New Threading.Thread(AddressOf TrazObjetos)
        _threadsTrazObjetos.Start()
        _threadsTrazObjetos.IsBackground = True
    End Sub

    Sub TrazObjetos()

        Dim prodDAO As New ClProdutoDAO
        Dim tempDAO As New ClTempoDAO
        Dim atendDAO As New ClAtendenteDAO
        Dim locacoesDAO As New ClMovimentacaoDAO

        prodDAO.TrazListProdutos(MdlConexaoBD.mdlListProdutos, MdlConexaoBD.conectionPadrao)
        tempDAO.TrazListTempos(MdlConexaoBD.mdlListTempos, MdlConexaoBD.conectionPadrao)
        atendDAO.TrazListAtendentes(MdlConexaoBD.mdlListAtendentes, MdlConexaoBD.conectionPadrao)
        locacoesDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
        locacoesDAO.TrazListaMovimentacoesFinalizadas(MdlConexaoBD.mdlListLocacoesFinalizadas, MdlConexaoBD.conectionPadrao)
        mdlConfiguracoesDAO.TrazConfiguracoesID(mdlConfiguracoes, MdlConexaoBD.conectionPadrao)
    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            _threadsTrazObjetos.Abort()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim configuracaoDAO As New ClConfiguracoesDAO
        Dim mconfiguracao As New ClConfiguracoes
        configuracaoDAO.TrazConfiguracoesID(mconfiguracao, MdlConexaoBD.conectionPadrao)
        mconfiguracao.liberar = False
        Dim frmTestaSenha As New FrmSenhaPadrao
        frmTestaSenha.configuracao = mconfiguracao
        frmTestaSenha.ShowDialog()
        If mconfiguracao.liberar Then

            Dim mFrmCofniguracoes As New FrmConfiguracoes
            mFrmCofniguracoes.ShowDialog()
        End If

    End Sub
End Class
