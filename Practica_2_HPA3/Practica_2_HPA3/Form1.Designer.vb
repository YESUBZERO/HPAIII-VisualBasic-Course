<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_informatica = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_letter_blue = New System.Windows.Forms.RadioButton()
        Me.rb_letter_green = New System.Windows.Forms.RadioButton()
        Me.rb_letter_red = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_background_blue = New System.Windows.Forms.RadioButton()
        Me.rb_background_green = New System.Windows.Forms.RadioButton()
        Me.rb_background_rojo = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_Style_Subrayado = New System.Windows.Forms.CheckBox()
        Me.cb_Style_Cursiva = New System.Windows.Forms.CheckBox()
        Me.cb_Style_Negrita = New System.Windows.Forms.CheckBox()
        Me._Exit_Button = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_informatica
        '
        Me.txt_informatica.BackColor = System.Drawing.SystemColors.Window
        Me.txt_informatica.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_informatica.Location = New System.Drawing.Point(172, 30)
        Me.txt_informatica.Name = "txt_informatica"
        Me.txt_informatica.Size = New System.Drawing.Size(475, 93)
        Me.txt_informatica.TabIndex = 0
        Me.txt_informatica.Text = "INFORMATICA"
        Me.txt_informatica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_letter_blue)
        Me.GroupBox1.Controls.Add(Me.rb_letter_green)
        Me.GroupBox1.Controls.Add(Me.rb_letter_red)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color de la letra"
        '
        'rb_letter_blue
        '
        Me.rb_letter_blue.AutoSize = True
        Me.rb_letter_blue.Location = New System.Drawing.Point(7, 75)
        Me.rb_letter_blue.Name = "rb_letter_blue"
        Me.rb_letter_blue.Size = New System.Drawing.Size(48, 19)
        Me.rb_letter_blue.TabIndex = 2
        Me.rb_letter_blue.TabStop = True
        Me.rb_letter_blue.Text = "Azul"
        Me.rb_letter_blue.UseVisualStyleBackColor = True
        '
        'rb_letter_green
        '
        Me.rb_letter_green.AutoSize = True
        Me.rb_letter_green.Location = New System.Drawing.Point(7, 49)
        Me.rb_letter_green.Name = "rb_letter_green"
        Me.rb_letter_green.Size = New System.Drawing.Size(54, 19)
        Me.rb_letter_green.TabIndex = 1
        Me.rb_letter_green.TabStop = True
        Me.rb_letter_green.Text = "Verde"
        Me.rb_letter_green.UseVisualStyleBackColor = True
        '
        'rb_letter_red
        '
        Me.rb_letter_red.AutoSize = True
        Me.rb_letter_red.Location = New System.Drawing.Point(7, 23)
        Me.rb_letter_red.Name = "rb_letter_red"
        Me.rb_letter_red.Size = New System.Drawing.Size(49, 19)
        Me.rb_letter_red.TabIndex = 0
        Me.rb_letter_red.TabStop = True
        Me.rb_letter_red.Text = "Rojo"
        Me.rb_letter_red.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_background_blue)
        Me.GroupBox2.Controls.Add(Me.rb_background_green)
        Me.GroupBox2.Controls.Add(Me.rb_background_rojo)
        Me.GroupBox2.Location = New System.Drawing.Point(421, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color de fondo"
        '
        'rb_background_blue
        '
        Me.rb_background_blue.AutoSize = True
        Me.rb_background_blue.Location = New System.Drawing.Point(7, 74)
        Me.rb_background_blue.Name = "rb_background_blue"
        Me.rb_background_blue.Size = New System.Drawing.Size(48, 19)
        Me.rb_background_blue.TabIndex = 2
        Me.rb_background_blue.TabStop = True
        Me.rb_background_blue.Text = "Azul"
        Me.rb_background_blue.UseVisualStyleBackColor = True
        '
        'rb_background_green
        '
        Me.rb_background_green.AutoSize = True
        Me.rb_background_green.Location = New System.Drawing.Point(7, 48)
        Me.rb_background_green.Name = "rb_background_green"
        Me.rb_background_green.Size = New System.Drawing.Size(54, 19)
        Me.rb_background_green.TabIndex = 1
        Me.rb_background_green.TabStop = True
        Me.rb_background_green.Text = "Verde"
        Me.rb_background_green.UseVisualStyleBackColor = True
        '
        'rb_background_rojo
        '
        Me.rb_background_rojo.AutoSize = True
        Me.rb_background_rojo.Location = New System.Drawing.Point(7, 23)
        Me.rb_background_rojo.Name = "rb_background_rojo"
        Me.rb_background_rojo.Size = New System.Drawing.Size(49, 19)
        Me.rb_background_rojo.TabIndex = 0
        Me.rb_background_rojo.TabStop = True
        Me.rb_background_rojo.Text = "Rojo"
        Me.rb_background_rojo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_Style_Subrayado)
        Me.GroupBox3.Controls.Add(Me.cb_Style_Cursiva)
        Me.GroupBox3.Controls.Add(Me.cb_Style_Negrita)
        Me.GroupBox3.Location = New System.Drawing.Point(191, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estilo de la letra"
        '
        'cb_Style_Subrayado
        '
        Me.cb_Style_Subrayado.AutoSize = True
        Me.cb_Style_Subrayado.Location = New System.Drawing.Point(7, 75)
        Me.cb_Style_Subrayado.Name = "cb_Style_Subrayado"
        Me.cb_Style_Subrayado.Size = New System.Drawing.Size(82, 19)
        Me.cb_Style_Subrayado.TabIndex = 2
        Me.cb_Style_Subrayado.Text = "Subrayado"
        Me.cb_Style_Subrayado.UseVisualStyleBackColor = True
        '
        'cb_Style_Cursiva
        '
        Me.cb_Style_Cursiva.AutoSize = True
        Me.cb_Style_Cursiva.Location = New System.Drawing.Point(7, 49)
        Me.cb_Style_Cursiva.Name = "cb_Style_Cursiva"
        Me.cb_Style_Cursiva.Size = New System.Drawing.Size(65, 19)
        Me.cb_Style_Cursiva.TabIndex = 1
        Me.cb_Style_Cursiva.Text = "Cursiva"
        Me.cb_Style_Cursiva.UseVisualStyleBackColor = True
        '
        'cb_Style_Negrita
        '
        Me.cb_Style_Negrita.AutoSize = True
        Me.cb_Style_Negrita.Location = New System.Drawing.Point(7, 23)
        Me.cb_Style_Negrita.Name = "cb_Style_Negrita"
        Me.cb_Style_Negrita.Size = New System.Drawing.Size(65, 19)
        Me.cb_Style_Negrita.TabIndex = 0
        Me.cb_Style_Negrita.Text = "Negrita"
        Me.cb_Style_Negrita.UseVisualStyleBackColor = True
        '
        '_Exit_Button
        '
        Me._Exit_Button.Location = New System.Drawing.Point(484, 296)
        Me._Exit_Button.Name = "_Exit_Button"
        Me._Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me._Exit_Button.TabIndex = 4
        Me._Exit_Button.Text = "Salir"
        Me._Exit_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me._Exit_Button)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_informatica)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_informatica As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_letter_blue As RadioButton
    Friend WithEvents rb_letter_green As RadioButton
    Friend WithEvents rb_letter_red As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_background_blue As RadioButton
    Friend WithEvents rb_background_green As RadioButton
    Friend WithEvents rb_background_rojo As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cb_Style_Subrayado As CheckBox
    Friend WithEvents cb_Style_Cursiva As CheckBox
    Friend WithEvents cb_Style_Negrita As CheckBox
    Friend WithEvents _Exit_Button As Button
End Class
