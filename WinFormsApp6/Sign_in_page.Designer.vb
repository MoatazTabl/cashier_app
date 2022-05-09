<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pass_text_box = New System.Windows.Forms.TextBox()
        Me.User_text_box = New System.Windows.Forms.TextBox()
        Me.User_name_label = New System.Windows.Forms.Label()
        Me.Password_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Login_button = New System.Windows.Forms.Button()
        Me.cbuser_type = New System.Windows.Forms.ComboBox()
        Me.Role_button = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(418, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(363, 373)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(10, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 165)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "welcome to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the medical house" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "company system"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pass_text_box
        '
        Me.Pass_text_box.Location = New System.Drawing.Point(564, 259)
        Me.Pass_text_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pass_text_box.Name = "Pass_text_box"
        Me.Pass_text_box.Size = New System.Drawing.Size(188, 23)
        Me.Pass_text_box.TabIndex = 1
        Me.Pass_text_box.UseSystemPasswordChar = True
        '
        'User_text_box
        '
        Me.User_text_box.Location = New System.Drawing.Point(564, 217)
        Me.User_text_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.User_text_box.Name = "User_text_box"
        Me.User_text_box.Size = New System.Drawing.Size(188, 23)
        Me.User_text_box.TabIndex = 0
        '
        'User_name_label
        '
        Me.User_name_label.AutoSize = True
        Me.User_name_label.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.User_name_label.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_name_label.ForeColor = System.Drawing.Color.Navy
        Me.User_name_label.Location = New System.Drawing.Point(436, 212)
        Me.User_name_label.Name = "User_name_label"
        Me.User_name_label.Size = New System.Drawing.Size(111, 25)
        Me.User_name_label.TabIndex = 4
        Me.User_name_label.Text = "User name"
        '
        'Password_label
        '
        Me.Password_label.AutoSize = True
        Me.Password_label.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Password_label.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Password_label.ForeColor = System.Drawing.Color.Navy
        Me.Password_label.Location = New System.Drawing.Point(441, 259)
        Me.Password_label.Name = "Password_label"
        Me.Password_label.Size = New System.Drawing.Size(100, 25)
        Me.Password_label.TabIndex = 5
        Me.Password_label.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.WinFormsApp6.My.Resources.Resources.The__6_
        Me.PictureBox1.InitialImage = Global.WinFormsApp6.My.Resources.Resources.The__6_
        Me.PictureBox1.Location = New System.Drawing.Point(501, 45)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Login_button
        '
        Me.Login_button.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Login_button.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Login_button.Location = New System.Drawing.Point(599, 341)
        Me.Login_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(108, 34)
        Me.Login_button.TabIndex = 8
        Me.Login_button.Text = "Login"
        Me.Login_button.UseVisualStyleBackColor = False
        '
        'cbuser_type
        '
        Me.cbuser_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbuser_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbuser_type.FormattingEnabled = True
        Me.cbuser_type.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.cbuser_type.Location = New System.Drawing.Point(564, 301)
        Me.cbuser_type.Name = "cbuser_type"
        Me.cbuser_type.Size = New System.Drawing.Size(188, 23)
        Me.cbuser_type.TabIndex = 2
        '
        'Role_button
        '
        Me.Role_button.AutoSize = True
        Me.Role_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Role_button.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Role_button.ForeColor = System.Drawing.Color.Navy
        Me.Role_button.Location = New System.Drawing.Point(441, 299)
        Me.Role_button.Name = "Role_button"
        Me.Role_button.Size = New System.Drawing.Size(53, 25)
        Me.Role_button.TabIndex = 10
        Me.Role_button.Text = "Role"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WinFormsApp6.My.Resources.Resources.imageedit_4_6475057521
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Role_button)
        Me.Controls.Add(Me.cbuser_type)
        Me.Controls.Add(Me.Login_button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Password_label)
        Me.Controls.Add(Me.User_name_label)
        Me.Controls.Add(Me.User_text_box)
        Me.Controls.Add(Me.Pass_text_box)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Pass_text_box As TextBox
    Friend WithEvents User_text_box As TextBox
    Friend WithEvents User_name_label As Label
    Friend WithEvents Password_label As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Login_button As Button
    Friend WithEvents cbuser_type As ComboBox
    Friend WithEvents Role_button As Label
End Class
