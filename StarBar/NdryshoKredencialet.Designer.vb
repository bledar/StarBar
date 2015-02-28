<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NdryshoKredencialet
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
        Me.UserTabela = New System.Windows.Forms.DataGridView()
        Me.StarBarDataSet = New StarBar.StarBarDataSet()
        Me.PerdoruesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerdoruesTableAdapter = New StarBar.StarBarDataSetTableAdapters.PerdoruesTableAdapter()
        Me.Ruaje_Ndryshime_user_b = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiveliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UserTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarBarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerdoruesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserTabela
        '
        Me.UserTabela.AllowUserToAddRows = False
        Me.UserTabela.AllowUserToDeleteRows = False
        Me.UserTabela.AutoGenerateColumns = False
        Me.UserTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserTabela.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EmriDataGridViewTextBoxColumn, Me.KodiDataGridViewTextBoxColumn, Me.NiveliDataGridViewTextBoxColumn})
        Me.UserTabela.DataSource = Me.PerdoruesBindingSource
        Me.UserTabela.Location = New System.Drawing.Point(10, 10)
        Me.UserTabela.Name = "UserTabela"
        Me.UserTabela.Size = New System.Drawing.Size(461, 300)
        Me.UserTabela.TabIndex = 0
        '
        'StarBarDataSet
        '
        Me.StarBarDataSet.DataSetName = "StarBarDataSet"
        Me.StarBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PerdoruesBindingSource
        '
        Me.PerdoruesBindingSource.DataMember = "Perdorues"
        Me.PerdoruesBindingSource.DataSource = Me.StarBarDataSet
        '
        'PerdoruesTableAdapter
        '
        Me.PerdoruesTableAdapter.ClearBeforeFill = True
        '
        'Ruaje_Ndryshime_user_b
        '
        Me.Ruaje_Ndryshime_user_b.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Ruaje_Ndryshime_user_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ruaje_Ndryshime_user_b.Image = Global.StarBar.My.Resources.Resources.Save_as_icon
        Me.Ruaje_Ndryshime_user_b.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ruaje_Ndryshime_user_b.Location = New System.Drawing.Point(107, 316)
        Me.Ruaje_Ndryshime_user_b.Name = "Ruaje_Ndryshime_user_b"
        Me.Ruaje_Ndryshime_user_b.Size = New System.Drawing.Size(236, 56)
        Me.Ruaje_Ndryshime_user_b.TabIndex = 1
        Me.Ruaje_Ndryshime_user_b.Text = "RUAJ NDRYSHIMET"
        Me.Ruaje_Ndryshime_user_b.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ruaje_Ndryshime_user_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ruaje_Ndryshime_user_b.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmriDataGridViewTextBoxColumn
        '
        Me.EmriDataGridViewTextBoxColumn.DataPropertyName = "Emri"
        Me.EmriDataGridViewTextBoxColumn.HeaderText = "Emri"
        Me.EmriDataGridViewTextBoxColumn.Name = "EmriDataGridViewTextBoxColumn"
        '
        'KodiDataGridViewTextBoxColumn
        '
        Me.KodiDataGridViewTextBoxColumn.DataPropertyName = "Kodi"
        Me.KodiDataGridViewTextBoxColumn.HeaderText = "Kodi"
        Me.KodiDataGridViewTextBoxColumn.Name = "KodiDataGridViewTextBoxColumn"
        '
        'NiveliDataGridViewTextBoxColumn
        '
        Me.NiveliDataGridViewTextBoxColumn.DataPropertyName = "Niveli"
        Me.NiveliDataGridViewTextBoxColumn.HeaderText = "Administrator(1)"
        Me.NiveliDataGridViewTextBoxColumn.Name = "NiveliDataGridViewTextBoxColumn"
        Me.NiveliDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'NdryshoKredencialet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(484, 388)
        Me.Controls.Add(Me.Ruaje_Ndryshime_user_b)
        Me.Controls.Add(Me.UserTabela)
        Me.Name = "NdryshoKredencialet"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NdryshoKredencialet"
        CType(Me.UserTabela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarBarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerdoruesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserTabela As System.Windows.Forms.DataGridView
    Friend WithEvents StarBarDataSet As StarBar.StarBarDataSet
    Friend WithEvents PerdoruesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PerdoruesTableAdapter As StarBar.StarBarDataSetTableAdapters.PerdoruesTableAdapter
    Friend WithEvents Ruaje_Ndryshime_user_b As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiveliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
