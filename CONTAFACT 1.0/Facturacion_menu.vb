Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class Facturacion_menu

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub OperacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperacionToolStripMenuItem.Click
        Dim form As New Facturacion
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub MetodosDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodosDePagoToolStripMenuItem.Click
        Dim form As New Metodo_Pago
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub FormasDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormasDePagoToolStripMenuItem.Click
        Dim form As New Forma_pago
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub ConsecutivosGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsecutivosGeneralesToolStripMenuItem.Click
        Dim form As New ConsecutivosGenerales
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub EmisorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmisorToolStripMenuItem.Click
        Dim form As New Emisor
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub SellosDigitalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellosDigitalesToolStripMenuItem.Click
        Dim form As New Sellos_Digitales
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub FoliosDigitalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoliosDigitalesToolStripMenuItem.Click
        Dim form As New Folios_Digitales
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim form As New Iva
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub VersionesFacturacionElectronicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionesFacturacionElectronicaToolStripMenuItem.Click
        Dim form As New Versiones_Facturacion
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub Facturacion_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cn As OdbcConnection

        Dim usuario As String
        '  Dim password As String

        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")
        Dim mystring As String = "Select concat(nombre, ' ',ap_paterno) from cat_usuarios where id_usuario='" + g_usuario + "'"

        Dim cmd As OdbcCommand = New OdbcCommand(mystring, cn)

        cn.Open()
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        Do While dr.Read()
            usuario = dr.GetString(0)
        Loop
        Me.Text = "FACTURACION MENU --> DSN= " + g_dsn.ToUpper + " USUARIO= " + usuario.ToUpper
    End Sub
End Class