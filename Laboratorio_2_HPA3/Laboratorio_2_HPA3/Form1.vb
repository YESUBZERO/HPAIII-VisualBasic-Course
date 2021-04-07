Public Class Form1
    'PRECIOS DE LOS PRODUCTOS QUE SE OFRECEN'
    Dim _Price_Hamburguesa As Double = 4.75
    Dim _Price_HotDog As Double = 3.25
    Dim _Price_Sandwich As Double = 1.75
    Dim _Price_Papas As Double = 0.75
    Dim _Price_Refresco As Double = 1.0
    Dim _Price_Gaseosa As Double = 2.0

    'VARIABLES GLOBALES'
    Dim _Cantidad_Hamburguesa As Integer
    Dim _Cantidad_HotDog As Integer
    Dim _Cantidad_Sandwich As Integer
    Dim _Cantidad_Gaseosa As Integer
    Dim _Cantidad_Refrescos As Integer
    Dim _Cantidad_PapasFritas As Integer
    Dim _total As Double
    Private Sub _Combo1_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles _Combo1_CheckBox.CheckedChanged
        If _Combo1_CheckBox.Checked Then
            _Hamburguesa_TextBox.Enabled = True
            _Gaseosa_TextBox.Enabled = True
            _Papas_TextBox.Enabled = True

        Else
            _Hamburguesa_TextBox.Enabled = False
            _Gaseosa_TextBox.Enabled = False
            _Papas_TextBox.Enabled = False
        End If
    End Sub

    Private Sub _Combo2_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles _Combo2_CheckBox.CheckedChanged
        If _Combo2_CheckBox.Checked Then
            _HotDog_TextBox.Enabled = True
            _Gaseosa_TextBox.Enabled = True
            _Papas_TextBox.Enabled = True


        Else
            _HotDog_TextBox.Enabled = False
            _Gaseosa_TextBox.Enabled = False
            _Papas_TextBox.Enabled = False
        End If
    End Sub

    Private Sub _Combo3_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles _Combo3_CheckBox.CheckedChanged
        If _Combo3_CheckBox.Checked Then
            _Sandwich_TextBox.Enabled = True
            _Gaseosa_TextBox.Enabled = True
            _Papas_TextBox.Enabled = True


        Else
            _Sandwich_TextBox.Enabled = False
            _Gaseosa_TextBox.Enabled = False
            _Papas_TextBox.Enabled = False
        End If
    End Sub

    Private Sub _Total_Button_Click(sender As Object, e As EventArgs) Handles _Total_Button.Click
        If _Combo1_CheckBox.Checked Then
            _Cantidad_Hamburguesa = _Hamburguesa_TextBox.Text
            _Cantidad_Gaseosa = _Gaseosa_TextBox.Text
            _Cantidad_PapasFritas = _Papas_TextBox.Text
            _Cantidad_Refrescos = _refrescos_TextBox.Text

            _total = ((_Cantidad_Hamburguesa * _Price_Hamburguesa) + (_Cantidad_Gaseosa * _Price_Gaseosa) + (_Cantidad_PapasFritas * _Price_Papas) + (_Cantidad_Refrescos * _Price_Refresco))
            _TotalCobro_TextBox.Text = _total
        ElseIf _Combo2_CheckBox.Checked Then
            _Cantidad_HotDog = _HotDog_TextBox.Text
            _Cantidad_Gaseosa = _Gaseosa_TextBox.Text
            _Cantidad_PapasFritas = _Papas_TextBox.Text
            _Cantidad_Refrescos = _refrescos_TextBox.Text

            _total = ((_Cantidad_HotDog * _Price_HotDog) + (_Cantidad_Gaseosa * _Price_Gaseosa) + (_Cantidad_PapasFritas * _Price_Papas) + (_Cantidad_Refrescos * _Price_Refresco))
            _TotalCobro_TextBox.Text = _total
        ElseIf _Combo3_CheckBox.Checked Then
            _Cantidad_Sandwich = _Sandwich_TextBox.Text
            _Cantidad_Gaseosa = _Gaseosa_TextBox.Text
            _Cantidad_PapasFritas = _Papas_TextBox.Text
            _Cantidad_Refrescos = _refrescos_TextBox.Text

            _total = ((_Cantidad_Sandwich * _Price_Sandwich) + (_Cantidad_Gaseosa * _Price_Gaseosa) + (_Cantidad_PapasFritas * _Price_Papas) + (_Cantidad_Refrescos * _Price_Refresco))
            _TotalCobro_TextBox.Text = _total
        End If
    End Sub

    Private Sub _Limpiar_Button_Click(sender As Object, e As EventArgs) Handles _Limpiar_Button.Click
        Me._Hamburguesa_TextBox.Text = "0"
        Me._HotDog_TextBox.Text = "0"
        Me._Gaseosa_TextBox.Text = "0"
        Me._Sandwich_TextBox.Text = "0"
        Me._Papas_TextBox.Text = "0"
        Me._refrescos_TextBox.Text = "0"
        Me._Combo1_CheckBox.Checked = False
        Me._Combo2_CheckBox.Checked = False
        Me._Combo3_CheckBox.Checked = False
    End Sub

    Private Sub _Exit_Button_Click(sender As Object, e As EventArgs) Handles _Exit_Button.Click
        End
    End Sub
End Class
