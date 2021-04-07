<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me._Generar_Button = New System.Windows.Forms.Button()
        Me._Limpiar_Button = New System.Windows.Forms.Button()
        Me._Numero_TextBox = New System.Windows.Forms.TextBox()
        Me._Resultado_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Salir_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(119, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = """Uso de FOR"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Introduzca un numero y conoce la tabla de multiplicar"
        '
        '_Generar_Button
        '
        Me._Generar_Button.BackColor = System.Drawing.Color.Green
        Me._Generar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me._Generar_Button.ForeColor = System.Drawing.Color.White
        Me._Generar_Button.Location = New System.Drawing.Point(343, 101)
        Me._Generar_Button.Name = "_Generar_Button"
        Me._Generar_Button.Size = New System.Drawing.Size(75, 23)
        Me._Generar_Button.TabIndex = 2
        Me._Generar_Button.Text = "Generar"
        Me._Generar_Button.UseVisualStyleBackColor = False
        '
        '_Limpiar_Button
        '
        Me._Limpiar_Button.BackColor = System.Drawing.Color.Maroon
        Me._Limpiar_Button.Enabled = False
        Me._Limpiar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me._Limpiar_Button.ForeColor = System.Drawing.Color.White
        Me._Limpiar_Button.Location = New System.Drawing.Point(343, 140)
        Me._Limpiar_Button.Name = "_Limpiar_Button"
        Me._Limpiar_Button.Size = New System.Drawing.Size(75, 23)
        Me._Limpiar_Button.TabIndex = 3
        Me._Limpiar_Button.Text = "Limpiar"
        Me._Limpiar_Button.UseVisualStyleBackColor = False
        '
        '_Numero_TextBox
        '
        Me._Numero_TextBox.Location = New System.Drawing.Point(13, 101)
        Me._Numero_TextBox.Name = "_Numero_TextBox"
        Me._Numero_TextBox.Size = New System.Drawing.Size(292, 23)
        Me._Numero_TextBox.TabIndex = 4
        '
        '_Resultado_TextBox
        '
        Me._Resultado_TextBox.Location = New System.Drawing.Point(13, 158)
        Me._Resultado_TextBox.Multiline = True
        Me._Resultado_TextBox.Name = "_Resultado_TextBox"
        Me._Resultado_TextBox.Size = New System.Drawing.Size(292, 280)
        Me._Resultado_TextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado..."
        '
        '_Salir_Button
        '
        Me._Salir_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me._Salir_Button.Location = New System.Drawing.Point(343, 414)
        Me._Salir_Button.Name = "_Salir_Button"
        Me._Salir_Button.Size = New System.Drawing.Size(75, 23)
        Me._Salir_Button.TabIndex = 7
        Me._Salir_Button.Text = "Salir"
        Me._Salir_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 450)
        Me.Controls.Add(Me._Salir_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me._Resultado_TextBox)
        Me.Controls.Add(Me._Numero_TextBox)
        Me.Controls.Add(Me._Limpiar_Button)
        Me.Controls.Add(Me._Generar_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents _Generar_Button As Button
    Friend WithEvents _Limpiar_Button As Button
    Friend WithEvents _Numero_TextBox As TextBox
    Friend WithEvents _Resultado_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents _Salir_Button As Button
End Class
