<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuS = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosMenuCadProduto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtendentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PainelPrincipal = New System.Windows.Forms.Panel()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuS.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuS
        '
        Me.MenuS.BackColor = System.Drawing.SystemColors.Info
        Me.MenuS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.MovimentaçãoToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem})
        Me.MenuS.Location = New System.Drawing.Point(0, 0)
        Me.MenuS.Name = "MenuS"
        Me.MenuS.Size = New System.Drawing.Size(629, 27)
        Me.MenuS.TabIndex = 0
        Me.MenuS.Text = "Menu"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosMenuCadProduto, Me.TemposToolStripMenuItem, Me.AtendentesToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(82, 23)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ProdutosMenuCadProduto
        '
        Me.ProdutosMenuCadProduto.Name = "ProdutosMenuCadProduto"
        Me.ProdutosMenuCadProduto.Size = New System.Drawing.Size(148, 24)
        Me.ProdutosMenuCadProduto.Text = "&Brinquedos"
        '
        'TemposToolStripMenuItem
        '
        Me.TemposToolStripMenuItem.Name = "TemposToolStripMenuItem"
        Me.TemposToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.TemposToolStripMenuItem.Text = "&Tempos"
        '
        'AtendentesToolStripMenuItem
        '
        Me.AtendentesToolStripMenuItem.Name = "AtendentesToolStripMenuItem"
        Me.AtendentesToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.AtendentesToolStripMenuItem.Text = "&Atendentes"
        '
        'MovimentaçãoToolStripMenuItem
        '
        Me.MovimentaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocaçõesToolStripMenuItem, Me.RelatórioToolStripMenuItem})
        Me.MovimentaçãoToolStripMenuItem.Name = "MovimentaçãoToolStripMenuItem"
        Me.MovimentaçãoToolStripMenuItem.Size = New System.Drawing.Size(112, 23)
        Me.MovimentaçãoToolStripMenuItem.Text = "Movimentação"
        '
        'LocaçõesToolStripMenuItem
        '
        Me.LocaçõesToolStripMenuItem.Name = "LocaçõesToolStripMenuItem"
        Me.LocaçõesToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.LocaçõesToolStripMenuItem.Text = "&Locações"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.RelatórioToolStripMenuItem.Text = "&Relatório"
        '
        'PainelPrincipal
        '
        Me.PainelPrincipal.BackgroundImage = Global.ConcordiaDelivery.My.Resources.Resources.LogoPapel
        Me.PainelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PainelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PainelPrincipal.Location = New System.Drawing.Point(0, 27)
        Me.PainelPrincipal.Name = "PainelPrincipal"
        Me.PainelPrincipal.Size = New System.Drawing.Size(629, 331)
        Me.PainelPrincipal.TabIndex = 1
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(108, 23)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ConcordiaDelivery.My.Resources.Resources.backgroundTelas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 358)
        Me.Controls.Add(Me.PainelPrincipal)
        Me.Controls.Add(Me.MenuS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuS
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locadora de Brinquedos"
        Me.MenuS.ResumeLayout(False)
        Me.MenuS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuS As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosMenuCadProduto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PainelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents AtendentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimentaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
