<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bnloadpicture = New System.Windows.Forms.Button()
        Me.bnclearpictue = New System.Windows.Forms.Button()
        Me.bnclear = New System.Windows.Forms.Button()
        Me.bnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtfees = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtregno = New System.Windows.Forms.TextBox()
        Me.Mtxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Ftxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(661, 86)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(381, 22)
        Me.txtfullname.TabIndex = 2
        '
        'cbogender
        '
        Me.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female", "Trans Gender"})
        Me.cbogender.Location = New System.Drawing.Point(64, 248)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(121, 24)
        Me.cbogender.TabIndex = 5
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(661, 268)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(381, 110)
        Me.txtaddress.TabIndex = 7
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(67, 433)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(409, 22)
        Me.txtphone.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(661, 433)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(381, 22)
        Me.txtemail.TabIndex = 10
        '
        'cboclass
        '
        Me.cboclass.AutoCompleteCustomSource.AddRange(New String() {"Play School", "Tuition", "Day Care", "Pre KG", "LKG"})
        Me.cboclass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboclass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboclass.CausesValidation = False
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Items.AddRange(New Object() {"Play School", "Tuition", "Day Care", "Pre KG", "LKG"})
        Me.cboclass.Location = New System.Drawing.Point(70, 506)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(232, 24)
        Me.cboclass.TabIndex = 11
        '
        'cbostream
        '
        Me.cbostream.AutoCompleteCustomSource.AddRange(New String() {"Undivided", "A", "B", "C", "D"})
        Me.cbostream.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbostream.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Items.AddRange(New Object() {"Undivided", "A", "B", "C", "D"})
        Me.cbostream.Location = New System.Drawing.Point(661, 506)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(226, 24)
        Me.cbostream.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(687, 582)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'bnloadpicture
        '
        Me.bnloadpicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnloadpicture.Location = New System.Drawing.Point(830, 582)
        Me.bnloadpicture.Name = "bnloadpicture"
        Me.bnloadpicture.Size = New System.Drawing.Size(75, 51)
        Me.bnloadpicture.TabIndex = 13
        Me.bnloadpicture.Text = "LOAD"
        Me.bnloadpicture.UseVisualStyleBackColor = True
        '
        'bnclearpictue
        '
        Me.bnclearpictue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnclearpictue.Location = New System.Drawing.Point(830, 639)
        Me.bnclearpictue.Name = "bnclearpictue"
        Me.bnclearpictue.Size = New System.Drawing.Size(75, 53)
        Me.bnclearpictue.TabIndex = 16
        Me.bnclearpictue.Text = "Clear"
        Me.bnclearpictue.UseVisualStyleBackColor = True
        '
        'bnclear
        '
        Me.bnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnclear.Location = New System.Drawing.Point(405, 601)
        Me.bnclear.Name = "bnclear"
        Me.bnclear.Size = New System.Drawing.Size(232, 92)
        Me.bnclear.TabIndex = 15
        Me.bnclear.Text = "Clear"
        Me.bnclear.UseVisualStyleBackColor = True
        '
        'bnsave
        '
        Me.bnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnsave.Location = New System.Drawing.Point(70, 602)
        Me.bnsave.Name = "bnsave"
        Me.bnsave.Size = New System.Drawing.Size(226, 91)
        Me.bnsave.TabIndex = 14
        Me.bnsave.Text = "Save!"
        Me.bnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Registration Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(658, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Full Name Of  The Student With Initial At Last"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Date Of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(658, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Contact Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Contact Phone Number (Parents Recomended)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(661, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 483)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Class"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(661, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Section"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(684, 547)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Student's Photo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(321, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(457, 44)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Welcome To Little Vinu !"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtfees
        '
        Me.txtfees.Location = New System.Drawing.Point(65, 356)
        Me.txtfees.Name = "txtfees"
        Me.txtfees.Size = New System.Drawing.Size(100, 22)
        Me.txtfees.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(292, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Student's Monthly fees with 2 decimal  places"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(185, 361)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Rs."
        '
        'txtregno
        '
        Me.txtregno.Location = New System.Drawing.Point(64, 86)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Size = New System.Drawing.Size(412, 22)
        Me.txtregno.TabIndex = 1
        '
        'Mtxt
        '
        Me.Mtxt.Location = New System.Drawing.Point(64, 180)
        Me.Mtxt.Name = "Mtxt"
        Me.Mtxt.Size = New System.Drawing.Size(412, 22)
        Me.Mtxt.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Mother's Name"
        '
        'Ftxt
        '
        Me.Ftxt.Location = New System.Drawing.Point(655, 180)
        Me.Ftxt.Name = "Ftxt"
        Me.Ftxt.Size = New System.Drawing.Size(390, 22)
        Me.Ftxt.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(652, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 17)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Father's Number"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(327, 248)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(142, 22)
        Me.dtp.TabIndex = 6
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 726)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Ftxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Mtxt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtregno)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtfees)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnsave)
        Me.Controls.Add(Me.bnclear)
        Me.Controls.Add(Me.bnclearpictue)
        Me.Controls.Add(Me.bnloadpicture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.txtfullname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Student"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bnloadpicture As System.Windows.Forms.Button
    Friend WithEvents bnclearpictue As System.Windows.Forms.Button
    Friend WithEvents bnclear As System.Windows.Forms.Button
    Friend WithEvents bnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtfees As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtregno As System.Windows.Forms.TextBox
    Friend WithEvents Mtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Ftxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
End Class
