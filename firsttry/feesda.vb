Public Class feesda
    Dim bind As New BindingSource
    Private Sub feesda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676753_vector_65_04
        Dim sql As New SqlControl
        sql.addprams("@name", txtsearch.Text)
        sql.ExecSql("Select * from dbo.show_fee(@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind

    End Sub
    Private Sub txtsearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        Dim sql As New SqlControl
        sql.addprams("@name", txtsearch.Text)
        sql.ExecSql("Select * from dbo.show_fee(@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        bind.DataSource = sql.data.Tables(0)
        DataGridView1.DataSource = bind
    End Sub
    Private Sub bnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnprint.Click
        index = 0
        document.Print()
    End Sub

    Private Sub feesda_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FeesStructures.Show()
        FeesStructures.MdiParent = MainInterface
    End Sub
    Dim index As Integer = 0
    Private Sub document_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles document.PrintPage

        Dim height As Integer = 100
        Dim sql As New SqlControl
        sql.ExecSql("select name,due from students where due>0")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        Dim fontss As New Font("Arial", 22)
        e.Graphics.DrawString("The List of Students With Due", fontss, Brushes.ForestGreen, 200, 50)
        Dim fonts As New Font("Arial", 10)
        For r = index To sql.count - 1
            e.Graphics.DrawRectangle(Pens.Black, 100, height, 200, 40)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(r)("due").ToString(), fonts, Brushes.Black, 400, height + 5)
            e.Graphics.DrawString(sql.data.Tables(0).Rows(r)("name"), fonts, Brushes.Black, 100, height + 5)
            e.Graphics.DrawLine(Pens.Black, 350, height + 20, 320, height + 20)
            e.Graphics.DrawRectangle(Pens.Black, 400, height, 150, 40)
            height += 80
            If height > 1000 Then
                height = 100
                index = r + 1
                e.HasMorePages = True
                Exit Sub
            End If

        Next
    End Sub
End Class
