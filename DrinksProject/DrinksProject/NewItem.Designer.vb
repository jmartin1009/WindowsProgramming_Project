<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewItem
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
        Me.cbItems = New System.Windows.Forms.ComboBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.tbItem = New System.Windows.Forms.TextBox()
        Me.cbPortion = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbItems
        '
        Me.cbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Location = New System.Drawing.Point(29, 137)
        Me.cbItems.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbItems.Name = "cbItems"
        Me.cbItems.Size = New System.Drawing.Size(146, 28)
        Me.cbItems.TabIndex = 0
        Me.cbItems.Text = "Ingredient Types"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(416, 162)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(146, 24)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(155, 36)
        Me.lblAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(298, 37)
        Me.lblAdd.TabIndex = 2
        Me.lblAdd.Text = "Add New Ingredient"
        '
        'tbItem
        '
        Me.tbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbItem.Location = New System.Drawing.Point(218, 162)
        Me.tbItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(146, 26)
        Me.tbItem.TabIndex = 3
        Me.tbItem.Text = "Name"
        '
        'cbPortion
        '
        Me.cbPortion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPortion.FormattingEnabled = True
        Me.cbPortion.Location = New System.Drawing.Point(29, 188)
        Me.cbPortion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPortion.Name = "cbPortion"
        Me.cbPortion.Size = New System.Drawing.Size(146, 28)
        Me.cbPortion.TabIndex = 4
        Me.cbPortion.Text = "Portions"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeMenu, Me.ExitMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(499, 36)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 27)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'NewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cbPortion)
        Me.Controls.Add(Me.tbItem)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.cbItems)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NewItem"
        Me.Text = "NewItem"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbItems As ComboBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents tbItem As TextBox
    Friend WithEvents cbPortion As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeMenu As ToolStripMenuItem
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents btnReturn As Button
End Class
