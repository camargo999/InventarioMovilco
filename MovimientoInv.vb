Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class MovimientoInv
    'Creación de variable para controlar el cambio de estado dependiendo el reporte seleccionado.
    Dim dondeestoy As Integer = 0
    Dim serialMovilco As String = ""
    Dim serialArticulo As String = ""


    'codigo utilizado para hacer el autocompletar en la caja de texto TextBoxBusqueda
    Public Function AutoCompletarMov(ByVal Control As TextBox, ByVal tabla As String, ByVal serial1 As String, ByVal serial2 As String) As AutoCompleteStringCollection

        Dim Coleccion As New AutoCompleteStringCollection

        Dim consulta1 As String
        Try

            consulta1 = "SELECT " & serial1 & "," & serial2 & "  FROM " & tabla
            ' MsgBox(consulta1)
            'Creamos una nueva cadena de coneccion 

            Dim llamado01 As New connection


            Dim consultaa As New MySqlCommand(consulta1, llamado01.conexion)

            'Abrimos la coneccion
            llamado01.AbrirConexion()

            Dim Lector As MySqlDataReader = consultaa.ExecuteReader()

            ' Realizamos un Loop mientras se este‚ leyendo.
            While Lector.Read()

                Coleccion.AddRange(New String() {Lector(0)})
                Coleccion.AddRange(New String() {Lector(1)})


            End While
            'Cerramos el SqlReader
            'Lector.Close()

            'Cerramos la coneccion
            llamado01.conexion.Close()

            'Ajustamos el control TextBox o ComboBox para recibir los datos de la siguiente manera.
            With Control
                .AutoCompleteMode = AutoCompleteMode.Suggest

                .AutoCompleteSource = AutoCompleteSource.CustomSource

                .AutoCompleteCustomSource = Coleccion

            End With

            'Devolvemos los datos recuperados de la base de datos
            Return Coleccion
            llamado01.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#Disable Warning BC42105 ' La función 'AutoCompletarMov' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function
#Enable Warning BC42105 ' La función 'AutoCompletarMov' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    Private Sub DataGridView111_LostFocus(sender As Object, e As EventArgs) Handles MyBase.LostFocus
        If DataGridView111.Focus = False Then
            DataGridView111.DataSource.clear()
        End If
    End Sub
    Private Sub MovimientoInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonExportar.Enabled = False

        'condicion por si es administrador entonces que se aviliten los botones necesarios
        If InventarioSH.Label4.Text = "ADMINISTRADOR" Then

            ButtonInvSist.Visible = True
            ButtonInvAc.Visible = True
            ButtonMovimiento.Visible = True

        ElseIf InventarioSH.Label4.Text = "SISTEMAS" Then

            ButtonInvSist.Visible = True
            ButtonMovimiento.Visible = True

        ElseIf InventarioSH.Label4.Text = "GENERAL" Then

            ButtonInvAc.Visible = True
            ButtonMovimiento.Visible = True

        End If

        TextBoxBusqueda.Focus()


    End Sub

    ''ingresamos el texto que queremos que figure como imagen al agua
    'TextBoxBusqueda.Text = "Buscar en base de datos"


    ''cambiamos el color a gris claro
    'TextBoxBusqueda.ForeColor = Color.LightGray

    ''Agregamos los eventos para el procedimiento GotfocusTexto

    'AddHandler TextBoxBusqueda.GotFocus, AddressOf GotfocusTexto


    '' Agregamos los eventos para el procedimiento LostfocusTexto
    'AddHandler TextBoxBusqueda.LostFocus, AddressOf LostfocusTexto



    'Private Sub GotfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim cadena As String
    '    'capturamos el texto que tenia
    '    cadena = sender.Text
    '    'borramos el texto del textbox
    '    sender.Text = ""
    '    'ponemos el color de la letra en negro
    '    sender.ForeColor = Color.Black
    'End Sub

    'Private Sub LostfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim cadena As String
    '    If sender.Text = "" Then 'si salio del textbox sin poner nada
    '        sender.Text = cadena  'volverle a poner el texto que tenia
    '        sender.ForeColor = Color.LightGray 'y poner la letra en gris
    '    End If

    'End Sub
    Sub traeriCantidadID()
        Dim conexionN As New connection
        Dim cmd01 As New MySqlCommand("SELECT COUNT(idInventario) FROM `inventariohardware` where `serialArticuloSoft`='" & TextBoxBusqueda.Text & "'", conexionN.conexion)
        Dim datas01 As New DataSet
        Dim adaptador01 As New MySqlDataAdapter(cmd01)
        adaptador01.Fill(datas01, "`inventariohardware`")
        DataGridView111.DataSource = datas01.Tables("`inventariohardware`")

        Dim leer01 As MySqlDataReader = cmd01.ExecuteReader()

        If leer01.Read Then

            LabelCantidad.Text = leer01(0)

        End If

        conexionN.CerrarConexion()
    End Sub
    Private Sub TextBoxBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusqueda.TextChanged

        ' aqui realizamos el llamado al metodo que esta realizando la consulta para el autocompletar
        'AutoCompletarMov(Me.TextBoxBusqueda, "inventarioactivos", "serialMovilco", "serialArticuloA")
        ' AutoCompletarMov(Me.TextBoxBusqueda, "inventariohardware", "codigoArticuloH", "serialArticuloSoft")
        If dondeestoy = 3 Then

            Try
                Dim llamadoo As New connection
                llamadoo.AbrirConexion()

                Dim DataGrid As New DataTable()
                Dim cmd2 As New MySqlCommand(" SELECT  `tipoArticuloH` AS 'ARTICULO',`marcaArticuloH` AS 'MARCA ARTICULO',`serialArticuloSoft` AS 'SERIAL MOVILCO',
`codigoArticuloH` AS 'CODIGO ARTICULO',`estadoArticuloH` AS 'CONDICION ARTICULO',`oficinaH` AS 'OFICINA',`areaSoft` AS 'AREA',`tonnerH` AS 'TONNER',
`capacidadDdH` AS 'CAPACIDAD DD',`memoriaRamH` AS 'MEMORIA',`sistemaOperativo` AS 'SISTEMA OP',`mOffice` AS 'OFFICE',`hClient` AS 'H-CLIENT',
`dropBox` AS 'DROPBOX',`screemView` AS 'SCREEMVIEW',`sicacomVPN` AS 'SICACOM',`adobePDF` AS 'ADOBE PDF',`adminTurno` AS 'ADMIN TURNO',`rrVpnFijo` AS 'RR/VPN FIJO',
`numeroDemo` AS 'DEMO',`anyDesk` AS 'ANYDESK',`estado` AS 'ESTADO',`responsable` AS 'RESPONSABLE',`decripcionDetallesH` AS 'DESCRIPCIONES',
`fechaIngresoH` AS 'FECHA REGISTRO' FROM `inventariohardware` WHERE `serialArticuloSoft` like '%" & TextBoxBusqueda.Text & "%' or codigoArticuloH like '%" & TextBoxBusqueda.Text & "%'
or tipoArticuloH like '%" & TextBoxBusqueda.Text & "%'", llamadoo.conexion)

                Dim datas1 As New DataSet
                Dim adaptador1 As New MySqlDataAdapter(cmd2)
                adaptador1.Fill(datas1, "inventariohardware")
                DataGridView111.DataSource = datas1.Tables("inventariohardware")

                'metodo utilizado para contar los registros que trae la busqueda
                Dim filas As Integer
                filas = DataGridView111.Rows.Count
                LabelCantidad.Text = filas
                llamadoo.CerrarConexion()

            Catch ex As Exception

                MsgBox("Error al cargar el DataGridView." + ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf dondeestoy = 1 Then
            Dim conexion As New connection
            conexion.AbrirConexion()
            Try

                Dim cmd5 As New MySqlCommand("SELECT `idInventarioA`AS No,`fechaRegistroG` AS 'FECHA REGISTRO',`oficinaG` AS OFICINA,`dirAdmin` AS 'DIRECTOR ADMIN',`correoElectric` AS CORREO,
`analistaVer` AS 'ANALISTA VERIF',`serialMovilco` AS 'SERIAL MOVILCO',`articuloA` AS ARTICULO,`marcaArticuloA` AS 'MARCA ARTICULO',`serialArticuloA` AS 'SERIAL ARTICULO',
`estadoArticuloA` AS 'CONDICION ARTICULO',`valorpromedioA` AS 'VALOR PROMEDIO', estado as ESTADO,`observacionesA` AS OBSERVACIONES FROM `inventarioactivos` where serialMovilco like '%" & TextBoxBusqueda.Text & "%'
or serialArticuloA like '%" & TextBoxBusqueda.Text & "%' or articuloA like'%" & TextBoxBusqueda.Text & "%'", conexion.conexion)

                Dim datas101 As New DataSet
                Dim adaptador101 As New MySqlDataAdapter(cmd5)
                adaptador101.Fill(datas101, "inventariohardware")
                DataGridView111.DataSource = datas101.Tables("inventariohardware")


                'metodo utilizado para contar los registros que trae la busqueda
                Dim filas1 As Integer
                filas1 = DataGridView111.Rows.Count
                LabelCantidad.Text = filas1
                conexion.CerrarConexion()
            Catch ex As Exception

                MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Information, "INFORMACION")

            End Try

        End If

    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarB.Click

        TextBoxBusqueda_TextChanged(sender, e)
        TextBoxBusqueda.Text = ""
    End Sub

    Private Sub ButtonInvSist_Click(sender As Object, e As EventArgs) Handles ButtonInvSist.Click
        TextBoxBusqueda.Enabled = True
        ButtonLimpiarB.Enabled = True
        Label3.Visible = False
        RadioButtonTodos.Checked = False
        RadioButtonTodos.Visible = False
        RadioButtonMovActi.Visible = False
        RadioButtonMovSist.Visible = False
        dondeestoy = 3
        lblNombreEstado.Visible = True
        lblEstado.Visible = True
        lblCambiarA.Visible = True
        comboEstadoCambiar.Visible = True
        botonActualizarEstado.Visible = True
        comboEstadoCambiar.Enabled = True
        botonActualizarEstado.Enabled = True
        lblEstado.Text = ""

        LabelTituloEstado.Visible = True
        GroupBox1.Visible = True

        ButtonExportar.Enabled = True
        Dim conexion As New connection
        conexion.AbrirConexion()
        Try


            Dim cmd5 As New MySqlCommand("SELECT `codigoArticuloH` AS 'SERIAL MOVILCO',`serialArticuloSoft` AS 'CODIGO ARTICULO',`tipoArticuloH` AS ARTICULO,
`marcaArticuloH` AS MARCA,`estadoArticuloH` AS 'CONDICION ARTICULO',`oficinaH` AS OFICINA,`tonnerH` AS TONNER,`capacidadDdH` AS 'CAPACIDAD DISCO D.',`memoriaRamH` AS 'MEMORIA RAM',
`sistemaOperativo` AS 'SISTEMA OP',`mOffice` AS OFFICE,`hClient` 'H CLIENT',`dropBox` AS DROPBOX,`areaSoft` AS AREA,`screemView` AS 'SCREEM VIEW',`sicacomVPN` AS SICACOM,
`adobePDF` AS 'ADOBE PDF',`adminTurno` AS 'ADMIN TURNO',`rrVpnFijo` AS 'VPN FIJO',`correoElectronico` AS CORREO,`numeroDemo` 'No DEMO',`anyDesk` AS 'ANNY DESK',`responsable` AS RESPONSABLE,
estado as ESTADO,`decripcionDetallesH` AS DETALLES,`fechaIngresoH` AS FECHA FROM `inventariohardware` ", conexion.conexion)

            Dim cmd4 As New MySqlCommand("SELECT COUNT(idInventario) FROM `inventariohardware` ", conexion.conexion)
            Dim datas2 As New DataSet
            Dim adaptador1 As New MySqlDataAdapter(cmd5)
            adaptador1.Fill(datas2, "`inventariohardware`")
            DataGridView111.DataSource = datas2.Tables("`inventariohardware`")

            Dim leer1 As MySqlDataReader = cmd4.ExecuteReader()

            If leer1.Read Then

                LabelCantidad.Text = leer1(0)

            End If

            conexion.CerrarConexion()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Information, "INFORMACION")
        End Try



    End Sub

    Private Sub ButtonInvAc_Click(sender As Object, e As EventArgs) Handles ButtonInvAc.Click

        TextBoxBusqueda.Enabled = True
        ButtonLimpiarB.Enabled = True
        Label3.Visible = False
        RadioButtonTodos.Checked = False
        RadioButtonTodos.Visible = False
        RadioButtonMovActi.Visible = False
        RadioButtonMovSist.Visible = False
        dondeestoy = 1
        lblNombreEstado.Visible = True
        lblEstado.Visible = True
        lblCambiarA.Visible = True
        comboEstadoCambiar.Visible = True
        botonActualizarEstado.Visible = True
        comboEstadoCambiar.Enabled = True
        botonActualizarEstado.Enabled = True
        lblEstado.Text = ""

        LabelTituloEstado.Visible = True
        GroupBox1.Visible = True

        ButtonExportar.Enabled = True
        Dim conexion As New connection
        conexion.AbrirConexion()
        Try



            Dim cmd5 As New MySqlCommand("SELECT `serialMovilco` AS 'SERIAL MOVILCO',`serialArticuloA` AS 'SERIAL ARTICULO',`articuloA` AS ARTICULO,
`marcaArticuloA` AS 'MARCA ARTICULO',`estadoArticuloA` AS 'CONDICION ARTICULO',`oficinaG` AS OFICINA,`dirAdmin` AS 'DIRECTOR ADMIN',`correoElectric` AS CORREO,`analistaVer` AS 'ANALISTA VERIF',
`valorpromedioA` AS 'VALOR PROMEDIO', estado as ESTADO,`fechaRegistroG` AS 'FECHA REGISTRO',`observacionesA` AS OBSERVACIONES FROM `inventarioactivos` ", conexion.conexion)

            Dim cmd4 As New MySqlCommand("SELECT COUNT(idInventarioA) FROM `inventarioactivos` ", conexion.conexion)
            Dim datas2 As New DataSet
            Dim adaptador1 As New MySqlDataAdapter(cmd5)
            adaptador1.Fill(datas2, "inventarioactivos")
            DataGridView111.DataSource = datas2.Tables("inventarioactivos")

            Dim leer1 As MySqlDataReader = cmd4.ExecuteReader()

            If leer1.Read Then

                LabelCantidad.Text = leer1(0)

            End If

            conexion.CerrarConexion()
        Catch ex As Exception

            MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Information, "INFORMACION")

        End Try


    End Sub

    Private Sub ButtonMovimiento_Click(sender As Object, e As EventArgs) Handles ButtonMovimiento.Click
        TextBoxBusqueda.Enabled = False
        ButtonLimpiarB.Enabled = False
        If InventarioSH.Label4.Text = "ADMINISTRADOR" Then
            Label3.Visible = True
            RadioButtonTodos.Checked = True
            RadioButtonTodos.Visible = True
            RadioButtonMovActi.Visible = True
            RadioButtonMovSist.Visible = True
        End If

        dondeestoy = 2
        lblNombreEstado.Visible = False
        lblEstado.Visible = False
        lblCambiarA.Visible = False
        comboEstadoCambiar.Visible = False
        botonActualizarEstado.Visible = False
        comboEstadoCambiar.Enabled = True
        botonActualizarEstado.Enabled = True
        lblEstado.Text = ""

        LabelTituloEstado.Visible = False
        GroupBox1.Visible = False

        ButtonExportar.Enabled = True

        Try
            If InventarioSH.Label4.Text = "ADMINISTRADOR" Then
                Dim conexion0 As New connection
                conexion0.AbrirConexion()
                Dim cmd5 As New MySqlCommand("SELECT flag as INVENTARIO ,serialR as 'SERIAL(S)', articuloR as 'ARTICULO(S)', `destinatarioR` AS DESTINATARIO,`remitenteR` AS REMITENTE,
            `observacionesR` AS DETALLES,`fechaR` AS 'FECHA REGISTRO' FROM `registrosremisiones`", conexion0.conexion)

                Dim cmd4 As New MySqlCommand("SELECT COUNT(idRegistroR) FROM registrosremisiones ", conexion0.conexion)
                Dim datas2 As New DataSet
                Dim adaptador1 As New MySqlDataAdapter(cmd5)
                adaptador1.Fill(datas2, "registrosremisiones")
                DataGridView111.DataSource = datas2.Tables("registrosremisiones")

                Dim leer11 As MySqlDataReader = cmd4.ExecuteReader()

                If leer11.Read Then

                    LabelCantidad.Text = leer11(0)

                End If

                conexion0.CerrarConexion()
            ElseIf InventarioSH.Label4.Text = "GENERAL" Then
                Dim conexion1 As New connection
                Dim cmd11 As New MySqlCommand("SELECT `idRegistroR` AS NUMERO,`idDestinatario` AS 'ID DESTINATARIO',flag as INVENTARIO ,serialR as 'SERIAL(S)', articuloR as 'ARTICULO(S)', `destinatarioR` AS DESTINATARIO,`remitenteR` AS REMITENTE,
`observacionesR` AS DETALLES,`fechaR` AS 'FECHA REGISTRO' FROM `registrosremisiones` where  flag = 'ACTIVOS' ", conexion1.conexion)

                Dim cmd12 As New MySqlCommand("SELECT COUNT(*) FROM registrosremisiones where flag='ACTIVOS' ", conexion1.conexion)
                conexion1.AbrirConexion()
                Dim datas11 As New DataSet
                Dim adaptador11 As New MySqlDataAdapter(cmd11)
                adaptador11.Fill(datas11, "registrosremisiones")
                DataGridView111.DataSource = datas11.Tables("registrosremisiones")

                Dim leer111 As MySqlDataReader = cmd12.ExecuteReader()

                If leer111.Read Then

                    LabelCantidad.Text = leer111(0)

                End If

                conexion1.CerrarConexion()
            ElseIf InventarioSH.Label4.Text = "SISTEMAS" Then
                Dim conexion2 As New connection
                Dim cmd11 As New MySqlCommand("SELECT `idRegistroR` AS NUMERO,`idDestinatario` AS 'ID DESTINATARIO',flag as INVENTARIO ,serialR as 'SERIAL(S)', articuloR as 'ARTICULO(S)', `destinatarioR` AS DESTINATARIO,`remitenteR` AS REMITENTE,
`observacionesR` AS DETALLES,`fechaR` AS 'FECHA REGISTRO' FROM `registrosremisiones` where  flag = 'SISTEMAS' ", conexion2.conexion)

                Dim cmd12 As New MySqlCommand("SELECT COUNT(*) FROM registrosremisiones where flag='SISTEMAS'", conexion2.conexion)
                conexion2.AbrirConexion()
                Dim datas11 As New DataSet
                Dim adaptador11 As New MySqlDataAdapter(cmd11)
                adaptador11.Fill(datas11, "registrosremisiones")
                DataGridView111.DataSource = datas11.Tables("registrosremisiones")

                Dim leer111 As MySqlDataReader = cmd12.ExecuteReader()

                If leer111.Read Then

                    LabelCantidad.Text = leer111(0)

                End If

                conexion2.CerrarConexion()

            End If


        Catch ex As Exception

            MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Information, "INFORMACION")

        End Try



    End Sub



    Private Sub DataGridView111_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView111.CellClick
        Dim estado As String
        If (dondeestoy = 3) Then

            estado = DataGridView111.Item(23, DataGridView111.CurrentRow.Index).Value
            serialMovilco = DataGridView111.Item(0, DataGridView111.CurrentRow.Index).Value
            serialArticulo = DataGridView111.Item(1, DataGridView111.CurrentRow.Index).Value
            lblEstado.Text = estado

        ElseIf (dondeestoy = 1) Then

            estado = DataGridView111.Item(10, DataGridView111.CurrentRow.Index).Value
            serialMovilco = DataGridView111.Item(0, DataGridView111.CurrentRow.Index).Value
            serialArticulo = DataGridView111.Item(1, DataGridView111.CurrentRow.Index).Value
            lblEstado.Text = estado

        End If

    End Sub

    Private Sub BotonActualizarEstado_Click(sender As Object, e As EventArgs) Handles botonActualizarEstado.Click



        If lblEstado.Text = "" And comboEstadoCambiar.Text = "SELECCIONAR" Then

            MsgBox("Porfavor seleccione un registro de la tabla y un item valido e intentelo nuevamente.")

        ElseIf (lblEstado.Text = "") Then

            MsgBox("Porfavor seleccione un registro de la tabla e intentelo nuevamente.")

        ElseIf (comboEstadoCambiar.Text = "SELECCIONAR") Then

            MsgBox("Porfavor seleccione un item valido e intentelo nuevamente.")

        ElseIf (comboEstadoCambiar.SelectedItem = lblEstado.Text) Then

            MsgBox("No se realizo la actualización del estado ya que son iguales.")

        Else

            If dondeestoy = 3 Then
                Try
                    Dim llamado0 As New connection
                    Dim cmd0 As New MySqlCommand("update inventariohardware set estado='" & comboEstadoCambiar.SelectedItem & "' where serialArticuloSoft='" & serialArticulo & "' or codigoArticuloH='" & serialMovilco & "'", llamado0.conexion)
                    llamado0.AbrirConexion()
                    cmd0.ExecuteNonQuery()
                    llamado0.CerrarConexion()

                    Dim conexion As New connection
                    conexion.AbrirConexion()
                    Dim cmd5 As New MySqlCommand("SELECT `codigoArticuloH` AS 'SERIAL MOVILCO',`serialArticuloSoft` AS 'CODIGO ARTICULO',`tipoArticuloH` AS ARTICULO,
`marcaArticuloH` AS MARCA,`estadoArticuloH` AS 'CONDICION ARTICULO',`oficinaH` AS OFICINA,`tonnerH` AS TONNER,`capacidadDdH` AS 'CAPACIDAD DISCO D.',`memoriaRamH` AS 'MEMORIA RAM',
`sistemaOperativo` AS 'SISTEMA OP',`mOffice` AS OFFICE,`hClient` 'H CLIENT',`dropBox` AS DROPBOX,`areaSoft` AS AREA,`screemView` AS 'SCREEM VIEW',`sicacomVPN` AS SICACOM,
`adobePDF` AS 'ADOBE PDF',`adminTurno` AS 'ADMIN TURNO',`rrVpnFijo` AS 'VPN FIJO',`correoElectronico` AS CORREO,`numeroDemo` 'No DEMO',`anyDesk` AS 'ANNY DESK',`responsable` AS RESPONSABLE,
estado as ESTADO,`decripcionDetallesH` AS DETALLES,`fechaIngresoH` AS FECHA FROM `inventariohardware` ", conexion.conexion)

                    Dim cmd4 As New MySqlCommand("SELECT COUNT(idInventario) FROM `inventariohardware` ", conexion.conexion)
                    Dim datas2 As New DataSet
                    Dim adaptador1 As New MySqlDataAdapter(cmd5)
                    adaptador1.Fill(datas2, "`inventariohardware`")
                    DataGridView111.DataSource = datas2.Tables("`inventariohardware`")

                    Dim leer1 As MySqlDataReader = cmd4.ExecuteReader()

                    If leer1.Read Then

                        LabelCantidad.Text = leer1(0)

                    End If

                    conexion.CerrarConexion()

                Catch ex As Exception
                    MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Information, "INFORMACION")
                End Try

            ElseIf dondeestoy = 1 Then
                Try
                    Dim llamado1 As New connection
                    Dim cmd1 As New MySqlCommand("update inventarioactivos set estado='" & comboEstadoCambiar.SelectedItem & "' where serialArticuloA='" & serialArticulo & "' or serialMovilco='" & serialMovilco & "'", llamado1.conexion)

                    llamado1.AbrirConexion()
                    cmd1.ExecuteNonQuery()
                    llamado1.CerrarConexion()

                    Dim conexion1 As New connection
                    conexion1.AbrirConexion()
                    Dim cmd51 As New MySqlCommand("SELECT `serialMovilco` AS 'SERIAL MOVILCO',`serialArticuloA` AS 'SERIAL ARTICULO',`articuloA` AS ARTICULO,
`marcaArticuloA` AS 'MARCA ARTICULO',`estadoArticuloA` AS 'CONDICION ARTICULO',`oficinaG` AS OFICINA,`dirAdmin` AS 'DIRECTOR ADMIN',`correoElectric` AS CORREO,`analistaVer` AS 'ANALISTA VERIF',
`valorpromedioA` AS 'VALOR PROMEDIO', estado as ESTADO,`fechaRegistroG` AS 'FECHA REGISTRO',`observacionesA` AS OBSERVACIONES FROM `inventarioactivos` ", conexion1.conexion)

                    Dim cmd41 As New MySqlCommand("SELECT COUNT(idInventarioA) FROM `inventarioactivos` ", conexion1.conexion)
                    Dim datas21 As New DataSet
                    Dim adaptador11 As New MySqlDataAdapter(cmd51)
                    adaptador11.Fill(datas21, "inventarioactivos")
                    DataGridView111.DataSource = datas21.Tables("inventarioactivos")

                    Dim leer1 As MySqlDataReader = cmd41.ExecuteReader()

                    If leer1.Read Then

                        LabelCantidad.Text = leer1(0)

                    End If

                    conexion1.CerrarConexion()

                Catch ex As Exception
                    MsgBox("ERROR EN LA CONEXION A BASE DE DATOS", MsgBoxStyle.Information, "INFORMACION")
                End Try

            End If
            comboEstadoCambiar.BackColor = DefaultBackColor
            comboEstadoCambiar.Text = "SELECCIONAR"
            lblEstado.Text = ""
            MsgBox("EL ESTADO SE MODIFICÓ CORRECTAMENTE.", MsgBoxStyle.Information, "INFORMACION")

        End If
    End Sub

    Private Sub ComboEstadoCambiar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboEstadoCambiar.SelectedIndexChanged
        If comboEstadoCambiar.SelectedItem = "EN USO" Then
            comboEstadoCambiar.BackColor = Color.Green
        ElseIf comboEstadoCambiar.SelectedItem = "DISPONIBLE" Then
            comboEstadoCambiar.BackColor = Color.Yellow
        ElseIf comboEstadoCambiar.SelectedItem = "DADO DE BAJA" Then
            comboEstadoCambiar.BackColor = Color.Red
        ElseIf comboEstadoCambiar.Text = "SELECCIONAR" Then
            comboEstadoCambiar.BackColor = Color.White
        End If
    End Sub

    Private Sub RadioButtonTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTodos.CheckedChanged
        If RadioButtonTodos.Checked = True Then
            ButtonMovimiento_Click(sender, e)
        End If
    End Sub

    Private Sub RadioButtonMovSist_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMovSist.CheckedChanged
        Dim conexion0 As New connection
        If RadioButtonMovSist.Checked Then

            Dim cmd11 As New MySqlCommand("SELECT flag as INVENTARIO ,serialR as 'SERIAL(S)', articuloR as 'ARTICULO(S)', `destinatarioR` AS DESTINATARIO,`remitenteR` AS REMITENTE,
`observacionesR` AS DETALLES,`fechaR` AS 'FECHA REGISTRO' FROM `registrosremisiones` where  flag = 'SISTEMAS' ", conexion0.conexion)

            Dim cmd12 As New MySqlCommand("SELECT COUNT(*) FROM registrosremisiones where flag='SISTEMAS'", conexion0.conexion)
            conexion0.AbrirConexion()
            Dim datas11 As New DataSet
            Dim adaptador11 As New MySqlDataAdapter(cmd11)
            adaptador11.Fill(datas11, "registrosremisiones")
            DataGridView111.DataSource = datas11.Tables("registrosremisiones")

            Dim leer111 As MySqlDataReader = cmd12.ExecuteReader()

            If leer111.Read Then

                LabelCantidad.Text = leer111(0)

            End If

            conexion0.CerrarConexion()
        End If
    End Sub

    Private Sub RadioButtonMovActi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMovActi.CheckedChanged
        Dim conexion1 As New connection
        If RadioButtonMovActi.Checked Then

            Dim cmd11 As New MySqlCommand("SELECT flag as INVENTARIO ,serialR as 'SERIAL(S)', articuloR as 'ARTICULO(S)', `destinatarioR` AS DESTINATARIO,`remitenteR` AS REMITENTE,
`observacionesR` AS DETALLES,`fechaR` AS 'FECHA REGISTRO' FROM `registrosremisiones` where  flag = 'ACTIVOS' ", conexion1.conexion)

            Dim cmd12 As New MySqlCommand("SELECT COUNT(*) FROM registrosremisiones where flag='ACTIVOS' ", conexion1.conexion)
            conexion1.AbrirConexion()
            Dim datas11 As New DataSet
            Dim adaptador11 As New MySqlDataAdapter(cmd11)
            adaptador11.Fill(datas11, "registrosremisiones")
            DataGridView111.DataSource = datas11.Tables("registrosremisiones")

            Dim leer111 As MySqlDataReader = cmd12.ExecuteReader()

            If leer111.Read Then

                LabelCantidad.Text = leer111(0)

            End If

            conexion1.CerrarConexion()
        End If

    End Sub

    Private Sub ButtonExportar_Click(sender As Object, e As EventArgs) Handles ButtonExportar.Click
        Try
            If ((DataGridView111.Columns.Count = 0) Or (DataGridView111.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creando Dataset para Exportar
            Dim dset As New DataSet
            'Agregar tabla al Dataset
            dset.Tables.Add()
            'AGregar Columna a la tabla
            For i As Integer = 0 To DataGridView111.ColumnCount - 1
                dset.Tables(0).Columns.Add(DataGridView111.Columns(i).HeaderText)
            Next
            'Agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To DataGridView111.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To DataGridView111.Columns.Count - 1
                    dr1(j) = DataGridView111.Rows(i).Cells(j).Value
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

            Dim strFileName As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ExportadoM"
            ' Dim strFileName As String = "C:\Users\CVR\Desktop\Reporte .xlsx"
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
End Class