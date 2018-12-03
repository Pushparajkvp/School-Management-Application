<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTeacher
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
        Me.imageT = New System.Windows.Forms.PictureBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.cbodesignation = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bnsave = New System.Windows.Forms.Button()
        Me.bnload = New System.Windows.Forms.Button()
        Me.bnclear = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnclearing = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtqua = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        CType(Me.imageT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageT
        '
        Me.imageT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageT.Location = New System.Drawing.Point(539, 36)
        Me.imageT.Name = "imageT"
        Me.imageT.Size = New System.Drawing.Size(219, 249)
        Me.imageT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageT.TabIndex = 0
        Me.imageT.TabStop = False
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(175, 55)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(331, 22)
        Me.txtfullname.TabIndex = 1
        '
        'cbogender
        '
        Me.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female", "Trans Gender"})
        Me.cbogender.Location = New System.Drawing.Point(175, 113)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(146, 24)
        Me.cbogender.TabIndex = 2
        '
        'cbodesignation
        '
        Me.cbodesignation.AutoCompleteCustomSource.AddRange(New String() {"Day Care Helper", "Day Care Teacher", "Primary School Teacher", "Account Manager", "Tuition Teacher"})
        Me.cbodesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodesignation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbodesignation.FormattingEnabled = True
        Me.cbodesignation.Items.AddRange(New Object() {"Day Care Helper", "Day Care Teacher", "Primary School Teacher", "Account Manager", "Tuition Teacher"})
        Me.cbodesignation.Location = New System.Drawing.Point(175, 226)
        Me.cbodesignation.Name = "cbodesignation"
        Me.cbodesignation.Size = New System.Drawing.Size(331, 24)
        Me.cbodesignation.TabIndex = 4
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(175, 356)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(331, 80)
        Me.txtaddress.TabIndex = 6
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(175, 490)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(331, 22)
        Me.txtphone.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(175, 564)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(331, 22)
        Me.txtemail.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 567)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Email address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contact Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Designation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Full Name"
        '
        'bnsave
        '
        Me.bnsave.Location = New System.Drawing.Point(76, 766)
        Me.bnsave.Name = "bnsave"
        Me.bnsave.Size = New System.Drawing.Size(254, 65)
        Me.bnsave.TabIndex = 12
        Me.bnsave.Text = "Save!"
        Me.bnsave.UseVisualStyleBackColor = True
        '
        'bnload
        '
        Me.bnload.Location = New System.Drawing.Point(539, 315)
        Me.bnload.Name = "bnload"
        Me.bnload.Size = New System.Drawing.Size(133, 60)
        Me.bnload.TabIndex = 11
        Me.bnload.Text = "Load"
        Me.bnload.UseVisualStyleBackColor = True
        '
        'bnclear
        '
        Me.bnclear.Location = New System.Drawing.Point(688, 315)
        Me.bnclear.Name = "bnclear"
        Me.bnclear.Size = New System.Drawing.Size(70, 62)
        Me.bnclear.TabIndex = 19
        Me.bnclear.Text = "Clear"
        Me.bnclear.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(175, 176)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 641)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 559
        Me.Label10.Text = "Monthly Pay"
        '
        'bnclearing
        '
        Me.bnclearing.Location = New System.Drawing.Point(430, 766)
        Me.bnclearing.Name = "bnclearing"
        Me.bnclearing.Size = New System.Drawing.Size(251, 65)
        Me.bnclearing.TabIndex = 13
        Me.bnclearing.Text = "Clear"
        Me.bnclearing.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 562
        Me.Label11.Text = "Qualification"
        '
        'txtqua
        '
        Me.txtqua.Location = New System.Drawing.Point(175, 287)
        Me.txtqua.Name = "txtqua"
        Me.txtqua.Size = New System.Drawing.Size(331, 22)
        Me.txtqua.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(175, 636)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 22)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 563
        Me.Label1.Text = "Date Of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 701)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 565
        Me.Label6.Text = "Date Of Joining"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(175, 701)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 22)
        Me.dtp.TabIndex = 10
        '
        'AddTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 864)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtqua)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bnclearing)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.bnclear)
        Me.Controls.Add(Me.bnload)
        Me.Controls.Add(Me.bnsave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.cbodesignation)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.imageT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AddTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Teacher"
        CType(Me.imageT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imageT As System.Windows.Forms.PictureBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents cbodesignation As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bnsave As System.Windows.Forms.Button
    Friend WithEvents bnload As System.Windows.Forms.Button
    Friend WithEvents bnclear As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bnclearing As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtqua As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
End Class
