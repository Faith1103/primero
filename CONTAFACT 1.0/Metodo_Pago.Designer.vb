<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metodo_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Metodo_Pago))
        Me.dgv_metodo_pago = New System.Windows.Forms.DataGridView()
        Me.IdmetodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetododescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatmetodopagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)

                Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_elimina = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        CType(Me.dgv_metodo_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatmetodopagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'dgv_metodo_pago
        '
        Me.dgv_metodo_pago.AutoGenerateColumns = False
        Me.dgv_metodo_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_metodo_pago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmetodoDataGridViewTextBoxColumn, Me.MetododescripcionDataGridViewTextBoxColumn})
        Me.dgv_metodo_pago.DataSource = Me.CatmetodopagoBindingSource
        Me.dgv_metodo_pago.Location = New System.Drawing.Point(12, 14)
        Me.dgv_metodo_pago.Name = "dgv_metodo_pago"
        Me.dgv_metodo_pago.Size = New System.Drawing.Size(565, 162)
        Me.dgv_metodo_pago.TabIndex = 0
        '
        'IdmetodoDataGridViewTextBoxColumn
        '
        Me.IdmetodoDataGridViewTextBoxColumn.DataPropertyName = "id_metodo"
        Me.IdmetodoDataGridViewTextBoxColumn.HeaderText = "id_metodo"
        Me.IdmetodoDataGridViewTextBoxColumn.Name = "IdmetodoDataGridViewTextBoxColumn"
        '
        'MetododescripcionDataGridViewTextBoxColumn
        '
        Me.MetododescripcionDataGridViewTextBoxColumn.DataPropertyName = "metodo_descripcion"
        Me.MetododescripcionDataGridViewTextBoxColumn.HeaderText = "metodo_descripcion"
        Me.MetododescripcionDataGridViewTextBoxColumn.Name = "MetododescripcionDataGridViewTextBoxColumn"
        Me.MetododescripcionDataGridViewTextBoxColumn.Width = 400
        '
        'CatmetodopagoBindingSource
        '
        Me.CatmetodopagoBindingSource.DataMember = "cat_metodo_pago"

        '
        'Contafact_newDataSet2
        '
              '
        'Cat_metodo_pagoTableAdapter
        '

        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Navy
        Me.btn_nuevo.BackgroundImage = CType(resources.GetObject("btn_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Location = New System.Drawing.Point(605, 24)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 66)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_elimina
        '
        Me.btn_elimina.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_elimina.BackgroundImage = CType(resources.GetObject("btn_elimina.BackgroundImage"), System.Drawing.Image)
        Me.btn_elimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_elimina.Location = New System.Drawing.Point(605, 108)
        Me.btn_elimina.Name = "btn_elimina"
        Me.btn_elimina.Size = New System.Drawing.Size(80, 66)
        Me.btn_elimina.TabIndex = 2
        Me.btn_elimina.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Navy
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(254, 213)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(160, 48)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Metodo_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(716, 273)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_elimina)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.dgv_metodo_pago)
        Me.Name = "Metodo_Pago"
        Me.Text = "Metodo Pago"
        CType(Me.dgv_metodo_pago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatmetodopagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_metodo_pago As System.Windows.Forms.DataGridView

    Friend WithEvents CatmetodopagoBindingSource As System.Windows.Forms.BindingSource
       Friend WithEvents IdmetodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetododescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_elimina As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button

     
End Class
