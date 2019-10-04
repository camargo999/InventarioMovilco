Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports System.IO

Public Class InventarioHardware

    Public Function AutoCompletarGlobal(ByVal Control As TextBox, ByVal item As String) As AutoCompleteStringCollection


        Dim auto4 As New AutoCompleteStringCollection
        Dim comando4 As String

        comando4 = "SELECT " & item & " FROM `inventariohardware`"
        Dim llamado04 As New connection
        Dim consulta04 As New MySqlCommand(comando4, llamado04.conexion)
        llamado04.AbrirConexion()

        Dim lector04 As MySqlDataReader = consulta04.ExecuteReader()

        While lector04.Read()

            auto4.AddRange(New String() {lector04(0)})

        End While
        lector04.Close()
        llamado04.conexion.Close()
        With Control
            .AutoCompleteMode = AutoCompleteMode.Suggest

            .AutoCompleteSource = AutoCompleteSource.CustomSource

            .AutoCompleteCustomSource = auto4

        End With
        Return auto4
        llamado04.conexion.Close()
    End Function
    Sub cargarcombooficinasIS()
        Dim llamado As New connection
        Dim consulta As New MySqlCommand("Select oficinaCoordinador from coordinadores", llamado.conexion)
        llamado.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                ComboBoxOf.Items.Add(leer("oficinaCoordinador"))

            End While
        End If
        llamado.CerrarConexion()
    End Sub
    Private Sub InventarioHardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TextBoxNumFac.Focus()
        cargarcombooficinasIS()

        AutoCompletarGlobal(Me.txtCodigoH, "codigoArticuloH")
        AutoCompletarGlobal(Me.txtTipoArticulo, "tipoArticuloH")

        AutoCompletarGlobal(Me.txtMarcaArticuloH, "marcaArticuloH")
        AutoCompletarGlobal(Me.txtTonnerH, "tonnerH")
        AutoCompletarGlobal(Me.txtSistemaOP, "sistemaOperativo")
        AutoCompletarGlobal(Me.txtMicrosoftOf, "mOffice")
        AutoCompletarGlobal(Me.txtHclient, "hClient")
        AutoCompletarGlobal(Me.txtCodigoSOFT, "serialArticuloSoft")

        AutoCompletarGlobal(Me.txtCapacidadDDH, "capacidadDdH")
        AutoCompletarGlobal(Me.txtMemoriaRamH, "memoriaRamH")
        AutoCompletarGlobal(Me.txtEstadoArticulo, "estadoArticuloH")
        AutoCompletarGlobal(Me.txtScreenV, "screemView")
        AutoCompletarGlobal(Me.txtSicacom, "sicacomVPN")
        AutoCompletarGlobal(Me.txtAdobePDF, "adobePDF")
        AutoCompletarGlobal(Me.txtDopBox, "dropBox")
        AutoCompletarGlobal(Me.txtAreaSoft, "areaSoft")
        AutoCompletarGlobal(Me.txtAdminT, "adminTurno")
        AutoCompletarGlobal(Me.txtRR, "rrVpnFijo")
        AutoCompletarGlobal(Me.txtCorreoE, "correoElectronico")
        AutoCompletarGlobal(Me.txtDemo, "numeroDemo")
        AutoCompletarGlobal(Me.txtAnyDesk, "anyDesk")

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

    Function IdFactura()
        'CONSULTA UTILIZADA PARA TRAER EL IDMAXIMO DE LA TABLA DETALLES FACTURA Y ANEXARLO A LA INSERCION DEL INVENTARIO HARDWARE.
        Dim id As String = ""
        Dim llamado1 As New connection
        Dim cmd As New MySqlCommand("Select NoFactura from detalle_factura where IdFactura=(select max(IdFactura) from detalle_factura)", llamado1.conexion)
        llamado1.AbrirConexion()
        Dim leerconsulta As MySqlDataReader = cmd.ExecuteReader()
        If leerconsulta.Read Then
            id = leerconsulta(0).ToString
        End If
        llamado1.CerrarConexion()

        Return id
    End Function
    Function validarfacturarepetida()
        Dim validadorFactura As Integer
        validadorFactura = 0
        Dim llamadoValidarFactura As New connection
        Dim consultaValidarFactura As New MySqlCommand("Select * from detalle_factura where NoFactura='" & TextBoxNumFac.Text & "'", llamadoValidarFactura.conexion)
        llamadoValidarFactura.AbrirConexion()
        Dim leerValidarSerial As MySqlDataReader = consultaValidarFactura.ExecuteReader()
        If leerValidarSerial.Read Then
            validadorFactura = 1
        End If
        llamadoValidarFactura.CerrarConexion()
        Return validadorFactura
    End Function
    Function valorUnitario()
        Dim cont As Integer = TextBoxCantid.Text
        Dim cadenaVUnitario As String = 0
        For a = 0 To (cont - 1) Step 1
            cadenaVUnitario += Convert.ToString(dataGridViewCencepto.Rows(a).Cells(1).Value) & vbCrLf

        Next
        Return (cadenaVUnitario)
    End Function

    Function concepto()
        Dim cont As Integer = TextBoxCantid.Text
        Dim cadenaArticulo As String = ""
        For a = 0 To (cont - 1) Step 1
            cadenaArticulo += Convert.ToString(dataGridViewCencepto.Rows(a).Cells(0).Value) & vbCrLf

        Next
        Return (cadenaArticulo)

    End Function

    Public contador As Integer = 0

    Private Sub BtnGuardarH_Click(sender As Object, e As EventArgs) Handles btnGuardarH.Click
        If cantidadArticulos > 0 Then

            GroupBoxDetalles.Enabled = False
            ButtonImp.Enabled = False
            ButtonImprimirF.Enabled = False


        End If
        cantidadArticulos += -1
        Try
            Dim validador, validador2 As Integer


            If validador = 0 And validador2 = 0 Then



                If txtCapacidadDDH.Text <> "" And txtRR.Text <> "" And txtCorreoE.Text <> "" And txtDemo.Text <> "" And txtAnyDesk.Text <> "" And txtAdminT.Text <> "" And
                    txtAdobePDF.Text <> "" And txtSicacom.Text <> "" And txtScreenV.Text <> "" And txtCodigoSOFT.Text <> "" And txtAreaSoft.Text <> "" And txtDopBox.Text <> "" And
                    txtHclient.Text <> "" And txtMicrosoftOf.Text <> "" And txtSistemaOP.Text <> "" And txtCodigoH.Text <> "" And
                    txtEstadoArticulo.Text <> "" And txtMarcaArticuloH.Text <> "" And ComboBoxOf.Text <> "" And txtTipoArticulo.Text <> "" And txtTonnerH.Text <> "" And
                    txtMemoriaRamH.Text <> "" And ComboBoxIS.Text <> "SELECCIONAR" And ComboBoxOf.Text <> "SELECCIONAR OFICINA" And TextBoxNumFac.Text <> "" And TextBoxCantid.Text <> "" And
                    TextBoxVend.Text <> "" Then



                    If contador = 0 Then
                        contador = TextBoxCantid.Text
                    End If

                    Dim llamado0 As New connection

                        Dim consultaConcepto As String = concepto().ToString
                        Dim consultaVUnitario As String = valorUnitario()



                        Dim consult0 As New MySqlCommand("INSERT INTO `detalle_factura`(`IdFactura`,`NoFactura`, `Concepto`, `ValorUnitario`, `ValorTotal`, `CantidadTotal`, `Proveedor`, `FechaCompra`,`factura`) VALUES 
(null,'" & TextBoxNumFac.Text & "','" & consultaConcepto & "','" & consultaVUnitario & "','" & labelValor.Text & "','" & TextBoxCantid.Text & "','" & TextBoxVend.Text.ToUpper & "','" & DateTimePickerFC.Value.ToLongDateString & "',?imagen)", llamado0.conexion)
                        llamado0.AbrirConexion()

                        consult0.Parameters.AddWithValue("?imagen", Imagen_Bytes(Me.PictureBoxFactura.Image))

                        If contador = TextBoxCantid.Text Then
                            consult0.ExecuteNonQuery()

                        End If

                        Dim consulta0 As New MySqlCommand("INSERT INTO `inventariohardware` VALUES (null,'" & IdFactura() & "','" + txtCodigoH.Text + "', '" + txtTipoArticulo.Text + "', '" + ComboBoxOf.SelectedItem + "',
'" + txtMarcaArticuloH.Text + "','" + txtTonnerH.Text + "','" + txtCapacidadDDH.Text + "','" + txtMemoriaRamH.Text + "','" + txtEstadoArticulo.Text + "',
'" + txtSistemaOP.Text + "','" + txtMicrosoftOf.Text + "','" + txtHclient.Text + "','" + txtDopBox.Text + "','" + txtAreaSoft.Text + "','" + txtCodigoSOFT.Text + "',
'" + txtScreenV.Text + "','" + txtSicacom.Text + "','" + txtAdobePDF.Text + "','" + txtAdminT.Text + "','" + txtRR.Text + "','" + txtCorreoE.Text + "','" + txtDemo.Text + "',
'" + txtAnyDesk.Text + "','" + ComboBoxIS.SelectedItem + "','" + RichTextBox1.Text + "', '" + labelNombreH.Text + "', CURRENT_TIMESTAMP)", llamado0.conexion)

                        consulta0.ExecuteNonQuery()
                        MsgBox("DATOS GUARDADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

                        ComboBoxIS.Text = "SELECCIONAR"
                        ComboBoxOf.Text = "SELECCIONAR OFICINA"
                        txtCapacidadDDH.Text = ""
                        txtCodigoH.Text = ""

                        txtEstadoArticulo.Text = ""
                        txtMarcaArticuloH.Text = ""
                        ' txtOficina.Text = ""
                        txtTipoArticulo.Text = ""
                        txtTonnerH.Text = ""
                        txtMemoriaRamH.Text = ""

                        RichTextBox1.Text = ""

                        txtSistemaOP.Text = ""
                        txtMicrosoftOf.Text = ""
                        txtHclient.Text = ""
                        txtDopBox.Text = ""
                        txtAreaSoft.Text = ""
                        txtCodigoSOFT.Text = ""
                        txtScreenV.Text = ""
                        txtSicacom.Text = ""
                        txtAdobePDF.Text = ""
                        txtAdminT.Text = ""

                        txtRR.Text = ""
                        txtCorreoE.Text = ""
                        txtDemo.Text = ""
                        txtAnyDesk.Text = ""

                        txtCodigoH.Focus()

                        If contador = 1 Then
                            TextBoxNumFac.Text = ""
                            TextBoxCantid.Text = ""
                            TextBoxVend.Text = ""

                            GroupBoxDetalles.Enabled = True
                            ButtonImp.Enabled = True
                            ButtonImprimirF.Enabled = True
                            dataGridViewCencepto.Rows.Clear()
                            TextBoxNumFac.Focus()

                        End If


                        contador = contador - 1
                        llamado0.conexion.Close()

                    ElseIf ComboBoxIS.Text = "SELECCIONAR" Or ComboBoxOf.Text = "SELECCIONAR OFICINA" Then

                        MsgBox("DEBE SELECCIONAR UN ITEM VALIDO.", MsgBoxStyle.Information, "INFORMACION")

                    Else
                        MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS", MsgBoxStyle.Information, "INFORMACION")
                    txtCodigoH.Focus()
                End If


            ElseIf validador = 1 Then
                MsgBox("Uno o los dos seriales ya estan registrados en la base de datos.")
            ElseIf validador2 = 1 Then
                MsgBox("La factura de venta No." + TextBoxNumFac.Text + " ya existe.")
            End If

        Catch ex As Exception
            MsgBox("ERROR DE CONEXION " + ex.Message)
        End Try

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        labelNombreH.Text = InventarioSH.Label3.Text
    End Sub

    Private Sub BtnLimpiarHard_Click(sender As Object, e As EventArgs) Handles btnLimpiarHard.Click


        txtCapacidadDDH.Text = ""
        txtCodigoH.Text = ""

        txtEstadoArticulo.Text = ""
        txtMarcaArticuloH.Text = ""
        ' txtOficina.Text = ""
        txtTipoArticulo.Text = ""
        txtTonnerH.Text = ""
        txtMemoriaRamH.Text = ""

        RichTextBox1.Text = ""

        txtSistemaOP.Text = ""
        txtMicrosoftOf.Text = ""
        txtHclient.Text = ""
        txtDopBox.Text = ""
        txtAreaSoft.Text = ""
        txtCodigoSOFT.Text = ""
        txtScreenV.Text = ""
        txtSicacom.Text = ""
        txtAdobePDF.Text = ""
        txtAdminT.Text = ""

        txtRR.Text = ""
        txtCorreoE.Text = ""
        txtDemo.Text = ""
        txtAnyDesk.Text = ""

        txtCodigoH.Focus()

    End Sub

    Private Sub RichTextBox1_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.Enter
        PictureBoxColor.Visible = True
    End Sub

    Private Sub RichTextBox1_Leave(sender As Object, e As EventArgs) Handles RichTextBox1.Leave
        PictureBoxColor.Visible = False
    End Sub

    Private Sub TxtCodigoH_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoH.TextChanged
        'AutoCompletar(Me.txtCodigoH)
    End Sub

    Private Sub TxtCodigoH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoH.KeyPress
        'aqui deberia dejar borrar cuando ingreso un codigo mal
        If (e.KeyChar = ChrW(Keys.Space) And txtCodigoH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("+{TAB}")

        End If
    End Sub

    Private Sub TxtTipoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoArticulo.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtTipoArticulo.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtOficina_KeyPress(sender As Object, e As KeyPressEventArgs)
        'If (e.KeyChar = ChrW(Keys.Space) And txtOficina.Text = "") Then
        '    e.Handled = True
        'End If
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    SendKeys.Send("{TAB}")

        'End If
    End Sub

    Private Sub TxtMarcaArticuloH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarcaArticuloH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtMarcaArticuloH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtTonnerH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTonnerH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtTonnerH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtSistemaOP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSistemaOP.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtSistemaOP.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtMicrosoftOf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMicrosoftOf.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtMicrosoftOf.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtHclient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHclient.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtHclient.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtCodigoSOFT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoSOFT.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtCodigoSOFT.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    'Private Sub TxtDependenciaH_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = ChrW(Keys.Space) And txtDependenciaH.Text = "") Then
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        SendKeys.Send("{TAB}")

    '    End If
    'End Sub

    Private Sub TxtCapacidadDDH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacidadDDH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtCapacidadDDH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtMemoriaRamH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemoriaRamH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtMemoriaRamH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtEstadoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoArticulo.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtEstadoArticulo.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtScreenV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScreenV.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtScreenV.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtSicacom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSicacom.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtSicacom.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAdobePDF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdobePDF.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAdobePDF.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtDopBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDopBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtDopBox.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAreaSoft_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAreaSoft.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAreaSoft.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAdminT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdminT.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAdminT.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtRR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRR.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtRR.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtCorreoE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoE.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtCorreoE.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtDemo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDemo.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If

        If (e.KeyChar = ChrW(Keys.Space) And txtDemo.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAnyDesk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnyDesk.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAnyDesk.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And RichTextBox1.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub ComboBoxIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxIS.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBoxIS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIS.SelectedIndexChanged
        If ComboBoxIS.SelectedItem = "DISPONIBLE" Then
            ComboBoxIS.BackColor = Color.Yellow
        ElseIf ComboBoxIS.SelectedItem = "EN USO" Then
            ComboBoxIS.BackColor = Color.Green
        ElseIf ComboBoxIS.SelectedItem = "DADO DE BAJA" Then
            ComboBoxIS.BackColor = Color.Red

        End If
    End Sub

    Private Sub ComboBoxOf_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxOf.SelectedValueChanged
        'metodo utilizado para buscar en el combobox y dependiendo del item celecccionado que muestre en textbox los datos correspondientes
        Dim llamado As New connection
        llamado.AbrirConexion()
        Dim consulta As New MySqlCommand("SELECT `nombreCoordinador`,`dirCoordinador`,`correoCoordinador`,`telCoordinador` FROM `coordinadores` WHERE  oficinaCoordinador='" & ComboBoxOf.SelectedItem.ToString & "'", llamado.conexion)

        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.Read Then
            txtCorreoE.Text = leer("correoCoordinador")
            txtDemo.Text = leer("telCoordinador")
        End If
        llamado.CerrarConexion()

    End Sub

    Private Sub ButtonImp_Click(sender As Object, e As EventArgs) Handles ButtonImp.Click

        MsgBox("RECUERDE NO EXCEDER EL MAXIMO DE 150KB, EN PESO DE LA IMAGEN", MsgBoxStyle.Information, "INFORMACION")

        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg|PDF|*.pdf|PNG|*.png"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBoxFactura.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub ButtonImprimirF_Click(sender As Object, e As EventArgs) Handles ButtonImprimirF.Click
        mostrarIMG.PictureBoxMost.Image = PictureBoxFactura.Image
        mostrarIMG.ShowDialog()
    End Sub

    Private Sub DataGridViewCencepto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewCencepto.CellValueChanged

        If dataGridViewCencepto.Rows.Count > 0 Then
            Dim Total As Single
            Dim cont As Integer = 0 'PARA CONTADOR DE PARTIDAS

            For Each row As DataGridViewRow In Me.dataGridViewCencepto.Rows
                Total += Val(row.Cells(1).Value) 'ROW.CELLS (NUMERO DE LA COLUMNA A SUMAR).VALUE
            Next
            Me.labelValor.Text = Total.ToString
        End If

    End Sub
    Dim cantidadArticulos As Integer = 0
    Private Sub TextBoxCantid_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantid.TextChanged
        labelValor.Text = 0
        Try
            cantidadArticulos = TextBoxCantid.Text
        Catch ex As Exception
            cantidadArticulos = 0
        End Try

        'VALIDAR LA CANTIDAD DE FILAS A AGREGAR A LA HORA DE DIGITAR LA CANTIDAD DE ARTICULOS EN SISTEMAS
        If TextBoxCantid.Text <> "" Then
            Dim cantidadADD As Integer = 0
            cantidadADD = TextBoxCantid.Text
            For a = 1 To cantidadADD Step 1
                Me.dataGridViewCencepto.Rows.Add()
            Next

        End If



    End Sub

    Private Sub TextBoxCantid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantid.KeyPress
        'metodo para evitar que se ingresen letras pero que se puedan borrar los numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If
        If e.KeyChar = ChrW(Keys.Back) Then
            Dim cantidadREM As Integer = Me.dataGridViewCencepto.Rows.Count

            For filaABorrar As Integer = (cantidadREM - 1) To 0 Step -1
                Me.dataGridViewCencepto.Rows.RemoveAt(filaABorrar)
            Next
        End If


    End Sub

    Private Sub ComboBoxOf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxOf.KeyPress
        e.Handled = True
    End Sub

    Private Sub DataGridViewCencepto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewCencepto.CellContentClick

    End Sub
End Class