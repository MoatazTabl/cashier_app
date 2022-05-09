Imports System.Data.SqlClient
Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Employees.Click
        Dim sign_in As New Form3
        sign_in.Show()
        Dim home_page As New Form2
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles products_prices.Click
        Dim Products As New Products
        Products.Show()
        Me.Hide()
    End Sub
End Class