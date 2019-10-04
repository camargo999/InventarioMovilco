Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Usuarios

    Sub configDataGridView()
        'codigo utilizado para personalizar el datagridview
        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            If i Mod 2 = 0 Then

                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

            End If

        Next

    End Sub

    Private Sub TabUsuarios_Click(sender As Object, e As EventArgs) Handles tabUsuarios.Click

        Dim llamado2 As New connection
        llamado2.llenarTabla(DataGridView1)

        txtNombreUsuarioM.Text = ""
        txtUsuarioM.Text = ""
        comboTipoUsuarioM.Text = "SELECCIONAR"
        txtCodigoRecuperacionM.Text = ""
        txtEscribirContraseñaM.Text = ""
        txtVolverEscribirContraseñaM.Text = ""
        comboUsuarioSeleccionadoM.Items.Clear()
        comboUsuarioSeleccionadoM.Text = "SELECCIONAR"

        If (comboUsuarioSeleccionadoM.Text = "SELECCIONAR") Then
            txtNombreUsuarioM.Enabled = False
            txtUsuarioM.Enabled = False
            comboTipoUsuarioM.Enabled = False
            txtCodigoRecuperacionM.Enabled = False
            txtEscribirContraseñaM.Enabled = False
            txtVolverEscribirContraseñaM.Enabled = False
        End If


        Dim llamado As New connection
        Dim consulta As New MySqlCommand("Select NombreUsuario from usuarios", llamado.conexion)
        llamado.AbrirConexion()
        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        If leer.HasRows Then
            While leer.Read

                comboUsuarioSeleccionadoM.Items.Add(leer("NombreUsuario"))

            End While
        End If
        llamado.CerrarConexion()

    End Sub
    Private Sub BtnRefrescarE_Click(sender As Object, e As EventArgs)
        Dim llamado As New connection
        llamado.llenarTabla(DataGridView1)
    End Sub

    Private Sub TabUsuarios_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabUsuarios.SelectedIndexChanged



    End Sub

    Private Sub BtnRegistrarUsuarioC_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuarioC.Click

        Try

            If txtCodigoRecuperacionC.Text <> "" And txtContraseñaC.Text <> "" And txtNombreUsuarioC.Text <> "" And txtUsuarioC.Text <> "" And txtVerificarContraseñaC.Text <> "" And comboTipoUsuarioC.Text <> "" Then

                If comboTipoUsuarioC.Text = "SELECCIONAR" Then

                    MsgBox("SELECCIONE UN ITEM VALIDO", MsgBoxStyle.Information, "INFORMACION")
                    comboTipoUsuarioC.Focus()

                Else
                    If txtContraseñaC.Text.Equals(txtVerificarContraseñaC.Text) Then
                        Dim llamado1 As New connection
                        llamado1.AbrirConexion()
                        Dim consulta0 As New MySqlCommand("Select * from usuarios where Nombreusuario='" & txtNombreUsuarioC.Text & "' or Usuario='" & txtUsuarioC.Text & "' or codigoRecuperacion='" & txtCodigoRecuperacionC.Text & "'", llamado1.conexion)
                        Dim leer As MySqlDataReader = consulta0.ExecuteReader

                        If leer.Read Then
                            MsgBox("EL USUARIO QUE INTENTA CREAR YA EXISTE EN LA BASE DE DATOS," & vbNewLine & "POR FAVOR INTENTE CON OTROS DATOS", MsgBoxStyle.Exclamation, "AVISO")
                        Else
                            Dim llamado2 As New connection
                            llamado2.AbrirConexion()
                            Dim consulta As New MySqlCommand("INSERT INTO `usuarios` VALUES (null,'" + txtNombreUsuarioC.Text.ToUpper.Trim + "', '" + txtUsuarioC.Text.Trim + "', '" + comboTipoUsuarioC.Text + "', '" + txtCodigoRecuperacionC.Text.Trim + "', '" + txtContraseñaC.Text.Trim + "', CURRENT_TIMESTAMP)", llamado2.conexion)
                            consulta.ExecuteNonQuery()
                            MsgBox("                            REGISTRO CORRECTO " & vbNewLine & "POR FAVOR NO OLVIDE EL CODIGO DE RECUPERACION", MsgBoxStyle.Information, "RECUERDE...")
                            txtCodigoRecuperacionC.Text = ""
                            txtContraseñaC.Text = ""
                            txtNombreUsuarioC.Text = ""
                            txtUsuarioC.Text = ""
                            txtVerificarContraseñaC.Text = ""
                            comboTipoUsuarioC.Text = "SELECCIONAR"
                            txtNombreUsuarioC.Focus()
                            llamado2.conexion.Close()
                        End If
                        llamado1.conexion.Close()
                    Else
                        MsgBox("LAS CONTRASEÑAS NO COINCIDEN, INTENTELO NUEVAMENTE.", MsgBoxStyle.Information, "INFORMACION")
                        txtContraseñaC.Focus()
                    End If

                End If

            Else
                MsgBox("DEBE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical, "INFORMACION..")
                txtNombreUsuarioC.Focus()


            End If



        Catch ex As Exception
            MsgBox("Error de conexion")
        End Try



    End Sub

    Private Sub BtnBorrarC_Click(sender As Object, e As EventArgs) Handles btnBorrarC.Click

        txtCodigoRecuperacionC.Text = ""
        txtContraseñaC.Text = ""
        txtNombreUsuarioC.Text = ""
        txtUsuarioC.Text = ""
        txtVerificarContraseñaC.Text = ""

        comboTipoUsuarioC.Text = "SELECCIONAR"
        txtNombreUsuarioC.Focus()


    End Sub

    Private Sub PestañaCrearU_Click(sender As Object, e As EventArgs) Handles pestañaCrearU.Click
        txtNombreUsuarioC.Focus()
    End Sub



    Private Sub ComboTipoUsuarioC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboTipoUsuarioC.KeyPress

        e.Handled = True  'este pequeño codigo se utiliza para deshabilitar la edicion del combobox

        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If

    End Sub
    'BLOQUE UTILIZADO PARA BLOQUEAR LA BARRA ESPACIADORA AL INICIAR LA ESCRITURA.
    Private Sub TxtNombreUsuarioC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreUsuarioC.KeyPress

        If txtNombreUsuarioC.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtUsuarioC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuarioC.KeyPress
        If txtUsuarioC.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtCodigoRecuperacionC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoRecuperacionC.KeyPress
        If txtCodigoRecuperacionC.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtContraseñaC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseñaC.KeyPress
        If txtContraseñaC.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtVerificarContraseñaC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVerificarContraseñaC.KeyPress
        If txtVerificarContraseñaC.Text = "" Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnRegistrarUsuarioC.PerformClick()

        End If
    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged

        configDataGridView()

    End Sub

    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub ComboUsuarioSeleccionadoM_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboUsuarioSeleccionadoM.SelectedValueChanged
        txtNombreUsuarioM.Enabled = True
        txtUsuarioM.Enabled = True
        comboTipoUsuarioM.Enabled = True
        txtCodigoRecuperacionM.Enabled = True
        txtEscribirContraseñaM.Enabled = True
        txtVolverEscribirContraseñaM.Enabled = True

        Dim llamado As New connection
        llamado.AbrirConexion()
        Dim consulta As New MySqlCommand("Select * from usuarios where NombreUsuario='" & comboUsuarioSeleccionadoM.SelectedItem.ToString & "'", llamado.conexion)

        Dim leer As MySqlDataReader = consulta.ExecuteReader()

        If leer.Read Then
            txtNombreUsuarioM.Text = leer(1).ToString
            txtUsuarioM.Text = leer(2)
            comboTipoUsuarioM.Text = leer(3)
            txtCodigoRecuperacionM.Text = leer(4)
            txtEscribirContraseñaM.Text = leer(5)
            txtVolverEscribirContraseñaM.Text = leer(5)
        End If
        llamado.CerrarConexion()
    End Sub


    Private Sub ComboUsuarioSeleccionadoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboUsuarioSeleccionadoM.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtNombreUsuarioC_Enter(sender As Object, e As EventArgs) Handles txtNombreUsuarioC.Enter
        'txtNombreUsuarioC.Text = txtNombreUsuarioC.Text
        'txtNombreUsuarioC.Clear()
    End Sub


    Private Sub BtnModificarM_Click(sender As Object, e As EventArgs) Handles btnModificarM.Click

        Try

            If txtCodigoRecuperacionM.Text <> "" And txtEscribirContraseñaM.Text <> "" And txtNombreUsuarioM.Text <> "" And txtUsuarioM.Text <> "" And txtVolverEscribirContraseñaM.Text <> "" And comboTipoUsuarioM.Text <> "" Then

                If comboTipoUsuarioM.Text = "SELECCIONAR" Then

                    MsgBox("Seleccione un item valido")
                    comboTipoUsuarioC.Focus()

                Else
                    If txtEscribirContraseñaM.Text.Equals(txtVolverEscribirContraseñaM.Text) Then
                        Dim llamado1 As New connection
                        llamado1.AbrirConexion()
                        Dim consulta0 As New MySqlCommand("Select * from usuarios where Nombreusuario='" & txtNombreUsuarioM.Text & "' or Usuario='" & txtUsuarioM.Text & "' or codigoRecuperacion='" & txtCodigoRecuperacionM.Text & "'", llamado1.conexion)
                        Dim leer As MySqlDataReader = consulta0.ExecuteReader

                        If leer.Read Then
                            If (leer(1) <> comboUsuarioSeleccionadoM.SelectedItem.ToString) Then

                                MsgBox("El usuario que intenta modificar ya esta en la base de datos, porfavor intente cambiando nombre, usuario o codigo de recuperacion.")

                            Else

                                Dim llamado2 As New connection
                                llamado2.AbrirConexion()
                                Dim consulta As New MySqlCommand("Update `usuarios` set NombreUsuario='" + txtNombreUsuarioM.Text.ToUpper.Trim + "',Usuario='" + txtUsuarioM.Text.Trim + "',TipoUsuario='" + comboTipoUsuarioM.Text + "',codigoRecuperacion='" + txtCodigoRecuperacionM.Text.Trim + "',Contraseña='" + txtEscribirContraseñaM.Text.Trim + "',Fecha= CURRENT_TIMESTAMP where Nombreusuario='" & comboUsuarioSeleccionadoM.SelectedItem.ToString & "'", llamado2.conexion)
                                consulta.ExecuteNonQuery()
                                MsgBox("Modificación Correcta.")
                                txtCodigoRecuperacionC.Text = ""
                                txtContraseñaC.Text = ""
                                txtNombreUsuarioC.Text = ""
                                txtUsuarioC.Text = ""
                                txtVerificarContraseñaC.Text = ""
                                comboTipoUsuarioC.Text = "SELECCIONAR"
                                txtNombreUsuarioC.Focus()
                                llamado2.conexion.Close()

                            End If
                        Else
                            Dim llamado2 As New connection
                            llamado2.AbrirConexion()
                            Dim consulta As New MySqlCommand("Update `usuarios` set NombreUsuario='" + txtNombreUsuarioM.Text.ToUpper.Trim + "',Usuario='" + txtUsuarioM.Text.Trim + "',TipoUsuario='" + comboTipoUsuarioM.Text + "',codigoRecuperacion='" + txtCodigoRecuperacionM.Text.Trim + "',Contraseña='" + txtEscribirContraseñaM.Text.Trim + "',Fecha= CURRENT_TIMESTAMP where Nombreusuario='" & comboUsuarioSeleccionadoM.SelectedItem.ToString & "'", llamado2.conexion)
                            consulta.ExecuteNonQuery()
                            MsgBox("Modificación Correcta.")
                            txtCodigoRecuperacionC.Text = ""
                            txtContraseñaC.Text = ""
                            txtNombreUsuarioC.Text = ""
                            txtUsuarioC.Text = ""
                            txtVerificarContraseñaC.Text = ""
                            comboTipoUsuarioC.Text = "SELECCIONAR"
                            txtNombreUsuarioC.Focus()
                            llamado2.conexion.Close()
                        End If
                        llamado1.conexion.Close()
                    Else
                        MsgBox("Las contraseñas no coinciden,porfavor intentelo nuevamente.")
                        txtContraseñaC.Focus()
                    End If

                End If

            Else
                MsgBox("Debe llenar todos los campos")
                txtNombreUsuarioC.Focus()


            End If
        Catch ex As Exception
            MsgBox("Error de conexion")
        End Try

    End Sub

    Private Sub TxtNombreUsuarioC_Leave(sender As Object, e As EventArgs) Handles txtNombreUsuarioC.Leave

        ' txtNombreUsuarioC.Text = Convert.ToString(txtNombreUsuarioC.Tag)
        ' txtNombreUsuarioC.Tag = Nothing

    End Sub

    Private Sub ComboTipoUsuarioM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboTipoUsuarioM.KeyPress
        Dim llamado As New connection
        llamado.AbrirConexion()
        Dim consulta As New MySqlCommand("Select * from usuarios where TipoUsuario='" & comboTipoUsuarioM.SelectedItem.ToString & "'", llamado.conexion)

        Dim leer As MySqlDataReader = consulta.ExecuteReader()
        llamado.CerrarConexion()
    End Sub

    Private Sub ComboTipoUsuarioM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipoUsuarioM.SelectedIndexChanged
        'Dim llamado As New connection
        'Dim consulta As New MySqlCommand("Select TipoUsuario from usuarios", llamado.conexion)
        'llamado.AbrirConexion()
        'Dim leer As MySqlDataReader = consulta.ExecuteReader()
        'If leer.HasRows Then
        '    While leer.Read

        '        comboUsuarioSeleccionadoM.Items.Add(leer("TombreUsuario"))

        '    End While
        'End If
        'llamado.CerrarConexion()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim cell As DataGridViewCell = DataGridView1.CurrentCell
        If Not ((TypeOf cell Is DataGridViewButtonCell) And (DataGridView1.Columns(e.ColumnIndex).Name = "btnEliminar")) Then Return
        Try
            Dim Result As DialogResult = MessageBox.Show("REALMENTE DESEA ELIMINAR EL USUARIO SELECCIONADO?.", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If Result = DialogResult.Yes Then
                If DataGridView1.SelectedRows(0).Index = 0 Then
                    MsgBox("EL ADMINISTRADOR NO SE PUEDE ELIMINAR", MsgBoxStyle.Critical)
                Else
                    If DataGridView1.GetCellCount(DataGridViewElementStates.Selected) = 7 Then

                        Try

                            Dim llamado As New connection
                            Dim consulta As New MySqlCommand("delete from usuarios where NombreUsuario='" + DataGridView1.SelectedCells(1).Value + "' and Usuario='" + DataGridView1.SelectedCells(2).Value + "' and TipoUsuario='" + DataGridView1.SelectedCells(3).Value + "' and Contraseña='" + DataGridView1.SelectedCells(4).Value + "' and codigoRecuperacion='" + DataGridView1.SelectedCells(5).Value + "'", llamado.conexion)

                            llamado.AbrirConexion()
                            consulta.ExecuteNonQuery()
                            llamado.CerrarConexion()
                            MsgBox("DATOS ELIMINADOS CORRECTAMENTE.", MsgBoxStyle.Information)
                            llamado.llenarTabla(DataGridView1)

                        Catch ex As Exception
                            MsgBox("Error al intentar eliminar usuario.", MsgBoxStyle.Critical, "Error")
                        End Try
                    Else
                        MsgBox("Porfavor seleccione una fila")
                    End If
                End If


            End If

            'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        Catch ex As Exception

        End Try


    End Sub


End Class