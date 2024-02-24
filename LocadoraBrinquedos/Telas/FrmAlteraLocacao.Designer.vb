<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlteraLocacao
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
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.txtNovoTempo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboOperacao = New System.Windows.Forms.ComboBox()
        Me.txtTempoFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBrinquedo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboAtendente = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnFinalizar.Image = Global.ConcordiaDelivery.My.Resources.Resources.ok_16x16
        Me.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinalizar.Location = New System.Drawing.Point(374, 41)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(112, 41)
        Me.btnFinalizar.TabIndex = 5
        Me.btnFinalizar.Text = "&Confirmar!"
        Me.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'txtNovoTempo
        '
        Me.txtNovoTempo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNovoTempo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNovoTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovoTempo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNovoTempo.Location = New System.Drawing.Point(339, 32)
        Me.txtNovoTempo.Name = "txtNovoTempo"
        Me.txtNovoTempo.Size = New System.Drawing.Size(113, 23)
        Me.txtNovoTempo.TabIndex = 4
        Me.txtNovoTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Novo Tempo Final:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboOperacao)
        Me.GroupBox1.Controls.Add(Me.txtTempoFinal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtMinutos)
        Me.GroupBox1.Controls.Add(Me.txtNovoTempo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cboOperacao
        '
        Me.cboOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOperacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperacao.FormattingEnabled = True
        Me.cboOperacao.Items.AddRange(New Object() {"TOTAL", "ADD + ", "SUB   -  "})
        Me.cboOperacao.Location = New System.Drawing.Point(131, 30)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(82, 24)
        Me.cboOperacao.TabIndex = 22
        '
        'txtTempoFinal
        '
        Me.txtTempoFinal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTempoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempoFinal.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTempoFinal.Location = New System.Drawing.Point(16, 32)
        Me.txtTempoFinal.Name = "txtTempoFinal"
        Me.txtTempoFinal.ReadOnly = True
        Me.txtTempoFinal.Size = New System.Drawing.Size(81, 21)
        Me.txtTempoFinal.TabIndex = 20
        Me.txtTempoFinal.Text = "00:00:00"
        Me.txtTempoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Minutos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Operação.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Final:"
        '
        'txtMinutos
        '
        Me.txtMinutos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutos.Location = New System.Drawing.Point(240, 30)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.Size = New System.Drawing.Size(59, 23)
        Me.txtMinutos.TabIndex = 2
        Me.txtMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Brinquedo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(165, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alterar Locação!"
        '
        'cboBrinquedo
        '
        Me.cboBrinquedo.BackColor = System.Drawing.SystemColors.Info
        Me.cboBrinquedo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrinquedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboBrinquedo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrinquedo.FormattingEnabled = True
        Me.cboBrinquedo.Location = New System.Drawing.Point(103, 61)
        Me.cboBrinquedo.Name = "cboBrinquedo"
        Me.cboBrinquedo.Size = New System.Drawing.Size(252, 21)
        Me.cboBrinquedo.TabIndex = 116
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Atendente:"
        '
        'cboAtendente
        '
        Me.cboAtendente.BackColor = System.Drawing.SystemColors.Info
        Me.cboAtendente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAtendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAtendente.FormattingEnabled = True
        Me.cboAtendente.Location = New System.Drawing.Point(103, 94)
        Me.cboAtendente.Name = "cboAtendente"
        Me.cboAtendente.Size = New System.Drawing.Size(189, 21)
        Me.cboAtendente.TabIndex = 117
        '
        'FrmAlteraLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ConcordiaDelivery.My.Resources.Resources.backgroundTelas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(502, 220)
        Me.Controls.Add(Me.cboAtendente)
        Me.Controls.Add(Me.cboBrinquedo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAlteraLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alteração de Locação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents txtNovoTempo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOperacao As System.Windows.Forms.ComboBox
    Friend WithEvents txtTempoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMinutos As System.Windows.Forms.TextBox
    Friend WithEvents cboBrinquedo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboAtendente As System.Windows.Forms.ComboBox
End Class
