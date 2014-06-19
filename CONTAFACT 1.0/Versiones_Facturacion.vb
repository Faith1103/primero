Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml
Public Class Versiones_Facturacion


    Private Sub Versiones_Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet6.cat_version_facturacion' Puede moverla o quitarla según sea necesario.
        '  Me.Cat_version_facturacionTableAdapter.Fill(Me.Contafact_newDataSet6.cat_version_facturacion)


        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet2.cat_metodo_pago' Puede moverla o quitarla según sea necesario.

        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select * from cat_version_facturacion"

        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_version_facturacion")

        Dim dt As DataTable
        dt = ds.Tables("cat_version_facturacion")
        dgv_versiones.AutoGenerateColumns = False
        dgv_versiones.DataSource = dt

        dgv_versiones.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        dgv_versiones.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        'DataGridViewCheckBoxColumn
        dgv_versiones.Columns(5).CellTemplate = New DataGridViewCheckBoxCell()



        cn.Close()





    End Sub
 

End Class