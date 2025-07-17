Public Class AdicionarEstoque
    Private helperSql As New HelperSQL
    Private resultBd
    Private quantAtual
    Private nomeProd

    Private Sub AdicionarEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtulizaDados()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If helperSql.Update_("produtos", New Dictionary(Of String, Object) From {{"quantidade", quantAtual + Integer.Parse(txtValor.Text)}}, "id", Form1.IdSelecionado) Then
            Dim dadosMov As New Dictionary(Of String, Object) From {
                {"id_produto", Form1.IdSelecionado},
                {"tipo", "entrada"},
                {"quantidade", Integer.Parse(txtValor.Text)},
                {"data_mov", Date.Now}
            }
            helperSql.Insert_("movimentacoes", dadosMov)
            MessageBox.Show("Valor atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtValor.Text = ""
            AtulizaDados()
        End If
    End Sub

    Private Sub AtulizaDados()
        resultBd = helperSql.Select_(New List(Of String) From {"nome", "quantidade"}, "produtos", "id", Form1.IdSelecionado)
        nomeProd = resultBd.Rows(0)("nome")
        quantAtual = resultBd.Rows(0)("quantidade")
        txtProd.Text = nomeProd
        lblQuantAtual.Text = quantAtual
    End Sub
End Class