Public Class AdicionarRemoverEstoque
    Private helperSql As New HelperSQL
    Private resultBd
    Private quantAtual
    Private nomeProd

    Private Sub AdicionarEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtulizaDados()
        AcceptButton = btnAdicionar
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If Not String.IsNullOrWhiteSpace(txtValor.Text) Then
            If helperSql.Update_("produtos", New Dictionary(Of String, Object) From {{"quantidade", quantAtual + Integer.Parse(txtValor.Text)}}, "id", Form1.IdSelecionado) Then
                Dim dadosMov As New Dictionary(Of String, Object) From {
                    {"id_produto", Form1.IdSelecionado},
                    {"tipo", "entrada"},
                    {"quantidade", Integer.Parse(txtValor.Text)},
                    {"data_mov", Date.Now}
                }
                helperSql.Insert_("movimentacoes", dadosMov)
                MessageBox.Show($"Adicionado {txtValor.Text} ao estoque!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtValor.Text = ""
                AtulizaDados()
            End If
        End If
    End Sub

    Private Sub AtulizaDados()
        resultBd = helperSql.Select_(New List(Of String) From {"nome", "quantidade"}, "produtos", "id", Form1.IdSelecionado)
        nomeProd = resultBd.Rows(0)("nome")
        quantAtual = resultBd.Rows(0)("quantidade")
        txtProd.Text = nomeProd
        lblQuantAtual.Text = quantAtual
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        ' Permite somente números e controle (como backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignora a tecla
        End If
    End Sub
End Class