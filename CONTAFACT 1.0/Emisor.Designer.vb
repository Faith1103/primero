<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emisor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emisor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rfc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_num_interior = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_colonia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cod_postal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_municipio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_regimen_fiscal = New System.Windows.Forms.Button()
        Me.btn_usuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(92, 21)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(569, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RFC:"
        '
        'txt_rfc
        '
        Me.txt_rfc.Location = New System.Drawing.Point(92, 54)
        Me.txt_rfc.Name = "txt_rfc"
        Me.txt_rfc.Size = New System.Drawing.Size(186, 20)
        Me.txt_rfc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Calle:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(92, 91)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(569, 20)
        Me.txt_calle.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numero:"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(92, 128)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(186, 20)
        Me.txt_numero.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Numero Interior:"
        '
        'txt_num_interior
        '
        Me.txt_num_interior.Location = New System.Drawing.Point(449, 127)
        Me.txt_num_interior.Name = "txt_num_interior"
        Me.txt_num_interior.Size = New System.Drawing.Size(212, 20)
        Me.txt_num_interior.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Colonia:"
        '
        'txt_colonia
        '
        Me.txt_colonia.Location = New System.Drawing.Point(92, 164)
        Me.txt_colonia.Name = "txt_colonia"
        Me.txt_colonia.Size = New System.Drawing.Size(186, 20)
        Me.txt_colonia.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Codigo Postal:"
        '
        'txt_cod_postal
        '
        Me.txt_cod_postal.Location = New System.Drawing.Point(449, 163)
        Me.txt_cod_postal.Name = "txt_cod_postal"
        Me.txt_cod_postal.Size = New System.Drawing.Size(212, 20)
        Me.txt_cod_postal.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Municipio:"
        '
        'txt_municipio
        '
        Me.txt_municipio.Location = New System.Drawing.Point(92, 200)
        Me.txt_municipio.Name = "txt_municipio"
        Me.txt_municipio.Size = New System.Drawing.Size(569, 20)
        Me.txt_municipio.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Estado"
        '
        'txt_estado
        '
        Me.txt_estado.Location = New System.Drawing.Point(92, 239)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(186, 20)
        Me.txt_estado.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(328, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Pais:"
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(449, 238)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(212, 20)
        Me.txt_pais.TabIndex = 19
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Navy
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(339, 334)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(158, 46)
        Me.btn_guardar.TabIndex = 20
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Navy
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(503, 333)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(158, 46)
        Me.btn_salir.TabIndex = 21
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_regimen_fiscal
        '
        Me.btn_regimen_fiscal.BackColor = System.Drawing.Color.Navy
        Me.btn_regimen_fiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regimen_fiscal.ForeColor = System.Drawing.Color.White
        Me.btn_regimen_fiscal.Image = CType(resources.GetObject("btn_regimen_fiscal.Image"), System.Drawing.Image)
        Me.btn_regimen_fiscal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_regimen_fiscal.Location = New System.Drawing.Point(175, 334)
        Me.btn_regimen_fiscal.Name = "btn_regimen_fiscal"
        Me.btn_regimen_fiscal.Size = New System.Drawing.Size(158, 46)
        Me.btn_regimen_fiscal.TabIndex = 22
        Me.btn_regimen_fiscal.Text = "Regimen Fiscal"
        Me.btn_regimen_fiscal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_regimen_fiscal.UseVisualStyleBackColor = False
        '
        'btn_usuario
        '
        Me.btn_usuario.BackColor = System.Drawing.Color.Navy
        Me.btn_usuario.BackgroundImage = CType(resources.GetObject("btn_usuario.BackgroundImage"), System.Drawing.Image)
        Me.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuario.ForeColor = System.Drawing.Color.White
        Me.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuario.Location = New System.Drawing.Point(92, 334)
        Me.btn_usuario.Name = "btn_usuario"
        Me.btn_usuario.Size = New System.Drawing.Size(75, 46)
        Me.btn_usuario.TabIndex = 23
        Me.btn_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_usuario.UseVisualStyleBackColor = False
        '
=======
        Me.SuspendLayout()
        '
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
        'Emisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(696, 386)
        Me.Controls.Add(Me.btn_usuario)
        Me.Controls.Add(Me.btn_regimen_fiscal)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_pais)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_municipio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cod_postal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_colonia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_num_interior)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_rfc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Emisor"
        Me.Text = "Emisor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rfc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_num_interior As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_colonia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_postal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_municipio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_pais As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_regimen_fiscal As System.Windows.Forms.Button
    Friend WithEvents btn_usuario As System.Windows.Forms.Button
=======
        Me.ClientSize = New System.Drawing.Size(762, 553)
        Me.Name = "Emisor"
        Me.Text = "Emisor"
        Me.ResumeLayout(False)

    End Sub
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
End Class
