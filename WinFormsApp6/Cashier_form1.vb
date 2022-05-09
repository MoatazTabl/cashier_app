Imports System.Data.SqlClient
Public Class Cashier_form1
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter

    Dim ds As DataSet
    Private Sub Cashier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")
        conn.Open()
        da = New SqlDataAdapter("select * from products1", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "products1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dr As DataRow = ds.Tables("products1").NewRow()

        dr("id") = Val(Id.Text)
        dr("nameofproduct") = Val(text_box.Text)
        dr("quantity") = Val(quantity.Text)
        dr("price") = Val(Price.Text)
        dr("selling price") = Val(selling_price.Text)
        ds.Tables("products1").Rows.Add(dr)
        da.Update(ds, "products1")
    End Sub


End Class
