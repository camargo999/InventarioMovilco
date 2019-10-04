Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Ajax.Utilities
Imports MySql.Data.MySqlClient

Public Class InventarioSH


    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL 
    Private Sub AbrirFormEnPanel(Of miforms As {Form, New})()
        Dim formulario As Form
        formulario = panelContenedor.Controls.OfType(Of miforms)().FirstOrDefault()

        If formulario Is Nothing Then
            formulario = New miforms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            panelContenedor.Controls.Add(formulario)
            panelContenedor.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
            'AddHandler formulario.FormClosed, AddressOf Me.CloseForms
        Else

            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If

            formulario.BringToFront()
        End If


    End Sub

    Private Sub BtnHardware_Click(sender As Object, e As EventArgs) Handles btnHardware.Click





        'metodo que estamos llamando para habrir el form inventario hardware en el principal que es inventarioSH
        AbrirFormEnPanel(Of InventarioHardware)()
        Dim llamado As New connection

        ' InventarioHardware.txtCodigoH.Focus()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitulo_Paint(sender As Object, e As PaintEventArgs) Handles panelTitulo.Paint

        ' labelFecha.Text = DateTime.Now.ToString("G")
        'labelHora.Text = DateTime.Now.ToShortTimeString()
        'DateTime.Now.ToString("dd/MM/yyyy") 
    End Sub


    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        'llamado al frame usuarios
        AbrirFormEnPanel(Of Usuarios)()

        Usuarios.txtNombreUsuarioC.Focus()



    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'metodo para hacer que el boton que se creo para minimizar, haga
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        mensajeC.ShowDialog()

    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles btnExterno.Click
        'llamado al frame inventario general
        AbrirFormEnPanel(Of InventarioGeneral)()


    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseDown
        'codigo para hacer movil el panel que contiene el titulo

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub
    Declare Function AddFontResource Lib "gdi32" Alias "AddFontResourceA" (ByVal lpFileName As String) As Long

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerMostrarHorayFecha.Tick
        '       evento y metodo empleado para que la fecha y hora se muestren

        labelHora.Text = DateTime.Now.Hour.ToString("D2") _
            + ":" _
            + DateTime.Now.Minute.ToString("D2") _
            + ":" _
            + DateTime.Now.Second.ToString("D2")

        'labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        labelFecha.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub BtnMovimiento_Click(sender As Object, e As EventArgs) Handles btnMovimiento.Click

        AbrirFormEnPanel(Of MovimientoInv)()

    End Sub

    Private Sub InventarioSH_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'este codigo deberia ser para utilizar las teclas del teclado y desplazarnos hacia todos los lados
        'Select Case e.KeyCode

        '    Case Keys.Down

        '        SendKeys.Send("+{TAB}")

        '    Case Keys.Right

        '        SendKeys.Send("+{TAB}")

        '    Case Keys.Up

        '        SendKeys.Send("+{TAB}")

        '    Case Keys.Left

        '        SendKeys.Send("+{TAB}")

        '    Case Else


        'End Select

        'CODIGO PARA QUE ENTRE A UN LINK AL PULSAR LAS DEBIDAS TECLAS DENTRO DEL IF
        'If e.KeyData = Keys.Control + Keys.Alt + Keys.I Then
        '    System.Diagnostics.Process.Start("http://investigacionmovilcosas.blogspot.com/")

        'End If

    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click

        AbrirFormEnPanel(Of Reportes)()

        '' METODO UTILIZADO PARA QUE CUANDO CARGUE EL TABCONTROL SE ACTUALICE EL TEXTBOX CANTIDAD DE REMISIONES
        'Try
        '    Dim llama As New connection
        '    Dim num As String = 0
        '    llama.AbrirConexion()
        '    Dim consult As New MySqlCommand("Select  COUNT(`idRegistroR`) FROM `registrosremisiones`", llama.conexion)
        '    Dim leer01 As MySqlDataReader = consult.ExecuteReader()
        '    If leer01.Read Then
        '        num = leer01(0)
        '    End If

        '    Reportes.TextBoxCantidadR.Text = num
        '    llama.CerrarConexion()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try



    End Sub

    Private Sub InventarioSH_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        LabelS.Font = New Font(LabelS.Font.Name, 20)
        NotifyIcon1.ShowBalloonTip(5, "Inventario Movilco", "El aplicativo ha iniciado correctamente", ToolTipIcon.Info)

    End Sub

    Private Sub CLIKAQUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIKAQUIToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.movilco.com.co")
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        Dim ruta As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\S.I.M\Ayuda.chm"
        Help.ShowHelp(PictureBox5, "file://" + ruta)

    End Sub

End Class