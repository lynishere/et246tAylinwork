<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Titulo = New System.Windows.Forms.Label()
        Me.LB_Num2 = New System.Windows.Forms.Label()
        Me.LB_Num1 = New System.Windows.Forms.Label()
        Me.TXT_numero1 = New System.Windows.Forms.TextBox()
        Me.TXT_numero2 = New System.Windows.Forms.TextBox()
        Me.BTN_suma = New System.Windows.Forms.Button()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.btn_multiplcacion = New System.Windows.Forms.Button()
        Me.btn_division = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.pbHeramientas = New System.Windows.Forms.PictureBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        CType(Me.pbHeramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(350, 28)
        Me.Titulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(366, 39)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Practica con calculos"
        '
        'LB_Num2
        '
        Me.LB_Num2.AutoSize = True
        Me.LB_Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Num2.Location = New System.Drawing.Point(407, 217)
        Me.LB_Num2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_Num2.Name = "LB_Num2"
        Me.LB_Num2.Size = New System.Drawing.Size(94, 24)
        Me.LB_Num2.TabIndex = 1
        Me.LB_Num2.Text = "Numero 2"
        '
        'LB_Num1
        '
        Me.LB_Num1.AutoSize = True
        Me.LB_Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Num1.Location = New System.Drawing.Point(407, 149)
        Me.LB_Num1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_Num1.Name = "LB_Num1"
        Me.LB_Num1.Size = New System.Drawing.Size(94, 24)
        Me.LB_Num1.TabIndex = 2
        Me.LB_Num1.Text = "Numero 1"
        '
        'TXT_numero1
        '
        Me.TXT_numero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_numero1.Location = New System.Drawing.Point(529, 149)
        Me.TXT_numero1.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_numero1.Name = "TXT_numero1"
        Me.TXT_numero1.Size = New System.Drawing.Size(148, 29)
        Me.TXT_numero1.TabIndex = 3
        '
        'TXT_numero2
        '
        Me.TXT_numero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_numero2.Location = New System.Drawing.Point(529, 217)
        Me.TXT_numero2.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_numero2.Name = "TXT_numero2"
        Me.TXT_numero2.Size = New System.Drawing.Size(148, 29)
        Me.TXT_numero2.TabIndex = 4
        '
        'BTN_suma
        '
        Me.BTN_suma.AutoSize = True
        Me.BTN_suma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTN_suma.Image = CType(resources.GetObject("BTN_suma.Image"), System.Drawing.Image)
        Me.BTN_suma.Location = New System.Drawing.Point(234, 308)
        Me.BTN_suma.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_suma.Name = "BTN_suma"
        Me.BTN_suma.Size = New System.Drawing.Size(149, 141)
        Me.BTN_suma.TabIndex = 5
        Me.BTN_suma.UseVisualStyleBackColor = True
        '
        'btn_resta
        '
        Me.btn_resta.Image = CType(resources.GetObject("btn_resta.Image"), System.Drawing.Image)
        Me.btn_resta.Location = New System.Drawing.Point(428, 308)
        Me.btn_resta.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(139, 139)
        Me.btn_resta.TabIndex = 6
        Me.btn_resta.UseVisualStyleBackColor = True
        '
        'btn_multiplcacion
        '
        Me.btn_multiplcacion.Image = CType(resources.GetObject("btn_multiplcacion.Image"), System.Drawing.Image)
        Me.btn_multiplcacion.Location = New System.Drawing.Point(610, 313)
        Me.btn_multiplcacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_multiplcacion.Name = "btn_multiplcacion"
        Me.btn_multiplcacion.Size = New System.Drawing.Size(138, 137)
        Me.btn_multiplcacion.TabIndex = 7
        Me.btn_multiplcacion.UseVisualStyleBackColor = True
        '
        'btn_division
        '
        Me.btn_division.Image = CType(resources.GetObject("btn_division.Image"), System.Drawing.Image)
        Me.btn_division.Location = New System.Drawing.Point(787, 315)
        Me.btn_division.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_division.Name = "btn_division"
        Me.btn_division.Size = New System.Drawing.Size(137, 135)
        Me.btn_division.TabIndex = 8
        Me.btn_division.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Image = CType(resources.GetObject("btn_borrar.Image"), System.Drawing.Image)
        Me.btn_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_borrar.Location = New System.Drawing.Point(119, 484)
        Me.btn_borrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_borrar.Size = New System.Drawing.Size(264, 104)
        Me.btn_borrar.TabIndex = 9
        Me.btn_borrar.Text = "BORRAR"
        Me.btn_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Green
        Me.btn_salir.Location = New System.Drawing.Point(903, 492)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(110, 96)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'pbHeramientas
        '
        Me.pbHeramientas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbHeramientas.Image = CType(resources.GetObject("pbHeramientas.Image"), System.Drawing.Image)
        Me.pbHeramientas.Location = New System.Drawing.Point(79, 91)
        Me.pbHeramientas.Margin = New System.Windows.Forms.Padding(4)
        Me.pbHeramientas.Name = "pbHeramientas"
        Me.pbHeramientas.Size = New System.Drawing.Size(220, 186)
        Me.pbHeramientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHeramientas.TabIndex = 11
        Me.pbHeramientas.TabStop = False
        '
        'txt_resultado
        '
        Me.txt_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.Location = New System.Drawing.Point(464, 507)
        Me.txt_resultado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_resultado.Multiline = True
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.ReadOnly = True
        Me.txt_resultado.Size = New System.Drawing.Size(290, 64)
        Me.txt_resultado.TabIndex = 12
        Me.txt_resultado.Text = "Se muestra el resultado"
        Me.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1200, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.pbHeramientas)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_division)
        Me.Controls.Add(Me.btn_multiplcacion)
        Me.Controls.Add(Me.btn_resta)
        Me.Controls.Add(Me.BTN_suma)
        Me.Controls.Add(Me.TXT_numero2)
        Me.Controls.Add(Me.TXT_numero1)
        Me.Controls.Add(Me.LB_Num1)
        Me.Controls.Add(Me.LB_Num2)
        Me.Controls.Add(Me.Titulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Practicamos"
        CType(Me.pbHeramientas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents LB_Num2 As Label
    Friend WithEvents LB_Num1 As Label
    Friend WithEvents TXT_numero1 As TextBox
    Friend WithEvents TXT_numero2 As TextBox
    Friend WithEvents BTN_suma As Button
    Friend WithEvents btn_resta As Button
    Friend WithEvents btn_multiplcacion As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents pbHeramientas As PictureBox
    Friend WithEvents txt_resultado As TextBox
End Class
