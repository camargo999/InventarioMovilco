<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabUsuarios = New System.Windows.Forms.TabControl()
        Me.pestañaCrearU = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelRecomendacion = New System.Windows.Forms.Label()
        Me.comboTipoUsuarioC = New System.Windows.Forms.ComboBox()
        Me.btnBorrarC = New System.Windows.Forms.Button()
        Me.btnRegistrarUsuarioC = New System.Windows.Forms.Button()
        Me.txtVerificarContraseñaC = New System.Windows.Forms.TextBox()
        Me.lblVerificarContraseñaC = New System.Windows.Forms.Label()
        Me.txtContraseñaC = New System.Windows.Forms.TextBox()
        Me.lblContraseñaC = New System.Windows.Forms.Label()
        Me.txtCodigoRecuperacionC = New System.Windows.Forms.TextBox()
        Me.lblCodigoRecuperacionC = New System.Windows.Forms.Label()
        Me.txtUsuarioC = New System.Windows.Forms.TextBox()
        Me.lblUsuarioC = New System.Windows.Forms.Label()
        Me.lblTipoUsuarioC = New System.Windows.Forms.Label()
        Me.txtNombreUsuarioC = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuarioC = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pestañaModificarU = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnModificarM = New System.Windows.Forms.Button()
        Me.lblEscribirContraseñaM = New System.Windows.Forms.Label()
        Me.comboTipoUsuarioM = New System.Windows.Forms.ComboBox()
        Me.lblCodigoRecuperacionM = New System.Windows.Forms.Label()
        Me.comboUsuarioSeleccionadoM = New System.Windows.Forms.ComboBox()
        Me.lblVolverEscribirContraseñaM = New System.Windows.Forms.Label()
        Me.txtVolverEscribirContraseñaM = New System.Windows.Forms.TextBox()
        Me.lblInformacionM = New System.Windows.Forms.Label()
        Me.txtNombreUsuarioM = New System.Windows.Forms.TextBox()
        Me.lblUsuariosM = New System.Windows.Forms.Label()
        Me.txtUsuarioM = New System.Windows.Forms.TextBox()
        Me.txtEscribirContraseñaM = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuarioM = New System.Windows.Forms.Label()
        Me.txtCodigoRecuperacionM = New System.Windows.Forms.TextBox()
        Me.lblTipoUsuarioM = New System.Windows.Forms.Label()
        Me.pestañaEliminarU = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTipUsuarios = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabUsuarios.SuspendLayout()
        Me.pestañaCrearU.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pestañaModificarU.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pestañaEliminarU.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(327, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.pestañaCrearU)
        Me.tabUsuarios.Controls.Add(Me.pestañaModificarU)
        Me.tabUsuarios.Controls.Add(Me.pestañaEliminarU)
        Me.tabUsuarios.HotTrack = True
        Me.tabUsuarios.ImageList = Me.ImageList1
        Me.tabUsuarios.ItemSize = New System.Drawing.Size(123, 29)
        Me.tabUsuarios.Location = New System.Drawing.Point(0, 54)
        Me.tabUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.tabUsuarios.Multiline = True
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.SelectedIndex = 0
        Me.tabUsuarios.Size = New System.Drawing.Size(790, 622)
        Me.tabUsuarios.TabIndex = 1
        '
        'pestañaCrearU
        '
        Me.pestañaCrearU.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pestañaCrearU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pestañaCrearU.Controls.Add(Me.Label10)
        Me.pestañaCrearU.Controls.Add(Me.Label9)
        Me.pestañaCrearU.Controls.Add(Me.PictureBox2)
        Me.pestañaCrearU.Controls.Add(Me.Label8)
        Me.pestañaCrearU.Controls.Add(Me.Label2)
        Me.pestañaCrearU.Controls.Add(Me.labelRecomendacion)
        Me.pestañaCrearU.Controls.Add(Me.comboTipoUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.btnBorrarC)
        Me.pestañaCrearU.Controls.Add(Me.btnRegistrarUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.txtVerificarContraseñaC)
        Me.pestañaCrearU.Controls.Add(Me.lblVerificarContraseñaC)
        Me.pestañaCrearU.Controls.Add(Me.txtContraseñaC)
        Me.pestañaCrearU.Controls.Add(Me.lblContraseñaC)
        Me.pestañaCrearU.Controls.Add(Me.txtCodigoRecuperacionC)
        Me.pestañaCrearU.Controls.Add(Me.lblCodigoRecuperacionC)
        Me.pestañaCrearU.Controls.Add(Me.txtUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.lblUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.lblTipoUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.txtNombreUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.lblNombreUsuarioC)
        Me.pestañaCrearU.Controls.Add(Me.PictureBox1)
        Me.pestañaCrearU.ImageIndex = 0
        Me.pestañaCrearU.Location = New System.Drawing.Point(4, 33)
        Me.pestañaCrearU.Name = "pestañaCrearU"
        Me.pestañaCrearU.Padding = New System.Windows.Forms.Padding(3)
        Me.pestañaCrearU.Size = New System.Drawing.Size(782, 585)
        Me.pestañaCrearU.TabIndex = 0
        Me.pestañaCrearU.Text = "CREAR USUARIO"
        Me.pestañaCrearU.ToolTipText = "Hola"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(123, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "BIENVENIDO/A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(69, 436)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(265, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "CREAR NUEVO USUARIO"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox2.Image = Global.Inventario.My.Resources.Resources.UserAdd
        Me.PictureBox2.Location = New System.Drawing.Point(43, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(330, 423)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(737, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "*"
        '
        'labelRecomendacion
        '
        Me.labelRecomendacion.AutoSize = True
        Me.labelRecomendacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labelRecomendacion.ForeColor = System.Drawing.Color.Red
        Me.labelRecomendacion.Location = New System.Drawing.Point(16, 560)
        Me.labelRecomendacion.Name = "labelRecomendacion"
        Me.labelRecomendacion.Size = New System.Drawing.Size(260, 13)
        Me.labelRecomendacion.TabIndex = 16
        Me.labelRecomendacion.Text = "Se recomienda, NO olvidar el codigo de recuperacion"
        '
        'comboTipoUsuarioC
        '
        Me.comboTipoUsuarioC.FormattingEnabled = True
        Me.comboTipoUsuarioC.Items.AddRange(New Object() {"ADMINSTRADOR", "SISTEMAS", "GENERAL"})
        Me.comboTipoUsuarioC.Location = New System.Drawing.Point(420, 206)
        Me.comboTipoUsuarioC.Name = "comboTipoUsuarioC"
        Me.comboTipoUsuarioC.Size = New System.Drawing.Size(193, 21)
        Me.comboTipoUsuarioC.TabIndex = 3
        Me.comboTipoUsuarioC.Tag = ""
        Me.comboTipoUsuarioC.Text = "SELECCIONAR"
        Me.ToolTipUsuarios.SetToolTip(Me.comboTipoUsuarioC, "Seleccione un item")
        '
        'btnBorrarC
        '
        Me.btnBorrarC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBorrarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnBorrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarC.Location = New System.Drawing.Point(591, 482)
        Me.btnBorrarC.Name = "btnBorrarC"
        Me.btnBorrarC.Size = New System.Drawing.Size(142, 67)
        Me.btnBorrarC.TabIndex = 8
        Me.btnBorrarC.Text = "B&ORRAR CAMPOS"
        Me.ToolTipUsuarios.SetToolTip(Me.btnBorrarC, "Limpiar registros")
        Me.btnBorrarC.UseVisualStyleBackColor = False
        '
        'btnRegistrarUsuarioC
        '
        Me.btnRegistrarUsuarioC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRegistrarUsuarioC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarUsuarioC.Location = New System.Drawing.Point(420, 482)
        Me.btnRegistrarUsuarioC.Name = "btnRegistrarUsuarioC"
        Me.btnRegistrarUsuarioC.Size = New System.Drawing.Size(148, 67)
        Me.btnRegistrarUsuarioC.TabIndex = 7
        Me.btnRegistrarUsuarioC.Text = "R&EGISTRAR USUARIO"
        Me.ToolTipUsuarios.SetToolTip(Me.btnRegistrarUsuarioC, "Registrar Usuario")
        Me.btnRegistrarUsuarioC.UseVisualStyleBackColor = False
        '
        'txtVerificarContraseñaC
        '
        Me.txtVerificarContraseñaC.Location = New System.Drawing.Point(419, 407)
        Me.txtVerificarContraseñaC.Multiline = True
        Me.txtVerificarContraseñaC.Name = "txtVerificarContraseñaC"
        Me.txtVerificarContraseñaC.Size = New System.Drawing.Size(313, 22)
        Me.txtVerificarContraseñaC.TabIndex = 6
        Me.ToolTipUsuarios.SetToolTip(Me.txtVerificarContraseñaC, "Ingresar nuevamente la contraseña")
        '
        'lblVerificarContraseñaC
        '
        Me.lblVerificarContraseñaC.AutoSize = True
        Me.lblVerificarContraseñaC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblVerificarContraseñaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerificarContraseñaC.Location = New System.Drawing.Point(416, 389)
        Me.lblVerificarContraseñaC.Name = "lblVerificarContraseñaC"
        Me.lblVerificarContraseñaC.Size = New System.Drawing.Size(210, 15)
        Me.lblVerificarContraseñaC.TabIndex = 10
        Me.lblVerificarContraseñaC.Text = "VOLVER A ESCRIBIR CONTRASEÑA:"
        '
        'txtContraseñaC
        '
        Me.txtContraseñaC.Location = New System.Drawing.Point(420, 339)
        Me.txtContraseñaC.Name = "txtContraseñaC"
        Me.txtContraseñaC.Size = New System.Drawing.Size(312, 20)
        Me.txtContraseñaC.TabIndex = 5
        Me.ToolTipUsuarios.SetToolTip(Me.txtContraseñaC, "Ingresar contraseña")
        '
        'lblContraseñaC
        '
        Me.lblContraseñaC.AutoSize = True
        Me.lblContraseñaC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblContraseñaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseñaC.Location = New System.Drawing.Point(416, 320)
        Me.lblContraseñaC.Name = "lblContraseñaC"
        Me.lblContraseñaC.Size = New System.Drawing.Size(150, 15)
        Me.lblContraseñaC.TabIndex = 8
        Me.lblContraseñaC.Text = "ESCRIBIR CONTRASEÑA:"
        '
        'txtCodigoRecuperacionC
        '
        Me.txtCodigoRecuperacionC.Location = New System.Drawing.Point(419, 271)
        Me.txtCodigoRecuperacionC.Name = "txtCodigoRecuperacionC"
        Me.txtCodigoRecuperacionC.Size = New System.Drawing.Size(312, 20)
        Me.txtCodigoRecuperacionC.TabIndex = 4
        Me.ToolTipUsuarios.SetToolTip(Me.txtCodigoRecuperacionC, "Codigo de recuperacion")
        '
        'lblCodigoRecuperacionC
        '
        Me.lblCodigoRecuperacionC.AutoSize = True
        Me.lblCodigoRecuperacionC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCodigoRecuperacionC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoRecuperacionC.Location = New System.Drawing.Point(416, 253)
        Me.lblCodigoRecuperacionC.Name = "lblCodigoRecuperacionC"
        Me.lblCodigoRecuperacionC.Size = New System.Drawing.Size(175, 15)
        Me.lblCodigoRecuperacionC.TabIndex = 6
        Me.lblCodigoRecuperacionC.Text = "CODIGO DE RECUPERACIÓN:"
        '
        'txtUsuarioC
        '
        Me.txtUsuarioC.Location = New System.Drawing.Point(419, 137)
        Me.txtUsuarioC.Name = "txtUsuarioC"
        Me.txtUsuarioC.Size = New System.Drawing.Size(313, 20)
        Me.txtUsuarioC.TabIndex = 2
        Me.ToolTipUsuarios.SetToolTip(Me.txtUsuarioC, "Ingrese un usuario")
        '
        'lblUsuarioC
        '
        Me.lblUsuarioC.AutoSize = True
        Me.lblUsuarioC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblUsuarioC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioC.Location = New System.Drawing.Point(416, 119)
        Me.lblUsuarioC.Name = "lblUsuarioC"
        Me.lblUsuarioC.Size = New System.Drawing.Size(64, 15)
        Me.lblUsuarioC.TabIndex = 4
        Me.lblUsuarioC.Text = "USUARIO:"
        '
        'lblTipoUsuarioC
        '
        Me.lblTipoUsuarioC.AutoSize = True
        Me.lblTipoUsuarioC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTipoUsuarioC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuarioC.Location = New System.Drawing.Point(416, 188)
        Me.lblTipoUsuarioC.Name = "lblTipoUsuarioC"
        Me.lblTipoUsuarioC.Size = New System.Drawing.Size(94, 15)
        Me.lblTipoUsuarioC.TabIndex = 2
        Me.lblTipoUsuarioC.Text = "TIPO USUARIO:"
        '
        'txtNombreUsuarioC
        '
        Me.txtNombreUsuarioC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNombreUsuarioC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txtNombreUsuarioC.Location = New System.Drawing.Point(419, 71)
        Me.txtNombreUsuarioC.Name = "txtNombreUsuarioC"
        Me.txtNombreUsuarioC.Size = New System.Drawing.Size(313, 20)
        Me.txtNombreUsuarioC.TabIndex = 1
        Me.txtNombreUsuarioC.Tag = ""
        Me.ToolTipUsuarios.SetToolTip(Me.txtNombreUsuarioC, "Ingrese un nombre")
        '
        'lblNombreUsuarioC
        '
        Me.lblNombreUsuarioC.AutoSize = True
        Me.lblNombreUsuarioC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNombreUsuarioC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuarioC.Location = New System.Drawing.Point(416, 53)
        Me.lblNombreUsuarioC.Name = "lblNombreUsuarioC"
        Me.lblNombreUsuarioC.Size = New System.Drawing.Size(121, 15)
        Me.lblNombreUsuarioC.TabIndex = 0
        Me.lblNombreUsuarioC.Text = "NOMBRE USUARIO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 579)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'pestañaModificarU
        '
        Me.pestañaModificarU.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pestañaModificarU.Controls.Add(Me.GroupBox1)
        Me.pestañaModificarU.ImageIndex = 1
        Me.pestañaModificarU.Location = New System.Drawing.Point(4, 33)
        Me.pestañaModificarU.Name = "pestañaModificarU"
        Me.pestañaModificarU.Padding = New System.Windows.Forms.Padding(3)
        Me.pestañaModificarU.Size = New System.Drawing.Size(782, 585)
        Me.pestañaModificarU.TabIndex = 1
        Me.pestañaModificarU.Text = "MODIFICAR USUARIO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.btnModificarM)
        Me.GroupBox1.Controls.Add(Me.lblEscribirContraseñaM)
        Me.GroupBox1.Controls.Add(Me.comboTipoUsuarioM)
        Me.GroupBox1.Controls.Add(Me.lblCodigoRecuperacionM)
        Me.GroupBox1.Controls.Add(Me.comboUsuarioSeleccionadoM)
        Me.GroupBox1.Controls.Add(Me.lblVolverEscribirContraseñaM)
        Me.GroupBox1.Controls.Add(Me.txtVolverEscribirContraseñaM)
        Me.GroupBox1.Controls.Add(Me.lblInformacionM)
        Me.GroupBox1.Controls.Add(Me.txtNombreUsuarioM)
        Me.GroupBox1.Controls.Add(Me.lblUsuariosM)
        Me.GroupBox1.Controls.Add(Me.txtUsuarioM)
        Me.GroupBox1.Controls.Add(Me.txtEscribirContraseñaM)
        Me.GroupBox1.Controls.Add(Me.lblNombreUsuarioM)
        Me.GroupBox1.Controls.Add(Me.txtCodigoRecuperacionM)
        Me.GroupBox1.Controls.Add(Me.lblTipoUsuarioM)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 579)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(84, 462)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(228, 25)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "MODIFICAR USUARIO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(117, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "BIENVENIDO/A"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Inventario.My.Resources.Resources.UserEdit
        Me.PictureBox3.Location = New System.Drawing.Point(39, 73)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(332, 378)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'btnModificarM
        '
        Me.btnModificarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarM.Location = New System.Drawing.Point(429, 515)
        Me.btnModificarM.Name = "btnModificarM"
        Me.btnModificarM.Size = New System.Drawing.Size(314, 48)
        Me.btnModificarM.TabIndex = 14
        Me.btnModificarM.Text = "MO&DIFICAR"
        Me.ToolTipUsuarios.SetToolTip(Me.btnModificarM, "Modificar Usuario")
        Me.btnModificarM.UseVisualStyleBackColor = True
        '
        'lblEscribirContraseñaM
        '
        Me.lblEscribirContraseñaM.AutoSize = True
        Me.lblEscribirContraseñaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscribirContraseñaM.Location = New System.Drawing.Point(426, 383)
        Me.lblEscribirContraseñaM.Name = "lblEscribirContraseñaM"
        Me.lblEscribirContraseñaM.Size = New System.Drawing.Size(150, 15)
        Me.lblEscribirContraseñaM.TabIndex = 9
        Me.lblEscribirContraseñaM.Text = "ESCRIBIR CONTRASEÑA:"
        '
        'comboTipoUsuarioM
        '
        Me.comboTipoUsuarioM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboTipoUsuarioM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.comboTipoUsuarioM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTipoUsuarioM.FormattingEnabled = True
        Me.comboTipoUsuarioM.Items.AddRange(New Object() {"ADMINISTRADOR", "SISTEMAS", "GENERAL"})
        Me.comboTipoUsuarioM.Location = New System.Drawing.Point(429, 264)
        Me.comboTipoUsuarioM.Name = "comboTipoUsuarioM"
        Me.comboTipoUsuarioM.Size = New System.Drawing.Size(314, 23)
        Me.comboTipoUsuarioM.TabIndex = 11
        Me.comboTipoUsuarioM.Text = "SELECCIONAR"
        Me.ToolTipUsuarios.SetToolTip(Me.comboTipoUsuarioM, "Seleccione un item")
        '
        'lblCodigoRecuperacionM
        '
        Me.lblCodigoRecuperacionM.AutoSize = True
        Me.lblCodigoRecuperacionM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoRecuperacionM.Location = New System.Drawing.Point(426, 312)
        Me.lblCodigoRecuperacionM.Name = "lblCodigoRecuperacionM"
        Me.lblCodigoRecuperacionM.Size = New System.Drawing.Size(175, 15)
        Me.lblCodigoRecuperacionM.TabIndex = 5
        Me.lblCodigoRecuperacionM.Text = "CODIGO DE RECUPERACIÓN:"
        '
        'comboUsuarioSeleccionadoM
        '
        Me.comboUsuarioSeleccionadoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboUsuarioSeleccionadoM.FormattingEnabled = True
        Me.comboUsuarioSeleccionadoM.Location = New System.Drawing.Point(429, 73)
        Me.comboUsuarioSeleccionadoM.Name = "comboUsuarioSeleccionadoM"
        Me.comboUsuarioSeleccionadoM.Size = New System.Drawing.Size(314, 23)
        Me.comboUsuarioSeleccionadoM.TabIndex = 13
        Me.comboUsuarioSeleccionadoM.Text = "SELECCIONAR"
        Me.ToolTipUsuarios.SetToolTip(Me.comboUsuarioSeleccionadoM, "Seleccione un item")
        '
        'lblVolverEscribirContraseñaM
        '
        Me.lblVolverEscribirContraseñaM.AutoSize = True
        Me.lblVolverEscribirContraseñaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolverEscribirContraseñaM.Location = New System.Drawing.Point(426, 452)
        Me.lblVolverEscribirContraseñaM.Name = "lblVolverEscribirContraseñaM"
        Me.lblVolverEscribirContraseñaM.Size = New System.Drawing.Size(163, 15)
        Me.lblVolverEscribirContraseñaM.TabIndex = 10
        Me.lblVolverEscribirContraseñaM.Text = "(VERIFICAR) CONTRASEÑA:"
        '
        'txtVolverEscribirContraseñaM
        '
        Me.txtVolverEscribirContraseñaM.Location = New System.Drawing.Point(429, 473)
        Me.txtVolverEscribirContraseñaM.Name = "txtVolverEscribirContraseñaM"
        Me.txtVolverEscribirContraseñaM.Size = New System.Drawing.Size(314, 20)
        Me.txtVolverEscribirContraseñaM.TabIndex = 8
        Me.ToolTipUsuarios.SetToolTip(Me.txtVolverEscribirContraseñaM, "Ingresar nuevamente contraseña")
        '
        'lblInformacionM
        '
        Me.lblInformacionM.AutoSize = True
        Me.lblInformacionM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacionM.Location = New System.Drawing.Point(426, 52)
        Me.lblInformacionM.Name = "lblInformacionM"
        Me.lblInformacionM.Size = New System.Drawing.Size(143, 15)
        Me.lblInformacionM.TabIndex = 12
        Me.lblInformacionM.Text = "USUARIO A MODIFICAR:"
        '
        'txtNombreUsuarioM
        '
        Me.txtNombreUsuarioM.Location = New System.Drawing.Point(429, 137)
        Me.txtNombreUsuarioM.Name = "txtNombreUsuarioM"
        Me.txtNombreUsuarioM.Size = New System.Drawing.Size(314, 20)
        Me.txtNombreUsuarioM.TabIndex = 0
        Me.ToolTipUsuarios.SetToolTip(Me.txtNombreUsuarioM, "Ingrese un nombre")
        '
        'lblUsuariosM
        '
        Me.lblUsuariosM.AutoSize = True
        Me.lblUsuariosM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuariosM.Location = New System.Drawing.Point(426, 178)
        Me.lblUsuariosM.Name = "lblUsuariosM"
        Me.lblUsuariosM.Size = New System.Drawing.Size(64, 15)
        Me.lblUsuariosM.TabIndex = 7
        Me.lblUsuariosM.Text = "USUARIO:"
        '
        'txtUsuarioM
        '
        Me.txtUsuarioM.Location = New System.Drawing.Point(429, 199)
        Me.txtUsuarioM.Name = "txtUsuarioM"
        Me.txtUsuarioM.Size = New System.Drawing.Size(314, 20)
        Me.txtUsuarioM.TabIndex = 6
        Me.ToolTipUsuarios.SetToolTip(Me.txtUsuarioM, "Ingrese usuario")
        '
        'txtEscribirContraseñaM
        '
        Me.txtEscribirContraseñaM.Location = New System.Drawing.Point(429, 404)
        Me.txtEscribirContraseñaM.Name = "txtEscribirContraseñaM"
        Me.txtEscribirContraseñaM.Size = New System.Drawing.Size(314, 20)
        Me.txtEscribirContraseñaM.TabIndex = 4
        Me.ToolTipUsuarios.SetToolTip(Me.txtEscribirContraseñaM, "Ingrese contraseña")
        '
        'lblNombreUsuarioM
        '
        Me.lblNombreUsuarioM.AutoSize = True
        Me.lblNombreUsuarioM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuarioM.Location = New System.Drawing.Point(426, 116)
        Me.lblNombreUsuarioM.Name = "lblNombreUsuarioM"
        Me.lblNombreUsuarioM.Size = New System.Drawing.Size(121, 15)
        Me.lblNombreUsuarioM.TabIndex = 1
        Me.lblNombreUsuarioM.Text = "NOMBRE USUARIO:"
        '
        'txtCodigoRecuperacionM
        '
        Me.txtCodigoRecuperacionM.Location = New System.Drawing.Point(429, 333)
        Me.txtCodigoRecuperacionM.Name = "txtCodigoRecuperacionM"
        Me.txtCodigoRecuperacionM.Size = New System.Drawing.Size(314, 20)
        Me.txtCodigoRecuperacionM.TabIndex = 2
        Me.ToolTipUsuarios.SetToolTip(Me.txtCodigoRecuperacionM, "Ingrese codigo de recuperacion")
        '
        'lblTipoUsuarioM
        '
        Me.lblTipoUsuarioM.AutoSize = True
        Me.lblTipoUsuarioM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuarioM.Location = New System.Drawing.Point(426, 243)
        Me.lblTipoUsuarioM.Name = "lblTipoUsuarioM"
        Me.lblTipoUsuarioM.Size = New System.Drawing.Size(94, 15)
        Me.lblTipoUsuarioM.TabIndex = 3
        Me.lblTipoUsuarioM.Text = "TIPO USUARIO:"
        '
        'pestañaEliminarU
        '
        Me.pestañaEliminarU.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pestañaEliminarU.Controls.Add(Me.DataGridView1)
        Me.pestañaEliminarU.ImageIndex = 2
        Me.pestañaEliminarU.Location = New System.Drawing.Point(4, 33)
        Me.pestañaEliminarU.Name = "pestañaEliminarU"
        Me.pestañaEliminarU.Padding = New System.Windows.Forms.Padding(3)
        Me.pestañaEliminarU.Size = New System.Drawing.Size(782, 585)
        Me.pestañaEliminarU.TabIndex = 2
        Me.pestañaEliminarU.Text = "ELIMINAR USUARIO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(776, 158)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.HeaderText = "ELIMINAR"
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnEliminar.Text = "Borrar"
        Me.btnEliminar.ToolTipText = "Columna Eliminar"
        Me.btnEliminar.UseColumnTextForButtonValue = True
        Me.btnEliminar.Width = 70
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "CrearUsuario.png")
        Me.ImageList1.Images.SetKeyName(1, "EditarUsuario.png")
        Me.ImageList1.Images.SetKeyName(2, "EliminarUsuario.png")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(377, 242)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ESCRIBIR CONTRASEÑA:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(378, 199)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(245, 20)
        Me.TextBox3.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "CODIGO DE RECUPERACIÓN:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(377, 121)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(246, 20)
        Me.TextBox4.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "USUARIO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TIPO USUARIO:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(377, 75)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(246, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(107, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "NOMBRE USUARIO:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(72, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 676)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tabUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.tabUsuarios.ResumeLayout(False)
        Me.pestañaCrearU.ResumeLayout(False)
        Me.pestañaCrearU.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pestañaModificarU.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pestañaEliminarU.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents tabUsuarios As TabControl
    Friend WithEvents pestañaCrearU As TabPage
    Friend WithEvents btnRegistrarUsuarioC As Button
    Friend WithEvents txtVerificarContraseñaC As TextBox
    Friend WithEvents lblVerificarContraseñaC As Label
    Friend WithEvents txtContraseñaC As TextBox
    Friend WithEvents lblContraseñaC As Label
    Friend WithEvents txtCodigoRecuperacionC As TextBox
    Friend WithEvents lblCodigoRecuperacionC As Label
    Friend WithEvents txtUsuarioC As TextBox
    Friend WithEvents lblUsuarioC As Label
    Friend WithEvents lblTipoUsuarioC As Label
    Friend WithEvents txtNombreUsuarioC As TextBox
    Friend WithEvents lblNombreUsuarioC As Label
    Friend WithEvents pestañaModificarU As TabPage
    Friend WithEvents pestañaEliminarU As TabPage
    Friend WithEvents btnBorrarC As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents comboTipoUsuarioC As ComboBox

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblVolverEscribirContraseñaM As Label
    Friend WithEvents lblEscribirContraseñaM As Label
    Friend WithEvents txtVolverEscribirContraseñaM As TextBox
    Friend WithEvents lblUsuariosM As Label
    Friend WithEvents txtUsuarioM As TextBox
    Friend WithEvents lblCodigoRecuperacionM As Label
    Friend WithEvents txtEscribirContraseñaM As TextBox
    Friend WithEvents lblTipoUsuarioM As Label
    Friend WithEvents txtCodigoRecuperacionM As TextBox
    Friend WithEvents lblNombreUsuarioM As Label
    Friend WithEvents txtNombreUsuarioM As TextBox
    Friend WithEvents comboTipoUsuarioM As ComboBox
    Friend WithEvents comboUsuarioSeleccionadoM As ComboBox
    Friend WithEvents lblInformacionM As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModificarM As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelRecomendacion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminar As DataGridViewButtonColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolTipUsuarios As ToolTip
End Class
