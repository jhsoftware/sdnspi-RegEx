<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAddEditRemove
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.btnAdd = New System.Windows.Forms.Button
    Me.btnEdit = New System.Windows.Forms.Button
    Me.btnRemove = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnAdd
    '
    Me.btnAdd.Location = New System.Drawing.Point(0, 0)
    Me.btnAdd.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(65, 21)
    Me.btnAdd.TabIndex = 0
    Me.btnAdd.Text = "Add..."
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'btnEdit
    '
    Me.btnEdit.Enabled = False
    Me.btnEdit.Location = New System.Drawing.Point(0, 27)
    Me.btnEdit.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(65, 21)
    Me.btnEdit.TabIndex = 1
    Me.btnEdit.Text = "Edit..."
    Me.btnEdit.UseVisualStyleBackColor = True
    '
    'btnRemove
    '
    Me.btnRemove.Enabled = False
    Me.btnRemove.Location = New System.Drawing.Point(0, 54)
    Me.btnRemove.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(65, 21)
    Me.btnRemove.TabIndex = 2
    Me.btnRemove.Text = "Remove"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'ctlAddEditRemove
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.btnEdit)
    Me.Controls.Add(Me.btnAdd)
    Me.Name = "ctlAddEditRemove"
    Me.Size = New System.Drawing.Size(65, 75)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents btnEdit As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class
