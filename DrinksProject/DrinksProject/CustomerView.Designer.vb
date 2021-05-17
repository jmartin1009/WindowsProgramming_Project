<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerView
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
        Me.btnPastOrders = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnOrderDrink = New System.Windows.Forms.Button()
        Me.cbIngredientTypes = New System.Windows.Forms.ComboBox()
        Me.dgvDrink = New System.Windows.Forms.DataGridView()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(263, 35)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(399, 240)
        Me.DataGridView1.TabIndex = 0
        '
        'btnPastOrders
        '
        Me.btnPastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastOrders.Location = New System.Drawing.Point(53, 176)
        Me.btnPastOrders.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPastOrders.Name = "btnPastOrders"
        Me.btnPastOrders.Size = New System.Drawing.Size(160, 32)
        Me.btnPastOrders.TabIndex = 2
        Me.btnPastOrders.Text = "View Past Orders"
        Me.btnPastOrders.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(263, 305)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(2)
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
        Me.btnAddItem.Location = New System.Drawing.Point(409, 305)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(111, 38)
        Me.btnAddItem.TabIndex = 12
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnOrderDrink
        '
        Me.btnOrderDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderDrink.Location = New System.Drawing.Point(551, 306)
        Me.btnOrderDrink.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderDrink.Name = "btnOrderDrink"
        Me.btnOrderDrink.Size = New System.Drawing.Size(111, 37)
        Me.btnOrderDrink.TabIndex = 14
        Me.btnOrderDrink.Text = "Order Drink"
        Me.btnOrderDrink.UseVisualStyleBackColor = True
        '
        'cbIngredientTypes
        '
        Me.cbIngredientTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIngredientTypes.FormattingEnabled = True
        Me.cbIngredientTypes.Location = New System.Drawing.Point(53, 102)
        Me.cbIngredientTypes.Margin = New System.Windows.Forms.Padding(2)
        Me.cbIngredientTypes.Name = "cbIngredientTypes"
        Me.cbIngredientTypes.Size = New System.Drawing.Size(161, 28)
        Me.cbIngredientTypes.TabIndex = 15
        '
        'dgvDrink
        '
        Me.dgvDrink.AllowUserToAddRows = False
        Me.dgvDrink.AllowUserToDeleteRows = False
        Me.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDrink.Location = New System.Drawing.Point(33, 256)
        Me.dgvDrink.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDrink.Name = "dgvDrink"
        Me.dgvDrink.RowHeadersWidth = 51
        Me.dgvDrink.RowTemplate.Height = 24
        Me.dgvDrink.Size = New System.Drawing.Size(180, 122)
        Me.dgvDrink.TabIndex = 16
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOrder.Location = New System.Drawing.Point(53, 176)
        Me.btnViewOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(160, 32)
        Me.btnViewOrder.TabIndex = 17
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'CustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 409)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.dgvDrink)
        Me.Controls.Add(Me.cbIngredientTypes)
        Me.Controls.Add(Me.btnOrderDrink)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnPastOrders)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CustomerView"
        Me.Text = "CustomerView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnPastOrders As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeMenu As ToolStripMenuItem
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnOrderDrink As Button
    Friend WithEvents cbIngredientTypes As ComboBox
    Friend WithEvents dgvDrink As DataGridView
    Friend WithEvents btnViewOrder As Button
End Class
