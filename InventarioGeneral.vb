Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Public Class InventarioGeneral

    Private Sub InventarioGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcombooficinas()
        DateTimePickerIG.Focus()

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
    Function valorUnitario2()
        Dim cont As Integer = TextBoxCantid2.Text
        Dim cadenaVUnitario As String = ""
        For a = 0 To (cont - 1) Step 1
            cadenaVUnitario += Convert.ToString(dataGridViewCencepto2.Rows(a).Cells(1).Value) & vbCrLf

        Next
        Return (cadenaVUnitario)
    End Function
    Function concepto2()
        Dim cont As Integer = TextBoxCantid2.Text
        Dim cadenaArticulo = ""
        For a = 0 To (cont - 1) Step 1
            cadenaArticulo += Convert.ToString(dataGridViewCencepto2.Rows(a).Cells(0).Value) & vbCrLf

        Next
        Return (cadenaArticulo)
    End Function
    Public contador As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'codigo para validar que el datagrid no guarde campos vacios
        Dim numLineas As Integer = DataGridViewIG.RowCount - 2
        Dim numLineas1 As Integer = dataGridViewCencepto2.RowCount - 1
        '  MsgBox(DataGridViewIG.RowCount - 1)
        Dim contador As Integer = 0
        Dim contador1 As Integer = 0
        Dim validador As String = "verdadero"
        Dim validador1 As String = "verdadero"
        Dim numeroOletra As Integer = 1
        Dim numeroOletra1 As Integer = 1



        For variable3 = 0 To numLineas1 Step 1

            For variable4 = 1 To 2 Step 1

                If (Convert.ToString(dataGridViewCencepto2.Rows(contador1).Cells(0).Value)).Equals("") Then
                    validador1 = "falso"
                End If
                If (Convert.ToString(dataGridViewCencepto2.Rows(contador1).Cells(1).Value)).Equals("") Then
                    validador1 = "falso"
                End If
                Try
                    If (IsNumeric(((dataGridViewCencepto2.Rows(contador1).Cells(1).Value)) = False)) Then

                    End If
                Catch ex As Exception
                    numeroOletra1 = 0
                End Try


            Next
            contador1 = contador + 1

        Next
        MsgBox(numeroOletra1)
        MsgBox(validador1)

        For variable1 = 0 To numLineas Step 1

            For variable2 = 1 To 8 Step 1
                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(0).Value)).Equals("") Then
                    validador = "falso"
                End If

                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(1).Value)).Equals("") Then
                    validador = "falso"
                End If

                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(2).Value)).Equals("") Then
                    validador = "falso"

                End If

                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(3).Value)).Equals("") Then
                    validador = "falso"

                End If

                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(4).Value)).Equals("") Then
                    validador = "falso"
                End If


                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(5).Value)).Equals("") Then
                    validador = "falso"
                End If
                Try
                    If (IsNumeric(((DataGridViewIG.Rows(contador).Cells(5).Value)) = False)) Then

                    End If
                Catch ex As Exception
                    numeroOletra = 0
                End Try

                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(6).Value)).Equals("") Then
                    validador = "falso"
                End If

                If (Convert.ToString(DataGridViewIG.Rows(contador).Cells(7).Value)).Equals("") Then
                    validador = "falso"
                End If


            Next
            contador = contador + 1
        Next


        Dim llamado2 As New connection
        Dim trycach As Integer = 0

        Try
            If DateTimePickerIG.Text <> "" And txtDirectorAdmin.Text <> "" And txtCorreoEl.Text <> "" And txtTelefono.Text <> "" And validador1 <> "falso" And numeroOletra1 <> 0 And TextBoxNumFac2.Text <> "" And TextBoxCantid2.Text <> "" And TextBoxVend2.Text <> "" Then

                If contador = 0 Then
                    contador = TextBoxCantid2.Text
                End If

                Dim llamado0 As New connection

                Dim consultaConcepto As String = concepto2().ToString
                Dim consultaVUnitario As String = valorUnitario2().ToString

                Dim consult0 As New MySqlCommand("INSERT INTO `detalle_factura`(`IdFactura`,`NoFactura`, `Concepto`, `ValorUnitario`, `ValorTotal`, `CantidadTotal`, `Proveedor`, `FechaCompra`,`factura`) VALUES 
(null,'" & TextBoxNumFac2.Text & "','" & consultaConcepto & "','" & consultaVUnitario & "','" & labelValor2.Text & "','" & TextBoxCantid2.Text & "','" & TextBoxVend2.Text.ToUpper & "','" & DateTimePickerFC2.Value.ToLongDateString & "',?imagen)", llamado0.conexion)
                llamado0.AbrirConexion()

                consult0.Parameters.AddWithValue("?imagen", Imagen_Bytes(Me.PictureBoxFactura2.Image))

                If contador = TextBoxCantid2.Text Then
                    consult0.ExecuteNonQuery()

                End If
                llamado0.CerrarConexion()


                If validador = "verdadero" Then

                    If numeroOletra = 1 Then
                        MsgBox("as")
                        Dim agregar As New MySqlCommand(" INSERT INTO `inventarioactivos`(`serialMovilco`,`NoFacturaA`, `articuloA`, `marcaArticuloA`, `serialArticuloA`,
`estadoArticuloA`, `valorpromedioA`, `observacionesA`, `fechaRegistroG`, `oficinaG`,`coordinadorCvs`,direccionCvs,`correoElectric`, `telefono`,estado)
VALUES (?serialMovilco, ?NoFactura,?articuloA, ?marcaArticuloA, ?serialArticuloA, ?estadoArticuloA,?valorpromedioA,
?observacionesA,'" & DateTimePickerIG.Value.ToShortDateString & "','" & ComboBoxOficina.SelectedItem & "','" & txtDirectorAdmin.Text.ToUpper & "','" & TextBoxDireccion.Text.ToUpper & "','" & txtCorreoEl.Text.ToUpper & "', '" & txtTelefono.Text.ToUpper & "',?estado)", llamado2.conexion)
                        llamado2.AbrirConexion()

                        Dim fila As New DataGridViewRow()
                        For Each fila In DataGridViewIG.Rows

                            agregar.Parameters.Clear()

                            agregar.Parameters.Add("?serialMovilco", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("serialM").Value)
                            agregar.Parameters.Add("?NoFactura", MySqlDbType.VarChar).Value = TextBoxNumFac2.Text 
                            agregar.Parameters.Add("?articuloA", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("articulo").Value).ToUpper
                            agregar.Parameters.Add("?marcaArticuloA", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("marcaArticulo").Value).ToUpper
                            agregar.Parameters.Add("?serialArticuloA", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("serialArticulo").Value)
                            agregar.Parameters.Add("?estadoArticuloA", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("estadoArticulo").Value).ToUpper
                            agregar.Parameters.Add("?valorpromedioA", MySqlDbType.Float).Value = Convert.ToString(fila.Cells("ValorPromedio").Value)
                            agregar.Parameters.Add("?observacionesA", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Observaciones").Value).ToUpper
                            agregar.Parameters.Add("?estado", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("ComboBoxIG").Value).ToUpper

                            trycach = 1

                            agregar.ExecuteNonQuery()

                        Next

                    Else
                        MsgBox("La columna 'VALOR PROMEDIO' debe ser un dato númerico")
                    End If

                Else
                    MsgBox("FAVOR DILIGENCIAR TODOS LOS CAMPOS.", MsgBoxStyle.Information, "INFORMACION")
                End If


            ElseIf ComboBoxOficina.Text = "SELECCIONAR OFICINA" Then

                MsgBox("DEBE SELECCIONAR UN ITEM VALIDO.", MsgBoxStyle.Information, "INFORMACION")

            Else
                MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS", MsgBoxStyle.Information, "INFORMACION")
                ComboBoxOficina.Focus()
            End If


        Catch ex As Exception
            If trycach = 1 Then
                labelValor2.Text = "0"
                TextBoxVend2.Text = ""
                TextBoxCantid2.Text = ""
                TextBoxNumFac2.Text = ""
                ComboBoxOficina.Text = "SELECCIONAR OFICINA"
                dataGridViewCencepto2.Rows.Clear()
                PictureBoxFactura2.Image = Nothing

                Button1_Click(sender, e)
                MsgBox("DATOS GUARDADOS CORRECTAMENTE.", MsgBoxStyle.Information, "INFORMACION")

            ElseIf trycach = 0 Then
                MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Critical, "ADVERTENCIA")
            End If
            llamado2.CerrarConexion()
        End Try


    End Sub



    Private Sub DataGridViewIG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewIG.CellContentClick
        'BLOQUE UTILIZADO PARA ELIMINAR FILA AL DAR CLICK EN EL BOTON ELIMINAR ALOJADO EN EL DATAGRIDVIEWIG.
        For n As Integer = DataGridViewIG.Rows.Count - 1 To 0 Step -1

            Dim row As DataGridViewRow = DataGridViewIG.Rows(n)

            If (row.Cells(1).Value Is DBNull.Value) Then
                DataGridViewIG.Rows.Remove(row)

            End If

        Next

    End Sub

    Private Sub TxtOficinaG_TextChanged(sender As Object, e As EventArgs)
        ' aqui realizamos el llamado al metodo que esta realizando la consulta para el autocompletar

        'Dim Coleccion1 As New AutoCompleteStringCollection
        'Dim Comando1 As String
        'Try

        '    Comando1 = "SELECT oficinaG FROM inventarioactivos union select oficinaH from inventariohardware"

        '    'Creamos una nueva cadena de coneccion 

        '    Dim llamado1 As New connection
        '    Dim consulta As New MySqlCommand(Comando1, llamado1.conexion)

        '    'Abrimos la coneccion
        '    llamado1.AbrirConexion()


        '    Dim Lector1 As MySqlDataReader = consulta.ExecuteReader()


        '    ' Realizamos un Loop mientras se este‚ leyendo.
        '    While Lector1.Read()

        '        Coleccion1.AddRange(New String() {Lector1(0)})

        '    End While

        '    Lector1.Close()

        '    'Cerramos la coneccion
        '    llamado1.conexion.Close()

        '    'Ajustamos el control TextBox o ComboBox para recibir los datos de la siguiente manera.
        '    With txtOficinaG
        '        .AutoCompleteMode = AutoCompleteMode.Suggest

        '        .AutoCompleteSource = AutoCompleteSource.CustomSource

        '        .AutoCompleteCustomSource = Coleccion1

        '    End With

        '    'Devolvemos los datos recuperados de la base de datos

        '    llamado1.CerrarConexion()
        'Catch ex As Exception
        '    MsgBox("ERROR EN LA CONSULTA A BASE DE DATOS", MsgBoxStyle.Critical, "ADVERTENCIA")
        'End Try



    End Sub

    Private Sub AnalistaV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If txtTelefono.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtDirectorAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDirectorAdmin.KeyPress
        If txtDirectorAdmin.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtCorreoEl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoEl.KeyPress
        If txtCorreoEl.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtOficinaG_KeyPress(sender As Object, e As KeyPressEventArgs)
        If ComboBoxOficina.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'DateTimePickerIG.Text = ""
        ComboBoxOficina.Text = ""
        txtDirectorAdmin.Text = ""
        txtCorreoEl.Text = ""
        txtTelefono.Text = ""
        TextBoxDireccion.Text = ""
        DataGridViewIG.Rows.Clear()


    End Sub

    Private Sub DataGridViewIG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewIG.CellClick
        Dim cell As DataGridViewCell = DataGridViewIG.CurrentCell
        If Not ((TypeOf cell Is DataGridViewButtonCell) And (DataGridViewIG.Columns(e.ColumnIndex).Name = "btnEliminar")) Then Return
        Try
            DataGridViewIG.Rows.Remove(DataGridViewIG.CurrentRow)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ComboBoxIG_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub


    Private Sub ComboBoxOficina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxOficina.KeyPress

        e.Handled = True  'este pequeño codigo se utiliza para deshabilitar la edicion del combobox

        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    SendKeys.Send("{TAB}")

        'End If


    End Sub
    'metodo utilizado para cargar el comboboxoficina en el modulo inventario general
    Sub cargarcombooficinas()
        Dim llamado As New connection
        Dim consulta As New MySqlCommand("Select oficinaCoordinador from coordinadores", llamado.conexion)
        llamado.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                ComboBoxOficina.Items.Add(leer("oficinaCoordinador"))

            End While
        End If
        llamado.CerrarConexion()
    End Sub

    'codigo utilizado para llenar las cajas de texto con datos del comboboxoficinas
    Private Sub ComboBoxOficina_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxOficina.SelectedValueChanged

        Dim llamado As New connection
        llamado.AbrirConexion()
        Dim consulta As New MySqlCommand("SELECT `nombreCoordinador`,`dirCoordinador`,`correoCoordinador`,`telCoordinador` FROM `coordinadores` WHERE  oficinaCoordinador='" & ComboBoxOficina.SelectedItem.ToString & "'", llamado.conexion)

        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.Read Then
            txtDirectorAdmin.Text = leer("nombreCoordinador")
            TextBoxDireccion.Text = leer("dirCoordinador")
            txtCorreoEl.Text = leer("correoCoordinador")
            txtTelefono.Text = leer("telCoordinador")

        End If
        llamado.CerrarConexion()


    End Sub

    Private Sub ButtonImp2_Click(sender As Object, e As EventArgs) Handles ButtonImp2.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg|PDF|*.pdf|PNG|*.png"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBoxFactura2.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub ButtonImprimirF2_Click(sender As Object, e As EventArgs) Handles ButtonImprimirF2.Click
        mostrarIMG.PictureBoxMost.Image = PictureBoxFactura2.Image
        mostrarIMG.ShowDialog()
    End Sub

    Private Sub DataGridViewCencepto2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewCencepto2.CellValueChanged
        If dataGridViewCencepto2.Rows.Count > 0 Then
            Dim Total As Single
            Dim cont As Integer = 0 'PARA CONTADOR DE PARTIDAS

            For Each row As DataGridViewRow In Me.dataGridViewCencepto2.Rows
                Total += Val(row.Cells(1).Value) 'ROW.CELLS (NUMERO DE LA COLUMNA A SUMAR).VALUE
            Next
            Me.labelValor2.Text = Total.ToString
        End If

    End Sub

    Private Sub TextBoxCantid2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantid2.TextChanged
        'VALIDAR LA CANTIDAD DE FILAS A AGREGAR A LA HORA DE DIGITAR LA CANTIDAD DE ARTICULOS EN SISTEMAS
        If TextBoxCantid2.Text <> "" Then
            Dim cantidadADD As Integer = 0
            cantidadADD = TextBoxCantid2.Text
            For a = 1 To cantidadADD Step 1
                Me.dataGridViewCencepto2.Rows.Add()
            Next

        Else
            'VALIDAR LA CANTIDAD DE FILAS A ELIMINAR A LA HORA DE DIGITAR LA CANTIDAD DE ARTICULOS EN SISTEMAS
            Dim cantidadREM As Integer = Me.dataGridViewCencepto2.Rows.Count

            For filaABorrar As Integer = (cantidadREM - 1) To 0 Step -1
                Me.dataGridViewCencepto2.Rows.RemoveAt(filaABorrar)
            Next
        End If
    End Sub

    Private Sub TextBoxCantid2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantid2.KeyPress
        'metodo para evitar que se ingresen letras pero que se puedan borrar los numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If
    End Sub
End Class