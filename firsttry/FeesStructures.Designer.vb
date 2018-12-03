<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeesStructures
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grpdetails = New System.Windows.Forms.GroupBox()
        Me.butedit = New System.Windows.Forms.Button()
        Me.txtdue = New System.Windows.Forms.TextBox()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.lblsection = New System.Windows.Forms.Label()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblfeesmonth = New System.Windows.Forms.Label()
        Me.lblfee = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboname = New System.Windows.Forms.ComboBox()
        Me.loadpay = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblpay = New System.Windows.Forms.Label()
        Me.txtpay = New System.Windows.Forms.TextBox()
        Me.makepay = New System.Windows.Forms.Button()
        Me.loadcan = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ckjan = New System.Windows.Forms.CheckBox()
        Me.ckdec = New System.Windows.Forms.CheckBox()
        Me.cknov = New System.Windows.Forms.CheckBox()
        Me.ckoct = New System.Windows.Forms.CheckBox()
        Me.ckaug = New System.Windows.Forms.CheckBox()
        Me.ckjune = New System.Windows.Forms.CheckBox()
        Me.ckapril = New System.Windows.Forms.CheckBox()
        Me.ckmar = New System.Windows.Forms.CheckBox()
        Me.cksept = New System.Windows.Forms.CheckBox()
        Me.ckmay = New System.Windows.Forms.CheckBox()
        Me.ckfeb = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.ckjuly = New System.Windows.Forms.CheckBox()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.btignore = New System.Windows.Forms.Button()
        Me.txtrange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grpdetails.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sudent's Name"
        '
        'Grpdetails
        '
        Me.Grpdetails.BackColor = System.Drawing.SystemColors.Control
        Me.Grpdetails.Controls.Add(Me.butedit)
        Me.Grpdetails.Controls.Add(Me.txtdue)
        Me.Grpdetails.Controls.Add(Me.picbox)
        Me.Grpdetails.Controls.Add(Me.lblsection)
        Me.Grpdetails.Controls.Add(Me.lblclass)
        Me.Grpdetails.Controls.Add(Me.Label7)
        Me.Grpdetails.Controls.Add(Me.Label6)
        Me.Grpdetails.Controls.Add(Me.lblname)
        Me.Grpdetails.Controls.Add(Me.Label5)
        Me.Grpdetails.Controls.Add(Me.lbldue)
        Me.Grpdetails.Controls.Add(Me.Label4)
        Me.Grpdetails.Controls.Add(Me.lblfeesmonth)
        Me.Grpdetails.Controls.Add(Me.lblfee)
        Me.Grpdetails.Controls.Add(Me.lblage)
        Me.Grpdetails.Controls.Add(Me.Label2)
        Me.Grpdetails.Location = New System.Drawing.Point(535, 12)
        Me.Grpdetails.Name = "Grpdetails"
        Me.Grpdetails.Size = New System.Drawing.Size(587, 617)
        Me.Grpdetails.TabIndex = 2
        Me.Grpdetails.TabStop = False
        Me.Grpdetails.Text = "Student Details"
        '
        'butedit
        '
        Me.butedit.Location = New System.Drawing.Point(426, 543)
        Me.butedit.Name = "butedit"
        Me.butedit.Size = New System.Drawing.Size(75, 23)
        Me.butedit.TabIndex = 18
        Me.butedit.Text = "Edit"
        Me.butedit.UseVisualStyleBackColor = True
        '
        'txtdue
        '
        Me.txtdue.Location = New System.Drawing.Point(327, 544)
        Me.txtdue.Name = "txtdue"
        Me.txtdue.Size = New System.Drawing.Size(81, 22)
        Me.txtdue.TabIndex = 17
        Me.txtdue.Visible = False
        '
        'picbox
        '
        Me.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox.Location = New System.Drawing.Point(217, 35)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(213, 240)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox.TabIndex = 16
        Me.picbox.TabStop = False
        '
        'lblsection
        '
        Me.lblsection.AutoSize = True
        Me.lblsection.Location = New System.Drawing.Point(342, 409)
        Me.lblsection.Name = "lblsection"
        Me.lblsection.Size = New System.Drawing.Size(51, 17)
        Me.lblsection.TabIndex = 13
        Me.lblsection.Text = "Label9"
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Location = New System.Drawing.Point(339, 366)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(51, 17)
        Me.lblclass.TabIndex = 12
        Me.lblclass.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Section"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Class"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(336, 318)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 17)
        Me.lblname.TabIndex = 9
        Me.lblname.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Name"
        '
        'lbldue
        '
        Me.lbldue.AutoSize = True
        Me.lbldue.Location = New System.Drawing.Point(339, 549)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(51, 17)
        Me.lbldue.TabIndex = 7
        Me.lbldue.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 549)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Due"
        '
        'lblfeesmonth
        '
        Me.lblfeesmonth.AutoSize = True
        Me.lblfeesmonth.Location = New System.Drawing.Point(339, 500)
        Me.lblfeesmonth.Name = "lblfeesmonth"
        Me.lblfeesmonth.Size = New System.Drawing.Size(51, 17)
        Me.lblfeesmonth.TabIndex = 5
        Me.lblfeesmonth.Text = "Label4"
        '
        'lblfee
        '
        Me.lblfee.AutoSize = True
        Me.lblfee.Location = New System.Drawing.Point(229, 500)
        Me.lblfee.Name = "lblfee"
        Me.lblfee.Size = New System.Drawing.Size(82, 17)
        Me.lblfee.TabIndex = 4
        Me.lblfee.Text = "Fees/Month"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Location = New System.Drawing.Point(336, 453)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(51, 17)
        Me.lblage.TabIndex = 3
        Me.lblage.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 453)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age"
        '
        'cboname
        '
        Me.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboname.FormattingEnabled = True
        Me.cboname.Location = New System.Drawing.Point(193, 26)
        Me.cboname.Name = "cboname"
        Me.cboname.Size = New System.Drawing.Size(183, 24)
        Me.cboname.TabIndex = 1
        '
        'loadpay
        '
        Me.loadpay.Location = New System.Drawing.Point(63, 561)
        Me.loadpay.Name = "loadpay"
        Me.loadpay.Size = New System.Drawing.Size(120, 68)
        Me.loadpay.TabIndex = 6
        Me.loadpay.Text = "Load"
        Me.loadpay.UseVisualStyleBackColor = True
        Me.loadpay.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 77)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Show All Transactions"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblpay
        '
        Me.lblpay.AutoSize = True
        Me.lblpay.Location = New System.Drawing.Point(80, 465)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(155, 17)
        Me.lblpay.TabIndex = 22
        Me.lblpay.Text = "Enter The Amount Paid"
        Me.lblpay.Visible = False
        '
        'txtpay
        '
        Me.txtpay.Location = New System.Drawing.Point(267, 460)
        Me.txtpay.Name = "txtpay"
        Me.txtpay.Size = New System.Drawing.Size(190, 22)
        Me.txtpay.TabIndex = 4
        Me.txtpay.Visible = False
        '
        'makepay
        '
        Me.makepay.Location = New System.Drawing.Point(30, 91)
        Me.makepay.Name = "makepay"
        Me.makepay.Size = New System.Drawing.Size(199, 71)
        Me.makepay.TabIndex = 3
        Me.makepay.Text = "Make Payment"
        Me.makepay.UseVisualStyleBackColor = True
        '
        'loadcan
        '
        Me.loadcan.Location = New System.Drawing.Point(353, 561)
        Me.loadcan.Name = "loadcan"
        Me.loadcan.Size = New System.Drawing.Size(140, 68)
        Me.loadcan.TabIndex = 8
        Me.loadcan.Text = "Cancel"
        Me.loadcan.UseVisualStyleBackColor = True
        Me.loadcan.Visible = False
        '
        'PrintDocument1
        '
        '
        'ckjan
        '
        Me.ckjan.AutoSize = True
        Me.ckjan.Location = New System.Drawing.Point(75, 94)
        Me.ckjan.Name = "ckjan"
        Me.ckjan.Size = New System.Drawing.Size(53, 21)
        Me.ckjan.TabIndex = 26
        Me.ckjan.Text = "Jan"
        Me.ckjan.UseVisualStyleBackColor = True
        '
        'ckdec
        '
        Me.ckdec.AutoSize = True
        Me.ckdec.Location = New System.Drawing.Point(265, 215)
        Me.ckdec.Name = "ckdec"
        Me.ckdec.Size = New System.Drawing.Size(95, 21)
        Me.ckdec.TabIndex = 28
        Me.ckdec.Text = "December"
        Me.ckdec.UseVisualStyleBackColor = True
        '
        'cknov
        '
        Me.cknov.AutoSize = True
        Me.cknov.Location = New System.Drawing.Point(164, 215)
        Me.cknov.Name = "cknov"
        Me.cknov.Size = New System.Drawing.Size(95, 21)
        Me.cknov.TabIndex = 29
        Me.cknov.Text = "November"
        Me.cknov.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cknov.UseVisualStyleBackColor = True
        '
        'ckoct
        '
        Me.ckoct.AutoSize = True
        Me.ckoct.Location = New System.Drawing.Point(77, 215)
        Me.ckoct.Name = "ckoct"
        Me.ckoct.Size = New System.Drawing.Size(81, 21)
        Me.ckoct.TabIndex = 30
        Me.ckoct.Text = "October"
        Me.ckoct.UseVisualStyleBackColor = True
        '
        'ckaug
        '
        Me.ckaug.AutoSize = True
        Me.ckaug.Location = New System.Drawing.Point(164, 176)
        Me.ckaug.Name = "ckaug"
        Me.ckaug.Size = New System.Drawing.Size(74, 21)
        Me.ckaug.TabIndex = 31
        Me.ckaug.Text = "Augest"
        Me.ckaug.UseVisualStyleBackColor = True
        '
        'ckjune
        '
        Me.ckjune.AutoSize = True
        Me.ckjune.Location = New System.Drawing.Point(265, 135)
        Me.ckjune.Name = "ckjune"
        Me.ckjune.Size = New System.Drawing.Size(57, 21)
        Me.ckjune.TabIndex = 32
        Me.ckjune.Text = "june"
        Me.ckjune.UseVisualStyleBackColor = True
        '
        'ckapril
        '
        Me.ckapril.AutoSize = True
        Me.ckapril.Location = New System.Drawing.Point(77, 135)
        Me.ckapril.Name = "ckapril"
        Me.ckapril.Size = New System.Drawing.Size(58, 21)
        Me.ckapril.TabIndex = 33
        Me.ckapril.Text = "April"
        Me.ckapril.UseVisualStyleBackColor = True
        '
        'ckmar
        '
        Me.ckmar.AutoSize = True
        Me.ckmar.Location = New System.Drawing.Point(265, 94)
        Me.ckmar.Name = "ckmar"
        Me.ckmar.Size = New System.Drawing.Size(69, 21)
        Me.ckmar.TabIndex = 34
        Me.ckmar.Text = "March"
        Me.ckmar.UseVisualStyleBackColor = True
        '
        'cksept
        '
        Me.cksept.AutoSize = True
        Me.cksept.Location = New System.Drawing.Point(265, 176)
        Me.cksept.Name = "cksept"
        Me.cksept.Size = New System.Drawing.Size(99, 21)
        Me.cksept.TabIndex = 35
        Me.cksept.Text = "September"
        Me.cksept.UseVisualStyleBackColor = True
        '
        'ckmay
        '
        Me.ckmay.AutoSize = True
        Me.ckmay.Location = New System.Drawing.Point(164, 135)
        Me.ckmay.Name = "ckmay"
        Me.ckmay.Size = New System.Drawing.Size(56, 21)
        Me.ckmay.TabIndex = 36
        Me.ckmay.Text = "may"
        Me.ckmay.UseVisualStyleBackColor = True
        '
        'ckfeb
        '
        Me.ckfeb.AutoSize = True
        Me.ckfeb.Location = New System.Drawing.Point(164, 94)
        Me.ckfeb.Name = "ckfeb"
        Me.ckfeb.Size = New System.Drawing.Size(54, 21)
        Me.ckfeb.TabIndex = 37
        Me.ckfeb.Text = "Feb"
        Me.ckfeb.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblyear)
        Me.GroupBox1.Controls.Add(Me.ckjuly)
        Me.GroupBox1.Controls.Add(Me.cboyear)
        Me.GroupBox1.Controls.Add(Me.ckfeb)
        Me.GroupBox1.Controls.Add(Me.ckdec)
        Me.GroupBox1.Controls.Add(Me.cknov)
        Me.GroupBox1.Controls.Add(Me.ckoct)
        Me.GroupBox1.Controls.Add(Me.cksept)
        Me.GroupBox1.Controls.Add(Me.ckmay)
        Me.GroupBox1.Controls.Add(Me.ckmar)
        Me.GroupBox1.Controls.Add(Me.ckapril)
        Me.GroupBox1.Controls.Add(Me.ckjune)
        Me.GroupBox1.Controls.Add(Me.ckaug)
        Me.GroupBox1.Controls.Add(Me.ckjan)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 256)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Months"
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Location = New System.Drawing.Point(93, 36)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(38, 17)
        Me.lblyear.TabIndex = 40
        Me.lblyear.Text = "Year"
        Me.lblyear.Visible = False
        '
        'ckjuly
        '
        Me.ckjuly.AutoSize = True
        Me.ckjuly.Location = New System.Drawing.Point(75, 172)
        Me.ckjuly.Name = "ckjuly"
        Me.ckjuly.Size = New System.Drawing.Size(55, 21)
        Me.ckjuly.TabIndex = 38
        Me.ckjuly.Text = "July"
        Me.ckjuly.UseVisualStyleBackColor = True
        '
        'cboyear
        '
        Me.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.cboyear.Location = New System.Drawing.Point(163, 29)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(183, 24)
        Me.cboyear.TabIndex = 39
        '
        'btignore
        '
        Me.btignore.Location = New System.Drawing.Point(212, 561)
        Me.btignore.Name = "btignore"
        Me.btignore.Size = New System.Drawing.Size(120, 68)
        Me.btignore.TabIndex = 7
        Me.btignore.Text = "Ignore selected Month"
        Me.btignore.UseVisualStyleBackColor = True
        Me.btignore.Visible = False
        '
        'txtrange
        '
        Me.txtrange.Location = New System.Drawing.Point(267, 506)
        Me.txtrange.Name = "txtrange"
        Me.txtrange.Size = New System.Drawing.Size(190, 22)
        Me.txtrange.TabIndex = 5
        Me.txtrange.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 511)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Paid Month Range"
        Me.Label3.Visible = False
        '
        'FeesStructures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 641)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrange)
        Me.Controls.Add(Me.btignore)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.loadcan)
        Me.Controls.Add(Me.makepay)
        Me.Controls.Add(Me.txtpay)
        Me.Controls.Add(Me.lblpay)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.loadpay)
        Me.Controls.Add(Me.cboname)
        Me.Controls.Add(Me.Grpdetails)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FeesStructures"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student's Fees Manager"
        Me.Grpdetails.ResumeLayout(False)
        Me.Grpdetails.PerformLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grpdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblfeesmonth As System.Windows.Forms.Label
    Friend WithEvents lblfee As System.Windows.Forms.Label
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblsection As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbldue As System.Windows.Forms.Label
    Friend WithEvents cboname As System.Windows.Forms.ComboBox
    Friend WithEvents loadpay As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblpay As System.Windows.Forms.Label
    Friend WithEvents txtpay As System.Windows.Forms.TextBox
    Friend WithEvents makepay As System.Windows.Forms.Button
    Friend WithEvents loadcan As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
    Friend WithEvents ckjan As System.Windows.Forms.CheckBox
    Friend WithEvents ckdec As System.Windows.Forms.CheckBox
    Friend WithEvents cknov As System.Windows.Forms.CheckBox
    Friend WithEvents ckoct As System.Windows.Forms.CheckBox
    Friend WithEvents ckaug As System.Windows.Forms.CheckBox
    Friend WithEvents ckjune As System.Windows.Forms.CheckBox
    Friend WithEvents ckapril As System.Windows.Forms.CheckBox
    Friend WithEvents ckmar As System.Windows.Forms.CheckBox
    Friend WithEvents cksept As System.Windows.Forms.CheckBox
    Friend WithEvents ckmay As System.Windows.Forms.CheckBox
    Friend WithEvents ckfeb As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckjuly As System.Windows.Forms.CheckBox
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents btignore As System.Windows.Forms.Button
    Friend WithEvents butedit As System.Windows.Forms.Button
    Friend WithEvents txtdue As System.Windows.Forms.TextBox
    Friend WithEvents txtrange As TextBox
    Friend WithEvents Label3 As Label
End Class
