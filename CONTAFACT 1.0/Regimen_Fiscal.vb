Public Class Regimen_Fiscal

    Private Sub Regimen_Fiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet4.cat_regimen_fiscal' Puede moverla o quitarla según sea necesario.
        Me.Cat_regimen_fiscalTableAdapter.Fill(Me.Contafact_newDataSet4.cat_regimen_fiscal)

    End Sub
End Class