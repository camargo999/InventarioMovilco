<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperarContraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoRecuperacion = New System.Windows.Forms.TextBox()
        Me.txtNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.txtVolverAescribir = New System.Windows.Forms.TextBox()
        Me.botonCambioClave = New System.Windows.Forms.Button()
        Me.botonCancelarCambio = New System.Windows.Forms.Button()
        Me.ToolTipRecup = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECUPERAR CONTRASEÑA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de recuperacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nueva Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vuelva a escribir la contraseña:"
        '
        'txtCodigoRecuperacion
        '
        Me.txtCodigoRecuperacion.Location = New System.Drawing.Point(173, 55)
        Me.txtCodigoRecuperacion.Name = "txtCodigoRecuperacion"
        Me.txtCodigoRecuperacion.Size = New System.Drawing.Size(179, 20)
        Me.txtCodigoRecuperacion.TabIndex = 4
        Me.ToolTipRecup.SetToolTip(Me.txtCodigoRecuperacion, "Ingrese codigo de recuperacion")
        '
        'txtNuevaContraseña
        '
        Me.txtNuevaContraseña.Enabled = False
        Me.txtNuevaContraseña.Location = New System.Drawing.Point(173, 91)
        Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
        Me.txtNuevaContraseña.Size = New System.Drawing.Size(179, 20)
        Me.txtNuevaContraseña.TabIndex = 5
        Me.ToolTipRecup.SetToolTip(Me.txtNuevaContraseña, "Ingrese contraseña")
        '
        'txtVolverAescribir
        '
        Me.txtVolverAescribir.Enabled = False
        Me.txtVolverAescribir.Location = New System.Drawing.Point(173, 132)
        Me.txtVolverAescribir.Name = "txtVolverAescribir"
        Me.txtVolverAescribir.Size = New System.Drawing.Size(179, 20)
        Me.txtVolverAescribir.TabIndex = 6
        Me.ToolTipRecup.SetToolTip(Me.txtVolverAescribir, "Ingrese nuevamente la contraseña")
        '
        'botonCambioClave
        '
        Me.botonCambioClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonCambioClave.Location = New System.Drawing.Point(60, 170)
        Me.botonCambioClave.Name = "botonCambioClave"
        Me.botonCambioClave.Size = New System.Drawing.Size(92, 32)
        Me.botonCambioClave.TabIndex = 1
        Me.botonCambioClave.Text = "&CAMBIAR"
        Me.ToolTipRecup.SetToolTip(Me.botonCambioClave, "Cambiar contraseña")
        Me.botonCambioClave.UseVisualStyleBackColor = True
        '
        'botonCancelarCambio
        '
        Me.botonCancelarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonCancelarCambio.Location = New System.Drawing.Point(209, 170)
        Me.botonCancelarCambio.Name = "botonCancelarCambio"
        Me.botonCancelarCambio.Size = New System.Drawing.Size(93, 32)
        Me.botonCancelarCambio.TabIndex = 2
        Me.botonCancelarCambio.Text = "CANCE&LAR"
        Me.ToolTipRecup.SetToolTip(Me.botonCancelarCambio, "Cancelar cambio de contraseña")
        Me.botonCancelarCambio.UseVisualStyleBackColor = True
        '
        'RecuperarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(363, 214)
        Me.Controls.Add(Me.botonCancelarCambio)
        Me.Controls.Add(Me.botonCambioClave)
        Me.Controls.Add(Me.txtVolverAescribir)
        Me.Controls.Add(Me.txtNuevaContraseña)
        Me.Controls.Add(Me.txtCodigoRecuperacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecuperarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Contraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigoRecuperacion As TextBox
    Friend WithEvents txtNuevaContraseña As TextBox
    Friend WithEvents txtVolverAescribir As TextBox
    Friend WithEvents botonCambioClave As Button
    Friend WithEvents botonCancelarCambio As Button
    Friend WithEvents ToolTipRecup As ToolTip
End Class
