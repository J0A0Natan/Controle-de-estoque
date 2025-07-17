<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GerenciarProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNomeEdit = New System.Windows.Forms.TextBox()
        Me.txtDescricaoEdit = New System.Windows.Forms.TextBox()
        Me.txtPrecoProdEdit = New System.Windows.Forms.TextBox()
        Me.txtPrecoVendaEdit = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblPrecoProd = New System.Windows.Forms.Label()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.gbEditar = New System.Windows.Forms.GroupBox()
        Me.btnSalvarEdit = New System.Windows.Forms.Button()
        Me.gbProdutos = New System.Windows.Forms.GroupBox()
        Me.cbProdutosEdit = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpEditar = New System.Windows.Forms.TabPage()
        Me.tbCadastrar = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.lblPrecoVendaCad = New System.Windows.Forms.Label()
        Me.txtPrecoVendaCad = New System.Windows.Forms.TextBox()
        Me.lblNomeCad = New System.Windows.Forms.Label()
        Me.lblPrecoFabCad = New System.Windows.Forms.Label()
        Me.txtNomeCad = New System.Windows.Forms.TextBox()
        Me.lblQuantCad = New System.Windows.Forms.Label()
        Me.txtDescCad = New System.Windows.Forms.TextBox()
        Me.lblDescCad = New System.Windows.Forms.Label()
        Me.txtQuantCad = New System.Windows.Forms.TextBox()
        Me.txtPrecoFabCad = New System.Windows.Forms.TextBox()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.gbEditar.SuspendLayout()
        Me.gbProdutos.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpEditar.SuspendLayout()
        Me.tbCadastrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNomeEdit
        '
        Me.txtNomeEdit.Location = New System.Drawing.Point(6, 46)
        Me.txtNomeEdit.Name = "txtNomeEdit"
        Me.txtNomeEdit.Size = New System.Drawing.Size(342, 20)
        Me.txtNomeEdit.TabIndex = 0
        '
        'txtDescricaoEdit
        '
        Me.txtDescricaoEdit.Location = New System.Drawing.Point(6, 85)
        Me.txtDescricaoEdit.Name = "txtDescricaoEdit"
        Me.txtDescricaoEdit.Size = New System.Drawing.Size(342, 20)
        Me.txtDescricaoEdit.TabIndex = 1
        '
        'txtPrecoProdEdit
        '
        Me.txtPrecoProdEdit.Location = New System.Drawing.Point(6, 124)
        Me.txtPrecoProdEdit.Name = "txtPrecoProdEdit"
        Me.txtPrecoProdEdit.Size = New System.Drawing.Size(342, 20)
        Me.txtPrecoProdEdit.TabIndex = 2
        '
        'txtPrecoVendaEdit
        '
        Me.txtPrecoVendaEdit.Location = New System.Drawing.Point(6, 163)
        Me.txtPrecoVendaEdit.Name = "txtPrecoVendaEdit"
        Me.txtPrecoVendaEdit.Size = New System.Drawing.Size(342, 20)
        Me.txtPrecoVendaEdit.TabIndex = 3
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(3, 30)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 4
        Me.lblNome.Text = "Nome"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(3, 69)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lblDescricao.TabIndex = 5
        Me.lblDescricao.Text = "Descrição"
        '
        'lblPrecoProd
        '
        Me.lblPrecoProd.AutoSize = True
        Me.lblPrecoProd.Location = New System.Drawing.Point(3, 108)
        Me.lblPrecoProd.Name = "lblPrecoProd"
        Me.lblPrecoProd.Size = New System.Drawing.Size(89, 13)
        Me.lblPrecoProd.TabIndex = 6
        Me.lblPrecoProd.Text = "Preço do produto"
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.Location = New System.Drawing.Point(3, 147)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(83, 13)
        Me.lblPrecoVenda.TabIndex = 7
        Me.lblPrecoVenda.Text = "Preço de venda"
        '
        'gbEditar
        '
        Me.gbEditar.Controls.Add(Me.btnSalvarEdit)
        Me.gbEditar.Controls.Add(Me.lblNome)
        Me.gbEditar.Controls.Add(Me.lblPrecoVenda)
        Me.gbEditar.Controls.Add(Me.txtNomeEdit)
        Me.gbEditar.Controls.Add(Me.lblPrecoProd)
        Me.gbEditar.Controls.Add(Me.txtDescricaoEdit)
        Me.gbEditar.Controls.Add(Me.lblDescricao)
        Me.gbEditar.Controls.Add(Me.txtPrecoProdEdit)
        Me.gbEditar.Controls.Add(Me.txtPrecoVendaEdit)
        Me.gbEditar.Location = New System.Drawing.Point(6, 113)
        Me.gbEditar.Name = "gbEditar"
        Me.gbEditar.Size = New System.Drawing.Size(357, 299)
        Me.gbEditar.TabIndex = 8
        Me.gbEditar.TabStop = False
        Me.gbEditar.Text = "Editar"
        '
        'btnSalvarEdit
        '
        Me.btnSalvarEdit.Location = New System.Drawing.Point(139, 234)
        Me.btnSalvarEdit.Name = "btnSalvarEdit"
        Me.btnSalvarEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarEdit.TabIndex = 8
        Me.btnSalvarEdit.Text = "Salvar"
        Me.btnSalvarEdit.UseVisualStyleBackColor = True
        '
        'gbProdutos
        '
        Me.gbProdutos.Controls.Add(Me.btnDeletar)
        Me.gbProdutos.Controls.Add(Me.cbProdutosEdit)
        Me.gbProdutos.Location = New System.Drawing.Point(6, 6)
        Me.gbProdutos.Name = "gbProdutos"
        Me.gbProdutos.Size = New System.Drawing.Size(357, 101)
        Me.gbProdutos.TabIndex = 9
        Me.gbProdutos.TabStop = False
        Me.gbProdutos.Text = "Produtos"
        '
        'cbProdutosEdit
        '
        Me.cbProdutosEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProdutosEdit.FormattingEnabled = True
        Me.cbProdutosEdit.Location = New System.Drawing.Point(6, 19)
        Me.cbProdutosEdit.Name = "cbProdutosEdit"
        Me.cbProdutosEdit.Size = New System.Drawing.Size(342, 21)
        Me.cbProdutosEdit.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpEditar)
        Me.TabControl1.Controls.Add(Me.tbCadastrar)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(377, 444)
        Me.TabControl1.TabIndex = 10
        '
        'tpEditar
        '
        Me.tpEditar.Controls.Add(Me.gbProdutos)
        Me.tpEditar.Controls.Add(Me.gbEditar)
        Me.tpEditar.Location = New System.Drawing.Point(4, 22)
        Me.tpEditar.Name = "tpEditar"
        Me.tpEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEditar.Size = New System.Drawing.Size(369, 418)
        Me.tpEditar.TabIndex = 0
        Me.tpEditar.Text = "Editar/Deletar"
        Me.tpEditar.UseVisualStyleBackColor = True
        '
        'tbCadastrar
        '
        Me.tbCadastrar.Controls.Add(Me.GroupBox1)
        Me.tbCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastrar.Name = "tbCadastrar"
        Me.tbCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastrar.Size = New System.Drawing.Size(369, 418)
        Me.tbCadastrar.TabIndex = 1
        Me.tbCadastrar.Text = "Cadastrar"
        Me.tbCadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCadastrar)
        Me.GroupBox1.Controls.Add(Me.lblPrecoVendaCad)
        Me.GroupBox1.Controls.Add(Me.txtPrecoVendaCad)
        Me.GroupBox1.Controls.Add(Me.lblNomeCad)
        Me.GroupBox1.Controls.Add(Me.lblPrecoFabCad)
        Me.GroupBox1.Controls.Add(Me.txtNomeCad)
        Me.GroupBox1.Controls.Add(Me.lblQuantCad)
        Me.GroupBox1.Controls.Add(Me.txtDescCad)
        Me.GroupBox1.Controls.Add(Me.lblDescCad)
        Me.GroupBox1.Controls.Add(Me.txtQuantCad)
        Me.GroupBox1.Controls.Add(Me.txtPrecoFabCad)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 406)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novo Produto"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(123, 319)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(108, 23)
        Me.btnCadastrar.TabIndex = 27
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'lblPrecoVendaCad
        '
        Me.lblPrecoVendaCad.AutoSize = True
        Me.lblPrecoVendaCad.Location = New System.Drawing.Point(6, 218)
        Me.lblPrecoVendaCad.Name = "lblPrecoVendaCad"
        Me.lblPrecoVendaCad.Size = New System.Drawing.Size(83, 13)
        Me.lblPrecoVendaCad.TabIndex = 26
        Me.lblPrecoVendaCad.Text = "Preço de venda"
        '
        'txtPrecoVendaCad
        '
        Me.txtPrecoVendaCad.Location = New System.Drawing.Point(9, 234)
        Me.txtPrecoVendaCad.Name = "txtPrecoVendaCad"
        Me.txtPrecoVendaCad.Size = New System.Drawing.Size(342, 20)
        Me.txtPrecoVendaCad.TabIndex = 24
        '
        'lblNomeCad
        '
        Me.lblNomeCad.AutoSize = True
        Me.lblNomeCad.Location = New System.Drawing.Point(6, 16)
        Me.lblNomeCad.Name = "lblNomeCad"
        Me.lblNomeCad.Size = New System.Drawing.Size(35, 13)
        Me.lblNomeCad.TabIndex = 20
        Me.lblNomeCad.Text = "Nome"
        '
        'lblPrecoFabCad
        '
        Me.lblPrecoFabCad.AutoSize = True
        Me.lblPrecoFabCad.Location = New System.Drawing.Point(6, 167)
        Me.lblPrecoFabCad.Name = "lblPrecoFabCad"
        Me.lblPrecoFabCad.Size = New System.Drawing.Size(103, 13)
        Me.lblPrecoFabCad.TabIndex = 23
        Me.lblPrecoFabCad.Text = "Preço de fabricação"
        '
        'txtNomeCad
        '
        Me.txtNomeCad.Location = New System.Drawing.Point(9, 32)
        Me.txtNomeCad.Name = "txtNomeCad"
        Me.txtNomeCad.Size = New System.Drawing.Size(342, 20)
        Me.txtNomeCad.TabIndex = 16
        '
        'lblQuantCad
        '
        Me.lblQuantCad.AutoSize = True
        Me.lblQuantCad.Location = New System.Drawing.Point(6, 115)
        Me.lblQuantCad.Name = "lblQuantCad"
        Me.lblQuantCad.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantCad.TabIndex = 22
        Me.lblQuantCad.Text = "Quantidade"
        '
        'txtDescCad
        '
        Me.txtDescCad.Location = New System.Drawing.Point(9, 81)
        Me.txtDescCad.Name = "txtDescCad"
        Me.txtDescCad.Size = New System.Drawing.Size(342, 20)
        Me.txtDescCad.TabIndex = 17
        '
        'lblDescCad
        '
        Me.lblDescCad.AutoSize = True
        Me.lblDescCad.Location = New System.Drawing.Point(6, 65)
        Me.lblDescCad.Name = "lblDescCad"
        Me.lblDescCad.Size = New System.Drawing.Size(55, 13)
        Me.lblDescCad.TabIndex = 21
        Me.lblDescCad.Text = "Descrição"
        '
        'txtQuantCad
        '
        Me.txtQuantCad.Location = New System.Drawing.Point(9, 131)
        Me.txtQuantCad.Name = "txtQuantCad"
        Me.txtQuantCad.Size = New System.Drawing.Size(342, 20)
        Me.txtQuantCad.TabIndex = 18
        '
        'txtPrecoFabCad
        '
        Me.txtPrecoFabCad.Location = New System.Drawing.Point(9, 183)
        Me.txtPrecoFabCad.Name = "txtPrecoFabCad"
        Me.txtPrecoFabCad.Size = New System.Drawing.Size(342, 20)
        Me.txtPrecoFabCad.TabIndex = 19
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(139, 62)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletar.TabIndex = 1
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'GerenciarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 468)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "GerenciarProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Produtos"
        Me.gbEditar.ResumeLayout(False)
        Me.gbEditar.PerformLayout()
        Me.gbProdutos.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpEditar.ResumeLayout(False)
        Me.tbCadastrar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNomeEdit As TextBox
    Friend WithEvents txtDescricaoEdit As TextBox
    Friend WithEvents txtPrecoProdEdit As TextBox
    Friend WithEvents txtPrecoVendaEdit As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblPrecoProd As Label
    Friend WithEvents lblPrecoVenda As Label
    Friend WithEvents gbEditar As GroupBox
    Friend WithEvents btnSalvarEdit As Button
    Friend WithEvents gbProdutos As GroupBox
    Friend WithEvents cbProdutosEdit As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpEditar As TabPage
    Friend WithEvents tbCadastrar As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrecoVendaCad As Label
    Friend WithEvents txtPrecoVendaCad As TextBox
    Friend WithEvents lblNomeCad As Label
    Friend WithEvents lblPrecoFabCad As Label
    Friend WithEvents txtNomeCad As TextBox
    Friend WithEvents lblQuantCad As Label
    Friend WithEvents txtDescCad As TextBox
    Friend WithEvents lblDescCad As Label
    Friend WithEvents txtQuantCad As TextBox
    Friend WithEvents txtPrecoFabCad As TextBox
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnDeletar As Button
End Class
