<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_Modif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario_Modif))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fecha_reg = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora_reg = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario_reg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_usuario_modif = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_hora_modif = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_modif = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(449, 299)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(11, 12)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(424, 232)
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Navy
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(260, 252)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(176, 44)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos de Registro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora:"
        '
        'txt_fecha_reg
        '
        Me.txt_fecha_reg.Location = New System.Drawing.Point(87, 60)
        Me.txt_fecha_reg.Mask = "00/00/0000"
        Me.txt_fecha_reg.Name = "txt_fecha_reg"
        Me.txt_fecha_reg.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_reg.TabIndex = 5
        Me.txt_fecha_reg.ValidatingType = GetType(Date)
        '
        'txt_hora_reg
        '
        Me.txt_hora_reg.Location = New System.Drawing.Point(311, 52)
        Me.txt_hora_reg.Mask = "00:00"
        Me.txt_hora_reg.Name = "txt_hora_reg"
        Me.txt_hora_reg.Size = New System.Drawing.Size(100, 20)
        Me.txt_hora_reg.TabIndex = 6
        Me.txt_hora_reg.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario:"
        '
        'txt_usuario_reg
        '
        Me.txt_usuario_reg.Location = New System.Drawing.Point(87, 99)
        Me.txt_usuario_reg.Name = "txt_usuario_reg"
        Me.txt_usuario_reg.Size = New System.Drawing.Size(324, 20)
        Me.txt_usuario_reg.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Datos Ultima Modificacion"
        '
        'txt_usuario_modif
        '
        Me.txt_usuario_modif.Location = New System.Drawing.Point(91, 190)
        Me.txt_usuario_modif.Name = "txt_usuario_modif"
        Me.txt_usuario_modif.Size = New System.Drawing.Size(324, 20)
        Me.txt_usuario_modif.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Usuario:"
        '
        'txt_hora_modif
        '
        Me.txt_hora_modif.Location = New System.Drawing.Point(315, 143)
        Me.txt_hora_modif.Mask = "00:00"
        Me.txt_hora_modif.Name = "txt_hora_modif"
        Me.txt_hora_modif.Size = New System.Drawing.Size(100, 20)
        Me.txt_hora_modif.TabIndex = 13
        Me.txt_hora_modif.ValidatingType = GetType(Date)
        '
        'txt_fecha_modif
        '
        Me.txt_fecha_modif.Location = New System.Drawing.Point(91, 151)
        Me.txt_fecha_modif.Mask = "00/00/0000"
        Me.txt_fecha_modif.Name = "txt_fecha_modif"
        Me.txt_fecha_modif.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_modif.TabIndex = 12
        Me.txt_fecha_modif.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Hora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha:"
        '
        'Usuario_Modif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(449, 299)
        Me.Controls.Add(Me.txt_usuario_modif)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_hora_modif)
        Me.Controls.Add(Me.txt_fecha_modif)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_usuario_reg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_hora_reg)
        Me.Controls.Add(Me.txt_fecha_reg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Usuario_Modif"
        Me.Text = "REGISTRO Y ULTIMA MODIFICACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_reg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_hora_reg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_modif As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_hora_modif As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_modif As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
