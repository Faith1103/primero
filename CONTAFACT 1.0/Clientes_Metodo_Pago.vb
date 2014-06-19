
Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml
Public Class Clientes_Metodo_Pago

    Private Sub Clientes_Metodo_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet1.cat_clientes_metodo_forma_pago' Puede moverla o quitarla según sea necesario.
       

        Dim cn As OdbcConnection
        cn = New OdbcConnection("dsn=" + g_dsn + ";uid=postgres;pwd=sas;")


        Dim myDataTable As New DataTable
        Dim ds As New DataSet()
        Dim da As OdbcDataAdapter
        Dim sr As String
        sr = "select * from cat_clientes_metodo_forma_pago"

        cn.Open()
        da = New OdbcDataAdapter(sr, cn)
        da.Fill(ds, "cat_clientes_metodo_forma_pago")

        Dim dt As DataTable
        dt = ds.Tables("cat_clientes_metodo_forma_pago")
        dgv_cliente_metodo.AutoGenerateColumns = False
        dgv_cliente_metodo.DataSource = dt

        dgv_cliente_metodo.Columns(0).DataPropertyName = dt.Columns(0).ColumnName.ToUpper
        dgv_cliente_metodo.Columns(1).DataPropertyName = dt.Columns(1).ColumnName.ToUpper
        'DataGridViewCheckBoxColumn
        'dgv_cliente_metodo.Columns(1).CellTemplate = New DataGridViewCheckBoxCell()
        'dgv_cliente_metodo.Columns(2).CellTemplate = New DataGridViewCheckBoxCell()
        ' dgv_cliente_metodo.Columns(3).CellTemplate = New DataGridViewCheckBoxCell()
        ' dgv_cliente_metodo.Columns(5).CellTemplate = New DataGridViewCheckBoxCell()



        cn.Close()



    End Sub
End Class