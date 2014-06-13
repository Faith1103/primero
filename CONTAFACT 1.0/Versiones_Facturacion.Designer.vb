<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Versiones_Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Versiones_Facturacion))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Contafact_newDataSet6 = New CONTAFACT_1._0.contafact_newDataSet6()
        Me.CatversionfacturacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_version_facturacionTableAdapter = New CONTAFACT_1._0.contafact_newDataSet6TableAdapters.cat_version_facturacionTableAdapter()
        Me.IdversionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsquemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contafact_newDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatversionfacturacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdversionDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn, Me.EsquemaDataGridViewTextBoxColumn, Me.FechainicialDataGridViewTextBoxColumn, Me.FechafinalDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CatversionfacturacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(594, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Contafact_newDataSet6
        '
        Me.Contafact_newDataSet6.DataSetName = "contafact_newDataSet6"
        Me.Contafact_newDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatversionfacturacionBindingSource
        '
        Me.CatversionfacturacionBindingSource.DataMember = "cat_version_facturacion"
        Me.CatversionfacturacionBindingSource.DataSource = Me.Contafact_newDataSet6
        '
        'Cat_version_facturacionTableAdapter
        '
        Me.Cat_version_facturacionTableAdapter.ClearBeforeFill = True
        '
        'IdversionDataGridViewTextBoxColumn
        '
        Me.IdversionDataGridViewTextBoxColumn.DataPropertyName = "id_version"
        Me.IdversionDataGridViewTextBoxColumn.HeaderText = "# Version"
        Me.IdversionDataGridViewTextBoxColumn.Name = "IdversionDataGridViewTextBoxColumn"
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "version"
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "Version"
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        '
        'EsquemaDataGridViewTextBoxColumn
        '
        Me.EsquemaDataGridViewTextBoxColumn.DataPropertyName = "esquema"
        Me.EsquemaDataGridViewTextBoxColumn.HeaderText = "Esquema"
        Me.EsquemaDataGridViewTextBoxColumn.Name = "EsquemaDataGridViewTextBoxColumn"
        '
        'FechainicialDataGridViewTextBoxColumn
        '
        Me.FechainicialDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicial"
        Me.FechainicialDataGridViewTextBoxColumn.HeaderText = "Fecha Inicial"
        Me.FechainicialDataGridViewTextBoxColumn.Name = "FechainicialDataGridViewTextBoxColumn"
        '
        'FechafinalDataGridViewTextBoxColumn
        '
        Me.FechafinalDataGridViewTextBoxColumn.DataPropertyName = "fecha_final"
        Me.FechafinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final"
        Me.FechafinalDataGridViewTextBoxColumn.Name = "FechafinalDataGridViewTextBoxColumn"
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "activo"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = ""
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        Me.ActivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ActivoDataGridViewTextBoxColumn.Width = 20
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Navy
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(632, 26)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(77, 60)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Navy
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar.Location = New System.Drawing.Point(632, 116)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(77, 60)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
=======
        Me.SuspendLayout()
        '
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
        'Versiones_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(726, 206)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Versiones_Facturacion"
        Me.Text = "Versiones Facturacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contafact_newDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatversionfacturacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Contafact_newDataSet6 As CONTAFACT_1._0.contafact_newDataSet6
    Friend WithEvents CatversionfacturacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_version_facturacionTableAdapter As CONTAFACT_1._0.contafact_newDataSet6TableAdapters.cat_version_facturacionTableAdapter
    Friend WithEvents IdversionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsquemaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
=======
        Me.ClientSize = New System.Drawing.Size(765, 554)
        Me.Name = "Versiones_Facturacion"
        Me.Text = "Versiones_Facturacion"
        Me.ResumeLayout(False)

    End Sub
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
End Class
