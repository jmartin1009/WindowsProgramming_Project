<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminView
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
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnManageIngredients = New System.Windows.Forms.Button()
        Me.btnManageDrinks = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(351, 43)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(532, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers.Location = New System.Drawing.Point(71, 88)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(213, 40)
        Me.btnManageUsers.TabIndex = 1
        Me.btnManageUsers.Text = "Manage Users"
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnManageIngredients
        '
        Me.btnManageIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageIngredients.Location = New System.Drawing.Point(71, 163)
        Me.btnManageIngredients.Name = "btnManageIngredients"
        Me.btnManageIngredients.Size = New System.Drawing.Size(213, 39)
        Me.btnManageIngredients.TabIndex = 2
        Me.btnManageIngredients.Text = "Manage Ingredients"
        Me.btnManageIngredients.UseVisualStyleBackColor = True
        '
        'btnManageDrinks
        '
        Me.btnManageDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageDrinks.Location = New System.Drawing.Point(71, 244)
        Me.btnManageDrinks.Name = "btnManageDrinks"
        Me.btnManageDrinks.Size = New System.Drawing.Size(213, 44)
        Me.btnManageDrinks.TabIndex = 3
        Me.btnManageDrinks.Text = "Manage Drinks"
        Me.btnManageDrinks.UseVisualStyleBackColor = True
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 503)
        Me.Controls.Add(Me.btnManageDrinks)
        Me.Controls.Add(Me.btnManageIngredients)
        Me.Controls.Add(Me.btnManageUsers)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdminView"
        Me.Text = "AdminView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnManageIngredients As Button
    Friend WithEvents btnManageDrinks As Button
End Class
