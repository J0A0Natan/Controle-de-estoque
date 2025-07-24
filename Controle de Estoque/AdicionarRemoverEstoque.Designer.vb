<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionarRemoverEstoque
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Adicionar = New System.Windows.Forms.TabPage()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuantAtual = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Remover = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Adicionar.SuspendLayout()
        Me.Remover.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Adicionar)
        Me.TabControl1.Controls.Add(Me.Remover)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(174, 288)
        Me.TabControl1.TabIndex = 0
        '
        'Adicionar
        '
        Me.Adicionar.Controls.Add(Me.txtProd)
        Me.Adicionar.Controls.Add(Me.Label3)
        Me.Adicionar.Controls.Add(Me.btnAdicionar)
        Me.Adicionar.Controls.Add(Me.Label2)
        Me.Adicionar.Controls.Add(Me.lblQuantAtual)
        Me.Adicionar.Controls.Add(Me.txtValor)
        Me.Adicionar.Controls.Add(Me.Label1)
        Me.Adicionar.Location = New System.Drawing.Point(4, 22)
        Me.Adicionar.Name = "Adicionar"
        Me.Adicionar.Padding = New System.Windows.Forms.Padding(3)
        Me.Adicionar.Size = New System.Drawing.Size(166, 262)
        Me.Adicionar.TabIndex = 0
        Me.Adicionar.Text = "Adicionar"
        Me.Adicionar.UseVisualStyleBackColor = True
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(23, 50)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.ReadOnly = True
        Me.txtProd.Size = New System.Drawing.Size(121, 20)
        Me.txtProd.TabIndex = 13
        Me.txtProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Produto"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(51, 215)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(62, 23)
        Me.btnAdicionar.TabIndex = 11
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Adicionar:"
        '
        'lblQuantAtual
        '
        Me.lblQuantAtual.AutoSize = True
        Me.lblQuantAtual.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantAtual.Location = New System.Drawing.Point(71, 120)
        Me.lblQuantAtual.Name = "lblQuantAtual"
        Me.lblQuantAtual.Size = New System.Drawing.Size(22, 26)
        Me.lblQuantAtual.TabIndex = 9
        Me.lblQuantAtual.Text = "0"
        Me.lblQuantAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(51, 189)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(62, 20)
        Me.txtValor.TabIndex = 8
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantidade atual"
        '
        'Remover
        '
        Me.Remover.Controls.Add(Me.TextBox1)
        Me.Remover.Controls.Add(Me.Label4)
        Me.Remover.Controls.Add(Me.btnRemover)
        Me.Remover.Controls.Add(Me.Label5)
        Me.Remover.Controls.Add(Me.Label6)
        Me.Remover.Controls.Add(Me.TextBox2)
        Me.Remover.Controls.Add(Me.Label7)
        Me.Remover.Location = New System.Drawing.Point(4, 22)
        Me.Remover.Name = "Remover"
        Me.Remover.Padding = New System.Windows.Forms.Padding(3)
        Me.Remover.Size = New System.Drawing.Size(166, 262)
        Me.Remover.TabIndex = 1
        Me.Remover.Text = "Remover"
        Me.Remover.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Produto"
        '
        'btnRemover
        '
        Me.btnRemover.CausesValidation = False
        Me.btnRemover.Location = New System.Drawing.Point(51, 215)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(62, 23)
        Me.btnRemover.TabIndex = 18
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Remover:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 26)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "0"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(51, 189)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 20)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Quantidade atual"
        '
        'AdicionarRemoverEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 312)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdicionarRemoverEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar/Remover"
        Me.TabControl1.ResumeLayout(False)
        Me.Adicionar.ResumeLayout(False)
        Me.Adicionar.PerformLayout()
        Me.Remover.ResumeLayout(False)
        Me.Remover.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Adicionar As TabPage
    Friend WithEvents Remover As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRemover As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuantAtual As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
End Class
