Public Class MainInterface
    Dim sqlm As New SqlControl
    Private Sub MainInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dayss As Boolean = False
        If Now.Day >= 2 Then
            dayss = True
        End If
        If dayss = False Then
            If Now.Day = 1 Then
                dayss = True
                FeesStructures.Show()
                FeesStructures.MdiParent = Me
            End If
        End If
        sqlm.ExecSql("select id from students where due>0")
        If sqlm.count <> 0 Then
            NotifyIcon1.BalloonTipText = sqlm.count & "  Students have to pay the fees"
            NotifyIcon1.BalloonTipTitle = "Fee Info"
            NotifyIcon1.ShowBalloonTip(100)
        End If
        sqlm.ExecProc("exec update_leaves")
        sqlm.ExecSql("")
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click, ToolStripButton1.Click
        If AddStudent.IsHandleCreated Then
            AddStudent.Close()
            AddStudent.Show()
            AddStudent.MdiParent = Me
        Else
            AddStudent.Show()
            AddStudent.MdiParent = Me
        End If
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        If ManageStudents.IsHandleCreated Then
            ManageStudents.Close()
            ManageStudents.Show()
            ManageStudents.MdiParent = Me
        Else
            ManageStudents.Show()
            ManageStudents.MdiParent = Me
        End If
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        If ManageTeacher.IsHandleCreated Then
            ManageTeacher.Close()
            ManageTeacher.Show()
            ManageTeacher.MdiParent = Me
        Else
            ManageTeacher.Show()
            ManageTeacher.MdiParent = Me
        End If
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        If Entermarkss.IsHandleCreated Then
            Entermarkss.Close()
            Entermarkss.Show()
            Entermarkss.MdiParent = Me
        End If
        Entermarkss.Show()
        Entermarkss.MdiParent = Me

    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        If FeesStructures.IsHandleCreated Then
            FeesStructures.Close()
            FeesStructures.Show()
            FeesStructures.MdiParent = Me
        Else
            FeesStructures.Show()
            FeesStructures.MdiParent = Me
        End If
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        If Selection.IsHandleCreated Then
            Selection.Close()
            Selection.Close()
            Selection.MdiParent = Me
        Else
            Selection.Show()
            Selection.MdiParent = Me
        End If
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        If ManageUsers.IsHandleCreated Then
            ManageUsers.Close()
            ManageUsers.Show()
            ManageUsers.MdiParent = Me
        Else
            ManageUsers.Show()
            ManageUsers.MdiParent = Me
        End If
    End Sub

    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to Exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel)
        If ask = MsgBoxResult.Ok Then
            LoginDialog.Show()
            Me.Close()
        Else
            Exit Sub

        End If
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Are you sure you want to Exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel)

        If ask = MsgBoxResult.Ok Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        AboutSMS.ShowDialog()
    End Sub
End Class
