<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entermarkss
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboname = New System.Windows.Forms.ComboBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.bnload = New System.Windows.Forms.Button()
        Me.cbosub = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcurentdate = New System.Windows.Forms.Label()
        Me.bnclear = New System.Windows.Forms.Button()
        Me.bnprint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1229, 445)
        Me.DataGridView1.TabIndex = 0
        '
        'cboname
        '
        Me.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboname.FormattingEnabled = True
        Me.cboname.Location = New System.Drawing.Point(28, 59)
        Me.cboname.Name = "cboname"
        Me.cboname.Size = New System.Drawing.Size(247, 24)
        Me.cboname.TabIndex = 1
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(640, 46)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 22)
        Me.dtp.TabIndex = 2
        '
        'bnload
        '
        Me.bnload.Location = New System.Drawing.Point(359, 36)
        Me.bnload.Name = "bnload"
        Me.bnload.Size = New System.Drawing.Size(159, 57)
        Me.bnload.TabIndex = 3
        Me.bnload.Text = "LOAD"
        Me.bnload.UseVisualStyleBackColor = True
        '
        'cbosub
        '
        Me.cbosub.AutoCompleteCustomSource.AddRange(New String() {"Maths", "Physics", "English", "Chemisty", "History", "Econmics", "Computer Science", "Bussinesss Maths", "Civics", "Tamil", "Hindi", "French", "Biology", "Science", "Zoology", "Botany", "Ariviyal Tamil", "English", "Geography", " Environmental Science", " Agricultural Science", "Commercial Studies", "Technical Drawing", "Drawing", "Abacus", "SST"})
        Me.cbosub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbosub.FormattingEnabled = True
        Me.cbosub.Location = New System.Drawing.Point(31, 138)
        Me.cbosub.Name = "cbosub"
        Me.cbosub.Size = New System.Drawing.Size(244, 24)
        Me.cbosub.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Name"
        '
        'lblcurentdate
        '
        Me.lblcurentdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurentdate.Location = New System.Drawing.Point(635, 87)
        Me.lblcurentdate.Name = "lblcurentdate"
        Me.lblcurentdate.Size = New System.Drawing.Size(208, 67)
        Me.lblcurentdate.TabIndex = 7
        Me.lblcurentdate.Text = "Label3"
        Me.lblcurentdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnclear
        '
        Me.bnclear.Location = New System.Drawing.Point(359, 121)
        Me.bnclear.Name = "bnclear"
        Me.bnclear.Size = New System.Drawing.Size(159, 56)
        Me.bnclear.TabIndex = 8
        Me.bnclear.Text = "Delete Record"
        Me.bnclear.UseVisualStyleBackColor = True
        '
        'bnprint
        '
        Me.bnprint.Location = New System.Drawing.Point(932, 46)
        Me.bnprint.Name = "bnprint"
        Me.bnprint.Size = New System.Drawing.Size(230, 67)
        Me.bnprint.TabIndex = 9
        Me.bnprint.Text = "PRINT"
        Me.bnprint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Entermarkss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 673)
        Me.Controls.Add(Me.bnprint)
        Me.Controls.Add(Me.bnclear)
        Me.Controls.Add(Me.lblcurentdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbosub)
        Me.Controls.Add(Me.bnload)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.cboname)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Entermarkss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Marks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cboname As System.Windows.Forms.ComboBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents bnload As System.Windows.Forms.Button
    Friend WithEvents cbosub As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcurentdate As System.Windows.Forms.Label
    Friend WithEvents bnclear As System.Windows.Forms.Button
    Friend WithEvents bnprint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
