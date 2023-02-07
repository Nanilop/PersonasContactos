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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labRFC = New System.Windows.Forms.Label()
        Me.adverPater = New System.Windows.Forms.Label()
        Me.adverTele = New System.Windows.Forms.Label()
        Me.adverFecha = New System.Windows.Forms.Label()
        Me.adverMat = New System.Windows.Forms.Label()
        Me.adverNombre = New System.Windows.Forms.Label()
        Me.adverEmail = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMater = New System.Windows.Forms.TextBox()
        Me.txtPater = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(16, 367)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 29)
        Me.btnLimpiar.TabIndex = 0
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(307, 371)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 29)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Calculadora de RFC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese sus nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese su Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese su Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ingrese su Fecha de Nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Ingrese su Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ingrese su número de teléfono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tu RFC es:"
        '
        'labRFC
        '
        Me.labRFC.AutoSize = True
        Me.labRFC.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRFC.Location = New System.Drawing.Point(164, 318)
        Me.labRFC.Name = "labRFC"
        Me.labRFC.Size = New System.Drawing.Size(203, 36)
        Me.labRFC.TabIndex = 10
        Me.labRFC.Text = "XXXX000000"
        Me.labRFC.Visible = False
        '
        'adverPater
        '
        Me.adverPater.AutoSize = True
        Me.adverPater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adverPater.ForeColor = System.Drawing.Color.Red
        Me.adverPater.Location = New System.Drawing.Point(218, 120)
        Me.adverPater.Name = "adverPater"
        Me.adverPater.Size = New System.Drawing.Size(162, 15)
        Me.adverPater.TabIndex = 11
        Me.adverPater.Text = "*Ingrese su Apellido Paterno"
        Me.adverPater.Visible = False
        '
        'adverTele
        '
        Me.adverTele.AutoSize = True
        Me.adverTele.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adverTele.ForeColor = System.Drawing.Color.Red
        Me.adverTele.Location = New System.Drawing.Point(167, 303)
        Me.adverTele.Name = "adverTele"
        Me.adverTele.Size = New System.Drawing.Size(215, 15)
        Me.adverTele.TabIndex = 12
        Me.adverTele.Text = "*Ingrese un número de télefono valido"
        Me.adverTele.Visible = False
        '
        'adverFecha
        '
        Me.adverFecha.AutoSize = True
        Me.adverFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adverFecha.ForeColor = System.Drawing.Color.Red
        Me.adverFecha.Location = New System.Drawing.Point(117, 210)
        Me.adverFecha.Name = "adverFecha"
        Me.adverFecha.Size = New System.Drawing.Size(266, 15)
        Me.adverFecha.TabIndex = 13
        Me.adverFecha.Text = "*Debes ser mayor de edad para tramitar tu RFC"
        Me.adverFecha.Visible = False
        '
        'adverMat
        '
        Me.adverMat.AutoSize = True
        Me.adverMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adverMat.ForeColor = System.Drawing.Color.Red
        Me.adverMat.Location = New System.Drawing.Point(218, 165)
        Me.adverMat.Name = "adverMat"
        Me.adverMat.Size = New System.Drawing.Size(165, 15)
        Me.adverMat.TabIndex = 14
        Me.adverMat.Text = "*Ingrese su Apellido Materno"
        Me.adverMat.Visible = False
        '
        'adverNombre
        '
        Me.adverNombre.AutoSize = True
        Me.adverNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adverNombre.ForeColor = System.Drawing.Color.Red
        Me.adverNombre.Location = New System.Drawing.Point(265, 70)
        Me.adverNombre.Name = "adverNombre"
        Me.adverNombre.Size = New System.Drawing.Size(117, 15)
        Me.adverNombre.TabIndex = 15
        Me.adverNombre.Text = "*Ingrese su Nombre"
        Me.adverNombre.Visible = False
        '
        'adverEmail
        '
        Me.adverEmail.AutoSize = True
        Me.adverEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adverEmail.ForeColor = System.Drawing.Color.Red
        Me.adverEmail.Location = New System.Drawing.Point(237, 257)
        Me.adverEmail.Name = "adverEmail"
        Me.adverEmail.Size = New System.Drawing.Size(143, 15)
        Me.adverEmail.TabIndex = 16
        Me.adverEmail.Text = "*Ingrese un correo valido"
        Me.adverEmail.Visible = False
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha.Location = New System.Drawing.Point(263, 183)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(119, 29)
        Me.Fecha.TabIndex = 17
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(257, 275)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(123, 29)
        Me.txtTel.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(154, 228)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 29)
        Me.txtEmail.TabIndex = 19
        '
        'txtMater
        '
        Me.txtMater.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMater.Location = New System.Drawing.Point(237, 136)
        Me.txtMater.Name = "txtMater"
        Me.txtMater.Size = New System.Drawing.Size(143, 29)
        Me.txtMater.TabIndex = 20
        '
        'txtPater
        '
        Me.txtPater.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPater.Location = New System.Drawing.Point(237, 88)
        Me.txtPater.Name = "txtPater"
        Me.txtPater.Size = New System.Drawing.Size(143, 29)
        Me.txtPater.TabIndex = 21
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(186, 41)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(196, 29)
        Me.txtNombre.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 410)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPater)
        Me.Controls.Add(Me.txtMater)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.adverEmail)
        Me.Controls.Add(Me.adverNombre)
        Me.Controls.Add(Me.adverMat)
        Me.Controls.Add(Me.adverFecha)
        Me.Controls.Add(Me.adverTele)
        Me.Controls.Add(Me.adverPater)
        Me.Controls.Add(Me.labRFC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "RFC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents labRFC As Label
    Friend WithEvents adverPater As Label
    Friend WithEvents adverTele As Label
    Friend WithEvents adverFecha As Label
    Friend WithEvents adverMat As Label
    Friend WithEvents adverNombre As Label
    Friend WithEvents adverEmail As Label
    Friend WithEvents Fecha As DateTimePicker
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMater As TextBox
    Friend WithEvents txtPater As TextBox
    Friend WithEvents txtNombre As TextBox
End Class
