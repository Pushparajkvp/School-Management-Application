Public Class Studentsdetailedlist
    Dim bind As New BindingSource
    Dim sql As New SqlControl
    Private Sub Studentsdetailedlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676288_cmyk_04
        dtp.Value = New Date(Now.Year, Now.Month, Now.Day)
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
        sql.ExecSql("select name from students")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cboname.Items.Contains(r("name")) = False Then
                cboname.Items.Add(r("name"))
            End If
        Next
    End Sub

    Private Sub Studentsdetailedlist_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        StudentsAt.Show()
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        If cboclass.Text <> "" And cboname.Text <> "" And cbosection.Text <> "" Then
            sql.addprams("@name", cboname.Text)
            sql.addprams("@class", cboclass.Text)
            sql.addprams("@section", cbosection.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * from dbo.show_classsection(@name,@class,@section,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        Else
            sql.addprams("@name", cboname.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * from dbo.show_classsection(@name,default,default,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub cboclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboclass.SelectedIndexChanged
        If cboclass.Text <> "" And cboname.Text <> "" And cbosection.Text <> "" Then
            sql.addprams("@name", cboname.Text)
            sql.addprams("@class", cboclass.Text)
            sql.addprams("@section", cbosection.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * from dbo.show_classsection(@name,@class,@section,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        ElseIf cbosection.Text <> "" Then
            sql.addprams("@date", dtp.Value)
            sql.addprams("@section", cbosection.Text)
            sql.addprams("@class", cboclass.Text)
            sql.ExecSql("select * from dbo.show_classsection(default,@class,@section,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        Else
            sql.addprams("@name", cboname.Text)
            sql.addprams("@class", cboclass.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * from dbo.show_classsection(@name,@class,default,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub cbosection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosection.SelectedIndexChanged
        If cboclass.Text <> "" And cboname.Text <> "" And cbosection.Text <> "" Then
            sql.addprams("@name", cboname.Text)
            sql.addprams("@class", cboclass.Text)
            sql.addprams("@section", cbosection.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * from dbo.show_classsection(@name,@class,@section,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        ElseIf cboclass.Text <> "" Then
            sql.addprams("@date", dtp.Value)
            sql.addprams("@section", cbosection.Text)
            sql.addprams("@class", cboclass.Text)
            sql.ExecSql("select * from dbo.show_classsection(default,@class,@section,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        Else
            sql.addprams("@name", cboname.Text)
            sql.addprams("@date", dtp.Value)
            sql.addprams("@section", cbosection.Text)
            sql.ExecSql("select * from dbo.show_classsection(@name,default,@section,@date)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub bnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnprint.Click
        If cboname.Text <> "" Then
            PrintDocument1.Print()
        End If
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
            e.Graphics.DrawString(sql.data.Tables(0).Rows(j - 1)("Student Name"), fonts, Brushes.Brown, 22, height + 10)
            e.Graphics.DrawRectangle(Pens.Black, 270, height, 240, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(j - 1)("date"), fonts, Brushes.Brown, 272, height + 10)
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
    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        If dtp.Value > Now.Date Then
            dtp.Value = Now.Date
        End If
        cboname_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If cboname.Text <> "" Then
            sql.addprams("@name", cboname.Text)
            sql.ExecSql("select *from dbo.show_classname(@name,default,default)")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            bind.DataSource = sql.data.Tables(0)
            DataGridView1.DataSource = bind
        Else
            MessageBox.Show("Please Select A Student !", "Select", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
End Class