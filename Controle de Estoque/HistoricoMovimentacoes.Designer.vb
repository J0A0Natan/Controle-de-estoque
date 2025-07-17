<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricoMovimentacoes
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
        Me.dgvHistoricoMovs = New System.Windows.Forms.DataGridView()
        Me.cbProds = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvHistoricoMovs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistoricoMovs
        '
        Me.dgvHistoricoMovs.AllowUserToAddRows = False
        Me.dgvHistoricoMovs.AllowUserToDeleteRows = False
        Me.dgvHistoricoMovs.AllowUserToOrderColumns = True
        Me.dgvHistoricoMovs.AllowUserToResizeColumns = False
        Me.dgvHistoricoMovs.AllowUserToResizeRows = False
        Me.dgvHistoricoMovs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistoricoMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistoricoMovs.Location = New System.Drawing.Point(12, 48)
        Me.dgvHistoricoMovs.Name = "dgvHistoricoMovs"
        Me.dgvHistoricoMovs.ReadOnly = True
        Me.dgvHistoricoMovs.Size = New System.Drawing.Size(441, 220)
        Me.dgvHistoricoMovs.TabIndex = 0
        '
        'cbProds
        '
        Me.cbProds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProds.FormattingEnabled = True
        Me.cbProds.Location = New System.Drawing.Point(65, 12)
        Me.cbProds.Name = "cbProds"
        Me.cbProds.Size = New System.Drawing.Size(206, 21)
        Me.cbProds.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Produto:"
        '
        'HistoricoMovimentacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 280)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProds)
        Me.Controls.Add(Me.dgvHistoricoMovs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HistoricoMovimentacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico de Movimentacoes"
        CType(Me.dgvHistoricoMovs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHistoricoMovs As DataGridView
    Friend WithEvents cbProds As ComboBox
    Friend WithEvents Label1 As Label
End Class
