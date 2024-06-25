
Public Class Form1

    Sub RealizarOperacion(op As String)
        Dim numero1 As Integer
        Dim numero2 As Integer

        If Not Integer.TryParse(TXT_numero1.Text, numero1) OrElse Not Integer.TryParse(TXT_numero2.Text, numero2) Then
            MessageBox.Show("Ingrese valores numéricos válidos")
            Return
        End If

        Dim resultado As Integer

        Select Case op
            Case "+"
                resultado = numero1 + numero2
            Case "-"
                resultado = numero1 - numero2
            Case "*"
                resultado = numero1 * numero2
            Case "/"
                If numero2 = 0 Then
                    MessageBox.Show("No se puede dividir por cero")
                    Return
                End If
                resultado = numero1 / numero2
            Case Else
                MessageBox.Show("Operación no válida")
                Return
        End Select

        txt_resultado.Text = resultado.ToString
    End Sub
    Private Sub BTN_suma_Click(sender As Object, e As EventArgs) Handles BTN_suma.Click
        RealizarOperacion("+")
    End Sub

    Private Sub btn_resta_Click(sender As Object, e As EventArgs) Handles btn_resta.Click
        RealizarOperacion("-")
    End Sub

    Private Sub btn_multiplcacion_Click(sender As Object, e As EventArgs) Handles btn_multiplcacion.Click

        RealizarOperacion("*")
    End Sub

    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        RealizarOperacion("/")
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txt_resultado.Text <> "" Then
            btn_salir.Visible = True
        Else
            btn_salir.Visible = False
        End If
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        TXT_numero1.Text = ""
        TXT_numero2.Text = ""
        txt_resultado.Text = ""
        btn_salir.Visible = False
    End Sub

    Private Sub txt_resultado_TextChanged(sender As Object, e As EventArgs) Handles txt_resultado.TextChanged
        btn_salir.Visible = txt_resultado.Text <> ""
    End Sub
End Class
