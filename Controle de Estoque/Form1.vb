Public Class Form1
    Private prod As New Produto
    Public Shared IdSelecionado
    Private linhaSelecionada

    Private Sub SetIdSelecionado()
        IdSelecionado = dgvProdutos.CurrentRow.Cells("id").Value
    End Sub

    Private Sub SetLinhaSelecionada()
        linhaSelecionada = dgvProdutos.CurrentRow.Index
    End Sub

    Private Sub AtualizaDgv()
        dgvProdutos.DataSource = prod.SelectAllProdutos
        dgvProdutos.CurrentCell = dgvProdutos.Rows(linhaSelecionada).Cells("Produto")
        dgvProdutos.Rows(linhaSelecionada).Selected = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaDgv()
        dgvProdutos.Columns("id").Visible = False
        dgvProdutos.Columns("Produto").Width = 130
        dgvProdutos.Columns("Descrição").Width = 250
        dgvProdutos.Columns("Quantidade").Width = 80
        dgvProdutos.Columns("Custo fabricação").Width = 80
        dgvProdutos.Columns("Preço de venda").Width = 80
        dgvProdutos.Columns("Criado em").Width = 120
        dgvProdutos.Columns("Modificado em").Width = 120
    End Sub

    Private Sub GerenciarProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarProdutoToolStripMenuItem.Click
        SetIdSelecionado()
        GerenciarProdutos.ShowDialog()
        SetLinhaSelecionada()
        AtualizaDgv()
    End Sub

    Private Sub HistoricoDeMovimentaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoDeMovimentaçõesToolStripMenuItem.Click
        SetIdSelecionado()
        HistoricoMovimentacoes.ShowDialog()
    End Sub

    Private Sub AdicionarAoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarAoEstoqueToolStripMenuItem.Click
        SetIdSelecionado()
        AdicionarEstoque.ShowDialog()
        SetLinhaSelecionada()
        AtualizaDgv()
    End Sub

    Private Sub RemoverDoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverDoEstoqueToolStripMenuItem.Click
        SetIdSelecionado()
        RemoverEstoque.ShowDialog()
        SetLinhaSelecionada()
        AtualizaDgv()
    End Sub
End Class
