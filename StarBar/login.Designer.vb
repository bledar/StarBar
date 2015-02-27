<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.LoginEmri_t = New System.Windows.Forms.TextBox()
        Me.LognKodi_t = New System.Windows.Forms.TextBox()
        Me.logohu_b = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LoginEmri_t
        '
        Me.LoginEmri_t.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginEmri_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginEmri_t.Location = New System.Drawing.Point(486, 206)
        Me.LoginEmri_t.Name = "LoginEmri_t"
        Me.LoginEmri_t.Size = New System.Drawing.Size(242, 29)
        Me.LoginEmri_t.TabIndex = 0
        Me.LoginEmri_t.Text = "admin"
        '
        'LognKodi_t
        '
        Me.LognKodi_t.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LognKodi_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LognKodi_t.Location = New System.Drawing.Point(487, 300)
        Me.LognKodi_t.Name = "LognKodi_t"
        Me.LognKodi_t.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LognKodi_t.Size = New System.Drawing.Size(242, 29)
        Me.LognKodi_t.TabIndex = 1
        Me.LognKodi_t.Text = "123456"
        Me.LognKodi_t.UseSystemPasswordChar = True
        Me.LognKodi_t.WordWrap = False
        '
        'logohu_b
        '
        Me.logohu_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logohu_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logohu_b.Location = New System.Drawing.Point(487, 352)
        Me.logohu_b.Name = "logohu_b"
        Me.logohu_b.Size = New System.Drawing.Size(242, 61)
        Me.logohu_b.TabIndex = 2
        Me.logohu_b.Text = "logohu"
        Me.logohu_b.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Peroduesi"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(481, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fjalekalimi"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(461, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 284)
        Me.Panel1.TabIndex = 5
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(825, 576)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logohu_b)
        Me.Controls.Add(Me.LognKodi_t)
        Me.Controls.Add(Me.LoginEmri_t)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "login"
        Me.Text = "* StarBar *"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginEmri_t As System.Windows.Forms.TextBox
    Friend WithEvents LognKodi_t As System.Windows.Forms.TextBox
    Friend WithEvents logohu_b As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
