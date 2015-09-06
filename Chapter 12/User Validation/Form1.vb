Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MaskedTextBox1.Text = "219-09-9999" _
        And MaskedTextBox2.Text = "54321" Then
            MsgBox("Welcome to the system!")
        Else
            MsgBox("I don't recognize this number")
        End If

    End Sub
End Class
