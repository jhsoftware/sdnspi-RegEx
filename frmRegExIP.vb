Imports System.Windows.Forms

Public Class frmRegExIP

  Friend IPCtrl As Windows.Forms.Control
  Private LastTestStr As String = ""

  Private Sub frmRegExIP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    IPCtrl.Location = New Drawing.Point(txtRegEx.Left, Label2.Bottom + Label2.Margin.Bottom)
    GroupBox1.Controls.Add(IPCtrl)
    IPCtrl.TabIndex = Label2.TabIndex + 1
  End Sub

  Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
    If txtRegEx.Text.Trim.Length = 0 Then
      MessageBox.Show("Regular Expression is empty", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End If
    Dim rx As System.Text.RegularExpressions.Regex
    Try
      rx = New System.Text.RegularExpressions.Regex(txtRegEx.Text.Trim)
    Catch ex As Exception
      MessageBox.Show("Invalid regular expression", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End Try

    Dim s As String = InputBox("Enter domain name to test:", "Test Regular Expression", LastTestStr)
    If s.Length = 0 Then Exit Sub
    LastTestStr = s.Trim.ToLower

    If rx.IsMatch(LastTestStr) Then
      MessageBox.Show("TEST SUCCESSFUL" & vbCrLf & vbCrLf & _
                      "Domain name matches regular expression", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("TEST FAILED" & vbCrLf & vbCrLf & _
                      "Domain name does NOT match regular expression", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    If txtRegEx.Text.Trim.Length = 0 Then
      MessageBox.Show("Regular Expression is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End If
    Dim rx As System.Text.RegularExpressions.Regex
    Try
      rx = New System.Text.RegularExpressions.Regex(txtRegEx.Text)
    Catch ex As Exception
      MessageBox.Show("Invalid regular expression", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End Try
    If IPCtrl.Text.Length = 0 Then
      MessageBox.Show("IP address is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      IPCtrl.Focus()
      Exit Sub
    End If
    Dim ip As System.Net.IPAddress
    If Not System.Net.IPAddress.TryParse(IPCtrl.Text, ip) Then
      MessageBox.Show("Invalid IP address", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      IPCtrl.Focus()
      Exit Sub
    End If

    DialogResult = Windows.Forms.DialogResult.OK
  End Sub
End Class
