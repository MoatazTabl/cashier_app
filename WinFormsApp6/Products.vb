Imports System.Data.SqlClient
Public Class Products
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim table As DataTable

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")

        conn.Open()
        da = New SqlDataAdapter("select * from Products1", conn)
        table = New DataTable()

        da.Fill(table)

        DataGridView1.DataSource = table

    End Sub


End Class