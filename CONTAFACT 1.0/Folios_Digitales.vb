﻿Public Class Folios_Digitales


    Private Sub Folios_Digitales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contafact_newDataSet5.cat_folios_digitales' Puede moverla o quitarla según sea necesario.
        Me.Cat_folios_digitalesTableAdapter.Fill(Me.Contafact_newDataSet5.cat_folios_digitales)

    End Sub

End Class