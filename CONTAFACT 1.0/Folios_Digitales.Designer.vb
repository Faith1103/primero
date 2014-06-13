<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Folios_Digitales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
<<<<<<< HEAD
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Folios_Digitales))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Contafact_newDataSet5 = New CONTAFACT_1._0.contafact_newDataSet5()
        Me.CatfoliosdigitalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_folios_digitalesTableAdapter = New CONTAFACT_1._0.contafact_newDataSet5TableAdapters.cat_folios_digitalesTableAdapter()
        Me.IdserieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeffaultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioinicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoliofinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsecutivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoaprobacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioaprobacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contafact_newDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatfoliosdigitalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdserieDataGridViewTextBoxColumn, Me.DeffaultDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.FolioinicialDataGridViewTextBoxColumn, Me.FoliofinalDataGridViewTextBoxColumn, Me.ConsecutivoDataGridViewTextBoxColumn, Me.NoaprobacionDataGridViewTextBoxColumn, Me.AnioaprobacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CatfoliosdigitalesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(734, 151)
        Me.DataGridView1.TabIndex = 0
        '
        'Contafact_newDataSet5
        '
        Me.Contafact_newDataSet5.DataSetName = "contafact_newDataSet5"
        Me.Contafact_newDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatfoliosdigitalesBindingSource
        '
        Me.CatfoliosdigitalesBindingSource.DataMember = "cat_folios_digitales"
        Me.CatfoliosdigitalesBindingSource.DataSource = Me.Contafact_newDataSet5
        '
        'Cat_folios_digitalesTableAdapter
        '
        Me.Cat_folios_digitalesTableAdapter.ClearBeforeFill = True
        '
        'IdserieDataGridViewTextBoxColumn
        '
        Me.IdserieDataGridViewTextBoxColumn.DataPropertyName = "id_serie"
        Me.IdserieDataGridViewTextBoxColumn.HeaderText = "# Serie"
        Me.IdserieDataGridViewTextBoxColumn.Name = "IdserieDataGridViewTextBoxColumn"
        Me.IdserieDataGridViewTextBoxColumn.Width = 50
        '
        'DeffaultDataGridViewTextBoxColumn
        '
        Me.DeffaultDataGridViewTextBoxColumn.DataPropertyName = "deffault"
        Me.DeffaultDataGridViewTextBoxColumn.HeaderText = ""
        Me.DeffaultDataGridViewTextBoxColumn.Name = "DeffaultDataGridViewTextBoxColumn"
        Me.DeffaultDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeffaultDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeffaultDataGridViewTextBoxColumn.Width = 20
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        '
        'FolioinicialDataGridViewTextBoxColumn
        '
        Me.FolioinicialDataGridViewTextBoxColumn.DataPropertyName = "folio_inicial"
        Me.FolioinicialDataGridViewTextBoxColumn.HeaderText = "Folio Ini"
        Me.FolioinicialDataGridViewTextBoxColumn.Name = "FolioinicialDataGridViewTextBoxColumn"
        '
        'FoliofinalDataGridViewTextBoxColumn
        '
        Me.FoliofinalDataGridViewTextBoxColumn.DataPropertyName = "folio_final"
        Me.FoliofinalDataGridViewTextBoxColumn.HeaderText = "Folio Fin"
        Me.FoliofinalDataGridViewTextBoxColumn.Name = "FoliofinalDataGridViewTextBoxColumn"
        '
        'ConsecutivoDataGridViewTextBoxColumn
        '
        Me.ConsecutivoDataGridViewTextBoxColumn.DataPropertyName = "consecutivo"
        Me.ConsecutivoDataGridViewTextBoxColumn.HeaderText = "Consecutivo"
        Me.ConsecutivoDataGridViewTextBoxColumn.Name = "ConsecutivoDataGridViewTextBoxColumn"
        '
        'NoaprobacionDataGridViewTextBoxColumn
        '
        Me.NoaprobacionDataGridViewTextBoxColumn.DataPropertyName = "no_aprobacion"
        Me.NoaprobacionDataGridViewTextBoxColumn.HeaderText = "No Aprobacion"
        Me.NoaprobacionDataGridViewTextBoxColumn.Name = "NoaprobacionDataGridViewTextBoxColumn"
        '
        'AnioaprobacionDataGridViewTextBoxColumn
        '
        Me.AnioaprobacionDataGridViewTextBoxColumn.DataPropertyName = "anio_aprobacion"
        Me.AnioaprobacionDataGridViewTextBoxColumn.HeaderText = "Año Aprovacion"
        Me.AnioaprobacionDataGridViewTextBoxColumn.Name = "AnioaprobacionDataGridViewTextBoxColumn"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Navy
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(752, 25)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 64)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Navy
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar.Location = New System.Drawing.Point(752, 106)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 70)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
=======
        Me.SuspendLayout()
        '
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
        'Folios_Digitales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(835, 225)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Folios_Digitales"
        Me.Text = "Folios_Digitales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contafact_newDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatfoliosdigitalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Contafact_newDataSet5 As CONTAFACT_1._0.contafact_newDataSet5
    Friend WithEvents CatfoliosdigitalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_folios_digitalesTableAdapter As CONTAFACT_1._0.contafact_newDataSet5TableAdapters.cat_folios_digitalesTableAdapter
    Friend WithEvents IdserieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeffaultDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioinicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoliofinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsecutivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoaprobacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnioaprobacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
=======
        Me.ClientSize = New System.Drawing.Size(776, 546)
        Me.Name = "Folios_Digitales"
        Me.Text = "Folios_Digitales"
        Me.ResumeLayout(False)

    End Sub
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
End Class
