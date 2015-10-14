<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsCtrl
  Inherits JHSoftware.SimpleDNS.Plugin.OptionsUI 'System.Windows.Forms.UserControl

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
    Me.lstMatch = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.Label1 = New System.Windows.Forms.Label
    Me.btns = New ctlAddEditRemove
    Me.btnUp = New System.Windows.Forms.Button
    Me.btnDown = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'lstMatch
    '
    Me.lstMatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstMatch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
    Me.lstMatch.FullRowSelect = True
    Me.lstMatch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.lstMatch.HideSelection = False
    Me.lstMatch.Location = New System.Drawing.Point(0, 16)
    Me.lstMatch.MultiSelect = False
    Me.lstMatch.Name = "lstMatch"
    Me.lstMatch.Size = New System.Drawing.Size(358, 240)
    Me.lstMatch.TabIndex = 1
    Me.lstMatch.UseCompatibleStateImageBehavior = False
    Me.lstMatch.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Regular Expression"
    Me.ColumnHeader1.Width = 183
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "IP Address"
    Me.ColumnHeader2.Width = 151
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(-3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(316, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Match requested host names against (search stops at first match):"
    '
    'btns
    '
    Me.btns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btns.AutoSize = True
    Me.btns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.btns.EnableEditRemove = False
    Me.btns.Location = New System.Drawing.Point(364, 16)
    Me.btns.Name = "btns"
    Me.btns.Size = New System.Drawing.Size(65, 75)
    Me.btns.TabIndex = 2
    '
    'btnUp
    '
    Me.btnUp.Enabled = False
    Me.btnUp.Location = New System.Drawing.Point(364, 107)
    Me.btnUp.Name = "btnUp"
    Me.btnUp.Size = New System.Drawing.Size(65, 21)
    Me.btnUp.TabIndex = 4
    Me.btnUp.Text = "Up"
    Me.btnUp.UseVisualStyleBackColor = True
    '
    'btnDown
    '
    Me.btnDown.Enabled = False
    Me.btnDown.Location = New System.Drawing.Point(364, 134)
    Me.btnDown.Name = "btnDown"
    Me.btnDown.Size = New System.Drawing.Size(65, 21)
    Me.btnDown.TabIndex = 5
    Me.btnDown.Text = "Down"
    Me.btnDown.UseVisualStyleBackColor = True
    '
    'OptionsCtrl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.btnDown)
    Me.Controls.Add(Me.btnUp)
    Me.Controls.Add(Me.btns)
    Me.Controls.Add(Me.lstMatch)
    Me.Controls.Add(Me.Label1)
    Me.Name = "OptionsCtrl"
    Me.Size = New System.Drawing.Size(429, 256)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstMatch As System.Windows.Forms.ListView
  Friend WithEvents btns As ctlAddEditRemove
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnUp As System.Windows.Forms.Button
  Friend WithEvents btnDown As System.Windows.Forms.Button

End Class
