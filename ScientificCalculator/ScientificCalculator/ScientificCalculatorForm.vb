Public Class Calculator

    Dim fieldClear As Boolean = True

    Private Sub showNum(NewValue As String)
        If fieldClear = True Then TextBox1.Text = ""
        TextBox1.Text &= NewValue
        fieldClear = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub display_textbox(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click, Button22.Click

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub display2_textbox(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonZERO_Click(sender As Object, e As EventArgs) Handles Button45.Click
        showNum("0")
    End Sub

    Private Sub ButtonONE_Click(sender As Object, e As EventArgs) Handles Button39.Click
        showNum("1")
    End Sub

    Private Sub ButtonTWO_Click(sender As Object, e As EventArgs) Handles Button40.Click
        showNum("2")
    End Sub

    Private Sub ButtonTHREE_Click(sender As Object, e As EventArgs) Handles Button41.Click
        showNum("3")
    End Sub

    Private Sub ButtonFOUR_Click(sender As Object, e As EventArgs) Handles Button34.Click
        showNum("4")
    End Sub

    Private Sub ButtonFIVE_Click(sender As Object, e As EventArgs) Handles Button35.Click
        showNum("5")
    End Sub

    Private Sub ButtonSIX_Click(sender As Object, e As EventArgs) Handles Button36.Click
        showNum("6")
    End Sub

    Private Sub ButtonSEVEN_Click(sender As Object, e As EventArgs) Handles Button29.Click
        showNum("7")
    End Sub

    Private Sub ButtonEIGHT_Click(sender As Object, e As EventArgs) Handles Button30.Click
        showNum("8")
    End Sub

    Private Sub ButtonNINE_Click(sender As Object, e As EventArgs) Handles Button31.Click
        showNum("9")
    End Sub
End Class
