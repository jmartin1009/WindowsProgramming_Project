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
        Me.cbPortions = New System.Windows.Forms.ComboBox()
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
        Me.DataGridView1.Location = New System.Drawing.Point(351, 43)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(532, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'btnPastOrders
        '
        Me.btnPastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastOrders.Location = New System.Drawing.Point(71, 217)
        Me.btnPastOrders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPastOrders.Name = "btnPastOrders"
        Me.btnPastOrders.Size = New System.Drawing.Size(213, 39)
        Me.btnPastOrders.TabIndex = 2
        Me.btnPastOrders.Text = "View Past Orders"
        Me.btnPastOrders.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(351, 375)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(148, 47)
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 28)
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
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(545, 375)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(148, 47)
        Me.btnAddItem.TabIndex = 12
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnOrderDrink
        '
        Me.btnOrderDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderDrink.Location = New System.Drawing.Point(735, 377)
        Me.btnOrderDrink.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOrderDrink.Name = "btnOrderDrink"
        Me.btnOrderDrink.Size = New System.Drawing.Size(148, 46)
        Me.btnOrderDrink.TabIndex = 14
        Me.btnOrderDrink.Text = "Order Drink"
        Me.btnOrderDrink.UseVisualStyleBackColor = True
        '
        'cbIngredientTypes
        '
        Me.cbIngredientTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIngredientTypes.FormattingEnabled = True
        Me.cbIngredientTypes.Location = New System.Drawing.Point(69, 102)
        Me.cbIngredientTypes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbIngredientTypes.Name = "cbIngredientTypes"
        Me.cbIngredientTypes.Size = New System.Drawing.Size(213, 33)
        Me.cbIngredientTypes.TabIndex = 15
        Me.cbIngredientTypes.Text = "Ingredients"
        '
        'dgvDrink
        '
        Me.dgvDrink.AllowUserToAddRows = False
        Me.dgvDrink.AllowUserToDeleteRows = False
        Me.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDrink.Location = New System.Drawing.Point(44, 315)
        Me.dgvDrink.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDrink.Name = "dgvDrink"
        Me.dgvDrink.RowHeadersVisible = False
        Me.dgvDrink.RowHeadersWidth = 51
        Me.dgvDrink.RowTemplate.Height = 24
        Me.dgvDrink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDrink.Size = New System.Drawing.Size(240, 150)
        Me.dgvDrink.TabIndex = 16
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOrder.Location = New System.Drawing.Point(71, 217)
        Me.btnViewOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(213, 39)
        Me.btnViewOrder.TabIndex = 17
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'cbPortions
        '
        Me.cbPortions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPortions.FormattingEnabled = True
        Me.cbPortions.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbPortions.Location = New System.Drawing.Point(69, 142)
        Me.cbPortions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPortions.Name = "cbPortions"
        Me.cbPortions.Size = New System.Drawing.Size(213, 33)
        Me.cbPortions.TabIndex = 18
        Me.cbPortions.Text = "Portions"
        '
        'CustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 503)
        Me.Controls.Add(Me.cbPortions)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.dgvDrink)
        Me.Controls.Add(Me.cbIngredientTypes)
        Me.Controls.Add(Me.btnOrderDrink)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnPastOrders)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents cbPortions As ComboBox
End Class
