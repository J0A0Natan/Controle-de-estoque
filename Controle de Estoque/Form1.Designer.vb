<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoDeMovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarAoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverDoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        Me.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProdutos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProdutos.Location = New System.Drawing.Point(12, 39)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.Size = New System.Drawing.Size(994, 491)
        Me.dgvProdutos.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçõesToolStripMenuItem, Me.AdicionarAoEstoqueToolStripMenuItem, Me.RemoverDoEstoqueToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AçõesToolStripMenuItem
        '
        Me.AçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesquisaToolStripMenuItem, Me.GerenciarProdutoToolStripMenuItem, Me.HistoricoDeMovimentaçõesToolStripMenuItem})
        Me.AçõesToolStripMenuItem.Name = "AçõesToolStripMenuItem"
        Me.AçõesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AçõesToolStripMenuItem.Text = "Opções"
        '
        'PesquisaToolStripMenuItem
        '
        Me.PesquisaToolStripMenuItem.Name = "PesquisaToolStripMenuItem"
        Me.PesquisaToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.PesquisaToolStripMenuItem.Text = "Pesquisa"
        '
        'GerenciarProdutoToolStripMenuItem
        '
        Me.GerenciarProdutoToolStripMenuItem.Name = "GerenciarProdutoToolStripMenuItem"
        Me.GerenciarProdutoToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.GerenciarProdutoToolStripMenuItem.Text = "Gerenciar produto"
        '
        'HistoricoDeMovimentaçõesToolStripMenuItem
        '
        Me.HistoricoDeMovimentaçõesToolStripMenuItem.Name = "HistoricoDeMovimentaçõesToolStripMenuItem"
        Me.HistoricoDeMovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.HistoricoDeMovimentaçõesToolStripMenuItem.Text = "Historico de movimentações"
        '
        'AdicionarAoEstoqueToolStripMenuItem
        '
        Me.AdicionarAoEstoqueToolStripMenuItem.Name = "AdicionarAoEstoqueToolStripMenuItem"
        Me.AdicionarAoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.AdicionarAoEstoqueToolStripMenuItem.Text = "Adicionar ao estoque"
        '
        'RemoverDoEstoqueToolStripMenuItem
        '
        Me.RemoverDoEstoqueToolStripMenuItem.Name = "RemoverDoEstoqueToolStripMenuItem"
        Me.RemoverDoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.RemoverDoEstoqueToolStripMenuItem.Text = "Remover do estoque"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 542)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Estoque"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricoDeMovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarAoEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoverDoEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisaToolStripMenuItem As ToolStripMenuItem
End Class
