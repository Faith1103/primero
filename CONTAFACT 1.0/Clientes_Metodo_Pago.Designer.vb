<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Metodo_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes_Metodo_Pago))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CatclientesmetodoformapagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contafact_newDataSet1 = New CONTAFACT_1._0.contafact_newDataSet1()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_razon = New System.Windows.Forms.TextBox()
        Me.Cat_clientes_metodo_forma_pagoTableAdapter = New CONTAFACT_1._0.contafact_newDataSet1TableAdapters.cat_clientes_metodo_forma_pagoTableAdapter()
        Me.CmetnumdetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmettipomonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CmetformapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CmetmetodopagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CmetnumcuentapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmetdefaulttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatclientesmetodoformapagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contafact_newDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CmetnumdetalleDataGridViewTextBoxColumn, Me.CmettipomonedaDataGridViewTextBoxColumn, Me.CmetformapagoDataGridViewTextBoxColumn, Me.CmetmetodopagoDataGridViewTextBoxColumn, Me.CmetnumcuentapagoDataGridViewTextBoxColumn, Me.CmetdefaulttDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CatclientesmetodoformapagoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 202)
        Me.DataGridView1.TabIndex = 0
        '
        'CatclientesmetodoformapagoBindingSource
        '
        Me.CatclientesmetodoformapagoBindingSource.DataMember = "cat_clientes_metodo_forma_pago"
        Me.CatclientesmetodoformapagoBindingSource.DataSource = Me.Contafact_newDataSet1
        '
        'Contafact_newDataSet1
        '
        Me.Contafact_newDataSet1.DataSetName = "contafact_newDataSet1"
        Me.Contafact_newDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Navy
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(678, 48)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(78, 65)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Navy
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar.Location = New System.Drawing.Point(678, 135)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(78, 63)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_cliente.Enabled = False
        Me.txt_cliente.Location = New System.Drawing.Point(75, 4)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_cliente.TabIndex = 4
        '
        'txt_razon
        '
        Me.txt_razon.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_razon.Enabled = False
        Me.txt_razon.Location = New System.Drawing.Point(181, 4)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(451, 20)
        Me.txt_razon.TabIndex = 5
        '
        'Cat_clientes_metodo_forma_pagoTableAdapter
        '
        Me.Cat_clientes_metodo_forma_pagoTableAdapter.ClearBeforeFill = True
        '
        'CmetnumdetalleDataGridViewTextBoxColumn
        '
        Me.CmetnumdetalleDataGridViewTextBoxColumn.DataPropertyName = "cmet_num_detalle"
        Me.CmetnumdetalleDataGridViewTextBoxColumn.HeaderText = "Num Detalle"
        Me.CmetnumdetalleDataGridViewTextBoxColumn.Name = "CmetnumdetalleDataGridViewTextBoxColumn"
        '
        'CmettipomonedaDataGridViewTextBoxColumn
        '
        Me.CmettipomonedaDataGridViewTextBoxColumn.DataPropertyName = "cmet_tipo_moneda"
        Me.CmettipomonedaDataGridViewTextBoxColumn.HeaderText = "Tipo Moneda"
        Me.CmettipomonedaDataGridViewTextBoxColumn.Name = "CmettipomonedaDataGridViewTextBoxColumn"
        Me.CmettipomonedaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CmettipomonedaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CmetformapagoDataGridViewTextBoxColumn
        '
        Me.CmetformapagoDataGridViewTextBoxColumn.DataPropertyName = "cmet_forma_pago"
        Me.CmetformapagoDataGridViewTextBoxColumn.HeaderText = "Forma Pago"
        Me.CmetformapagoDataGridViewTextBoxColumn.Name = "CmetformapagoDataGridViewTextBoxColumn"
        Me.CmetformapagoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CmetformapagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CmetmetodopagoDataGridViewTextBoxColumn
        '
        Me.CmetmetodopagoDataGridViewTextBoxColumn.DataPropertyName = "cmet_metodo_pago"
        Me.CmetmetodopagoDataGridViewTextBoxColumn.HeaderText = "Metodo Pago"
        Me.CmetmetodopagoDataGridViewTextBoxColumn.Name = "CmetmetodopagoDataGridViewTextBoxColumn"
        Me.CmetmetodopagoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CmetmetodopagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CmetnumcuentapagoDataGridViewTextBoxColumn
        '
        Me.CmetnumcuentapagoDataGridViewTextBoxColumn.DataPropertyName = "cmet_num_cuenta_pago"
        Me.CmetnumcuentapagoDataGridViewTextBoxColumn.HeaderText = "Num Cuenta"
        Me.CmetnumcuentapagoDataGridViewTextBoxColumn.Name = "CmetnumcuentapagoDataGridViewTextBoxColumn"
        '
        'CmetdefaulttDataGridViewTextBoxColumn
        '
        Me.CmetdefaulttDataGridViewTextBoxColumn.DataPropertyName = "cmet_defaultt"
        Me.CmetdefaulttDataGridViewTextBoxColumn.HeaderText = "Default"
        Me.CmetdefaulttDataGridViewTextBoxColumn.Name = "CmetdefaulttDataGridViewTextBoxColumn"
        Me.CmetdefaulttDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CmetdefaulttDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Clientes_Metodo_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(758, 262)
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Clientes_Metodo_Pago"
        Me.Text = "Clientes Metodo Pago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatclientesmetodoformapagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contafact_newDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
    Friend WithEvents Contafact_newDataSet1 As CONTAFACT_1._0.contafact_newDataSet1
    Friend WithEvents CatclientesmetodoformapagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_clientes_metodo_forma_pagoTableAdapter As CONTAFACT_1._0.contafact_newDataSet1TableAdapters.cat_clientes_metodo_forma_pagoTableAdapter
    Friend WithEvents CmetnumdetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmettipomonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CmetformapagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CmetmetodopagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CmetnumcuentapagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmetdefaulttDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
