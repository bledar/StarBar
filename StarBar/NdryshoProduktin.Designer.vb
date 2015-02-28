<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NdryshoProduktin
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
        Me.TabelProdukte = New System.Windows.Forms.DataGridView()
        Me.StarBarDataSet1 = New StarBar.StarBarDataSet1()
        Me.ProdukteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdukteTableAdapter = New StarBar.StarBarDataSet1TableAdapters.ProdukteTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmriPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmimiPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SasiaPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuajProduktin_b = New System.Windows.Forms.Button()
        CType(Me.TabelProdukte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarBarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabelProdukte
        '
        Me.TabelProdukte.AllowUserToDeleteRows = False
        Me.TabelProdukte.AutoGenerateColumns = False
        Me.TabelProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelProdukte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EmriPDataGridViewTextBoxColumn, Me.CmimiPDataGridViewTextBoxColumn, Me.SasiaPDataGridViewTextBoxColumn})
        Me.TabelProdukte.DataSource = Me.ProdukteBindingSource
        Me.TabelProdukte.Location = New System.Drawing.Point(13, 13)
        Me.TabelProdukte.Name = "TabelProdukte"
        Me.TabelProdukte.Size = New System.Drawing.Size(459, 292)
        Me.TabelProdukte.TabIndex = 0
        '
        'StarBarDataSet1
        '
        Me.StarBarDataSet1.DataSetName = "StarBarDataSet1"
        Me.StarBarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdukteBindingSource
        '
        Me.ProdukteBindingSource.DataMember = "Produkte"
        Me.ProdukteBindingSource.DataSource = Me.StarBarDataSet1
        '
        'ProdukteTableAdapter
        '
        Me.ProdukteTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmriPDataGridViewTextBoxColumn
        '
        Me.EmriPDataGridViewTextBoxColumn.DataPropertyName = "EmriP"
        Me.EmriPDataGridViewTextBoxColumn.HeaderText = "EmriP"
        Me.EmriPDataGridViewTextBoxColumn.Name = "EmriPDataGridViewTextBoxColumn"
        '
        'CmimiPDataGridViewTextBoxColumn
        '
        Me.CmimiPDataGridViewTextBoxColumn.DataPropertyName = "CmimiP"
        Me.CmimiPDataGridViewTextBoxColumn.HeaderText = "CmimiP"
        Me.CmimiPDataGridViewTextBoxColumn.Name = "CmimiPDataGridViewTextBoxColumn"
        '
        'SasiaPDataGridViewTextBoxColumn
        '
        Me.SasiaPDataGridViewTextBoxColumn.DataPropertyName = "SasiaP"
        Me.SasiaPDataGridViewTextBoxColumn.HeaderText = "SasiaP"
        Me.SasiaPDataGridViewTextBoxColumn.Name = "SasiaPDataGridViewTextBoxColumn"
        '
        'RuajProduktin_b
        '
        Me.RuajProduktin_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuajProduktin_b.Image = Global.StarBar.My.Resources.Resources.Save_as_icon
        Me.RuajProduktin_b.Location = New System.Drawing.Point(143, 328)
        Me.RuajProduktin_b.Name = "RuajProduktin_b"
        Me.RuajProduktin_b.Size = New System.Drawing.Size(177, 48)
        Me.RuajProduktin_b.TabIndex = 1
        Me.RuajProduktin_b.Text = "Ruaj Produktet"
        Me.RuajProduktin_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RuajProduktin_b.UseVisualStyleBackColor = True
        '
        'NdryshoProduktin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 388)
        Me.Controls.Add(Me.RuajProduktin_b)
        Me.Controls.Add(Me.TabelProdukte)
        Me.MaximumSize = New System.Drawing.Size(500, 427)
        Me.MinimumSize = New System.Drawing.Size(500, 427)
        Me.Name = "NdryshoProduktin"
        Me.Text = "NdryshoProduktin"
        CType(Me.TabelProdukte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarBarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabelProdukte As System.Windows.Forms.DataGridView
    Friend WithEvents StarBarDataSet1 As StarBar.StarBarDataSet1
    Friend WithEvents ProdukteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdukteTableAdapter As StarBar.StarBarDataSet1TableAdapters.ProdukteTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmriPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmimiPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SasiaPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RuajProduktin_b As System.Windows.Forms.Button
End Class
