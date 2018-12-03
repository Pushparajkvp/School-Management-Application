Public Class FeesStructures

    Private Sub FeesStructures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboyear.Text = Now.Year
        Me.Icon = My.Resources._1459676753_vector_65_04
        Grpdetails.Visible = False
        Dim sql As New SqlControl
        sql.ExecSql("Select name as [Student] from students")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cboname.Items.Contains(r("Student")) = False Then
                cboname.Items.Add(r("Student"))
            End If
        Next
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        GroupBox1.Visible = False
    End Sub

    Private Sub cboname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.TextChanged
        If cboname.Text = "" Then
            Grpdetails.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub txtpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNumeric(txtpay.Text) = False Then
            txtpay.Clear()
        End If
    End Sub

    Private Sub loadpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadpay.Click
        If txtpay.Text = "" Or txtrange.Text = "" Then
            MessageBox.Show("Please Enter An Amount and Fill The Range", "Fill Up", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim mess As DialogResult
        mess = MessageBox.Show("Are You sure the amount is collected?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If mess = DialogResult.No Then
            Exit Sub
        End If
        Dim lst As List(Of Integer) = getnum()
        Dim sql As New SqlControl
        For Each r As Integer In lst
            sql.addprams("@name", cboname.Text)
            sql.addprams("@date", Now.Date)
            sql.addprams("@year", Val(cboyear.Text))
            sql.addprams("@month", r)
            sql.addprams("@amount", Val(txtpay.Text) / lst.Count)
            sql.ExecProc("exec insert_fee @name,@date,@month,@year,@amount")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        Next
        lst.Clear()
        mess = MessageBox.Show("The Payment is Done! Do you want a Bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If mess = DialogResult.Yes Then
            PrintDocument1.Print()
            mess = MessageBox.Show("Do You Want To Print Another Copy?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If mess = DialogResult.Yes Then
                PrintDocument1.Print()
            End If
        End If
        cboname_SelectedIndexChanged(sender, e)
        makepay_Click(sender, e)
        txtpay.Text = ""
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        Dim sql As New SqlControl
        sql.addprams("@name", cboname.Text)
        sql.ExecSql("select * from dbo.show_students(@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If

        If sql.count <> 0 Then
            Grpdetails.Visible = True
            picbox.ImageLocation = sql.data.Tables(0).Rows(0)("pic")
            lblage.Text = sql.data.Tables(0).Rows(0)("age")
            lblclass.Text = sql.data.Tables(0).Rows(0)("Class")
            lblfeesmonth.Text = sql.data.Tables(0).Rows(0)("amount")
            lblname.Text = sql.data.Tables(0).Rows(0)("Student Name")
            lblsection.Text = sql.data.Tables(0).Rows(0)("Section")
            lbldue.Text = sql.data.Tables(0).Rows(0)("due")
        Exit Sub
        End If
        makepay_Click(sender, e)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        feesda.Show()
        feesda.MdiParent = MainInterface
        Me.Hide()
    End Sub

    Private Sub makepay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles makepay.Click
        If cboname.Text = "" Then
            MessageBox.Show("Please Select A Name First", "No name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim sql As New SqlControl
        sql.addprams("@name", cboname.Text)
        sql.addprams("@date", Val(cboyear.Text))
        sql.ExecSql("select *from dbo.show_fees(@name,@date)")
        Dim lsts As New List(Of Integer)
        For Each r As DataRow In sql.data.Tables(0).Rows
            lsts.Add(r("months"))
        Next
        Checks(lsts)
        btignore.Visible = True
        lblyear.Visible = True
        GroupBox1.Visible = True
        lblpay.Visible = True
        loadcan.Visible = True
        loadpay.Visible = True
        txtpay.Visible = True
        makepay.Visible = False
        txtrange.Visible = True
        Label3.Visible = True
    End Sub
    Private Sub Checks(ByVal lsts As List(Of Integer))
        If lsts.Contains(1) Then
            ckjan.Checked = False
            ckjan.Enabled = False
        Else
            ckjan.Enabled = True
            ckjan.Checked = False
        End If
        If lsts.Contains(2) Then
            ckfeb.Checked = False
            ckfeb.Enabled = False
        Else
            ckfeb.Enabled = True
            ckfeb.Checked = False
        End If
        If lsts.Contains(3) Then
            ckmar.Checked = False
            ckmar.Enabled = False
        Else
            ckmar.Enabled = True
            ckmar.Checked = False
        End If
        If lsts.Contains(4) Then
            ckapril.Checked = False
            ckapril.Enabled = False
        Else
            ckapril.Enabled = True
            ckapril.Checked = False
        End If
        If lsts.Contains(5) Then
            ckmay.Checked = False
            ckmay.Enabled = False
        Else
            ckmay.Enabled = True
            ckmay.Checked = False
        End If
        If lsts.Contains(6) Then
            ckjune.Checked = False
            ckjune.Enabled = False
        Else
            ckjune.Enabled = True
            ckjune.Checked = False
        End If
        If lsts.Contains(7) Then
            ckjuly.Checked = False
            ckjuly.Enabled = False
        Else
            ckjuly.Enabled = True
            ckjuly.Checked = False
        End If
        If lsts.Contains(8) Then
            ckaug.Checked = False
            ckaug.Enabled = False
        Else
            ckaug.Enabled = True
            ckaug.Checked = False
        End If
        If lsts.Contains(9) Then
            cksept.Checked = False
            cksept.Enabled = False
        Else
            cksept.Enabled = True
            cksept.Checked = False
        End If
        If lsts.Contains(10) Then
            ckoct.Checked = False
            ckoct.Enabled = False
        Else
            ckoct.Enabled = True
            ckoct.Checked = False
        End If
        If lsts.Contains(11) Then
            cknov.Checked = False
            cknov.Enabled = False
        Else
            cknov.Enabled = True
            cknov.Checked = False
        End If
        If lsts.Contains(12) Then
            ckdec.Checked = False
            ckdec.Enabled = False
        Else
            ckdec.Enabled = True
            ckdec.Checked = False
        End If
    End Sub
    Private Sub loadcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadcan.Click
        btignore.Visible = False
        lblyear.Visible = False
        GroupBox1.Visible = False
        lblpay.Visible = False
        loadcan.Visible = False
        loadpay.Visible = False
        txtpay.Visible = False
        txtrange.Visible = False
        Label3.Visible = False
        makepay.Visible = True
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim sql As New SqlControl
        sql.addprams("@name", cboname.Text)
        sql.ExecSql("select *From show_students(@name)")
        Dim sql1 As New SqlControl
        sql1.addprams("@name", cboname.Text)
        sql1.ExecSql("select count(*) as counts From fees")
        Dim fonts As Font
        fonts = New Font("Arial", 16)
        Dim newim As Image
        newim = My.Resources.Bill_Heading
        Dim sizes As New System.Drawing.Size
        sizes = New System.Drawing.Size(725, 200)
        newim = New Bitmap(newim, sizes)
        e.Graphics.DrawImage(newim, 20, 20)
        e.Graphics.DrawString("Fees Receipt", New Font("Arial", 26), Brushes.Black, 300, 250)
        e.Graphics.DrawString("No: 00" + sql1.data.Tables(0).Rows(0)("counts").ToString() + "\" + MonthName(Now.Date.Month, True) + "\" + Now.Date.Year.ToString(), New Font("Arial", 16), Brushes.Black, 310, 300)
        e.Graphics.DrawString("Name : " + cboname.Text, fonts, Brushes.Black, 50, 350)
        e.Graphics.DrawString("Registration Number : " + (sql.data.Tables(0).Rows(0)("Register Number")).ToString(), fonts, Brushes.Black, 450, 350)
        e.Graphics.DrawString("Class : " + lblclass.Text, fonts, Brushes.Black, 50, 400)
        e.Graphics.DrawString("Date : 20/may/2016", fonts, Brushes.Black, 450, 400)
        e.Graphics.DrawRectangle(Pens.Black, 50, 500, 750, 250)
        e.Graphics.DrawRectangle(Pens.Black, 50, 500, 750, 80)
        e.Graphics.DrawString("Description", New Font("Arial", 20), Brushes.Black, 250, 520)
        e.Graphics.DrawString("Coaching Fee", New Font("Arial", 16), Brushes.Black, 60, 630)
        e.Graphics.DrawString(txtrange.Text, New Font("Arial", 16), Brushes.Black, 60, 680)
        e.Graphics.DrawString(txtpay.Text + "\- Rs", New Font("Arial", 16), Brushes.Black, 650, 650)
        e.Graphics.DrawRectangle(Pens.Black, 600, 500, 200, 250)
        e.Graphics.DrawString("Amount in words  : .............................................................................................", New Font("Arial", 16), Brushes.Black, 50, 800)
        e.Graphics.DrawString("Amount", New Font("Arial", 20), Brushes.Black, 640, 520)
        e.Graphics.DrawString("Signature", New Font("Arial", 16), Brushes.Black, 640, 970)
        e.Graphics.DrawString("Seal", New Font("Arial", 16), Brushes.Black, 200, 970)
        e.Graphics.DrawString("Vinu Academy,177 Mountbatten Road , 5th Street,Kumaran kudil ,Thoraipakkam,chennai 600097", New Font("Arial", 12), Brushes.Black, 100, 1030)
        e.Graphics.DrawString("9381887424", New Font("Arial", 12), Brushes.Black, 400, 1050)

    End Sub

    Private Sub btignore_Click(sender As System.Object, e As System.EventArgs) Handles btignore.Click
        If ckapril.Checked = False And ckaug.Checked = False And ckdec.Checked = False And ckfeb.Checked = False And ckjan.Checked = False And ckjuly.Checked = False And ckjune.Checked = False And ckmar.Checked = False And ckmay.Checked = False And cknov.Checked = False And ckoct.Checked = False And cksept.Checked = False Then
            MessageBox.Show("Please Select A month First To Ignore!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim mess As DialogResult
        mess = MessageBox.Show("Are you sure you want to ignore this month?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If mess = DialogResult.No Then
            Exit Sub
        End If
        Dim lst As New List(Of Integer)
        Dim sql As New SqlControl
        lst = getnum()
        For Each r As Integer In lst
            sql.addprams("@name", cboname.Text)
            sql.addprams("@date", Now.Date)
            sql.addprams("@year", Val(cboyear.Text))
            sql.addprams("@month", r)
            sql.ExecProc("exec insert_fee @name,@date,@month,@year,0")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
        Next
        lst.Clear()
        makepay_Click(sender, e)
        MessageBox.Show("The Fees For The selected Months Have Been Ignored", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Private Function getnum() As List(Of Integer)
        Dim lst As New List(Of Integer)
        If ckjan.Checked = True Then lst.Add(1)
        If ckfeb.Checked = True Then lst.Add(2)
        If ckmar.Checked = True Then lst.Add(3)
        If ckapril.Checked = True Then lst.Add(4)
        If ckmay.Checked = True Then lst.Add(5)
        If ckjune.Checked = True Then lst.Add(6)
        If ckjuly.Checked = True Then lst.Add(7)
        If ckaug.Checked = True Then lst.Add(8)
        If cksept.Checked = True Then lst.Add(9)
        If ckoct.Checked = True Then lst.Add(10)
        If cknov.Checked = True Then lst.Add(11)
        If ckdec.Checked = True Then lst.Add(12)
        Return lst
    End Function

    Private Sub cboyear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboyear.SelectedIndexChanged
        If cboname.Text <> "" Then
            makepay_Click(sender, e)
        End If
    End Sub

    Private Sub butedit_Click(sender As System.Object, e As System.EventArgs) Handles butedit.Click
        txtdue.Visible = True
        lbldue.Visible = False
        txtdue.Focus()
    End Sub

    Private Sub txtdue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtdue.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim sql As New SqlControl
            sql.addprams("@name", cboname.Text)
            sql.addprams("@due", Val(txtdue.Text))
            sql.ExecSql("update students set due = @due where name = @name")
            If sql.exep <> "" Then
                MsgBox(sql.exep)
                Exit Sub
            End If
            txtdue.Visible = False
            lbldue.Visible = True
            cboname_SelectedIndexChanged(sender, e)
        End If
    End Sub

End Class
