Imports System.Data.SqlClient
Public Class Form4
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dr As DataRow
    Dim ds As DataSet
    Dim cb As SqlCommandBuilder
    Dim cmd As SqlCommand
    Dim reader As SqlDataReader

    Public Function Clear1()
        Employee_name_Text_box.Clear()
        Salray_text_box.Clear()
        Id_text_box.Clear()
        age_text_box.Clear()
        address_text_box.Clear()
        user_name_text_box.Clear()
        password_text_box.Clear()
        role_type_cb.SelectedIndex = -1
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")
        conn.Open()
        da = New SqlDataAdapter("select * from employees", conn)
        cb = New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "employees")
    End Sub

    Private Sub Add_button_Click(sender As Object, e As EventArgs) Handles Add_button.Click
        dr = ds.Tables("employees").NewRow
        dr("id") = Val(Id_text_box.Text)
        dr("name") = Employee_name_Text_box.Text
        dr("age") = Val(age_text_box.Text)
        dr("salray") = Val(Salray_text_box.Text)
        dr("role") = role_type_cb.SelectedItem
        dr("address") = address_text_box.Text
        dr("user_name") = user_name_text_box.Text
        dr("password") = password_text_box.Text


        ds.Tables("employees").Rows.Add(dr)
        da.Update(ds, "employees")

        MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear1()

    End Sub

    Private Sub disply_button_Click(sender As Object, e As EventArgs) Handles disply_button.Click
        Try
            If Id_text_box.TextLength > 0 Then
                cmd = New SqlCommand("select * from employees where id=" & Val(Id_text_box.Text), conn)
                Using reader = cmd.ExecuteReader()

                    reader.Read()
                    Employee_name_Text_box.Text = reader(1)
                    age_text_box.Text = reader(2)
                    address_text_box.Text = reader(3)
                    role_type_cb.Text = reader(4)
                    user_name_text_box.Text = reader(5)
                    password_text_box.Text = reader(6)
                    Salray_text_box.Text = reader(7)

                End Using
            Else
                employee_data.DataBindings.Clear()

                employee_data.DataBindings.Add("datasource", ds, "employees")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Edit_button_Click(sender As Object, e As EventArgs) Handles Edit_button.Click
        Dim dr As DataRow = Nothing
        For Each dr In ds.Tables("employees").Rows
            If dr("id") = Val(Id_text_box.Text) Then
                dr("name") = Employee_name_Text_box.Text
                dr("age") = Val(age_text_box.Text)
                dr("address") = address_text_box.Text
                dr("role") = role_type_cb.SelectedItem
                dr("user_name") = user_name_text_box.Text
                dr("password") = password_text_box.Text
                dr("salray") = Salray_text_box.Text
                da.Update(ds, "employees")
                Exit For
            End If
        Next
        MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear1()

        da.Update(ds, "employees")
        employee_data.DataBindings.Clear()
    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        Dim answer As Integer
        Dim dr As DataRow = Nothing
        For Each dr In ds.Tables("employees").Rows
            If dr("id") = Val(Id_text_box.Text) Then
                Employee_name_Text_box.Text = dr("name")
                age_text_box.Text = dr("age")
                address_text_box.Text = dr("address")
                role_type_cb.Text = dr("role")
                user_name_text_box.Text = dr("user_name")
                password_text_box.Text = dr("password")
                Salray_text_box.Text = dr("salray")
                Exit For
            End If
        Next
        answer = MessageBox.Show(
            "are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If answer = System.Windows.Forms.DialogResult.No Then Exit Sub
        dr.Delete()
        da.Update(ds, "employees")
    End Sub

    Private Sub bk_button_Click(sender As Object, e As EventArgs) Handles bk_button.Click
        Dim m As New Form3
        m.Show()
        Me.Hide()
    End Sub
End Class