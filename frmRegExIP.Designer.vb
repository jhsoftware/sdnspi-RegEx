<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegExIP
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
    Me.btnOK = New System.Windows.Forms.Button
    Me.btnCancel = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnTest = New System.Windows.Forms.Button
    Me.txtRegEx = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.CtlTTL1 = New ctlTTL
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnOK
    '
    Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnOK.Location = New System.Drawing.Point(261, 203)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 1
    Me.btnOK.Text = "OK"
    '
    'btnCancel
    '
    Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(342, 203)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 2
    Me.btnCancel.Text = "Cancel"
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.CtlTTL1)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.btnTest)
    Me.GroupBox1.Controls.Add(Me.txtRegEx)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
    Me.GroupBox1.Size = New System.Drawing.Size(405, 185)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Match host name"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(18, 127)
    Me.Label3.Margin = New System.Windows.Forms.Padding(3, 37, 3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(159, 13)
    Me.Label3.TabIndex = 98
    Me.Label3.Text = "Host record TTL (Time To Live):"
    '
    'btnTest
    '
    Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnTest.Location = New System.Drawing.Point(330, 37)
    Me.btnTest.Name = "btnTest"
    Me.btnTest.Size = New System.Drawing.Size(57, 23)
    Me.btnTest.TabIndex = 2
    Me.btnTest.Text = "Test..."
    Me.btnTest.UseVisualStyleBackColor = True
    '
    'txtRegEx
    '
    Me.txtRegEx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtRegEx.Location = New System.Drawing.Point(18, 39)
    Me.txtRegEx.Name = "txtRegEx"
    Me.txtRegEx.Size = New System.Drawing.Size(306, 20)
    Me.txtRegEx.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(18, 77)
    Me.Label2.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(236, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Respond with host record pointing to IP address:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(18, 23)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(282, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "If requested domain name matches this regular expression:"
    '
    'CtlTTL1
    '
    Me.CtlTTL1.AutoSize = True
    Me.CtlTTL1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.CtlTTL1.BackColor = System.Drawing.Color.Transparent
    Me.CtlTTL1.Location = New System.Drawing.Point(21, 143)
    Me.CtlTTL1.Name = "CtlTTL1"
    Me.CtlTTL1.ReadOnly = False
    Me.CtlTTL1.Size = New System.Drawing.Size(156, 21)
    Me.CtlTTL1.TabIndex = 99
    Me.CtlTTL1.Value = 1800
    '
    'frmRegExIP
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.ClientSize = New System.Drawing.Size(429, 238)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnOK)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmRegExIP"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Match host name"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtRegEx As System.Windows.Forms.TextBox
  Friend WithEvents btnTest As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents CtlTTL1 As ctlTTL

End Class
