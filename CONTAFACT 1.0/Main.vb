Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class Main

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionToolStripMenuItem.Click
        Dim form As New Facturacion_menu
        ' form.MdiParent = Me

        form.Show()
        Me.Visible = False

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Me.Text = "CONTAFACT 1.0 DSN= " + g_dsn.ToUpper + " USUARIO= " + usuario.ToUpper
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim form As New Usuarios

        ' form.MdiParent = Me
        form.Show()

    End Sub
End Class
