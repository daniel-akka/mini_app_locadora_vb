Imports System.Text
Imports System.Data
Imports System.Math
Imports Npgsql

Public Class FrmCadProduto

    'Objetos:
    Dim produto As New ClProduto
    Dim produtoDAO As New ClProdutoDAO
    Dim funcoes As New ClFuncoes

    'Variaveis:
    Dim tipoOperacao As String = "I"

    Private Sub FrmCadProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmCadProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                ExecutaF2()
            Case Keys.F3
                ExecutaF3()
            Case Keys.F5
                ExecutaF5()
        End Select
    End Sub

    Private Sub txtCodProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProd.KeyPress, txtCapacidadeProd.KeyPress
        'permite só numeros:
        If funcoes.SoNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

#Region "Funcoes"

    Sub ZeraValores()
        Me.txtCodProd.Text = "" : Me.txtDescricaoProd.Text = "" : Me.txtCapacidadeProd.Text = ""
        Me.txtInfoProd.Text = "" : Me.txtIdProd.Text = "" : Me.txtValorMinuto.Text = "0"
    End Sub

    Sub DesabilitaCampos()
        Me.txtCodProd.ReadOnly = True : Me.txtDescricaoProd.ReadOnly = True : Me.txtCapacidadeProd.ReadOnly = True
        Me.txtInfoProd.ReadOnly = True : Me.txtValorMinuto.ReadOnly = True
        Me.btnSalvar.Enabled = False : Me.btnCancelar.Enabled = False
    End Sub

    Sub HabilitaCampos()
        Me.txtCodProd.ReadOnly = False : Me.txtDescricaoProd.ReadOnly = False : Me.txtCapacidadeProd.ReadOnly = False
        Me.txtInfoProd.ReadOnly = False : Me.txtValorMinuto.ReadOnly = False
        Me.btnSalvar.Enabled = True : Me.btnCancelar.Enabled = True
    End Sub

    Private Sub preencheDtgProdutos()

        Dim oConn As New NpgsqlConnection(MdlConexaoBD.conectionPadrao)
        Try
            oConn.Open()
        Catch ex As Exception
            MsgBox("ERRO ao ABRIR connection:: " & ex.Message, MsgBoxStyle.Exclamation, "METROSYS")
            Return

        End Try

        Dim cmd As New NpgsqlCommand
        Dim sql As New StringBuilder
        Dim dr As NpgsqlDataReader


        Try

            sql.Append("SELECT pid, pcodigo, pdescricao, pcapacidade, pinformacao, pvalorminuto FROM produto ")
            sql.Append("WHERE pdescricao LIKE @descricao ORDER BY pdescricao ASC")
            cmd = New NpgsqlCommand(sql.ToString, oConn)
            cmd.Parameters.Add("@descricao", Me.txt_pesquisa.Text & "%")
            dr = cmd.ExecuteReader

            dtg_produtos.Rows.Clear()
            If dr.HasRows = False Then Return
            Dim mTelefone As String = ""
            While dr.Read
                dtg_produtos.Rows.Add(dr(0), dr(1).ToString, dr(2).ToString, dr(3).ToString, CDbl(dr(5)).ToString("0.00"))
            End While

            dtg_produtos.Refresh() : dr.Close()
            oConn.ClearPool() : oConn.Close()
        Catch ex As Exception
            MsgBox("ERRO no SELECT dos PRODUTOS:: " & ex.Message, MsgBoxStyle.Exclamation, "METROSYS")
            Return

        End Try

        txt_qtdRegistros.Text = dtg_produtos.Rows.Count
        cmd.CommandText = ""
        sql.Remove(0, sql.ToString.Length)

        'Limpa Objetos de Memoria...
        oConn = Nothing : cmd = Nothing
        sql = Nothing : dr = Nothing



    End Sub

    Sub PreencheValoresCampos()
        txtIdProd.Text = produto.pId
        txtCodProd.Text = produto.pCodigo
        txtDescricaoProd.Text = produto.pDescricao
        txtCapacidadeProd.Text = produto.pCapacidade
        txtInfoProd.Text = produto.pInformacao
        txtValorMinuto.Text = produto.pValorMinuto
    End Sub

    Sub PreencheProdutoValores()
        If IsNumeric(txtIdProd.Text) Then produto.pId = CInt(txtIdProd.Text)
        produto.pCodigo = CInt(txtCodProd.Text)
        produto.pDescricao = txtDescricaoProd.Text
        produto.pCapacidade = CDbl(txtCapacidadeProd.Text)
        produto.pInformacao = txtInfoProd.Text
        produto.pValorMinuto = CDbl(txtValorMinuto.Text)
    End Sub

    Sub ExecutaF5()
        preencheDtgProdutos()
    End Sub

    Sub ExecutaF2()
        ZeraValores()
        HabilitaCampos()
        txtCodProd.Focus()
        tipoOperacao = "I"
    End Sub

    Sub ExecutaF3()

        If dtg_produtos.CurrentRow.IsNewRow = False Then
            produto.pId = CInt(dtg_produtos.CurrentRow.Cells(0).Value)
            produtoDAO.TrazProduto(produto, MdlConexaoBD.conectionPadrao)
            PreencheValoresCampos()
            HabilitaCampos()
            txtCodProd.Focus()
            tipoOperacao = "A"
        End If

    End Sub

    Sub ExecutaDel()
        tipoOperacao = ""
        If dtg_produtos.CurrentRow.IsNewRow = False Then
            produto.pId = CInt(dtg_produtos.CurrentRow.Cells(0).Value)
            'produtoDAO.delProduto(produto
        End If

        Try

            If dtg_produtos.CurrentRow.IsNewRow = False Then

                If MessageBox.Show("Deseja Realmente Deletar esse BRINQUEDO ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.Yes Then

                    ZeraValores() : DesabilitaCampos() : produto.ZeraValores()
                    produto.pId = CInt(dtg_produtos.CurrentRow.Cells(0).Value)


                    Dim transacao As NpgsqlTransaction
                    Dim conection As New NpgsqlConnection(MdlConexaoBD.conectionPadrao)

                    Try

                        Try
                            conection.Open()
                        Catch ex As Exception
                            MsgBox("ERRO ao ABRIR connection:: " & ex.Message, MsgBoxStyle.Exclamation, "METROSYS")
                            Return
                        End Try

                        transacao = conection.BeginTransaction
                        produtoDAO.delProduto(produto, conection, transacao)
                        transacao.Commit() : conection.ClearPool() : conection.Close()
                        ExecutaF5()
                        MsgBox("BRINQUEDO Deletado com Sucesso!", MsgBoxStyle.Exclamation)
                        produtoDAO.TrazListProdutos(MdlConexaoBD.mdlListProdutos, MdlConexaoBD.conectionPadrao)
                    Catch ex As Exception
                        MsgBox("ERRO: " & ex.Message, MsgBoxStyle.Critical)
                        Try
                            transacao.Rollback()

                        Catch ex1 As Exception
                        End Try

                    Finally
                        transacao = Nothing : conection = Nothing
                    End Try



                End If

            End If
        Catch ex As Exception
        End Try

    End Sub
#End Region

    Private Sub FrmCadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitaCampos()
        ExecutaF5()
    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        ExecutaF2()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        tipoOperacao = ""
        ZeraValores()
        DesabilitaCampos()
        txt_pesquisa.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            produto.pId = Me.txtIdProd.Text
        Catch ex As Exception
            produto.pId = 0
        End Try

        'Dados principais:
        If IsNumeric(Me.txtCodProd.Text) Then produto.pCodigo = CInt(Me.txtCodProd.Text)
        produto.pDescricao = Me.txtDescricaoProd.Text
        If IsNumeric(Me.txtCapacidadeProd.Text) Then produto.pCapacidade = CDbl(Me.txtCapacidadeProd.Text)
        produto.pInformacao = Me.txtInfoProd.Text

        If tipoOperacao.Equals("I") Then
            If produtoDAO.ValidaProduto(produto) = False Then Return
        Else
            If produtoDAO.ValidaProduto(produto, "A") = False Then Return
        End If

        PreencheProdutoValores()

        Dim connection As New NpgsqlConnection(MdlConexaoBD.conectionPadrao)
        Try


            Try
                connection.Open()
            Catch ex As Exception
                MsgBox("ERRO:: " & ex.Message)
                connection = Nothing : Return
            End Try

            If tipoOperacao.Equals("I") Then

                Dim transacao As NpgsqlTransaction = connection.BeginTransaction
                produtoDAO.incProduto(produto, connection, transacao)
                transacao.Commit()

            Else

                Dim transacao As NpgsqlTransaction = connection.BeginTransaction
                produtoDAO.altProduto(produto, connection, transacao)
                transacao.Commit()

            End If

            MsgBox("BRINQUEDO Salvo com Sucesso!", MsgBoxStyle.Exclamation)
            produtoDAO.TrazListProdutos(MdlConexaoBD.mdlListProdutos, MdlConexaoBD.conectionPadrao)
            ZeraValores()
            DesabilitaCampos()
            produto.ZeraValores()
            ExecutaF5() : txt_pesquisa.Focus()
            DesabilitaCampos() : ZeraValores()

        Catch ex As Exception
            MsgBox("ERRO:: " & ex.Message)
        Finally
            connection.ClearPool() : connection.Close() : connection = Nothing
        End Try

    End Sub

    Private Sub dtg_produtos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_produtos.CellDoubleClick

        If dtg_produtos.CurrentRow.IsNewRow = False Then
            produto.pId = CInt(dtg_produtos.CurrentRow.Cells(0).Value)
            produtoDAO.TrazProduto(produto, MdlConexaoBD.conectionPadrao)
            PreencheValoresCampos()
        End If


    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        ExecutaF3()
    End Sub

    Private Sub txt_pesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pesquisa.KeyDown
        If Keys.Enter Then preencheDtgProdutos()
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        ExecutaDel()
    End Sub

    Private Sub txtValorMinuto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorMinuto.KeyPress
        'permite só numeros virgula:
        If funcoes.SoNumerosVirgula(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
End Class