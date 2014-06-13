Public Class Metodo_Pago

    Private Sub Matodo_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet2.cat_metodo_pago' Puede moverla o quitarla según sea necesario.
        Me.Cat_metodo_pagoTableAdapter.Fill(Me.Contafact_newDataSet2.cat_metodo_pago)

    End Sub
End Class