<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorioTermo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rvTermoResponsabilidade = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvTermoResponsabilidade
        '
        Me.rvTermoResponsabilidade.BackColor = System.Drawing.SystemColors.Window
        Me.rvTermoResponsabilidade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvTermoResponsabilidade.Location = New System.Drawing.Point(0, 0)
        Me.rvTermoResponsabilidade.Name = "rvTermoResponsabilidade"
        Me.rvTermoResponsabilidade.ShowBackButton = False
        Me.rvTermoResponsabilidade.ShowFindControls = False
        Me.rvTermoResponsabilidade.ShowPageNavigationControls = False
        Me.rvTermoResponsabilidade.ShowZoomControl = False
        Me.rvTermoResponsabilidade.Size = New System.Drawing.Size(306, 625)
        Me.rvTermoResponsabilidade.TabIndex = 0
        '
        'FrmRelatorioTermo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 625)
        Me.Controls.Add(Me.rvTermoResponsabilidade)
        Me.Name = "FrmRelatorioTermo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Termo de Responsabilidade"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvTermoResponsabilidade As Microsoft.Reporting.WinForms.ReportViewer
End Class
