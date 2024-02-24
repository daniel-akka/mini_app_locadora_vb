Imports System.Text
Imports System.Data
Imports System.Math
Imports Npgsql

Public Class FrmRelatorioLocacoes

    'Objetos:
    Dim brinquedo As New ClProduto
    Dim atendente As New ClAtendente
    Dim locacao As New ClMovimentacao
    Dim brinquedoDAO As New ClProdutoDAO
    Dim atendenteDao As New ClAtendenteDAO
    Dim locacaoDAO As New ClMovimentacaoDAO
    Dim locacaoCanceladaDAO As New ClLocacoesCanceladasDAO
    Dim funcoes As New ClFuncoes
    Dim locacoes As New List(Of ClMovimentacao)
    Dim locacoesCanceladas As New List(Of ClLocacoesCanceladas)

    Private Sub FrmRelatorioLocacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'rdbCancelados.Enabled = False
        'grbFiltros.Enabled = False
        If rdbFiltros.Checked Then grbFiltros.Enabled = True

        brinquedoDAO.PreencheCboProdutosRelatorio(cboBrinquedos, MdlConexaoBD.conectionPadrao)
        atendenteDao.PreencheCboAtendentesRelatorio(cboAtendentes, MdlConexaoBD.conectionPadrao)

        locacaoCanceladaDAO.TrazListaLocacoesCanceladas(locacoesCanceladas, MdlConexaoBD.conectionPadrao)
    End Sub

    Private Sub FrmRelatorioLocacoes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Sub ExecutaF5()

        locacaoDAO.TrazListaMovimentacoesFinalizadas(locacoes, MdlConexaoBD.conectionPadrao)
        dtg_locacoes.Rows.Clear()

        Dim mLocacoes As New List(Of ClMovimentacao)
        Dim mLocacoesCanc As New List(Of ClLocacoesCanceladas)

        'Selecionada a Busca da Todos:
        If rdbTodos.Checked Then
            mLocacoes = locacoes.FindAll(Function(l As ClMovimentacao) ((l.mData >= dtpInicio.Text) AndAlso (l.mData <= dtpFinal.Text)))
        End If

        'Selecionada a Busca por Filtros:
        If rdbFiltros.Checked Then

            If atendente.aId > 0 Then
                mLocacoes = locacoes.FindAll(Function(l As ClMovimentacao) ((l.mData >= dtpInicio.Text) AndAlso (l.mData <= dtpFinal.Text)) _
                                             AndAlso (l.mAtendenteId = atendente.aId))
            Else
                mLocacoes = locacoes.FindAll(Function(l As ClMovimentacao) ((l.mData >= dtpInicio.Text) AndAlso (l.mData <= dtpFinal.Text)))
            End If

            If brinquedo.pId > 0 Then

                If atendente.aId > 0 Then
                    mLocacoes = locacoes.FindAll(Function(l As ClMovimentacao) ((l.mData >= dtpInicio.Text) AndAlso (l.mData <= dtpFinal.Text)) _
                                                 AndAlso (l.mProdutoId = brinquedo.pId) AndAlso (l.mAtendenteId = atendente.aId))
                Else
                    mLocacoes = locacoes.FindAll(Function(l As ClMovimentacao) ((l.mData >= dtpInicio.Text) AndAlso (l.mData <= dtpFinal.Text)) _
                                                 AndAlso (l.mProdutoId = brinquedo.pId))
                End If
            End If
        End If

        'IF Locações Canceladas:
        If rdbCancelados.Checked Then
            mLocacoesCanc = locacoesCanceladas.FindAll(Function(l As ClLocacoesCanceladas) ((l.mData >= dtpInicio.Text) AndAlso (l.mData <= dtpFinal.Text)))
        End If

        If mLocacoes.Count > 0 Then

            For Each l As ClMovimentacao In mLocacoes

                If l.mTempoProgramado > 1 Then
                    dtg_locacoes.Rows.Add(l.mId, l.mProdutoNome & vbNewLine & "Atend.: " & l.mAtendenteNome & "   Tmp: " & _
                                      l.mTempoProgramado & " minutos", l.mData.ToShortDateString, l.mValorTempoTotal.ToString("0.00"), l.mDesconto.ToString("0.00"), _
                                      l.mValorTotalDesconto.ToString("0.00"))
                Else
                    dtg_locacoes.Rows.Add(l.mId, "Brinquedo: " & l.mProdutoNome & vbNewLine & "Atend.: " & l.mAtendenteNome & "   Tmp: " & _
                                      l.mTempoProgramado & " minuto", l.mData.ToShortDateString, l.mValorTempoTotal.ToString("0.00"), l.mDesconto.ToString("0.00"), _
                                      l.mValorTotalDesconto.ToString("0.00"))
                End If

            Next
        End If

        If mLocacoesCanc.Count > 0 Then

            For Each l As ClLocacoesCanceladas In mLocacoesCanc

                dtg_locacoes.Rows.Add(l.mId, l.mProdutoNome & vbNewLine & "Atend.: " & l.mAtendenteNome & "   Tmp: " & _
                                       l.mTempoProgramado & " minutos", l.mData.ToShortDateString, l.mValorTempoTotal.ToString("0.00"), l.mDesconto.ToString("0.00"), _
                                       l.mValorTotalDesconto.ToString("0.00"), l.mJustificativa)
            Next
        End If
        

        VerificaInfoLocacoes()
    End Sub

    Sub VerificaInfoLocacoes()

        lblRegistros.Text = dtg_locacoes.Rows.Count & " Locação"
        If dtg_locacoes.Rows.Count > 1 Then lblRegistros.Text = dtg_locacoes.Rows.Count & " Locações"

        'Soma Totais:
        Dim mSomaTot As Double = 0.0
        For Each r As DataGridViewRow In dtg_locacoes.Rows

            If r.IsNewRow = False Then
                mSomaTot += r.Cells(3).Value
            End If
        Next
        txtTotalValores.Text = mSomaTot.ToString("0.00")

    End Sub

    Private Sub rdbFiltros_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFiltros.CheckedChanged, rdbTodos.CheckedChanged, rdbCancelados.CheckedChanged

        If rdbFiltros.Checked Then
            grbFiltros.Enabled = True
            Try
                cboAtendentes.SelectedIndex = 0
                cboBrinquedos.SelectedIndex = 0
            Catch ex As Exception
            End Try


            dtg_locacoes.Columns(3).Visible = True
            dtg_locacoes.Columns(4).Visible = True
            dtg_locacoes.Columns(5).Visible = True
            dtg_locacoes.Columns(6).Visible = False

        ElseIf rdbTodos.Checked Then

            grbFiltros.Enabled = True
            Try
                cboAtendentes.SelectedIndex = -1
                cboBrinquedos.SelectedIndex = -1
            Catch ex As Exception
            End Try

            dtg_locacoes.Columns(3).Visible = True
            dtg_locacoes.Columns(4).Visible = True
            dtg_locacoes.Columns(5).Visible = True
            dtg_locacoes.Columns(6).Visible = False

        ElseIf rdbCancelados.Checked Then

            grbFiltros.Enabled = True
            Try
                cboAtendentes.SelectedIndex = -1
                cboBrinquedos.SelectedIndex = -1
            Catch ex As Exception
            End Try

            dtg_locacoes.Columns(3).Visible = False
            dtg_locacoes.Columns(4).Visible = False
            dtg_locacoes.Columns(5).Visible = False
            dtg_locacoes.Columns(6).Visible = True
        End If

    End Sub

    Private Sub cboBrinquedos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrinquedos.SelectedIndexChanged

        brinquedo.ZeraValores()
        If cboBrinquedos.SelectedIndex > 0 Then
            Dim mProd As String = cboBrinquedos.SelectedItem
            brinquedo.pId = CInt(Trim(mProd.Substring(mProd.Length - 4)))
            brinquedoDAO.TrazProduto(brinquedo, MdlConexaoBD.conectionPadrao)
        End If

    End Sub

    Private Sub cboAtendentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAtendentes.SelectedIndexChanged

        atendente.ZeraValores()
        If cboAtendentes.SelectedIndex > 0 Then
            atendente.aNome = cboAtendentes.SelectedItem
            atendenteDao.TrazAtendenteNome(atendente, MdlConexaoBD.conectionPadrao)
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ExecutaF5()
    End Sub
End Class