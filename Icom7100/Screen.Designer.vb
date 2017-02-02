<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen
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
        Me.BtnButton1 = New System.Windows.Forms.Button()
        Me.btnButton2 = New System.Windows.Forms.Button()
        Me.btnButton3 = New System.Windows.Forms.Button()
        Me.btnButton4 = New System.Windows.Forms.Button()
        Me.btnButton5 = New System.Windows.Forms.Button()
        Me.rtxFreq = New System.Windows.Forms.RichTextBox()
        Me.rtxName = New System.Windows.Forms.RichTextBox()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnButton1
        '
        Me.BtnButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnButton1.Location = New System.Drawing.Point(73, 503)
        Me.BtnButton1.Name = "BtnButton1"
        Me.BtnButton1.Size = New System.Drawing.Size(132, 58)
        Me.BtnButton1.TabIndex = 0
        Me.BtnButton1.Text = "Button1"
        Me.BtnButton1.UseVisualStyleBackColor = True
        '
        'btnButton2
        '
        Me.btnButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton2.Location = New System.Drawing.Point(241, 503)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(132, 58)
        Me.btnButton2.TabIndex = 1
        Me.btnButton2.Text = "Button2"
        Me.btnButton2.UseVisualStyleBackColor = True
        '
        'btnButton3
        '
        Me.btnButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton3.Location = New System.Drawing.Point(409, 503)
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(132, 58)
        Me.btnButton3.TabIndex = 2
        Me.btnButton3.Text = "Button3"
        Me.btnButton3.UseVisualStyleBackColor = True
        '
        'btnButton4
        '
        Me.btnButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton4.Location = New System.Drawing.Point(577, 503)
        Me.btnButton4.Name = "btnButton4"
        Me.btnButton4.Size = New System.Drawing.Size(132, 58)
        Me.btnButton4.TabIndex = 3
        Me.btnButton4.Text = "Button4"
        Me.btnButton4.UseVisualStyleBackColor = True
        '
        'btnButton5
        '
        Me.btnButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton5.Location = New System.Drawing.Point(745, 503)
        Me.btnButton5.Name = "btnButton5"
        Me.btnButton5.Size = New System.Drawing.Size(132, 58)
        Me.btnButton5.TabIndex = 4
        Me.btnButton5.Text = "Button5"
        Me.btnButton5.UseVisualStyleBackColor = True
        '
        'rtxFreq
        '
        Me.rtxFreq.Location = New System.Drawing.Point(219, 65)
        Me.rtxFreq.Name = "rtxFreq"
        Me.rtxFreq.Size = New System.Drawing.Size(523, 52)
        Me.rtxFreq.TabIndex = 5
        Me.rtxFreq.Text = ""
        '
        'rtxName
        '
        Me.rtxName.Location = New System.Drawing.Point(219, 123)
        Me.rtxName.Name = "rtxName"
        Me.rtxName.Size = New System.Drawing.Size(523, 52)
        Me.rtxName.TabIndex = 6
        Me.rtxName.Text = ""
        '
        'btnMode
        '
        Me.btnMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMode.Location = New System.Drawing.Point(219, 12)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(75, 33)
        Me.btnMode.TabIndex = 7
        Me.btnMode.Text = "Mode"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 582)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.rtxName)
        Me.Controls.Add(Me.rtxFreq)
        Me.Controls.Add(Me.btnButton5)
        Me.Controls.Add(Me.btnButton4)
        Me.Controls.Add(Me.btnButton3)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.BtnButton1)
        Me.Name = "Screen"
        Me.Text = "Screen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnButton1 As Button
    Friend WithEvents btnButton2 As Button
    Friend WithEvents btnButton3 As Button
    Friend WithEvents btnButton4 As Button
    Friend WithEvents btnButton5 As Button
    Friend WithEvents rtxFreq As RichTextBox
    Friend WithEvents rtxName As RichTextBox
    Friend WithEvents btnMode As Button
End Class
