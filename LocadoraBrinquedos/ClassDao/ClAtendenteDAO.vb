Imports Npgsql
Public Class ClAtendenteDAO

    Public Sub incAtendente(ByVal Atendente As ClAtendente, ByVal conexao As NpgsqlConnection, ByVal transacao As NpgsqlTransaction)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""

        sql = "INSERT INTO atendente(aid, anome)"
        sql += "VALUES (DEFAULT, @anome)"

        comm.Transaction = transacao
        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@anome", Atendente.aNome)
        comm.ExecuteNonQuery()

        TrazListAtendentes(MdlConexaoBD.mdlListAtendentes, MdlConexaoBD.conectionPadrao)
        comm = Nothing : sql = Nothing
    End Sub

    Public Sub altAtendente(ByVal Atendente As ClAtendente, ByVal conexao As NpgsqlConnection, ByVal transacao As NpgsqlTransaction)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""

        sql = "UPDATE atendente SET anome = @anome WHERE aid = @aid"

        comm.Transaction = transacao
        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@aid", Atendente.aId)
        comm.Parameters.Add("@anome", Atendente.aNome)
        comm.ExecuteNonQuery()

        TrazListAtendentes(MdlConexaoBD.mdlListAtendentes, MdlConexaoBD.conectionPadrao)
        comm = Nothing : sql = Nothing
    End Sub

    Public Function ValidaAtendente(ByVal Atendente As ClAtendente, Optional ByVal Operacao As String = "I") As Boolean

        If Trim(Atendente.aNome).Equals("") Then MsgBox("Informe um NOME para o Atendente!") : Return False

        Dim consulta As String = ""
        If Operacao.Equals("I") Then
            consulta = "SELECT anome FROM atendente WHERE anome = '" & Atendente.aNome & "'"
        Else
            consulta = "SELECT anome FROM atendente WHERE aid <> " & Atendente.aId & " AND anome = '" & Atendente.aNome & "'"
        End If
        If AtendenteConsulta(Atendente, consulta, MdlConexaoBD.conectionPadrao) Then
            MsgBox("O ATENDENTE """ & Atendente.aNome & """ já existe em outro CADASTRO !") : Return False
        End If

        Return True
    End Function

    Public Sub TrazListAtendentes(ByRef Atendente As List(Of ClAtendente), ByVal strConection As String)

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:TrazAtendente"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT aid, anome FROM atendente "
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        Atendente.Clear()
        While dr.Read

            Atendente.Add(New ClAtendente(dr(0), dr(1).ToString))
        End While
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Function TrazAtendente(ByRef Atendente As ClAtendente, ByVal strConection As String) As Boolean

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:TrazAtendente"":: " & ex.Message)
            Return False
        End Try

        consulta = "SELECT aid, anome FROM atendente WHERE aid = " & Atendente.aId
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        While dr.Read

            Atendente.aId = dr(0)
            Atendente.aNome = dr(1).ToString

        End While
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

        Return True
    End Function

    Public Function TrazAtendenteNome(ByRef Atendente As ClAtendente, ByVal strConection As String) As Boolean

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:TrazAtendente"":: " & ex.Message)
            Return False
        End Try

        consulta = "SELECT aid, anome FROM atendente WHERE anome = '" & Atendente.aNome & "'"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        While dr.Read

            Atendente.aId = dr(0)
            Atendente.aNome = dr(1).ToString

        End While
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

        Return True
    End Function

    Public Sub PreencheCboAtendentes(ByRef cboAtendente As ComboBox, ByVal strConection As String, Optional ByVal condicao As String = "")

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:PreencheCboAtendentes"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT anome, aid FROM atendente "
        If Trim(condicao).Equals("") = False Then consulta += "WHERE " & condicao & " "
        consulta += "ORDER BY anome ASC"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        cboAtendente.Items.Clear()
        If dr.HasRows = True Then
            cboAtendente.AutoCompleteCustomSource.Clear()
            cboAtendente.Items.Clear()
            cboAtendente.Refresh()
            While dr.Read

                cboAtendente.AutoCompleteCustomSource.Add(dr(0).ToString) '& " - " & dr(1).ToString.PadLeft(5, " ")
                cboAtendente.Items.Add(dr(0).ToString) '& " - " & dr(1).ToString.PadLeft(5, " ")
            End While

            cboAtendente.SelectedIndex = -1
        End If
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Sub PreencheCboAtendentesLista(ByRef cboAtendente As ComboBox, ByVal listAtendentes As List(Of ClAtendente))

        If listAtendentes.Count > 0 Then

            cboAtendente.AutoCompleteCustomSource.Clear()
            cboAtendente.Items.Clear()
            cboAtendente.Refresh()

            For Each a As ClAtendente In listAtendentes

                cboAtendente.AutoCompleteCustomSource.Add(a.aNome) '& " - " & dr(1).ToString.PadLeft(5, " ")
                cboAtendente.Items.Add(a.aNome) '& " - " & dr(1).ToString.PadLeft(5, " ")
            Next
        End If

    End Sub

    Public Sub PreencheCboAtendentesRelatorio(ByRef cboAtendente As ComboBox, ByVal strConection As String, Optional ByVal condicao As String = "")

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:PreencheCboAtendentes"":: " & ex.Message)
            Return
        End Try

        consulta = "SELECT anome, aid FROM atendente "
        If Trim(condicao).Equals("") = False Then consulta += "WHERE " & condicao & " "
        consulta += "ORDER BY anome ASC"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        cboAtendente.Items.Clear()
        If dr.HasRows = True Then
            cboAtendente.AutoCompleteCustomSource.Clear()
            cboAtendente.Items.Clear()
            cboAtendente.Refresh()
            cboAtendente.AutoCompleteCustomSource.Add("< TODOS >")
            cboAtendente.Items.Add("< TODOS >")

            While dr.Read

                cboAtendente.AutoCompleteCustomSource.Add(dr(0).ToString) '& " - " & dr(1).ToString.PadLeft(5, " ")
                cboAtendente.Items.Add(dr(0).ToString) '& " - " & dr(1).ToString.PadLeft(5, " ")
            End While

            cboAtendente.SelectedIndex = -1
        End If
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

    End Sub

    Public Sub delAtendente(ByVal Atendente As ClAtendente, ByVal conexao As NpgsqlConnection, ByVal transacao As NpgsqlTransaction)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""

        sql = "DELETE FROM atendente WHERE aid = @aid"
        comm.Transaction = transacao
        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@aid", Atendente.aId)

        comm.ExecuteNonQuery()

        TrazListAtendentes(MdlConexaoBD.mdlListAtendentes, MdlConexaoBD.conectionPadrao)
        comm = Nothing : sql = Nothing

    End Sub

    Public Function AtendenteConsulta(ByRef Atendente As ClAtendente, ByVal Query As String, ByVal strConection As String) As Boolean

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:TrazTEMPO"":: " & ex.Message)
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

End Class
