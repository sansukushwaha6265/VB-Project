Public Class Form3

    'Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
    ' Me.Hide()
    '  Dim cal As New Form4()
    '   cal.Show()
    'End Sub

    'Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    ' Me.Hide()
    '  Dim bmi As New Form5()
    '   bmi.Show()
    'End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Dim bmi As New Form5()
        bmi.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Dim cal As New Form4()
        cal.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Dim diet As New Form6()
        diet.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class