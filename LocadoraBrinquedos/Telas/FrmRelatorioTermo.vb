Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class FrmRelatorioTermo

    Public _TermoResponsabilidade As New ClTermoResponsabilidade
    Public _Locacao As New ClMovimentacao
    Private WithEvents _evento As ReportViewer

    Private Sub FrmRelatorioTermo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listLocacao As New List(Of ClMovimentacao)
        listLocacao.Add(_Locacao)

        Dim listTermo As New List(Of ClTermoResponsabilidade)
        listTermo.Add(_TermoResponsabilidade)

        rvTermoResponsabilidade.LocalReport.DataSources.Clear()
        rvTermoResponsabilidade.LocalReport.ReportEmbeddedResource = "LocadoraBrinquedos.ReportRelatorioTermo.rdlc"
        Dim ds1 As New Microsoft.Reporting.WinForms.ReportDataSource("DtImpressaoDadosBrinquedo", listLocacao)
        Dim ds2 As New Microsoft.Reporting.WinForms.ReportDataSource("DtImpressaoTermo", listTermo)

        Me.rvTermoResponsabilidade.LocalReport.DataSources.Add(ds1)
        Me.rvTermoResponsabilidade.LocalReport.DataSources.Add(ds2)
        ds1.Value = listLocacao
        ds2.Value = listTermo

        rvTermoResponsabilidade.LocalReport.Refresh()
        Me.rvTermoResponsabilidade.RefreshReport()
        _evento = Me.rvTermoResponsabilidade
    End Sub

    Sub SetaCamposImpressao()

        'txtDataHorario.Text = "Data: " & _Locacao.mData.ToShortDateString & " / Horario: " & _Locacao.mTempoInicial.ToLongTimeString
        'txtTmpInicioFinal.Text = "Inicio: " & _Locacao.mTempoInicial.ToLongTimeString & " até Fim: " & _Locacao.mTempoFinal.ToLongTimeString
        'txtNomeBrinquedo.Text = _Locacao.mProdutoNome

        'rtbTermo1.Text = "- " & _TermoResponsabilidade.trTermo1
        'rtbTermo2.Text = "- " & _TermoResponsabilidade.trTermo2
        'rtbTermo3.Text = "- " & _TermoResponsabilidade.trTermo3

    End Sub

    Private Sub FrmRelatorioTermo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.P
                '_evento.p
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

End Class