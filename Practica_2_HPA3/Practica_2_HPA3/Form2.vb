Public Class Form2
    Private Sub Suma_Button_Click(sender As Object, e As EventArgs) Handles Suma_Button.Click
        simbolo.Text = "+"
    End Sub

    Private Sub Resta_Button_Click(sender As Object, e As EventArgs) Handles Resta_Button.Click
        simbolo.Text = "-"
    End Sub

    Private Sub Division_Button_Click(sender As Object, e As EventArgs) Handles Division_Button.Click
        simbolo.Text = "/"
    End Sub

    Private Sub Producto_Button_Click(sender As Object, e As EventArgs) Handles Producto_Button.Click
        simbolo.Text = "*"
    End Sub
End Class