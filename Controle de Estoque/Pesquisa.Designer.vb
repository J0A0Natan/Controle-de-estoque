<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa
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
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnGerenciar = New System.Windows.Forms.Button()
        Me.btnHistorico = New System.Windows.Forms.Button()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResultado
        '
        Me.dgvResultado.AllowUserToAddRows = False
        Me.dgvResultado.AllowUserToDeleteRows = False
        Me.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultado.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultado.Location = New System.Drawing.Point(12, 69)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        Me.dgvResultado.Size = New System.Drawing.Size(901, 380)
        Me.dgvResultado.TabIndex = 0
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(267, 27)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(289, 20)
        Me.txtPesquisa.TabIndex = 1
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(572, 27)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 20)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(6, 19)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(107, 17)
        Me.rbNome.TabIndex = 3
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome do produto"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(119, 19)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(101, 17)
        Me.rbData.TabIndex = 4
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data de criação"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbData)
        Me.GroupBox1.Controls.Add(Me.rbNome)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 50)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar por:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(267, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(289, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'btnGerenciar
        '
        Me.btnGerenciar.Location = New System.Drawing.Point(838, 26)
        Me.btnGerenciar.Name = "btnGerenciar"
        Me.btnGerenciar.Size = New System.Drawing.Size(75, 20)
        Me.btnGerenciar.TabIndex = 8
        Me.btnGerenciar.Text = "Gerenciar"
        Me.btnGerenciar.UseVisualStyleBackColor = True
        '
        'btnHistorico
        '
        Me.btnHistorico.Location = New System.Drawing.Point(757, 26)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(75, 20)
        Me.btnHistorico.TabIndex = 9
        Me.btnHistorico.Text = "Historico"
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'Pesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 461)
        Me.Controls.Add(Me.btnHistorico)
        Me.Controls.Add(Me.btnGerenciar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.dgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Pesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa"
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbData As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnGerenciar As Button
    Friend WithEvents btnHistorico As Button
End Class
