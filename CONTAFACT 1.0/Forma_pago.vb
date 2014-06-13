Public Class Forma_pago


    Private Sub Forma_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet3.cat_forma_pago' Puede moverla o quitarla según sea necesario.
        Me.Cat_forma_pagoTableAdapter.Fill(Me.Contafact_newDataSet3.cat_forma_pago)

    End Sub

End Class