Imports System.Data.SqlClient

Public Class HistoricoMovimentacoes
    Private helperSql As New HelperSQL

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProds.SelectedValueChanged
        If cbProds.SelectedValue Is Nothing OrElse TypeOf cbProds.SelectedValue Is DataRowView Then
            'Console.WriteLine("Funciona!!!--------------------------------")
            Exit Sub
        End If

        Dim query = $"
            SELECT m.tipo Tipo, m.quantidade Quantidade, m.data_mov Data
            FROM movimentacoes m
            INNER JOIN produtos p ON p.id = m.id_produto
            WHERE m.id_produto = {cbProds.SelectedValue}
            ORDER BY Data DESC"

        Dim dt As New DataTable
        Using con As New SqlConnection(helperSql.strCon)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                Catch ex As Exception

                End Try
            End Using
        End Using

        dgvHistoricoMovs.DataSource = dt
    End Sub

    Private Sub HistoricoMovimentacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = $"
            SELECT m.id_produto id, p.nome nome
            FROM movimentacoes m
            INNER JOIN produtos p ON p.id = m.id_produto
            GROUP BY m.id_produto, p.nome
            ORDER BY nome"

        Dim dt As New DataTable
        Using con As New SqlConnection(helperSql.strCon)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                Catch ex As Exception

                End Try
            End Using
        End Using

        cbProds.DataSource = dt
        cbProds.DisplayMember = "nome"
        cbProds.ValueMember = "id"

        cbProds.SelectedValue = Form1.IdSelecionado
    End Sub
End Class