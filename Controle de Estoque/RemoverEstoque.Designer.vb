<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoverEstoque
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
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuantAtual = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(44, 46)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.ReadOnly = True
        Me.txtProd.Size = New System.Drawing.Size(121, 20)
        Me.txtProd.TabIndex = 13
        Me.txtProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Produto"
        '
        'btnRemover
        '
        Me.btnRemover.CausesValidation = False
        Me.btnRemover.Location = New System.Drawing.Point(72, 211)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(62, 23)
        Me.btnRemover.TabIndex = 11
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Remover:"
        '
        'lblQuantAtual
        '
        Me.lblQuantAtual.AutoSize = True
        Me.lblQuantAtual.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantAtual.Location = New System.Drawing.Point(92, 116)
        Me.lblQuantAtual.Name = "lblQuantAtual"
        Me.lblQuantAtual.Size = New System.Drawing.Size(22, 26)
        Me.lblQuantAtual.TabIndex = 9
        Me.lblQuantAtual.Text = "0"
        Me.lblQuantAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(72, 185)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(62, 20)
        Me.txtValor.TabIndex = 8
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantidade atual"
        '
        'RemoverEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 255)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuantAtual)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RemoverEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remover do Estoque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemover As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuantAtual As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
End Class
