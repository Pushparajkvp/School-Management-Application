Public Class Selection

    Private Sub teacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teacher.Click
        If TeachersAttendance.IsHandleCreated Then
            TeachersAttendance.Close()
            TeachersAttendance.Show()
            TeachersAttendance.MdiParent = MainInterface
        Else
            TeachersAttendance.Show()
            TeachersAttendance.MdiParent = MainInterface
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If StudentsAt.IsHandleCreated Then
            StudentsAt.Close()
            StudentsAt.Show()
            StudentsAt.MdiParent = MainInterface
        Else
            StudentsAt.Show()
            StudentsAt.MdiParent = MainInterface
        End If
    End Sub

    Private Sub Selection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676787_19
    End Sub
End Class