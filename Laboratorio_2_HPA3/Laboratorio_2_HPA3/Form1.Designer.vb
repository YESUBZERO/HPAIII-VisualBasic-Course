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
        Me._title_label = New System.Windows.Forms.Label()
        Me._GB_Pedidos = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._Combo3_CheckBox = New System.Windows.Forms.CheckBox()
        Me._Combo2_CheckBox = New System.Windows.Forms.CheckBox()
        Me._Combo1_CheckBox = New System.Windows.Forms.CheckBox()
        Me._GB_Alimentos_select = New System.Windows.Forms.GroupBox()
        Me._Papas_Label = New System.Windows.Forms.Label()
        Me._Refrescos_Label = New System.Windows.Forms.Label()
        Me._Gaseosa_Label = New System.Windows.Forms.Label()
        Me._Sandwich_Label = New System.Windows.Forms.Label()
        Me._HotDog_Label = New System.Windows.Forms.Label()
        Me._Hamburguesa_Label = New System.Windows.Forms.Label()
        Me._Papas_TextBox = New System.Windows.Forms.TextBox()
        Me._refrescos_TextBox = New System.Windows.Forms.TextBox()
        Me._Gaseosa_TextBox = New System.Windows.Forms.TextBox()
        Me._Sandwich_TextBox = New System.Windows.Forms.TextBox()
        Me._HotDog_TextBox = New System.Windows.Forms.TextBox()
        Me._Hamburguesa_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Total_Title_Label = New System.Windows.Forms.Label()
        Me._TotalCobro_TextBox = New System.Windows.Forms.TextBox()
        Me._Total_Button = New System.Windows.Forms.Button()
        Me._Limpiar_Button = New System.Windows.Forms.Button()
        Me._Exit_Button = New System.Windows.Forms.Button()
        Me._GB_Pedidos.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GB_Alimentos_select.SuspendLayout()
        Me.SuspendLayout()
        '
        '_title_label
        '
        Me._title_label.AllowDrop = True
        Me._title_label.AutoSize = True
        Me._title_label.Font = New System.Drawing.Font("Hobo Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me._title_label.Location = New System.Drawing.Point(108, 19)
        Me._title_label.Name = "_title_label"
        Me._title_label.Size = New System.Drawing.Size(305, 30)
        Me._title_label.TabIndex = 0
        Me._title_label.Text = "Cobro de Servicio de Comida"
        Me._title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_GB_Pedidos
        '
        Me._GB_Pedidos.Controls.Add(Me.PictureBox3)
        Me._GB_Pedidos.Controls.Add(Me.PictureBox2)
        Me._GB_Pedidos.Controls.Add(Me.PictureBox1)
        Me._GB_Pedidos.Controls.Add(Me._Combo3_CheckBox)
        Me._GB_Pedidos.Controls.Add(Me._Combo2_CheckBox)
        Me._GB_Pedidos.Controls.Add(Me._Combo1_CheckBox)
        Me._GB_Pedidos.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me._GB_Pedidos.Location = New System.Drawing.Point(12, 84)
        Me._GB_Pedidos.Name = "_GB_Pedidos"
        Me._GB_Pedidos.Size = New System.Drawing.Size(273, 122)
        Me._GB_Pedidos.TabIndex = 1
        Me._GB_Pedidos.TabStop = False
        Me._GB_Pedidos.Text = "Seleccion por Pedidos"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Laboratorio_2_HPA3.My.Resources.Resources.sandwich
        Me.PictureBox3.Location = New System.Drawing.Point(16, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Laboratorio_2_HPA3.My.Resources.Resources.hot_dog
        Me.PictureBox2.Location = New System.Drawing.Point(16, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Laboratorio_2_HPA3.My.Resources.Resources.fast_food
        Me.PictureBox1.Location = New System.Drawing.Point(16, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        '_Combo3_CheckBox
        '
        Me._Combo3_CheckBox.AutoSize = True
        Me._Combo3_CheckBox.Location = New System.Drawing.Point(41, 89)
        Me._Combo3_CheckBox.Name = "_Combo3_CheckBox"
        Me._Combo3_CheckBox.Size = New System.Drawing.Size(205, 18)
        Me._Combo3_CheckBox.TabIndex = 2
        Me._Combo3_CheckBox.Text = "No. 3 (Sandwich, Gaseosa, Papas)"
        Me._Combo3_CheckBox.UseVisualStyleBackColor = True
        '
        '_Combo2_CheckBox
        '
        Me._Combo2_CheckBox.AutoSize = True
        Me._Combo2_CheckBox.Location = New System.Drawing.Point(41, 56)
        Me._Combo2_CheckBox.Name = "_Combo2_CheckBox"
        Me._Combo2_CheckBox.Size = New System.Drawing.Size(197, 18)
        Me._Combo2_CheckBox.TabIndex = 1
        Me._Combo2_CheckBox.Text = "No. 2 (Hot Dog, Gaseosa, Papas)"
        Me._Combo2_CheckBox.UseVisualStyleBackColor = True
        '
        '_Combo1_CheckBox
        '
        Me._Combo1_CheckBox.AutoSize = True
        Me._Combo1_CheckBox.Location = New System.Drawing.Point(41, 22)
        Me._Combo1_CheckBox.Name = "_Combo1_CheckBox"
        Me._Combo1_CheckBox.Size = New System.Drawing.Size(226, 18)
        Me._Combo1_CheckBox.TabIndex = 0
        Me._Combo1_CheckBox.Text = "No. 1 (Hamburguesa, gaseosa, Papas)"
        Me._Combo1_CheckBox.UseVisualStyleBackColor = True
        '
        '_GB_Alimentos_select
        '
        Me._GB_Alimentos_select.BackColor = System.Drawing.Color.White
        Me._GB_Alimentos_select.Controls.Add(Me._Papas_Label)
        Me._GB_Alimentos_select.Controls.Add(Me._Refrescos_Label)
        Me._GB_Alimentos_select.Controls.Add(Me._Gaseosa_Label)
        Me._GB_Alimentos_select.Controls.Add(Me._Sandwich_Label)
        Me._GB_Alimentos_select.Controls.Add(Me._HotDog_Label)
        Me._GB_Alimentos_select.Controls.Add(Me._Hamburguesa_Label)
        Me._GB_Alimentos_select.Controls.Add(Me._Papas_TextBox)
        Me._GB_Alimentos_select.Controls.Add(Me._refrescos_TextBox)
        Me._GB_Alimentos_select.Controls.Add(Me._Gaseosa_TextBox)
        Me._GB_Alimentos_select.Controls.Add(Me._Sandwich_TextBox)
        Me._GB_Alimentos_select.Controls.Add(Me._HotDog_TextBox)
        Me._GB_Alimentos_select.Controls.Add(Me._Hamburguesa_TextBox)
        Me._GB_Alimentos_select.Controls.Add(Me.Label1)
        Me._GB_Alimentos_select.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me._GB_Alimentos_select.Location = New System.Drawing.Point(291, 84)
        Me._GB_Alimentos_select.Name = "_GB_Alimentos_select"
        Me._GB_Alimentos_select.Size = New System.Drawing.Size(180, 256)
        Me._GB_Alimentos_select.TabIndex = 2
        Me._GB_Alimentos_select.TabStop = False
        Me._GB_Alimentos_select.Text = "Alimentos Seleccionados"
        '
        '_Papas_Label
        '
        Me._Papas_Label.AutoSize = True
        Me._Papas_Label.Location = New System.Drawing.Point(71, 221)
        Me._Papas_Label.Name = "_Papas_Label"
        Me._Papas_Label.Size = New System.Drawing.Size(73, 14)
        Me._Papas_Label.TabIndex = 17
        Me._Papas_Label.Text = "Papas Fritas"
        '
        '_Refrescos_Label
        '
        Me._Refrescos_Label.AutoSize = True
        Me._Refrescos_Label.Location = New System.Drawing.Point(71, 184)
        Me._Refrescos_Label.Name = "_Refrescos_Label"
        Me._Refrescos_Label.Size = New System.Drawing.Size(60, 14)
        Me._Refrescos_Label.TabIndex = 16
        Me._Refrescos_Label.Text = "Refrescos"
        '
        '_Gaseosa_Label
        '
        Me._Gaseosa_Label.AutoSize = True
        Me._Gaseosa_Label.Location = New System.Drawing.Point(71, 148)
        Me._Gaseosa_Label.Name = "_Gaseosa_Label"
        Me._Gaseosa_Label.Size = New System.Drawing.Size(51, 14)
        Me._Gaseosa_Label.TabIndex = 15
        Me._Gaseosa_Label.Text = "Gaseosa"
        '
        '_Sandwich_Label
        '
        Me._Sandwich_Label.AutoSize = True
        Me._Sandwich_Label.Location = New System.Drawing.Point(71, 112)
        Me._Sandwich_Label.Name = "_Sandwich_Label"
        Me._Sandwich_Label.Size = New System.Drawing.Size(57, 14)
        Me._Sandwich_Label.TabIndex = 14
        Me._Sandwich_Label.Text = "Sandwich"
        '
        '_HotDog_Label
        '
        Me._HotDog_Label.AutoSize = True
        Me._HotDog_Label.Location = New System.Drawing.Point(71, 76)
        Me._HotDog_Label.Name = "_HotDog_Label"
        Me._HotDog_Label.Size = New System.Drawing.Size(49, 14)
        Me._HotDog_Label.TabIndex = 13
        Me._HotDog_Label.Text = "Hot Dog"
        '
        '_Hamburguesa_Label
        '
        Me._Hamburguesa_Label.AutoSize = True
        Me._Hamburguesa_Label.Location = New System.Drawing.Point(71, 43)
        Me._Hamburguesa_Label.Name = "_Hamburguesa_Label"
        Me._Hamburguesa_Label.Size = New System.Drawing.Size(80, 14)
        Me._Hamburguesa_Label.TabIndex = 12
        Me._Hamburguesa_Label.Text = "Hamburguesa"
        '
        '_Papas_TextBox
        '
        Me._Papas_TextBox.Enabled = False
        Me._Papas_TextBox.Location = New System.Drawing.Point(16, 221)
        Me._Papas_TextBox.Name = "_Papas_TextBox"
        Me._Papas_TextBox.Size = New System.Drawing.Size(39, 21)
        Me._Papas_TextBox.TabIndex = 11
        Me._Papas_TextBox.Text = "0"
        Me._Papas_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_refrescos_TextBox
        '
        Me._refrescos_TextBox.Location = New System.Drawing.Point(16, 184)
        Me._refrescos_TextBox.Name = "_refrescos_TextBox"
        Me._refrescos_TextBox.Size = New System.Drawing.Size(39, 21)
        Me._refrescos_TextBox.TabIndex = 5
        Me._refrescos_TextBox.Text = "0"
        Me._refrescos_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Gaseosa_TextBox
        '
        Me._Gaseosa_TextBox.Enabled = False
        Me._Gaseosa_TextBox.Location = New System.Drawing.Point(16, 148)
        Me._Gaseosa_TextBox.Name = "_Gaseosa_TextBox"
        Me._Gaseosa_TextBox.Size = New System.Drawing.Size(39, 21)
        Me._Gaseosa_TextBox.TabIndex = 4
        Me._Gaseosa_TextBox.Text = "0"
        Me._Gaseosa_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Sandwich_TextBox
        '
        Me._Sandwich_TextBox.Enabled = False
        Me._Sandwich_TextBox.Location = New System.Drawing.Point(16, 112)
        Me._Sandwich_TextBox.Name = "_Sandwich_TextBox"
        Me._Sandwich_TextBox.Size = New System.Drawing.Size(39, 21)
        Me._Sandwich_TextBox.TabIndex = 3
        Me._Sandwich_TextBox.Text = "0"
        Me._Sandwich_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_HotDog_TextBox
        '
        Me._HotDog_TextBox.Enabled = False
        Me._HotDog_TextBox.Location = New System.Drawing.Point(16, 76)
        Me._HotDog_TextBox.Name = "_HotDog_TextBox"
        Me._HotDog_TextBox.Size = New System.Drawing.Size(39, 21)
        Me._HotDog_TextBox.TabIndex = 2
        Me._HotDog_TextBox.Text = "0"
        Me._HotDog_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Hamburguesa_TextBox
        '
        Me._Hamburguesa_TextBox.Enabled = False
        Me._Hamburguesa_TextBox.Location = New System.Drawing.Point(16, 40)
        Me._Hamburguesa_TextBox.Name = "_Hamburguesa_TextBox"
        Me._Hamburguesa_TextBox.Size = New System.Drawing.Size(39, 21)
        Me._Hamburguesa_TextBox.TabIndex = 1
        Me._Hamburguesa_TextBox.Text = "0"
        Me._Hamburguesa_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CANTIDAD"
        '
        '_Total_Title_Label
        '
        Me._Total_Title_Label.AutoSize = True
        Me._Total_Title_Label.Font = New System.Drawing.Font("Hobo Std", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me._Total_Title_Label.Location = New System.Drawing.Point(41, 235)
        Me._Total_Title_Label.Name = "_Total_Title_Label"
        Me._Total_Title_Label.Size = New System.Drawing.Size(122, 18)
        Me._Total_Title_Label.TabIndex = 3
        Me._Total_Title_Label.Text = "TOTAL A COBRAR"
        '
        '_TotalCobro_TextBox
        '
        Me._TotalCobro_TextBox.Location = New System.Drawing.Point(170, 232)
        Me._TotalCobro_TextBox.Name = "_TotalCobro_TextBox"
        Me._TotalCobro_TextBox.Size = New System.Drawing.Size(100, 23)
        Me._TotalCobro_TextBox.TabIndex = 4
        '
        '_Total_Button
        '
        Me._Total_Button.BackColor = System.Drawing.Color.Green
        Me._Total_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me._Total_Button.ForeColor = System.Drawing.Color.White
        Me._Total_Button.Location = New System.Drawing.Point(64, 287)
        Me._Total_Button.Name = "_Total_Button"
        Me._Total_Button.Size = New System.Drawing.Size(55, 23)
        Me._Total_Button.TabIndex = 5
        Me._Total_Button.Text = "Total"
        Me._Total_Button.UseVisualStyleBackColor = False
        '
        '_Limpiar_Button
        '
        Me._Limpiar_Button.BackColor = System.Drawing.Color.Maroon
        Me._Limpiar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me._Limpiar_Button.ForeColor = System.Drawing.Color.White
        Me._Limpiar_Button.Location = New System.Drawing.Point(125, 287)
        Me._Limpiar_Button.Name = "_Limpiar_Button"
        Me._Limpiar_Button.Size = New System.Drawing.Size(55, 23)
        Me._Limpiar_Button.TabIndex = 6
        Me._Limpiar_Button.Text = "Limpiar"
        Me._Limpiar_Button.UseVisualStyleBackColor = False
        '
        '_Exit_Button
        '
        Me._Exit_Button.BackColor = System.Drawing.Color.Maroon
        Me._Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me._Exit_Button.ForeColor = System.Drawing.Color.White
        Me._Exit_Button.Location = New System.Drawing.Point(186, 287)
        Me._Exit_Button.Name = "_Exit_Button"
        Me._Exit_Button.Size = New System.Drawing.Size(54, 23)
        Me._Exit_Button.TabIndex = 7
        Me._Exit_Button.Text = "Salir"
        Me._Exit_Button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(517, 357)
        Me.Controls.Add(Me._Exit_Button)
        Me.Controls.Add(Me._Limpiar_Button)
        Me.Controls.Add(Me._Total_Button)
        Me.Controls.Add(Me._TotalCobro_TextBox)
        Me.Controls.Add(Me._Total_Title_Label)
        Me.Controls.Add(Me._GB_Alimentos_select)
        Me.Controls.Add(Me._GB_Pedidos)
        Me.Controls.Add(Me._title_label)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Cobro de Servicio de Comida"
        Me._GB_Pedidos.ResumeLayout(False)
        Me._GB_Pedidos.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GB_Alimentos_select.ResumeLayout(False)
        Me._GB_Alimentos_select.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _title_label As Label
    Friend WithEvents _GB_Pedidos As GroupBox
    Friend WithEvents _Combo3_CheckBox As CheckBox
    Friend WithEvents _Combo2_CheckBox As CheckBox
    Friend WithEvents _Combo1_CheckBox As CheckBox
    Friend WithEvents _GB_Alimentos_select As GroupBox
    Friend WithEvents _Papas_Label As Label
    Friend WithEvents _Refrescos_Label As Label
    Friend WithEvents _Gaseosa_Label As Label
    Friend WithEvents _Sandwich_Label As Label
    Friend WithEvents _HotDog_Label As Label
    Friend WithEvents _Hamburguesa_Label As Label
    Friend WithEvents _Papas_TextBox As TextBox
    Friend WithEvents _refrescos_TextBox As TextBox
    Friend WithEvents _Gaseosa_TextBox As TextBox
    Friend WithEvents _Sandwich_TextBox As TextBox
    Friend WithEvents _HotDog_TextBox As TextBox
    Friend WithEvents _Hamburguesa_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents _Total_Title_Label As Label
    Friend WithEvents _TotalCobro_TextBox As TextBox
    Friend WithEvents _Total_Button As Button
    Friend WithEvents _Limpiar_Button As Button
    Friend WithEvents _Exit_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
