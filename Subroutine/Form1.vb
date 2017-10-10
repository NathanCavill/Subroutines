Public Class Form1

    Dim number1 As Integer
    Dim number2 As Integer
    Dim result As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        number1 = CInt(TextBox1.Text)
        number2 = CInt(TextBox2.Text)

        AddNumbers()

        TextBox3.Text = result
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        number1 = CInt(TextBox1.Text)
        number2 = CInt(TextBox2.Text)

        SubtractNumbers()

        TextBox3.Text = result

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        number1 = CInt(TextBox1.Text)
        number2 = CInt(TextBox2.Text)

        MultiplyNumbers()

        TextBox3.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        number1 = CInt(TextBox1.Text)
        number2 = CInt(TextBox2.Text)

        DivideNumbers()

        TextBox3.Text = result
    End Sub

    Private Sub AddNumbers()
        result = number1 + number2

    End Sub

    Private Sub SubtractNumbers()
        result = number1 - number2
    End Sub

    Private Sub MultiplyNumbers()
        result = number1 * number2

    End Sub

    Private Sub DivideNumbers()
        result = number1 / number2

    End Sub

End Class
