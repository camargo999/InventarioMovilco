Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports System.Net.WebRequestMethods
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports File = System.IO.File


Public Class Reportes


    Sub configDataGridView1()
        'codigo utilizado para personalizar el datagridview
        For i As Integer = 0 To DataGridMov.Rows.Count - 1

            If i Mod 2 = 0 Then

                DataGridMov.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                DataGridMov.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

            End If

        Next
    End Sub
    Public Function traerId()
        'funcion creada para traer el id max que haya en la tabla registrosremisiones
        Try
            Dim numero As String = 0
            Dim llamado As New connection
            llamado.AbrirConexion()
            Dim consulta As New MySqlCommand("Select MAX(idRegistroR) from registrosremisiones", llamado.conexion)

            Dim leer As MySqlDataReader = consulta.ExecuteReader()
            If leer.Read Then
                numero = leer(0)
            End If
            llamado.CerrarConexion()
#Disable Warning BC42104 ' La variable 'numero' se usa antes de que se le haya asignado un valor. Podría darse una excepción de referencia NULL en tiempo de ejecución.
            Return numero
#Enable Warning BC42104 ' La variable 'numero' se usa antes de que se le haya asignado un valor. Podría darse una excepción de referencia NULL en tiempo de ejecución.
        Catch ex As Exception
            '    MsgBox(ex.Message)
        End Try
#Disable Warning BC42105 ' La función 'traerId' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function
#Enable Warning BC42105 ' La función 'traerId' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

        Me.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Timer1.Stop()

    End Sub
    Private bmp As Bitmap
    Private Sub btnImprimirRep_Click_1(sender As Object, e As EventArgs) Handles btnImprimirRep.Click

        '  Remision.Show()
        'este codigo pertenece al boton imprimir
        Try

            If comboCodigoArticulo.Text = "Seleccionar" Or comboDestinatarioR.Text = "Seleccionar" Or comboCodigoArticulo.Text = "Seleccionar" Then

                lblOcultoId.Visible = False
                MsgBox("NO HAY DATOS PARA ALMACENAR", MsgBoxStyle.Information, "INFORMACIÓN")


            Else
                'este metodo crea una carpeta en documentos
                Dim CarpetaDestino As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\imagenBD"
                MsgBox("Se almacanara en la ruta.. " & CarpetaDestino, MsgBoxStyle.Information, "INFORMACION")


                'este metodo se utiliza para modificar el tamaño del panel a guardar
                bmp = New Bitmap(PanelVista.Width, PanelVista.Height)
                Dim G As Graphics = Graphics.FromImage(bmp)
                PanelVista.DrawToBitmap(bmp, PanelVista.ClientRectangle)



                If PrintDialog22.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    PrintDocument22.PrinterSettings = PrintDialog22.PrinterSettings
                    PrintDocument22.Print()
                Else
                    MsgBox("IMPRESION INTERRUMPIDA.", MsgBoxStyle.Exclamation, "AVISO")
                End If

                'With Remision
                '        Remision.Show()
                '        .imprimir.Print()

                '.PrintAction = Printing.PrintAction.PrintToPreview
                '.Print(Remision, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)


                ' Dim sz As Size = Me.Size

                Try

                    If My.Computer.FileSystem.DirectoryExists(CarpetaDestino) Then

                        'este metodo se utiliza para modificar el tamaño del panel a guardar
                        bmp = New Bitmap(PanelVista.Width, PanelVista.Height)
                        Dim G1 As Graphics = Graphics.FromImage(bmp)
                        PanelVista.DrawToBitmap(bmp, PanelVista.ClientRectangle)

                        'Guardamos el mapa de bits como archivo JPEG.

                        bmp.Save(CarpetaDestino & "\Form.jpg", Imaging.ImageFormat.Jpeg)
                        bmp.Dispose()


                    Else
                        'Si la carpeta no existe la creamos
                        My.Computer.FileSystem.CreateDirectory(CarpetaDestino)

                        'este metodo se utiliza para modificar el tamaño del panel a guardar
                        bmp = New Bitmap(PanelVista.Width, PanelVista.Height)
                        Dim G2 As Graphics = Graphics.FromImage(bmp)
                        PanelVista.DrawToBitmap(bmp, PanelVista.ClientRectangle)

                        ' Guardamos el mapa de bits como archivo JPEG.

                        bmp.Save(CarpetaDestino & "\Form.jpg", Imaging.ImageFormat.Jpeg)
                        bmp.Dispose()

                    End If
                Catch ex As Exception
                    MsgBox("Error al realizar el proceso debido a: " & ex.Message)
                End Try

                Dim concatenarserial As String = ""

                Dim i, a As Integer
                a = 0


                Dim j, r As Integer
                Dim concatenararticulo As String = ""
                Dim concatenararticuloH As String = ""
                Dim concatenararticuloA As String = ""
                Dim llamadoarticulo As New connection

                r = 0
                Dim flag As String = 0


                Dim consultaarticuloH As New MySqlCommand("select tipoArticuloH from inventariohardware where codigoArticuloH='" & comboCodigoArticulo.SelectedItem & "' or serialArticuloSoft='" & comboCodigoArticulo.SelectedItem & "'", llamadoarticulo.conexion)
                llamadoarticulo.AbrirConexion()
                Dim leer12 As MySqlDataReader = consultaarticuloH.ExecuteReader()
                If leer12.Read Then
                    concatenararticuloH = concatenararticuloH + " " + leer12(0)
                End If
                llamadoarticulo.CerrarConexion()

                Dim consultaarticuloA As New MySqlCommand("select articuloA from inventarioactivos where serialMovilco='" & comboCodigoArticulo.SelectedItem & "' or serialArticuloA='" & comboCodigoArticulo.SelectedItem & "'", llamadoarticulo.conexion)
                llamadoarticulo.AbrirConexion()
                Dim leer23 As MySqlDataReader = consultaarticuloA.ExecuteReader()
                If leer23.Read Then
                    concatenararticuloA = concatenararticuloA + " " + leer23(0)
                    MsgBox(concatenararticuloA)
                End If
                llamadoarticulo.CerrarConexion()



                If concatenararticuloH <> "" Then
                    concatenararticulo = concatenararticuloH
                    flag = "SISTEMAS"
                ElseIf concatenararticuloA <> "" Then
                    ' MsgBox(concatenararticuloA)
                    concatenararticulo = concatenararticuloA
                    flag = "ACTIVOS"
                End If


                Dim llamado As New connection

                Dim comando As New MySqlCommand("INSERT INTO `registrosremisiones` (`idRegistroR`, `idDestinatario`,`flag`,`serialR`,`articuloR`, `destinatarioR`, `remitenteR`, `observacionesR`,`imagenes`,`fechaR`) VALUES
(null,'" & lblOcultoId.Text & "','" & flag & "','" & concatenarserial & "', '" & concatenararticulo & "','" & lblParaDestinatario.Text & "', '" & lblDeRemit.Text & "','" & TextBoxObserv.Text & "',?imagen, CURRENT_TIMESTAMP)", llamado.conexion)
                Dim fs As New FileStream(CarpetaDestino & "\Form.jpg", FileMode.Open, FileAccess.Read)

                Dim imag = Image.FromStream(fs)
                imag = (Image.FromFile(CarpetaDestino & "\Form.jpg"))


                comando.Parameters.AddWithValue("?imagen", Imagen_Bytes(imag))

                llamado.AbrirConexion()
                comando.ExecuteNonQuery()


                MsgBox("ARCHIVO GUARDADO CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACIÓN")

                fs.Dispose()
                imag.Dispose()


                comboDestinatarioR.Text = "Seleccionar"
                comboCodigoArticulo.Text = "Seleccionar"

                lblParaDestinatario.Text = ""
                lblEncargadoDest.Text = ""
                lblOficinaDest.Text = ""
                lblDireccionDest.Text = ""
                lblCyD.Text = ""
                lblTelef.Text = ""

                lblDeRemit.Text = ""
                lblCargoRemit.Text = ""
                lblOficinaRemit.Text = ""
                lblDireccionRemit.Text = ""
                lblCelularRemit.Text = ""
                TextBoxObserv.Text = ""

                lblNumeroRemision.Text = traerId() + 1

                ' End With
            End If
            ' End If

        Catch ex As Exception
            MsgBox("ESTABLECER IMPRESORA COMO PREDETERMINADA" + ex.ToString, MsgBoxStyle.Critical, "INFORMACIÓN")
        End Try

        btnGuardarReporte.Visible = True
        btnImprimirRep.Visible = True

        lblTituloReportes.Visible = True
        lblDestin.Visible = True
        comboDestinatarioR.Visible = True
        lblRemit.Visible = True
        comboCodigoArticulo.Visible = True
        LabelArticulo.Visible = True

        lblOcultoId.Visible = False


    End Sub
    Sub traerCantidadRemision()

    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        ' METODO UTILIZADO PARA QUE CUANDO CARGUE EL TABCONTROL SE ACTUALICE EL TEXTBOX CANTIDAD DE REMISIONES
        Try
            Dim llama As New connection
            Dim num As String = 0
            llama.AbrirConexion()
            Dim consult As New MySqlCommand("Select  COUNT(`idRegistroR`) FROM `registrosremisiones`", llama.conexion)
            Dim leer01 As MySqlDataReader = consult.ExecuteReader()
            If leer01.Read Then
                num = leer01(0)
            End If

            TextBoxCantidadR.Text = num
            llama.CerrarConexion()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TextBoxMostrarImg.Focus()
    End Sub
    Sub llenarComboDestinatario()
        Dim llamado As New connection
        Dim consulta As New MySqlCommand("SELECT encargadoD FROM `destinatarios_remitentes` ", llamado.conexion)
        llamado.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                ComboBoxRemitentes.Items.Add(leer("encargadoD"))
                comboDestinatarioR.Items.Add(leer("encargadoD"))
                LabelRemitente.Text = InventarioSH.Label3.Text

            End While
        End If
        llamado.CerrarConexion()

        lblNumeroRemision.Text = traerId() + 1

    End Sub

    Public Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)

        TextBoxCantidadR.ReadOnly = True   'METODO PARA EVITAR QUE EL TEXTBOX SEA EDITABLE


        LabelElemento.Visible = False
        Dim llamado1 As New connection
        llamado1.llenarDataGrid(DataGridMov)

        llenarComboDestinatario()  'metodo para llenar el combobox destinatarios


        'Codigo utilizado para cargar el ListBoxArticulos con los seriales de la tabla hardware.

        Dim llamadoHardwares, llamadoHardwarea, llamadoActivosg, llamadoActivosa As New connection
        If InventarioSH.Label4.Text = "SISTEMAS" Then

            Dim consultaHardware As New MySqlCommand("SELECT codigoArticuloH, serialArticuloSoft FROM inventariohardware ", llamadoHardwares.conexion)
            llamadoHardwares.AbrirConexion()
            Dim leerHardware As MySqlDataReader = consultaHardware.ExecuteReader()

            If leerHardware.HasRows Then
                While leerHardware.Read

                    comboCodigoArticulo.Items.Add(leerHardware("codigoArticuloH"))
                    comboCodigoArticulo.Items.Add(leerHardware("serialArticuloSoft"))

                End While
            End If
            llamadoHardwares.CerrarConexion()
        ElseIf InventarioSH.Label4.Text = "GENERAL" Then

            Dim consultaActivos As New MySqlCommand("SELECT serialMovilco,serialArticuloA FROM inventarioactivos", llamadoActivosg.conexion)
            llamadoActivosg.AbrirConexion()
            Dim leerActivos As MySqlDataReader = consultaActivos.ExecuteReader()

            If leerActivos.HasRows Then
                While leerActivos.Read

                    comboCodigoArticulo.Items.Add(leerActivos("serialMovilco"))
                    comboCodigoArticulo.Items.Add(leerActivos("serialArticuloA"))

                End While
            End If
            llamadoActivosg.CerrarConexion()
        ElseIf InventarioSH.Label4.Text = "ADMINISTRADOR" Then
            RadioSistemas.Visible = True
            RadioActivos.Visible = True
            RadioSistemas_CheckedChanged(sender, e)

        Else
            MsgBox("ERROR CON LA BASE DE DATOS", MsgBoxStyle.Critical, "ADVERTENCIA")
        End If
        comboCodigoArticulo.Text = comboCodigoArticulo.Items.Item(0)

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '       evento y metodo empleado para que la fecha y hora se muestren



        'labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblFechaDest.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour.ToString("D2") _
            + ":" _
            + DateTime.Now.Minute.ToString("D2") _
            + ":" _
            + DateTime.Now.Second.ToString("D2")

    End Sub
    '  Public cargoremit As Label = lblCargoRemit
    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        'Realizo el llamado a la clase llenarDatagrid que se creo previamente en la clase conexion 

        Dim llamado As New connection
        llamado.llenarDataGrid(DataGridMov)
    End Sub

    Private Sub DataGridMov_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridMov.DataSourceChanged
        'llamado al metodo de personalizacion del datagridview

        configDataGridView1()

    End Sub


    Private Sub DataGridMov_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMov.CellClick

        Dim va1, va2, va3, va4, va5, va6, va0 As String
        va1 = DataGridMov.Item(1, DataGridMov.CurrentRow.Index).Value
        va2 = DataGridMov.Item(2, DataGridMov.CurrentRow.Index).Value
        va3 = DataGridMov.Item(3, DataGridMov.CurrentRow.Index).Value
        va4 = DataGridMov.Item(4, DataGridMov.CurrentRow.Index).Value
        va5 = DataGridMov.Item(5, DataGridMov.CurrentRow.Index).Value
        va6 = DataGridMov.Item(6, DataGridMov.CurrentRow.Index).Value
        va0 = DataGridMov.Item(0, DataGridMov.CurrentRow.Index).Value

        txtEditarOficina.Text = va1
        txtEditarEncargado.Text = va2
        txtEditarCuidar.Text = va3
        txtEditarDireccion.Text = va4
        txtEditarCelular.Text = va5
        txtEditarCargo.Text = va6

        lblIdInvisible.Text = va0


    End Sub

    Public Sub Btnprueba_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub ComboDestinatarioR_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboDestinatarioR.SelectedValueChanged
        'Se creara el codigo para que dependiendo del item seleccionado se llenen los campos de reportes o remision

        Dim llamado As New connection
        Dim consulta As New MySqlCommand("SELECT * FROM `destinatarios_remitentes` WHERE encargadoD='" & comboDestinatarioR.SelectedItem & "' ", llamado.conexion)
        llamado.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()

        If leer.Read Then

            lblOcultoId.Text = leer(0)
            lblParaDestinatario.Text = leer(2)
            lblEncargadoDest.Text = leer(6)
            lblOficinaDest.Text = leer(1)
            lblDireccionDest.Text = leer(4)
            lblTelef.Text = leer(5)
            lblCyD.Text = leer(3)


        End If

        llamado.CerrarConexion()
    End Sub

    'Private Sub comboCodigoArticulo_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboCodigoArticulo.SelectedValueChanged
    '    Dim llamado As New connection
    '    Dim consulta As New MySqlCommand("SELECT  FROM `inventariohardware`", llamado.conexion)
    '    llamado.AbrirConexion()
    '    Dim leer As MySqlDataReader = consulta.ExecuteReader()

    '    llamado.CerrarConexion()

    '    Dim llamado1 As New connection
    '    Dim consulta1 As New MySqlCommand("SELECT serialMovilco, serialArticuloA FROM `inventarioactivos`", llamado1.conexion)
    '    llamado1.AbrirConexion()
    '    Dim leer1 As MySqlDataReader = consulta1.ExecuteReader()

    '    llamado1.CerrarConexion()
    'End Sub

    Private Sub ComboDestinatarioR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboDestinatarioR.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboCodigoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboCodigoArticulo.KeyPress
        ' e.Handled = True
    End Sub

    Private Sub DataGridMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridMov.KeyPress
        '  DataGridMov.KeyPress()

        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    Dim i, var1 As Integer
        '    i = DataGridMov.CurrentRow.Index - 1
        '    var1 = DataGridMov.Item(1, i).Value 'id
        '    txtEditarOficina.Text = var1
        '    MsgBox(var1)
        'End If

    End Sub

    Private Sub BtnEliminarRe_Click(sender As Object, e As EventArgs) Handles btnEliminarRe.Click

        Dim llamado As New connection


        If txtEditarOficina.Text <> "" And txtEditarEncargado.Text <> "" And txtEditarCuidar.Text <> "" And txtEditarDireccion.Text <> "" And txtEditarCelular.Text <> "" And txtEditarCargo.Text <> "" Then
            Dim msg As String
            msg = MsgBox("Esta seguro(a) de eliminar los datos?. ", MsgBoxStyle.YesNo, "PRECAUCIÓN")
            If msg = vbYes Then
                Dim comando As New MySqlCommand("delete from `destinatarios_remitentes` where idDestinatario=" & lblIdInvisible.Text, llamado.conexion)
                llamado.AbrirConexion()
                comando.ExecuteNonQuery()

                txtEditarOficina.Text = ""
                txtEditarEncargado.Text = ""
                txtEditarCuidar.Text = ""
                txtEditarDireccion.Text = ""
                txtEditarCelular.Text = ""
                txtEditarCargo.Text = ""

                llamado.CerrarConexion()
                llamado.llenarDataGrid(DataGridMov)

                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")
            End If

        Else
            MsgBox("No hay datos para eliminar")
            txtEditarOficina.Focus()
        End If

        comboDestinatarioR.Items.Clear()
        comboCodigoArticulo.Items.Clear()
        Dim llamadoRemision As New connection
        Dim consulta As New MySqlCommand("SELECT encargadoD FROM `destinatarios_remitentes` ", llamadoRemision.conexion)
        llamadoRemision.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                comboDestinatarioR.Items.Add(leer("encargadoD"))
                comboCodigoArticulo.Items.Add(leer("encargadoD"))

            End While
        End If
        llamadoRemision.CerrarConexion()

        lblNumeroRemision.Text = traerId() + 1
        lblFechaDest.Text = InventarioSH.labelFecha.Text + ",  " + InventarioSH.labelHora.Text


    End Sub

    Private Sub BtnActualizarItem_Click(sender As Object, e As EventArgs) Handles btnActualizarItem.Click

        Dim llamado As New connection

        If txtEditarOficina.Text <> "" And txtEditarEncargado.Text <> "" And txtEditarCuidar.Text <> "" And txtEditarDireccion.Text <> "" And txtEditarCelular.Text <> "" And txtEditarCargo.Text <> "" Then

            Dim comando As New MySqlCommand("UPDATE `destinatarios_remitentes` SET `oficinaDestinatario`='" & txtEditarOficina.Text & "',`encargadoD`='" & txtEditarEncargado.Text & "',`departamentoYciudad`='" & txtEditarCuidar.Text & "',`direccionDest`='" & txtEditarDireccion.Text & "',`celularDestinatario`='" & txtEditarCelular.Text & "',`cargo`='" & txtEditarCargo.Text & "',`fechaIngresoD`=CURRENT_TIMESTAMP where idDestinatario=" & lblIdInvisible.Text, llamado.conexion)
            llamado.AbrirConexion()
            comando.ExecuteNonQuery()

            MsgBox("DATOS MODIFICADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

            txtEditarOficina.Text = ""
            txtEditarEncargado.Text = ""
            txtEditarCuidar.Text = ""
            txtEditarDireccion.Text = ""
            txtEditarCelular.Text = ""
            txtEditarCargo.Text = ""

            llamado.CerrarConexion()
            llamado.llenarDataGrid(DataGridMov)
        Else
            MsgBox("Todos los campos deben ser debidamente diligenciados")
            txtEditarOficina.Focus()
        End If

        comboDestinatarioR.Items.Clear()
        comboCodigoArticulo.Items.Clear()
        Dim llamadoRemision As New connection
        Dim consulta As New MySqlCommand("SELECT encargadoD FROM `destinatarios_remitentes` ", llamadoRemision.conexion)
        llamadoRemision.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                comboDestinatarioR.Items.Add(leer("encargadoD"))
                comboCodigoArticulo.Items.Add(leer("encargadoD"))

            End While
        End If
        llamadoRemision.CerrarConexion()

        lblNumeroRemision.Text = traerId() + 1
        lblFechaDest.Text = InventarioSH.labelFecha.Text + ",  " + InventarioSH.labelHora.Text

    End Sub
    Private Sub ButtonInsertarND_Click(sender As Object, e As EventArgs) Handles ButtonInsertarND.Click

        Dim llamado As New connection

        If txtEditarOficina.Text <> "" And txtEditarEncargado.Text <> "" And txtEditarCuidar.Text <> "" And txtEditarDireccion.Text <> "" And txtEditarCelular.Text <> "" And txtEditarCargo.Text <> "" Then

            Dim comando As New MySqlCommand("INSERT INTO `destinatarios_remitentes` VALUES (null, '" & txtEditarOficina.Text & "','" & txtEditarEncargado.Text & "','" & txtEditarCuidar.Text & "','" & txtEditarDireccion.Text & "','" & txtEditarCelular.Text & "','" & txtEditarCargo.Text & "', CURRENT_TIMESTAMP)", llamado.conexion)

            llamado.AbrirConexion()
            comando.ExecuteNonQuery()

            MsgBox("DATOS GUARDADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

            txtEditarOficina.Text = ""
            txtEditarEncargado.Text = ""
            txtEditarCuidar.Text = ""
            txtEditarDireccion.Text = ""
            txtEditarCelular.Text = ""
            txtEditarCargo.Text = ""

            llamado.CerrarConexion()
            llamado.llenarDataGrid(DataGridMov)
        Else
            MsgBox("TODOS LOS CAMPOS DEBEN SER DEBIDAMENTE DILIGENCIADOS", MsgBoxStyle.Exclamation, "AVISO")
            txtEditarOficina.Focus()
        End If

        comboDestinatarioR.Items.Clear()
        comboCodigoArticulo.Items.Clear()
        Dim llamadoRemision As New connection
        Dim consulta As New MySqlCommand("SELECT encargadoD FROM `destinatarios_remitentes` ", llamadoRemision.conexion)
        llamadoRemision.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                comboDestinatarioR.Items.Add(leer("encargadoD"))
                comboCodigoArticulo.Items.Add(leer("encargadoD"))

            End While
        End If
        llamadoRemision.CerrarConexion()

        lblNumeroRemision.Text = traerId() + 1
        lblFechaDest.Text = InventarioSH.labelFecha.Text + ",  " + InventarioSH.labelHora.Text

    End Sub

    Private Sub RadioButtonEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEliminar.CheckedChanged
        btnActualizarItem.Enabled = False
        ButtonInsertarND.Enabled = False
        btnEliminarRe.Enabled = True
    End Sub

    Private Sub RadioButtonModificar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonModificar.CheckedChanged
        ButtonInsertarND.Enabled = False
        btnEliminarRe.Enabled = False
        btnActualizarItem.Enabled = True
    End Sub

    Private Sub RadioButtonInsertarND_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInsertarND.CheckedChanged
        btnEliminarRe.Enabled = False
        btnActualizarItem.Enabled = False
        ButtonInsertarND.Enabled = True
        If RadioButtonInsertarND.Checked = True Then
            txtEditarOficina.Text = ""
            txtEditarEncargado.Text = ""
            txtEditarCuidar.Text = ""
            txtEditarDireccion.Text = ""
            txtEditarCelular.Text = ""
            txtEditarCargo.Text = ""
        End If
    End Sub

    Shared Function Imagen_Bytes(ByVal Foto As Image) As Byte()
        If Not Foto Is Nothing Then
            Dim Codi As New IO.MemoryStream
            Foto.Save(Codi, Imaging.ImageFormat.Jpeg)
            Return Codi.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Private Sub BtnGuardarReporte_Click(sender As Object, e As EventArgs) Handles btnGuardarReporte.Click

        Try


            If lblParaDestinatario.Text <> "" And lblEncargadoDest.Text <> "" And lblOficinaDest.Text <> "" And lblDeRemit.Text <> "" And comboCodigoArticulo.SelectedItem <> "" And
                comboDestinatarioR.Text <> "Seleccionar" Or comboCodigoArticulo.Text <> "Seleccionar" And lblCargoRemit.Text <> "" And lblOficinaDest.Text <> "" And LabelElemento.Text <> "" Then

                'este metodo crea una carpeta en documentos
                Dim CarpetaDestino As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\imagenBD"
                MsgBox("Se almacenara en la ruta.. " & CarpetaDestino, MsgBoxStyle.Information, "INFORMACION")



                Try
                    ':::Validamos si la carpeta existe
                    If My.Computer.FileSystem.DirectoryExists(CarpetaDestino) Then

                        'este metodo se utiliza para modificar el tamaño del panel a guardar
                        bmp = New Bitmap(PanelVista.Width, PanelVista.Height)
                        Dim G As Graphics = Graphics.FromImage(bmp)
                        PanelVista.DrawToBitmap(bmp, PanelVista.ClientRectangle)


                        'Guardamos el mapa de bits como archivo JPEG.

                        bmp.Save(CarpetaDestino & "\Form.jpg", Imaging.ImageFormat.Jpeg)
                        bmp.Dispose()


                    Else
                        'Si la carpeta no existe la creamos
                        My.Computer.FileSystem.CreateDirectory(CarpetaDestino)

                        'este metodo se utiliza para modificar el tamaño del panel a guardar
                        bmp = New Bitmap(PanelVista.Width, PanelVista.Height)
                        Dim G As Graphics = Graphics.FromImage(bmp)
                        PanelVista.DrawToBitmap(bmp, PanelVista.ClientRectangle)


                        ' Guardamos el mapa de bits como archivo JPEG.

                        bmp.Save(CarpetaDestino & "\Form.jpg", Imaging.ImageFormat.Jpeg)
                        bmp.Dispose()

                    End If
                Catch ex As Exception
                    MsgBox("Error al realizar el proceso debido a: " & ex.Message)
                End Try

                Dim concatenarserial As String = ""


                Dim j, r As Integer
                Dim concatenararticulo As String = ""
                Dim concatenararticuloH As String = ""
                Dim concatenararticuloA As String = ""
                Dim llamadoarticulo As New connection

                r = 0
                Dim flag As String = 0


                Dim consultaarticuloH As New MySqlCommand("select tipoArticuloH from inventariohardware where codigoArticuloH='" & comboCodigoArticulo.SelectedItem & "' or serialArticuloSoft='" & comboCodigoArticulo.SelectedItem & "'", llamadoarticulo.conexion)
                llamadoarticulo.AbrirConexion()
                        Dim leer0 As MySqlDataReader = consultaarticuloH.ExecuteReader()
                        If leer0.Read Then
                            concatenararticuloH = concatenararticuloH + " " + leer0(0)
                        End If
                        llamadoarticulo.CerrarConexion()

                Dim consultaarticuloA As New MySqlCommand("select articuloA from inventarioactivos where serialMovilco='" & comboCodigoArticulo.SelectedItem & "' or serialArticuloA='" & comboCodigoArticulo.SelectedItem & "'", llamadoarticulo.conexion)
                llamadoarticulo.AbrirConexion()
                        Dim leer1 As MySqlDataReader = consultaarticuloA.ExecuteReader()
                        If leer1.Read Then
                            concatenararticuloA = concatenararticuloA + " " + leer1(0)
                        End If
                        llamadoarticulo.CerrarConexion()


                If concatenararticuloH <> "" Then
                    concatenararticulo = concatenararticuloH
                    flag = "SISTEMAS"
                ElseIf concatenararticuloA <> "" Then

                    concatenararticulo = concatenararticuloA
                    flag = "ACTIVOS"
                End If

                Dim llamado As New connection

                Dim comando As New MySqlCommand("INSERT INTO `registrosremisiones` (`idRegistroR`, `idDestinatario`, flag, serialR, articuloR, `destinatarioR`, `remitenteR`, `observacionesR`,`imagenes`,`fechaR`) VALUES
(null,'" & lblOcultoId.Text & "','" & flag & "','" & concatenarserial & "', '" & concatenararticulo & "','" & lblParaDestinatario.Text & "', '" & lblDeRemit.Text & "','" & TextBoxObserv.Text & "',?imagen, CURRENT_TIMESTAMP)", llamado.conexion)


                Dim fs As New FileStream(CarpetaDestino & "\Form.jpg", FileMode.Open, FileAccess.Read)

                Dim imag = Image.FromStream(fs)

                comando.Parameters.AddWithValue("?imagen", Imagen_Bytes(imag))

                llamado.AbrirConexion()

                comando.ExecuteNonQuery()

                llamado.CerrarConexion()
                llamado.llenarDataGrid(DataGridMov)
                lblNumeroRemision.Text = traerId() + 1


                imag.Dispose()
                fs.Dispose()

                Try

                    Dim datos As New connection
                    Dim consultaa As New MySqlCommand("update inventariohardware set oficinaH='" & lblOficinaDest.Text & "' 
WHERE codigoArticuloH='" & comboCodigoArticulo.SelectedItem & "' or serialArticuloSoft='" & comboCodigoArticulo.SelectedItem & "'", datos.conexion)
                    datos.AbrirConexion()
                    consultaa.ExecuteNonQuery()
                    datos.CerrarConexion()



                    Dim datos1 As New connection
                    Dim consultaa1 As New MySqlCommand("update inventarioactivos set oficinaG='" & lblOficinaDest.Text & "' 
WHERE serialMovilco='" & comboCodigoArticulo.SelectedItem & "' or serialArticuloA='" & comboCodigoArticulo.SelectedItem & "'", datos1.conexion)
                    datos1.AbrirConexion()
                    consultaa1.ExecuteNonQuery()
                    datos1.CerrarConexion()

                Catch ex1 As Exception
                    MsgBox("ERROR EN CONEXION A BASE DE DATOS", MsgBoxStyle.Critical, "INFORMACION")
                End Try

                comboCodigoArticulo.Text = "Seleccionar"
                comboDestinatarioR.Text = "Seleccionar"
                comboCodigoArticulo.Text = "Seleccionar"

                lblParaDestinatario.Text = ""
                lblEncargadoDest.Text = ""
                lblOficinaDest.Text = ""
                lblDireccionDest.Text = ""
                lblCyD.Text = ""
                lblTelef.Text = ""

                lblDeRemit.Text = ""
                lblCargoRemit.Text = ""
                lblOficinaRemit.Text = ""
                lblDireccionRemit.Text = ""
                lblCelularRemit.Text = ""
                TextBoxObserv.Text = ""
                LabelElemento.Visible = False
                tabMovimientosR.Text = "DESTINATARIOS"
                tabRemisiones.Text = "REMISIONES"
                TabPageMostrarR.Text = "MOSTRAR REMISIONES"

                LabelElemento.Text = ""

                'llamando al loading

                Loading.Show()
                Loading.TimerLoading.Start()

                ' se utiliza para limpiar lo que esta seleccionado en el listbox luego de guardar los datos.
                comboCodigoArticulo.Items.Clear()


            Else

                If comboCodigoArticulo.Text = "Seleccionar" Or comboDestinatarioR.Text = "Seleccionar" Or comboCodigoArticulo.Text = "Seleccionar" Then

                    MsgBox("ELIJA UN ITEM VALIDO")
                Else
                    MsgBox("NO HAY DATOS PARA ALMACENAR", MsgBoxStyle.Information, "INFORMACIÓN")
                End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub ButtonDescargarIMG_Click(sender As Object, e As EventArgs) Handles ButtonDescargarIMG.Click


        If PictureBoxMostrarI.Image Is Nothing Then

            MsgBox("ELIJA UNA IMAGEN", MsgBoxStyle.Information, "Aviso")
            TextBoxMostrarImg.Focus()
        Else
            Dim b As Bitmap = Me.PictureBoxMostrarI.Image

            Dim objSFD As New SaveFileDialog
            objSFD.Filter = "(*.png )|.png|(*.jpeg)|.jpg|(*.gif)|.gif|(*.pdf)|.pdf|(*.svg)|.svg|(*.*)|.*.*"
            objSFD.InitialDirectory = "C: \"
            objSFD.Title = "Guardar imagen en ..."


            If objSFD.ShowDialog = DialogResult.OK Then

                b.Save(objSFD.FileName, Imaging.ImageFormat.Png)
                b = Nothing
                GC.Collect()

                'llamando al loading
                Loading.Show()
                Loading.TimerLoading.Start()
            Else
                MsgBox("ARCHIVO NO ALMACENADO", MsgBoxStyle.Critical, "ADVERTENCIA")
            End If
            '  PictureBoxMostrarI.Image = Nothing
            'ButtonDescargarIMG.Enabled = False

        End If

    End Sub

    Private Sub ButtonMostrarR_Click(sender As Object, e As EventArgs) Handles ButtonMostrarR.Click

        Try
            'funcion creada para contar la cantidad de id que haya en la tabla registrosremisiones

            Dim numero0 As String = 0
            Dim llamado As New connection
            llamado.AbrirConexion()
            Dim consulta As New MySqlCommand("Select  COUNT(`idRegistroR`) FROM `registrosremisiones`", llamado.conexion)
            Dim leer As MySqlDataReader = consulta.ExecuteReader()
            If leer.Read Then
                numero0 = leer(0)
                ' MsgBox(numero0)
            End If

            llamado.CerrarConexion()

            If TextBoxMostrarImg.Text < 1 Or TextBoxMostrarImg.Text > numero0 Then

                MsgBox("ID DE REMISION NO EXISTENTE", MsgBoxStyle.Critical, "AVISO")
                TextBoxMostrarImg.Focus()

            Else

                Dim prueba As New connection
                Dim c As New MySqlCommand("select imagenes from registrosremisiones where idRegistroR='" & TextBoxMostrarImg.Text & "'", prueba.conexion)
                prueba.AbrirConexion()
                Dim dt As New DataTable
                Dim dp As New MySqlDataAdapter(c)

                'Llenamos el objeto datatable con Fill
                dp.Fill(dt)
                Dim myRow As DataRow = dt.Rows(0)

                Dim MyData As Byte() = DirectCast(myRow("imagenes"), Byte())

                Dim Stream = New MemoryStream(MyData)
                PictureBoxMostrarI.Image = Image.FromStream(Stream)


                prueba.CerrarConexion()
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message)
            MsgBox("ELIJA UN NUMERO DE REMISION", MsgBoxStyle.Exclamation, "AVISO")
            TextBoxMostrarImg.Focus()
        End Try


    End Sub

    Private Sub TextBoxMostrarImg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMostrarImg.KeyPress
        'metodo para evitar que se ingresen letras pero que se puedan borrar los numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If
    End Sub

    Private Sub ButtonImprimirFoto_Click(sender As Object, e As EventArgs) Handles ButtonImprimirFoto.Click

        If PictureBoxMostrarI.Image Is Nothing Then


            MsgBox("ELIJA UNA IMAGEN", MsgBoxStyle.Information, "Aviso")
            TextBoxMostrarImg.Focus()

        Else


            TextBoxMostrarImg.Focus()

            With PrintForm1
                Try
                    'metodo para imprimir la foto del picture en MOSTRAR REMISIONES
                    If PrintDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                        PrintDocument1.Print()
                    Else
                        MsgBox("IMPRESION INTERRUMPIDA", MsgBoxStyle.Critical, "ADVERTENCIA")
                    End If

                Catch ex As Exception
                    MsgBox("ESTABLECER UNA IMPRESORA COMO PREDETERMINADA")
                End Try

                LabelNumeroRemision.Visible = True
                TextBoxMostrarImg.Visible = True
                ButtonMostrarR.Visible = True
                ButtonDescargarIMG.Visible = True
                ButtonImprimirFoto.Visible = True


            End With

            LabelNumeroRemision.Visible = True
            TextBoxMostrarImg.Visible = True
            ButtonMostrarR.Visible = True
            ButtonDescargarIMG.Visible = True
            ButtonImprimirFoto.Visible = True

            TextBoxCantidadR.Visible = True
        End If



    End Sub

    Private Sub ComboBoxArticulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Dim cerrar = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'If cerrar = 0 Then
        '    ListBoxArticulos.Visible = True
        '    cerrar = 1
        'Else
        '    ListBoxArticulos.Visible = False
        '    cerrar = 0
        'End If


    End Sub

    Private Sub Reportes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        'Aquí crea tus controles.
        Me.ResumeLayout()
    End Sub


    'Private Sub PanelVista_Paint(sender As Object, e As PaintEventArgs) Handles PanelVista.Paint
    '    Remision.TopLevel = False
    '    Remision.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    '    Remision.Dock = DockStyle.Fill
    '    PanelVista.Controls.Add(Remision)
    '    Remision.Show()
    'End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PictureBoxMostrarI.Image, 10, 20, 500, 500) 'PB1 ES EL NOMBRE DEL PICTUREBOX

    End Sub

    Private Sub PrintDocument22_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument22.PrintPage
        e.Graphics.DrawImage(bmp, 10, 20, 500, 500)

    End Sub

    Private Sub TabPageMostrarR_MouseClick(sender As Object, e As MouseEventArgs) Handles TabPageMostrarR.MouseClick
        TextBoxMostrarImg.Focus()
    End Sub

    Private Sub RadioSistemas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSistemas.CheckedChanged

        Dim llamadoHardware As New connection
            comboCodigoArticulo.Items.Clear()
        If RadioSistemas.Checked = True Then
            Dim consultaHardware As New MySqlCommand("SELECT codigoArticuloH, serialArticuloSoft FROM inventariohardware ", llamadoHardware.conexion)
            llamadoHardware.AbrirConexion()
            Dim leerHardware As MySqlDataReader = consultaHardware.ExecuteReader()

            If leerHardware.HasRows Then
                While leerHardware.Read

                    comboCodigoArticulo.Items.Add(leerHardware("codigoArticuloH"))
                    comboCodigoArticulo.Items.Add(leerHardware("serialArticuloSoft"))

                End While

            End If
            comboCodigoArticulo.Text = comboCodigoArticulo.Items.Item(0)
        End If
        llamadoHardware.CerrarConexion()



    End Sub

    Private Sub RadioActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioActivos.CheckedChanged

        Dim llamadoActivos As New connection
            comboCodigoArticulo.Items.Clear()
        If RadioActivos.Checked = True Then
            Dim consultaActivos As New MySqlCommand("SELECT serialMovilco,serialArticuloA FROM inventarioactivos", llamadoActivos.conexion)
            llamadoActivos.AbrirConexion()
            Dim leerActivos As MySqlDataReader = consultaActivos.ExecuteReader()

            If leerActivos.HasRows Then
                While leerActivos.Read

                    comboCodigoArticulo.Items.Add(leerActivos("serialMovilco"))
                    comboCodigoArticulo.Items.Add(leerActivos("serialArticuloA"))

                End While
            End If
            comboCodigoArticulo.Text = comboCodigoArticulo.Items.Item(0)
        End If
        llamadoActivos.CerrarConexion()




    End Sub




    Private Sub TextBoxMostrarImg_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxMostrarImg.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                'funcion creada para contar la cantidad de id que haya en la tabla registrosremisiones

                Dim numero0 As String = 0
                Dim llamado As New connection
                llamado.AbrirConexion()
                Dim consulta As New MySqlCommand("Select  COUNT(`idRegistroR`) FROM `registrosremisiones`", llamado.conexion)
                Dim leer As MySqlDataReader = consulta.ExecuteReader()
                If leer.Read Then
                    numero0 = leer(0)
                    ' MsgBox(numero0)
                End If

                llamado.CerrarConexion()

                If TextBoxMostrarImg.Text < 1 Or TextBoxMostrarImg.Text > numero0 Then

                    MsgBox("ID DE REMISION NO EXISTENTE", MsgBoxStyle.Critical, "AVISO")
                    TextBoxMostrarImg.Focus()

                Else

                    Dim prueba As New connection
                    Dim c As New MySqlCommand("select imagenes from registrosremisiones where idRegistroR='" & TextBoxMostrarImg.Text & "'", prueba.conexion)
                    prueba.AbrirConexion()
                    Dim dt As New DataTable
                    Dim dp As New MySqlDataAdapter(c)

                    'Llenamos el objeto datatable con Fill
                    dp.Fill(dt)
                    Dim myRow As DataRow = dt.Rows(0)

                    Dim MyData As Byte() = DirectCast(myRow("imagenes"), Byte())

                    Dim Stream = New MemoryStream(MyData)
                    PictureBoxMostrarI.Image = Image.FromStream(Stream)


                    prueba.CerrarConexion()
                End If

            Catch ex As Exception
                ' MsgBox(ex.Message)
                MsgBox("ELIJA UN NUMERO DE REMISION", MsgBoxStyle.Exclamation, "AVISO")

            End Try


        End If
        TextBoxMostrarImg.Focus()
    End Sub

    Private Sub ButtonExp_Click(sender As Object, e As EventArgs) Handles ButtonExp.Click
        Try
            If ((DataGridMov.Columns.Count = 0) Or (DataGridMov.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creando Dataset para Exportar
            Dim dset As New DataSet
            'Agregar tabla al Dataset
            dset.Tables.Add()
            'AGregar Columna a la tabla
            For i As Integer = 0 To DataGridMov.ColumnCount - 1
                dset.Tables(0).Columns.Add(DataGridMov.Columns(i).HeaderText)
            Next
            'Agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To DataGridMov.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To DataGridMov.Columns.Count - 1
                    dr1(j) = DataGridMov.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim aplicacion As New Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = aplicacion.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                aplicacion.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

                Next
            Next
            'Configurar la orientacion de la  hoja y el tamaño
            ''''''''' wSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
            ''''''  wSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLegal
            'Configurar con negrilla la cabecera y tenga autofit
            wSheet.Rows.Item(1).Font.Bold = 1
            wSheet.Columns.AutoFit()

            'este metodo crea una carpeta en documentos
            Dim strFileName As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ExportadoMovilco"
            '  Dim strFileName As String = "C:\Users\CVR\Desktop\Reporte .xlsx"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If
            MessageBox.Show("DOCUMENTO EXPORTADO CORRECTAMENTE.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            wBook.SaveAs(strFileName)
            aplicacion.Workbooks.Open(strFileName)
            aplicacion.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "INVENTARIO MOVILCO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBoxRemitentes_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxRemitentes.SelectedValueChanged
        'Se creara el codigo para que dependiendo del item seleccionado se llenen los campos de reportes o remision

        Dim llamado As New connection
        Dim consulta As New MySqlCommand("SELECT * FROM `destinatarios_remitentes` WHERE encargadoD='" & ComboBoxRemitentes.SelectedItem & "' ", llamado.conexion)
        llamado.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()

        If leer.Read Then

            lblDeRemit.Text = leer(2)
            lblCargoRemit.Text = leer(6)
            lblOficinaRemit.Text = leer(3)
            lblDireccionRemit.Text = leer(4)
            lblCelularRemit.Text = leer(5)



        End If

        llamado.CerrarConexion()
    End Sub


End Class