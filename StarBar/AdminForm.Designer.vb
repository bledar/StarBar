<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Dil_b = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FshiUser_b = New System.Windows.Forms.Button()
        Me.ShtoUser_b = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ShtoUser_b)
        Me.Panel1.Location = New System.Drawing.Point(43, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 382)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Perdoruesit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Produkte"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Location = New System.Drawing.Point(377, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(266, 382)
        Me.Panel3.TabIndex = 8
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.Image = Global.StarBar.My.Resources.Resources.Actions_view_pim_tasks_icon
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button7.Location = New System.Drawing.Point(34, 104)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(204, 61)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Ndrysho Produktet"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button8.Image = Global.StarBar.My.Resources.Resources.Actions_document_print_icon
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button8.Location = New System.Drawing.Point(703, 263)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(204, 61)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Printo Raportin"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button9.Image = Global.StarBar.My.Resources.Resources.Actions_application_exit_icon
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button9.Location = New System.Drawing.Point(34, 182)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(204, 56)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Fshi Produktin"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button10.Image = Global.StarBar.My.Resources.Resources.Actions_insert_table_icon
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button10.Location = New System.Drawing.Point(34, 26)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(204, 57)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Shto Produkt"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.StarBar.My.Resources.Resources.Actions_view_pim_tasks_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(34, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 61)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ndrysho Kredencialet"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dil_b
        '
        Me.Dil_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Dil_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dil_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dil_b.Image = Global.StarBar.My.Resources.Resources.Actions_system_shutdown_icon
        Me.Dil_b.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Dil_b.Location = New System.Drawing.Point(703, 344)
        Me.Dil_b.Name = "Dil_b"
        Me.Dil_b.Size = New System.Drawing.Size(204, 57)
        Me.Dil_b.TabIndex = 10
        Me.Dil_b.Text = "Dil nga Llogaria"
        Me.Dil_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Dil_b.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = Global.StarBar.My.Resources.Resources.Actions_view_pim_tasks_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(62, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 61)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ndysho Kredencialet"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.StarBar.My.Resources.Resources.Actions_document_print_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(62, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 61)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Printo Raportin"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FshiUser_b
        '
        Me.FshiUser_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FshiUser_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FshiUser_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FshiUser_b.Image = Global.StarBar.My.Resources.Resources.Actions_application_exit_icon
        Me.FshiUser_b.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.FshiUser_b.Location = New System.Drawing.Point(62, 268)
        Me.FshiUser_b.Name = "FshiUser_b"
        Me.FshiUser_b.Size = New System.Drawing.Size(204, 56)
        Me.FshiUser_b.TabIndex = 1
        Me.FshiUser_b.Text = "Fshi User"
        Me.FshiUser_b.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FshiUser_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FshiUser_b.UseVisualStyleBackColor = True
        '
        'ShtoUser_b
        '
        Me.ShtoUser_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShtoUser_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShtoUser_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ShtoUser_b.Image = Global.StarBar.My.Resources.Resources.Actions_contact_new_icon
        Me.ShtoUser_b.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ShtoUser_b.Location = New System.Drawing.Point(17, 26)
        Me.ShtoUser_b.Name = "ShtoUser_b"
        Me.ShtoUser_b.Size = New System.Drawing.Size(204, 57)
        Me.ShtoUser_b.TabIndex = 0
        Me.ShtoUser_b.Text = "Shto Perdorues"
        Me.ShtoUser_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShtoUser_b.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 493)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Dil_b)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FshiUser_b)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShtoUser_b As System.Windows.Forms.Button
    Friend WithEvents FshiUser_b As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Dil_b As System.Windows.Forms.Button
End Class
