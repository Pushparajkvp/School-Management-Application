Public Class AddStudent
    Dim sql As New SqlControl
    Private Sub bnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclear.Click
        txtaddress.Clear()
        txtemail.Clear()
        txtfullname.Clear()
        txtphone.Clear()
        cboclass.Text = ""
        cbogender.Text = ""
        cbostream.Text = ""
        PictureBox1.Image = Nothing
        txtregno.Focus()
    End Sub
    Private Sub bnclearpictue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclearpictue.Click
        PictureBox1.Image = Nothing
    End Sub
    Public Sub cls()
     sql.ExecSql("select class as [class] ,section as [section] from class")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cboclass.Items.Contains(r("class")) = False Then
                cboclass.Items.Add(r("class"))
            End If
            If cbostream.Items.Contains(r("section")) = False Then
                cbostream.Items.Add(r("section"))
            End If
        Next
    End Sub
    Private Sub bnloadpicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnloadpicture.Click
        With OpenFileDialog1
            .Title = "Select a Jpeg image"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Load(.FileName)
            End If
        End With
    End Sub
    Private Sub bnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnsave.Click
        If txtaddress.Text = "" Or txtemail.Text = "" Or txtfullname.Text = "" Or txtphone.Text = "" Or txtregno.Text = "" Or cboclass.Text = "" Or cbogender.Text = "" Or cbostream.Text = "" Then
            MessageBox.Show("No fields must be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        Try
            If txtphone.Text.Length < 8 Then
                MessageBox.Show("The phone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        sql.addprams("@name", txtfullname.Text)
        sql.ExecSql("select name from students where name = @name")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If

        If sql.count <> 0 Then
            MessageBox.Show("There is already a student with exact name please make a little adjustment to help the software :) ", "Same Full names", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim res As DialogResult = MessageBox.Show("Are you sure you all the student details are entered correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = DialogResult.No Then
            Exit Sub
        End If
        sql.addprams("@name", txtfullname.Text)
        sql.addprams("@Fname", Ftxt.Text)
        sql.addprams("@Mname", Mtxt.Text)
        sql.addprams("@Rnum", txtregno.Text)
        sql.addprams("@date", dtp.Value)
        sql.addprams("@add", txtaddress.Text)
        sql.addprams("@phone", Val(txtphone.Text))
        sql.addprams("@pic", PictureBox1.ImageLocation)
        sql.addprams("@email", txtemail.Text)
        sql.addprams("@gender", cbogender.SelectedIndex + 1)
        sql.addprams("@class", cboclass.Text)
        sql.addprams("@section", cbostream.Text)
        sql.addprams("@amount", Val(txtfees.Text))
        sql.ExecProc("exec Insert_class @gender,@name,@Fname,@Mname,@Rnum,@add,@phone,@pic,@email ,@date ,@class,@section,@amount")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        bnclear_Click(sender, e)
        MessageBox.Show("The Student is saved in vinu ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        dates = Now.Date
        Me.Close()
    End Sub
    Dim dates As Date
    Dim threads As System.Threading.Thread
    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676551_add_user
    End Sub
    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged
        If IsNumeric(txtphone.Text) = False Then
            txtphone.Clear()
        End If
    End Sub
    Private Sub txtfees_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfees.TextChanged
        If IsNumeric(txtfees.Text) = False Then
            txtfees.Clear()
        End If
    End Sub

    Private Sub txtregno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtregno.TextChanged
        If IsNumeric(txtregno.Text) = False Then
            txtregno.Clear()
        End If
    End Sub
End Class