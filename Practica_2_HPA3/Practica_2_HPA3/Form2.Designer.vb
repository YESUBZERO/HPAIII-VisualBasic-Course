<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.simbolo = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Suma_Button = New System.Windows.Forms.Button()
        Me.Resta_Button = New System.Windows.Forms.Button()
        Me.Division_Button = New System.Windows.Forms.Button()
        Me.Producto_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 0
        '
        'simbolo
        '
        Me.simbolo.AutoSize = True
        Me.simbolo.Location = New System.Drawing.Point(199, 101)
        Me.simbolo.Name = "simbolo"
        Me.simbolo.Size = New System.Drawing.Size(14, 15)
        Me.simbolo.TabIndex = 1
        Me.simbolo.Text = "X"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(219, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 2
        '
        'Suma_Button
        '
        Me.Suma_Button.Location = New System.Drawing.Point(92, 143)
        Me.Suma_Button.Name = "Suma_Button"
        Me.Suma_Button.Size = New System.Drawing.Size(75, 23)
        Me.Suma_Button.TabIndex = 3
        Me.Suma_Button.Text = "Suma"
        Me.Suma_Button.UseVisualStyleBackColor = True
        '
        'Resta_Button
        '
        Me.Resta_Button.Location = New System.Drawing.Point(219, 143)
        Me.Resta_Button.Name = "Resta_Button"
        Me.Resta_Button.Size = New System.Drawing.Size(75, 23)
        Me.Resta_Button.TabIndex = 4
        Me.Resta_Button.Text = "Resta"
        Me.Resta_Button.UseVisualStyleBackColor = True
        '
        'Division_Button
        '
        Me.Division_Button.Location = New System.Drawing.Point(92, 173)
        Me.Division_Button.Name = "Division_Button"
        Me.Division_Button.Size = New System.Drawing.Size(75, 23)
        Me.Division_Button.TabIndex = 5
        Me.Division_Button.Text = "Division"
        Me.Division_Button.UseVisualStyleBackColor = True
        '
        'Producto_Button
        '
        Me.Producto_Button.Location = New System.Drawing.Point(219, 173)
        Me.Producto_Button.Name = "Producto_Button"
        Me.Producto_Button.Size = New System.Drawing.Size(75, 23)
        Me.Producto_Button.TabIndex = 6
        Me.Producto_Button.Text = "Producto"
        Me.Producto_Button.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Producto_Button)
        Me.Controls.Add(Me.Division_Button)
        Me.Controls.Add(Me.Resta_Button)
        Me.Controls.Add(Me.Suma_Button)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.simbolo)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents simbolo As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Suma_Button As Button
    Friend WithEvents Resta_Button As Button
    Friend WithEvents Division_Button As Button
    Friend WithEvents Producto_Button As Button
End Class
