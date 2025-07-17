Public Class Produto

    Public Property Id
    Private ReadOnly helperSql As New HelperSQL

    Public Function GetId()
        Return Id
    End Function

    Public Sub SetId(id)
        Me.Id = id
    End Sub

    Public Function SelectAllProdutos()
        Dim colunas As New List(Of String) From {
            {"id"},
            {"nome Produto"},
            {"descricao 'Descrição'"},
            {"quantidade Quantidade"},
            {"preco_custo 'Custo fabricação'"},
            {"preco_venda 'Preço de venda'"},
            {"created 'Criado em'"},
            {"modified 'Modificado em'"}
        }
        Return helperSql.Select_(colunas, "produtos", orderBy:="nome")
    End Function

    Public Function InsertProduto(colunasValores As Dictionary(Of String, Object))
        Return helperSql.Insert_("produtos", colunasValores)
    End Function

    Public Function UpdateProduto(colunasValores As Dictionary(Of String, Object), paramLink As String, paramValue As Integer)
        Return helperSql.Update_("produtos", colunasValores, paramLink, paramValue)
        'Dim setClause As New List(Of String)

        'For Each coluna In colunasValores.Keys
        '    setClause.Add($"{coluna} = @{coluna}")
        'Next

        'Dim query = $"UPDATE produtos SET {String.Join(", ", setClause)} WHERE {condicao};"

        'Using con As New SqlConnection(strCon)
        '    Using cmd As New SqlCommand(query, con)
        '        For Each cv In colunasValores
        '            cmd.Parameters.AddWithValue("@" & cv.Key, cv.Value)
        '        Next

        '        cmd.Parameters.AddWithValue(paramLink, paramValue)

        '        Try
        '            con.Open()
        '            Return cmd.ExecuteNonQuery() > 0
        '        Catch ex As Exception
        '            MessageBox.Show("ERRO: " & ex.Message, "Erro ao atualizar produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Return False
        '        End Try
        '    End Using
        'End Using
    End Function

    Public Function DeleteProduto()
        Return helperSql.Delete_("produtos", New Dictionary(Of String, Object) From {{"id", Id}})
    End Function
End Class
