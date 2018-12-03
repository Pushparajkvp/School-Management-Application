Public Class StudentsAt
    Dim cotn As Integer = 0
    Private Sub StudentsAt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676288_cmyk_04
        dtp.Value = New Date(Now.Year, Now.Month, Now.Day)
        grphidden.Visible = True
        grpbox.Visible = False
        Dim sql As New SqlControl
        sql.ExecSql("select class as [class] ,section as [section] from class")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cboclass.Items.Contains(r("class")) = False Then
                cboclass.Items.Add(r("class"))
            End If
            If cbosection.Items.Contains(r("section")) = False Then
                cbosection.Items.Add(r("section"))
            End If
        Next
        sql.ExecProc("exec update_leaves")
    End Sub
    Private Sub see()
        Dim sql2 As New SqlControl
        sql2.ExecProc("exec update_leaves")
        If cotn > 0 Then
            Dim numm As Integer = 1
            For j = 1 To cotn
                pan.Controls("Combos" + numm.ToString).Dispose()
                pan.Controls("Names" + numm.ToString).Dispose()
                numm += 1
            Next
        End If
        cotn = 0
        Try
            pan.Controls("bnload").Dispose()
        Catch ex As Exception
        End Try
        Dim sql As New SqlControl
        sql.addprams("@class", cboclass.Text)
        sql.addprams("@section", cbosection.Text)
        sql.addprams("@date", dtp.Value)
        sql.ExecSql("select * from dbo.show_stuat(@class,@section,@date) order by name asc")
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
                combos(j).Text = sql.data.Tables(0).Rows(j - 1)("at").ToString
                pan.Controls.Add(combos(j))

                lables(j) = New Label
                lables(j).Name = "Names" + num.ToString
                lables(j).Location = New Point(50, yy)
                lables(j).Size = New Size(140, 24)
                lables(j).Font = fonts
                lables(j).Text = sql.data.Tables(0).Rows(j - 1)("name")
                pan.Controls.Add(lables(j))
                AddHandler lables(j).Click, AddressOf clicky

                yy += 50
                num += 1
                cotn += 1
            Next
            cbofill.Enabled = False
        Else
            sql.addprams("@class", cboclass.Text)
            sql.addprams("@section", cbosection.Text)
            sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If

            Dim arraysize As Integer
            arraysize = sql.count
            Dim combos(arraysize) As ComboBox
            Dim lables(arraysize) As Label
            Dim fonts As New Font("Arial", 12)
            Dim num As Integer = 1
            Dim butt As Button
            Dim buttfont As New Font("Arial", 22)
            Dim yy As Integer = 100
            For j = 1 To sql.count
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
                lables(j).Text = sql.data.Tables(0).Rows(j - 1)("name")
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

            grphidden.Visible = True
            grpbox.Visible = False

            boons = True
            cbofill.Enabled = True
        End If
    End Sub
    Sub clicky(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cboclass.Text <> "" And cbosection.Text <> "" Then
            Dim sql As New SqlControl
            sql.addprams("@class", cboclass.Text)
            sql.addprams("@section", cbosection.Text)
            sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            Dim num As Integer = 1
            For j = 1 To sql.count
                If sender Is pan.Controls("Names" + num.ToString) Then
                    Dim sql1 As New SqlControl
                    sql1.addprams("@class", cboclass.Text)
                    sql1.addprams("@section", cbosection.Text)
                    sql1.addprams("@name", pan.Controls("Names" + num.ToString()).Text)
                    sql1.ExecSql("select * from dbo.show_atclassname(@class,@section,@name)")
                    PictureBox1.ImageLocation = sql1.data.Tables(0).Rows(0)("pic")
                    lblnames.Text = sql1.data.Tables(0).Rows(0)("name")
                    lblgender.Text = sql1.data.Tables(0).Rows(0)("gender")
                    lblclass.Text = sql1.data.Tables(0).Rows(0)("class")
                    lblsection.Text = sql1.data.Tables(0).Rows(0)("section")
                    lblnoholidays.Text = sql1.data.Tables(0).Rows(0)("leaves")
                    dates()
                End If
                num += 1
            Next
            grphidden.Visible = False
            grpbox.Visible = True
        Else
            MessageBox.Show("You must not leave class and section empty", "Fill Up", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub saves(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cboclass.Text <> "" And cbosection.Text <> "" Then
            Dim sql As New SqlControl
            Sql.addprams("@class", cboclass.Text)
            Sql.addprams("@section", cbosection.Text)
            Sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc")
            If Sql.exep <> "" Then
                MsgBox(Sql.exep)
                Exit Sub
            End If
            Dim num As Integer = 1
            For j = 1 To sql.count
                If pan.Controls("Combos" + num.ToString).Text = "" Then
                    MessageBox.Show("You cannot leave a field blank", "Fill all up", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                num += 1
            Next
            num = 1
            For j = 1 To sql.count
                Dim sql1 As New SqlControl
                sql1.addprams("@name", pan.Controls("Names" + num.ToString).Text)
                sql1.addprams("@date", dtp.Value)
                Dim combo As ComboBox = pan.Controls("Combos" + num.ToString())
                sql1.addprams("@at", combo.SelectedIndex + 1)
                sql1.ExecProc("exec insert_at @name,@date,@at")
                num += 1
            Next
            see()
        End If
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        If dtp.Value.Date > Now.Date Then
            dtp.Value = Now.Date
            Exit Sub
        End If
        If cboclass.Text <> "" And cbosection.Text <> "" Then
            see()
        End If
    End Sub
    Dim boons As Boolean

    Private Sub cbofill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofill.SelectedIndexChanged
        If boons = True Then
            Dim sql As New SqlControl
            If cboclass.Text <> "" And cbosection.Text <> "" Then
                Sql.addprams("@class", cboclass.Text)
                Sql.addprams("@section", cbosection.Text)
                Sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc")
                If Sql.exep <> "" Then
                    MsgBox(Sql.exep)
                    Exit Sub
                End If
                Dim num As Integer = 1
                For j = 1 To sql.count
                    Dim combo As ComboBox = pan.Controls("Combos" + num.ToString)
                    If cbofill.SelectedIndex = 0 Then
                        combo.SelectedIndex = 0
                    Else
                        combo.SelectedIndex = 1
                    End If
                    num += 1
                Next
            End If
        End If
    End Sub
    Private Sub pan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pan.Click
        grphidden.Visible = True
        grpbox.Visible = False
    End Sub
    Private Sub dates()
        ListBox1.Items.Clear()
        Dim sql As New SqlControl
        sql.addprams("@name", lblnames.Text)
        sql.addprams("@date", dtp.Value.Month)
        sql.ExecSql("select *from dbo.get_dates(@name,@date)")
        For j = 1 To sql.count
            ListBox1.Items.Add(sql.data.Tables(0).Rows(0)("dates").ToString())
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Studentsdetailedlist.Show()
        Studentsdetailedlist.MdiParent = MainInterface
        Me.Hide()
    End Sub

    Private Sub cboclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboclass.SelectedIndexChanged
        If cboclass.Text <> "" And cbosection.Text <> "" Then
            see()
        End If
    End Sub

    Private Sub cbosection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosection.SelectedIndexChanged
        If cboclass.Text <> "" And cbosection.Text <> "" Then
            see()
        End If
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cboclass.Text <> "" And cbosection.Text <> "" Then
            see()
        End If
    End Sub
End Class