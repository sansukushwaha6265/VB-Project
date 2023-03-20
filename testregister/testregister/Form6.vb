Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If RadioButton1.Checked = True Then
            Me.Hide()
            Dim veg1 As New Form7()
            veg1.Show()
        ElseIf RadioButton2.Checked = True Then
            Me.Hide()
            Dim nonveg1 As New Form8()
            nonveg1.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If RadioButton1.Checked = True Then
            Me.Hide()
            Dim veg2 As New Form9()
            veg2.Show()
        ElseIf RadioButton2.Checked = True Then
            Me.Hide()
            Dim nonveg2 As New Form10()
            nonveg2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim pot As New Form3()
        pot.Show()
    End Sub
End Class