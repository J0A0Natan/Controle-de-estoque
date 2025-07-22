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

    Private Sub Alertas()
        Dim allProds = prod.SelectAllProdutos
        Dim cont = 0
        For Each p In allProds.Rows
            'Console.WriteLine($"Quant: {p("quantidade")}")
            If p("quantidade") < 15 Then
                cont += 1
            End If
        Next

        If cont > 0 Then
            MessageBox.Show($"Há {cont} produtos com baixo estoque!" & vbCrLf & "Eles ficarão em amarelo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        Alertas()
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

    Private Sub AdicionarAoEstoqueToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AdicionarAoEstoqueToolStripMenuItem.Click
        SetIdSelecionado()
        AdicionarEstoque.ShowDialog()
        SetLinhaSelecionada()
        AtualizaDgv()
    End Sub

    Private Sub RemoverDoEstoqueToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RemoverDoEstoqueToolStripMenuItem.Click
        SetIdSelecionado()
        RemoverEstoque.ShowDialog()
        SetLinhaSelecionada()
        AtualizaDgv()
    End Sub

    Private Sub PesquisaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisaToolStripMenuItem.Click
        Pesquisa.ShowDialog()
    End Sub

    Private Sub dgvProdutos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProdutos.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        ' Verifica se a coluna é "Quantidade"
        If dgv.Columns(e.ColumnIndex).Name = "Quantidade" Then
            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                Dim valor As Integer = Convert.ToInt32(e.Value)

                If valor < 15 Then
                    dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
                Else
                    dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        End If
    End Sub
End Class
