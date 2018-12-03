<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selection
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
        Me.teacher = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'teacher
        '
        Me.teacher.Location = New System.Drawing.Point(92, 51)
        Me.teacher.Name = "teacher"
        Me.teacher.Size = New System.Drawing.Size(324, 90)
        Me.teacher.TabIndex = 0
        Me.teacher.Text = "Teacher's Attendance"
        Me.teacher.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(324, 90)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Student's Attendance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 383)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.teacher)
        Me.Name = "Selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teacher As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
