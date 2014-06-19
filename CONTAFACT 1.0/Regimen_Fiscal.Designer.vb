<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regimen_Fiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Regimen_Fiscal))
        Me.dgv_regimen_fiscal = New System.Windows.Forms.DataGridView()
        Me.IdregimenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionregimenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatregimenfiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_regimen_fiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatregimenfiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'dgv_regimen_fiscal
        '
        Me.dgv_regimen_fiscal.AutoGenerateColumns = False
        Me.dgv_regimen_fiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_regimen_fiscal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdregimenDataGridViewTextBoxColumn, Me.DescripcionregimenDataGridViewTextBoxColumn})
        Me.dgv_regimen_fiscal.DataSource = Me.CatregimenfiscalBindingSource
        Me.dgv_regimen_fiscal.Location = New System.Drawing.Point(12, 31)
        Me.dgv_regimen_fiscal.Name = "dgv_regimen_fiscal"
        Me.dgv_regimen_fiscal.Size = New System.Drawing.Size(546, 150)
        Me.dgv_regimen_fiscal.TabIndex = 0
        '
        'IdregimenDataGridViewTextBoxColumn
        '
        Me.IdregimenDataGridViewTextBoxColumn.DataPropertyName = "id_regimen"
        Me.IdregimenDataGridViewTextBoxColumn.HeaderText = "id_regimen"
        Me.IdregimenDataGridViewTextBoxColumn.Name = "IdregimenDataGridViewTextBoxColumn"
        '
        'DescripcionregimenDataGridViewTextBoxColumn
        '
        Me.DescripcionregimenDataGridViewTextBoxColumn.DataPropertyName = "descripcion_regimen"
        Me.DescripcionregimenDataGridViewTextBoxColumn.HeaderText = "descripcion_regimen"
        Me.DescripcionregimenDataGridViewTextBoxColumn.Name = "DescripcionregimenDataGridViewTextBoxColumn"
        Me.DescripcionregimenDataGridViewTextBoxColumn.Width = 400
        '
        'CatregimenfiscalBindingSource
        '
        Me.CatregimenfiscalBindingSource.DataMember = "cat_regimen_fiscal"

        '
        'Contafact_newDataSet4
        '
                '
        'Cat_regimen_fiscalTableAdapter
        '

        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Navy
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(589, 31)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 67)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Navy
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar.Location = New System.Drawing.Point(589, 114)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 67)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Regimen_Fiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(687, 226)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_regimen_fiscal)
        Me.Name = "Regimen_Fiscal"
        Me.Text = "Regimen Fiscal"
        CType(Me.dgv_regimen_fiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatregimenfiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_regimen_fiscal As System.Windows.Forms.DataGridView
    Friend WithEvents CatregimenfiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdregimenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionregimenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
End Class
