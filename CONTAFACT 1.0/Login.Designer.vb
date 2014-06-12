<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_dsn = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ODBC:"
        '
        'txt_dsn
        '
        Me.txt_dsn.BackColor = System.Drawing.SystemColors.Control
        Me.txt_dsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dsn.Location = New System.Drawing.Point(162, 35)
        Me.txt_dsn.Name = "txt_dsn"
        Me.txt_dsn.Size = New System.Drawing.Size(100, 26)
        Me.txt_dsn.TabIndex = 4
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(162, 86)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 26)
        Me.txt_usuario.TabIndex = 5
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(162, 129)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(100, 26)
        Me.txt_password.TabIndex = 1
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.Navy
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.Location = New System.Drawing.Point(3, 177)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(164, 52)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Navy
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(173, 177)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(161, 52)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(337, 246)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_dsn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_dsn As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
End Class
