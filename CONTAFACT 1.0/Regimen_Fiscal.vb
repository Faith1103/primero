Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml
Public Class Regimen_Fiscal

    Private Sub Regimen_Fiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet4.cat_regimen_fiscal' Puede moverla o quitarla según sea necesario.
        'Me.Cat_regimen_fiscalTableAdapter.Fill(Me.Contafact_newDataSet4.cat_regimen_fiscal)
        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select * from cat_regimen_fiscal"

        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_regimen_fiscal")

        Dim dt As DataTable
        dt = ds.Tables("cat_regimen_fiscal")
        dgv_regimen_fiscal.AutoGenerateColumns = False
        dgv_regimen_fiscal.DataSource = dt

        dgv_regimen_fiscal.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        dgv_regimen_fiscal.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        cn.Close()

    End Sub
End Class