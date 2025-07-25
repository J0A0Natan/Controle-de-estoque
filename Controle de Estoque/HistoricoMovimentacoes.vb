﻿Imports System.Data.SqlClient

Public Class HistoricoMovimentacoes
    Private helperSql As New HelperSQL
    Private Id

    Sub New(IdProd)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Id = IdProd
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
                    Throw
                End Try
            End Using
        End Using

        cbProds.DataSource = dt
        cbProds.DisplayMember = "nome"
        cbProds.ValueMember = "id"

        'cbProds.SelectedValue = Form1.IdSelecionado

        Dim result As Boolean = False
        For Each valor In dt.Rows
            'Console.WriteLine($"Valor: {valor("id")}")
            If valor("id") = Id Then
                'cbProds.SelectedValue = Form1.IdSelecionado
                result = True
                Exit For
            End If
        Next

        If result Then
            cbProds.SelectedValue = Id
        Else
            MessageBox.Show("Nenhum histórico encontrado!", "Históricos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Close()
        End If

    End Sub

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
End Class