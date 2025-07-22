Imports System.Data.SqlClient

Public Class GerenciarProdutos
    Private prod As New Produto
    Private helperSql As New HelperSQL

    Private Sub GerenciarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaProds()
        cbProdutosEdit.DisplayMember = "Produto"
        cbProdutosEdit.ValueMember = "id"
        cbProdutosEdit.SelectedValue = Form1.IdSelecionado
    End Sub

    Private Sub cbProdutos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProdutosEdit.SelectedValueChanged
        If cbProdutosEdit.SelectedValue Is Nothing OrElse TypeOf cbProdutosEdit.SelectedValue Is DataRowView Then
            'Console.WriteLine("Funciona!!!--------------------------------")
            Exit Sub
        End If
        Dim colunas As New List(Of String) From {{"nome"}, {"descricao"}, {"preco_custo"}, {"preco_venda"}}
        Dim dt = helperSql.Select_(colunas, "produtos", "id", cbProdutosEdit.SelectedValue)
        txtNomeEdit.Text = dt(0)("nome")
        txtDescEdit.Text = dt(0)("descricao").ToString
        txtPrecoFabEdit.Text = dt(0)("preco_custo")
        txtPrecoVendaEdit.Text = dt(0)("preco_venda")
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvarEdit.Click
        Dim campos As New Dictionary(Of TextBox, String) From {
            {txtNomeEdit, "Nome do Produto"},
            {txtDescEdit, "Descrição"},
            {txtPrecoFabEdit, "Preço de Fabricação"},
            {txtPrecoVendaEdit, "Preço de Venda"}
        }

        If Not CamposPreenchidos(campos) Then Exit Sub

        Dim valoresEcolunas As New Dictionary(Of String, Object) From {
            {"nome", txtNomeEdit.Text},
            {"descricao", txtDescEdit.Text},
            {"preco_custo", Double.Parse(txtPrecoFabEdit.Text)},
            {"preco_venda", Double.Parse(txtPrecoVendaEdit.Text)},
            {"modified", Date.Now}}
        If prod.UpdateProduto(valoresEcolunas, "id", cbProdutosEdit.SelectedValue) Then
            MessageBox.Show("Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        Dim campos As New Dictionary(Of TextBox, String) From {
            {txtNomeCad, "Nome do Produto"},
            {txtDescCad, "Descrição"},
            {txtQuantCad, "Quantidade"},
            {txtPrecoFabCad, "Preço de Fabricação"},
            {txtPrecoVendaCad, "Preço de Venda"}
        }

        If Not CamposPreenchidos(campos) Then Exit Sub

        Dim colunasValores As New Dictionary(Of String, Object) From {
            {"nome", txtNomeCad.Text},
            {"descricao", txtDescCad.Text},
            {"quantidade", Integer.Parse(txtQuantCad.Text)},
            {"preco_custo", Double.Parse(txtPrecoFabCad.Text)},
            {"preco_venda", Double.Parse(txtPrecoVendaCad.Text)},
            {"created", Date.Now}
        }
        If prod.InsertProduto(colunasValores) Then
            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNomeCad.Text = ""
            txtDescCad.Text = ""
            txtQuantCad.Text = ""
            txtPrecoFabCad.Text = ""
            txtPrecoVendaCad.Text = ""
            AtualizaProds()
        End If
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Dim resposta As DialogResult
        resposta = MessageBox.Show("Deseja realmente excluir este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            prod.SetId(cbProdutosEdit.SelectedValue)
            If prod.DeleteProduto() Then
                MessageBox.Show("Item excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AtualizaProds()
            End If
        End If
    End Sub

    Private Sub AtualizaProds()
        cbProdutosEdit.DataSource = prod.SelectAllProdutos()
    End Sub

    Private Function CamposPreenchidos(campos As Dictionary(Of TextBox, String)) As Boolean
        For Each item In campos
            If String.IsNullOrWhiteSpace(item.Key.Text) Then
                MessageBox.Show($"O campo '{item.Value}' está vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                item.Key.Focus()
                Return False
            End If
        Next
        Return True
    End Function

End Class