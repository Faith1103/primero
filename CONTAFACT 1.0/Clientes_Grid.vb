Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml
Public Class Clientes_Grid

    Private Sub Clientes_Grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select cte_id_cliente, cte_RFC, cte_RAZON_SOCIAL from cat_cliente"

        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_cliente")

        Dim dt As DataTable
        dt = ds.Tables("cat_cliente")
        dgv_clientes.AutoGenerateColumns = False
        dgv_clientes.DataSource = dt

        dgv_clientes.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        dgv_clientes.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        cn.Close()



     

    End Sub
End Class