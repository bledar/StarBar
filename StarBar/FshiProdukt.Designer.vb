<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FshiProdukt
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FshiProduktin_cb = New System.Windows.Forms.ComboBox()
        Me.FshijP_b = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.FshiProduktin_cb)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zgjidh Produktin qe deshironi te fshini"
        '
        'FshiProduktin_cb
        '
        Me.FshiProduktin_cb.FormattingEnabled = True
        Me.FshiProduktin_cb.Location = New System.Drawing.Point(78, 30)
        Me.FshiProduktin_cb.Name = "FshiProduktin_cb"
        Me.FshiProduktin_cb.Size = New System.Drawing.Size(326, 28)
        Me.FshiProduktin_cb.TabIndex = 0
        '
        'FshijP_b
        '
        Me.FshijP_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FshijP_b.Image = Global.StarBar.My.Resources.Resources.Actions_application_exit_icon
        Me.FshijP_b.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FshijP_b.Location = New System.Drawing.Point(119, 135)
        Me.FshijP_b.Name = "FshijP_b"
        Me.FshijP_b.Size = New System.Drawing.Size(200, 57)
        Me.FshijP_b.TabIndex = 1
        Me.FshijP_b.Text = "Fshij Produktin"
        Me.FshijP_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FshijP_b.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StarBar.My.Resources.Resources.shopping232
        Me.PictureBox1.Location = New System.Drawing.Point(13, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FshiProdukt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 231)
        Me.Controls.Add(Me.FshijP_b)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(450, 270)
        Me.MaximumSize = New System.Drawing.Size(450, 270)
        Me.MinimumSize = New System.Drawing.Size(450, 270)
        Me.Name = "FshiProdukt"
        Me.Text = "FshiProdukt"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FshiProduktin_cb As System.Windows.Forms.ComboBox
    Friend WithEvents FshijP_b As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
