Public Class ManageUsers
    Private Sub bnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnsubmit.Click
        If txtpass.Text = "" Or txtrepass.Text = "" Or txtsecurity.Text = "" Or txtusername.Text = "" Then
            MsgBox("Please fill up The above fields", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If txtpass.Text <> txtrepass.Text Then
            MsgBox("Your password and confirmation password does not match", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If txtsecurity.Text <> "vinu" Then
            MsgBox("Your authentication password does not match", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim sql As New SqlControl
        sql.addprams("@name", txtusername.Text)
        sql.ExecSql("select *From users where username =@name")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        If sql.count <> 0 Then
            MsgBox("There is already a user with that name please select a different username!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim sql1 As New SqlControl
        sql1.addprams("@name", txtfullname.Text)
        sql1.addprams("@user", txtusername.Text)
        sql1.addprams("@pass", txtpass.Text)
        sql1.addprams("@pic", PictureBox1.ImageLocation)
        sql1.ExecSql("insert into Users(name,pass,picture,username) values(@user,@pass,@pic,@user)")
        If sql1.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        MsgBox("The new User Details hav been added to the database :)", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        txtfullname.Clear()
        txtpass.Clear()
        txtrepass.Clear()
        txtsecurity.Clear()
        txtusername.Clear()
        PictureBox1.Image = Nothing
        txtusername.Focus()
        ManageUsers_Load(sender, e)

    End Sub

    Private Sub bndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndelete.Click
        If lstusernames.Text = "" Then
            MsgBox("Please Slect a Username from the above list box first :) ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If lstusernames.Items.Count = 1 Then
            MsgBox("You cannt delete this user because you need atleast 1 user to log in the software!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim sql As New SqlControl
        sql.addprams("@user", lstusernames.Text)
        sql.ExecSql("delete from users where username = @user")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        ManageUsers_Load(sender, e)
    End Sub

    Private Sub ManageUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676551_add_user
        Dim sql As New SqlControl
        sql.ExecSql("Select username from users order by username asc")
        lstusernames.Items.Clear()
        If sql.count <> 0 Then
            For j = 1 To sql.count
                lstusernames.Items.Add(sql.data.Tables(0).Rows(j - 1)("username"))
            Next
        End If
    End Sub

    Private Sub bnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnload.Click
        With OpenFileDialog1
            .Title = "Select a Jpeg photo"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else
                PictureBox1.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub bnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclear.Click
        Try
            PictureBox1.Image = Nothing
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class