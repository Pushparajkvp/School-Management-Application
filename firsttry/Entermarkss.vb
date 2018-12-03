Public Class Entermarkss
    Dim bind As New BindingSource
    Dim tryer As Boolean = True
    Private Sub Entermarkss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load    
        Dim sql As New SqlControl
        Me.Icon = My.Resources._1459676723_Test_paper_24
        sql.ExecSql("select name as [dash] from students")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cboname.Items.Contains(r("dash")) = False Then
                cboname.Items.Add(r("dash"))
            End If
        Next
        sql.ExecSql("select name as [lol] from sub")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cbosub.Items.Contains(r("lol")) = False Then
                cbosub.Items.Add(r("lol"))
            End If
        Next
        dtp.Value = New Date(Now.Year, Now.Month, Now.Day)
    End Sub
    Private Sub bnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnload.Click
        Dim sql As New SqlControl
        If cboname.Text <> "" And cbosub.Text <> "" Then
            Sql.addprams("@name", cboname.Text)
            Sql.addprams("@sub", cbosub.Text)
            Sql.addprams("@date", dtp.Value)
            sql.ExecSql("select *from dbo.show_marks(@name,@sub,@date)")
            If sql.count <= 0 Then
                sql.addprams("@name", cboname.Text)
                sql.addprams("@sub", cbosub.Text)
                sql.addprams("@date", dtp.Value)
                sql.ExecProc("Exec insert_marks @date,NULL,@sub,@name")
                bnload_Click(sender, e)
                Exit Sub
            End If
            bind.DataSource = Sql.data.Tables(0)
            DataGridView1.DataSource = bind
            If Sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            Exit Sub
        End If
        If cboname.Text <> "" And cbosub.Text = "" Then
            sql.addprams("@name", cboname.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * From dbo.show_marks(@name,default,@date)")
            bind.DataSource = sql.data.Tables(0)
            DataGridView1.DataSource = bind
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            Exit Sub
        End If
        If cboname.Text = "" And cbosub.Text <> "" Then
            sql.addprams("@sub", cbosub.Text)
            sql.addprams("@date", dtp.Value)
            sql.ExecSql("select * from dbo.show_marks(default,@sub,@date)")
            bind.DataSource = sql.data.Tables(0)
            DataGridView1.DataSource = bind
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub
    Private Sub DataGridView1_CellParsing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles DataGridView1.CellParsing
        Me.DataGridView1.CurrentCell.Selected = True
    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim sql As New SqlControl
        If Me.DataGridView1.CurrentCell.ColumnIndex = 2 Then
            If IsNumeric(Me.DataGridView1.CurrentCell.Value) = False Then
                MessageBox.Show("Please Enter A Number", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Val(Me.DataGridView1.CurrentCell.Value < 0 Or Me.DataGridView1.CurrentCell.Value > 100) Then
                MessageBox.Show("Enter a number between 1 to 100", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                bnload_Click(sender, e)
                Exit Sub
            End If
            sql.addprams("@name", Me.DataGridView1.Rows(Me.DataGridView1.CurrentCell.RowIndex).Cells(0).Value)
            sql.addprams("@sub", Me.DataGridView1.Rows(Me.DataGridView1.CurrentCell.RowIndex).Cells(1).Value)
            sql.addprams("@date", dtp.Value)
            sql.addprams("@mark", Me.DataGridView1.CurrentCell.Value)
            sql.ExecProc("exec update_marks @name,@sub,@date,@mark")
            bnload_Click(sender, e)
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        End If
    End Sub
    Dim once As Boolean = False
    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        If dtp.Value > Now.Date Then
            dtp.Value = Now.Date
            Exit Sub
        End If
        Dim names As String
        Dim values As Integer
        values = dtp.Value.Month
        Select Case values
            Case 1 : names = "Jan"
            Case 2 : names = "feb"
            Case 3 : names = "march"
            Case 4 : names = "april"
            Case 5 : names = "may"
            Case 6 : names = "june"
            Case 7 : names = "july"
            Case 8 : names = "Aug"
            Case 9 : names = "sept"
            Case 10 : names = "oct"
            Case 11 : names = "Nov"
            Case 12 : names = "Dec"
            Case Else
                names = "Default"
        End Select

        lblcurentdate.Text = "" & names & "-" & dtp.Value.Year
        If once = True Then
            bnload_Click(sender, e)
        End If
        once = True
    End Sub

    Private Sub bnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclear.Click
        Try
            Dim sql As New SqlControl
            sql.addprams("@name", Me.DataGridView1.Rows(Me.DataGridView1.CurrentCell.RowIndex).Cells(0).Value)
            sql.addprams("@sub", Me.DataGridView1.Rows(Me.DataGridView1.CurrentCell.RowIndex).Cells(1).Value)
            sql.addprams("@date", dtp.Value)
            sql.ExecProc("exec delete_marks @name,@sub,@date")
            MessageBox.Show("The Mark Details Has Been Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            bnload_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Please Select A Mark Info first In The Grid", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try    
    End Sub

    Private Sub bnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnprint.Click
        If cboname.Text = "" Then
            MessageBox.Show("Please Select A Student First !", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        PrintDocument1.Print()
        index = 0
    End Sub
    Private index As Integer = 0
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim height As Integer = 250
        Dim sql As New SqlControl
        sql.addprams("@name", cboname.Text)
        sql.addprams("@date", dtp.Value)
        sql.ExecSql("select * from dbo.show_marks(@name,default,@date)")

        Dim fontss As New Font("Arial", 22)
        Dim fonts As New Font("Arial", 16)
        Dim rectangles As New Rectangle

        Dim fullnamesfont As New Font("Arial", 20)

        e.Graphics.DrawString("Name : ", fullnamesfont, Brushes.Black, 50, 50)
        e.Graphics.DrawString(sql.data.Tables(0).Rows(0)("Student Name"), fullnamesfont, Brushes.DarkOrange, 250, 50)
        e.Graphics.DrawString("Class : ", fullnamesfont, Brushes.Black, 50, 100)
        e.Graphics.DrawString(sql.data.Tables(0).Rows(0)("class"), fullnamesfont, Brushes.DarkOrange, 250, 100)
        e.Graphics.DrawString("Section : ", fullnamesfont, Brushes.Black, 50, 150)
        e.Graphics.DrawString(sql.data.Tables(0).Rows(0)("section"), fullnamesfont, Brushes.DarkOrange, 250, 150)

        rectangles = New Rectangle(20, 200, 250, 50)
        e.Graphics.DrawRectangle(Pens.Black, rectangles)
        e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
        e.Graphics.DrawString("Subjects", fontss, Brushes.Black, 22, 210)

        rectangles = New Rectangle(270, 200, 120, 50)
        e.Graphics.DrawRectangle(Pens.Black, rectangles)
        e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
        e.Graphics.DrawString("Mark", fonts, Brushes.Black, 272, 210)

        rectangles = New Rectangle(390, 200, 120, 50)
        e.Graphics.DrawRectangle(Pens.Black, rectangles)
        e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
        e.Graphics.DrawString("Grade", fonts, Brushes.Black, 392, 210)

        rectangles = New Rectangle(510, 200, 300, 50)
        e.Graphics.DrawRectangle(Pens.Black, rectangles)
        e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles)
        e.Graphics.DrawString("Remarks", fonts, Brushes.Black, 632, 210)

        For r As Integer = index To sql.count - 1
            e.Graphics.DrawRectangle(Pens.Black, 20, height, 250, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(r)("Subject Name"), fonts, Brushes.Brown, 22, height + 10)
            e.Graphics.DrawRectangle(Pens.Black, 270, height, 120, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(r)("Marks"), fonts, Brushes.Brown, 272, height + 10)
            e.Graphics.DrawRectangle(Pens.Black, 390, height, 120, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(r)("Grade"), fonts, Brushes.Brown, 392, height + 10)
            e.Graphics.DrawRectangle(Pens.Black, 510, height, 300, 50)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(r)("Remark"), fonts, Brushes.Brown, 530, height + 10)
            height += 50
            If height > 1000 Then
                height = 100
                index = r + 1
                e.HasMorePages = True
                Exit Sub
            End If
        Next
        e.HasMorePages = False
    End Sub
    Private Sub cbosub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosub.SelectedIndexChanged
        bnload_Click(sender, e)
    End Sub

    Private Sub cboname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboname.SelectedIndexChanged
        cbosub.Text = ""
        bnload_Click(sender, e)
    End Sub

    Private Sub Entermarkss_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim sql As New SqlControl
        sql.ExecSql("delete from marks where marks is null")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
    End Sub
    Private Sub cbosub_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbosub.KeyDown
        If e.KeyCode = Keys.Enter Then
            bnload_Click(sender, e)
        End If
    End Sub

End Class