<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionToolStripMenuItem, Me.CatalogosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionToolStripMenuItem
        '
        Me.OperacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem})
        Me.OperacionToolStripMenuItem.Name = "OperacionToolStripMenuItem"
        Me.OperacionToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.OperacionToolStripMenuItem.Text = "&Operacion"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Image = CType(resources.GetObject("FacturacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.FacturacionToolStripMenuItem.Text = "&Facturacion"
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.TipoCambioToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CatalogosToolStripMenuItem.Text = "&Catalogos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ClientesToolStripMenuItem.Text = "C&lientes"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'TipoCambioToolStripMenuItem
        '
        Me.TipoCambioToolStripMenuItem.Image = CType(resources.GetObject("TipoCambioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoCambioToolStripMenuItem.Name = "TipoCambioToolStripMenuItem"
        Me.TipoCambioToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TipoCambioToolStripMenuItem.Text = "&Tipo Cambio"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca De.."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 478)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "CONTAFACT 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoCambioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
