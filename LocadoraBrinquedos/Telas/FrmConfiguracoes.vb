Imports System.Text
Imports System.Data
Imports System.Math
Imports Npgsql

Public Class FrmConfiguracoes

    'Objetos:
    Dim _configuracao As New ClConfiguracoes
    Dim configuracaoDAO As New ClConfiguracoesDAO
    Dim funcoes As New ClFuncoes


    Private Sub txtLimiteDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLimiteDesconto.KeyPress
        'permite só numeros virgula:
        If funcoes.SoNumerosVirgula(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub FrmConfiguracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracaoDAO.TrazConfiguracoesID(_configuracao, MdlConexaoBD.conectionPadrao)
        Me.txtLimiteDesconto.Text = _configuracao.tLimiteDesconto
        Me.txtSenhaPadrao.Text = _configuracao.tSenhaPadrao
    End Sub

    Private Sub FrmConfiguracoes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmConfiguracoes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        _configuracao.tLimiteDesconto = CDbl(txtLimiteDesconto.Text)
        _configuracao.tSenhaPadrao = Trim(txtSenhaPadrao.Text)
        configuracaoDAO.altConfiguracoes(_configuracao, MdlConexaoBD.conectionPadrao)
        mdlConfiguracoesDAO.TrazConfiguracoesID(mdlConfiguracoes, MdlConexaoBD.conectionPadrao)
        Me.Close()
    End Sub
End Class