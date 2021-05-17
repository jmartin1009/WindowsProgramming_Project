<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BartenderView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnManageInv = New System.Windows.Forms.Button()
        Me.btnManageOrders = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnMakeDrink = New System.Windows.Forms.Button()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(263, 35)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(399, 240)
        Me.DataGridView1.TabIndex = 0
        '
        'btnManageInv
        '
        Me.btnManageInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageInv.Location = New System.Drawing.Point(53, 97)
        Me.btnManageInv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnManageInv.Name = "btnManageInv"
        Me.btnManageInv.Size = New System.Drawing.Size(160, 32)
        Me.btnManageInv.TabIndex = 1
        Me.btnManageInv.Text = "Manage Inventory"
        Me.btnManageInv.UseVisualStyleBackColor = True
        '
        'btnManageOrders
        '
        Me.btnManageOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrders.Location = New System.Drawing.Point(53, 176)
        Me.btnManageOrders.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnManageOrders.Name = "btnManageOrders"
        Me.btnManageOrders.Size = New System.Drawing.Size(160, 32)
        Me.btnManageOrders.TabIndex = 2
        Me.btnManageOrders.Text = "Manage Orders"
        Me.btnManageOrders.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(263, 305)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(111, 38)
        Me.btnDeleteItem.TabIndex = 4
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeMenu, Me.ExitMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeMenu
        '
        Me.HomeMenu.Name = "HomeMenu"
        Me.HomeMenu.Size = New System.Drawing.Size(52, 20)
        Me.HomeMenu.Text = "Home"
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(38, 20)
        Me.ExitMenu.Text = "Exit"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(551, 305)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(111, 38)
        Me.btnAddItem.TabIndex = 12
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.Location = New System.Drawing.Point(263, 305)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(111, 38)
        Me.btnDeleteOrder.TabIndex = 13
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.UseVisualStyleBackColor = True
        '
        'btnMakeDrink
        '
        Me.btnMakeDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeDrink.Location = New System.Drawing.Point(551, 306)
        Me.btnMakeDrink.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMakeDrink.Name = "btnMakeDrink"
        Me.btnMakeDrink.Size = New System.Drawing.Size(111, 37)
        Me.btnMakeDrink.TabIndex = 14
        Me.btnMakeDrink.Text = "Make Drink"
        Me.btnMakeDrink.UseVisualStyleBackColor = True
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOrder.Location = New System.Drawing.Point(551, 305)
        Me.btnViewOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(111, 38)
        Me.btnViewOrder.TabIndex = 15
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'BartenderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 409)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.btnMakeDrink)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnManageOrders)
        Me.Controls.Add(Me.btnManageInv)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BartenderView"
        Me.Text = "AdminView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnManageInv As Button
    Friend WithEvents btnManageOrders As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeMenu As ToolStripMenuItem
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnMakeDrink As Button
    Friend WithEvents btnViewOrder As Button
End Class
