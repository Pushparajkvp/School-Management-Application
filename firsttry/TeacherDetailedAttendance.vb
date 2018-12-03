Public Class TeacherDetailedAttendance
    Dim sql As New SqlControl
    Dim bind As New BindingSource
    Private Sub TeacherDetailedAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources._1459676288_cmyk_04
        dtp.Value = New Date(Now.Year, Now.Month, Now.Day)
        sql.ExecSql("Select *from teacher")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If

        For j = 1 To sql.count
            If cboname.Items.Contains(sql.data.Tables(0).Rows(j - 1)("name")) = False Then
                cboname.Items.Add(sql.data.Tables(0).Rows(j - 1)("name"))
            End If
        Next
        Me.Icon = My.Resources._1459676288_cmyk_04
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        sql.addprams("@name", cboname.Text)
        sql.addprams("@date", dtp.Value)
        sql.ExecSql("select *From dbo.show_Tattendancenamedate(@name,@date)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub TeacherDetailedAttendance_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        TeachersAttendance.Show()
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        If dtp.Value > Now.Date Then
            dtp.Value = Now.Date
            Exit Sub
        End If
        If cboname.Text <> "" Then
            cboname_SelectedIndexChanged(sender, e)
        Else
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select *from dbo.show_Tattendance(@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            bind.DataSource = sql.data.Tables(0)
            DataGridView1.DataSource = bind
        End If
    End Sub

    Private Sub bnsingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnsingle.Click
        sql.addprams("@name", cboname.Text)
        sql.ExecSql("select *from dbo.show_Tattendances(@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub
    Dim index As Integer = 1
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

            Dim height As Integer = 250
            Dim fontss As New Font("Arial", 22)


            Dim fonts As New Font("Arial", 16)
            Dim rectangles As New Rectangle



            rectangles = New Rectangle(20, 200, 250, 50)
            e.Graphics.DrawRectangle(Pens.Black, rectangles)
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
            e.Graphics.DrawString("Name", fontss, Brushes.Black, 22, 210)

            rectangles = New Rectangle(270, 200, 240, 50)
            e.Graphics.DrawRectangle(Pens.Black, rectangles)
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
            e.Graphics.DrawString("Date", fonts, Brushes.Black, 272, 210)


            rectangles = New Rectangle(510, 200, 250, 50)
            e.Graphics.DrawRectangle(Pens.Black, rectangles)
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
            e.Graphics.DrawString("Present/Absent", fonts, Brushes.Black, 512, 210)


        For j = index To sql.count
            e.Graphics.DrawRectangle(Pens.Black, 20, height, 250, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(j - 1)("Staff Name"), fonts, Brushes.Brown, 22, height + 10)
            e.Graphics.DrawRectangle(Pens.Black, 270, height, 240, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(j - 1)("Date"), fonts, Brushes.Brown, 272, height + 10)
            e.Graphics.DrawRectangle(Pens.Black, 510, height, 250, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(j - 1)("P/A"), fonts, Brushes.Brown, 512, height + 10)


            height += 50
            If height > 1000 Then
                index = j + 1
                e.HasMorePages = True
                Exit Sub
            End If

        Next
    End Sub

    Private Sub bnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnprint.Click
        PrintDocument1.Print()
    End Sub
End Class