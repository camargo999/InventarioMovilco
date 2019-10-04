<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloReportes = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.comboRemitenteR = New System.Windows.Forms.ComboBox()
        Me.btnGuardarReporte = New System.Windows.Forms.Button()
        Me.btnImprimirRep = New System.Windows.Forms.Button()
        Me.ListBoxArticulos = New System.Windows.Forms.ListBox()
        Me.comboDestinatarioR = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabMovimientosR = New System.Windows.Forms.TabPage()
        Me.ButtonExp = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.RadioButtonInsertarND = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModificar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEliminar = New System.Windows.Forms.RadioButton()
        Me.ButtonInsertarND = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblIdInvisible = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEditarCargo = New System.Windows.Forms.TextBox()
        Me.txtEditarCelular = New System.Windows.Forms.TextBox()
        Me.txtEditarDireccion = New System.Windows.Forms.TextBox()
        Me.txtEditarCuidar = New System.Windows.Forms.TextBox()
        Me.txtEditarEncargado = New System.Windows.Forms.TextBox()
        Me.txtEditarOficina = New System.Windows.Forms.TextBox()
        Me.btnActualizarItem = New System.Windows.Forms.Button()
        Me.btnEliminarRe = New System.Windows.Forms.Button()
        Me.DataGridMov = New System.Windows.Forms.DataGridView()
        Me.tabRemisiones = New System.Windows.Forms.TabPage()
        Me.TextBoxRemitente = New System.Windows.Forms.TextBox()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioActivos = New System.Windows.Forms.RadioButton()
        Me.RadioSistemas = New System.Windows.Forms.RadioButton()
        Me.PanelVista = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblOcultoId = New System.Windows.Forms.Label()
        Me.lblTelef = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblParaDestinatario = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFechaDest = New System.Windows.Forms.Label()
        Me.lblCyD = New System.Windows.Forms.Label()
        Me.lblDireccionDest = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOficinaDest = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEncargadoDest = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBoxObserv = New System.Windows.Forms.TextBox()
        Me.lblObservacionesR = New System.Windows.Forms.Label()
        Me.lblCargoRemit = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNumeroRemision = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCelularRemit = New System.Windows.Forms.Label()
        Me.lblDireccionRemit = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblOficinaRemit = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblDeRemit = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblIdInventario1 = New System.Windows.Forms.Label()
        Me.lblIdInventario0 = New System.Windows.Forms.Label()
        Me.LabelArticulo = New System.Windows.Forms.Label()
        Me.lblRemit = New System.Windows.Forms.Label()
        Me.lblDestin = New System.Windows.Forms.Label()
        Me.LabelElemento = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPageMostrarR = New System.Windows.Forms.TabPage()
        Me.TextBoxCantidadR = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBoxMostrarI = New System.Windows.Forms.PictureBox()
        Me.ButtonDescargarIMG = New System.Windows.Forms.Button()
        Me.ButtonImprimirFoto = New System.Windows.Forms.Button()
        Me.LabelNumeroRemision = New System.Windows.Forms.Label()
        Me.ButtonMostrarR = New System.Windows.Forms.Button()
        Me.TextBoxMostrarImg = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTipRemisiones = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument22 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog22 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog22 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1.SuspendLayout()
        Me.tabMovimientosR.SuspendLayout()
        CType(Me.DataGridMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRemisiones.SuspendLayout()
        Me.PanelVista.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMostrarR.SuspendLayout()
        CType(Me.PictureBoxMostrarI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloReportes
        '
        Me.lblTituloReportes.AutoSize = True
        Me.lblTituloReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloReportes.ForeColor = System.Drawing.Color.Black
        Me.lblTituloReportes.Location = New System.Drawing.Point(290, 9)
        Me.lblTituloReportes.Name = "lblTituloReportes"
        Me.lblTituloReportes.Size = New System.Drawing.Size(195, 31)
        Me.lblTituloReportes.TabIndex = 3
        Me.lblTituloReportes.Text = "REMISIONES"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'comboRemitenteR
        '
        Me.comboRemitenteR.BackColor = System.Drawing.Color.LightSlateGray
        Me.comboRemitenteR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboRemitenteR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRemitenteR.ForeColor = System.Drawing.Color.White
        Me.comboRemitenteR.FormattingEnabled = True
        Me.comboRemitenteR.Location = New System.Drawing.Point(25, 74)
        Me.comboRemitenteR.Name = "comboRemitenteR"
        Me.comboRemitenteR.Size = New System.Drawing.Size(184, 26)
        Me.comboRemitenteR.TabIndex = 42
        Me.comboRemitenteR.Text = "Seleccionar"
        Me.ToolTipRemisiones.SetToolTip(Me.comboRemitenteR, "Seleccione un item")
        '
        'btnGuardarReporte
        '
        Me.btnGuardarReporte.BackColor = System.Drawing.Color.Black
        Me.btnGuardarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGuardarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarReporte.ForeColor = System.Drawing.Color.White
        Me.btnGuardarReporte.Location = New System.Drawing.Point(10, 526)
        Me.btnGuardarReporte.Name = "btnGuardarReporte"
        Me.btnGuardarReporte.Size = New System.Drawing.Size(378, 57)
        Me.btnGuardarReporte.TabIndex = 38
        Me.btnGuardarReporte.Text = "GU&ARDAR REPORTE"
        Me.ToolTipRemisiones.SetToolTip(Me.btnGuardarReporte, "Guardar reporte")
        Me.btnGuardarReporte.UseVisualStyleBackColor = False
        '
        'btnImprimirRep
        '
        Me.btnImprimirRep.BackColor = System.Drawing.Color.Black
        Me.btnImprimirRep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnImprimirRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnImprimirRep.ForeColor = System.Drawing.Color.White
        Me.btnImprimirRep.Location = New System.Drawing.Point(394, 526)
        Me.btnImprimirRep.Name = "btnImprimirRep"
        Me.btnImprimirRep.Size = New System.Drawing.Size(378, 57)
        Me.btnImprimirRep.TabIndex = 6
        Me.btnImprimirRep.Text = "&IMPRIMIR REPORTE"
        Me.ToolTipRemisiones.SetToolTip(Me.btnImprimirRep, "Imprimir reporte")
        Me.btnImprimirRep.UseVisualStyleBackColor = False
        '
        'ListBoxArticulos
        '
        Me.ListBoxArticulos.BackColor = System.Drawing.Color.LightSlateGray
        Me.ListBoxArticulos.Enabled = False
        Me.ListBoxArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxArticulos.ForeColor = System.Drawing.Color.White
        Me.ListBoxArticulos.FormattingEnabled = True
        Me.ListBoxArticulos.ItemHeight = 15
        Me.ListBoxArticulos.Location = New System.Drawing.Point(11, 56)
        Me.ListBoxArticulos.Name = "ListBoxArticulos"
        Me.ListBoxArticulos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxArticulos.Size = New System.Drawing.Size(204, 214)
        Me.ListBoxArticulos.TabIndex = 49
        Me.ToolTipRemisiones.SetToolTip(Me.ListBoxArticulos, "Seleccione seriales")
        Me.ListBoxArticulos.Visible = False
        '
        'comboDestinatarioR
        '
        Me.comboDestinatarioR.BackColor = System.Drawing.Color.LightSlateGray
        Me.comboDestinatarioR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboDestinatarioR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboDestinatarioR.ForeColor = System.Drawing.Color.White
        Me.comboDestinatarioR.FormattingEnabled = True
        Me.comboDestinatarioR.Location = New System.Drawing.Point(393, 33)
        Me.comboDestinatarioR.Name = "comboDestinatarioR"
        Me.comboDestinatarioR.Size = New System.Drawing.Size(185, 24)
        Me.comboDestinatarioR.TabIndex = 41
        Me.comboDestinatarioR.Text = "Seleccionar"
        Me.ToolTipRemisiones.SetToolTip(Me.comboDestinatarioR, "Seleccione un item")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMovimientosR)
        Me.TabControl1.Controls.Add(Me.tabRemisiones)
        Me.TabControl1.Controls.Add(Me.TabPageMostrarR)
        Me.TabControl1.Location = New System.Drawing.Point(0, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(790, 620)
        Me.TabControl1.TabIndex = 39
        '
        'tabMovimientosR
        '
        Me.tabMovimientosR.Controls.Add(Me.ButtonExp)
        Me.tabMovimientosR.Controls.Add(Me.Label26)
        Me.tabMovimientosR.Controls.Add(Me.RadioButtonInsertarND)
        Me.tabMovimientosR.Controls.Add(Me.RadioButtonModificar)
        Me.tabMovimientosR.Controls.Add(Me.RadioButtonEliminar)
        Me.tabMovimientosR.Controls.Add(Me.ButtonInsertarND)
        Me.tabMovimientosR.Controls.Add(Me.Label25)
        Me.tabMovimientosR.Controls.Add(Me.lblIdInvisible)
        Me.tabMovimientosR.Controls.Add(Me.Label24)
        Me.tabMovimientosR.Controls.Add(Me.Label23)
        Me.tabMovimientosR.Controls.Add(Me.Label14)
        Me.tabMovimientosR.Controls.Add(Me.Label13)
        Me.tabMovimientosR.Controls.Add(Me.Label11)
        Me.tabMovimientosR.Controls.Add(Me.Label10)
        Me.tabMovimientosR.Controls.Add(Me.Label2)
        Me.tabMovimientosR.Controls.Add(Me.txtEditarCargo)
        Me.tabMovimientosR.Controls.Add(Me.txtEditarCelular)
        Me.tabMovimientosR.Controls.Add(Me.txtEditarDireccion)
        Me.tabMovimientosR.Controls.Add(Me.txtEditarCuidar)
        Me.tabMovimientosR.Controls.Add(Me.txtEditarEncargado)
        Me.tabMovimientosR.Controls.Add(Me.txtEditarOficina)
        Me.tabMovimientosR.Controls.Add(Me.btnActualizarItem)
        Me.tabMovimientosR.Controls.Add(Me.btnEliminarRe)
        Me.tabMovimientosR.Controls.Add(Me.DataGridMov)
        Me.tabMovimientosR.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMovimientosR.Location = New System.Drawing.Point(4, 22)
        Me.tabMovimientosR.Name = "tabMovimientosR"
        Me.tabMovimientosR.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMovimientosR.Size = New System.Drawing.Size(782, 594)
        Me.tabMovimientosR.TabIndex = 1
        Me.tabMovimientosR.Text = "COORDINADORES"
        Me.tabMovimientosR.UseVisualStyleBackColor = True
        '
        'ButtonExp
        '
        Me.ButtonExp.BackColor = System.Drawing.Color.Teal
        Me.ButtonExp.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.ButtonExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExp.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExp.ForeColor = System.Drawing.Color.Maroon
        Me.ButtonExp.Location = New System.Drawing.Point(696, 383)
        Me.ButtonExp.Name = "ButtonExp"
        Me.ButtonExp.Size = New System.Drawing.Size(78, 26)
        Me.ButtonExp.TabIndex = 30
        Me.ButtonExp.Text = "EXPORTAR"
        Me.ToolTipRemisiones.SetToolTip(Me.ButtonExp, "Exportar contenido de tabla")
        Me.ButtonExp.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(20, 383)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(203, 14)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Elija la opcion que desea realizar?.."
        '
        'RadioButtonInsertarND
        '
        Me.RadioButtonInsertarND.AutoSize = True
        Me.RadioButtonInsertarND.BackColor = System.Drawing.Color.SkyBlue
        Me.RadioButtonInsertarND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonInsertarND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonInsertarND.Location = New System.Drawing.Point(441, 382)
        Me.RadioButtonInsertarND.Name = "RadioButtonInsertarND"
        Me.RadioButtonInsertarND.Size = New System.Drawing.Size(80, 18)
        Me.RadioButtonInsertarND.TabIndex = 28
        Me.RadioButtonInsertarND.Text = "INGRESAR "
        Me.ToolTipRemisiones.SetToolTip(Me.RadioButtonInsertarND, "Elegir para ingresar")
        Me.RadioButtonInsertarND.UseVisualStyleBackColor = False
        '
        'RadioButtonModificar
        '
        Me.RadioButtonModificar.AutoSize = True
        Me.RadioButtonModificar.BackColor = System.Drawing.Color.SkyBlue
        Me.RadioButtonModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonModificar.Location = New System.Drawing.Point(333, 382)
        Me.RadioButtonModificar.Name = "RadioButtonModificar"
        Me.RadioButtonModificar.Size = New System.Drawing.Size(84, 18)
        Me.RadioButtonModificar.TabIndex = 27
        Me.RadioButtonModificar.Text = "MODIFICAR"
        Me.ToolTipRemisiones.SetToolTip(Me.RadioButtonModificar, "Elegir para modificar")
        Me.RadioButtonModificar.UseVisualStyleBackColor = False
        '
        'RadioButtonEliminar
        '
        Me.RadioButtonEliminar.AutoSize = True
        Me.RadioButtonEliminar.BackColor = System.Drawing.Color.SkyBlue
        Me.RadioButtonEliminar.Checked = True
        Me.RadioButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonEliminar.Location = New System.Drawing.Point(231, 382)
        Me.RadioButtonEliminar.Name = "RadioButtonEliminar"
        Me.RadioButtonEliminar.Size = New System.Drawing.Size(75, 18)
        Me.RadioButtonEliminar.TabIndex = 26
        Me.RadioButtonEliminar.TabStop = True
        Me.RadioButtonEliminar.Text = "ELIMINAR"
        Me.ToolTipRemisiones.SetToolTip(Me.RadioButtonEliminar, "Elegir para eliminar")
        Me.RadioButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonInsertarND
        '
        Me.ButtonInsertarND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonInsertarND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonInsertarND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsertarND.Location = New System.Drawing.Point(554, 539)
        Me.ButtonInsertarND.Name = "ButtonInsertarND"
        Me.ButtonInsertarND.Size = New System.Drawing.Size(223, 43)
        Me.ButtonInsertarND.TabIndex = 25
        Me.ButtonInsertarND.Text = "&INGRESAR NUEVO"
        Me.ToolTipRemisiones.SetToolTip(Me.ButtonInsertarND, "Ingresar nuevo registro")
        Me.ButtonInsertarND.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.SkyBlue
        Me.Label25.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(156, 5)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(463, 26)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "DATOS CORRESPONDIENTES A COORDINADORES CVS"
        '
        'lblIdInvisible
        '
        Me.lblIdInvisible.AutoSize = True
        Me.lblIdInvisible.Location = New System.Drawing.Point(10, 557)
        Me.lblIdInvisible.Name = "lblIdInvisible"
        Me.lblIdInvisible.Size = New System.Drawing.Size(18, 14)
        Me.lblIdInvisible.TabIndex = 20
        Me.lblIdInvisible.Text = "id"
        Me.lblIdInvisible.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(297, 419)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(197, 23)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "DATOS SELECCIONADOS"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(551, 490)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 14)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Cargo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(273, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 14)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Celular"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 490)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 14)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(554, 449)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 14)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Dep/Ciudad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(273, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Encargado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Oficina"
        '
        'txtEditarCargo
        '
        Me.txtEditarCargo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEditarCargo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditarCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEditarCargo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditarCargo.Location = New System.Drawing.Point(554, 507)
        Me.txtEditarCargo.Name = "txtEditarCargo"
        Me.txtEditarCargo.Size = New System.Drawing.Size(223, 16)
        Me.txtEditarCargo.TabIndex = 12
        Me.ToolTipRemisiones.SetToolTip(Me.txtEditarCargo, "Cargo")
        '
        'txtEditarCelular
        '
        Me.txtEditarCelular.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEditarCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditarCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEditarCelular.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditarCelular.Location = New System.Drawing.Point(276, 507)
        Me.txtEditarCelular.Name = "txtEditarCelular"
        Me.txtEditarCelular.Size = New System.Drawing.Size(232, 16)
        Me.txtEditarCelular.TabIndex = 11
        Me.ToolTipRemisiones.SetToolTip(Me.txtEditarCelular, "Numero telefonico")
        '
        'txtEditarDireccion
        '
        Me.txtEditarDireccion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEditarDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditarDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEditarDireccion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditarDireccion.Location = New System.Drawing.Point(5, 505)
        Me.txtEditarDireccion.Name = "txtEditarDireccion"
        Me.txtEditarDireccion.Size = New System.Drawing.Size(226, 16)
        Me.txtEditarDireccion.TabIndex = 10
        Me.ToolTipRemisiones.SetToolTip(Me.txtEditarDireccion, "Direccion")
        '
        'txtEditarCuidar
        '
        Me.txtEditarCuidar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEditarCuidar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditarCuidar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEditarCuidar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditarCuidar.Location = New System.Drawing.Point(554, 464)
        Me.txtEditarCuidar.Name = "txtEditarCuidar"
        Me.txtEditarCuidar.Size = New System.Drawing.Size(223, 16)
        Me.txtEditarCuidar.TabIndex = 9
        Me.ToolTipRemisiones.SetToolTip(Me.txtEditarCuidar, "Ciudad y departamento")
        '
        'txtEditarEncargado
        '
        Me.txtEditarEncargado.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEditarEncargado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditarEncargado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEditarEncargado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditarEncargado.Location = New System.Drawing.Point(276, 464)
        Me.txtEditarEncargado.Name = "txtEditarEncargado"
        Me.txtEditarEncargado.Size = New System.Drawing.Size(232, 16)
        Me.txtEditarEncargado.TabIndex = 8
        Me.ToolTipRemisiones.SetToolTip(Me.txtEditarEncargado, "Encargado")
        '
        'txtEditarOficina
        '
        Me.txtEditarOficina.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEditarOficina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditarOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEditarOficina.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditarOficina.Location = New System.Drawing.Point(5, 464)
        Me.txtEditarOficina.Name = "txtEditarOficina"
        Me.txtEditarOficina.Size = New System.Drawing.Size(226, 16)
        Me.txtEditarOficina.TabIndex = 7
        Me.ToolTipRemisiones.SetToolTip(Me.txtEditarOficina, "Oficina")
        '
        'btnActualizarItem
        '
        Me.btnActualizarItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnActualizarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnActualizarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarItem.Location = New System.Drawing.Point(276, 539)
        Me.btnActualizarItem.Name = "btnActualizarItem"
        Me.btnActualizarItem.Size = New System.Drawing.Size(232, 43)
        Me.btnActualizarItem.TabIndex = 6
        Me.btnActualizarItem.Text = "&ACTUALIZAR DATOS"
        Me.ToolTipRemisiones.SetToolTip(Me.btnActualizarItem, "Actualizar seleccion")
        Me.btnActualizarItem.UseVisualStyleBackColor = True
        '
        'btnEliminarRe
        '
        Me.btnEliminarRe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnEliminarRe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnEliminarRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRe.Location = New System.Drawing.Point(6, 539)
        Me.btnEliminarRe.Name = "btnEliminarRe"
        Me.btnEliminarRe.Size = New System.Drawing.Size(223, 44)
        Me.btnEliminarRe.TabIndex = 5
        Me.btnEliminarRe.Text = "&ELIMINAR DATOS"
        Me.ToolTipRemisiones.SetToolTip(Me.btnEliminarRe, "Eliminar seleccion")
        Me.btnEliminarRe.UseVisualStyleBackColor = True
        '
        'DataGridMov
        '
        Me.DataGridMov.AllowUserToAddRows = False
        Me.DataGridMov.AllowUserToDeleteRows = False
        Me.DataGridMov.AllowUserToResizeColumns = False
        Me.DataGridMov.AllowUserToResizeRows = False
        Me.DataGridMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridMov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridMov.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridMov.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMov.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMov.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridMov.EnableHeadersVisualStyles = False
        Me.DataGridMov.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridMov.Location = New System.Drawing.Point(3, 35)
        Me.DataGridMov.MultiSelect = False
        Me.DataGridMov.Name = "DataGridMov"
        Me.DataGridMov.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMov.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridMov.RowHeadersVisible = False
        Me.DataGridMov.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMov.Size = New System.Drawing.Size(776, 333)
        Me.DataGridMov.TabIndex = 0
        '
        'tabRemisiones
        '
        Me.tabRemisiones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tabRemisiones.Controls.Add(Me.TextBoxRemitente)
        Me.tabRemisiones.Controls.Add(Me.TextBoxBusqueda)
        Me.tabRemisiones.Controls.Add(Me.Label5)
        Me.tabRemisiones.Controls.Add(Me.ListBoxArticulos)
        Me.tabRemisiones.Controls.Add(Me.RadioActivos)
        Me.tabRemisiones.Controls.Add(Me.RadioSistemas)
        Me.tabRemisiones.Controls.Add(Me.PanelVista)
        Me.tabRemisiones.Controls.Add(Me.lblIdInventario1)
        Me.tabRemisiones.Controls.Add(Me.lblIdInventario0)
        Me.tabRemisiones.Controls.Add(Me.LabelArticulo)
        Me.tabRemisiones.Controls.Add(Me.lblRemit)
        Me.tabRemisiones.Controls.Add(Me.lblDestin)
        Me.tabRemisiones.Controls.Add(Me.comboDestinatarioR)
        Me.tabRemisiones.Controls.Add(Me.btnGuardarReporte)
        Me.tabRemisiones.Controls.Add(Me.btnImprimirRep)
        Me.tabRemisiones.Controls.Add(Me.LabelElemento)
        Me.tabRemisiones.Controls.Add(Me.PictureBox3)
        Me.tabRemisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRemisiones.Location = New System.Drawing.Point(4, 22)
        Me.tabRemisiones.Name = "tabRemisiones"
        Me.tabRemisiones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRemisiones.Size = New System.Drawing.Size(782, 594)
        Me.tabRemisiones.TabIndex = 0
        Me.tabRemisiones.Text = "REMISIONES"
        '
        'TextBoxRemitente
        '
        Me.TextBoxRemitente.BackColor = System.Drawing.Color.LightSlateGray
        Me.TextBoxRemitente.Location = New System.Drawing.Point(588, 35)
        Me.TextBoxRemitente.Name = "TextBoxRemitente"
        Me.TextBoxRemitente.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxRemitente.TabIndex = 59
        '
        'TextBoxBusqueda
        '
        Me.TextBoxBusqueda.BackColor = System.Drawing.Color.LightSlateGray
        Me.TextBoxBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusqueda.Location = New System.Drawing.Point(11, 34)
        Me.TextBoxBusqueda.Name = "TextBoxBusqueda"
        Me.TextBoxBusqueda.Size = New System.Drawing.Size(185, 22)
        Me.TextBoxBusqueda.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(247, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Tipo de inventario"
        '
        'RadioActivos
        '
        Me.RadioActivos.AutoSize = True
        Me.RadioActivos.Location = New System.Drawing.Point(249, 45)
        Me.RadioActivos.Name = "RadioActivos"
        Me.RadioActivos.Size = New System.Drawing.Size(63, 17)
        Me.RadioActivos.TabIndex = 56
        Me.RadioActivos.Text = "Activos."
        Me.ToolTipRemisiones.SetToolTip(Me.RadioActivos, "Inventario activos")
        Me.RadioActivos.UseVisualStyleBackColor = True
        '
        'RadioSistemas
        '
        Me.RadioSistemas.AutoSize = True
        Me.RadioSistemas.Checked = True
        Me.RadioSistemas.Location = New System.Drawing.Point(249, 30)
        Me.RadioSistemas.Name = "RadioSistemas"
        Me.RadioSistemas.Size = New System.Drawing.Size(70, 17)
        Me.RadioSistemas.TabIndex = 55
        Me.RadioSistemas.TabStop = True
        Me.RadioSistemas.Text = "Sistemas."
        Me.ToolTipRemisiones.SetToolTip(Me.RadioSistemas, "Inventario sistemas")
        Me.RadioSistemas.UseVisualStyleBackColor = True
        '
        'PanelVista
        '
        Me.PanelVista.Controls.Add(Me.Panel2)
        Me.PanelVista.Controls.Add(Me.Panel3)
        Me.PanelVista.Location = New System.Drawing.Point(3, 67)
        Me.PanelVista.Name = "PanelVista"
        Me.PanelVista.Size = New System.Drawing.Size(776, 451)
        Me.PanelVista.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lblOcultoId)
        Me.Panel2.Controls.Add(Me.lblTelef)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblParaDestinatario)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lblFechaDest)
        Me.Panel2.Controls.Add(Me.lblCyD)
        Me.Panel2.Controls.Add(Me.lblDireccionDest)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblOficinaDest)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblEncargadoDest)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(6, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 443)
        Me.Panel2.TabIndex = 41
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Inventario.My.Resources.Resources.movilco
        Me.PictureBox2.Location = New System.Drawing.Point(252, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'lblOcultoId
        '
        Me.lblOcultoId.AutoSize = True
        Me.lblOcultoId.Location = New System.Drawing.Point(13, 55)
        Me.lblOcultoId.Name = "lblOcultoId"
        Me.lblOcultoId.Size = New System.Drawing.Size(16, 13)
        Me.lblOcultoId.TabIndex = 45
        Me.lblOcultoId.Text = "---"
        Me.lblOcultoId.Visible = False
        '
        'lblTelef
        '
        Me.lblTelef.AutoSize = True
        Me.lblTelef.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelef.Location = New System.Drawing.Point(62, 359)
        Me.lblTelef.Name = "lblTelef"
        Me.lblTelef.Size = New System.Drawing.Size(0, 13)
        Me.lblTelef.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Telefono:"
        '
        'lblParaDestinatario
        '
        Me.lblParaDestinatario.AutoSize = True
        Me.lblParaDestinatario.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParaDestinatario.Location = New System.Drawing.Point(62, 101)
        Me.lblParaDestinatario.Name = "lblParaDestinatario"
        Me.lblParaDestinatario.Size = New System.Drawing.Size(0, 13)
        Me.lblParaDestinatario.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(249, 30)
        Me.Panel4.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESTINATARIO"
        '
        'lblFechaDest
        '
        Me.lblFechaDest.AutoSize = True
        Me.lblFechaDest.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDest.Location = New System.Drawing.Point(37, 413)
        Me.lblFechaDest.Name = "lblFechaDest"
        Me.lblFechaDest.Size = New System.Drawing.Size(0, 13)
        Me.lblFechaDest.TabIndex = 22
        '
        'lblCyD
        '
        Me.lblCyD.AutoSize = True
        Me.lblCyD.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCyD.Location = New System.Drawing.Point(62, 309)
        Me.lblCyD.Name = "lblCyD"
        Me.lblCyD.Size = New System.Drawing.Size(0, 13)
        Me.lblCyD.TabIndex = 37
        '
        'lblDireccionDest
        '
        Me.lblDireccionDest.AutoSize = True
        Me.lblDireccionDest.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionDest.Location = New System.Drawing.Point(62, 248)
        Me.lblDireccionDest.Name = "lblDireccionDest"
        Me.lblDireccionDest.Size = New System.Drawing.Size(0, 13)
        Me.lblDireccionDest.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Para:"
        '
        'lblOficinaDest
        '
        Me.lblOficinaDest.AutoSize = True
        Me.lblOficinaDest.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOficinaDest.Location = New System.Drawing.Point(62, 204)
        Me.lblOficinaDest.Name = "lblOficinaDest"
        Me.lblOficinaDest.Size = New System.Drawing.Size(0, 13)
        Me.lblOficinaDest.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cargo:"
        '
        'lblEncargadoDest
        '
        Me.lblEncargadoDest.AutoSize = True
        Me.lblEncargadoDest.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargadoDest.Location = New System.Drawing.Point(62, 156)
        Me.lblEncargadoDest.Name = "lblEncargadoDest"
        Me.lblEncargadoDest.Size = New System.Drawing.Size(0, 13)
        Me.lblEncargadoDest.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Oficina:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Direccion:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Ciudad y Departamento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 395)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Fecha de Tramite:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(378, 441)
        Me.ShapeContainer1.TabIndex = 46
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 12
        Me.LineShape8.X2 = 356
        Me.LineShape8.Y1 = 435
        Me.LineShape8.Y2 = 435
        '
        'LineShape7
        '
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 12
        Me.LineShape7.X2 = 356
        Me.LineShape7.Y1 = 386
        Me.LineShape7.Y2 = 386
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 12
        Me.LineShape6.X2 = 356
        Me.LineShape6.Y1 = 333
        Me.LineShape6.Y2 = 333
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 12
        Me.LineShape5.X2 = 356
        Me.LineShape5.Y1 = 278
        Me.LineShape5.Y2 = 278
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 12
        Me.LineShape4.X2 = 356
        Me.LineShape4.Y1 = 227
        Me.LineShape4.Y2 = 227
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 12
        Me.LineShape2.X2 = 356
        Me.LineShape2.Y1 = 175
        Me.LineShape2.Y2 = 175
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 356
        Me.LineShape1.Y1 = 121
        Me.LineShape1.Y2 = 121
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.comboRemitenteR)
        Me.Panel3.Controls.Add(Me.TextBoxObserv)
        Me.Panel3.Controls.Add(Me.lblObservacionesR)
        Me.Panel3.Controls.Add(Me.lblCargoRemit)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.lblCelularRemit)
        Me.Panel3.Controls.Add(Me.lblDireccionRemit)
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Controls.Add(Me.lblOficinaRemit)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.lblDeRemit)
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.Location = New System.Drawing.Point(390, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 443)
        Me.Panel3.TabIndex = 40
        '
        'TextBoxObserv
        '
        Me.TextBoxObserv.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxObserv.Location = New System.Drawing.Point(12, 375)
        Me.TextBoxObserv.Multiline = True
        Me.TextBoxObserv.Name = "TextBoxObserv"
        Me.TextBoxObserv.Size = New System.Drawing.Size(351, 51)
        Me.TextBoxObserv.TabIndex = 47
        Me.ToolTipRemisiones.SetToolTip(Me.TextBoxObserv, "Ingresar observaciones")
        '
        'lblObservacionesR
        '
        Me.lblObservacionesR.AutoSize = True
        Me.lblObservacionesR.Location = New System.Drawing.Point(9, 359)
        Me.lblObservacionesR.Name = "lblObservacionesR"
        Me.lblObservacionesR.Size = New System.Drawing.Size(81, 13)
        Me.lblObservacionesR.TabIndex = 39
        Me.lblObservacionesR.Text = "Observaciones:"
        '
        'lblCargoRemit
        '
        Me.lblCargoRemit.AutoSize = True
        Me.lblCargoRemit.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoRemit.Location = New System.Drawing.Point(63, 156)
        Me.lblCargoRemit.Name = "lblCargoRemit"
        Me.lblCargoRemit.Size = New System.Drawing.Size(0, 13)
        Me.lblCargoRemit.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblNumeroRemision)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 35)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Remision N°:"
        '
        'lblNumeroRemision
        '
        Me.lblNumeroRemision.AutoSize = True
        Me.lblNumeroRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroRemision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNumeroRemision.Location = New System.Drawing.Point(69, 11)
        Me.lblNumeroRemision.Name = "lblNumeroRemision"
        Me.lblNumeroRemision.Size = New System.Drawing.Size(25, 20)
        Me.lblNumeroRemision.TabIndex = 39
        Me.lblNumeroRemision.Text = "N°"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(248, 30)
        Me.Panel5.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-1, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "REMITENTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Inventario.My.Resources.Resources.movilco
        Me.PictureBox1.Location = New System.Drawing.Point(252, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblCelularRemit
        '
        Me.lblCelularRemit.AutoSize = True
        Me.lblCelularRemit.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelularRemit.Location = New System.Drawing.Point(63, 309)
        Me.lblCelularRemit.Name = "lblCelularRemit"
        Me.lblCelularRemit.Size = New System.Drawing.Size(0, 13)
        Me.lblCelularRemit.TabIndex = 37
        '
        'lblDireccionRemit
        '
        Me.lblDireccionRemit.AutoSize = True
        Me.lblDireccionRemit.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionRemit.Location = New System.Drawing.Point(63, 248)
        Me.lblDireccionRemit.Name = "lblDireccionRemit"
        Me.lblDireccionRemit.Size = New System.Drawing.Size(0, 13)
        Me.lblDireccionRemit.TabIndex = 36
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(9, 96)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(24, 13)
        Me.Label38.TabIndex = 23
        Me.Label38.Text = "De:"
        '
        'lblOficinaRemit
        '
        Me.lblOficinaRemit.AutoSize = True
        Me.lblOficinaRemit.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOficinaRemit.Location = New System.Drawing.Point(63, 204)
        Me.lblOficinaRemit.Name = "lblOficinaRemit"
        Me.lblOficinaRemit.Size = New System.Drawing.Size(0, 13)
        Me.lblOficinaRemit.TabIndex = 35
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(9, 135)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(38, 13)
        Me.Label37.TabIndex = 24
        Me.Label37.Text = "Cargo:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(9, 187)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = "Oficina:"
        '
        'lblDeRemit
        '
        Me.lblDeRemit.AutoSize = True
        Me.lblDeRemit.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeRemit.Location = New System.Drawing.Point(63, 101)
        Me.lblDeRemit.Name = "lblDeRemit"
        Me.lblDeRemit.Size = New System.Drawing.Size(0, 13)
        Me.lblDeRemit.TabIndex = 33
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(9, 237)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 13)
        Me.Label35.TabIndex = 26
        Me.Label35.Text = "Direccion:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 289)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(109, 13)
        Me.Label34.TabIndex = 27
        Me.Label34.Text = "Celular  y/o Telefono:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape12, Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(378, 441)
        Me.ShapeContainer2.TabIndex = 43
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape12
        '
        Me.LineShape12.Name = "LineShape12"
        Me.LineShape12.X1 = 16
        Me.LineShape12.X2 = 362
        Me.LineShape12.Y1 = 333
        Me.LineShape12.Y2 = 333
        '
        'LineShape11
        '
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 16
        Me.LineShape11.X2 = 362
        Me.LineShape11.Y1 = 227
        Me.LineShape11.Y2 = 227
        '
        'LineShape10
        '
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 12
        Me.LineShape10.X2 = 362
        Me.LineShape10.Y1 = 175
        Me.LineShape10.Y2 = 175
        '
        'LineShape9
        '
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 12
        Me.LineShape9.X2 = 365
        Me.LineShape9.Y1 = 122
        Me.LineShape9.Y2 = 122
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 16
        Me.LineShape3.X2 = 362
        Me.LineShape3.Y1 = 280
        Me.LineShape3.Y2 = 280
        '
        'lblIdInventario1
        '
        Me.lblIdInventario1.AutoSize = True
        Me.lblIdInventario1.Location = New System.Drawing.Point(14, 563)
        Me.lblIdInventario1.Name = "lblIdInventario1"
        Me.lblIdInventario1.Size = New System.Drawing.Size(70, 13)
        Me.lblIdInventario1.TabIndex = 48
        Me.lblIdInventario1.Text = "IdInventarioA"
        Me.lblIdInventario1.Visible = False
        '
        'lblIdInventario0
        '
        Me.lblIdInventario0.AutoSize = True
        Me.lblIdInventario0.Location = New System.Drawing.Point(14, 539)
        Me.lblIdInventario0.Name = "lblIdInventario0"
        Me.lblIdInventario0.Size = New System.Drawing.Size(71, 13)
        Me.lblIdInventario0.TabIndex = 46
        Me.lblIdInventario0.Text = "IdInventarioH"
        Me.lblIdInventario0.Visible = False
        '
        'LabelArticulo
        '
        Me.LabelArticulo.AutoSize = True
        Me.LabelArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticulo.ForeColor = System.Drawing.Color.Red
        Me.LabelArticulo.Location = New System.Drawing.Point(8, 18)
        Me.LabelArticulo.Name = "LabelArticulo"
        Me.LabelArticulo.Size = New System.Drawing.Size(154, 15)
        Me.LabelArticulo.TabIndex = 47
        Me.LabelArticulo.Text = "Serial movilco/articulo:"
        '
        'lblRemit
        '
        Me.lblRemit.AutoSize = True
        Me.lblRemit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemit.ForeColor = System.Drawing.Color.Red
        Me.lblRemit.Location = New System.Drawing.Point(584, 18)
        Me.lblRemit.Name = "lblRemit"
        Me.lblRemit.Size = New System.Drawing.Size(125, 15)
        Me.lblRemit.TabIndex = 44
        Me.lblRemit.Text = "Buscar Remitente:"
        '
        'lblDestin
        '
        Me.lblDestin.AutoSize = True
        Me.lblDestin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestin.ForeColor = System.Drawing.Color.Red
        Me.lblDestin.Location = New System.Drawing.Point(390, 18)
        Me.lblDestin.Name = "lblDestin"
        Me.lblDestin.Size = New System.Drawing.Size(133, 15)
        Me.lblDestin.TabIndex = 43
        Me.lblDestin.Text = "Buscar Desinatario:"
        '
        'LabelElemento
        '
        Me.LabelElemento.AutoSize = True
        Me.LabelElemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelElemento.Location = New System.Drawing.Point(3, 15)
        Me.LabelElemento.Name = "LabelElemento"
        Me.LabelElemento.Size = New System.Drawing.Size(0, 33)
        Me.LabelElemento.TabIndex = 45
        Me.LabelElemento.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.Inventario.My.Resources.Resources.desple
        Me.PictureBox3.Location = New System.Drawing.Point(193, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 50
        Me.PictureBox3.TabStop = False
        '
        'TabPageMostrarR
        '
        Me.TabPageMostrarR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPageMostrarR.Controls.Add(Me.TextBoxCantidadR)
        Me.TabPageMostrarR.Controls.Add(Me.Label27)
        Me.TabPageMostrarR.Controls.Add(Me.PictureBoxMostrarI)
        Me.TabPageMostrarR.Controls.Add(Me.ButtonDescargarIMG)
        Me.TabPageMostrarR.Controls.Add(Me.ButtonImprimirFoto)
        Me.TabPageMostrarR.Controls.Add(Me.LabelNumeroRemision)
        Me.TabPageMostrarR.Controls.Add(Me.ButtonMostrarR)
        Me.TabPageMostrarR.Controls.Add(Me.TextBoxMostrarImg)
        Me.TabPageMostrarR.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMostrarR.Name = "TabPageMostrarR"
        Me.TabPageMostrarR.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMostrarR.Size = New System.Drawing.Size(782, 594)
        Me.TabPageMostrarR.TabIndex = 2
        Me.TabPageMostrarR.Text = "MOSTRAR REMISIONES"
        '
        'TextBoxCantidadR
        '
        Me.TextBoxCantidadR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxCantidadR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCantidadR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBoxCantidadR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantidadR.ForeColor = System.Drawing.Color.Red
        Me.TextBoxCantidadR.Location = New System.Drawing.Point(671, 34)
        Me.TextBoxCantidadR.Multiline = True
        Me.TextBoxCantidadR.Name = "TextBoxCantidadR"
        Me.TextBoxCantidadR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxCantidadR.Size = New System.Drawing.Size(58, 32)
        Me.TextBoxCantidadR.TabIndex = 38
        Me.TextBoxCantidadR.Text = "CANT"
        Me.TextBoxCantidadR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRemisiones.SetToolTip(Me.TextBoxCantidadR, "Cantidad de remisiones")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(637, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 15)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Cantidad Remisiones:"
        '
        'PictureBoxMostrarI
        '
        Me.PictureBoxMostrarI.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBoxMostrarI.Location = New System.Drawing.Point(4, 104)
        Me.PictureBoxMostrarI.Name = "PictureBoxMostrarI"
        Me.PictureBoxMostrarI.Size = New System.Drawing.Size(775, 485)
        Me.PictureBoxMostrarI.TabIndex = 31
        Me.PictureBoxMostrarI.TabStop = False
        '
        'ButtonDescargarIMG
        '
        Me.ButtonDescargarIMG.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonDescargarIMG.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonDescargarIMG.FlatAppearance.BorderSize = 2
        Me.ButtonDescargarIMG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonDescargarIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonDescargarIMG.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonDescargarIMG.Image = Global.Inventario.My.Resources.Resources.icons8_abajo_círculo_50
        Me.ButtonDescargarIMG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDescargarIMG.Location = New System.Drawing.Point(327, 6)
        Me.ButtonDescargarIMG.Name = "ButtonDescargarIMG"
        Me.ButtonDescargarIMG.Size = New System.Drawing.Size(133, 60)
        Me.ButtonDescargarIMG.TabIndex = 36
        Me.ButtonDescargarIMG.Text = "D&ESCARGAR"
        Me.ButtonDescargarIMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipRemisiones.SetToolTip(Me.ButtonDescargarIMG, "Descargar remision")
        Me.ButtonDescargarIMG.UseVisualStyleBackColor = False
        '
        'ButtonImprimirFoto
        '
        Me.ButtonImprimirFoto.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonImprimirFoto.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonImprimirFoto.FlatAppearance.BorderSize = 2
        Me.ButtonImprimirFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonImprimirFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonImprimirFoto.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonImprimirFoto.Image = Global.Inventario.My.Resources.Resources.icons8_imprimir_50
        Me.ButtonImprimirFoto.Location = New System.Drawing.Point(485, 6)
        Me.ButtonImprimirFoto.Name = "ButtonImprimirFoto"
        Me.ButtonImprimirFoto.Size = New System.Drawing.Size(133, 60)
        Me.ButtonImprimirFoto.TabIndex = 35
        Me.ButtonImprimirFoto.Text = "&IMPRIMIR"
        Me.ButtonImprimirFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonImprimirFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTipRemisiones.SetToolTip(Me.ButtonImprimirFoto, "Imprimir remision")
        Me.ButtonImprimirFoto.UseVisualStyleBackColor = False
        '
        'LabelNumeroRemision
        '
        Me.LabelNumeroRemision.AutoSize = True
        Me.LabelNumeroRemision.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumeroRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroRemision.ForeColor = System.Drawing.Color.Black
        Me.LabelNumeroRemision.Location = New System.Drawing.Point(8, 6)
        Me.LabelNumeroRemision.Name = "LabelNumeroRemision"
        Me.LabelNumeroRemision.Size = New System.Drawing.Size(128, 15)
        Me.LabelNumeroRemision.TabIndex = 33
        Me.LabelNumeroRemision.Text = "Numero de Remision:"
        '
        'ButtonMostrarR
        '
        Me.ButtonMostrarR.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonMostrarR.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonMostrarR.FlatAppearance.BorderSize = 2
        Me.ButtonMostrarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonMostrarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonMostrarR.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonMostrarR.Image = Global.Inventario.My.Resources.Resources.mostrarpropiedad50
        Me.ButtonMostrarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMostrarR.Location = New System.Drawing.Point(177, 6)
        Me.ButtonMostrarR.Name = "ButtonMostrarR"
        Me.ButtonMostrarR.Size = New System.Drawing.Size(126, 60)
        Me.ButtonMostrarR.TabIndex = 32
        Me.ButtonMostrarR.Text = "MOS&TRAR"
        Me.ButtonMostrarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipRemisiones.SetToolTip(Me.ButtonMostrarR, "Mostrar  remision")
        Me.ButtonMostrarR.UseVisualStyleBackColor = False
        '
        'TextBoxMostrarImg
        '
        Me.TextBoxMostrarImg.BackColor = System.Drawing.Color.White
        Me.TextBoxMostrarImg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMostrarImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMostrarImg.ForeColor = System.Drawing.Color.Red
        Me.TextBoxMostrarImg.Location = New System.Drawing.Point(45, 34)
        Me.TextBoxMostrarImg.Name = "TextBoxMostrarImg"
        Me.TextBoxMostrarImg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxMostrarImg.Size = New System.Drawing.Size(39, 22)
        Me.TextBoxMostrarImg.TabIndex = 34
        Me.TextBoxMostrarImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRemisiones.SetToolTip(Me.TextBoxMostrarImg, "Digite el numero de remision")
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument22
        '
        '
        'PrintPreviewDialog22
        '
        Me.PrintPreviewDialog22.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog22.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog22.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog22.Enabled = True
        Me.PrintPreviewDialog22.Icon = CType(resources.GetObject("PrintPreviewDialog22.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog22.Name = "PrintPreviewDialog22"
        Me.PrintPreviewDialog22.Visible = False
        '
        'PrintDialog22
        '
        Me.PrintDialog22.UseEXDialog = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(790, 676)
        Me.Controls.Add(Me.lblTituloReportes)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(513, 439)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.TabControl1.ResumeLayout(False)
        Me.tabMovimientosR.ResumeLayout(False)
        Me.tabMovimientosR.PerformLayout()
        CType(Me.DataGridMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRemisiones.ResumeLayout(False)
        Me.tabRemisiones.PerformLayout()
        Me.PanelVista.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMostrarR.ResumeLayout(False)
        Me.TabPageMostrarR.PerformLayout()
        CType(Me.PictureBoxMostrarI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloReportes As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimirRep As Button
    Friend WithEvents btnGuardarReporte As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabRemisiones As TabPage
    Friend WithEvents tabMovimientosR As TabPage
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DataGridMov As DataGridView
    Friend WithEvents ToolTipRemisiones As ToolTip

    Friend WithEvents comboRemitenteR As ComboBox
    Friend WithEvents comboDestinatarioR As ComboBox

    Friend WithEvents lblRemit As Label
    Friend WithEvents lblDestin As Label
    Friend WithEvents btnActualizarItem As Button
    Friend WithEvents btnEliminarRe As Button
    Friend WithEvents txtEditarCargo As TextBox
    Friend WithEvents txtEditarCelular As TextBox
    Friend WithEvents txtEditarDireccion As TextBox
    Friend WithEvents txtEditarCuidar As TextBox
    Friend WithEvents txtEditarEncargado As TextBox
    Friend WithEvents txtEditarOficina As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblIdInvisible As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents ButtonInsertarND As Button
    Friend WithEvents RadioButtonModificar As RadioButton
    Friend WithEvents RadioButtonEliminar As RadioButton
    Friend WithEvents RadioButtonInsertarND As RadioButton
    Friend WithEvents Label26 As Label
    Friend WithEvents LabelElemento As Label
    Friend WithEvents LabelArticulo As Label
    Friend WithEvents TabPageMostrarR As TabPage
    Friend WithEvents ButtonMostrarR As Button
    Friend WithEvents TextBoxMostrarImg As TextBox
    Friend WithEvents LabelNumeroRemision As Label
    Friend WithEvents ButtonDescargarIMG As Button
    Friend WithEvents ButtonImprimirFoto As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBoxCantidadR As TextBox
    Friend WithEvents lblIdInventario1 As Label
    Friend WithEvents lblIdInventario0 As Label
    Friend WithEvents ListBoxArticulos As ListBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PanelVista As Panel
    Friend WithEvents PictureBoxMostrarI As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument22 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog22 As PrintPreviewDialog
    Friend WithEvents PrintDialog22 As PrintDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblOcultoId As Label
    Friend WithEvents lblTelef As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblParaDestinatario As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblFechaDest As Label
    Friend WithEvents lblCyD As Label
    Friend WithEvents lblDireccionDest As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOficinaDest As Label
    Friend WithEvents Label9 As Label
    Public WithEvents lblEncargadoDest As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape8 As PowerPacks.LineShape
    Friend WithEvents LineShape7 As PowerPacks.LineShape
    Friend WithEvents LineShape6 As PowerPacks.LineShape
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBoxObserv As TextBox
    Friend WithEvents lblObservacionesR As Label
    Friend WithEvents lblCargoRemit As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNumeroRemision As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCelularRemit As Label
    Friend WithEvents lblDireccionRemit As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents lblOficinaRemit As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lblDeRemit As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape12 As PowerPacks.LineShape
    Friend WithEvents LineShape11 As PowerPacks.LineShape
    Friend WithEvents LineShape10 As PowerPacks.LineShape
    Friend WithEvents LineShape9 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents RadioActivos As RadioButton
    Friend WithEvents RadioSistemas As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonExp As Button
    Friend WithEvents TextBoxBusqueda As TextBox
    Friend WithEvents TextBoxRemitente As TextBox
End Class
