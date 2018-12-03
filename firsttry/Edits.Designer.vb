<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edits
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.Section = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfees = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(165, 183)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(185, 83)
        Me.txtaddress.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone Number"
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(165, 322)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(185, 22)
        Me.txtphone.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Class"
        '
        'cboclass
        '
        Me.cboclass.AutoCompleteCustomSource.AddRange(New String() {"Play School", "Tuition", "Day Care", "Pre KG", "LKG"})
        Me.cboclass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboclass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(165, 403)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(121, 24)
        Me.cboclass.TabIndex = 5
        '
        'cbostream
        '
        Me.cbostream.AutoCompleteCustomSource.AddRange(New String() {"Undivided", "A", "B", "C", "D"})
        Me.cbostream.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbostream.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(165, 484)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(121, 24)
        Me.cbostream.TabIndex = 6
        '
        'Section
        '
        Me.Section.AutoSize = True
        Me.Section.Location = New System.Drawing.Point(41, 490)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(55, 17)
        Me.Section.TabIndex = 13
        Me.Section.Text = "Section"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(165, 38)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(185, 22)
        Me.txtname.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fees"
        '
        'txtfees
        '
        Me.txtfees.Location = New System.Drawing.Point(532, 37)
        Me.txtfees.Name = "txtfees"
        Me.txtfees.Size = New System.Drawing.Size(81, 22)
        Me.txtfees.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(532, 103)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(198, 22)
        Me.txtemail.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(430, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(532, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(532, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 56)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(634, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 56)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cbogender
        '
        Me.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female", "trans"})
        Me.cbogender.Location = New System.Drawing.Point(165, 96)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(121, 24)
        Me.cbogender.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(532, 510)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 63)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Save Changes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Edits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 616)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfees)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Section)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Edits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edits"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents Section As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfees As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
