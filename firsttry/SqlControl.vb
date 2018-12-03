Imports System.Data.SqlClient
Imports System.Data
Public Class SqlControl
    Private con As New SqlClient.SqlConnection("Data Source=PUSHPARAJ\PUSHPARAJ;Initial Catalog=School;Integrated Security=True")
    Private cmd As New SqlClient.SqlCommand

    Public adapter As New SqlClient.SqlDataAdapter
    Public data As New DataSet

    Public prams As New List(Of SqlClient.SqlParameter)

    Public count As Integer
    Public exep As String

    Public Sub ExecSql(query As String)
        Try
            con.Open()
            cmd = New SqlClient.SqlCommand(query, con)
            prams.ForEach(Sub(x) cmd.Parameters.Add(x))
            prams.Clear()
            data = New DataSet
            adapter = New SqlClient.SqlDataAdapter(cmd)
            count = adapter.Fill(data, query)
            con.Close()
        Catch ex As Exception
            exep = ex.Message
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Public Sub ExecProc(query As String)
        Try
            con.Open()
            cmd = New SqlClient.SqlCommand(query, con)
            prams.ForEach(Sub(x) cmd.Parameters.Add(x))
            prams.Clear()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            exep = ex.Message
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Public Sub addprams(name As String, value As Object)
        Dim para As New SqlClient.SqlParameter(name, value)
        prams.Add(para)
    End Sub
End Class




