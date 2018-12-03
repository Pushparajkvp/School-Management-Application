Public Class AddTeacher
    Dim sql As New SqlControl
    Private Sub bnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclear.Click
        imageT.Image = Nothing
    End Sub

    Private Sub bnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnload.Click
        With OpenFileDialog1
            .Title = "Load Teacher's Photo "
            .Multiselect = False
            .FileName = ""
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else
                imageT.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub bnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnsave.Click
        If txtemail.Text = "" Or txtfullname.Text = "" Or txtphone.Text = "" Or txtaddress.Text = "" Or cbodesignation.Text = "" Or cbogender.Text = "" Or txtqua.Text = "" Then
            MsgBox("No fields must be left blank :)", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Val(txtphone.Text) < 10000000 Then
            MsgBox("Invalid Phone number!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        sql.addprams("@name", txtfullname.Text)
        sql.ExecSql("select name from teacher where name = @name")
        If sql.count <> 0 Then
            MessageBox.Show("There is already a student with exact name please make a little adjustment to help the software :) ", "Same Full names", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        sql.addprams("@name", txtfullname.Text)
        sql.addprams("@gender", cbogender.SelectedIndex + 1)
        sql.addprams("@dob", DateTimePicker1.Value)
        sql.addprams("@desig", cbodesignation.Text)
        sql.addprams("@qua", txtqua.Text)
        sql.addprams("@add", txtaddress.Text)
        sql.addprams("@phone", Val(txtphone.Text))
        sql.addprams("@email", txtemail.Text)
        sql.addprams("@fee", Val(ComboBox1.Text))
        sql.addprams("@join", dtp.Value)
        sql.addprams("@pic", imageT.ImageLocation)
        sql.ExecProc("exec insert_teacher @name,@gender,@dob,@desig,@qua,@add,@phone,@email,@fee,@join,@pic")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        MsgBox("The details about the teacher is stored", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        bnclear_Click(sender, e)
        Me.Close()

    End Sub
    Private Sub AddTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676422_Teacher_male_24
        sql.ExecSql("Select name from designation")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cbodesignation.Items.Contains(r("name")) = False Then
                cbodesignation.Items.Add(r("name"))
            End If
        Next
    End Sub

    Private Sub bnclearing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclearing.Click
        txtaddress.Clear()
        txtemail.Clear()
        txtfullname.Clear()
        txtphone.Clear()
        cbodesignation.Text = ""
        cbodesignation.Text = ""
        cbogender.Text = ""
        txtqua.Clear()
        ComboBox1.Text = ""
        imageT.Image = Nothing
    End Sub

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged
        If IsNumeric(txtphone.Text) = False Then
            txtphone.Clear()
        End If
    End Sub
End Class