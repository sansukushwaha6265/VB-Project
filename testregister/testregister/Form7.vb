Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub Populate()
        Dim conn As New MY_CONNECTION()
        Dim command As MySqlCommand
        Dim SDA As New MySqlDataAdapter()
        Dim dbDataSet As New DataTable()
        Dim bSource As New BindingSource()
        Try
            conn.openConnection()
            Dim Query As String
            Query = "Select * from sample.veggain"
            command = New MySqlCommand(Query, conn.getConnection())
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            conn.closeConnection()
        Catch ex As Exception

        Finally
            conn.getConnection().Dispose()


        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim veggain As New Form6()
        veggain.Show()
    End Sub
End Class