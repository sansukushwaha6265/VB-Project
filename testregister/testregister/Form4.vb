Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Integer = TextBox1.Text
        Dim f As Integer = TextBox2.Text
        Dim p As Integer = TextBox3.Text
        Dim calories As Double = (c * 4) + (f * 9) + (p * 4)
        Dim msg As String = "This serving contains " & calories & " calories"
        Label4.Text = msg
        Label4.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim vegloss As New Form3()
        vegloss.Show()
    End Sub
End Class