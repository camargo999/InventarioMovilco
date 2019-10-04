Public Class mostrarIMG
    Private Sub MostrarIMG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonImprimirIMG_Click(sender As Object, e As EventArgs) Handles ButtonImprimirIMG.Click
        If PrintDialogIMP.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PrintDocumentIMP.PrinterSettings = PrintDialogIMP.PrinterSettings
            PrintDocumentIMP.Print()
            Me.Close()
        Else
            MsgBox("IMPRESION INTERRUMPIDA.", MsgBoxStyle.Exclamation, "AVISO")
            Me.Close()
        End If

    End Sub

    Private Sub PrintDocumentIMP_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentIMP.PrintPage
        e.Graphics.DrawImage(PictureBoxMost.Image, 10, 10, 800, 800)
    End Sub
End Class