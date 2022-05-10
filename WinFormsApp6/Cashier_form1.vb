Imports System.Data.SqlClient
Public Class Cashierform
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim reader As SqlDataReader

    Dim ds As DataSet
    Private Sub Cashier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")
        conn.Open()
        da = New SqlDataAdapter("select * from products1", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "products1")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles insert_button.Click
        Dim dr As DataRow = ds.Tables("products1").NewRow()

        dr("id") = Val(Id.Text)
        dr("name") = text_box.Text
        dr("quantity") = Val(quantity.Text)
        dr("price") = Val(Price.Text)
        dr("selling price") = Val(selling_price.Text)
        ds.Tables("products1").Rows.Add(dr)
        da.Update(ds, "products1")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles disply_button.Click
        Try
            If Id.TextLength > 0 Then
                cmd = New SqlCommand("select * from products1 where id=" & Val(Id.Text), conn)
                reader = cmd.ExecuteReader()
                reader.Read()
                text_box.Text = reader(1)
                quantity.Text = reader(2)
                Price.Text = reader(3)
                selling_price.Text = reader(4)
            Else
                DataGridView1.DataBindings.Add("datasource", ds, "products1")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
