Public Class Clientes_Metodo_Pago

    Private Sub Clientes_Metodo_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet1.cat_clientes_metodo_forma_pago' Puede moverla o quitarla según sea necesario.
        Me.Cat_clientes_metodo_forma_pagoTableAdapter.Fill(Me.Contafact_newDataSet1.cat_clientes_metodo_forma_pago)

    End Sub
End Class