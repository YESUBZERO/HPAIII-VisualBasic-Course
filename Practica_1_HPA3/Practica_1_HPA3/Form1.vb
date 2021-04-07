Public Class FRMPractica1

    Dim Total As Double
    Dim Num1 As Integer
    Dim Num2 As Integer

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub FRMPractica1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrimerNumero.TextChanged

    End Sub

    Private Sub BotonSuma_Click(sender As Object, e As EventArgs) Handles BotonSuma.Click

        Num1 = TextBoxPrimerNumero.Text
        Num2 = TextBoxSegundoNumero.Text
        Total = Num1 + Num2
        TextBoxTotal.Text = Total



    End Sub

    Private Sub Boton_Division_Click(sender As Object, e As EventArgs) Handles Boton_Division.Click
        TextBoxTotal.Text = ""
        If Num2 > 0 Then
            Num1 = TextBoxPrimerNumero.Text
            Num2 = TextBoxSegundoNumero.Text
            Total = Num1 / Num2
            TextBoxTotal.Text = Total
        End If
        If Num2 = 0 Then
            TextBoxTotal.Text = "Error de sintaxis"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton_Resta.Click
        Num1 = TextBoxPrimerNumero.Text
        Num2 = TextBoxSegundoNumero.Text
        Total = Num1 - Num2
        TextBoxTotal.Text = Total
    End Sub

    Private Sub Boton_Multiplicar_Click(sender As Object, e As EventArgs) Handles Boton_Multiplicar.Click
        Num1 = TextBoxPrimerNumero.Text
        Num2 = TextBoxSegundoNumero.Text
        Total = Num1 * Num2
        TextBoxTotal.Text = Total
    End Sub
End Class
