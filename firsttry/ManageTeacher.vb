Public Class ManageTeacher
    Dim sql As New SqlControl
    Dim bind As New BindingSource
    Private Sub ManageTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676422_Teacher_male_24
        sql.addprams("@name", TextBox1.Text)
        sql.ExecSql("Select * from dbo.teacher_show(@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnadd.Click
        AddTeacher.ShowDialog()
        ManageTeacher_Load(sender, e)
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        sql.addprams("@name", TextBox1.Text)
        sql.ExecSql("Select * from dbo.teacher_show(@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub bndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndelete.Click
        Try
            sql.addprams("@name", DataGridView1.CurrentRow.Cells(0).Value)
            sql.ExecSql("delete from teacher where name = @name")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
            End If
            MsgBox("The Seleteced Student's details where deleted !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageTeacher_Load(sender, e)
        Catch ex As Exception
            MsgBox("The Operation could not be performed because you didnt select a Teacher!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnrefresh.Click
        ManageTeacher_Load(sender, e)
    End Sub
    Private Sub bnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnprint.Click
        Me.Close()
    End Sub
End Class