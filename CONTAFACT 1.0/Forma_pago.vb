Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml

Public Class Forma_pago


    Private Sub Forma_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select * from cat_forma_pago"

        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_forma_pago")

        Dim dt As DataTable
        dt = ds.Tables("cat_forma_pago")
        dgv_forma_pago.AutoGenerateColumns = False
        dgv_forma_pago.DataSource = dt

        dgv_forma_pago.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        dgv_forma_pago.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        cn.Close()

    End Sub

End Class