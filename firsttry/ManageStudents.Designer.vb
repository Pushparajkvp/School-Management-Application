<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudents
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
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.bnnew = New System.Windows.Forms.Button()
        Me.bnprint = New System.Windows.Forms.Button()
        Me.bndelete = New System.Windows.Forms.Button()
        Me.bnrefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1148, 497)
        Me.DataGridView1.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(13, 33)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(1147, 22)
        Me.txtsearch.TabIndex = 1
        '
        'bnnew
        '
        Me.bnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnnew.Location = New System.Drawing.Point(63, 606)
        Me.bnnew.Name = "bnnew"
        Me.bnnew.Size = New System.Drawing.Size(230, 83)
        Me.bnnew.TabIndex = 2
        Me.bnnew.Text = "Add New Student"
        Me.bnnew.UseVisualStyleBackColor = True
        '
        'bnprint
        '
        Me.bnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnprint.Location = New System.Drawing.Point(887, 606)
        Me.bnprint.Name = "bnprint"
        Me.bnprint.Size = New System.Drawing.Size(230, 83)
        Me.bnprint.TabIndex = 3
        Me.bnprint.Text = "Edit"
        Me.bnprint.UseVisualStyleBackColor = True
        '
        'bndelete
        '
        Me.bndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bndelete.Location = New System.Drawing.Point(620, 606)
        Me.bndelete.Name = "bndelete"
        Me.bndelete.Size = New System.Drawing.Size(230, 83)
        Me.bndelete.TabIndex = 4
        Me.bndelete.Text = "Delete"
        Me.bndelete.UseVisualStyleBackColor = True
        '
        'bnrefresh
        '
        Me.bnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnrefresh.Location = New System.Drawing.Point(332, 606)
        Me.bnrefresh.Name = "bnrefresh"
        Me.bnrefresh.Size = New System.Drawing.Size(230, 83)
        Me.bnrefresh.TabIndex = 5
        Me.bnrefresh.Text = "Refresh"
        Me.bnrefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter Name to filter"
        '
        'ManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 733)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnrefresh)
        Me.Controls.Add(Me.bndelete)
        Me.Controls.Add(Me.bnprint)
        Me.Controls.Add(Me.bnnew)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ManageStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bnnew As System.Windows.Forms.Button
    Friend WithEvents bnprint As System.Windows.Forms.Button
    Friend WithEvents bndelete As System.Windows.Forms.Button
    Friend WithEvents bnrefresh As System.Windows.Forms.Button
    Friend WithEvents RegistrationNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
