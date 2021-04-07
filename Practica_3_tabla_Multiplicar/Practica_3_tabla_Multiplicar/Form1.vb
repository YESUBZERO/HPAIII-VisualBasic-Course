Public Class Form1
    Private Sub _Generar_Button_Click(sender As Object, e As EventArgs) Handles _Generar_Button.Click
        Dim _Numero As Integer
        Dim i As Integer

        _Limpiar_Button.Enabled = True

        _Numero = _Numero_TextBox.Text
        For i = 0 To 9 Step 1
            _Resultado_TextBox.Text = _Resultado_TextBox.Text & _Numero & "x" & i & " = " & _Numero * i & vbCrLf
        Next

    End Sub

    Private Sub _Salir_Button_Click(sender As Object, e As EventArgs) Handles _Salir_Button.Click
        End
    End Sub

    Private Sub _Limpiar_Button_Click(sender As Object, e As EventArgs) Handles _Limpiar_Button.Click
        _Numero_TextBox.Text = " "
        _Resultado_TextBox.Text = " "
        _Limpiar_Button.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = " Uso de For"
    End Sub
End Class
