Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rb_letter_red_CheckedChanged(sender As Object, e As EventArgs) Handles rb_letter_red.CheckedChanged
        txt_informatica.ForeColor = Color.Red
    End Sub

    Private Sub rb_letter_green_CheckedChanged(sender As Object, e As EventArgs) Handles rb_letter_green.CheckedChanged
        txt_informatica.ForeColor = Color.Green
    End Sub

    Private Sub rb_letter_blue_CheckedChanged(sender As Object, e As EventArgs) Handles rb_letter_blue.CheckedChanged
        txt_informatica.ForeColor = Color.Blue
    End Sub

    Private Sub rb_background_rojo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_background_rojo.CheckedChanged
        txt_informatica.BackColor = Color.Red
    End Sub

    Private Sub _Exit_Button_Click(sender As Object, e As EventArgs) Handles _Exit_Button.Click
        End
    End Sub

    Private Sub rb_background_green_CheckedChanged(sender As Object, e As EventArgs) Handles rb_background_green.CheckedChanged
        txt_informatica.BackColor = Color.Green
    End Sub

    Private Sub rb_background_blue_CheckedChanged(sender As Object, e As EventArgs) Handles rb_background_blue.CheckedChanged
        txt_informatica.BackColor = Color.Blue
    End Sub

    Private Sub cb_Style_Negrita_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Style_Negrita.CheckedChanged
        If cb_Style_Negrita.Checked Then
            txt_informatica.Font = New Font(txt_informatica.Font, FontStyle.Bold)
        Else
            txt_informatica.Font = New Font(txt_informatica.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub cb_Style_Cursiva_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Style_Cursiva.CheckedChanged
        txt_informatica.Font = New Font(txt_informatica.Font, FontStyle.Italic)
    End Sub

    Private Sub cb_Style_Subrayado_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Style_Subrayado.CheckedChanged
        txt_informatica.Font = New Font(txt_informatica.Font, FontStyle.Underline)
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs)

    End Sub
End Class
