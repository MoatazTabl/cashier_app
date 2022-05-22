<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashierform
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
        Me.delete_button = New System.Windows.Forms.Button()
        Me.insert_button = New System.Windows.Forms.Button()
        Me.disply_button = New System.Windows.Forms.Button()
        Me.edit_button = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.text_box = New System.Windows.Forms.TextBox()
        Me.selling_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bk_button = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'delete_button
        '
        Me.delete_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.delete_button.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.delete_button.ForeColor = System.Drawing.Color.Red
        Me.delete_button.Location = New System.Drawing.Point(102, 461)
        Me.delete_button.Name = "delete_button"
        Me.delete_button.Size = New System.Drawing.Size(136, 72)
        Me.delete_button.TabIndex = 0
        Me.delete_button.TabStop = False
        Me.delete_button.Text = "حذف"
        Me.delete_button.UseVisualStyleBackColor = False
        '
        'insert_button
        '
        Me.insert_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.insert_button.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.insert_button.Location = New System.Drawing.Point(284, 461)
        Me.insert_button.Name = "insert_button"
        Me.insert_button.Size = New System.Drawing.Size(136, 72)
        Me.insert_button.TabIndex = 1
        Me.insert_button.TabStop = False
        Me.insert_button.Text = "اضافة"
        Me.insert_button.UseVisualStyleBackColor = False
        '
        'disply_button
        '
        Me.disply_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.disply_button.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.disply_button.Location = New System.Drawing.Point(497, 461)
        Me.disply_button.Name = "disply_button"
        Me.disply_button.Size = New System.Drawing.Size(136, 72)
        Me.disply_button.TabIndex = 3
        Me.disply_button.TabStop = False
        Me.disply_button.Text = "عرض الصنف"
        Me.disply_button.UseVisualStyleBackColor = False
        '
        'edit_button
        '
        Me.edit_button.BackColor = System.Drawing.Color.LavenderBlush
        Me.edit_button.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.edit_button.Location = New System.Drawing.Point(674, 461)
        Me.edit_button.Name = "edit_button"
        Me.edit_button.Size = New System.Drawing.Size(136, 72)
        Me.edit_button.TabIndex = 4
        Me.edit_button.TabStop = False
        Me.edit_button.Text = "تعديل"
        Me.edit_button.UseVisualStyleBackColor = False
        '
        'Id
        '
        Me.Id.BackColor = System.Drawing.Color.LavenderBlush
        Me.Id.Location = New System.Drawing.Point(130, 54)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(183, 20)
        Me.Id.TabIndex = 0
        '
        'quantity
        '
        Me.quantity.BackColor = System.Drawing.Color.LavenderBlush
        Me.quantity.Location = New System.Drawing.Point(130, 115)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(183, 20)
        Me.quantity.TabIndex = 2
        '
        'Price
        '
        Me.Price.BackColor = System.Drawing.Color.LavenderBlush
        Me.Price.Location = New System.Drawing.Point(130, 170)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(183, 20)
        Me.Price.TabIndex = 4
        '
        'text_box
        '
        Me.text_box.BackColor = System.Drawing.Color.LavenderBlush
        Me.text_box.Location = New System.Drawing.Point(562, 54)
        Me.text_box.Name = "text_box"
        Me.text_box.Size = New System.Drawing.Size(183, 20)
        Me.text_box.TabIndex = 1
        '
        'selling_price
        '
        Me.selling_price.BackColor = System.Drawing.Color.LavenderBlush
        Me.selling_price.Location = New System.Drawing.Point(562, 115)
        Me.selling_price.Name = "selling_price"
        Me.selling_price.Size = New System.Drawing.Size(183, 20)
        Me.selling_price.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "رقم الصنف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(56, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "الوحدة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(62, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "السعر"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(476, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "اسم الصنف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(476, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 26)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "سعر البيع"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(152, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(548, 189)
        Me.DataGridView1.TabIndex = 17
        Me.DataGridView1.TabStop = False
        '
        'bk_button
        '
        Me.bk_button.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bk_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bk_button.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bk_button.Location = New System.Drawing.Point(10, 515)
        Me.bk_button.Name = "bk_button"
        Me.bk_button.Size = New System.Drawing.Size(86, 34)
        Me.bk_button.TabIndex = 18
        Me.bk_button.Text = "Back"
        Me.bk_button.UseVisualStyleBackColor = False
        '
        'Cashierform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.bk_button)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selling_price)
        Me.Controls.Add(Me.text_box)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.edit_button)
        Me.Controls.Add(Me.disply_button)
        Me.Controls.Add(Me.insert_button)
        Me.Controls.Add(Me.delete_button)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Cashierform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents delete_button As Button
    Friend WithEvents insert_button As Button
    Friend WithEvents disply_button As Button
    Friend WithEvents edit_button As Button
    Friend WithEvents Id As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents Price As TextBox

    Friend WithEvents selling_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Name1 As TextBox
    Friend WithEvents text_box As TextBox
    Friend WithEvents bk_button As Button
End Class
