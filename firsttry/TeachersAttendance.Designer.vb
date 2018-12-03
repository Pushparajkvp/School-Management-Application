<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeachersAttendance
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
        Me.pan = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.grpbox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstbo = New System.Windows.Forms.ListBox()
        Me.lblleaves = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbldesig = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Picbox1 = New System.Windows.Forms.PictureBox()
        Me.grphidden = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbofill = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pan.SuspendLayout()
        Me.grpbox.SuspendLayout()
        CType(Me.Picbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grphidden.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan
        '
        Me.pan.AutoScroll = True
        Me.pan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pan.Controls.Add(Me.Label8)
        Me.pan.Controls.Add(Me.lblname)
        Me.pan.Location = New System.Drawing.Point(12, 107)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(708, 594)
        Me.pan.TabIndex = 0
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
        'grpbox
        '
        Me.grpbox.Controls.Add(Me.Label6)
        Me.grpbox.Controls.Add(Me.lstbo)
        Me.grpbox.Controls.Add(Me.lblleaves)
        Me.grpbox.Controls.Add(Me.Label7)
        Me.grpbox.Controls.Add(Me.lbldesig)
        Me.grpbox.Controls.Add(Me.lblgender)
        Me.grpbox.Controls.Add(Me.Label4)
        Me.grpbox.Controls.Add(Me.Label3)
        Me.grpbox.Controls.Add(Me.lbltname)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.Picbox1)
        Me.grpbox.Location = New System.Drawing.Point(749, 107)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(436, 594)
        Me.grpbox.TabIndex = 1
        Me.grpbox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 522)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dates On Leave"
        '
        'lstbo
        '
        Me.lstbo.FormattingEnabled = True
        Me.lstbo.ItemHeight = 16
        Me.lstbo.Location = New System.Drawing.Point(224, 522)
        Me.lstbo.Name = "lstbo"
        Me.lstbo.Size = New System.Drawing.Size(160, 52)
        Me.lstbo.TabIndex = 9
        '
        'lblleaves
        '
        Me.lblleaves.AutoSize = True
        Me.lblleaves.Location = New System.Drawing.Point(196, 485)
        Me.lblleaves.Name = "lblleaves"
        Me.lblleaves.Size = New System.Drawing.Size(0, 17)
        Me.lblleaves.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "No. Of Leave"
        '
        'lbldesig
        '
        Me.lbldesig.AutoSize = True
        Me.lbldesig.Location = New System.Drawing.Point(196, 437)
        Me.lbldesig.Name = "lbldesig"
        Me.lbldesig.Size = New System.Drawing.Size(0, 17)
        Me.lbldesig.TabIndex = 6
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(196, 389)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(0, 17)
        Me.lblgender.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Designation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gender"
        '
        'lbltname
        '
        Me.lbltname.AutoSize = True
        Me.lbltname.Location = New System.Drawing.Point(196, 341)
        Me.lbltname.Name = "lbltname"
        Me.lbltname.Size = New System.Drawing.Size(0, 17)
        Me.lbltname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Picbox1
        '
        Me.Picbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picbox1.Location = New System.Drawing.Point(115, 38)
        Me.Picbox1.Name = "Picbox1"
        Me.Picbox1.Size = New System.Drawing.Size(228, 255)
        Me.Picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picbox1.TabIndex = 0
        Me.Picbox1.TabStop = False
        '
        'grphidden
        '
        Me.grphidden.Controls.Add(Me.Label5)
        Me.grphidden.Location = New System.Drawing.Point(749, 109)
        Me.grphidden.Name = "grphidden"
        Me.grphidden.Size = New System.Drawing.Size(436, 592)
        Me.grphidden.TabIndex = 9
        Me.grphidden.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(432, 76)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "For staff details click on their names"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbofill
        '
        Me.cbofill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofill.FormattingEnabled = True
        Me.cbofill.Items.AddRange(New Object() {"Present", "Absent"})
        Me.cbofill.Location = New System.Drawing.Point(443, 77)
        Me.cbofill.Name = "cbofill"
        Me.cbofill.Size = New System.Drawing.Size(172, 24)
        Me.cbofill.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Auto Fill"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(43, 75)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 22)
        Me.dtp.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(749, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(430, 72)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "More Details and Printing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TeachersAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 713)
        Me.Controls.Add(Me.grphidden)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbofill)
        Me.Controls.Add(Me.grpbox)
        Me.Controls.Add(Me.pan)
        Me.Name = "TeachersAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teachers Attendance"
        Me.pan.ResumeLayout(False)
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        CType(Me.Picbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grphidden.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents Picbox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents cbofill As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblleaves As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbldesig As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents grphidden As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstbo As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
