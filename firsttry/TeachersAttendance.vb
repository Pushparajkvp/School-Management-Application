Public Class TeachersAttendance
    Dim cotn As Integer = 0
    Private Sub TeachersAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676288_cmyk_04
        dtp.Value = New Date(Now.Year, Now.Month, Now.Day)
        grphidden.Visible = True
        grpbox.Visible = False
        see()
    End Sub
    Sub clicky(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql2 As New SqlControl
        sql2.ExecSql("Select * from teacher")
        If sql2.exep <> "" Then
            MsgBox(sql2.exep)
            Exit Sub
        End If

        Dim num As Integer = 1
        For j = 1 To sql2.count
            If sender Is pan.Controls("Names" + num.ToString) Then
                Dim sql1 As New SqlControl
                sql1.addprams("@name", pan.Controls("Names" + num.ToString).Text)
                sql1.ExecSql("Select *From dbo.teacher_shows(@name)")
                If sql1.exep <> "" Then
                    MsgBox(sql1.exep)
                    Exit Sub
                End If
                Picbox1.ImageLocation = sql1.data.Tables(0).Rows(0)("Picture")
                lbldesig.Text = sql1.data.Tables(0).Rows(0)("Designation")
                lblgender.Text = sql1.data.Tables(0).Rows(0)("Gender")
                lbltname.Text = sql1.data.Tables(0).Rows(0)("Staff Name")
                lblleaves.Text = sql1.data.Tables(0).Rows(0)("leave")
            End If
            num += 1
        Next
        grphidden.Visible = False
        grpbox.Visible = True
        dates()
    End Sub

    Private Sub see()
        If cotn > 0 Then
            Dim num As Integer = 1
            For j = 1 To cotn
                pan.Controls("Combos" + num.ToString).Dispose()
                pan.Controls("Names" + num.ToString).Dispose()
                num += 1
            Next
        End If
        cotn = 0
        Try
            pan.Controls("bnload").Dispose()
        Catch ex As Exception
        End Try
        Dim sql As New SqlControl
        sql.addprams("@date", dtp.Value)
        sql.ExecSql("select * from dbo.show_Tattendance(@date)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        If sql.count <> 0 Then
            Dim arraysize As Integer
            arraysize = sql.count
            Dim combos(arraysize) As ComboBox
            Dim lables(arraysize) As Label
            Dim fonts As New Font("Arial", 12)
            Dim num As Integer = 1
            Dim yy As Integer = 100
            For j = 1 To sql.count
                combos(j) = New ComboBox
                combos(j).Name = "Combos" + num.ToString
                combos(j).Location = New Point(300, yy)
                combos(j).Size = New Size(140, 24)
                combos(j).Text = sql.data.Tables(0).Rows(j - 1)("P/A")
                pan.Controls.Add(combos(j))

                lables(j) = New Label
                lables(j).Name = "Names" + num.ToString
                lables(j).Location = New Point(50, yy)
                lables(j).Size = New Size(140, 24)
                lables(j).Font = fonts
                lables(j).Text = sql.data.Tables(0).Rows(j - 1)("Staff Name")
                pan.Controls.Add(lables(j))
                AddHandler lables(j).Click, AddressOf clicky

                yy += 50
                num += 1
                cotn += 1
            Next
            cbofill.Enabled = False

        Else
            Dim sqls As New SqlControl
            sqls.ExecSql("select * from teacher")
            If sqls.exep <> "" Then
                MsgBox(sqls.exep)
                Exit Sub
            End If
            Dim arraysize As Integer
            arraysize = sqls.count
            Dim combos(arraysize) As ComboBox
            Dim lables(arraysize) As Label
            Dim fonts As New Font("Arial", 12)
            Dim num As Integer = 1
            Dim butt As Button
            Dim buttfont As New Font("Arial", 22)
            Dim yy As Integer = 100
            For j = 1 To sqls.count
                combos(j) = New ComboBox
                combos(j).Name = "Combos" + num.ToString
                combos(j).Location = New Point(300, yy)
                combos(j).Size = New Size(140, 24)
                combos(j).Items.Add("Present")
                combos(j).Items.Add("Absent")
                pan.Controls.Add(combos(j))

                lables(j) = New Label
                lables(j).Name = "Names" + num.ToString
                lables(j).Location = New Point(50, yy)
                lables(j).Size = New Size(140, 24)
                lables(j).Font = fonts
                lables(j).Text = sqls.data.Tables(0).Rows(j - 1)("name")
                pan.Controls.Add(lables(j))
                AddHandler lables(j).Click, AddressOf clicky

                yy += 50
                num += 1
                cotn += 1
            Next

            butt = New Button
            butt.Name = "bnload"
            butt.Text = "Save"
            butt.Font = buttfont
            butt.Location = New Point(75, yy + 50)
            butt.Size = New Size(400, 100)
            AddHandler butt.Click, AddressOf saves
            pan.Controls.Add(butt)
            cbofill.Enabled = True
        End If
        grphidden.Visible = True
        grpbox.Visible = False

        boons = True
    End Sub
    Dim boons As Boolean
    Sub saves(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sqls As New SqlControl
        sqls.ExecSql("select * from teacher")
        If sqls.exep <> "" Then
            MsgBox(sqls.exep)
            Exit Sub
        End If
        Dim num As Integer = 1
        For j = 1 To sqls.count
            If pan.Controls("Combos" + num.ToString).Text = "" Then
                MessageBox.Show("You cannot leave a field blank", "Fill all up", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            num += 1
        Next


        num = 1

        For j = 1 To sqls.count
            Dim sql As New SqlControl
            sql.addprams("@name", sqls.data.Tables(0).Rows(j - 1)("name"))
            sql.addprams("@date", dtp.Value)
            Dim combo As New ComboBox
            combo = pan.Controls("Combos" + num.ToString)
            sql.addprams("@at", combo.SelectedIndex + 1)
            sql.ExecProc("exec insert_Tat @name,@date,@at")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            num += 1
        Next
        see()
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        If dtp.Value.Date > Now.Date Then
            dtp.Value = Now.Date
            Exit Sub
        End If
        see()
        cbofill.Text = ""
    End Sub

    Private Sub cbofill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofill.SelectedIndexChanged
        If boons = True Then
            Dim sqls As New SqlControl
            sqls.ExecSql("select * from teacher")
            If sqls.exep <> "" Then
                MsgBox(sqls.exep)
                Exit Sub
            End If
            Dim num As Integer = 1
            For j = 1 To sqls.count
                Dim combo As New ComboBox
                combo = pan.Controls("Combos" + num.ToString)
                If cbofill.SelectedIndex = 0 Then
                    combo.SelectedIndex = 0
                Else
                    combo.SelectedIndex = 1
                End If
                num += 1
            Next
        End If
    End Sub

    Private Sub pan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pan.Click
        grphidden.Visible = True
        grpbox.Visible = False
    End Sub
    Private Sub dates()
        lstbo.Items.Clear()
        Dim sql As New SqlControl
        sql.addprams("@date", Val(dtp.Value.Month))
        sql.addprams("@name", lbltname.Text)
        sql.ExecSql("select * from dbo.get_datess(@name,@date)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If

        For j = 1 To sql.count
            If lstbo.Items.Contains(sql.data.Tables(0).Rows(j - 1)("date")) = False Then
                lstbo.Items.Add(sql.data.Tables(0).Rows(j - 1)("date"))
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TeacherDetailedAttendance.Show()
        TeacherDetailedAttendance.MdiParent = MainInterface
        Me.Hide()

    End Sub
End Class