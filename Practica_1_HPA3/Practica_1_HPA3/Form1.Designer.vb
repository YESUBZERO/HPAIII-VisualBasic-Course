<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPractica1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPrimerNumero = New System.Windows.Forms.TextBox()
        Me.TextBoxSegundoNumero = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.BotonSuma = New System.Windows.Forms.Button()
        Me.Boton_Division = New System.Windows.Forms.Button()
        Me.Boton_Resta = New System.Windows.Forms.Button()
        Me.Boton_Multiplicar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CALCULADORA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Primer Numero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Segundo Numero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total:"
        '
        'TextBoxPrimerNumero
        '
        Me.TextBoxPrimerNumero.Location = New System.Drawing.Point(266, 119)
        Me.TextBoxPrimerNumero.Name = "TextBoxPrimerNumero"
        Me.TextBoxPrimerNumero.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPrimerNumero.TabIndex = 4
        '
        'TextBoxSegundoNumero
        '
        Me.TextBoxSegundoNumero.Location = New System.Drawing.Point(266, 164)
        Me.TextBoxSegundoNumero.Name = "TextBoxSegundoNumero"
        Me.TextBoxSegundoNumero.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxSegundoNumero.TabIndex = 5
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(266, 206)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxTotal.TabIndex = 6
        '
        'BotonSuma
        '
        Me.BotonSuma.Location = New System.Drawing.Point(454, 119)
        Me.BotonSuma.Name = "BotonSuma"
        Me.BotonSuma.Size = New System.Drawing.Size(75, 23)
        Me.BotonSuma.TabIndex = 7
        Me.BotonSuma.Text = "Sumar"
        Me.BotonSuma.UseVisualStyleBackColor = True
        '
        'Boton_Division
        '
        Me.Boton_Division.Location = New System.Drawing.Point(454, 180)
        Me.Boton_Division.Name = "Boton_Division"
        Me.Boton_Division.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Division.TabIndex = 8
        Me.Boton_Division.TabStop = False
        Me.Boton_Division.Text = "Dividir"
        Me.Boton_Division.UseVisualStyleBackColor = True
        '
        'Boton_Resta
        '
        Me.Boton_Resta.Location = New System.Drawing.Point(454, 148)
        Me.Boton_Resta.Name = "Boton_Resta"
        Me.Boton_Resta.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Resta.TabIndex = 9
        Me.Boton_Resta.Text = "Restar"
        Me.Boton_Resta.UseVisualStyleBackColor = True
        '
        'Boton_Multiplicar
        '
        Me.Boton_Multiplicar.Location = New System.Drawing.Point(454, 209)
        Me.Boton_Multiplicar.Name = "Boton_Multiplicar"
        Me.Boton_Multiplicar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Multiplicar.TabIndex = 10
        Me.Boton_Multiplicar.Text = "Multiplicar"
        Me.Boton_Multiplicar.UseVisualStyleBackColor = True
        '
        'FRMPractica1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Boton_Multiplicar)
        Me.Controls.Add(Me.Boton_Resta)
        Me.Controls.Add(Me.Boton_Division)
        Me.Controls.Add(Me.BotonSuma)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxSegundoNumero)
        Me.Controls.Add(Me.TextBoxPrimerNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMPractica1"
        Me.Text = "Formulario de Practica VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrimerNumero As TextBox
    Friend WithEvents TextBoxSegundoNumero As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents BotonSuma As Button
    Friend WithEvents Boton_Division As Button
    Friend WithEvents Boton_Resta As Button
    Friend WithEvents Boton_Multiplicar As Button
End Class
