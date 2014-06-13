Public Class Clientes

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_correo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_correo.Click
        Clientes_Email.Show()

    End Sub

    Private Sub btn_metodo_pago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_metodo_pago.Click
        Clientes_Metodo_Pago.Show()

    End Sub

    Private Sub btn_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_usuario.Click
        Usuario_Modif.Show()

    End Sub
End Class