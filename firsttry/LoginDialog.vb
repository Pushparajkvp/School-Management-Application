Public Class LoginDialog
    Dim sql As New SqlControl
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Enter your Username and password !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        sql.addprams("@name", UsernameTextBox.Text)
        sql.addprams("@pass", PasswordTextBox.Text)
        sql.ExecSql("Select * from users where username = @name and pass = @pass")
        If sql.count = 0 Then
            MessageBox.Show("Invalid Username or Password", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
            Exit Sub
        Else
            MainInterface.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676300_Login_Manager
        Dim sql As New SqlControl
        sql.ExecProc("exec update_fees")
    End Sub
End Class
