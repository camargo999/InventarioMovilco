<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioSH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioSH))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelS = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.labelHora = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnMovimiento = New System.Windows.Forms.Button()
        Me.btnExterno = New System.Windows.Forms.Button()
        Me.btnHardware = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CLIKAQUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TimerMostrarHorayFecha = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipPrincipal = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.panelTitulo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.panelTitulo.Controls.Add(Me.PictureBox5)
        Me.panelTitulo.Controls.Add(Me.Label5)
        Me.panelTitulo.Controls.Add(Me.Label1)
        Me.panelTitulo.Controls.Add(Me.LabelS)
        Me.panelTitulo.Controls.Add(Me.PictureBox4)
        Me.panelTitulo.Controls.Add(Me.PictureBox3)
        Me.panelTitulo.Controls.Add(Me.Label2)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(990, 54)
        Me.panelTitulo.TabIndex = 3
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Inventario.My.Resources.Resources.icons8_ayuda_50
        Me.PictureBox5.Location = New System.Drawing.Point(890, 11)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(593, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 31)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "M"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(418, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "I"
        '
        'LabelS
        '
        Me.LabelS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelS.ForeColor = System.Drawing.Color.Maroon
        Me.LabelS.Location = New System.Drawing.Point(292, 13)
        Me.LabelS.Name = "LabelS"
        Me.LabelS.Size = New System.Drawing.Size(27, 31)
        Me.LabelS.TabIndex = 9
        Me.LabelS.Text = "S"
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(926, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        Me.ToolTipPrincipal.SetToolTip(Me.PictureBox4, "Minimizar")
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(957, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        Me.ToolTipPrincipal.SetToolTip(Me.PictureBox3, "Cerrar Programa")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SISTEMA INVENTARIO MOVILCO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnUsuarios)
        Me.Panel2.Controls.Add(Me.btnReportes)
        Me.Panel2.Controls.Add(Me.btnMovimiento)
        Me.Panel2.Controls.Add(Me.btnExterno)
        Me.Panel2.Controls.Add(Me.btnHardware)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 676)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.labelFecha)
        Me.Panel4.Controls.Add(Me.labelHora)
        Me.Panel4.Controls.Add(Me.ShapeContainer1)
        Me.Panel4.Location = New System.Drawing.Point(0, 529)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 145)
        Me.Panel4.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Fecha de publicacion 13/09/2019"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(-1, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "V_1.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Mostrara el Usuario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Mostrara el Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFecha.ForeColor = System.Drawing.Color.Maroon
        Me.labelFecha.Location = New System.Drawing.Point(1, 90)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(42, 16)
        Me.labelFecha.TabIndex = 8
        Me.labelFecha.Text = "Fecha"
        '
        'labelHora
        '
        Me.labelHora.AutoSize = True
        Me.labelHora.BackColor = System.Drawing.Color.Transparent
        Me.labelHora.Font = New System.Drawing.Font("LCD", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHora.ForeColor = System.Drawing.Color.Maroon
        Me.labelHora.Location = New System.Drawing.Point(71, 69)
        Me.labelHora.Name = "labelHora"
        Me.labelHora.Size = New System.Drawing.Size(33, 12)
        Me.labelHora.TabIndex = 9
        Me.labelHora.Text = "Hora"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(200, 145)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 4
        Me.LineShape2.X2 = 194
        Me.LineShape2.Y1 = 113
        Me.LineShape2.Y2 = 113
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 3
        Me.LineShape1.X2 = 194
        Me.LineShape1.Y1 = 60
        Me.LineShape1.Y2 = 60
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 443)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(199, 84)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.Text = "       &USUARIOS"
        Me.ToolTipPrincipal.SetToolTip(Me.btnUsuarios, "Usuarios")
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 359)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(199, 84)
        Me.btnReportes.TabIndex = 4
        Me.btnReportes.Text = "         RE&MISIONES"
        Me.ToolTipPrincipal.SetToolTip(Me.btnReportes, "Remisiones")
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnMovimiento
        '
        Me.btnMovimiento.BackColor = System.Drawing.Color.Transparent
        Me.btnMovimiento.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnMovimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnMovimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimiento.ForeColor = System.Drawing.Color.White
        Me.btnMovimiento.Image = CType(resources.GetObject("btnMovimiento.Image"), System.Drawing.Image)
        Me.btnMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimiento.Location = New System.Drawing.Point(0, 275)
        Me.btnMovimiento.Name = "btnMovimiento"
        Me.btnMovimiento.Size = New System.Drawing.Size(199, 84)
        Me.btnMovimiento.TabIndex = 3
        Me.btnMovimiento.Text = "        &REPORTES"
        Me.ToolTipPrincipal.SetToolTip(Me.btnMovimiento, "Reportes")
        Me.btnMovimiento.UseVisualStyleBackColor = False
        '
        'btnExterno
        '
        Me.btnExterno.BackColor = System.Drawing.Color.Transparent
        Me.btnExterno.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnExterno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnExterno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExterno.ForeColor = System.Drawing.Color.White
        Me.btnExterno.Image = CType(resources.GetObject("btnExterno.Image"), System.Drawing.Image)
        Me.btnExterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExterno.Location = New System.Drawing.Point(0, 191)
        Me.btnExterno.Name = "btnExterno"
        Me.btnExterno.Size = New System.Drawing.Size(199, 84)
        Me.btnExterno.TabIndex = 2
        Me.btnExterno.Text = "              INVENTARIO &GENERAL"
        Me.ToolTipPrincipal.SetToolTip(Me.btnExterno, "Inventario General")
        Me.btnExterno.UseVisualStyleBackColor = False
        '
        'btnHardware
        '
        Me.btnHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHardware.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btnHardware.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnHardware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHardware.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHardware.ForeColor = System.Drawing.Color.White
        Me.btnHardware.Image = CType(resources.GetObject("btnHardware.Image"), System.Drawing.Image)
        Me.btnHardware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHardware.Location = New System.Drawing.Point(0, 107)
        Me.btnHardware.Name = "btnHardware"
        Me.btnHardware.Size = New System.Drawing.Size(199, 84)
        Me.btnHardware.TabIndex = 1
        Me.btnHardware.Text = "                 INVENTARIO &SISTEMAS"
        Me.ToolTipPrincipal.SetToolTip(Me.btnHardware, "Inventario Sistemas")
        Me.btnHardware.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 107)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIKAQUIToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 26)
        '
        'CLIKAQUIToolStripMenuItem
        '
        Me.CLIKAQUIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIKAQUIToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CLIKAQUIToolStripMenuItem.Image = Global.Inventario.My.Resources.Resources.ico2
        Me.CLIKAQUIToolStripMenuItem.Name = "CLIKAQUIToolStripMenuItem"
        Me.CLIKAQUIToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CLIKAQUIToolStripMenuItem.Text = "CLIK AQUI"
        '
        'panelContenedor
        '
        Me.panelContenedor.Controls.Add(Me.PictureBox2)
        Me.panelContenedor.Location = New System.Drawing.Point(200, 54)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(790, 676)
        Me.panelContenedor.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Inventario.My.Resources.Resources.mapaMovilco
        Me.PictureBox2.Location = New System.Drawing.Point(1, -63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(789, 882)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TimerMostrarHorayFecha
        '
        Me.TimerMostrarHorayFecha.Enabled = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Notificacion"
        Me.NotifyIcon1.Visible = True
        '
        'InventarioSH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(990, 730)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "InventarioSH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventarioSH"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.panelContenedor.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTitulo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHardware As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnMovimiento As Button
    Friend WithEvents btnExterno As Button
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Public WithEvents TimerMostrarHorayFecha As Timer
    Friend WithEvents ToolTipPrincipal As ToolTip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelHora As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CLIKAQUIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LabelS As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
