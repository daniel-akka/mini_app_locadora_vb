Imports Npgsql

Public Class ClConfiguracoesDAO

    Public Sub altConfiguracoes(ByVal Config As ClConfiguracoes, ByVal strConection As String)

        Dim comm As New NpgsqlCommand
        Dim sql As String = ""
        Dim conexao As New NpgsqlConnection(strConection)
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""AtendenteDAO:TrazAtendente"":: " & ex.Message)
            Return
        End Try

        sql = "UPDATE configuracoes SET limite_desconto = @limite_desconto, senha_padrao = @senha_padrao WHERE idconfg = @idconfg"

        comm = New NpgsqlCommand(sql, conexao)
        ' Prepara Paramentros
        comm.Parameters.Add("@idconfg", Config.tId)
        comm.Parameters.Add("@limite_desconto", Config.tLimiteDesconto)
        comm.Parameters.Add("@senha_padrao", Config.tSenhaPadrao)

        comm.ExecuteNonQuery()

        comm = Nothing : sql = Nothing
    End Sub

    Public Function TrazConfiguracoesID(ByRef Config As ClConfiguracoes, ByVal strConection As String) As Boolean

        Dim conexao As New NpgsqlConnection(strConection)
        Dim dr As NpgsqlDataReader
        Dim com As NpgsqlCommand
        Dim consulta As String = ""

        Try
            conexao.Open()
        Catch ex As Exception
            MsgBox("ERRO ao Abrir conexão em ""TempoDAO:TrazTempo"":: " & ex.Message)
            Return False
        End Try

        consulta = "SELECT idconfg, limite_desconto, senha_padrao FROM configuracoes WHERE idconfg = 1"
        com = New NpgsqlCommand(consulta, conexao)
        dr = com.ExecuteReader

        While dr.Read

            Config.tId = dr(0)
            Config.tLimiteDesconto = dr(1)
            Config.tSenhaPadrao = dr(2).ToString

        End While
        dr.Close()
        com.Dispose()
        conexao.Close()
        com.Dispose()

        Return True
    End Function

End Class
