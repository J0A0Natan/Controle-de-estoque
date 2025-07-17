Imports System.Data.SqlClient

Public Class HelperSQL
    Private ReadOnly server As String = "192.168.111.3\SQLEXPRESS"
    Private ReadOnly db As String = "estoque"
    Private ReadOnly user As String = "estoque"
    Private ReadOnly pass As String = "admin"
    Public ReadOnly strCon = $"Server={server};Database={db};User Id={user};Password={pass};"

    Public Function Select_(colunas As List(Of String), tabela As String, Optional coluna As String = "", Optional valor As Integer = 0, Optional orderBy As String = "") As DataTable
        Dim query = $"SELECT {String.Join(", ", colunas)} FROM {tabela} "

        If coluna <> "" Then
            query &= $"WHERE {coluna} = @{coluna}"
        End If

        If orderBy <> "" Then
            query &= $"ORDER BY {orderBy}"
        End If

        Using con As New SqlConnection(strCon)
            Using cmd As New SqlCommand(query, con)
                If coluna <> "" Then
                    cmd.Parameters.AddWithValue($"@{coluna}", valor)
                End If
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    Return dt
                Catch ex As Exception
                    Throw
                End Try
            End Using
        End Using
    End Function

    Public Function Insert_(tabela As String, colunasValores As Dictionary(Of String, Object))
        Dim colunas As New List(Of String)
        Dim paramsLink As New List(Of String)

        For Each coluna In colunasValores.Keys
            colunas.Add(coluna)
            paramsLink.Add("@" & coluna)
        Next

        Dim query = $"INSERT INTO {tabela} ({String.Join(", ", colunas)}) VALUES ({String.Join(", ", paramsLink)}) "

        Using con As New SqlConnection(strCon)
            Using cmd As New SqlCommand(query, con)
                For Each p In colunasValores
                    cmd.Parameters.AddWithValue("@" & p.Key, p.Value)
                Next
                Try
                    con.Open()
                    Return cmd.ExecuteNonQuery
                Catch ex As Exception
                    Throw
                End Try
            End Using
        End Using
    End Function

    Public Function Update_(tabela As String, colunasValores As Dictionary(Of String, Object), coluna As String, valor As Integer)
        Dim setClause As New List(Of String)
        For Each c In colunasValores
            setClause.Add(c.Key & " = @" & c.Key)
        Next
        Dim query = $"UPDATE {tabela} SET {String.Join(", ", setClause)} WHERE {coluna} = @{coluna}"
        Using con As New SqlConnection(strCon)
            Using cmd As New SqlCommand(query, con)
                For Each cv In colunasValores
                    cmd.Parameters.AddWithValue("@" & cv.Key, cv.Value)
                Next
                cmd.Parameters.AddWithValue("@" & coluna, valor)
                Try
                    con.Open()
                    Return cmd.ExecuteNonQuery
                Catch ex As Exception
                    Throw
                End Try
            End Using
        End Using
    End Function

    Public Function Delete_(tabela As String, where As Dictionary(Of String, Object))
        Dim query = $"DELETE FROM {tabela} WHERE {where.ElementAt(0).Key} = @{where.ElementAt(0).Key}"

        Using con As New SqlConnection(strCon)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue($"@{where.ElementAt(0).Key}", where.ElementAt(0).Value)
                Try
                    con.Open()
                    Return cmd.ExecuteNonQuery
                Catch ex As Exception
                    Throw
                End Try
            End Using
        End Using
    End Function
End Class
