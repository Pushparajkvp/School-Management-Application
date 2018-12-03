Public Class Edits
    Dim sql As New SqlControl
    Dim ids As Integer
    Private Sub Edits_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        sql.ExecSql("select distinct(class) as [dash] from class")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cboclass.Items.Contains(r("dash")) = False Then
                cboclass.Items.Add(r("dash"))
            End If
        Next
        sql.ExecSql("select distinct(section) as [pupa] from class")
        For Each r As DataRow In sql.data.Tables(0).Rows
            If cbostream.Items.Contains(r("pupa")) = False Then
                cbostream.Items.Add(r("pupa"))
            End If
        Next
        ids = ManageStudents.edity()

        sql.addprams("@id", ids)
        sql.ExecSql("select * from dbo.show_studing(@id)")

        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        If sql.count > 0 Then
            txtaddress.Text = sql.data.Tables(0).Rows(0)("address")
            txtemail.Text = sql.data.Tables(0).Rows(0)("Email")
            txtfees.Text = sql.data.Tables(0).Rows(0)("fee")
            txtname.Text = sql.data.Tables(0).Rows(0)("Student Name")
            txtphone.Text = sql.data.Tables(0).Rows(0)("Phone Number")
            cboclass.Text = sql.data.Tables(0).Rows(0)("Class")
            cbogender.Text = sql.data.Tables(0).Rows(0)("Gender")
            cbostream.Text = sql.data.Tables(0).Rows(0)("Section")
            PictureBox1.ImageLocation = sql.data.Tables(0).Rows(0)("pic")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfees.TextChanged
        If IsNumeric(txtfees.Text) = False Then
            txtfees.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "Select a image"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        sql.addprams("@id", ids)
        sql.addprams("@name", txtname.Text)
        sql.addprams("@gender", cbogender.SelectedIndex + 1)
        sql.addprams("@add", txtaddress.Text)
        sql.addprams("@phone", Val(txtphone.Text))
        sql.addprams("@class", cboclass.Text)
        sql.addprams("@section", cbostream.Text)
        sql.addprams("@fee", Val(txtfees.Text))
        sql.addprams("@email", txtemail.Text)
        sql.addprams("@pic", PictureBox1.ImageLocation)
        sql.ExecProc("exec Insert_studing @id,@name,@gender,@add,@phone,@class,@section,@fee,@email,@pic")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        MessageBox.Show("The Changes Has Been Made", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    Private Sub Edits_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ManageStudents.ManageStudents_Load(sender, e)
        ManageStudents.txtsearch.Text = ""
    End Sub
End Class