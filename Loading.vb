Public Class Loading
    Private Sub TimerLoading_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        ProgressBar1.Increment(6)
        Labelporcentaje.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 100 Then
            LabelFinalizado.Visible = True
            TimerLoading.Stop()
            LabelMensaje.Visible = True

            ' Me.Hide()
            ' MsgBox("ARCHIVO ALMACENADO CORRECTAMENTE", MsgBoxStyle.Information, "AVISO")
        End If


    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub LabelFinalizado_Click(sender As Object, e As EventArgs) Handles LabelFinalizado.Click

    End Sub

    Private Sub Labelporcentaje_Click(sender As Object, e As EventArgs) Handles Labelporcentaje.Click

    End Sub

    Private Sub LabelMensaje_Click(sender As Object, e As EventArgs) Handles LabelMensaje.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class