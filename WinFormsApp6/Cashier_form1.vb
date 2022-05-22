Imports System.Data.SqlClient
Public Class Cashierform
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dr As DataRow
    Dim ds As DataSet
    Dim cb As SqlCommandBuilder

    Public Function Clear1()
        Id.Clear()
        text_box.Clear()
        quantity.Clear()
        Price.Clear()
        selling_price.Clear()
    End Function
    Private Sub Cashier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")
        conn.Open()
        da = New SqlDataAdapter("select * from products1", conn)
        cb = New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "products1")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles insert_button.Click
        dr = ds.Tables("products1").NewRow()

        dr("id") = Val(Id.Text)
        dr("name") = text_box.Text
        dr("quantity") = Val(quantity.Text)
        dr("price") = Val(Price.Text)
        dr("selling price") = Val(selling_price.Text)
        ds.Tables("products1").Rows.Add(dr)
        da.Update(ds, "products1")
        MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear1()

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
                conn.Close()
            Else
                DataGridView1.DataBindings.Clear()
                DataGridView1.DataBindings.Add("datasource", ds, "products1")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim answer As Integer
        Dim dr As DataRow = Nothing
        For Each dr In ds.Tables("products1").Rows
            If dr("id") = Val(Id.Text) Then
                text_box.Text = dr("name")
                quantity.Text = dr("quantity")
                Price.Text = dr("price")
                selling_price.Text = dr("selling price")
                Exit For
            End If
        Next
        answer = MessageBox.Show(
            "are you sure you want to delete this record?", "Warrnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If answer = System.Windows.Forms.DialogResult.No Then Exit Sub
        dr.Delete()
        da.Update(ds, "products1")

    End Sub

    Private Sub edit_button_Click(sender As Object, e As EventArgs) Handles edit_button.Click
        Dim dr As DataRow = Nothing
        For Each dr In ds.Tables("products1").Rows
            If dr("id") = Val(Id.Text) Then
                dr("name") = text_box.Text
                dr("quantity") = Val(quantity.Text)
                dr("price") = Val(Price.Text)
                dr("selling price") = Val(selling_price.Text)
                Exit For
            End If
        Next
        MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear1()

        da.Update(ds, "products1")
    End Sub

    Private Sub bk_button_Click(sender As Object, e As EventArgs) Handles bk_button.Click
        Dim m As New Form3
        m.Show()
        Me.Hide()

    End Sub
End Class
