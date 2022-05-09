<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.products_prices = New System.Windows.Forms.Button()
        Me.Employees = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(311, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الصفحة الرئيسية"
        '
        'products_prices
        '
        Me.products_prices.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.products_prices.Font = New System.Drawing.Font("Arabic Typesetting", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.products_prices.Location = New System.Drawing.Point(62, 255)
        Me.products_prices.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.products_prices.Name = "products_prices"
        Me.products_prices.Size = New System.Drawing.Size(184, 67)
        Me.products_prices.TabIndex = 1
        Me.products_prices.Text = "المنتجات و الاسعار"
        Me.products_prices.UseVisualStyleBackColor = False
        '
        'Employees
        '
        Me.Employees.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Employees.Font = New System.Drawing.Font("Arabic Typesetting", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Employees.Location = New System.Drawing.Point(521, 255)
        Me.Employees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Employees.Name = "Employees"
        Me.Employees.Size = New System.Drawing.Size(180, 67)
        Me.Employees.TabIndex = 2
        Me.Employees.Text = "الموظفين"
        Me.Employees.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Employees)
        Me.Controls.Add(Me.products_prices)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents products_prices As Button
    Friend WithEvents Employees As Button
End Class
