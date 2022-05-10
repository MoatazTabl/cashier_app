<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Id_text_box = New System.Windows.Forms.TextBox()
        Me.Salray_text_box = New System.Windows.Forms.TextBox()
        Me.Employee_name_Text_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.Add_button = New System.Windows.Forms.Button()
        Me.Edit_button = New System.Windows.Forms.Button()
        Me.role_type_cb = New System.Windows.Forms.ComboBox()
        Me.employee_data = New System.Windows.Forms.DataGridView()
        CType(Me.employee_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_text_box
        '
        Me.Id_text_box.BackColor = System.Drawing.Color.LavenderBlush
        Me.Id_text_box.Location = New System.Drawing.Point(542, 118)
        Me.Id_text_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Id_text_box.Name = "Id_text_box"
        Me.Id_text_box.Size = New System.Drawing.Size(168, 23)
        Me.Id_text_box.TabIndex = 3
        '
        'Salray_text_box
        '
        Me.Salray_text_box.BackColor = System.Drawing.Color.LavenderBlush
        Me.Salray_text_box.Location = New System.Drawing.Point(142, 118)
        Me.Salray_text_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Salray_text_box.Name = "Salray_text_box"
        Me.Salray_text_box.Size = New System.Drawing.Size(168, 23)
        Me.Salray_text_box.TabIndex = 2
        '
        'Employee_name_Text_box
        '
        Me.Employee_name_Text_box.BackColor = System.Drawing.Color.LavenderBlush
        Me.Employee_name_Text_box.Location = New System.Drawing.Point(142, 46)
        Me.Employee_name_Text_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Employee_name_Text_box.Name = "Employee_name_Text_box"
        Me.Employee_name_Text_box.Size = New System.Drawing.Size(168, 23)
        Me.Employee_name_Text_box.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(40, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "اسم الموظف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(453, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "المنصب"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(71, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "المرتب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(434, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "الرقم التعريفي"
        '
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.Delete_button.Font = New System.Drawing.Font("Arabic Typesetting", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Delete_button.ForeColor = System.Drawing.Color.Red
        Me.Delete_button.Location = New System.Drawing.Point(57, 427)
        Me.Delete_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(127, 56)
        Me.Delete_button.TabIndex = 9
        Me.Delete_button.TabStop = False
        Me.Delete_button.Text = "حذف"
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'Add_button
        '
        Me.Add_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.Add_button.Font = New System.Drawing.Font("Arabic Typesetting", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Add_button.Location = New System.Drawing.Point(337, 427)
        Me.Add_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(127, 56)
        Me.Add_button.TabIndex = 10
        Me.Add_button.TabStop = False
        Me.Add_button.Text = "اضافة"
        Me.Add_button.UseVisualStyleBackColor = False
        '
        'Edit_button
        '
        Me.Edit_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.Edit_button.Font = New System.Drawing.Font("Arabic Typesetting", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Edit_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Edit_button.Location = New System.Drawing.Point(602, 429)
        Me.Edit_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_button.Name = "Edit_button"
        Me.Edit_button.Size = New System.Drawing.Size(127, 56)
        Me.Edit_button.TabIndex = 13
        Me.Edit_button.TabStop = False
        Me.Edit_button.Text = "تعديل"
        Me.Edit_button.UseVisualStyleBackColor = False
        '
        'role_type_cb
        '
        Me.role_type_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.role_type_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.role_type_cb.BackColor = System.Drawing.Color.LavenderBlush
        Me.role_type_cb.FormattingEnabled = True
        Me.role_type_cb.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.role_type_cb.Location = New System.Drawing.Point(542, 47)
        Me.role_type_cb.Name = "role_type_cb"
        Me.role_type_cb.Size = New System.Drawing.Size(168, 23)
        Me.role_type_cb.TabIndex = 1
        '
        'employee_data
        '
        Me.employee_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employee_data.Location = New System.Drawing.Point(86, 211)
        Me.employee_data.Name = "employee_data"
        Me.employee_data.RowTemplate.Height = 25
        Me.employee_data.Size = New System.Drawing.Size(591, 150)
        Me.employee_data.TabIndex = 14
        Me.employee_data.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 485)
        Me.Controls.Add(Me.role_type_cb)
        Me.Controls.Add(Me.employee_data)
        Me.Controls.Add(Me.Edit_button)
        Me.Controls.Add(Me.Add_button)
        Me.Controls.Add(Me.Delete_button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Employee_name_Text_box)
        Me.Controls.Add(Me.Salray_text_box)
        Me.Controls.Add(Me.Id_text_box)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Page"
        CType(Me.employee_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Id_text_box As TextBox
    Friend WithEvents Salray_text_box As TextBox
    Friend WithEvents Employee_name_Text_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Delete_button As Button
    Friend WithEvents Add_button As Button
    Friend WithEvents Edit_button As Button
    Friend WithEvents role_type_cb As ComboBox
    Friend WithEvents employee_data As DataGridView
End Class
