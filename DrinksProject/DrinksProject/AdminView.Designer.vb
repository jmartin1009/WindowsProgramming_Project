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
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbBartender = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rbCustomer = New System.Windows.Forms.RadioButton()
        Me.btnChangeType = New System.Windows.Forms.Button()
        Me.btnAddIngredient = New System.Windows.Forms.Button()
        Me.btnDeleteIngredient = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(352, 44)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(532, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers.Location = New System.Drawing.Point(72, 121)
        Me.btnManageUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(212, 39)
        Me.btnManageUsers.TabIndex = 1
        Me.btnManageUsers.Text = "Manage Users"
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnManageIngredients
        '
        Me.btnManageIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageIngredients.Location = New System.Drawing.Point(72, 217)
        Me.btnManageIngredients.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManageIngredients.Name = "btnManageIngredients"
        Me.btnManageIngredients.Size = New System.Drawing.Size(212, 39)
        Me.btnManageIngredients.TabIndex = 2
        Me.btnManageIngredients.Text = "Manage Ingredients"
        Me.btnManageIngredients.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(352, 377)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(148, 48)
        Me.btnDeleteUser.TabIndex = 4
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmin.Location = New System.Drawing.Point(560, 359)
        Me.rbAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(89, 29)
        Me.rbAdmin.TabIndex = 5
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbBartender
        '
        Me.rbBartender.AutoSize = True
        Me.rbBartender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBartender.Location = New System.Drawing.Point(560, 391)
        Me.rbBartender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbBartender.Name = "rbBartender"
        Me.rbBartender.Size = New System.Drawing.Size(118, 29)
        Me.rbBartender.TabIndex = 6
        Me.rbBartender.TabStop = True
        Me.rbBartender.Text = "Bartender"
        Me.rbBartender.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeMenu, Me.ExitMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeMenu
        '
        Me.HomeMenu.Name = "HomeMenu"
        Me.HomeMenu.Size = New System.Drawing.Size(64, 24)
        Me.HomeMenu.Text = "Home"
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(47, 24)
        Me.ExitMenu.Text = "Exit"
        '
        'rbCustomer
        '
        Me.rbCustomer.AutoSize = True
        Me.rbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomer.Location = New System.Drawing.Point(560, 432)
        Me.rbCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbCustomer.Name = "rbCustomer"
        Me.rbCustomer.Size = New System.Drawing.Size(118, 29)
        Me.rbCustomer.TabIndex = 11
        Me.rbCustomer.TabStop = True
        Me.rbCustomer.Text = "Customer"
        Me.rbCustomer.UseVisualStyleBackColor = True
        '
        'btnChangeType
        '
        Me.btnChangeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeType.Location = New System.Drawing.Point(736, 377)
        Me.btnChangeType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnChangeType.Name = "btnChangeType"
        Me.btnChangeType.Size = New System.Drawing.Size(148, 48)
        Me.btnChangeType.TabIndex = 12
        Me.btnChangeType.Text = "Change Type"
        Me.btnChangeType.UseVisualStyleBackColor = True
        '
        'btnAddIngredient
        '
        Me.btnAddIngredient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddIngredient.Location = New System.Drawing.Point(352, 377)
        Me.btnAddIngredient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddIngredient.Name = "btnAddIngredient"
        Me.btnAddIngredient.Size = New System.Drawing.Size(184, 48)
        Me.btnAddIngredient.TabIndex = 13
        Me.btnAddIngredient.Text = "Add Ingredient"
        Me.btnAddIngredient.UseVisualStyleBackColor = True
        '
        'btnDeleteIngredient
        '
        Me.btnDeleteIngredient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteIngredient.Location = New System.Drawing.Point(700, 377)
        Me.btnDeleteIngredient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteIngredient.Name = "btnDeleteIngredient"
        Me.btnDeleteIngredient.Size = New System.Drawing.Size(184, 48)
        Me.btnDeleteIngredient.TabIndex = 14
        Me.btnDeleteIngredient.Text = "Delete Ingredient"
        Me.btnDeleteIngredient.UseVisualStyleBackColor = True
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 505)
        Me.Controls.Add(Me.btnDeleteIngredient)
        Me.Controls.Add(Me.btnAddIngredient)
        Me.Controls.Add(Me.btnChangeType)
        Me.Controls.Add(Me.rbCustomer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rbBartender)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnManageIngredients)
        Me.Controls.Add(Me.btnManageUsers)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminView"
        Me.Text = "AdminView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnManageIngredients As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbBartender As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeMenu As ToolStripMenuItem
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents rbCustomer As RadioButton
    Friend WithEvents btnChangeType As Button
    Friend WithEvents btnAddIngredient As Button
    Friend WithEvents btnDeleteIngredient As Button
End Class
