<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageTeacher
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bnadd = New System.Windows.Forms.Button()
        Me.bnrefresh = New System.Windows.Forms.Button()
        Me.bndelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnprint = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1134, 22)
        Me.TextBox1.TabIndex = 1
        '
        'bnadd
        '
        Me.bnadd.Location = New System.Drawing.Point(19, 572)
        Me.bnadd.Name = "bnadd"
        Me.bnadd.Size = New System.Drawing.Size(257, 59)
        Me.bnadd.TabIndex = 2
        Me.bnadd.Text = "Add New Teacher"
        Me.bnadd.UseVisualStyleBackColor = True
        '
        'bnrefresh
        '
        Me.bnrefresh.Location = New System.Drawing.Point(604, 572)
        Me.bnrefresh.Name = "bnrefresh"
        Me.bnrefresh.Size = New System.Drawing.Size(257, 59)
        Me.bnrefresh.TabIndex = 4
        Me.bnrefresh.Text = "Refresh"
        Me.bnrefresh.UseVisualStyleBackColor = True
        '
        'bndelete
        '
        Me.bndelete.Location = New System.Drawing.Point(310, 572)
        Me.bndelete.Name = "bndelete"
        Me.bndelete.Size = New System.Drawing.Size(257, 59)
        Me.bndelete.TabIndex = 5
        Me.bndelete.Text = "Delete Selected Teacher Records"
        Me.bndelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search"
        '
        'bnprint
        '
        Me.bnprint.Location = New System.Drawing.Point(896, 572)
        Me.bnprint.Name = "bnprint"
        Me.bnprint.Size = New System.Drawing.Size(257, 59)
        Me.bnprint.TabIndex = 3
        Me.bnprint.Text = "Close"
        Me.bnprint.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1134, 478)
        Me.DataGridView1.TabIndex = 7
        '
        'ManageTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 652)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bndelete)
        Me.Controls.Add(Me.bnrefresh)
        Me.Controls.Add(Me.bnprint)
        Me.Controls.Add(Me.bnadd)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ManageTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageTeacher"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bnadd As System.Windows.Forms.Button
    Friend WithEvents bnrefresh As System.Windows.Forms.Button
    Friend WithEvents bndelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bnprint As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
