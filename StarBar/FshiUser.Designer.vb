<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FshiUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FshiPerdoruesin_cb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FshiPerdorues_b = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.FshiPerdoruesin_cb)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 60)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StarBar.My.Resources.Resources.Folders_OS_User_No_Frame_Metro_icon
        Me.PictureBox1.Location = New System.Drawing.Point(4, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FshiPerdoruesin_cb
        '
        Me.FshiPerdoruesin_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FshiPerdoruesin_cb.FormattingEnabled = True
        Me.FshiPerdoruesin_cb.Location = New System.Drawing.Point(59, 17)
        Me.FshiPerdoruesin_cb.Name = "FshiPerdoruesin_cb"
        Me.FshiPerdoruesin_cb.Size = New System.Drawing.Size(346, 28)
        Me.FshiPerdoruesin_cb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Zgjidh Perdoruesin:"
        '
        'FshiPerdorues_b
        '
        Me.FshiPerdorues_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FshiPerdorues_b.Image = Global.StarBar.My.Resources.Resources.Actions_application_exit_icon
        Me.FshiPerdorues_b.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FshiPerdorues_b.Location = New System.Drawing.Point(112, 126)
        Me.FshiPerdorues_b.Name = "FshiPerdorues_b"
        Me.FshiPerdorues_b.Size = New System.Drawing.Size(200, 51)
        Me.FshiPerdorues_b.TabIndex = 2
        Me.FshiPerdorues_b.Text = "Fshije!"
        Me.FshiPerdorues_b.UseVisualStyleBackColor = True
        '
        'FshiUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 231)
        Me.Controls.Add(Me.FshiPerdorues_b)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 270)
        Me.Name = "FshiUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FshiUser"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FshiPerdoruesin_cb As System.Windows.Forms.ComboBox
    Friend WithEvents FshiPerdorues_b As System.Windows.Forms.Button
End Class
