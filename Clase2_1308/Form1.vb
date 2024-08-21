Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim t1 As String
        t1 = txt1.Text

        MsgBox("HOLA: " & t1)

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        Dim num1, num2, resultado As Integer
        num1 = Integer.Parse(txtnum1.Text)
        num2 = Integer.Parse(txtnum2.Text)


        Dim operacion As String = cbx1.SelectedItem.ToString()

        Select Case operacion
            Case "SUMA"
                resultado = num1 + num2
            Case "RESTA"
                resultado = num1 - num2
            Case "MULTIPLICACION"
                resultado = num1 * num2
            Case "DIVIDIR"
                ' Verificar que num2 no sea 0 para evitar división por cero
                If num2 <> 0 Then
                    resultado = num1 / num2
                Else
                    MessageBox.Show("No se puede dividir entre cero.")
                    Exit Sub
                End If

        End Select

        txtResultado.Text = resultado.ToString()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        cbx1.Items.Add("SELECCIONE UNA OPERACION")
        cbx1.Items.Add("SUMA")
        cbx1.Items.Add("RESTA")
        cbx1.Items.Add("MULTIPLICACION")
        cbx1.Items.Add("DIVIDIR")

        cbx1.SelectedIndex = 0
    End Sub

End Class
