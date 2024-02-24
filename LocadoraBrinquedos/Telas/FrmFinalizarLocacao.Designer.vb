<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinalizarLocacao
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTempoExcedido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVlrTotalExecido = New System.Windows.Forms.TextBox()
        Me.txtVlrTempoExcedido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAtendente = New System.Windows.Forms.TextBox()
        Me.txtVlrTotalLocacao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtValorProgramado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTempoProgramado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProdNome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTempoFinal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTempAcumulado = New System.Windows.Forms.TextBox()
        Me.txtTempoInicial = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtVlrPorMinuto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(236, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Finalizar Locação!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Brinquedo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnFinalizar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAtendente)
        Me.GroupBox1.Controls.Add(Me.txtVlrTotalLocacao)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtValorProgramado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTempoProgramado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtProdNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 175)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnFinalizar.Image = Global.ConcordiaDelivery.My.Resources.Resources.ok_16x16
        Me.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinalizar.Location = New System.Drawing.Point(463, 69)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(133, 41)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "&Finalizar!"
        Me.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTempoExcedido)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtVlrTotalExecido)
        Me.GroupBox2.Controls.Add(Me.txtVlrTempoExcedido)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adicionais: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tmp Excedido!:"
        '
        'txtTempoExcedido
        '
        Me.txtTempoExcedido.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTempoExcedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempoExcedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempoExcedido.Location = New System.Drawing.Point(114, 18)
        Me.txtTempoExcedido.Name = "txtTempoExcedido"
        Me.txtTempoExcedido.ReadOnly = True
        Me.txtTempoExcedido.Size = New System.Drawing.Size(113, 21)
        Me.txtTempoExcedido.TabIndex = 18
        Me.txtTempoExcedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(411, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Total R$:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(259, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Valor:"
        '
        'txtVlrTotalExecido
        '
        Me.txtVlrTotalExecido.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtVlrTotalExecido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVlrTotalExecido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrTotalExecido.ForeColor = System.Drawing.Color.Red
        Me.txtVlrTotalExecido.Location = New System.Drawing.Point(475, 15)
        Me.txtVlrTotalExecido.Name = "txtVlrTotalExecido"
        Me.txtVlrTotalExecido.ReadOnly = True
        Me.txtVlrTotalExecido.Size = New System.Drawing.Size(91, 26)
        Me.txtVlrTotalExecido.TabIndex = 20
        Me.txtVlrTotalExecido.Text = "0,00"
        Me.txtVlrTotalExecido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVlrTempoExcedido
        '
        Me.txtVlrTempoExcedido.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtVlrTempoExcedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVlrTempoExcedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrTempoExcedido.ForeColor = System.Drawing.Color.Red
        Me.txtVlrTempoExcedido.Location = New System.Drawing.Point(305, 15)
        Me.txtVlrTempoExcedido.Name = "txtVlrTempoExcedido"
        Me.txtVlrTempoExcedido.ReadOnly = True
        Me.txtVlrTempoExcedido.Size = New System.Drawing.Size(73, 26)
        Me.txtVlrTempoExcedido.TabIndex = 20
        Me.txtVlrTempoExcedido.Text = "0,00"
        Me.txtVlrTempoExcedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(460, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Atendente:"
        '
        'txtAtendente
        '
        Me.txtAtendente.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtAtendente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAtendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtendente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtAtendente.Location = New System.Drawing.Point(463, 35)
        Me.txtAtendente.Name = "txtAtendente"
        Me.txtAtendente.ReadOnly = True
        Me.txtAtendente.Size = New System.Drawing.Size(133, 21)
        Me.txtAtendente.TabIndex = 12
        Me.txtAtendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVlrTotalLocacao
        '
        Me.txtVlrTotalLocacao.BackColor = System.Drawing.SystemColors.Info
        Me.txtVlrTotalLocacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVlrTotalLocacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrTotalLocacao.ForeColor = System.Drawing.Color.Green
        Me.txtVlrTotalLocacao.Location = New System.Drawing.Point(366, 81)
        Me.txtVlrTotalLocacao.Name = "txtVlrTotalLocacao"
        Me.txtVlrTotalLocacao.ReadOnly = True
        Me.txtVlrTotalLocacao.Size = New System.Drawing.Size(80, 26)
        Me.txtVlrTotalLocacao.TabIndex = 2
        Me.txtVlrTotalLocacao.Text = "0,00"
        Me.txtVlrTotalLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(363, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Valor Total:"
        '
        'txtDesconto
        '
        Me.txtDesconto.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.ForeColor = System.Drawing.Color.Red
        Me.txtDesconto.Location = New System.Drawing.Point(273, 84)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(56, 21)
        Me.txtDesconto.TabIndex = 17
        Me.txtDesconto.Text = "0,00"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Desc. R$:"
        '
        'txtValorProgramado
        '
        Me.txtValorProgramado.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtValorProgramado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorProgramado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorProgramado.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtValorProgramado.Location = New System.Drawing.Point(166, 84)
        Me.txtValorProgramado.Name = "txtValorProgramado"
        Me.txtValorProgramado.ReadOnly = True
        Me.txtValorProgramado.Size = New System.Drawing.Size(80, 21)
        Me.txtValorProgramado.TabIndex = 16
        Me.txtValorProgramado.Text = "0,00"
        Me.txtValorProgramado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(163, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Valor Normal:"
        '
        'txtTempoProgramado
        '
        Me.txtTempoProgramado.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTempoProgramado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempoProgramado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempoProgramado.Location = New System.Drawing.Point(16, 84)
        Me.txtTempoProgramado.Name = "txtTempoProgramado"
        Me.txtTempoProgramado.ReadOnly = True
        Me.txtTempoProgramado.Size = New System.Drawing.Size(113, 21)
        Me.txtTempoProgramado.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tempo Normal:"
        '
        'txtProdNome
        '
        Me.txtProdNome.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtProdNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdNome.Location = New System.Drawing.Point(16, 35)
        Me.txtProdNome.Name = "txtProdNome"
        Me.txtProdNome.ReadOnly = True
        Me.txtProdNome.Size = New System.Drawing.Size(350, 21)
        Me.txtProdNome.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Inicial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(130, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Final:"
        '
        'txtTempoFinal
        '
        Me.txtTempoFinal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTempoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempoFinal.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTempoFinal.Location = New System.Drawing.Point(133, 78)
        Me.txtTempoFinal.Name = "txtTempoFinal"
        Me.txtTempoFinal.ReadOnly = True
        Me.txtTempoFinal.Size = New System.Drawing.Size(81, 21)
        Me.txtTempoFinal.TabIndex = 5
        Me.txtTempoFinal.Text = "00:00:00"
        Me.txtTempoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(109, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(292, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Tmp Acumulado:"
        '
        'txtTempAcumulado
        '
        Me.txtTempAcumulado.BackColor = System.Drawing.SystemColors.Info
        Me.txtTempAcumulado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempAcumulado.ForeColor = System.Drawing.Color.Red
        Me.txtTempAcumulado.Location = New System.Drawing.Point(295, 78)
        Me.txtTempAcumulado.Name = "txtTempAcumulado"
        Me.txtTempAcumulado.ReadOnly = True
        Me.txtTempAcumulado.Size = New System.Drawing.Size(81, 21)
        Me.txtTempAcumulado.TabIndex = 6
        Me.txtTempAcumulado.Text = "00:00"
        Me.txtTempAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTempoInicial
        '
        Me.txtTempoInicial.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTempoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempoInicial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtTempoInicial.Location = New System.Drawing.Point(22, 78)
        Me.txtTempoInicial.Name = "txtTempoInicial"
        Me.txtTempoInicial.ReadOnly = True
        Me.txtTempoInicial.Size = New System.Drawing.Size(81, 21)
        Me.txtTempoInicial.TabIndex = 4
        Me.txtTempoInicial.Text = "00:00:00"
        Me.txtTempoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(482, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Minuto R$:"
        '
        'txtVlrPorMinuto
        '
        Me.txtVlrPorMinuto.BackColor = System.Drawing.SystemColors.Info
        Me.txtVlrPorMinuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVlrPorMinuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrPorMinuto.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtVlrPorMinuto.Location = New System.Drawing.Point(488, 76)
        Me.txtVlrPorMinuto.Name = "txtVlrPorMinuto"
        Me.txtVlrPorMinuto.ReadOnly = True
        Me.txtVlrPorMinuto.Size = New System.Drawing.Size(63, 23)
        Me.txtVlrPorMinuto.TabIndex = 8
        Me.txtVlrPorMinuto.Text = "0,00"
        Me.txtVlrPorMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmFinalizarLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ConcordiaDelivery.My.Resources.Resources.backgroundTelas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 285)
        Me.Controls.Add(Me.txtVlrPorMinuto)
        Me.Controls.Add(Me.txtTempAcumulado)
        Me.Controls.Add(Me.txtTempoFinal)
        Me.Controls.Add(Me.txtTempoInicial)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFinalizarLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalização de Locação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTempoProgramado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProdNome As System.Windows.Forms.TextBox
    Friend WithEvents txtAtendente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTempoExcedido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVlrTempoExcedido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorProgramado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVlrTotalLocacao As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTempoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTempAcumulado As System.Windows.Forms.TextBox
    Friend WithEvents txtTempoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtVlrPorMinuto As System.Windows.Forms.TextBox
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtVlrTotalExecido As System.Windows.Forms.TextBox
End Class
