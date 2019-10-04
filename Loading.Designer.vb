<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.Labelporcentaje = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelFinalizado = New System.Windows.Forms.Label()
        Me.TimerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTipLoading = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Labelporcentaje
        '
        Me.Labelporcentaje.AutoSize = True
        Me.Labelporcentaje.Location = New System.Drawing.Point(11, 57)
        Me.Labelporcentaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelporcentaje.Name = "Labelporcentaje"
        Me.Labelporcentaje.Size = New System.Drawing.Size(27, 16)
        Me.Labelporcentaje.TabIndex = 0
        Me.Labelporcentaje.Text = "0%"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.OrangeRed
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 33)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(317, 21)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        Me.ToolTipLoading.SetToolTip(Me.ProgressBar1, "Barra de estado")
        '
        'LabelFinalizado
        '
        Me.LabelFinalizado.AutoSize = True
        Me.LabelFinalizado.Location = New System.Drawing.Point(258, 55)
        Me.LabelFinalizado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFinalizado.Name = "LabelFinalizado"
        Me.LabelFinalizado.Size = New System.Drawing.Size(70, 16)
        Me.LabelFinalizado.TabIndex = 2
        Me.LabelFinalizado.Text = "Finalizado"
        Me.LabelFinalizado.Visible = False
        '
        'TimerLoading
        '
        '
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMensaje.ForeColor = System.Drawing.Color.Black
        Me.LabelMensaje.Location = New System.Drawing.Point(37, 81)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(266, 20)
        Me.LabelMensaje.TabIndex = 3
        Me.LabelMensaje.Text = "Datos almacenados correctamente.."
        Me.LabelMensaje.Visible = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(254, 110)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "SALIR"
        Me.ToolTipLoading.SetToolTip(Me.ButtonSalir, "Salir")
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Loading..."
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(338, 139)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.LabelFinalizado)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Labelporcentaje)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Brown
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Loading"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelporcentaje As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LabelFinalizado As Label
    Friend WithEvents TimerLoading As Timer
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTipLoading As ToolTip
End Class
