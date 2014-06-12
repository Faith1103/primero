Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml
Public Class Clientes_Grid

    Private Sub Clientes_Grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet.cat_cliente' Puede moverla o quitarla según sea necesario.

        Me.Cat_clienteTableAdapter.Fill(Me.Contafact_newDataSet.cat_cliente)



     

    End Sub
End Class