Imports System.Data
Imports Npgsql
Imports System.Threading
Imports System.Text
Imports System.Math
Imports System.IO
Imports System.Drawing.Printing

Public Class FrmMovimentoLocacoes

    'Objetos:
    Dim tempo As New ClTempo
    Dim brinquedo As New ClProduto
    Dim atendente As New ClAtendente
    Dim locacao As New ClMovimentacao
    Dim brinquedoDAO As New ClProdutoDAO
    Dim tempoDao As New ClTempoDAO
    Dim atendenteDao As New ClAtendenteDAO
    Dim locacaoDAO As New ClMovimentacaoDAO
    Dim TermoResponsabilidadeDAO As New ClTermoResponsabilidadeDAO
    Dim funcoes As New ClFuncoes
    Dim locacoes As New List(Of ClMovimentacao)

    'Auxiliares:
    Dim threadsTempos As Thread
    Dim tmpExcedido As New List(Of Timer)
    Dim lblNomeProd As New Label
    Dim lblNomeAtendente As New Label
    Dim lblTempo As New Label
    Dim mTerminaConsultaF5 As Boolean = True
    Dim mRtbInfo As New RichTextBox
    Dim rs As New Resizer

    Dim _mLocacao As New ClMovimentacao
    Dim _mTermo As New ClTermoResponsabilidade

    'objetos para impressão:
    Dim _pathContrFrent As String = "\wged\Imagens\ControleMensal.png"
    Dim _StringToPrint As String = ""
    Dim MostrarCaixaImpressoras As Boolean = False
    Private _PrintFont As New Font("Lucida Console", 8) 'Stenci
    Private _PrintPageSettings As New PageSettings
    Private _leitorTabela As NpgsqlDataReader
    Private _pgAtualImpressao As Integer = 1
    Private _tituloConsulta As String = ""
    Private _sImpressao As StreamWriter
    Private _dtAdaptPrint As NpgsqlDataAdapter
    Dim mQtdRegistros As Int16 = 0


    Private Sub FrmMovimentoLocacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        brinquedoDAO.PreencheCboProdutosLista(cboBrinquedo, MdlConexaoBD.mdlListProdutos)
        tempoDao.PreencheCboTemposLista(cboTempo, MdlConexaoBD.mdlListTempos)
        atendenteDao.PreencheCboAtendentesLista(cboAtendente, MdlConexaoBD.mdlListAtendentes)

        ExecutaF5()
        'Thread Tempos:
        threadsTempos = New Threading.Thread(AddressOf AcionaTempos)
        threadsTempos.IsBackground = True
        threadsTempos.Start()

    

        'relaciona o objeto pd ao procedimento rptGravaTotaisNF
        AddHandler pdRelatorio.BeginPrint, AddressOf InicializaRelatorio

        'relaciona o objeto pd ao procedimento rptGravaTotaisNF
        AddHandler pdRelatorio.PrintPage, AddressOf rptGravaTermoResponsabilidade

        setImpressao()

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
                        .pValorMinuto = p.pValorMinuto
                    End With
                    Exit For
                End If

            Next
            txtValorMinuto.Text = brinquedo.pValorMinuto.ToString("0.00")
            txtCapacidade.Text = "Capacidade Maxima " & brinquedo.pCapacidade & "Kg"
        End If
    End Sub

    Private Sub cboTempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTempo.SelectedIndexChanged

        If cboTempo.SelectedIndex > -1 Then
            tempo.tTempo = CDbl(cboTempo.SelectedItem)

            For Each t As ClTempo In MdlConexaoBD.mdlListTempos

                If t.tTempo.Equals(tempo.tTempo) Then

                    With tempo
                        .tId = t.tId
                        .tTempo = t.tTempo
                        .tValor = t.tValor
                    End With
                    Exit For
                End If
            Next
            'tempo = MdlConexaoBD.mdlListTempos.Find(Function(t As ClTempo) t.tTempo = tempo.tTempo)
            'txtValorMinuto.Text = tempo.tValor.ToString("0.00")
            txtValorTotal.Text = Round((tempo.tTempo * CDbl(txtValorMinuto.Text)), 2).ToString("0.00")
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

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If verificaCamposForm() = False Then Return

        locacao.mProdutoId = brinquedo.pId
        locacao.mProdutoNome = brinquedo.pDescricao
        locacao.mAtendenteId = atendente.aId
        locacao.mAtendenteNome = atendente.aNome
        locacao.mTempoProgramado = tempo.tTempo
        locacao.mValorTempo = brinquedo.pValorMinuto
        locacao.mValorTempoTotal = Round((tempo.tTempo * tempo.tValor), 2)
        locacao.mTempoInicial = DateAndTime.TimeOfDay
        locacao.mTempoFinal = DateAndTime.DateAdd(DateInterval.Minute, tempo.tTempo, locacao.mTempoInicial)
        locacao.mFinalizado = False
        locacao.mIniciado = False


        Dim connection As New NpgsqlConnection(MdlConexaoBD.conectionPadrao)
        Try


            Try
                connection.Open()
            Catch ex As Exception
                MsgBox("ERRO:: " & ex.Message)
                connection = Nothing : Return
            End Try

            Dim transacao As NpgsqlTransaction = connection.BeginTransaction
            locacaoDAO.incMovimentacao(locacao, connection, transacao)
            transacao.Commit()
            MsgBox("LOCAÇÃO Salva com Sucesso!", MsgBoxStyle.Exclamation)


            locacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
            ZeraValoresFormulario()
            ExecutaF5()
            cboBrinquedo.Focus()
        Catch ex As Exception
            MsgBox("ERRO NO INSERT DA LOCACAO:: " & ex.Message)
        Finally
            connection.ClearPool() : connection.Close() : connection = Nothing
        End Try

    End Sub

    Function verificaCamposForm() As Boolean

        If cboBrinquedo.SelectedIndex < 0 Then
            MsgBox("Selecione um BRINQUEDO para Confirmar, por favor!")
            cboBrinquedo.Focus()
            Return False
        End If

        If cboTempo.SelectedIndex < 0 Then
            MsgBox("Selecione um TEMPO para Confirmar, por favor!")
            cboTempo.Focus()
            Return False
        End If

        If cboAtendente.SelectedIndex < 0 Then
            MsgBox("Selecione um ATENDENTE para Confirmar, por favor!")
            cboAtendente.Focus()
            Return False
        End If

        If locacoes.Exists(Function(l As ClMovimentacao) l.mProdutoId = brinquedo.pId) Then 'Verifica se o BRINQUEDO ja está em locação : Antigo codigo = locacaoDAO.verificaMovimentacaoQuery(MdlConexaoBD.conectionPadrao, ("WHERE m_finalizado = false AND m_produto_id = " & brinquedo.pId))
            MsgBox("O Brinquedo: """ & brinquedo.pDescricao & """ já está sendo USADO! Feche a Locação dele para Poder Usá-lo", MsgBoxStyle.Information)
            Return False
        End If

        Return True
    End Function

    Sub ZeraValoresFormulario()
        cboBrinquedo.SelectedIndex = -1
        cboAtendente.SelectedIndex = -1
        cboTempo.SelectedIndex = -1
        txtCapacidade.Text = ""
        txtValorTotal.Text = "0,00"
        brinquedo.ZeraValores()
        atendente.ZeraValores()
        tempo.ZeraValores()
    End Sub

    Sub ExecutaF5()

        Try

            Try
                locacoes.Clear()
                'locacoes = MdlConexaoBD.mdlListLocacoesNaoFinalizadas.ToList
                locacaoDAO.TrazListaMovimentacaoNaoFinalizada(locacoes, MdlConexaoBD.conectionPadrao)
                dtg_locacoes.Rows.Clear()
            Catch ex As Exception
                MsgBox("ERRO na função DAO ""TrazListaMovimentacaoNaoFinalizada"" " & ex.Message)
                Return
            End Try

            Dim mTempoAndamento As String = "00:00:00"
            For Each l As ClMovimentacao In locacoes

                'Formataçoes:
                lblNomeAtendente.Text = l.mAtendenteNome
                lblNomeProd.Text = l.mProdutoNome
                lblTempo.Text = l.mTempoProgramado


                If l.mTempoProgramado > 1 Then
                    mRtbInfo.Text = l.mProdutoNome & vbNewLine
                    mRtbInfo.Text += "Atend.: " & lblNomeAtendente.Text & "   Tmp: " & lblTempo.Text & " minutos"
                    If l.mIniciado = False Then l.mTempoInicial = Nothing
                    If l.mIniciado = False Then l.mTempoFinal = Nothing

                    dtg_locacoes.Rows.Add(l.mId, mRtbInfo.Text, l.mTempoInicial, l.mTempoFinal, mTempoAndamento, l.mTempoExcedido, l.mData, l.mIniciado)
                Else
                    mRtbInfo.Text = l.mProdutoNome & vbNewLine
                    mRtbInfo.Text += "Atend.: " & lblNomeAtendente.Text & "   Tmp: " & lblTempo.Text & " minuto"
                    If l.mIniciado = False Then l.mTempoInicial = Nothing
                    If l.mIniciado = False Then l.mTempoFinal = Nothing

                    dtg_locacoes.Rows.Add(l.mId, mRtbInfo.Text, l.mTempoInicial, l.mTempoFinal, mTempoAndamento, l.mTempoExcedido, l.mData, l.mIniciado)
                End If

            Next
            VerificaInfoLocacoes()

        Catch ex As Exception
            'MsgBox("ERRO NA HORA DE ATUALIZAR A CONSULTA FUNÇÃO ""ExecutaF5"" ::  " & ex.Message)
            ExecutaF5()
        End Try


    End Sub

    Sub AcionaTempos()

        Dim mPontoDeErro As String = ""
        Try
            'Variaveis...
            Dim mDataFinal As Date
            Dim mTempoExcedido As String
            'Auxiliares Tempo Andamento...
            Dim mDataInicial As Date
            Dim mTempoAtual As Date
            Dim mTempoAndamento As String
            Dim mTempoLimite As Boolean = False

            While Not (threadsTempos.ThreadState = ThreadState.Aborted)

                If dtg_locacoes.Rows.Count > 0 Then

                    For Each dt As DataGridViewRow In dtg_locacoes.Rows

                        If (dt.IsNewRow = False) AndAlso (dt.Cells(7).Value = True) Then

                            mTempoLimite = False
                            'Tratamento do TempoExcedido....
                            mDataFinal = dt.Cells(3).Value 'Vai servir para o tempo Excedido e o Tempo em Andamento

                            If (mDataFinal.ToString < DateAndTime.TimeOfDay.ToString) Then
                                dt.Cells(5).Style.BackColor = System.Drawing.Color.Orange
                                'dt.Cells(5).Style.ForeColor = System.Drawing.Color.Black
                                mTempoExcedido = (DateAndTime.TimeOfDay - mDataFinal).ToString
                                dt.Cells(5).Value = mTempoExcedido
                                mTempoLimite = True
                            End If
                            'Fim do Tratamento do Tempo Excedido!
                            '----------------------------------------------------------------------------------------------------


                            'Tratamento do Tempo Normal em Andamento...
                            mDataInicial = dt.Cells(2).Value
                            mTempoAtual = DateTime.Now.TimeOfDay.ToString

                            If (mDataFinal.ToString > DateAndTime.TimeOfDay.ToString) Then

                                If IsDate((mDataFinal - DateAndTime.TimeOfDay).ToString) Then
                                    dt.Cells(4).Style.BackColor = System.Drawing.Color.Beige
                                    mTempoAndamento = (mDataFinal - DateAndTime.TimeOfDay).ToString
                                    dt.Cells(4).Value = mTempoAndamento

                                End If
                            Else
                                dt.Cells(4).Style.BackColor = System.Drawing.Color.White
                                dt.Cells(4).Value = "00:00:00"
                            End If
                            'Fim do Tempo em Andamento!
                            '----------------------------------------------------------------------------------------------------

                        End If
                        'Fim do If IsNewRow
                    Next
                End If

            End While 'Fim While!

        Catch ex As Exception
            'MsgBox("Erro Thread AcionaTempoExcedido:: Pono do Erro: " & mPontoDeErro & "    Menssagem:" & ex.Message)
            Thread.Sleep(600)
            AcionaTempos()
        End Try

    End Sub

    Sub VerificaInfoLocacoes()

        Try

            txtInfoLocacoes.Text = ""
            txtLocacoesExcedidas.Text = ""
            If dtg_locacoes.Rows.Count > 1 Then
                txtInfoLocacoes.Text = dtg_locacoes.Rows.Count & " Locações em Andamento..."
            ElseIf dtg_locacoes.Rows.Count = 1 Then
                txtInfoLocacoes.Text = dtg_locacoes.Rows.Count & " Locação em Andamento..."
            End If

            'Verifica Locacoes Excedidas
            Dim excedidasDias As Integer = locacoes.FindAll(Function(l As ClMovimentacao) (l.mIniciado = True) AndAlso
                                                                (l.mData.ToShortDateString < Date.Now.ToShortDateString)).Count
            Dim excedidasHoje As Integer = locacoes.FindAll(Function(l As ClMovimentacao) (l.mData.ToShortDateString = Date.Now.ToShortDateString) _
                                                                AndAlso (l.mIniciado = True) AndAlso (l.mTempoFinal < DateAndTime.TimeOfDay)).Count

            If (excedidasDias + excedidasHoje) > 0 Then

                If (excedidasDias + excedidasHoje) > 1 Then
                    txtLocacoesExcedidas.Text = (excedidasDias + excedidasHoje) & " Locações Excedidas!"
                ElseIf (excedidasDias + excedidasHoje) = 1 Then
                    txtLocacoesExcedidas.Text = (excedidasDias + excedidasHoje) & " Locação Excedida!"
                End If
            End If
        Catch ex As Exception
            MsgBox("ERRO na Função ""VerificaInfoLocacoes""" & ex.Message)
        End Try

    End Sub

    Private Sub FrmMovimentoLocacoes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        AbortaThreads()

    End Sub

    Sub AbortaThreads()

        Try

            threadsTempos.Abort()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub dtg_locacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_locacoes.CellContentClick

        Select Case e.ColumnIndex
            Case 8 'Coluna do Botão Cancelar

                If dtg_locacoes.CurrentRow.IsNewRow = False Then

                    'If MessageBox.Show("Deseja Realmente Cancelar esta LOCAÇÃO?", "Cancelar Locação", MessageBoxButtons.YesNo) = _
                    ' Windows.Forms.DialogResult.No Then
                    '    Return
                    'End If
                    locacao.mId = dtg_locacoes.CurrentRow.Cells(0).Value
                    locacao = MdlConexaoBD.mdlListLocacoesNaoFinalizadas.Find(Function(l As ClMovimentacao) l.mId = locacao.mId)

                    'INFORMAR O MOTIVO DO CANCELAMENTO:
                    Dim mMotivo As New FrmMotivoCancelamento
                    Dim frmMotivoCanc As FrmMotivoCancelamento = mMotivo
                    frmMotivoCanc.ShowDialog()
                    If mMotivo._confirmaCancelamento Then

                        locacao.mJustificativa = mMotivo._MotivoCancelamento
                        locacaoDAO.altMovimentacao(locacao, MdlConexaoBD.conectionPadrao)
                        locacaoDAO.delMovimentacao(locacao, MdlConexaoBD.conectionPadrao)
                        locacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
                        ExecutaF5()
                    End If
                    
                End If

            Case 9 'Coluna do Botao Iniciar

                If dtg_locacoes.CurrentRow.IsNewRow = False Then

                    If dtg_locacoes.CurrentRow.Cells(7).Value = False Then

                        locacao.mId = dtg_locacoes.CurrentRow.Cells(0).Value
                        locacao = MdlConexaoBD.mdlListLocacoesNaoFinalizadas.Find(Function(l As ClMovimentacao) l.mId = locacao.mId)
                        locacao.mIniciado = True
                        locacao.mTempoInicial = DateAndTime.TimeOfDay
                        locacao.mTempoFinal = DateAndTime.DateAdd(DateInterval.Minute, locacao.mTempoProgramado, locacao.mTempoInicial)
                        locacaoDAO.altMovimentacao(locacao, MdlConexaoBD.conectionPadrao)
                        locacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
                        ExecutaF5()
                    End If

                End If


            Case 10 'Coluna do Botão Finalizar

                If dtg_locacoes.CurrentRow.IsNewRow = False Then

                    Dim mLocacoes As List(Of ClMovimentacao) = locacoes.ToList
                    Dim minutos, segundos As String

                    For Each l As ClMovimentacao In mLocacoes

                        If l.mId = dtg_locacoes.CurrentRow.Cells(0).Value Then

                            locacao = l
                            Exit For
                        End If
                    Next


                    locacao.mTempoExcedido = dtg_locacoes.CurrentRow.Cells(5).Value
                    minutos = DateAndTime.TimeOfDay.Subtract(locacao.mTempoInicial).TotalMinutes.ToString("00")
                    segundos = DateAndTime.TimeOfDay.Subtract(locacao.mTempoInicial).Seconds.ToString("00")
                    locacao.mTempoAcumulado = minutos & ":" & segundos
                    If MessageBox.Show("Deseja realmente Finalizar essa Locação de """ & locacao.mProdutoNome & """", "Finalizar Locação", MessageBoxButtons.YesNo) _
                        = Windows.Forms.DialogResult.Yes Then

                        Dim mFrmFinalizaLocacao As New FrmFinalizarLocacao
                        mFrmFinalizaLocacao.fLocacao = locacao
                        mFrmFinalizaLocacao.ShowDialog()
                        mFrmFinalizaLocacao = Nothing
                        locacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
                        ExecutaF5()

                    End If
                End If


        End Select
    End Sub

    Private Sub FrmMovimentoLocacoes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                ExecutaF5()
            Case Keys.Up, Keys.Down
                If dtg_locacoes.RowCount > 0 Then dtg_locacoes.Focus()
            Case Keys.F6
                _mLocacao.mId = dtg_locacoes.CurrentRow.Cells(0).Value
                locacaoDAO.TrazMovimentacao(_mLocacao, MdlConexaoBD.conectionPadrao)
                TermoResponsabilidadeDAO.Traztermo(_mTermo, MdlConexaoBD.conectionPadrao)
                ExecutaF6()
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.F3
                AlterarLocacao()
        End Select

    End Sub

    Sub AlterarLocacao()

        Try
            If dtg_locacoes.CurrentRow.IsNewRow = False Then

                Dim mLocacao As New ClMovimentacao
                mLocacao.mId = dtg_locacoes.CurrentRow.Cells(0).Value
                locacaoDAO.TrazMovimentacao(mLocacao, MdlConexaoBD.conectionPadrao)
                Dim mFrmAlterarLocacao As New FrmAlteraLocacao
                mFrmAlterarLocacao.fLocacao = mLocacao
                mFrmAlterarLocacao.ShowDialog()
                mFrmAlterarLocacao = Nothing
                locacaoDAO.TrazListaMovimentacaoNaoFinalizada(MdlConexaoBD.mdlListLocacoesNaoFinalizadas, MdlConexaoBD.conectionPadrao)
                ExecutaF5()

            Else
                MsgBox("Seleciona uma locação para Alterar")
            End If
        Catch ex As Exception
            MsgBox("Não existe no momento Locação para Alterar")
        End Try


    End Sub

    Private Sub dtg_locacoes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_locacoes.CellContentDoubleClick

        Select Case e.ColumnIndex
            Case 3 'Tempo final
                AlterarLocacao()
        End Select
    End Sub

    Private Sub btnImprimirTermo_Click(sender As Object, e As EventArgs) Handles btnImprimirTermo.Click

        Try

            If dtg_locacoes.CurrentRow.IsNewRow = False Then 'SE tiver Selecionado alguma linha...

                _mLocacao.mId = dtg_locacoes.CurrentRow.Cells(0).Value
                locacaoDAO.TrazMovimentacao(_mLocacao, MdlConexaoBD.conectionPadrao)
                TermoResponsabilidadeDAO.Traztermo(_mTermo, MdlConexaoBD.conectionPadrao)
                ExecutaF6()
                
            End If
        Catch ex As Exception
        End Try

    End Sub

#Region "Configuracao Impressao"

    Sub setImpressao()

        Dim valor As Int16 = 0
        pdRelatorio.DefaultPageSettings.Margins.Left = valor
        pdRelatorio.DefaultPageSettings.Margins.Top = valor
        pdRelatorio.DefaultPageSettings.Margins.Right = valor
        pdRelatorio.DefaultPageSettings.Margins.Bottom = valor

        pdRelatorio.PrinterSettings.DefaultPageSettings.Margins.Left = valor
        pdRelatorio.PrinterSettings.DefaultPageSettings.Margins.Top = valor
        pdRelatorio.PrinterSettings.DefaultPageSettings.Margins.Right = valor
        pdRelatorio.PrinterSettings.DefaultPageSettings.Margins.Bottom = valor

        PrintDialog1.PrinterSettings = pdRelatorio.PrinterSettings


    End Sub

    Private Sub InicializaRelatorio(ByVal sender As Object, ByVal Relatorio As System.Drawing.Printing.PrintEventArgs)

        If MostrarCaixaImpressoras Then


            Dim Impressora As New PrintDialog
            Impressora.AllowCurrentPage = True : Impressora.AllowSomePages = True
            If Impressora.ShowDialog() = DialogResult.Cancel Then

                Relatorio.Cancel = True

            Else

                Try

                    pdRelatorio.PrinterSettings = Impressora.PrinterSettings
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End If
        End If
        MostrarCaixaImpressoras = True


    End Sub

    Private Sub rptGravaTermoResponsabilidade(ByVal sender As Object, ByVal Relatorio As System.Drawing.Printing.PrintPageEventArgs)

        'Auxiliar:
        Dim rtBox As New RichTextBox

        'Asssumindo as Margens definidas pela impressora padrão
        Dim margemEsq As Single = Relatorio.MarginBounds.Left
        Dim margemSup As Single = Relatorio.MarginBounds.Top
        Dim margemDir As Single = Relatorio.MarginBounds.Right
        Dim margemInf As Single = Relatorio.MarginBounds.Bottom

        margemDir = 700 : margemEsq = 15 : margemInf += 40

        'Trabalhando com Fontes
        Dim mFonteNormal, mFonteTitulo, mFonteTermo, mFonteCondicoesTermo, mFonteAssinatura, mFonteCPF, mFonteProd As Font
        mFonteNormal = New Font("Times New Roman", 11, FontStyle.Regular)
        mFonteProd = New Font("Times New Roman", 10, FontStyle.Regular)
        mFonteTitulo = New Font("Times New Roman", 12, FontStyle.Bold)
        mFonteTermo = New Font("Times New Roman", 10, FontStyle.Bold)
        mFonteCondicoesTermo = New Font("Courier New", 9, FontStyle.Bold)
        mFonteAssinatura = New Font("Courier New", 8.5, FontStyle.Regular)
        mFonteCPF = New Font("Times New Roman", 9, FontStyle.Bold)

        Dim mValoresFormat As New StringFormat
        mValoresFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

        Dim posiY_aux As Int16 = -5
        Dim mLinhaAtualLetras As Double = 0, mLinhaAtualAux As Double = 0.0
        Dim mLinhaAtualImagem As Integer = 0

        Dim montaSTR As String = ""
        Dim montaStrAux As String = ""

        mLinhaAtualLetras -= 6


        'Montando o Relatorio:
        '1º TITULO DO COMPROVANTE...
        Relatorio.Graphics.DrawString(":::COMPROVANTE:::", mFonteTitulo, Brushes.Black, 55, 30, New StringFormat())

        '2º DATA/HORARIO; INICIO E FIM; NOME DO BRINQUEDO...
        'DATA HORARIO
        montaSTR = "Data: " & Format(_mLocacao.mData, "dd/MM/yyyy") & " / Horario: " & _mLocacao.mTempoInicial
        montaSTR = funcoes.CentralizaSTR(montaSTR, 40)
        Relatorio.Graphics.DrawString(montaSTR, mFonteNormal, Brushes.Black, margemEsq, 60, New StringFormat())
        'Tempo Inicial e Final
        montaSTR = "Inicial: " & _mLocacao.mTempoInicial & "  -  Final: " & _mLocacao.mTempoFinal
        montaSTR = funcoes.CentralizaSTR(montaSTR, 46)
        Relatorio.Graphics.DrawString(montaSTR, mFonteNormal, Brushes.Black, margemEsq, 75, New StringFormat())
        'NOME BRINQUEDO
        montaSTR = funcoes.CentralizaSTR(_mLocacao.mProdutoNome, 34)
        Relatorio.Graphics.DrawString(montaSTR, mFonteProd, Brushes.Black, margemEsq + 3, 93, New StringFormat())

        '3º TITULO DO TERMO...
        montaSTR = funcoes.CentralizaSTR("TERMO DE RESPONSABILIDADE", 32)
        Relatorio.Graphics.DrawString(montaSTR, mFonteTermo, Brushes.Black, margemEsq, 130, New StringFormat())

        '4º TERMOS DO RELATORIO...
        'Termo1:
        rtBox.Text = _mTermo.trTermo1
        mLinhaAtualAux = 150
        For Each l As String In rtBox.Lines
            Relatorio.Graphics.DrawString(l, mFonteCondicoesTermo, Brushes.Black, margemEsq, mLinhaAtualAux, New StringFormat())
            mLinhaAtualAux += 15
        Next

        'Termo2:
        rtBox.Text = _mTermo.trTermo2
        mLinhaAtualAux += 10
        For Each l As String In rtBox.Lines
            Relatorio.Graphics.DrawString(l, mFonteCondicoesTermo, Brushes.Black, margemEsq, mLinhaAtualAux, New StringFormat())
            mLinhaAtualAux += 15
        Next
       
        'Termo3:
        rtBox.Text = _mTermo.trTermo3
        mLinhaAtualAux += 10
        For Each l As String In rtBox.Lines
            'montaStrAux = Mid(montaSTR, 1, 32) : montaSTR = Mid(montaSTR, 33)
            Relatorio.Graphics.DrawString(l, mFonteCondicoesTermo, Brushes.Black, margemEsq, mLinhaAtualAux, New StringFormat())
            mLinhaAtualAux += 15
        Next

        'Termo4:
        rtBox.Text = _mTermo.trTermo4
        mLinhaAtualAux += 10
        For Each l As String In rtBox.Lines
            Relatorio.Graphics.DrawString(l, mFonteCondicoesTermo, Brushes.Black, margemEsq, mLinhaAtualAux, New StringFormat())
            mLinhaAtualAux += 15
        Next

        mLinhaAtualAux += 23
        '5º ASSINATURA DO RESPONSAVEL...
        Relatorio.Graphics.DrawString("______________________________________", mFonteCPF, Brushes.Black, 25, mLinhaAtualAux, New StringFormat())
        Relatorio.Graphics.DrawString("( Assinatura do Responsavel )", mFonteAssinatura, Brushes.Black, 35, mLinhaAtualAux + 20, New StringFormat())

        mLinhaAtualAux += 55
        '6º CPF...
        Relatorio.Graphics.DrawString("CPF: _______________________________", mFonteCPF, Brushes.Black, margemEsq, mLinhaAtualAux, New StringFormat())


        Relatorio.HasMorePages = False

    End Sub

    Sub ExecutaF6()

        executaRelatorioTermo("", "\Locadora\Termo\TermoResponsabilidade.txt")

    End Sub

    Private Sub executaRelatorioTermo(ByVal unidadePC As String, ByVal arqSaida As String)

        'Grava informações da(s) Nota(s) no arquivo de saida...
        Dim mArqTemp As String = "\Locadora\Termo\TMP_TermoResponsabilidade.TMP"
        Dim fs As New FileStream(mArqTemp, FileMode.Create, FileAccess.ReadWrite)
        Dim s As New StreamWriter(fs)

        _PrintFont = New Font("Lucida Console", 7) '126 Quebras de Linha padrao para esta configuração

        'Preparar Relatorio do Termo
        Dim lShouldReturn As Boolean
        Imprimir()
        If lShouldReturn Then Return

        MostrarCaixaImpressoras = False
        _StringToPrint = ""
        s.Close()
        fs.Dispose()

    End Sub

    Sub Imprimir()

        Try


            'IMPRESSÃO COM GRAFICOS     ...............................

            'cria uma nova instância do objeto PrintPreviewDialog
            Dim objPrintPreview As New PrintPreviewDialog
            objPrintPreview = PrintPreviewDialog1

            'define algumas propriedades do obejto
            With objPrintPreview

                'indica qual o documento vai ser visualizado
                .Document = pdRelatorio
                .WindowState = FormWindowState.Normal
                .PrintPreviewControl.Zoom = 1   'maxima a visualização
                .Text = "Termo de Responsabilidade"
                .Width = 270
                .Height = 600

                'exibe a janela de visualização para o usuário
                .ShowDialog()


            End With

            objPrintPreview = Nothing : _leitorTabela.Close()

        Catch ex As Exception
        End Try

    End Sub

#End Region

    Private Sub cboTempo_Leave(sender As Object, e As EventArgs) Handles cboTempo.Leave
        txtValorTotal.Text = Round((tempo.tTempo * CDbl(txtValorMinuto.Text)), 2).ToString("0.00")
    End Sub

End Class