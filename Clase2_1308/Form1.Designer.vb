<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.cbx1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(309, 76)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(277, 27)
        Me.txt1.TabIndex = 1
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero1.Location = New System.Drawing.Point(80, 207)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(199, 25)
        Me.lblNumero1.TabIndex = 2
        Me.lblNumero1.Text = "Ingrese un numero:"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero2.Location = New System.Drawing.Point(82, 271)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(288, 25)
        Me.lblNumero2.TabIndex = 3
        Me.lblNumero2.Text = "Ingrese un segundo numero:"
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(434, 341)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(125, 46)
        Me.btn2.TabIndex = 6
        Me.btn2.Text = "Calcular"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(413, 216)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(173, 22)
        Me.txtnum1.TabIndex = 7
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(413, 275)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(173, 22)
        Me.txtnum2.TabIndex = 8
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(645, 216)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(105, 81)
        Me.txtResultado.TabIndex = 9
        '
        'cbx1
        '
        Me.cbx1.FormattingEnabled = True
        Me.cbx1.Location = New System.Drawing.Point(85, 354)
        Me.cbx1.Name = "cbx1"
        Me.cbx1.Size = New System.Drawing.Size(285, 24)
        Me.cbx1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 528)
        Me.Controls.Add(Me.cbx1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.lblNumero1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lblNumero1 As Label
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents cbx1 As ComboBox
End Class
