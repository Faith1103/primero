Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Xml


Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reader As XmlTextReader = New XmlTextReader("contafact_ini.xml")
        Dim x As Integer = 0
        Try
            Do While (reader.Read())
                ' MsgBox(x)

                Select Case reader.NodeType
                   

                    Case XmlNodeType.Text 'Mostrar el texto de cada elemento.
                        ' MsgBox(reader.Value, , x)
                        If x = 5 Then
                            txt_dsn.Text = reader.Value
                        End If
                        If x = 9 Then
                            txt_usuario.Text = reader.Value
                        End If

                    Case XmlNodeType.EndElement 'Mostrar final del elemento.
                        ' Console.Write("</" + reader.Name)
                        ' Console.WriteLine(">")
                End Select
                x = x + 1
            Loop
            'Console.ReadLine()
        Catch ex As Exception
           
        End Try
       
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        Dim cn As OdbcConnection
        Dim dsn As String
        Dim usuario As String
        Dim password As String
        Dim myXmlDocument As XmlDocument = New XmlDocument()
        Dim newusuario As String
        Dim newdsn As String
        myXmlDocument.Load("contafact_ini.xml")

        dsn = txt_dsn.Text
        usuario = txt_usuario.Text
        password = txt_password.Text

      
        cn = New OdbcConnection("dsn=" + dsn + ";uid=postgres;pwd=sas;")
        Dim mystring As String = "Select count(*) from cat_usuarios where id_usuario='" + usuario + "' and password='" + password + "'"

        Dim cmd As OdbcCommand = New OdbcCommand(mystring, cn)

        Try
            cn.Open()
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            Do While dr.Read()
                If dr.GetString(0) = 1 Then
                    Dim node As XmlNode
                    node = myXmlDocument.DocumentElement
                    ''''''''''''''''''''''' guarda las nuevas credenciales
                    Dim node2 As XmlNode 'Used for internal loop.

                    For Each node In node.ChildNodes
                        'Find the price child node.
                        For Each node2 In node.ChildNodes

                            If node2.Name = "dsn" Then
                                '                    nodePriceText = node2.InnerText

                                newdsn = txt_dsn.Text

                                node2.InnerText = newdsn
                            End If

                            If node2.Name = "usuario" Then
                                '                    nodePriceText = node2.InnerText

                                newusuario = txt_dsn.Text

                                node2.InnerText = newusuario
                            End If
                        Next
                    Next


                    myXmlDocument.Save("contafact_ini2.xml")
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    g_dsn = dsn
                    g_usuario = usuario
                    Main.Show()
                    Me.Visible = False



                Else
                    MsgBox("Usuario y/o password incorrectos.", MsgBoxStyle.Critical, "Error autenticacion")
                    txt_usuario.Text = ""
                    txt_password.Text = ""

                End If
            Loop
        Catch ex As OdbcException
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try



        
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        End
    End Sub
End Class