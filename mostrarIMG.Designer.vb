<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostrarIMG
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
        Me.PictureBoxMost = New System.Windows.Forms.PictureBox()
        Me.ButtonImprimirIMG = New System.Windows.Forms.Button()
        Me.PrintDialogIMP = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentIMP = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBoxMost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxMost
        '
        Me.PictureBoxMost.Location = New System.Drawing.Point(12, 1)
        Me.PictureBoxMost.Name = "PictureBoxMost"
        Me.PictureBoxMost.Size = New System.Drawing.Size(750, 600)
        Me.PictureBoxMost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMost.TabIndex = 0
        Me.PictureBoxMost.TabStop = False
        '
        'ButtonImprimirIMG
        '
        Me.ButtonImprimirIMG.Location = New System.Drawing.Point(623, 583)
        Me.ButtonImprimirIMG.Name = "ButtonImprimirIMG"
        Me.ButtonImprimirIMG.Size = New System.Drawing.Size(103, 54)
        Me.ButtonImprimirIMG.TabIndex = 1
        Me.ButtonImprimirIMG.Text = "IMPRIMIR"
        Me.ButtonImprimirIMG.UseVisualStyleBackColor = True
        '
        'PrintDialogIMP
        '
        Me.PrintDialogIMP.UseEXDialog = True
        '
        'PrintDocumentIMP
        '
        '
        'mostrarIMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 638)
        Me.Controls.Add(Me.ButtonImprimirIMG)
        Me.Controls.Add(Me.PictureBoxMost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(790, 680)
        Me.MinimumSize = New System.Drawing.Size(790, 672)
        Me.Name = "mostrarIMG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.PictureBoxMost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxMost As PictureBox
    Friend WithEvents ButtonImprimirIMG As Button
    Friend WithEvents PrintDialogIMP As PrintDialog
    Friend WithEvents PrintDocumentIMP As Drawing.Printing.PrintDocument
End Class
