Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient



Public Class Login

#Region "Form Bhaviors"
    'ESTE CODIGO SE UTILIZA PARA CERRAR EL LOGIN
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    'ESTE CODIGO SE UTILIZA PARA MINIMIZAR EL LOGIN
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
    'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
#Region "Drag Form"
    <DllImport("user32.Dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
    <DllImport("user32.Dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
    'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H1128, &HF0128, 0)

    End Sub

    'BLOQUE UTILIZADO PARA REALIZAR LA VALIDACION E INICIO DE SESION.19-05-2019

    'BLOQUE UTILIZADO PARA DARLE FORMA AL BOTON DE INGRESO UTILIZANDO EL METODO PAINT.
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles botonIngresarLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = botonIngresarLogin.ClientRectangle
        myRectangle.Inflate(0, 25)
        buttonPath.AddEllipse(myRectangle)
        botonIngresarLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'BLOQUE UTILIZADO PARA VALIDAR CHECKBOX DEL TEXBOX CONTRASEÑA.19-05-2019
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False

        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If ChrW(Keys.Space) = e.KeyChar Then
            e.Handled = True
        End If
        If ChrW(Keys.Enter) = e.KeyChar Then
            e.Handled = True
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown

        'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown

        'ESTE METODO ES UTILIZADO PARA QUE SE PUEDA MOVER LA VENTANA DEL LOGIN POR TODA LA PANTALLA.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub Button1_Enter(sender As Object, e As EventArgs) Handles botonIngresarLogin.Enter

        Dim llamado As New connection


        Try
            Dim Usuario As String = "False"
            Dim NomUsuario As String = "False"
            Dim cmd As New MySqlCommand("Select * from usuarios where Usuario='" & txtusuario.Text & "' and Contraseña='" & TextBox1.Text & "'", llamado.conexion)

            llamado.AbrirConexion()
            Dim leer As MySqlDataReader = cmd.ExecuteReader()


            If (leer.Read()) Then

                NomUsuario = leer(1).ToString
                Usuario = leer(3).ToString

                If (txtusuario.Text.Equals(leer(2).ToString) And TextBox1.Text.Equals(leer(5)).ToString) Then
                    Me.Visible = False
                    If (leer(3).ToString.Equals("ADMINISTRADOR")) Then

                        '  MsgBox("Bienvenido Sr(a) " + NomUsuario)
                        NotifyIcon2.ShowBalloonTip(10, "Bienvenido Sr(a) ", "" & NomUsuario & "", ToolTipIcon.Info)
                        'mensaje.Show()
                        InventarioSH.Show()


                    ElseIf (leer(3).ToString.Equals("SISTEMAS")) Then

                        InventarioSH.Parent = Nothing
                        '   MsgBox("Rol Sistemas")
                        '  MsgBox("Bienvenido Sr(a) " + NomUsuario)
                        NotifyIcon2.ShowBalloonTip(10, "Bienvenido Sr(a) ", "" & NomUsuario & "", ToolTipIcon.Info)
                        InventarioSH.Show()
                        InventarioSH.btnExterno.Enabled = False
                        InventarioSH.btnUsuarios.Enabled = False

                    ElseIf (leer(3).ToString.Equals("GENERAL")) Then

                        'InventarioSH.Parent = Nothing
                        '  MsgBox("Rol Externo")
                        '    MsgBox("Bienvenido Sr(a) " + NomUsuario)
                        NotifyIcon2.ShowBalloonTip(10, "Bienvenido Sr(a) ", "" & NomUsuario & "", ToolTipIcon.Info)
                        InventarioSH.Show()
                        InventarioSH.btnHardware.Enabled = False
                        InventarioSH.btnUsuarios.Enabled = False




                    End If
                    InventarioSH.Label3.Text = NomUsuario
                    InventarioSH.Label4.Text = Usuario




                End If
            Else
                MsgBox("USUARIO Y/O CONTRASEÑA INCORECTO(S).", MsgBoxStyle.Exclamation)
                TextBox1.Text = ""
                txtusuario.Text = ""
                txtusuario.Focus()
                LabelMayuscula.Visible = False
            End If
            llamado.CerrarConexion()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try




    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then

            botonIngresarLogin.Focus()

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        RecuperarContraseña.ShowDialog()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If ChrW(Keys.Space) = e.KeyChar Then
            e.Handled = True
        End If
    End Sub

    Private Sub BotonIngresarLogin_Click(sender As Object, e As EventArgs) Handles botonIngresarLogin.Click
        Me.Close()

    End Sub
    'METODO QUE CONTROLA SI LA TECLA MAYUSCULA ESTA O NO ACTIVA
    'Sub checkBlock()

    '    If Control.IsKeyLocked(Keys.CapsLock) Then

    '        LabelMayuscula.Text = "MAYUSCULA activada "

    '    Else

    '        LabelMayuscula.Text = "MAYUSCULA desactivada"

    '    End If

    'End Sub

    Private Sub Login_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown
        ' checkBlock()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        '   LabelMayuscula.Visible = True
        '   checkBlock()
    End Sub

    Private Sub Txtusuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyUp
        '  LabelMayuscula.Visible = True
        ' checkBlock()
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



#End Region

End Class
