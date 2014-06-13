<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Grid
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CteidclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CteRFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CteRAZONSOCIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contafact_newDataSet = New CONTAFACT_1._0.contafact_newDataSet()
        Me.Cat_clienteTableAdapter = New CONTAFACT_1._0.contafact_newDataSetTableAdapters.cat_clienteTableAdapter()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_rfc = New System.Windows.Forms.TextBox()
        Me.txt_razon = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contafact_newDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CteidclienteDataGridViewTextBoxColumn, Me.CteRFCDataGridViewTextBoxColumn, Me.CteRAZONSOCIALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CatclienteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(747, 496)
        Me.DataGridView1.TabIndex = 0
        '
        'CteidclienteDataGridViewTextBoxColumn
        '
        Me.CteidclienteDataGridViewTextBoxColumn.DataPropertyName = "cte_id_cliente"
        Me.CteidclienteDataGridViewTextBoxColumn.HeaderText = "cte_id_cliente"
        Me.CteidclienteDataGridViewTextBoxColumn.Name = "CteidclienteDataGridViewTextBoxColumn"
        '
        'CteRFCDataGridViewTextBoxColumn
        '
        Me.CteRFCDataGridViewTextBoxColumn.DataPropertyName = "cte_RFC"
        Me.CteRFCDataGridViewTextBoxColumn.HeaderText = "cte_RFC"
        Me.CteRFCDataGridViewTextBoxColumn.Name = "CteRFCDataGridViewTextBoxColumn"
        '
        'CteRAZONSOCIALDataGridViewTextBoxColumn
        '
        Me.CteRAZONSOCIALDataGridViewTextBoxColumn.DataPropertyName = "cte_RAZON_SOCIAL"
        Me.CteRAZONSOCIALDataGridViewTextBoxColumn.HeaderText = "cte_RAZON_SOCIAL"
        Me.CteRAZONSOCIALDataGridViewTextBoxColumn.Name = "CteRAZONSOCIALDataGridViewTextBoxColumn"
        Me.CteRAZONSOCIALDataGridViewTextBoxColumn.Width = 500
        '
        'CatclienteBindingSource
        '
        Me.CatclienteBindingSource.DataMember = "cat_cliente"
        Me.CatclienteBindingSource.DataSource = Me.Contafact_newDataSet
        '
        'Contafact_newDataSet
        '
        Me.Contafact_newDataSet.DataSetName = "contafact_newDataSet"
        Me.Contafact_newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cat_clienteTableAdapter
        '
        Me.Cat_clienteTableAdapter.ClearBeforeFill = True
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(63, 20)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_cliente.TabIndex = 1
        '
        'txt_rfc
        '
        Me.txt_rfc.Location = New System.Drawing.Point(167, 20)
        Me.txt_rfc.Name = "txt_rfc"
        Me.txt_rfc.Size = New System.Drawing.Size(92, 20)
        Me.txt_rfc.TabIndex = 2
        '
        'txt_razon
        '
        Me.txt_razon.Location = New System.Drawing.Point(265, 20)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(504, 20)
        Me.txt_razon.TabIndex = 3
        '
        'Clientes_Grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(792, 554)
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.txt_rfc)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Clientes_Grid"
        Me.Text = "Listado Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contafact_newDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Contafact_newDataSet As CONTAFACT_1._0.contafact_newDataSet
    Friend WithEvents CatclienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_clienteTableAdapter As CONTAFACT_1._0.contafact_newDataSetTableAdapters.cat_clienteTableAdapter
    Friend WithEvents CteidclienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CteRFCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CteRAZONSOCIALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_rfc As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
End Class
