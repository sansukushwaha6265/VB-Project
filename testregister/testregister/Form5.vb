Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Visible = False
        Label4.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim wVar As Decimal = Decimal.Parse(TextBox1.Text)
        Dim hVar As Decimal = Decimal.Parse(TextBox2.Text)

        Dim bmiVar As Decimal = 0
        bmiVar = wVar / (hVar * hVar)
        Label3.Text = "BMI: " & bmiVar.ToString("##.##")

        If bmiVar < 18.5 Then
            Label4.Text = "Under Weight"
        ElseIf bmiVar >= 18.5 And bmiVar < 25 Then
            Label4.Text = "Normal"
        ElseIf bmiVar >= 25 And bmiVar < 30 Then
            Label4.Text = "Over Weight"
        ElseIf bmiVar >= 30 And bmiVar < 35 Then
            Label4.Text = "Obese Class I"
        ElseIf bmiVar >= 35 And bmiVar < 40 Then
            Label4.Text = "Obese Class II"
        ElseIf bmiVar > 40 Then
            Label4.Text = "Obese Class III"
        End If
        Label3.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Visible = False
        Label4.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim lun As New Form3()
        lun.Show()
    End Sub
End Class