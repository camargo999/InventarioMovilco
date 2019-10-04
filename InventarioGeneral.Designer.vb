<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioGeneral
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBoxRegistro = New System.Windows.Forms.GroupBox()
        Me.ComboBoxOficina = New System.Windows.Forms.ComboBox()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerIG = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreoEl = New System.Windows.Forms.TextBox()
        Me.txtDirectorAdmin = New System.Windows.Forms.TextBox()
        Me.DataGridViewIG = New System.Windows.Forms.DataGridView()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serialM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serialArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBoxIG = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTipInvGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonImprimirF2 = New System.Windows.Forms.Button()
        Me.ButtonImp2 = New System.Windows.Forms.Button()
        Me.PictureBoxFactura2 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxDetalles = New System.Windows.Forms.GroupBox()
        Me.dataGridViewCencepto2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelValor2 = New System.Windows.Forms.Label()
        Me.TextBoxVend2 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.DateTimePickerFC2 = New System.Windows.Forms.DateTimePicker()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBoxCantid2 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.LabelV = New System.Windows.Forms.Label()
        Me.TextBoxNumFac2 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.GroupBoxRegistro.SuspendLayout()
        CType(Me.DataGridViewIG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFactura2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDetalles.SuspendLayout()
        CType(Me.dataGridViewCencepto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(236, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INVENTARIO GENERAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "FECHA DE REGISTRO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "OFICINA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(16, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "COORDINADOR CVS:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CORREO ELECTRONICO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "TELEFONO:"
        '
        'GroupBoxRegistro
        '
        Me.GroupBoxRegistro.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxRegistro.Controls.Add(Me.ComboBoxOficina)
        Me.GroupBoxRegistro.Controls.Add(Me.TextBoxDireccion)
        Me.GroupBoxRegistro.Controls.Add(Me.Label1)
        Me.GroupBoxRegistro.Controls.Add(Me.DateTimePickerIG)
        Me.GroupBoxRegistro.Controls.Add(Me.txtTelefono)
        Me.GroupBoxRegistro.Controls.Add(Me.Label12)
        Me.GroupBoxRegistro.Controls.Add(Me.txtCorreoEl)
        Me.GroupBoxRegistro.Controls.Add(Me.Label14)
        Me.GroupBoxRegistro.Controls.Add(Me.txtDirectorAdmin)
        Me.GroupBoxRegistro.Controls.Add(Me.Label10)
        Me.GroupBoxRegistro.Controls.Add(Me.Label13)
        Me.GroupBoxRegistro.Controls.Add(Me.Label11)
        Me.GroupBoxRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxRegistro.Location = New System.Drawing.Point(5, 51)
        Me.GroupBoxRegistro.Name = "GroupBoxRegistro"
        Me.GroupBoxRegistro.Size = New System.Drawing.Size(399, 231)
        Me.GroupBoxRegistro.TabIndex = 14
        Me.GroupBoxRegistro.TabStop = False
        Me.GroupBoxRegistro.Text = "DATOS REGISTRO"
        '
        'ComboBoxOficina
        '
        Me.ComboBoxOficina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxOficina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxOficina.FormattingEnabled = True
        Me.ComboBoxOficina.Location = New System.Drawing.Point(151, 58)
        Me.ComboBoxOficina.Name = "ComboBoxOficina"
        Me.ComboBoxOficina.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxOficina.TabIndex = 2
        Me.ComboBoxOficina.Text = "SELECCIONAR OFICINA"
        Me.ToolTipInvGeneral.SetToolTip(Me.ComboBoxOficina, "Oficinas")
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDireccion.Location = New System.Drawing.Point(151, 126)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxDireccion.TabIndex = 4
        Me.ToolTipInvGeneral.SetToolTip(Me.TextBoxDireccion, "Direcccion")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DIRECCION:"
        '
        'DateTimePickerIG
        '
        Me.DateTimePickerIG.CalendarForeColor = System.Drawing.Color.Yellow
        Me.DateTimePickerIG.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DateTimePickerIG.CalendarTitleForeColor = System.Drawing.Color.Green
        Me.DateTimePickerIG.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DateTimePickerIG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerIG.Location = New System.Drawing.Point(151, 24)
        Me.DateTimePickerIG.Name = "DateTimePickerIG"
        Me.DateTimePickerIG.Size = New System.Drawing.Size(240, 21)
        Me.DateTimePickerIG.TabIndex = 1
        Me.ToolTipInvGeneral.SetToolTip(Me.DateTimePickerIG, "Calendario")
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(151, 198)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(240, 20)
        Me.txtTelefono.TabIndex = 6
        Me.ToolTipInvGeneral.SetToolTip(Me.txtTelefono, "Telefono")
        '
        'txtCorreoEl
        '
        Me.txtCorreoEl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreoEl.Location = New System.Drawing.Point(151, 162)
        Me.txtCorreoEl.Name = "txtCorreoEl"
        Me.txtCorreoEl.Size = New System.Drawing.Size(240, 20)
        Me.txtCorreoEl.TabIndex = 5
        Me.ToolTipInvGeneral.SetToolTip(Me.txtCorreoEl, "Correo electronico")
        '
        'txtDirectorAdmin
        '
        Me.txtDirectorAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDirectorAdmin.Location = New System.Drawing.Point(151, 93)
        Me.txtDirectorAdmin.Name = "txtDirectorAdmin"
        Me.txtDirectorAdmin.Size = New System.Drawing.Size(240, 20)
        Me.txtDirectorAdmin.TabIndex = 3
        Me.ToolTipInvGeneral.SetToolTip(Me.txtDirectorAdmin, "Coordinador cvs")
        '
        'DataGridViewIG
        '
        Me.DataGridViewIG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridViewIG.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewIG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewIG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewIG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.articulo, Me.marcaArticulo, Me.serialM, Me.serialArticulo, Me.estadoArticulo, Me.ValorPromedio, Me.Observaciones, Me.ComboBoxIG, Me.btnEliminar})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewIG.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewIG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewIG.GridColor = System.Drawing.Color.White
        Me.DataGridViewIG.Location = New System.Drawing.Point(5, 288)
        Me.DataGridViewIG.Name = "DataGridViewIG"
        Me.DataGridViewIG.RowHeadersVisible = False
        Me.DataGridViewIG.Size = New System.Drawing.Size(779, 336)
        Me.DataGridViewIG.StandardTab = True
        Me.DataGridViewIG.TabIndex = 12
        '
        'articulo
        '
        Me.articulo.HeaderText = "ARTICULO"
        Me.articulo.Name = "articulo"
        Me.articulo.Width = 71
        '
        'marcaArticulo
        '
        Me.marcaArticulo.HeaderText = "MARCA ARTICULO"
        Me.marcaArticulo.Name = "marcaArticulo"
        Me.marcaArticulo.Width = 94
        '
        'serialM
        '
        Me.serialM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.serialM.HeaderText = "SERIAL MOVILCO"
        Me.serialM.Name = "serialM"
        Me.serialM.ToolTipText = "Ingrese el serial"
        Me.serialM.Width = 60
        '
        'serialArticulo
        '
        Me.serialArticulo.HeaderText = "SERIAL ARTICULO"
        Me.serialArticulo.Name = "serialArticulo"
        Me.serialArticulo.Width = 93
        '
        'estadoArticulo
        '
        Me.estadoArticulo.HeaderText = "CONDICION ARTICULO"
        Me.estadoArticulo.Name = "estadoArticulo"
        Me.estadoArticulo.Width = 109
        '
        'ValorPromedio
        '
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.ValorPromedio.DefaultCellStyle = DataGridViewCellStyle14
        Me.ValorPromedio.HeaderText = "VALOR PROMEDIO"
        Me.ValorPromedio.Name = "ValorPromedio"
        Me.ValorPromedio.Width = 93
        '
        'Observaciones
        '
        Me.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Observaciones.HeaderText = "OBSERVACIONES"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 97
        '
        'ComboBoxIG
        '
        Me.ComboBoxIG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ComboBoxIG.HeaderText = "ESTADO"
        Me.ComboBoxIG.Items.AddRange(New Object() {"EN USO", "DISPONIBLE", "DADO DE BAJA"})
        Me.ComboBoxIG.Name = "ComboBoxIG"
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.btnEliminar.HeaderText = ""
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnEliminar.Text = "Borrar"
        Me.btnEliminar.UseColumnTextForButtonValue = True
        Me.btnEliminar.Width = 60
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(651, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 42)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "B&ORRAR DATOS"
        Me.ToolTipInvGeneral.SetToolTip(Me.Button1, "Borrar datos")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(525, 630)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 42)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "GU&ARDAR DATOS"
        Me.ToolTipInvGeneral.SetToolTip(Me.Button2, "Guardar datos")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ButtonImprimirF2
        '
        Me.ButtonImprimirF2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonImprimirF2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.ButtonImprimirF2.Location = New System.Drawing.Point(132, 630)
        Me.ButtonImprimirF2.Name = "ButtonImprimirF2"
        Me.ButtonImprimirF2.Size = New System.Drawing.Size(124, 41)
        Me.ButtonImprimirF2.TabIndex = 14
        Me.ButtonImprimirF2.Text = "VISTA PREVIA FACTURA"
        Me.ToolTipInvGeneral.SetToolTip(Me.ButtonImprimirF2, "Vista previa remision")
        Me.ButtonImprimirF2.UseVisualStyleBackColor = False
        '
        'ButtonImp2
        '
        Me.ButtonImp2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonImp2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.ButtonImp2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonImp2.Location = New System.Drawing.Point(5, 630)
        Me.ButtonImp2.Name = "ButtonImp2"
        Me.ButtonImp2.Size = New System.Drawing.Size(124, 42)
        Me.ButtonImp2.TabIndex = 13
        Me.ButtonImp2.Text = "IMPORTAR FACTURA"
        Me.ToolTipInvGeneral.SetToolTip(Me.ButtonImp2, "Importar remision")
        Me.ButtonImp2.UseVisualStyleBackColor = False
        '
        'PictureBoxFactura2
        '
        Me.PictureBoxFactura2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBoxFactura2.Location = New System.Drawing.Point(260, 632)
        Me.PictureBoxFactura2.Name = "PictureBoxFactura2"
        Me.PictureBoxFactura2.Size = New System.Drawing.Size(41, 37)
        Me.PictureBoxFactura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFactura2.TabIndex = 116
        Me.PictureBoxFactura2.TabStop = False
        '
        'GroupBoxDetalles
        '
        Me.GroupBoxDetalles.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDetalles.Controls.Add(Me.dataGridViewCencepto2)
        Me.GroupBoxDetalles.Controls.Add(Me.labelValor2)
        Me.GroupBoxDetalles.Controls.Add(Me.DateTimePickerFC2)
        Me.GroupBoxDetalles.Controls.Add(Me.Label54)
        Me.GroupBoxDetalles.Controls.Add(Me.TextBoxVend2)
        Me.GroupBoxDetalles.Controls.Add(Me.TextBoxCantid2)
        Me.GroupBoxDetalles.Controls.Add(Me.Label55)
        Me.GroupBoxDetalles.Controls.Add(Me.Label53)
        Me.GroupBoxDetalles.Controls.Add(Me.Label56)
        Me.GroupBoxDetalles.Controls.Add(Me.TextBoxNumFac2)
        Me.GroupBoxDetalles.Controls.Add(Me.Label51)
        Me.GroupBoxDetalles.Controls.Add(Me.LabelV)
        Me.GroupBoxDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxDetalles.Location = New System.Drawing.Point(405, 51)
        Me.GroupBoxDetalles.Name = "GroupBoxDetalles"
        Me.GroupBoxDetalles.Size = New System.Drawing.Size(379, 231)
        Me.GroupBoxDetalles.TabIndex = 119
        Me.GroupBoxDetalles.TabStop = False
        Me.GroupBoxDetalles.Text = "DETALLES FACTURAS"
        '
        'dataGridViewCencepto2
        '
        Me.dataGridViewCencepto2.AllowUserToAddRows = False
        Me.dataGridViewCencepto2.BackgroundColor = System.Drawing.Color.White
        Me.dataGridViewCencepto2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewCencepto2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dataGridViewCencepto2.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dataGridViewCencepto2.Location = New System.Drawing.Point(11, 103)
        Me.dataGridViewCencepto2.Name = "dataGridViewCencepto2"
        Me.dataGridViewCencepto2.RowHeadersVisible = False
        Me.dataGridViewCencepto2.Size = New System.Drawing.Size(364, 114)
        Me.dataGridViewCencepto2.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "ARTICULOS"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 235
        '
        'Column2
        '
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0"
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column2.HeaderText = "VALOR UNITARIO"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'labelValor2
        '
        Me.labelValor2.AutoEllipsis = True
        Me.labelValor2.AutoSize = True
        Me.labelValor2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelValor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelValor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelValor2.Location = New System.Drawing.Point(205, 73)
        Me.labelValor2.Name = "labelValor2"
        Me.labelValor2.Size = New System.Drawing.Size(19, 21)
        Me.labelValor2.TabIndex = 14
        Me.labelValor2.Text = "0"
        Me.labelValor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVend2
        '
        Me.TextBoxVend2.Location = New System.Drawing.Point(9, 74)
        Me.TextBoxVend2.Name = "TextBoxVend2"
        Me.TextBoxVend2.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxVend2.TabIndex = 11
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(6, 59)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(106, 13)
        Me.Label55.TabIndex = 11
        Me.Label55.Text = "Vendedor/proveedor"
        '
        'DateTimePickerFC2
        '
        Me.DateTimePickerFC2.Location = New System.Drawing.Point(187, 33)
        Me.DateTimePickerFC2.Name = "DateTimePickerFC2"
        Me.DateTimePickerFC2.Size = New System.Drawing.Size(186, 20)
        Me.DateTimePickerFC2.TabIndex = 9
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(184, 17)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(90, 13)
        Me.Label54.TabIndex = 9
        Me.Label54.Text = "Fecha de compra"
        '
        'TextBoxCantid2
        '
        Me.TextBoxCantid2.Location = New System.Drawing.Point(120, 33)
        Me.TextBoxCantid2.Name = "TextBoxCantid2"
        Me.TextBoxCantid2.Size = New System.Drawing.Size(61, 20)
        Me.TextBoxCantid2.TabIndex = 8
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(117, 17)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(49, 13)
        Me.Label53.TabIndex = 6
        Me.Label53.Text = "Cantidad"
        '
        'LabelV
        '
        Me.LabelV.AutoSize = True
        Me.LabelV.Location = New System.Drawing.Point(201, 59)
        Me.LabelV.Name = "LabelV"
        Me.LabelV.Size = New System.Drawing.Size(54, 13)
        Me.LabelV.TabIndex = 4
        Me.LabelV.Text = "Valor total"
        '
        'TextBoxNumFac2
        '
        Me.TextBoxNumFac2.Location = New System.Drawing.Point(9, 33)
        Me.TextBoxNumFac2.Name = "TextBoxNumFac2"
        Me.TextBoxNumFac2.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxNumFac2.TabIndex = 7
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(6, 17)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(103, 13)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Factura de venta N°"
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Red
        Me.Label56.Location = New System.Drawing.Point(192, 75)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(13, 22)
        Me.Label56.TabIndex = 13
        Me.Label56.Text = "$"
        '
        'InventarioGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(790, 676)
        Me.Controls.Add(Me.GroupBoxDetalles)
        Me.Controls.Add(Me.ButtonImprimirF2)
        Me.Controls.Add(Me.ButtonImp2)
        Me.Controls.Add(Me.PictureBoxFactura2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewIG)
        Me.Controls.Add(Me.GroupBoxRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventarioGeneral"
        Me.Text = "InventarioGeneral"
        Me.GroupBoxRegistro.ResumeLayout(False)
        Me.GroupBoxRegistro.PerformLayout()
        CType(Me.DataGridViewIG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFactura2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDetalles.ResumeLayout(False)
        Me.GroupBoxDetalles.PerformLayout()
        CType(Me.dataGridViewCencepto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBoxRegistro As GroupBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreoEl As TextBox
    Friend WithEvents txtDirectorAdmin As TextBox
    Friend WithEvents DataGridViewIG As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTipInvGeneral As ToolTip
    Friend WithEvents DateTimePickerIG As DateTimePicker
    Friend WithEvents articulo As DataGridViewTextBoxColumn
    Friend WithEvents marcaArticulo As DataGridViewTextBoxColumn
    Friend WithEvents serialM As DataGridViewTextBoxColumn
    Friend WithEvents serialArticulo As DataGridViewTextBoxColumn
    Friend WithEvents estadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents ValorPromedio As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxIG As DataGridViewComboBoxColumn
    Friend WithEvents btnEliminar As DataGridViewButtonColumn
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxOficina As ComboBox
    Friend WithEvents ButtonImprimirF2 As Button
    Friend WithEvents ButtonImp2 As Button
    Friend WithEvents PictureBoxFactura2 As PictureBox
    Friend WithEvents GroupBoxDetalles As GroupBox
    Friend WithEvents dataGridViewCencepto2 As DataGridView
    Friend WithEvents labelValor2 As Label
    Friend WithEvents TextBoxVend2 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents DateTimePickerFC2 As DateTimePicker
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBoxCantid2 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents LabelV As Label
    Friend WithEvents TextBoxNumFac2 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
