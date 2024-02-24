<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorioLocacoes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grbFiltros = New System.Windows.Forms.GroupBox()
        Me.cboAtendentes = New System.Windows.Forms.ComboBox()
        Me.cboBrinquedos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtg_locacoes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalValores = New System.Windows.Forms.TextBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdbCancelados = New System.Windows.Forms.RadioButton()
        Me.rdbFiltros = New System.Windows.Forms.RadioButton()
        Me.rdbTodos = New System.Windows.Forms.RadioButton()
        Me.idUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.locacaoInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgDesconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgTotalDesconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivoCancelamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbFiltros.SuspendLayout()
        CType(Me.dtg_locacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbFiltros
        '
        Me.grbFiltros.BackColor = System.Drawing.Color.Transparent
        Me.grbFiltros.Controls.Add(Me.cboAtendentes)
        Me.grbFiltros.Controls.Add(Me.cboBrinquedos)
        Me.grbFiltros.Controls.Add(Me.Label2)
        Me.grbFiltros.Controls.Add(Me.Label1)
        Me.grbFiltros.Location = New System.Drawing.Point(27, 89)
        Me.grbFiltros.Name = "grbFiltros"
        Me.grbFiltros.Size = New System.Drawing.Size(635, 66)
        Me.grbFiltros.TabIndex = 0
        Me.grbFiltros.TabStop = False
        Me.grbFiltros.Text = "Filtros: "
        '
        'cboAtendentes
        '
        Me.cboAtendentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtendentes.FormattingEnabled = True
        Me.cboAtendentes.Location = New System.Drawing.Point(447, 38)
        Me.cboAtendentes.Name = "cboAtendentes"
        Me.cboAtendentes.Size = New System.Drawing.Size(149, 21)
        Me.cboAtendentes.TabIndex = 1
        '
        'cboBrinquedos
        '
        Me.cboBrinquedos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrinquedos.FormattingEnabled = True
        Me.cboBrinquedos.Location = New System.Drawing.Point(9, 38)
        Me.cboBrinquedos.Name = "cboBrinquedos"
        Me.cboBrinquedos.Size = New System.Drawing.Size(386, 21)
        Me.cboBrinquedos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(444, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Atendentes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brinquedos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dt. Inicio:"
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtpInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(102, 33)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(92, 20)
        Me.dtpInicio.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dt. Final:"
        '
        'dtpFinal
        '
        Me.dtpFinal.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(298, 32)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(92, 20)
        Me.dtpFinal.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.ConcordiaDelivery.My.Resources.Resources.Busca_16x16
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(575, 49)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 33)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtg_locacoes
        '
        Me.dtg_locacoes.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_locacoes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_locacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_locacoes.BackgroundColor = System.Drawing.Color.Gray
        Me.dtg_locacoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_locacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_locacoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_locacoes.ColumnHeadersHeight = 26
        Me.dtg_locacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtg_locacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsu, Me.locacaoInfo, Me.rData, Me.tempoFinal, Me.dtgDesconto, Me.dtgTotalDesconto, Me.motivoCancelamento})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_locacoes.DefaultCellStyle = DataGridViewCellStyle9
        Me.dtg_locacoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtg_locacoes.Location = New System.Drawing.Point(0, 210)
        Me.dtg_locacoes.MultiSelect = False
        Me.dtg_locacoes.Name = "dtg_locacoes"
        Me.dtg_locacoes.ReadOnly = True
        Me.dtg_locacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_locacoes.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dtg_locacoes.RowTemplate.Height = 24
        Me.dtg_locacoes.Size = New System.Drawing.Size(686, 196)
        Me.dtg_locacoes.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtTotalValores)
        Me.GroupBox1.Controls.Add(Me.lblRegistros)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 44)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados: "
        '
        'txtTotalValores
        '
        Me.txtTotalValores.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalValores.ForeColor = System.Drawing.Color.Green
        Me.txtTotalValores.Location = New System.Drawing.Point(529, 13)
        Me.txtTotalValores.Name = "txtTotalValores"
        Me.txtTotalValores.ReadOnly = True
        Me.txtTotalValores.Size = New System.Drawing.Size(100, 27)
        Me.txtTotalValores.TabIndex = 1
        Me.txtTotalValores.Text = "0,00"
        Me.txtTotalValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRegistros.Location = New System.Drawing.Point(6, 25)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(69, 13)
        Me.lblRegistros.TabIndex = 0
        Me.lblRegistros.Text = "0 locações"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Valores R$:"
        '
        'rdbCancelados
        '
        Me.rdbCancelados.AutoSize = True
        Me.rdbCancelados.BackColor = System.Drawing.Color.Transparent
        Me.rdbCancelados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCancelados.ForeColor = System.Drawing.Color.Red
        Me.rdbCancelados.Location = New System.Drawing.Point(177, 65)
        Me.rdbCancelados.Name = "rdbCancelados"
        Me.rdbCancelados.Size = New System.Drawing.Size(95, 17)
        Me.rdbCancelados.TabIndex = 114
        Me.rdbCancelados.TabStop = True
        Me.rdbCancelados.Text = "Cancelados!"
        Me.rdbCancelados.UseVisualStyleBackColor = False
        '
        'rdbFiltros
        '
        Me.rdbFiltros.AutoSize = True
        Me.rdbFiltros.BackColor = System.Drawing.Color.Transparent
        Me.rdbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFiltros.Location = New System.Drawing.Point(107, 66)
        Me.rdbFiltros.Name = "rdbFiltros"
        Me.rdbFiltros.Size = New System.Drawing.Size(59, 17)
        Me.rdbFiltros.TabIndex = 114
        Me.rdbFiltros.Text = "Filtros"
        Me.rdbFiltros.UseVisualStyleBackColor = False
        '
        'rdbTodos
        '
        Me.rdbTodos.AutoSize = True
        Me.rdbTodos.BackColor = System.Drawing.Color.Transparent
        Me.rdbTodos.Checked = True
        Me.rdbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTodos.Location = New System.Drawing.Point(36, 65)
        Me.rdbTodos.Name = "rdbTodos"
        Me.rdbTodos.Size = New System.Drawing.Size(60, 17)
        Me.rdbTodos.TabIndex = 114
        Me.rdbTodos.TabStop = True
        Me.rdbTodos.Text = "Todos"
        Me.rdbTodos.UseVisualStyleBackColor = False
        '
        'idUsu
        '
        Me.idUsu.HeaderText = "Id"
        Me.idUsu.MaxInputLength = 13
        Me.idUsu.Name = "idUsu"
        Me.idUsu.ReadOnly = True
        Me.idUsu.Visible = False
        '
        'locacaoInfo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.locacaoInfo.DefaultCellStyle = DataGridViewCellStyle3
        Me.locacaoInfo.HeaderText = "Locação Info.:"
        Me.locacaoInfo.Name = "locacaoInfo"
        Me.locacaoInfo.ReadOnly = True
        Me.locacaoInfo.Width = 265
        '
        'rData
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.rData.DefaultCellStyle = DataGridViewCellStyle4
        Me.rData.HeaderText = "Data"
        Me.rData.Name = "rData"
        Me.rData.ReadOnly = True
        '
        'tempoFinal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "T"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.tempoFinal.DefaultCellStyle = DataGridViewCellStyle5
        Me.tempoFinal.HeaderText = "Total  R$"
        Me.tempoFinal.Name = "tempoFinal"
        Me.tempoFinal.ReadOnly = True
        Me.tempoFinal.Width = 80
        '
        'dtgDesconto
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtgDesconto.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgDesconto.HeaderText = "Desc. R$"
        Me.dtgDesconto.Name = "dtgDesconto"
        Me.dtgDesconto.ReadOnly = True
        Me.dtgDesconto.Width = 70
        '
        'dtgTotalDesconto
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green
        Me.dtgTotalDesconto.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgTotalDesconto.HeaderText = "Tatal Desc. R$"
        Me.dtgTotalDesconto.Name = "dtgTotalDesconto"
        Me.dtgTotalDesconto.ReadOnly = True
        Me.dtgTotalDesconto.Width = 110
        '
        'motivoCancelamento
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.motivoCancelamento.DefaultCellStyle = DataGridViewCellStyle8
        Me.motivoCancelamento.HeaderText = "Motivo do Cancelamento"
        Me.motivoCancelamento.Name = "motivoCancelamento"
        Me.motivoCancelamento.ReadOnly = True
        Me.motivoCancelamento.Visible = False
        Me.motivoCancelamento.Width = 265
        '
        'FrmRelatorioLocacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ConcordiaDelivery.My.Resources.Resources.backgroundTelas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 406)
        Me.Controls.Add(Me.rdbFiltros)
        Me.Controls.Add(Me.rdbTodos)
        Me.Controls.Add(Me.rdbCancelados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtg_locacoes)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.grbFiltros)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmRelatorioLocacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Locações"
        Me.grbFiltros.ResumeLayout(False)
        Me.grbFiltros.PerformLayout()
        CType(Me.dtg_locacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents cboAtendentes As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrinquedos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dtg_locacoes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents txtTotalValores As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rdbCancelados As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFiltros As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents idUsu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents locacaoInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tempoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgDesconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgTotalDesconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivoCancelamento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
