<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionarEstoque
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblQuantAtual = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantidade atual"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(70, 174)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(62, 20)
        Me.txtValor.TabIndex = 1
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuantAtual
        '
        Me.lblQuantAtual.AutoSize = True
        Me.lblQuantAtual.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantAtual.Location = New System.Drawing.Point(90, 105)
        Me.lblQuantAtual.Name = "lblQuantAtual"
        Me.lblQuantAtual.Size = New System.Drawing.Size(22, 26)
        Me.lblQuantAtual.TabIndex = 2
        Me.lblQuantAtual.Text = "0"
        Me.lblQuantAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Adicionar:"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(70, 200)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(62, 23)
        Me.btnAdicionar.TabIndex = 4
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Produto"
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(42, 35)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.ReadOnly = True
        Me.txtProd.Size = New System.Drawing.Size(121, 20)
        Me.txtProd.TabIndex = 6
        Me.txtProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AdicionarEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 255)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuantAtual)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdicionarEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar ao Estoque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblQuantAtual As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProd As TextBox
End Class
