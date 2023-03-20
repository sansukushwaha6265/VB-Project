Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim first_name As String = TextBox1.Text
        Dim last_name As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim username As String = TextBox4.Text
        Dim password As String = TextBox5.Text
        Dim conn As New MY_CONNECTION()
        Dim command As New MySqlCommand("INSERT INTO `tbl_accounts`(`first_name`, `last_name`, `email`, `username`, `password`) VALUES (@fname, @lname, @mail, @usn, @pass)", conn.getConnection)
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = first_name
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = last_name
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password
        conn.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.closeConnection()
        Else

            MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.closeConnection()

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Dim lForm As New Form2()
        lForm.Show()
    End Sub
End Class
