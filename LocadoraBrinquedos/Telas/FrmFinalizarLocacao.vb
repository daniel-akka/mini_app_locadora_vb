Imports System.Text
Imports System.Math
Imports Npgsql

Public Class FrmFinalizarLocacao

    Public fLocacao As New ClMovimentacao
    Private Sub FrmFinalizarLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtTempoInicial.Text = String.Format("{0:HH:mm:ss}", fLocacao.mTempoInicial)
        txtTempoFinal.Text = String.Format("{0:HH:mm:ss}", fLocacao.mTempoFinal)
        txtVlrPorMinuto.Text = fLocacao.mValorTempo.ToString("0.00")
        txtTempAcumulado.Text = fLocacao.mTempoAcumulado
        txtProdNome.Text = fLocacao.mProdutoNome
        txtAtendente.Text = fLocacao.mAtendenteNome

        If CInt(fLocacao.mTempoProgramado) > 1 Then
            txtTempoProgramado.Text = CInt(fLocacao.mTempoProgramado) & " Minutos"
        Else
            txtTempoProgramado.Text = CInt(fLocacao.mTempoProgramado) & " Minuto"
        End If

        txtValorProgramado.Text = Round(fLocacao.mValorTempo * fLocacao.mTempoProgramado).ToString("0.00")
        txtTempoExcedido.Text = fLocacao.mTempoExcedido

        'Tempo excedido:
        Dim mArray1 As Array = Split(fLocacao.mTempoExcedido, ":")
        Dim mMinutosHr, mMinutos As Integer
        mMinutosHr = CInt(mArray1(0)) * 60
        mMinutos = mMinutosHr + CInt(mArray1(1))
        If mMinutos > 0 Then
            fLocacao.mValorTempoExcedido = Round((mMinutos * fLocacao.mValorTempo), 2)
            txtVlrTempoExcedido.Text = fLocacao.mValorTempoExcedido.ToString("0.00")
        End If


        'Tempo total:
        Dim mArray As Array = Split(fLocacao.mTempoAcumulado, ":")
        Dim minutosAcumulados As Integer = CInt(mArray(0))
        fLocacao.mValorTempoTotal = Round(fLocacao.mValorTempo * minutosAcumulados, 2)
        fLocacao.mValorTotalDesconto = fLocacao.mValorTempoTotal
        txtVlrTotalLocacao.Text = fLocacao.mValorTotalDesconto.ToString("0.00")
        txtVlrTotalExecido.Text = fLocacao.mValorTempoTotal.ToString("0.00")

        txtVlrTotalLocacao.Focus() : txtVlrTotalLocacao.SelectAll()

        If fLocacao.mValorTempoExcedido <= 0 Then Me.txtDesconto.ReadOnly = True


    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        Dim flocacaoDAO As New ClMovimentacaoDAO
        fLocacao.mFinalizado = True

        If IsNumeric(txtVlrTotalLocacao.Text) = False Then MsgBox("Valor Total DEVE ser NUMERICO") : Return
        'fLocacao.mValorTempoTotal = CDbl(txtVlrTotalLocacao.Text)
        fLocacao.mDesconto = CDbl(txtDesconto.Text)
        fLocacao.mValorTotalDesconto = CDbl(txtVlrTotalLocacao.Text)

        Dim connection As New NpgsqlConnection(MdlConexaoBD.conectionPadrao)
        Try


            Try
                connection.Open()
            Catch ex As Exception
                MsgBox("ERRO:: " & ex.Message)
                connection = Nothing : Return
            End Try


            Dim transacao As NpgsqlTransaction = connection.BeginTransaction
            flocacaoDAO.altMovimentacao(fLocacao, connection, transacao)
            transacao.Commit()

            MsgBox("LOCAÇÃO Finalizada com Sucesso!", MsgBoxStyle.Exclamation)
            flocacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
        Catch ex As Exception
            MsgBox("ERRO:: " & ex.Message)
        Finally
            connection.ClearPool() : connection.Close() : connection = Nothing
        End Try

        Me.Close()
    End Sub

    Private Sub FrmFinalizarLocacao_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub txtVlrTotal_Leave(sender As Object, e As EventArgs) Handles txtVlrTotalLocacao.Leave

        Try
            txtVlrTotalLocacao.Text = CDbl(txtVlrTotalLocacao.Text).ToString("0.00")
        Catch ex As Exception
            MsgBox("Valor total deve ser numérico") : txtVlrTotalLocacao.Focus()
        End Try

    End Sub

    Private Sub FrmFinalizarLocacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDesconto_Leave(sender As Object, e As EventArgs) Handles txtDesconto.Leave
        Try
            txtDesconto.Text = CDbl(txtDesconto.Text).ToString("0.00")
        Catch ex As Exception
            MsgBox("Valor Desconto deve ser numérico") : txtDesconto.Focus()
        End Try

        If CDbl(txtDesconto.Text) > 0 Then

            If CDbl(txtDesconto.Text) > (fLocacao.mValorTempoExcedido * (mdlConfiguracoes.tLimiteDesconto / 100)) Then
                MsgBox("Limite de Desconto Excedido!") : txtDesconto.Focus() : txtDesconto.SelectAll() : Return
            End If

            txtVlrTotalLocacao.Text = CDbl(fLocacao.mValorTempoTotal - CDbl(txtDesconto.Text)).ToString("0.00")
        End If

        txtVlrTotalLocacao.Focus() : txtVlrTotalLocacao.SelectAll()
    End Sub
End Class