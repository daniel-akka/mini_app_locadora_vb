Public Class FrmTermoResponsabilidade

    Dim termo As New ClTermoResponsabilidade
    Dim termoDAO As New ClTermoResponsabilidadeDAO

    Private Sub FrmTermoResponsabilidade_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmTermoResponsabilidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        termoDAO.Traztermo(termo, MdlConexaoBD.conectionPadrao)
        rtbTermo1.Text = termo.trTermo1
        rtbTermo1.Font = New Font("Times New Roman", 12)

        rtbTermo2.Text = termo.trTermo2
        rtbTermo2.Font = New Font("Times New Roman", 12)

        rtbTermo3.Text = termo.trTermo3
        rtbTermo3.Font = New Font("Times New Roman", 12)

        rtbTermo4.Text = termo.trTermo4
        rtbTermo4.Font = New Font("Times New Roman", 12)
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        termo.trTermo1 = rtbTermo1.Text
        termo.trTermo2 = rtbTermo2.Text
        termo.trTermo3 = rtbTermo3.Text
        termo.trTermo4 = rtbTermo4.Text
        termoDAO.alttermo(termo, MdlConexaoBD.conectionPadrao)
        Me.Close()

    End Sub
End Class