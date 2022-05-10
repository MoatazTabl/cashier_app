Imports System.Data.SqlClient
Public Class Form3
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim dt As DataTable



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'making connection to the database
        conn = New SqlConnection("Data Source=localhost;Initial Catalog=MedicalHouse;Integrated Security=True")
        'openning it
        conn.Open()
        'if data base is not open it shows a warnning that Data base not found
        If conn.State = ConnectionState.Closed Then
            MessageBox.Show("Data base not found", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        cmd = New SqlCommand("select * from employees where user_name='" & User_text_box.Text & "'and password='" & Pass_text_box.Text & "'and role='" & cbuser_type.SelectedItem & "'", conn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You are logged as " + dt.Rows(0)(4), "Sucess")
            If (cbuser_type.SelectedIndex = 0) Then
                Dim a As New Form4
                a.Show()
                Me.Hide()
            Else
                Dim u As New Cashierform
                u.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Check your user name or pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class

