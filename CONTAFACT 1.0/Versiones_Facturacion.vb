Public Class Versiones_Facturacion


    Private Sub Versiones_Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet6.cat_version_facturacion' Puede moverla o quitarla según sea necesario.
        Me.Cat_version_facturacionTableAdapter.Fill(Me.Contafact_newDataSet6.cat_version_facturacion)

    End Sub

End Class