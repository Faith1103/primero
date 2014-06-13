<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forma_pago
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forma_pago))
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Contafact_newDataSet3 = New CONTAFACT_1._0.contafact_newDataSet3()
        Me.CatformapagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_forma_pagoTableAdapter = New CONTAFACT_1._0.contafact_newDataSet3TableAdapters.cat_forma_pagoTableAdapter()
        Me.IdformaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contafact_newDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatformapagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Navy
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(576, 18)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 68)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Navy
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar.Location = New System.Drawing.Point(576, 92)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 70)
        Me.btn_eliminar.TabIndex = 1
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdformaDataGridViewTextBoxColumn, Me.FormapagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CatformapagoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Contafact_newDataSet3
        '
        Me.Contafact_newDataSet3.DataSetName = "contafact_newDataSet3"
        Me.Contafact_newDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatformapagoBindingSource
        '
        Me.CatformapagoBindingSource.DataMember = "cat_forma_pago"
        Me.CatformapagoBindingSource.DataSource = Me.Contafact_newDataSet3
        '
        'Cat_forma_pagoTableAdapter
        '
        Me.Cat_forma_pagoTableAdapter.ClearBeforeFill = True
        '
        'IdformaDataGridViewTextBoxColumn
        '
        Me.IdformaDataGridViewTextBoxColumn.DataPropertyName = "id_forma"
        Me.IdformaDataGridViewTextBoxColumn.HeaderText = "id_forma"
        Me.IdformaDataGridViewTextBoxColumn.Name = "IdformaDataGridViewTextBoxColumn"
        '
        'FormapagoDataGridViewTextBoxColumn
        '
        Me.FormapagoDataGridViewTextBoxColumn.DataPropertyName = "forma_pago"
        Me.FormapagoDataGridViewTextBoxColumn.HeaderText = "forma_pago"
        Me.FormapagoDataGridViewTextBoxColumn.Name = "FormapagoDataGridViewTextBoxColumn"
        Me.FormapagoDataGridViewTextBoxColumn.Width = 400
        '
        'Forma_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(678, 179)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Name = "Forma_pago"
        Me.Text = "Forma Pago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contafact_newDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatformapagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Contafact_newDataSet3 As CONTAFACT_1._0.contafact_newDataSet3
    Friend WithEvents CatformapagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_forma_pagoTableAdapter As CONTAFACT_1._0.contafact_newDataSet3TableAdapters.cat_forma_pagoTableAdapter
    Friend WithEvents IdformaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormapagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
