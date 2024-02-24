Imports Npgsql

Public Class ClProdutoDAO

    Dim _funcoes As New ClFuncoes

    Public Sub incProduto(ByVal Produto As ClProduto, ByVal conexao As NpgsqlConnection, ByVal transacao As NpgsqlTransaction)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""

        sql = "INSERT INTO produto(pid, pdescricao, pcapacidade, pcodigo, pinformacao, pvalorminuto)"
        sql += "VALUES (DEFAULT, @pdescricao, @pcapacidade, @pcodigo, @pinformacao, @pvalorminuto)"

        comm.Transaction = transacao
        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@pdescricao", Produto.pDescricao)
        comm.Parameters.Add("@pcapacidade", Produto.pCapacidade)
        comm.Parameters.Add("@pcodigo", Produto.pCodigo)
        comm.Parameters.Add("@pinformacao", Produto.pInformacao)
        comm.Parameters.Add("@pvalorminuto", Produto.pValorMinuto)

        comm.ExecuteNonQuery()

        TrazListProdutos(MdlConexaoBD.mdlListProdutos, MdlConexaoBD.conectionPadrao)
        comm = Nothing : sql = Nothing
    End Sub

    Public Sub altProduto(ByVal Produto As ClProduto, ByVal conexao As NpgsqlConnection, ByVal transacao As NpgsqlTransaction)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""

        sql = "UPDATE produto SET pdescricao = @pdescricao, pcodigo = @pcodigo, pcapacidade = @pcapacidade, pinformacao = @pinformacao, "
        sql += "pvalorminuto = @pvalorminuto WHERE pid = @pid"

        comm.Transaction = transacao
        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@pid", Produto.pId)
        comm.Parameters.Add("@pdescricao", Produto.pDescricao)
        comm.Parameters.Add("@pcapacidade", Produto.pCapacidade)
        comm.Parameters.Add("@pcodigo", Produto.pCodigo)
        comm.Parameters.Add("@pinformacao", Produto.pInformacao)
        comm.Parameters.Add("@pvalorminuto", Produto.pValorMinuto)

        comm.ExecuteNonQuery()

        TrazListProdutos(MdlConexaoBD.mdlListProdutos, MdlConexaoBD.conectionPadrao)
        comm = Nothing : sql = Nothing
    End Sub

    Public Function ValidaProduto(ByVal Produto As ClProduto, Optional ByVal Operacao As String = "I") As Boolean
        Dim consulta As String = ""
        If Operacao.Equals("I") Then
            consulta = "SELECT pcodigo FROM produto WHERE pcodigo = " & Produto.pCodigo
        Else
            consulta = "SELECT pcodigo FROM produto WHERE pid <> " & Produto.pId & " AND pcodigo = " & Produto.pCodigo
        End If
        If ProdutoConsulta(Produto, consulta, MdlConexaoBD.conectionPadrao) Then
            MsgBox("O Codigo """ & Produto.pCodigo & """ já existe em outro Produto !") : Return False
        End If

        Return True
    End Function

    Public Function ProdutoConsulta(ByRef Produto As ClProduto, ByVal Query As String, ByVal strConection As String) As Boolean

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""ProdutoDAO:TrazPRODUTO"":: " & ex.Message)
            Return False
        End Try

        consulta = Query
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If

        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

        Return True
    End Function

    Public Function TrazProduto(ByRef Produto As ClProduto, ByVal strConection As String) As Boolean

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""ProdutoDAO:TrazPRODUTO"":: " & ex.Message)
            Return False
        End Try

        consulta = "SELECT pid, pdescricao, pcapacidade, pcodigo, pinformacao, pvalorminuto FROM produto WHERE pid = " & Produto.pId
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        While dr.Read

            Produto.pId = dr(0)
            Produto.pDescricao = dr(1).ToString
            Produto.pCapacidade = dr(2)
            Produto.pCodigo = dr(3).ToString
            Produto.pInformacao = dr(4).ToString
            Produto.pValorMinuto = dr(5)

        End While
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

        Return True
    End Function

    Public Sub TrazListProdutos(ByRef Produto As List(Of ClProduto), ByVal strConection As String)

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""ProdutoDAO:TrazPRODUTO"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT pid, pcodigo, pcapacidade, pdescricao, pinformacao, pvalorminuto FROM produto "
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        Produto.Clear()
        While dr.Read

            Produto.Add(New ClProduto(dr(0), dr(1), dr(2), dr(3).ToString, dr(4).ToString, dr(5)))
        End While
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Sub PreencheCboProdutos(ByRef cboProduto As ComboBox, ByVal strConection As String, Optional ByVal condicao As String = "")

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""ProdutoDAO:PreencheCboProdutos"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT pdescricao, pid FROM produto "
        If Trim(condicao).Equals("") = False Then consulta += "WHERE " & condicao & " "
        consulta += "ORDER BY pdescricao ASC"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        cboProduto.Items.Clear()
        If dr.HasRows = True Then
            cboProduto.AutoCompleteCustomSource.Clear()
            cboProduto.Items.Clear()
            cboProduto.Refresh()
            While dr.Read

                cboProduto.AutoCompleteCustomSource.Add(dr(0).ToString & " - " & dr(1).ToString.PadLeft(5, " "))
                cboProduto.Items.Add(dr(0).ToString & " - " & dr(1).ToString.PadLeft(5, " "))
            End While

            cboProduto.SelectedIndex = -1
        End If
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Sub PreencheCboProdutosLista(ByRef cboProduto As ComboBox, ByVal listProd As List(Of ClProduto))



        If listProd.Count > 0 Then

            cboProduto.AutoCompleteCustomSource.Clear()
            cboProduto.Items.Clear()
            cboProduto.Refresh()

            For Each p As ClProduto In listProd
                cboProduto.AutoCompleteCustomSource.Add(p.pDescricao & " - " & p.pId.ToString.PadLeft(5, " "))
                cboProduto.Items.Add(p.pDescricao & " - " & p.pId.ToString.PadLeft(5, " "))
            Next
        End If

    End Sub

    Public Sub PreencheCboProdutosRelatorio(ByRef cboProduto As ComboBox, ByVal strConection As String, Optional ByVal condicao As String = "")

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""ProdutoDAO:PreencheCboProdutos"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT pdescricao, pid FROM produto "
        If Trim(condicao).Equals("") = False Then consulta += "WHERE " & condicao & " "
        consulta += "ORDER BY pdescricao ASC"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        cboProduto.Items.Clear()
        If dr.HasRows = True Then
            cboProduto.AutoCompleteCustomSource.Clear()
            cboProduto.Items.Clear()
            cboProduto.Refresh()
            cboProduto.AutoCompleteCustomSource.Add("< TODOS >")
            cboProduto.Items.Add("< TODOS >")
            While dr.Read

                cboProduto.AutoCompleteCustomSource.Add(dr(0).ToString & " - " & dr(1).ToString.PadLeft(5, " "))
                cboProduto.Items.Add(dr(0).ToString & " - " & dr(1).ToString.PadLeft(5, " "))
            End While

            cboProduto.SelectedIndex = -1
        End If
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Sub PreencheCboProdutosConsulta(ByRef cboCliente As ComboBox, ByVal strConection As String)

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""ProdutoDAO:PreencheCboProdutos"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT pdescricao, pid FROM produto ORDER BY pdescricao ASC"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        cboCliente.Items.Clear()
        If dr.HasRows = True Then
            cboCliente.AutoCompleteCustomSource.Clear()
            cboCliente.Items.Clear()
            cboCliente.Refresh()
            While dr.Read

                cboCliente.AutoCompleteCustomSource.Add(dr(0).ToString & " - " & dr(1).ToString.PadLeft(5, " "))
                cboCliente.Items.Add(dr(0).ToString & " - " & dr(1).ToString.PadLeft(5, " "))
            End While

            cboCliente.AutoCompleteMode = AutoCompleteMode.Suggest
            cboCliente.AutoCompleteSource = AutoCompleteSource.ListItems
            cboCliente.Refresh()
            cboCliente.SelectedIndex = -1

        End If
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Sub delProduto(ByVal Produto As ClProduto, ByVal conexao As NpgsqlConnection, ByVal transacao As NpgsqlTransaction)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""

        sql = "DELETE FROM produto WHERE pid = @pid"
        comm.Transaction = transacao
        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@pid", Produto.pId)

        comm.ExecuteNonQuery()

        TrazListProdutos(MdlConexaoBD.mdlListProdutos, MdlConexaoBD.conectionPadrao)
        comm = Nothing : sql = Nothing
    End Sub

End Class
