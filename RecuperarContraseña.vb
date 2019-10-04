Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class RecuperarContraseña
    'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
#Region "Drag Form"
    <DllImport("user32.Dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
    <DllImport("user32.Dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Dim entrada As Integer = 0
    Private Sub BotonCambioClave_Click(sender As Object, e As EventArgs) Handles botonCambioClave.Click

        'FALTA TERMINAR DE VALIDAR EL CAMBIO DE CONTRASEÑA
        Try

            Dim llamado0 As New connection
            Dim codigo As String = "False"
            Try

                Dim consulta0 As New MySqlCommand("Select * from usuarios where codigoRecuperacion='" & txtCodigoRecuperacion.Text & "'", llamado0.conexion)

                llamado0.AbrirConexion()

                Dim leer As MySqlDataReader = consulta0.ExecuteReader()

                If (leer.Read()) Then
                    codigo = leer(4).ToString
                    If entrada = 0 Then

                        MsgBox("El codigo " + "(" + codigo + ")" + " es correcto.")
                        Label3.Enabled = True
                        Label4.Enabled = True
                        txtNuevaContraseña.Enabled = True
                        txtVolverAescribir.Enabled = True
                        txtCodigoRecuperacion.Enabled = False
                        entrada = 1

                    ElseIf entrada = 1 Then

                        If txtCodigoRecuperacion.Text = "" Or txtVolverAescribir.Text = "" Then
                            MsgBox("Los campos no deben estar vacios.")
                        Else
                            If txtNuevaContraseña.Text = txtVolverAescribir.Text Then

                                If leer(5).ToString <> txtNuevaContraseña.Text Then
                                    Dim llamado1 As New connection
                                    Dim consulta1 As New MySqlCommand("update usuarios set Contraseña ='" & txtNuevaContraseña.Text & "' where CodigoRecuperacion='" & codigo & "'", llamado1.conexion)

                                    llamado1.AbrirConexion()
                                    consulta1.ExecuteNonQuery()
                                    llamado1.CerrarConexion()
                                    entrada = 0

                                    MsgBox("Cambio de contraseña exitoso.")
                                    txtCodigoRecuperacion.Text = ""
                                    txtNuevaContraseña.Text = ""
                                    txtVolverAescribir.Text = ""

                                    Label3.Enabled = False
                                    Label4.Enabled = False
                                    txtNuevaContraseña.Enabled = False
                                    txtVolverAescribir.Enabled = False
                                    txtCodigoRecuperacion.Enabled = True
                                Else
                                    MsgBox("LA CONTRASEÑA SE UTILIZO RECIENTEMENTE,VUELVA A INTENTAR CON UNA CONTRASEÑA DIFERENTE.", MsgBoxStyle.Critical, "INFORMACION")
                                    txtNuevaContraseña.Focus()
                                End If


                            Else

                                MsgBox("Las contraseñas no coinciden,porfavor intentelo nuevamente.")
                                txtVolverAescribir.Text = ""
                                txtNuevaContraseña.Text = ""

                            End If


                        End If

                    End If

                Else

                    MsgBox("Codigo errado y/o el campo esta vacio.")

                End If
                llamado0.CerrarConexion()
            Catch ex As Exception

                MsgBox("No arrojo ningun valor")
            End Try


        Catch ex As Exception
            MsgBox("Error al intentar recuperar contraseña.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BotonCancelarCambio_Click(sender As Object, e As EventArgs) Handles botonCancelarCambio.Click

        txtCodigoRecuperacion.Text = ""
        txtNuevaContraseña.Text = ""
        txtVolverAescribir.Text = ""

        txtCodigoRecuperacion.Enabled = True
        txtNuevaContraseña.Enabled = False
        txtVolverAescribir.Enabled = False


        txtCodigoRecuperacion.Focus()

        Me.Hide()

    End Sub


    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H1128, &HF0128, 0)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H1128, &HF0128, 0)


    End Sub


#End Region
End Class