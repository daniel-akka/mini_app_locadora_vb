Public Class FrmMotivoCancelamento

    Public _MotivoCancelamento As New String("")
    Public _confirmaCancelamento As Boolean = False

    Private Sub FrmMotivoCancelamento_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If Trim(txtBoxCancelamento.Text).Equals("") Then MsgBox("Informe um motivo para o CANCELAMENTO!") : txtBoxCancelamento.Focus() : Return
        _MotivoCancelamento = Trim(txtBoxCancelamento.Text)
        _confirmaCancelamento = True
        Me.Close()
    End Sub

End Class