<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimentoLocacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMovimentoLocacoes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtCapacidade = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtValorMinuto = New System.Windows.Forms.TextBox()
        Me.cboAtendente = New System.Windows.Forms.ComboBox()
        Me.cboTempo = New System.Windows.Forms.ComboBox()
        Me.cboBrinquedo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnImprimirTermo = New System.Windows.Forms.Button()
        Me.txtInfoLocacoes = New System.Windows.Forms.TextBox()
        Me.txtLocacoesExcedidas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pdRelatorio = New System.Drawing.Printing.PrintDocument()
        Me.dtg_locacoes = New System.Windows.Forms.DataGridView()
        Me.idLocacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.locacaoInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contagemAndamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempoExcedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iniciado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btn_Iniciar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnFinalizaTempo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg_locacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 23)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "             :: LOCAÇÃO DE BRINQUEDOS ::                                  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(760, 17)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "_________________________________________________________________________________" &
    "_____________"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnConfirmar)
        Me.GroupBox1.Controls.Add(Me.txtCapacidade)
        Me.GroupBox1.Controls.Add(Me.txtValorTotal)
        Me.GroupBox1.Controls.Add(Me.txtValorMinuto)
        Me.GroupBox1.Controls.Add(Me.cboAtendente)
        Me.GroupBox1.Controls.Add(Me.cboTempo)
        Me.GroupBox1.Controls.Add(Me.cboBrinquedo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(129, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 117)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Locação::  "
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnConfirmar.Image = Global.ConcordiaDelivery.My.Resources.Resources.ok_16x16
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(667, 69)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(119, 37)
        Me.btnConfirmar.TabIndex = 15
        Me.btnConfirmar.Text = "&Confirmar!"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'txtCapacidade
        '
        Me.txtCapacidade.BackColor = System.Drawing.Color.Beige
        Me.txtCapacidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidade.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCapacidade.Location = New System.Drawing.Point(170, 23)
        Me.txtCapacidade.Name = "txtCapacidade"
        Me.txtCapacidade.ReadOnly = True
        Me.txtCapacidade.Size = New System.Drawing.Size(160, 13)
        Me.txtCapacidade.TabIndex = 35
        Me.txtCapacidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.ForeColor = System.Drawing.Color.Green
        Me.txtValorTotal.Location = New System.Drawing.Point(341, 80)
        Me.txtValorTotal.MaxLength = 7
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(88, 26)
        Me.txtValorTotal.TabIndex = 11
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorMinuto
        '
        Me.txtValorMinuto.BackColor = System.Drawing.SystemColors.Info
        Me.txtValorMinuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorMinuto.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtValorMinuto.Location = New System.Drawing.Point(107, 80)
        Me.txtValorMinuto.MaxLength = 7
        Me.txtValorMinuto.Name = "txtValorMinuto"
        Me.txtValorMinuto.ReadOnly = True
        Me.txtValorMinuto.Size = New System.Drawing.Size(58, 26)
        Me.txtValorMinuto.TabIndex = 9
        Me.txtValorMinuto.Text = "0,00"
        Me.txtValorMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboAtendente
        '
        Me.cboAtendente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAtendente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAtendente.BackColor = System.Drawing.SystemColors.Window
        Me.cboAtendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAtendente.FormattingEnabled = True
        Me.cboAtendente.Location = New System.Drawing.Point(608, 39)
        Me.cboAtendente.Name = "cboAtendente"
        Me.cboAtendente.Size = New System.Drawing.Size(178, 24)
        Me.cboAtendente.TabIndex = 5
        '
        'cboTempo
        '
        Me.cboTempo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTempo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTempo.BackColor = System.Drawing.SystemColors.Window
        Me.cboTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTempo.FormattingEnabled = True
        Me.cboTempo.Location = New System.Drawing.Point(455, 40)
        Me.cboTempo.Name = "cboTempo"
        Me.cboTempo.Size = New System.Drawing.Size(77, 24)
        Me.cboTempo.TabIndex = 3
        '
        'cboBrinquedo
        '
        Me.cboBrinquedo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBrinquedo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBrinquedo.BackColor = System.Drawing.SystemColors.Window
        Me.cboBrinquedo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrinquedo.FormattingEnabled = True
        Me.cboBrinquedo.Location = New System.Drawing.Point(18, 40)
        Me.cboBrinquedo.Name = "cboBrinquedo"
        Me.cboBrinquedo.Size = New System.Drawing.Size(411, 24)
        Me.cboBrinquedo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(534, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Minutos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Valor Total R$:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(605, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Atendente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Minuto R$:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(452, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tempo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Brinquedo:"
        '
        'btnImprimirTermo
        '
        Me.btnImprimirTermo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimirTermo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnImprimirTermo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnImprimirTermo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImprimirTermo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirTermo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirTermo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnImprimirTermo.Image = Global.ConcordiaDelivery.My.Resources.Resources.Print
        Me.btnImprimirTermo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimirTermo.Location = New System.Drawing.Point(1003, 99)
        Me.btnImprimirTermo.Name = "btnImprimirTermo"
        Me.btnImprimirTermo.Size = New System.Drawing.Size(108, 78)
        Me.btnImprimirTermo.TabIndex = 115
        Me.btnImprimirTermo.Text = "&Imprimir Termo!  [F6]"
        Me.btnImprimirTermo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimirTermo.UseVisualStyleBackColor = False
        '
        'txtInfoLocacoes
        '
        Me.txtInfoLocacoes.BackColor = System.Drawing.Color.Beige
        Me.txtInfoLocacoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfoLocacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoLocacoes.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtInfoLocacoes.Location = New System.Drawing.Point(129, 183)
        Me.txtInfoLocacoes.Name = "txtInfoLocacoes"
        Me.txtInfoLocacoes.ReadOnly = True
        Me.txtInfoLocacoes.Size = New System.Drawing.Size(214, 14)
        Me.txtInfoLocacoes.TabIndex = 116
        '
        'txtLocacoesExcedidas
        '
        Me.txtLocacoesExcedidas.BackColor = System.Drawing.Color.Beige
        Me.txtLocacoesExcedidas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLocacoesExcedidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocacoesExcedidas.ForeColor = System.Drawing.Color.Red
        Me.txtLocacoesExcedidas.Location = New System.Drawing.Point(370, 183)
        Me.txtLocacoesExcedidas.Name = "txtLocacoesExcedidas"
        Me.txtLocacoesExcedidas.ReadOnly = True
        Me.txtLocacoesExcedidas.Size = New System.Drawing.Size(231, 14)
        Me.txtLocacoesExcedidas.TabIndex = 116
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Alterar Locação"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(127, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "[ F3 ]"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'dtg_locacoes
        '
        Me.dtg_locacoes.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtg_locacoes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_locacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtg_locacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtg_locacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_locacoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_locacoes.ColumnHeadersHeight = 30
        Me.dtg_locacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtg_locacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idLocacao, Me.locacaoInfo, Me.tempoInicial, Me.tempoFinal, Me.contagemAndamento, Me.tempoExcedido, Me.data, Me.Iniciado, Me.btnCancelar, Me.btn_Iniciar, Me.btnFinalizaTempo})
        Me.dtg_locacoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtg_locacoes.Location = New System.Drawing.Point(0, 203)
        Me.dtg_locacoes.MultiSelect = False
        Me.dtg_locacoes.Name = "dtg_locacoes"
        Me.dtg_locacoes.ReadOnly = True
        Me.dtg_locacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_locacoes.RowTemplate.Height = 33
        Me.dtg_locacoes.Size = New System.Drawing.Size(1157, 485)
        Me.dtg_locacoes.TabIndex = 117
        '
        'idLocacao
        '
        Me.idLocacao.HeaderText = "Id"
        Me.idLocacao.Name = "idLocacao"
        Me.idLocacao.ReadOnly = True
        Me.idLocacao.Visible = False
        '
        'locacaoInfo
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.locacaoInfo.DefaultCellStyle = DataGridViewCellStyle3
        Me.locacaoInfo.HeaderText = "Locação Info.:"
        Me.locacaoInfo.Name = "locacaoInfo"
        Me.locacaoInfo.ReadOnly = True
        Me.locacaoInfo.Width = 360
        '
        'tempoInicial
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "T"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.tempoInicial.DefaultCellStyle = DataGridViewCellStyle4
        Me.tempoInicial.HeaderText = "Inicial"
        Me.tempoInicial.Name = "tempoInicial"
        Me.tempoInicial.ReadOnly = True
        Me.tempoInicial.Width = 120
        '
        'tempoFinal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Format = "T"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.tempoFinal.DefaultCellStyle = DataGridViewCellStyle5
        Me.tempoFinal.HeaderText = "Final"
        Me.tempoFinal.Name = "tempoFinal"
        Me.tempoFinal.ReadOnly = True
        Me.tempoFinal.Width = 120
        '
        'contagemAndamento
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contagemAndamento.DefaultCellStyle = DataGridViewCellStyle6
        Me.contagemAndamento.HeaderText = "Adamento"
        Me.contagemAndamento.Name = "contagemAndamento"
        Me.contagemAndamento.ReadOnly = True
        Me.contagemAndamento.Width = 110
        '
        'tempoExcedido
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.tempoExcedido.DefaultCellStyle = DataGridViewCellStyle7
        Me.tempoExcedido.HeaderText = "Excedido"
        Me.tempoExcedido.Name = "tempoExcedido"
        Me.tempoExcedido.ReadOnly = True
        Me.tempoExcedido.Width = 120
        '
        'data
        '
        Me.data.HeaderText = "Data"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Visible = False
        '
        'Iniciado
        '
        Me.Iniciado.HeaderText = "dtg_iniciado"
        Me.Iniciado.Name = "Iniciado"
        Me.Iniciado.ReadOnly = True
        Me.Iniciado.Visible = False
        '
        'btnCancelar
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.DefaultCellStyle = DataGridViewCellStyle8
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.HeaderText = "   "
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.ReadOnly = True
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseColumnTextForButtonValue = True
        Me.btnCancelar.Width = 90
        '
        'btn_Iniciar
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Iniciar.DefaultCellStyle = DataGridViewCellStyle9
        Me.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Iniciar.HeaderText = ""
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.ReadOnly = True
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseColumnTextForButtonValue = True
        Me.btn_Iniciar.Width = 90
        '
        'btnFinalizaTempo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Green
        Me.btnFinalizaTempo.DefaultCellStyle = DataGridViewCellStyle10
        Me.btnFinalizaTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizaTempo.HeaderText = "   "
        Me.btnFinalizaTempo.Name = "btnFinalizaTempo"
        Me.btnFinalizaTempo.ReadOnly = True
        Me.btnFinalizaTempo.Text = "Finalizar!"
        Me.btnFinalizaTempo.UseColumnTextForButtonValue = True
        Me.btnFinalizaTempo.Width = 90
        '
        'FrmMovimentoLocacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ConcordiaDelivery.My.Resources.Resources.backgroundTelas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1157, 688)
        Me.Controls.Add(Me.dtg_locacoes)
        Me.Controls.Add(Me.txtLocacoesExcedidas)
        Me.Controls.Add(Me.txtInfoLocacoes)
        Me.Controls.Add(Me.btnImprimirTermo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmMovimentoLocacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOCAÇÕES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtg_locacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTempo As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrinquedo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAtendente As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorMinuto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCapacidade As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents btnConfirmar As System.Windows.Forms.Button
    Public WithEvents btnImprimirTermo As System.Windows.Forms.Button
    Friend WithEvents txtInfoLocacoes As System.Windows.Forms.TextBox
    Friend WithEvents txtLocacoesExcedidas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents pdRelatorio As System.Drawing.Printing.PrintDocument
    Friend WithEvents dtg_locacoes As System.Windows.Forms.DataGridView
    Friend WithEvents idLocacao As DataGridViewTextBoxColumn
    Friend WithEvents locacaoInfo As DataGridViewTextBoxColumn
    Friend WithEvents tempoInicial As DataGridViewTextBoxColumn
    Friend WithEvents tempoFinal As DataGridViewTextBoxColumn
    Friend WithEvents contagemAndamento As DataGridViewTextBoxColumn
    Friend WithEvents tempoExcedido As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents Iniciado As DataGridViewCheckBoxColumn
    Friend WithEvents btnCancelar As DataGridViewButtonColumn
    Friend WithEvents btn_Iniciar As DataGridViewButtonColumn
    Friend WithEvents btnFinalizaTempo As DataGridViewButtonColumn
End Class
