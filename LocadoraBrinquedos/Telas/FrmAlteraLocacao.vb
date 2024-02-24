Imports System.Text
Imports System.Math
Imports Npgsql

Public Class FrmAlteraLocacao

    Public fLocacao As New ClMovimentacao
    Dim funcoes As New ClFuncoes
    Dim brinquedoDAO As New ClProdutoDAO
    Dim atendenteDao As New ClAtendenteDAO
    Dim brinquedo As New ClProduto
    Dim atendente As New ClAtendente

    Private Sub FrmAlteraLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        brinquedoDAO.PreencheCboProdutosLista(cboBrinquedo, MdlConexaoBD.mdlListProdutos)
        atendenteDao.PreencheCboAtendentesLista(cboAtendente, MdlConexaoBD.mdlListAtendentes)


        cboBrinquedo.SelectedIndex = funcoes.trazIndexComboBoxFinal(fLocacao.mProdutoId, 3, cboBrinquedo)
        cboAtendente.SelectedIndex = funcoes.trazIndexCboTextoTodo(fLocacao.mAtendenteNome, cboAtendente)
        txtTempoFinal.Text = String.Format("{0:HH:mm:ss}", fLocacao.mTempoFinal)
        txtNovoTempo.Text = txtTempoFinal.Text
        cboOperacao.SelectedIndex = 0
        txtMinutos.Text = fLocacao.mTempoProgramado
        cboBrinquedo.Text = fLocacao.mProdutoNome
        txtMinutos.Focus() : txtMinutos.SelectAll()

    End Sub

    Private Sub txtMinutos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMinutos.KeyDown

        If e.KeyCode = Keys.Enter Then

            fLocacao.mTempoFinal = CDate(txtTempoFinal.Text)
            Select Case cboOperacao.SelectedIndex
                Case 0 'Tempo total
                    If IsNumeric(txtMinutos.Text) Then
                        fLocacao.mTempoFinal = DateAndTime.DateAdd(DateInterval.Minute, CInt(txtMinutos.Text), fLocacao.mTempoInicial)
                        txtNovoTempo.Text = String.Format("{0:HH:mm:ss}", fLocacao.mTempoFinal)
                    End If


                Case 1 'Adicionar Tempo
                    If IsNumeric(txtMinutos.Text) Then
                        fLocacao.mTempoFinal = DateAndTime.DateAdd(DateInterval.Minute, CInt(txtMinutos.Text), fLocacao.mTempoFinal)
                        txtNovoTempo.Text = String.Format("{0:HH:mm:ss}", fLocacao.mTempoFinal)
                    End If

                Case 2 'Subtrair Tempo
                    If IsNumeric(txtMinutos.Text) Then
                        Dim mTmpFinal As Date = DateAndTime.DateAdd(DateInterval.Minute, -CInt(txtMinutos.Text), fLocacao.mTempoFinal)
                        If mTmpFinal < DateAndTime.TimeOfDay Then MsgBox("Tempo não pode ser menor que o Tempo ATUAL") : Return
                        fLocacao.mTempoFinal = mTmpFinal
                        txtNovoTempo.Text = String.Format("{0:HH:mm:ss}", fLocacao.mTempoFinal)
                    End If

            End Select
            btnFinalizar.Focus()
        End If
    End Sub

    Private Sub txtMinutos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinutos.KeyPress
        'permite só numeros:
        If funcoes.SoNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        Dim flocacaoDAO As New ClMovimentacaoDAO
        If flocacaoDAO.verificaMovimentacaoQuery(MdlConexaoBD.conectionPadrao, ("WHERE m_id <> " & fLocacao.mId & " AND m_finalizado = false AND m_produto_id = " & brinquedo.pId)) Then 'Verifica se o BRINQUEDO ja está em locação
            MsgBox("O Brinquedo: """ & brinquedo.pDescricao & """ já está sendo USADO! Feche a Locação dele para Poder Usá-lo", MsgBoxStyle.Information)
            Return
        End If

        If cboAtendente.SelectedIndex < 0 Then
            MsgBox("Selecione um Atendente", MsgBoxStyle.Information)
            Return
        End If

        Dim connection As New NpgsqlConnection(MdlConexaoBD.conectionPadrao)
        Try


            Try
                connection.Open()
            Catch ex As Exception
                MsgBox("ERRO:: " & ex.Message)
                connection = Nothing : Return
            End Try

            Dim mNovoTempoProgramado As Double = fLocacao.mTempoFinal.Subtract(fLocacao.mTempoInicial).TotalMinutes

            With fLocacao
                .mTempoProgramado = CInt(mNovoTempoProgramado)
                .mProdutoId = brinquedo.pId
                .mProdutoNome = brinquedo.pDescricao
                .mAtendenteId = atendente.aId
                .mAtendenteNome = atendente.aNome
            End With

            Dim transacao As NpgsqlTransaction = connection.BeginTransaction
            flocacaoDAO.altMovimentacao(fLocacao, connection, transacao)
            transacao.Commit()

            MsgBox("LOCAÇÃO Alterada com Sucesso!", MsgBoxStyle.Exclamation)
            flocacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
        Catch ex As Exception
            MsgBox("ERRO:: " & ex.Message)
        Finally
            connection.ClearPool() : connection.Close() : connection = Nothing
        End Try

        Me.Close()

    End Sub

    Private Sub txtNovoTempo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNovoTempo.KeyDown
        If e.KeyCode = Keys.Enter Then
            fLocacao.mTempoFinal = txtNovoTempo.Text
        End If
    End Sub

    Private Sub FrmAlteraLocacao_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
                'Case Keys.Enter
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub cboBrinquedo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrinquedo.SelectedIndexChanged

        If cboBrinquedo.SelectedIndex > -1 Then
            Dim mProd As String = cboBrinquedo.SelectedItem
            brinquedo.pId = CInt(Trim(mProd.Substring(mProd.Length - 4)))

            For Each p As ClProduto In MdlConexaoBD.mdlListProdutos
                If p.pId.Equals(brinquedo.pId) Then

                    With brinquedo
                        .pId = p.pId
                        .pCodigo = p.pCodigo
                        .pDescricao = p.pDescricao
                        .pCapacidade = p.pCapacidade
                        .pInformacao = p.pInformacao
                    End With
                    Exit For
                End If

            Next
            'brinquedo = MdlConexaoBD.mdlListProdutos.Find(Function(p As ClProduto) p.pId = brinquedo.pId)
        End If
    End Sub

    Private Sub cboAtendente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAtendente.SelectedIndexChanged

        If cboAtendente.SelectedIndex > -1 Then
            atendente.aNome = cboAtendente.SelectedItem

            For Each a As ClAtendente In MdlConexaoBD.mdlListAtendentes

                If a.aNome.Equals(atendente.aNome) Then

                    With atendente
                        .aId = a.aId
                        .aNome = a.aNome
                    End With
                    Exit For
                End If
            Next
            'atendente = MdlConexaoBD.mdlListAtendentes.Find(Function(a As ClAtendente) a.aNome = atendente.aNome)
        End If
    End Sub
End Class