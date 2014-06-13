<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sellos_Digitales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sellos_Digitales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_certificado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ruta_cer = New System.Windows.Forms.Button()
        Me.txt_key = New System.Windows.Forms.TextBox()
        Me.btn_ruta_key = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pass_key = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fecha_cer = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_vencimiento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_ruta_archivos = New System.Windows.Forms.Button()
        Me.txt_ruta_archivos = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_usuario_pac = New System.Windows.Forms.TextBox()
        Me.txt_pass_pac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_usuario = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Certificado:"
        '
        'txt_certificado
        '
        Me.txt_certificado.Location = New System.Drawing.Point(103, 31)
        Me.txt_certificado.Name = "txt_certificado"
        Me.txt_certificado.Size = New System.Drawing.Size(492, 20)
        Me.txt_certificado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Llave Privada:"
        '
        'btn_ruta_cer
        '
        Me.btn_ruta_cer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ruta_cer.Location = New System.Drawing.Point(612, 31)
        Me.btn_ruta_cer.Name = "btn_ruta_cer"
        Me.btn_ruta_cer.Size = New System.Drawing.Size(32, 23)
        Me.btn_ruta_cer.TabIndex = 4
        Me.btn_ruta_cer.Text = "..."
        Me.btn_ruta_cer.UseVisualStyleBackColor = True
        '
        'txt_key
        '
        Me.txt_key.Location = New System.Drawing.Point(103, 65)
        Me.txt_key.Name = "txt_key"
        Me.txt_key.Size = New System.Drawing.Size(492, 20)
        Me.txt_key.TabIndex = 5
        '
        'btn_ruta_key
        '
        Me.btn_ruta_key.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ruta_key.Location = New System.Drawing.Point(612, 65)
        Me.btn_ruta_key.Name = "btn_ruta_key"
        Me.btn_ruta_key.Size = New System.Drawing.Size(32, 23)
        Me.btn_ruta_key.TabIndex = 6
        Me.btn_ruta_key.Text = "..."
        Me.btn_ruta_key.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña:"
        '
        'txt_pass_key
        '
        Me.txt_pass_key.Location = New System.Drawing.Point(103, 101)
        Me.txt_pass_key.Name = "txt_pass_key"
        Me.txt_pass_key.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass_key.Size = New System.Drawing.Size(160, 20)
        Me.txt_pass_key.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_cer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vigencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Desde:"
        '
        'txt_fecha_cer
        '
        Me.txt_fecha_cer.Location = New System.Drawing.Point(85, 39)
        Me.txt_fecha_cer.Mask = "00/00/0000"
        Me.txt_fecha_cer.Name = "txt_fecha_cer"
        Me.txt_fecha_cer.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_cer.TabIndex = 1
        Me.txt_fecha_cer.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "(dd/mm/yyyy)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hasta:"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(375, 38)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_hasta.TabIndex = 4
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(385, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "(dd/mm/yyyy)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Avisarme Antes de Vencimiento:"
        '
        'cmb_vencimiento
        '
        Me.cmb_vencimiento.FormattingEnabled = True
        Me.cmb_vencimiento.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cmb_vencimiento.Location = New System.Drawing.Point(195, 272)
        Me.cmb_vencimiento.Name = "cmb_vencimiento"
        Me.cmb_vencimiento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_vencimiento.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_ruta_archivos)
        Me.GroupBox2.Controls.Add(Me.txt_ruta_archivos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 61)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ruta Archivos"
        '
        'btn_ruta_archivos
        '
        Me.btn_ruta_archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ruta_archivos.Location = New System.Drawing.Point(575, 19)
        Me.btn_ruta_archivos.Name = "btn_ruta_archivos"
        Me.btn_ruta_archivos.Size = New System.Drawing.Size(32, 23)
        Me.btn_ruta_archivos.TabIndex = 15
        Me.btn_ruta_archivos.Text = "..."
        Me.btn_ruta_archivos.UseVisualStyleBackColor = True
        '
        'txt_ruta_archivos
        '
        Me.txt_ruta_archivos.Location = New System.Drawing.Point(6, 19)
        Me.txt_ruta_archivos.Name = "txt_ruta_archivos"
        Me.txt_ruta_archivos.Size = New System.Drawing.Size(563, 20)
        Me.txt_ruta_archivos.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_pass_pac)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_usuario_pac)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 397)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(623, 100)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos PAC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Usuario:"
        '
        'txt_usuario_pac
        '
        Me.txt_usuario_pac.Location = New System.Drawing.Point(222, 26)
        Me.txt_usuario_pac.Name = "txt_usuario_pac"
        Me.txt_usuario_pac.Size = New System.Drawing.Size(347, 20)
        Me.txt_usuario_pac.TabIndex = 1
        '
        'txt_pass_pac
        '
        Me.txt_pass_pac.Location = New System.Drawing.Point(222, 60)
        Me.txt_pass_pac.Name = "txt_pass_pac"
        Me.txt_pass_pac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass_pac.Size = New System.Drawing.Size(347, 20)
        Me.txt_pass_pac.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Password:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Navy
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(460, 518)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(184, 44)
        Me.btn_guardar.TabIndex = 14
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_usuario
        '
        Me.btn_usuario.BackColor = System.Drawing.Color.Navy
        Me.btn_usuario.BackgroundImage = CType(resources.GetObject("btn_usuario.BackgroundImage"), System.Drawing.Image)
        Me.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_usuario.Location = New System.Drawing.Point(21, 518)
        Me.btn_usuario.Name = "btn_usuario"
        Me.btn_usuario.Size = New System.Drawing.Size(75, 44)
        Me.btn_usuario.TabIndex = 15
        Me.btn_usuario.UseVisualStyleBackColor = False
        '
=======
        Me.SuspendLayout()
        '
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
        'Sellos_Digitales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(669, 574)
        Me.Controls.Add(Me.btn_usuario)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmb_vencimiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_pass_key)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_ruta_key)
        Me.Controls.Add(Me.txt_key)
        Me.Controls.Add(Me.btn_ruta_cer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_certificado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sellos_Digitales"
        Me.Text = "Sellos Digitales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_certificado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ruta_cer As System.Windows.Forms.Button
    Friend WithEvents txt_key As System.Windows.Forms.TextBox
    Friend WithEvents btn_ruta_key As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_pass_key As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_cer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_vencimiento As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ruta_archivos As System.Windows.Forms.Button
    Friend WithEvents txt_ruta_archivos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pass_pac As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_pac As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_usuario As System.Windows.Forms.Button
=======
        Me.ClientSize = New System.Drawing.Size(772, 550)
        Me.Name = "Sellos_Digitales"
        Me.Text = "Sellos_Digitales"
        Me.ResumeLayout(False)

    End Sub
>>>>>>> cbcb8bd088aa3de7a1e7bb593e67b469ec8ea504
End Class
