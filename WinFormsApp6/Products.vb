Imports System.Data.SqlClient
Public Class Products
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter

    Dim table As DataTable

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")

        conn.Open()
        da = New SqlDataAdapter("select * from Products1", conn)
        table = New DataTable()

        da.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim m As New Form2
        m.Show()
        Me.Hide()
    End Sub

    Private Sub bk_button_Click(sender As Object, e As EventArgs) Handles bk_button.Click
        Dim m As New Form2
        m.Show()
        Me.Hide()
    End Sub
End Class