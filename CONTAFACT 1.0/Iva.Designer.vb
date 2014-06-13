<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iva))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_usuario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipo_iva = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_porcentaje = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(659, 303)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(25, 24)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(527, 178)
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Navy
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(375, 242)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(178, 49)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_usuario
        '
        Me.btn_usuario.BackColor = System.Drawing.Color.Navy
        Me.btn_usuario.BackgroundImage = CType(resources.GetObject("btn_usuario.BackgroundImage"), System.Drawing.Image)
        Me.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_usuario.Location = New System.Drawing.Point(570, 24)
        Me.btn_usuario.Name = "btn_usuario"
        Me.btn_usuario.Size = New System.Drawing.Size(77, 49)
        Me.btn_usuario.TabIndex = 2
        Me.btn_usuario.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo De IVA:"
        '
        'cmb_tipo_iva
        '
        Me.cmb_tipo_iva.FormattingEnabled = True
        Me.cmb_tipo_iva.Location = New System.Drawing.Point(148, 46)
        Me.cmb_tipo_iva.Name = "cmb_tipo_iva"
        Me.cmb_tipo_iva.Size = New System.Drawing.Size(328, 21)
        Me.cmb_tipo_iva.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Porcentaje:"
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.Location = New System.Drawing.Point(148, 81)
        Me.txt_porcentaje.Mask = "99999"
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.Size = New System.Drawing.Size(100, 20)
        Me.txt_porcentaje.TabIndex = 6
        Me.txt_porcentaje.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripcion:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(148, 120)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(328, 20)
        Me.txt_descripcion.TabIndex = 8
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Navy
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.Location = New System.Drawing.Point(25, 242)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(175, 49)
        Me.btn_nuevo.TabIndex = 9
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Navy
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(206, 242)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(163, 49)
        Me.btn_guardar.TabIndex = 10
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
=======
        Me.SuspendLayout()
        '
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
        'Iva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(659, 303)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_porcentaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_tipo_iva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_usuario)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Iva"
        Me.Text = "Iva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_usuario As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_iva As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_porcentaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
=======
        Me.ClientSize = New System.Drawing.Size(776, 556)
        Me.Name = "Iva"
        Me.Text = "Iva"
        Me.ResumeLayout(False)

    End Sub
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
End Class
