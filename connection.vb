
Imports MySql.Data.MySqlClient

Public Class connection


    Public conexion As New MySqlConnection
    'BLOQUE UTILIZADO PARA INICIAR BD E ABRIR LA CONEXION.19-05-2019
    Public Sub AbrirConexion()
        Try
            conexion.ConnectionString = "server=167.114.216.134;database=MovilcoBD;user id=bdMovilco;password=inventariomovilco;"
            ' conexion.ConnectionString = "server=127.0.0.1;database=bd_movilco;user id=root;password=;"
            conexion.Open()

        Catch ex As Exception
            MsgBox("ERROR DE CONEXION A BASE DE DATOS " + ex.Message, MsgBoxStyle.Critical, "INFORMACION")
        End Try


    End Sub

    Public Sub CerrarConexion()
        conexion.Close()
    End Sub

    Public Sub llenarTabla(ByVal tabla As DataGridView)


        Try
            AbrirConexion()
            Dim ElDataTable As New DataTable()

            Dim cmd As New MySqlCommand("Select NombreUsuario as 'NOMBRE DE USUARIO' ,Usuario as 'USUARIO',TipoUsuario as 'TIPO DE USUARIO',
Contraseña,codigoRecuperacion as 'CODIGO DE RECUPERACION', Fecha as 'FECHA DE CREACION' from usuarios", conexion)
            Dim datas As New DataSet
            Dim adaptador As New MySqlDataAdapter(cmd)
            adaptador.Fill(datas, "usuarios")
            tabla.DataSource = datas.Tables("usuarios")

            tabla.Columns(4).HeaderText = "CONTRASEÑA"

            tabla.Columns(4).MinimumWidth = 125

            conexion.Close()

        Catch ex As Exception
            MsgBox("ERROR AL CARGAR LA TABLA.", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub
    Public Sub llenarDataGrid(ByVal tabla1 As DataGridView)


        Try
            AbrirConexion()
            Dim DataGrid As New DataTable()

            'Select idDestinatario as 'No' ,oficinaDestinatario as 'OFICINA',
            ' encargadoD as 'ENCARGADO',departamentoYciudad as 'DEP/TO-CIUDAD',direccionDest as 'DIRECCION', celularDestinatario as 'CELULAR',
            '  cargo as 'CARGO' from `destinatarios_remitentes`"

            Dim cmd1 As New MySqlCommand("CALL `llenarDatagridRemisiones`();", conexion)

            'Dim _command As Object = conexion.CreateCommand
            '_command.commandText = "llenarDatagridRemisiones"
            '_command.commandType = CommandType.StoredProcedure
            '_command.ExecuteNonQuery
            ' conexion.Close()


            Dim datas1 As New DataSet
            Dim adaptador1 As New MySqlDataAdapter(cmd1)
            adaptador1.Fill(datas1, "destinatarios")
            tabla1.DataSource = datas1.Tables("destinatarios")

            conexion.Close()

        Catch ex As Exception
            MsgBox("ERROR AL CARGAR LA TABLA.", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub
    Public Sub llenarDataGrid1(ByVal tabla2 As DataGridView)

    End Sub
End Class
