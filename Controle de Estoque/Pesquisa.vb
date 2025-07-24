Imports System.Data.SqlClient

Public Class Pesquisa
    Private helperSql As New HelperSQL
    Private IdSelecionado

    Private Sub Pesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnPesquisar
        rbNome.Checked = True
        DateTimePicker1.Visible = False
    End Sub

    Private Sub SetIdSelecionado()
        IdSelecionado = dgvResultado.CurrentRow.Cells("id").Value
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        AtualizaDgv()
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        DateTimePicker1.Visible = Not DateTimePicker1.Visible
    End Sub

    Private Sub btnGerenciar_Click(sender As Object, e As EventArgs) Handles btnGerenciar.Click
        If dgvResultado.CurrentRow IsNot Nothing Then
            SetIdSelecionado()
            Dim form As New GerenciarProdutos(IdSelecionado)
            form.ShowDialog()
            AtualizaDgv()
        End If
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As EventArgs) Handles btnHistorico.Click
        If dgvResultado.CurrentRow IsNot Nothing Then
            SetIdSelecionado()
            Dim form As New HistoricoMovimentacoes(IdSelecionado)
            form.ShowDialog()
        End If
    End Sub

    Private Sub AtualizaDgv()
        Dim pesquisa = txtPesquisa.Text
        Dim colunaPesquisa = "nome"
        Dim colunas As New List(Of String) From {
            {"id"},
            {"nome Produto"},
            {"descricao 'Descrição'"},
            {"quantidade Quantidade"},
            {"preco_custo 'Custo de fabricação'"},
            {"preco_venda 'Preço de venda'"},
            {"created 'Criado em'"},
            {"modified 'Modificado em'"}
        }

        If rbNome.Checked = True Then
            dgvResultado.DataSource = helperSql.Select_(colunas, "produtos", colunaPesquisa, like_:=pesquisa)
        Else
            Dim d1 = DateTimePicker1.Value.Date '.ToString("yyyy-MM-dd")
            Dim d2 = d1.AddDays(1) '.ToString("yyyy-MM-dd")

            Dim query = $"SELECT {String.Join(", ", colunas)} FROM produtos WHERE created >= @d1 AND created < @d2"
            Try
                Using con As New SqlConnection(helperSql.strCon)
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@d1", d1)
                        cmd.Parameters.AddWithValue("@d2", d2)
                        con.Open()
                        Dim da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        dgvResultado.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        dgvResultado.Columns("id").Visible = False
        dgvResultado.Columns("Produto").Width = 130
        dgvResultado.Columns("Descrição").Width = 260
        dgvResultado.Columns("Quantidade").Width = 80
        dgvResultado.Columns("Custo de fabricação").Width = 80
        dgvResultado.Columns("Preço de venda").Width = 80
        dgvResultado.Columns("Criado em").Width = 120
        dgvResultado.Columns("Modificado em").Width = 120
    End Sub
End Class