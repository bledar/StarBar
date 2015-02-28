<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaneliShitjes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaneliShitjes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmriPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProdukteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StarBarDataSet2 = New StarBar.StarBarDataSet2()
        Me.StarBarDataSet = New StarBar.StarBarDataSet()
        Me.StarBarDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdukteTableAdapter = New StarBar.StarBarDataSet2TableAdapters.ProdukteTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Numri_l = New System.Windows.Forms.ListBox()
        Me.Emri_l = New System.Windows.Forms.ListBox()
        Me.Sasia_l = New System.Windows.Forms.ListBox()
        Me.Cmimi_l = New System.Windows.Forms.ListBox()
        Me.Totali_l = New System.Windows.Forms.ListBox()
        Me.ShumaTotale = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarBarDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarBarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarBarDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmriPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProdukteBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(13, 83)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(280, 580)
        Me.DataGridView1.TabIndex = 1
        '
        'EmriPDataGridViewTextBoxColumn
        '
        Me.EmriPDataGridViewTextBoxColumn.DataPropertyName = "EmriP"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = "(Gabim)"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        Me.EmriPDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmriPDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmriPDataGridViewTextBoxColumn.HeaderText = ""
        Me.EmriPDataGridViewTextBoxColumn.Name = "EmriPDataGridViewTextBoxColumn"
        Me.EmriPDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmriPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmriPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmriPDataGridViewTextBoxColumn.Text = "EmriP"
        Me.EmriPDataGridViewTextBoxColumn.Width = 280
        '
        'ProdukteBindingSource
        '
        Me.ProdukteBindingSource.DataMember = "Produkte"
        Me.ProdukteBindingSource.DataSource = Me.StarBarDataSet2
        '
        'StarBarDataSet2
        '
        Me.StarBarDataSet2.DataSetName = "StarBarDataSet2"
        Me.StarBarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StarBarDataSet
        '
        Me.StarBarDataSet.DataSetName = "StarBarDataSet"
        Me.StarBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StarBarDataSetBindingSource
        '
        Me.StarBarDataSetBindingSource.DataSource = Me.StarBarDataSet
        Me.StarBarDataSetBindingSource.Position = 0
        '
        'ProdukteTableAdapter
        '
        Me.ProdukteTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ShumaTotale)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Totali_l)
        Me.GroupBox1.Controls.Add(Me.Cmimi_l)
        Me.GroupBox1.Controls.Add(Me.Sasia_l)
        Me.GroupBox1.Controls.Add(Me.Emri_l)
        Me.GroupBox1.Controls.Add(Me.Numri_l)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 529)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fatura Aktuale:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Totali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Emri Produktit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sasia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cmimi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nr"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SHUMA TOTALE"
        '
        'Numri_l
        '
        Me.Numri_l.Enabled = False
        Me.Numri_l.FormattingEnabled = True
        Me.Numri_l.ItemHeight = 20
        Me.Numri_l.Location = New System.Drawing.Point(7, 46)
        Me.Numri_l.Name = "Numri_l"
        Me.Numri_l.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Numri_l.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Numri_l.Size = New System.Drawing.Size(31, 444)
        Me.Numri_l.TabIndex = 13
        '
        'Emri_l
        '
        Me.Emri_l.Enabled = False
        Me.Emri_l.FormattingEnabled = True
        Me.Emri_l.ItemHeight = 20
        Me.Emri_l.Location = New System.Drawing.Point(38, 46)
        Me.Emri_l.Name = "Emri_l"
        Me.Emri_l.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Emri_l.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Emri_l.Size = New System.Drawing.Size(114, 444)
        Me.Emri_l.TabIndex = 14
        '
        'Sasia_l
        '
        Me.Sasia_l.Enabled = False
        Me.Sasia_l.FormattingEnabled = True
        Me.Sasia_l.ItemHeight = 20
        Me.Sasia_l.Location = New System.Drawing.Point(152, 46)
        Me.Sasia_l.Name = "Sasia_l"
        Me.Sasia_l.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sasia_l.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Sasia_l.Size = New System.Drawing.Size(53, 444)
        Me.Sasia_l.TabIndex = 15
        '
        'Cmimi_l
        '
        Me.Cmimi_l.Enabled = False
        Me.Cmimi_l.FormattingEnabled = True
        Me.Cmimi_l.ItemHeight = 20
        Me.Cmimi_l.Location = New System.Drawing.Point(205, 46)
        Me.Cmimi_l.Name = "Cmimi_l"
        Me.Cmimi_l.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmimi_l.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Cmimi_l.Size = New System.Drawing.Size(104, 444)
        Me.Cmimi_l.TabIndex = 16
        '
        'Totali_l
        '
        Me.Totali_l.Enabled = False
        Me.Totali_l.FormattingEnabled = True
        Me.Totali_l.ItemHeight = 20
        Me.Totali_l.Location = New System.Drawing.Point(309, 46)
        Me.Totali_l.Name = "Totali_l"
        Me.Totali_l.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Totali_l.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Totali_l.Size = New System.Drawing.Size(149, 444)
        Me.Totali_l.TabIndex = 17
        '
        'ShumaTotale
        '
        Me.ShumaTotale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShumaTotale.AutoSize = True
        Me.ShumaTotale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShumaTotale.Location = New System.Drawing.Point(328, 493)
        Me.ShumaTotale.Name = "ShumaTotale"
        Me.ShumaTotale.Size = New System.Drawing.Size(21, 24)
        Me.ShumaTotale.TabIndex = 18
        Me.ShumaTotale.Text = "0"
        '
        'PaneliShitjes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 675)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "PaneliShitjes"
        Me.Text = "PaneliShitjes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarBarDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarBarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarBarDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StarBarDataSet As StarBar.StarBarDataSet
    Friend WithEvents StarBarDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StarBarDataSet2 As StarBar.StarBarDataSet2
    Friend WithEvents ProdukteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdukteTableAdapter As StarBar.StarBarDataSet2TableAdapters.ProdukteTableAdapter
    Friend WithEvents EmriPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Totali_l As System.Windows.Forms.ListBox
    Friend WithEvents Cmimi_l As System.Windows.Forms.ListBox
    Friend WithEvents Sasia_l As System.Windows.Forms.ListBox
    Friend WithEvents Emri_l As System.Windows.Forms.ListBox
    Friend WithEvents Numri_l As System.Windows.Forms.ListBox
    Friend WithEvents ShumaTotale As System.Windows.Forms.Label
End Class
