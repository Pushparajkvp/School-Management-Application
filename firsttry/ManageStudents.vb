Public Class ManageStudents
    Dim sql As New SqlControl
    Dim bind As New BindingSource
    Dim ids As Integer
    Public Sub ManageStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676203_graduation
        sql.ExecSql("select * from dbo.show_stud()")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If

        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text = "" Then
            ManageStudents_Load(sender, e)
        Else
            sql.addprams("@name", txtsearch.Text)
            sql.ExecSql("select * from dbo.show_studs(@name)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
            End If

            bind.DataSource = sql.data.Tables(0)
            DataGridView1.DataSource = bind
        End If

    End Sub

    Private Sub bnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnnew.Click
        AddStudent.ShowDialog()
        ManageStudents_Load(sender, e)
    End Sub

    Private Sub bnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnrefresh.Click
        ManageStudents_Load(sender, e)
    End Sub

    Private Sub bndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndelete.Click
        Try
            sql.addprams("@name", DataGridView1.CurrentRow.Cells(0).Value)
            sql.ExecSql("delete from students where name = @name")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
            End If
            MsgBox("The Seleteced Student's details where deleted !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageStudents_Load(sender, e)
        Catch ex As Exception
            MsgBox("The Operation could not be performed because you didnt select a Student!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnprint.Click
        sql.addprams("@id", DataGridView1.CurrentRow.Cells(0).Value)
        sql.ExecSql("Select id from students where id = dbo.getid(@id)")
        If sql.count > 0 Then
            ids = sql.data.Tables(0).Rows(0)("id")
        End If
        Edits.Show()
        Edits.MdiParent = MainInterface

    End Sub
    Public ReadOnly Property edity() As Integer
        Get
            Return ids
        End Get
    End Property

End Class