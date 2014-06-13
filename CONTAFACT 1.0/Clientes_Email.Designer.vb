<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Email
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes_Email))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.txt_razon = New System.Windows.Forms.TextBox()
        Me.rb_leyenda_decision = New System.Windows.Forms.RadioButton()
        Me.rb_leyenda_espefica = New System.Windows.Forms.RadioButton()
        Me.txt_leyenda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_correos = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'txt_idcliente
        '
        Me.txt_idcliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_idcliente.Enabled = False
        Me.txt_idcliente.Location = New System.Drawing.Point(82, 11)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(116, 20)
        Me.txt_idcliente.TabIndex = 1
        '
        'txt_razon
        '
        Me.txt_razon.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_razon.Enabled = False
        Me.txt_razon.Location = New System.Drawing.Point(206, 10)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(707, 20)
        Me.txt_razon.TabIndex = 2
        '
        'rb_leyenda_decision
        '
        Me.rb_leyenda_decision.AutoSize = True
        Me.rb_leyenda_decision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_leyenda_decision.Location = New System.Drawing.Point(17, 58)
        Me.rb_leyenda_decision.Name = "rb_leyenda_decision"
        Me.rb_leyenda_decision.Size = New System.Drawing.Size(118, 17)
        Me.rb_leyenda_decision.TabIndex = 1
        Me.rb_leyenda_decision.TabStop = True
        Me.rb_leyenda_decision.Text = "Leyenda Default"
        Me.rb_leyenda_decision.UseVisualStyleBackColor = True
        '
        'rb_leyenda_espefica
        '
        Me.rb_leyenda_espefica.AutoSize = True
        Me.rb_leyenda_espefica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_leyenda_espefica.Location = New System.Drawing.Point(17, 82)
        Me.rb_leyenda_espefica.Name = "rb_leyenda_espefica"
        Me.rb_leyenda_espefica.Size = New System.Drawing.Size(101, 17)
        Me.rb_leyenda_espefica.TabIndex = 2
        Me.rb_leyenda_espefica.TabStop = True
        Me.rb_leyenda_espefica.Text = "Otra Leyenda"
        Me.rb_leyenda_espefica.UseVisualStyleBackColor = True
        '
        'txt_leyenda
        '
        Me.txt_leyenda.Location = New System.Drawing.Point(17, 106)
        Me.txt_leyenda.Multiline = True
        Me.txt_leyenda.Name = "txt_leyenda"
        Me.txt_leyenda.Size = New System.Drawing.Size(896, 37)
        Me.txt_leyenda.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(417, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Clientes (Separado por ; ejemplo ejemplo1@xxx.com,ejemplo2@xxx.com)"
        '
        'txt_correos
        '
        Me.txt_correos.Location = New System.Drawing.Point(21, 189)
        Me.txt_correos.Multiline = True
        Me.txt_correos.Name = "txt_correos"
        Me.txt_correos.Size = New System.Drawing.Size(893, 88)
        Me.txt_correos.TabIndex = 4
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(330, 290)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(203, 45)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Clientes_Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(929, 347)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_correos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_leyenda)
        Me.Controls.Add(Me.rb_leyenda_espefica)
        Me.Controls.Add(Me.rb_leyenda_decision)
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.txt_idcliente)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Clientes_Email"
        Me.Text = "Clientes_Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_idcliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
    Friend WithEvents rb_leyenda_decision As System.Windows.Forms.RadioButton
    Friend WithEvents rb_leyenda_espefica As System.Windows.Forms.RadioButton
    Friend WithEvents txt_leyenda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_correos As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
