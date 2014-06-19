
Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml


Public Class Metodo_Pago


    Private Sub Matodo_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet2.cat_metodo_pago' Puede moverla o quitarla según sea necesario.

        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select * from cat_metodo_pago"
        
        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_metodo_pago")

        Dim dt As DataTable
        dt = ds.Tables("cat_metodo_pago")
        dgv_metodo_pago.AutoGenerateColumns = False
        dgv_metodo_pago.DataSource = dt

        dgv_metodo_pago.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        dgv_metodo_pago.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        cn.Close()

        




    End Sub

End Class