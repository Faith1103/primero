Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml
Public Class Folios_Digitales


    Private Sub Folios_Digitales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet5.cat_folios_digitales' Puede moverla o quitarla según sea necesario.
        ' Me.Cat_folios_digitalesTableAdapter.Fill(Me.Contafact_newDataSet5.cat_folios_digitales)
        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select * from cat_folios_digitales"

        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_folios_digitales")

        Dim dt As DataTable
        dt = ds.Tables("cat_folios_digitales")
        dgv_folios_digitales.AutoGenerateColumns = False
        dgv_folios_digitales.DataSource = dt

        'dgv_folios_digitales.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        'dgv_folios_digitales.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        'DataGridViewCheckBoxColumn
        dgv_folios_digitales.Columns(1).CellTemplate = New DataGridViewCheckBoxCell()



        cn.Close()



    End Sub

End Class