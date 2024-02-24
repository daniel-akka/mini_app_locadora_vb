Imports System.Text
Imports System.Data
Imports System.Math
Imports Npgsql

Public Class FrmCadAtendente

    Dim atendente As New ClAtendente
    Dim atendenteDao As New ClAtendenteDAO
    Dim funcoes As New ClFuncoes

    Dim tipoOperacao As String = "I"

    Private Sub FrmCadAtendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExecutaF5()
    End Sub

    Private Sub FrmCadAtendente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F3
                ExecutaF3()
            Case Keys.F5
                ExecutaF5()

            Case Keys.Delete
                ExecuteDel()
        End Select

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If IsNumeric(txtIdAtendente.Text) Then atendente.aId = CInt(txtIdAtendente.Text)
        atendente.aNome = Trim(txtAtendente.Text)
        If atendenteDao.ValidaAtendente(atendente, tipoOperacao) = False Then Return

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
                atendenteDao.incAtendente(atendente, connection, transacao)
                transacao.Commit()

            Else

                Dim transacao As NpgsqlTransaction = connection.BeginTransaction
                atendenteDao.altAtendente(atendente, connection, transacao)
                transacao.Commit()

            End If

            MsgBox("ATENDENTE Salvo com Sucesso!", MsgBoxStyle.Exclamation)
            atendenteDao.TrazListAtendentes(MdlConexaoBD.mdlListAtendentes, MdlConexaoBD.conectionPadrao)
            txtAtendente.Text = "" : txtIdAtendente.Text = ""
            atendente.ZeraValores()
            ExecutaF5()
            tipoOperacao = "I"
        Catch ex As Exception
            MsgBox("ERRO:: " & ex.Message)
        Finally
            connection.ClearPool() : connection.Close() : connection = Nothing
        End Try

    End Sub

    Sub ExecutaF5()
        atendenteDao.PreencheCboatendentes(CboAtendente, MdlConexaoBD.conectionPadrao)
    End Sub

    Sub ExecuteDel()

        If CboAtendente.SelectedIndex < 0 Then MsgBox("Selecione um ATENDENTE para Excluir!") : Return
        If MessageBox.Show("Deseja Realmente Deletar o ATENDENTE -> """ & CboAtendente.SelectedItem & """ ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.Yes Then


            atendente.aNome = CboAtendente.SelectedItem
            atendenteDao.TrazAtendenteNome(atendente, MdlConexaoBD.conectionPadrao)


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
                atendenteDao.delAtendente(atendente, conection, transacao)
                transacao.Commit() : conection.ClearPool() : conection.Close()
                MsgBox("ATENDENTE Deletado com Sucesso!", MsgBoxStyle.Exclamation)
                atendenteDao.TrazListAtendentes(MdlConexaoBD.mdlListAtendentes, MdlConexaoBD.conectionPadrao)
                ExecutaF5()
                tipoOperacao = "I"
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

    End Sub

    Sub ExecutaF3()
        If CboAtendente.SelectedIndex < 0 Then MsgBox("Selecione um ATENDENTE para Alterar!") : Return
        atendente.aNome = CboAtendente.SelectedItem
        atendenteDao.TrazAtendenteNome(atendente, MdlConexaoBD.conectionPadrao)

        tipoOperacao = "A"
        txtIdAtendente.Text = atendente.aId
        txtAtendente.Text = atendente.aNome
        txtAtendente.Focus()

    End Sub

End Class