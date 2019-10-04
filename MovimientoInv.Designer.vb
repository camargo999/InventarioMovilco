<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovimientoInv
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.ToolTipMovimientos = New System.Windows.Forms.ToolTip(Me.components)
        Me.comboEstadoCambiar = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCambiarA = New System.Windows.Forms.Label()
        Me.lblNombreEstado = New System.Windows.Forms.Label()
        Me.ButtonExportar = New System.Windows.Forms.Button()
        Me.ButtonLimpiarB = New System.Windows.Forms.Button()
        Me.RadioButtonMovSist = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMovActi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTodos = New System.Windows.Forms.RadioButton()
        Me.botonActualizarEstado = New System.Windows.Forms.Button()
        Me.ButtonInvAc = New System.Windows.Forms.Button()
        Me.ButtonInvSist = New System.Windows.Forms.Button()
        Me.ButtonMovimiento = New System.Windows.Forms.Button()
        Me.DataGridView111 = New System.Windows.Forms.DataGridView()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.LabelCantidadArt = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.LabelTituloEstado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView111, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(302, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "REPORTES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese un dato:"
        '
        'TextBoxBusqueda
        '
        Me.TextBoxBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBoxBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxBusqueda.Enabled = False
        Me.TextBoxBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusqueda.Location = New System.Drawing.Point(5, 97)
        Me.TextBoxBusqueda.Multiline = True
        Me.TextBoxBusqueda.Name = "TextBoxBusqueda"
        Me.TextBoxBusqueda.Size = New System.Drawing.Size(164, 26)
        Me.TextBoxBusqueda.TabIndex = 3
        Me.ToolTipMovimientos.SetToolTip(Me.TextBoxBusqueda, "Ingrese codigo movilco, serial o nombre del articulo...")
        '
        'comboEstadoCambiar
        '
        Me.comboEstadoCambiar.Enabled = False
        Me.comboEstadoCambiar.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboEstadoCambiar.FormattingEnabled = True
        Me.comboEstadoCambiar.Items.AddRange(New Object() {"EN USO", "DISPONIBLE", "DADO DE BAJA"})
        Me.comboEstadoCambiar.Location = New System.Drawing.Point(308, 632)
        Me.comboEstadoCambiar.Name = "comboEstadoCambiar"
        Me.comboEstadoCambiar.Size = New System.Drawing.Size(142, 23)
        Me.comboEstadoCambiar.TabIndex = 11
        Me.comboEstadoCambiar.Text = "SELECCIONAR"
        Me.ToolTipMovimientos.SetToolTip(Me.comboEstadoCambiar, "Seleccionar item")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblCambiarA)
        Me.GroupBox1.Controls.Add(Me.lblNombreEstado)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 597)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 68)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.ToolTipMovimientos.SetToolTip(Me.GroupBox1, "Actualizar estado")
        '
        'lblCambiarA
        '
        Me.lblCambiarA.AutoSize = True
        Me.lblCambiarA.Location = New System.Drawing.Point(161, 14)
        Me.lblCambiarA.Name = "lblCambiarA"
        Me.lblCambiarA.Size = New System.Drawing.Size(68, 13)
        Me.lblCambiarA.TabIndex = 12
        Me.lblCambiarA.Text = "CAMBIAR A:"
        '
        'lblNombreEstado
        '
        Me.lblNombreEstado.AutoSize = True
        Me.lblNombreEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreEstado.Location = New System.Drawing.Point(21, 15)
        Me.lblNombreEstado.Name = "lblNombreEstado"
        Me.lblNombreEstado.Size = New System.Drawing.Size(54, 13)
        Me.lblNombreEstado.TabIndex = 9
        Me.lblNombreEstado.Text = "ESTADO:"
        '
        'ButtonExportar
        '
        Me.ButtonExportar.BackColor = System.Drawing.Color.SlateGray
        Me.ButtonExportar.Enabled = False
        Me.ButtonExportar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportar.ForeColor = System.Drawing.Color.White
        Me.ButtonExportar.Image = Global.Inventario.My.Resources.Resources.icons8_microsoft_excel_2019_50
        Me.ButtonExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExportar.Location = New System.Drawing.Point(19, 603)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(135, 62)
        Me.ButtonExportar.TabIndex = 4
        Me.ButtonExportar.Text = "E&XPORTAR"
        Me.ButtonExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTipMovimientos.SetToolTip(Me.ButtonExportar, "Exportar datos")
        Me.ButtonExportar.UseVisualStyleBackColor = False
        '
        'ButtonLimpiarB
        '
        Me.ButtonLimpiarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLimpiarB.Enabled = False
        Me.ButtonLimpiarB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonLimpiarB.FlatAppearance.BorderSize = 0
        Me.ButtonLimpiarB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonLimpiarB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonLimpiarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiarB.Image = Global.Inventario.My.Resources.Resources.ic_remove_circle_outline_128_28748
        Me.ButtonLimpiarB.Location = New System.Drawing.Point(170, 92)
        Me.ButtonLimpiarB.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLimpiarB.Name = "ButtonLimpiarB"
        Me.ButtonLimpiarB.Size = New System.Drawing.Size(31, 34)
        Me.ButtonLimpiarB.TabIndex = 1
        Me.ToolTipMovimientos.SetToolTip(Me.ButtonLimpiarB, "Limpiar caja de texto")
        Me.ButtonLimpiarB.UseVisualStyleBackColor = False
        '
        'RadioButtonMovSist
        '
        Me.RadioButtonMovSist.AutoSize = True
        Me.RadioButtonMovSist.Location = New System.Drawing.Point(237, 92)
        Me.RadioButtonMovSist.Name = "RadioButtonMovSist"
        Me.RadioButtonMovSist.Size = New System.Drawing.Size(94, 17)
        Me.RadioButtonMovSist.TabIndex = 16
        Me.RadioButtonMovSist.Text = "Mov. Sistemas"
        Me.ToolTipMovimientos.SetToolTip(Me.RadioButtonMovSist, "Movimientos de sistemas")
        Me.RadioButtonMovSist.UseVisualStyleBackColor = True
        Me.RadioButtonMovSist.Visible = False
        '
        'RadioButtonMovActi
        '
        Me.RadioButtonMovActi.AutoSize = True
        Me.RadioButtonMovActi.Location = New System.Drawing.Point(237, 109)
        Me.RadioButtonMovActi.Name = "RadioButtonMovActi"
        Me.RadioButtonMovActi.Size = New System.Drawing.Size(87, 17)
        Me.RadioButtonMovActi.TabIndex = 17
        Me.RadioButtonMovActi.Text = "Mov. Activos"
        Me.ToolTipMovimientos.SetToolTip(Me.RadioButtonMovActi, "Movimientos de activos")
        Me.RadioButtonMovActi.UseVisualStyleBackColor = True
        Me.RadioButtonMovActi.Visible = False
        '
        'RadioButtonTodos
        '
        Me.RadioButtonTodos.AutoSize = True
        Me.RadioButtonTodos.Location = New System.Drawing.Point(237, 76)
        Me.RadioButtonTodos.Name = "RadioButtonTodos"
        Me.RadioButtonTodos.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonTodos.TabIndex = 19
        Me.RadioButtonTodos.Text = "Todos"
        Me.ToolTipMovimientos.SetToolTip(Me.RadioButtonTodos, "Mostrar todos los Movimientos")
        Me.RadioButtonTodos.UseVisualStyleBackColor = True
        Me.RadioButtonTodos.Visible = False
        '
        'botonActualizarEstado
        '
        Me.botonActualizarEstado.BackColor = System.Drawing.Color.SlateGray
        Me.botonActualizarEstado.Enabled = False
        Me.botonActualizarEstado.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.botonActualizarEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.botonActualizarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.botonActualizarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonActualizarEstado.ForeColor = System.Drawing.Color.White
        Me.botonActualizarEstado.Image = Global.Inventario.My.Resources.Resources.Actualizar50
        Me.botonActualizarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonActualizarEstado.Location = New System.Drawing.Point(477, 604)
        Me.botonActualizarEstado.Name = "botonActualizarEstado"
        Me.botonActualizarEstado.Size = New System.Drawing.Size(139, 61)
        Me.botonActualizarEstado.TabIndex = 13
        Me.botonActualizarEstado.Text = "ACTUALIZAR"
        Me.botonActualizarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipMovimientos.SetToolTip(Me.botonActualizarEstado, "Actualizar estado")
        Me.botonActualizarEstado.UseVisualStyleBackColor = True
        '
        'ButtonInvAc
        '
        Me.ButtonInvAc.BackColor = System.Drawing.Color.SlateGray
        Me.ButtonInvAc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInvAc.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonInvAc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonInvAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonInvAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInvAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInvAc.ForeColor = System.Drawing.Color.White
        Me.ButtonInvAc.Image = Global.Inventario.My.Resources.Resources.caja_entregada50
        Me.ButtonInvAc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInvAc.Location = New System.Drawing.Point(365, 73)
        Me.ButtonInvAc.Name = "ButtonInvAc"
        Me.ButtonInvAc.Size = New System.Drawing.Size(129, 50)
        Me.ButtonInvAc.TabIndex = 1
        Me.ButtonInvAc.Text = "INV. &ACTIVOS"
        Me.ButtonInvAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipMovimientos.SetToolTip(Me.ButtonInvAc, "Inventario Activos")
        Me.ButtonInvAc.UseVisualStyleBackColor = False
        Me.ButtonInvAc.Visible = False
        '
        'ButtonInvSist
        '
        Me.ButtonInvSist.BackColor = System.Drawing.Color.SlateGray
        Me.ButtonInvSist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInvSist.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonInvSist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonInvSist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonInvSist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInvSist.ForeColor = System.Drawing.Color.White
        Me.ButtonInvSist.Image = Global.Inventario.My.Resources.Resources.icons8_configuración_de_entrega_50
        Me.ButtonInvSist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInvSist.Location = New System.Drawing.Point(646, 73)
        Me.ButtonInvSist.Name = "ButtonInvSist"
        Me.ButtonInvSist.Size = New System.Drawing.Size(135, 50)
        Me.ButtonInvSist.TabIndex = 3
        Me.ButtonInvSist.Text = "INV. S&ISTEMAS"
        Me.ButtonInvSist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipMovimientos.SetToolTip(Me.ButtonInvSist, "Inventario Sistemas")
        Me.ButtonInvSist.UseVisualStyleBackColor = False
        Me.ButtonInvSist.Visible = False
        '
        'ButtonMovimiento
        '
        Me.ButtonMovimiento.BackColor = System.Drawing.Color.SlateGray
        Me.ButtonMovimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMovimiento.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonMovimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.ButtonMovimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMovimiento.ForeColor = System.Drawing.Color.White
        Me.ButtonMovimiento.Image = Global.Inventario.My.Resources.Resources.icons8_producto_50
        Me.ButtonMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMovimiento.Location = New System.Drawing.Point(503, 73)
        Me.ButtonMovimiento.Name = "ButtonMovimiento"
        Me.ButtonMovimiento.Size = New System.Drawing.Size(135, 50)
        Me.ButtonMovimiento.TabIndex = 2
        Me.ButtonMovimiento.Text = "MO&VIMIENTOS"
        Me.ButtonMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipMovimientos.SetToolTip(Me.ButtonMovimiento, "Movimientos")
        Me.ButtonMovimiento.UseVisualStyleBackColor = False
        Me.ButtonMovimiento.Visible = False
        '
        'DataGridView111
        '
        Me.DataGridView111.AllowUserToAddRows = False
        Me.DataGridView111.AllowUserToDeleteRows = False
        Me.DataGridView111.AllowUserToOrderColumns = True
        Me.DataGridView111.AllowUserToResizeColumns = False
        Me.DataGridView111.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView111.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView111.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView111.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView111.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView111.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView111.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView111.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView111.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView111.Location = New System.Drawing.Point(6, 129)
        Me.DataGridView111.Name = "DataGridView111"
        Me.DataGridView111.RowHeadersVisible = False
        Me.DataGridView111.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView111.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView111.Size = New System.Drawing.Size(778, 422)
        Me.DataGridView111.TabIndex = 4
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCantidad.ForeColor = System.Drawing.Color.Red
        Me.LabelCantidad.Location = New System.Drawing.Point(690, 630)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(26, 29)
        Me.LabelCantidad.TabIndex = 5
        Me.LabelCantidad.Text = "0"
        Me.LabelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCantidadArt
        '
        Me.LabelCantidadArt.AutoSize = True
        Me.LabelCantidadArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCantidadArt.ForeColor = System.Drawing.Color.Black
        Me.LabelCantidadArt.Location = New System.Drawing.Point(636, 604)
        Me.LabelCantidadArt.Name = "LabelCantidadArt"
        Me.LabelCantidadArt.Size = New System.Drawing.Size(140, 20)
        Me.LabelCantidadArt.TabIndex = 8
        Me.LabelCantidadArt.Text = "Cantidad articulos:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Navy
        Me.lblEstado.Location = New System.Drawing.Point(184, 635)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 15)
        Me.lblEstado.TabIndex = 10
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTituloEstado
        '
        Me.LabelTituloEstado.AutoSize = True
        Me.LabelTituloEstado.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTituloEstado.ForeColor = System.Drawing.Color.Red
        Me.LabelTituloEstado.Location = New System.Drawing.Point(255, 565)
        Me.LabelTituloEstado.Name = "LabelTituloEstado"
        Me.LabelTituloEstado.Size = New System.Drawing.Size(291, 18)
        Me.LabelTituloEstado.TabIndex = 14
        Me.LabelTituloEstado.Text = "ACTUALIZAR ESTADO DEL ARTICULO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(237, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FILTRAR POR:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(5, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ELIJA UN TIPO DE INVENTARIO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(491, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = " TIPOS DE INVENTARIO:"
        '
        'MovimientoInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(790, 676)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButtonTodos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButtonMovActi)
        Me.Controls.Add(Me.RadioButtonMovSist)
        Me.Controls.Add(Me.LabelTituloEstado)
        Me.Controls.Add(Me.botonActualizarEstado)
        Me.Controls.Add(Me.comboEstadoCambiar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.ButtonExportar)
        Me.Controls.Add(Me.ButtonInvAc)
        Me.Controls.Add(Me.ButtonInvSist)
        Me.Controls.Add(Me.LabelCantidadArt)
        Me.Controls.Add(Me.ButtonMovimiento)
        Me.Controls.Add(Me.LabelCantidad)
        Me.Controls.Add(Me.DataGridView111)
        Me.Controls.Add(Me.TextBoxBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonLimpiarB)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MovimientoInv"
        Me.Text = "MovimientoInv"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView111, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonLimpiarB As Button
    Friend WithEvents ToolTipMovimientos As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusqueda As TextBox
    Friend WithEvents DataGridView111 As DataGridView
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents ButtonMovimiento As Button
    Friend WithEvents LabelCantidadArt As Label
    Friend WithEvents ButtonInvSist As Button
    Friend WithEvents ButtonInvAc As Button
    Friend WithEvents ButtonExportar As Button
    Friend WithEvents lblNombreEstado As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents comboEstadoCambiar As ComboBox
    Friend WithEvents lblCambiarA As Label
    Friend WithEvents botonActualizarEstado As Button
    Friend WithEvents LabelTituloEstado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonMovSist As RadioButton
    Friend WithEvents RadioButtonMovActi As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButtonTodos As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
