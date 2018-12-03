<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsAt
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
        Me.grphidden = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbofill = New System.Windows.Forms.ComboBox()
        Me.pan = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.cbosection = New System.Windows.Forms.ComboBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpbox = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblnoholidays = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblsection = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblnames = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pan.SuspendLayout()
        Me.grpbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grphidden
        '
        Me.grphidden.Location = New System.Drawing.Point(739, 145)
        Me.grphidden.Name = "grphidden"
        Me.grphidden.Size = New System.Drawing.Size(436, 592)
        Me.grphidden.TabIndex = 16
        Me.grphidden.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(745, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(430, 72)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "More Details and Printing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(36, 111)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 22)
        Me.dtp.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Auto Fill"
        '
        'cbofill
        '
        Me.cbofill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofill.FormattingEnabled = True
        Me.cbofill.Items.AddRange(New Object() {"Present", "Absent"})
        Me.cbofill.Location = New System.Drawing.Point(439, 113)
        Me.cbofill.Name = "cbofill"
        Me.cbofill.Size = New System.Drawing.Size(200, 24)
        Me.cbofill.TabIndex = 12
        '
        'pan
        '
        Me.pan.AutoScroll = True
        Me.pan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pan.Controls.Add(Me.Label8)
        Me.pan.Controls.Add(Me.lblname)
        Me.pan.Location = New System.Drawing.Point(8, 143)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(708, 594)
        Me.pan.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(389, -1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 57)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Attendance"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblname
        '
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(-1, 1)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(255, 57)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Names"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbosection
        '
        Me.cbosection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosection.FormattingEnabled = True
        Me.cbosection.Location = New System.Drawing.Point(442, 30)
        Me.cbosection.Name = "cbosection"
        Me.cbosection.Size = New System.Drawing.Size(200, 24)
        Me.cbosection.TabIndex = 18
        '
        'cboclass
        '
        Me.cboclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(36, 30)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(200, 24)
        Me.cboclass.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Class"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(442, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Section"
        '
        'grpbox
        '
        Me.grpbox.Controls.Add(Me.ListBox1)
        Me.grpbox.Controls.Add(Me.Label17)
        Me.grpbox.Controls.Add(Me.lblnoholidays)
        Me.grpbox.Controls.Add(Me.Label15)
        Me.grpbox.Controls.Add(Me.lblsection)
        Me.grpbox.Controls.Add(Me.Label13)
        Me.grpbox.Controls.Add(Me.lblclass)
        Me.grpbox.Controls.Add(Me.Label7)
        Me.grpbox.Controls.Add(Me.lblgender)
        Me.grpbox.Controls.Add(Me.lblnames)
        Me.grpbox.Controls.Add(Me.Label3)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.PictureBox1)
        Me.grpbox.Location = New System.Drawing.Point(739, 145)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(436, 592)
        Me.grpbox.TabIndex = 23
        Me.grpbox.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(277, 519)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 52)
        Me.ListBox1.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(115, 519)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 17)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Dates of holidays"
        '
        'lblnoholidays
        '
        Me.lblnoholidays.AutoSize = True
        Me.lblnoholidays.Location = New System.Drawing.Point(274, 464)
        Me.lblnoholidays.Name = "lblnoholidays"
        Me.lblnoholidays.Size = New System.Drawing.Size(59, 17)
        Me.lblnoholidays.TabIndex = 10
        Me.lblnoholidays.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(115, 464)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 17)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "No of holidays"
        '
        'lblsection
        '
        Me.lblsection.AutoSize = True
        Me.lblsection.Location = New System.Drawing.Point(274, 418)
        Me.lblsection.Name = "lblsection"
        Me.lblsection.Size = New System.Drawing.Size(59, 17)
        Me.lblsection.TabIndex = 8
        Me.lblsection.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(115, 418)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Section"
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Location = New System.Drawing.Point(274, 368)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(59, 17)
        Me.lblclass.TabIndex = 6
        Me.lblclass.Text = "Label12"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Class"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(274, 318)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(51, 17)
        Me.lblgender.TabIndex = 4
        Me.lblgender.Text = "Label6"
        '
        'lblnames
        '
        Me.lblnames.AutoSize = True
        Me.lblnames.Location = New System.Drawing.Point(274, 268)
        Me.lblnames.Name = "lblnames"
        Me.lblnames.Size = New System.Drawing.Size(51, 17)
        Me.lblnames.TabIndex = 3
        Me.lblnames.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(133, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StudentsAt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 745)
        Me.Controls.Add(Me.grpbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grphidden)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.cbosection)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbofill)
        Me.Controls.Add(Me.pan)
        Me.Name = "StudentsAt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Attendance"
        Me.pan.ResumeLayout(False)
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grphidden As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbofill As System.Windows.Forms.ComboBox
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents cbosection As System.Windows.Forms.ComboBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblnoholidays As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblsection As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblnames As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
